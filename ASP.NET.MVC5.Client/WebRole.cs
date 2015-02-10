
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Web;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Diagnostics;
using Microsoft.WindowsAzure.Diagnostics.Management;
using Microsoft.WindowsAzure.ServiceRuntime;
using Microsoft.WindowsAzure.Storage;

namespace ASP.NET.MVC5.Client
{
    public class WebRole : RoleEntryPoint
    {
        public const string WADConnectionString = "Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString";
        public const string WADPerformanceCountersTable = "WADPerformanceCountersTable";

        /// <summary>
        /// The string used to separate performance counter specifiers in the
        /// WebRolePerfCounterConfig entry in the service configuration file.
        /// </summary>
        public const string ConfigSeparator = ";;";

        /// <summary>
        /// The entries in the configuration file for performance counters.
        /// </summary>
        public const string WebRoleConfigName = "WebRolePerfCounterConfig";
        public const string WebRolePeriodName = "WebRolePerfCounterTransferPeriod";
        public const string WebRoleSampleRateName = "WebRolePerfCounterSampleRate";

        /// <summary>
        /// The strings for custom category creation and usage.
        /// </summary>
        public const string CustomCounterCategory = "SampleCustomCategory";
        public const string CustomCounterCategoryDescription = "A custom counter category that tracks user interactions";
        public const string CustomCounter1Name = "Total Button1 Clicks";
        public const string CustomCounter1Description = "Total number of times button1 clicked by users.";
        public const string CustomCounter1 = @"\" + CustomCounterCategory + @"\" + CustomCounter1Name;
        public const string CustomCounter2Name = "Total Button2 Clicks";
        public const string CustomCounter2Description = "Total number of times button1 clicked by users.";
        public const string CustomCounter2 = @"\" + CustomCounterCategory + @"\" + CustomCounter2Name;

        /// <summary>
        /// Array of ConfigurationSettings setting names that will not force the role to be recycled when changed.
        /// </summary>
        private static string[] nonRecycleConfigurationItems = new[]
            {
                WebRoleConfigName, WebRolePeriodName, WebRoleSampleRateName
            };

        /// <summary>
        /// Override the OnStart handler to add our event handlers for RoleEnvironment changes and
        /// to initialize the PerformanceCounters as part of the Diagnostic Monitor configuration.
        /// </summary>
        /// <returns>Returns true if initialization succeeds, otherwise false.</returns>
        public override bool OnStart()
        {
            // Setup to handle service configuration changes at runtime.
            // For information on handling configuration changes
            // see the MSDN topic at http://go.microsoft.com/fwlink/?LinkId=166357.
            RoleEnvironment.Changing += this.RoleEnvironmentChanging;
            RoleEnvironment.Changed += this.RoleEnvironmentChanged;

            var diagnosticMonitorConfiguration = DiagnosticMonitor.GetDefaultInitialConfiguration();

            // Transfer diagnostic information once every minute.
            TimeSpan transferPeriod = TimeSpan.FromMinutes(1d);
            diagnosticMonitorConfiguration.PerformanceCounters.ScheduledTransferPeriod = transferPeriod;

            // Set the diagnostic monitor configuration.
            DiagnosticMonitor.Start(WADConnectionString, diagnosticMonitorConfiguration);

            // Initialize the custom performance counters.
            InitializeCustomPerformanceCounters();

            // Add the performance counter settings from the ServiceConfiguration.cscfg file.
            ConfigureDiagnostics();

            return base.OnStart();
        }

        /// <summary>
        /// Gets the value of the named setting configured in the ServiceConfiguration.cscfg file.
        /// </summary>
        /// <param name="settingName">The name of the setting.</param>
        /// <returns>The setting value, or string.Empty if the setting is not found.</returns>
        internal static string GetConfigurationSettingValue(string settingName)
        {
            string result;

            try
            {
                result = RoleEnvironment.GetConfigurationSettingValue(settingName);
            }
            catch (RoleEnvironmentException)
            {
                // The setting was not found.
                System.Diagnostics.Trace.WriteLine("WebRole environment diagnostics error: " + settingName + " not found.");
                result = string.Empty;
            }

            return result;
        }

