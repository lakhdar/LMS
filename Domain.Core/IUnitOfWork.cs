namespace Domain.Core
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Contract for ‘UnitOfWork pattern’. For more
    /// This interface/contract should be complied by any UoW implementation to be used with this Domain.
    /// </summary>
    public interface IUnitOfWork
        : IDisposable
    {
        /// <summary>
        /// Commit all changes made in a container.
        /// </summary>
        ///<remarks>
        /// If the entity have fixed properties and any optimistic concurrency problem exists,  
        /// then an exception is thrown
        ///</remarks>
        void Commit();

        /// <summary>
        /// Commit all changes made in  a container.
        /// </summary>
        ///<remarks>
        /// If the entity have fixed properties and any optimistic concurrency problem exists,
        /// then 'client changes' are refreshed - Client wins
        ///</remarks>
        void CommitAndRefreshChanges();

        /// <summary>
        /// Rollback changes are not stored in the database at 
        /// this moment. See references of UnitOfWork pattern
        /// </summary>
        void RollbackChanges();

        /// <summary>
        /// Commit all changes made in a container Async.
        /// </summary>
        ///<remarks>
        /// If the entity have fixed properties and any optimistic concurrency problem exists,  
        /// then an exception is thrown
        ///</remarks>
        Task CommitAsync( CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Commit all changes made in  a container Async.
        /// </summary>
        ///<remarks>
        /// If the entity have fixed properties and any optimistic concurrency problem exists,
        /// then 'client changes' are refreshed - Client wins
        ///</remarks>
        Task CommitAndRefreshChangesAsync(CancellationToken cancellationToken = default(CancellationToken));
    }
}
/*
/p:DeployOnBuild=True /p:DeployTarget=MsDeployPublish /p:CreatePackageOnPublish=True  /p:MSDeployPublishMethod=InProc /p:SkipExtraFilesOnServer=True/p:recycleApp="Default Web Site/LMS"  /p:DeployIisAppPath="Default Web Site/LMS" /p:MsDeployServiceUrl=localhost

/p:DeployOnBuild=True;DeployTarget=MSDeployPublish;CreatePackageOnPublish=True;MSDeployPublishMethod=InProc;MsDeployServiceUrl=pc-window81;DeployIisAppPath="Default Web Site/LMS";VisualStudioVersion=11.0;
*/