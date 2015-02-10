namespace Application.BoundedConext.Tests.Managers
{
    using Application.BoundedConext.Blob;
    using Domain.BoundedContext.BlobAggregates;
    using Infrastructure.CrossCutting.IoC;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Microsoft.WindowsAzure.Storage;
    using System.IO;
    using System.Linq;
    using System.Threading.Tasks;

    [TestClass]
    [DeploymentItem(@"TestFiles\TestImage.jpg")]
    public class BlobManagementServicesTests
    {



        [TestMethod]
        public async Task  BlobManagementServicesTests_Should_upload_ExistingFile()
        {
            BlobAggregate blob = new BlobAggregate();
            blob.FileName = "TestImage.jpg";
            blob.DirectoryName = "TestFiles";
            blob.Content = File.OpenRead(@"TestImage.jpg");

            IBlobManagementServices manager = IoCFactory.Instance.CurrentContainer.Resolve<IBlobManagementServices>();
           await manager.UploadBlobAsync(blob);

           Assert.IsNotNull(blob);
           
        }





        [TestMethod]
        public async Task BlobManagementServicesTests_Should_upload_ListeOfValidFiles()
        {
            //Arrange
            IBlobManagementServices manager = IoCFactory.Instance.CurrentContainer.Resolve<IBlobManagementServices>();
            string rootPath= @"C:\LMS\Trunk\LMS\ASP.NET.MVC5.Client\App_JS\compounents\collegeGreen\images";
            string imagesPath = @"App_JS\compounents\collegeGreen\images";
            //Act
            var images = System.IO.Directory.GetFiles(rootPath)
                        .Select(x => new BlobAggregate()
                        {
                            ContainerName = "static-content",
                            DirectoryName = imagesPath,
                            FileName = System.IO.Path.GetFileName(x),
                            Content = System.IO.File.OpenRead(x)
                        });
           await  manager.UploadBlobAsync(images);
            //Assert
           Assert.IsNotNull(images);

        }

    }
}