        /// <summary>
        /// Updates the performance counter configuration based on the current list in ServiceConfiguration.cscfg.
        /// </summary>
        private static void ConfigureDiagnostics()
        {
            try
            {
                CloudStorageAccount cloudStorageAccount = CloudStorageAccount.Parse(
                    WebRole.GetConfigurationSettingValue(WADConnectionString));

                var roleInstanceDiagnosticManager = CloudAccountDiagnosticMonitorExtensions.CreateRoleInstanceDiagnosticManager(
                    RoleEnvironment.GetConfigurationSettingValue(WADConnectionString),
                    RoleEnvironment.DeploymentId,
                    RoleEnvironment.CurrentRoleInstance.Role.Name,
                    RoleEnvironment.CurrentRoleInstance.Id);

                var roleDiagnosticMonitorConfiguration = roleInstanceDiagnosticManager.GetCurrentConfiguration();

                // Copy settings from configuration.
                double webRolePeriod;
                if (!double.TryParse(WebRole.GetConfigurationSettingValue(WebRolePeriodName), out webRolePeriod))
                {
                    Trace.WriteLine("WebRole environment diagnostics error: " + WebRolePeriodName + " parse failed.");

                    // Set the default to one minute.
                    webRolePeriod = 1d;
                }

                // Transfer diagnostic information once every webRolePeriod minutes.
                TimeSpan transferPeriod = TimeSpan.FromMinutes(webRolePeriod);
                roleDiagnosticMonitorConfiguration.PerformanceCounters.ScheduledTransferPeriod = transferPeriod;

                double webRoleSampleRate;
                if (!double.TryParse(WebRole.GetConfigurationSettingValue(WebRoleSampleRateName), out webRoleSampleRate))
                {
                    Trace.WriteLine("WebRole environment diagnostics error: " + WebRoleSampleRateName + " parse failed.");

                    // Set the default to ten seconds.
                    webRoleSampleRate = 10d;
                }

                // Remove original performance counters and add new set
                roleDiagnosticMonitorConfiguration.PerformanceCounters.DataSources.Clear();

                string webRoleConfig = WebRole.GetConfigurationSettingValue(WebRoleConfigName);
                string[] separators = new string[] { ConfigSeparator };
                string[] webRoleCounterSpecifiers = webRoleConfig.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                foreach (string specifier in webRoleCounterSpecifiers)
                {
                    roleDiagnosticMonitorConfiguration.PerformanceCounters.DataSources.Add(
                        new PerformanceCounterConfiguration()
                        {
                            CounterSpecifier = specifier,
                            SampleRate = TimeSpan.FromSeconds(webRoleSampleRate)
                        });

                    Trace.WriteLine("WebRole performance counter added: " + specifier);
                }

                roleInstanceDiagnosticManager.SetCurrentConfiguration(roleDiagnosticMonitorConfiguration);
            }
            catch (RoleEnvironmentException rex)
            {
                // The connection string was missing.
                Trace.WriteLine("WebRole environment diagnostics error: " + rex.Message);
            }
            catch (InvalidOperationException iox)
            {
                // Parse of the connection string failed.
                Trace.WriteLine("WebRole environment diagnostics error: " + iox.Message);
            }
        }

        /// <summary>
        /// Initialize custom performance counters for this role.
        /// Note that custom performance counter creation requires elevated priveleges
        /// for the role. A role instance will not initialize successfully on
        /// Windows Azure if these calls are made without elevated priveleges.
        /// If the instance is restarted within the host, or in the development emulator,
        /// the counters will already exist.
        /// </summary>
        private static void InitializeCustomPerformanceCounters()
        {
            if (!PerformanceCounterCategory.Exists(CustomCounterCategory))
            {
                CounterCreationDataCollection counterCollection = new CounterCreationDataCollection();

                // add a counter tracking user button1 clicks
                CounterCreationData operationTotal1 = new CounterCreationData();
                operationTotal1.CounterName = CustomCounter1Name;
                operationTotal1.CounterHelp = CustomCounter1Description;
                operationTotal1.CounterType = PerformanceCounterType.NumberOfItems32;
                counterCollection.Add(operationTotal1);

                // add a counter tracking user button2 clicks
                CounterCreationData operationTotal2 = new CounterCreationData();
                operationTotal2.CounterName = CustomCounter2Name;
                operationTotal2.CounterHelp = CustomCounter2Description;
                operationTotal2.CounterType = PerformanceCounterType.NumberOfItems32;
                counterCollection.Add(operationTotal2);

                PerformanceCounterCategory.Create(
                    CustomCounterCategory,
                    CustomCounterCategoryDescription,
                    PerformanceCounterCategoryType.SingleInstance,
                    counterCollection);

                Trace.WriteLine("Custom counter category created.");
            }
            else
            {
                Trace.WriteLine("Custom counter category already exists.");
            }
        }

        /// <summary>
        /// Check service configuration update for changes that we cannot handle without a recycle.
        /// </summary>
        /// <param name="changes">Collection of changes from RoleEnvironmentChanging event.</param>
        /// <returns>True if a non-handled configuration change was made, requiring a role recycle.</returns>
        private bool RecycleConfiguration(ReadOnlyCollection<RoleEnvironmentChange> changes)
        {
            Func<RoleEnvironmentConfigurationSettingChange, bool> changeForcesRecycle =
                    x => !nonRecycleConfigurationItems.Contains(x.ConfigurationSettingName);

            return changes.OfType<RoleEnvironmentConfigurationSettingChange>().Any(changeForcesRecycle);
        }

        /// <summary>
        /// Event handler called when an environment change is to be applied to the role.
        /// Determines whether or not the role instance must be recycled.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The list of changed environment values.</param>
        private void RoleEnvironmentChanging(object sender, RoleEnvironmentChangingEventArgs e)
        {
            // If Azure should recycle the role, e.Cancel should be set to true.
            // If the changes are ones we can handle without a recycle, we set it to false.
            e.Cancel = this.RecycleConfiguration(e.Changes);
            Trace.WriteLine("WebRole environment change - role instance recycling: " + e.Cancel.ToString());
        }

        /// <summary>
        /// Event handler called after an environment change has been applied to the role.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The list of changed environment values.</param>
        private void RoleEnvironmentChanged(object sender, RoleEnvironmentChangedEventArgs e)
        {
            // Refresh the settings defined in ServiceConfiguration.cscfg.
            ConfigureDiagnostics();
        }
    }
}