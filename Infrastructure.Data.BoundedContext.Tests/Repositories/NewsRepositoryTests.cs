// Decompiled with JetBrains decompiler
// Type: Infrastructure.Data.BoundedContext.tests.Membership.NewsRepositoryTests
// Assembly: Infrastructure.Data.BoundedContext.tests, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EC499FDF-797A-4D00-802C-5AFEB6A1772B
// Assembly location: C:\Pedago\Solution1\Infrastructure.Data.BoundedContext.tests\bin\Debug\Infrastructure.Data.BoundedContext.tests.dll

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain.BoundedContext.BlogingModule;
using Infrastructure.CrossCutting.IoC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace Infrastructure.Data.BoundedContext.tests.Membership
{
    [TestClass]
    public class NewsRepositoryTests
    {
        [TestMethod]
        public void NewsRepository_GetElementByIdValidIdTest()
        {
            Guid id = new Guid("b35369e3-ac21-c8aa-e553-08d1ca783d33");
            News byId = IoCFactory.Instance.CurrentContainer.Resolve<INewsRepository>().GetElementById(id);
            Assert.IsNotNull((object)byId);
            Assert.IsTrue(byId.Id == id);
        }

        [TestMethod]
        public async Task NewsRepository_GetElementByIdAsyncIdTest()
        {
            Guid id = new Guid("b35369e3-ac21-c8aa-e553-08d1ca783d33");
            INewsRepository repo = IoCFactory.Instance.CurrentContainer.Resolve<INewsRepository>();
            News nws = await repo.GetElementByIdAsync(id, new CancellationToken());
            Assert.IsNotNull((object)nws);
            Assert.IsTrue(nws.Id == id);
        }

        [TestMethod]
        public void NewsRepository_GetAllElementsTest()
        {
            IQueryable<News> all = IoCFactory.Instance.CurrentContainer.Resolve<INewsRepository>().GetAllElements();
            Assert.IsNotNull((object)all);
            Assert.IsTrue(Queryable.Count<News>(all) > 0);
        }

        [TestMethod]
        public void NewsRepository_AddTest_ValidNews()
        {
            INewsRepository newsRepository = IoCFactory.Instance.CurrentContainer.Resolve<INewsRepository>();
            newsRepository.UnitOfWork.RollbackChanges();
            News news1 = new News()
            {
                Id = new Guid("1cd1ae08-8e48-c902-0147-08d1ca79fb6a"),
                Title = "test title",
                Summary = "test Texte"
            };
            //news1.Image = "test Image";
            newsRepository.Add(news1);
            newsRepository.UnitOfWork.Commit();
            News byId = newsRepository.GetElementById(news1.Id);
            Assert.IsNotNull((object)byId);
            Assert.IsTrue(byId.Id == news1.Id);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void NewsRepository_AddTest_InValidNews()
        {
            INewsRepository newsRepository = IoCFactory.Instance.CurrentContainer.Resolve<INewsRepository>();
            News news = new News()
            {
                Title = null,
                Summary = "",
                //Image = "test Image"
            };
            newsRepository.Add(news);
            newsRepository.UnitOfWork.CommitAndRefreshChanges();
        }

        [TestMethod]
        public void NewsRepository_RemoveTest()
        {
            INewsRepository newsRepository = IoCFactory.Instance.CurrentContainer.Resolve<INewsRepository>();
            Guid id = new Guid("edc8b9d1-eb59-c66f-4c6c-08d1ca7a6897");
            News byId = newsRepository.GetElementById(id);
            Assert.IsNotNull(byId);
            newsRepository.Remove(byId);
            newsRepository.UnitOfWork.CommitAndRefreshChanges();
            News dbnews = newsRepository.GetElementById(byId.Id);
            Assert.IsNull(dbnews);
        }

        [TestMethod]
        public void NewsRepository_ModifyTest()
        {
            INewsRepository newsRepository = IoCFactory.Instance.CurrentContainer.Resolve<INewsRepository>();
            Guid id = new Guid("91ec4896-974f-cfc9-2d02-08d1ca7c9850");
            News byId1 = newsRepository.GetElementById(id);
            Assert.IsNotNull((object)byId1);
            byId1.Title = "Modified";
            newsRepository.SetModified(byId1);
            newsRepository.UnitOfWork.CommitAndRefreshChanges();
            News byId2 = newsRepository.GetElementById(byId1.Id);
            Assert.IsNotNull(byId2);
            Assert.IsTrue(byId2.Title == "Modified");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void NewsRepository_ModifyInvalidTest()
        {
            INewsRepository newsRepository = IoCFactory.Instance.CurrentContainer.Resolve<INewsRepository>();
            Guid id = new Guid("91ec4896-974f-cfc9-2d02-08d1ca7c9850");
            News byId1 = newsRepository.GetElementById(id);
            Assert.IsNotNull(byId1);

            byId1.Title = null;

            newsRepository.SetModified(byId1);
            newsRepository.UnitOfWork.CommitAndRefreshChanges();
        }


        [TestMethod]
        public void NewsRepository_GetFilteredElementsTest()
        {
            INewsRepository newsRepository = IoCFactory.Instance.CurrentContainer.Resolve<INewsRepository>();
            Guid id = new Guid("b35369e3-ac21-c8aa-e553-08d1ca783d33");
            IEnumerable<News> filteredElements = newsRepository.GetFilteredElements((x => x.Id == id));
            Assert.IsNotNull((object)filteredElements);
            Assert.IsTrue(Enumerable.Count<News>(filteredElements) == 1);
            Assert.IsTrue(Enumerable.First<News>(filteredElements).Id == id);
        }

        [TestMethod]
        public void NewsRepository_GetFilteredElementsTest_nonexisting()
        {
            INewsRepository newsRepository = IoCFactory.Instance.CurrentContainer.Resolve<INewsRepository>();
            string uTitle = "aaaaxxxx";
            IEnumerable<News> filteredElements = newsRepository.GetFilteredElements((u => u.Title != (object)null && u.Title.ToLower() == uTitle.ToLower()));
            Assert.IsNotNull((object)filteredElements);
            Assert.IsTrue(Enumerable.Count<News>(filteredElements) == 0);
        }

        [TestMethod]
        public void NewsRepository_GetFilteredElementsTest_existing()
        {
            INewsRepository newsRepository = IoCFactory.Instance.CurrentContainer.Resolve<INewsRepository>();
            string uTitle = "Phasellus scelerisque metus";
            IEnumerable<News> filteredElements = newsRepository.GetFilteredElements((u => u.Title != (object)null && u.Title.ToLower() == uTitle.ToLower()));
            Assert.IsNotNull((object)filteredElements);
            Assert.IsTrue(Enumerable.Count<News>(filteredElements) == 1);
            Assert.IsTrue(Enumerable.First<News>(filteredElements).Title == uTitle);
        }

        [TestMethod]
        public async Task NewsRepository_GetFilteredElementsAsyncTest_nonexisting()
        {
            INewsRepository repo = IoCFactory.Instance.CurrentContainer.Resolve<INewsRepository>();
            string uTitle = "aaaaxxxx";
            IEnumerable<News> posistions = await repo.GetFilteredElementsAsync((u => u.Title != (object)null && u.Title.ToLower() == uTitle.ToLower()), new CancellationToken());
            Assert.IsNotNull((object)posistions);
            Assert.IsTrue(Enumerable.Count<News>(posistions) == 0);
        }

        [TestMethod]
        public async Task NewsRepository_GetFilteredElementsAsyncTest_existing()
        {
            INewsRepository repo = IoCFactory.Instance.CurrentContainer.Resolve<INewsRepository>();
            string uTitle = "Phasellus scelerisque metus";
            IEnumerable<News> posistions = await repo.GetFilteredElementsAsync((u => u.Title != (object)null && u.Title.ToLower() == uTitle.ToLower()), new CancellationToken());
            Assert.IsNotNull((object)posistions);
            Assert.IsTrue(Enumerable.Count<News>(posistions) == 1);
            Assert.IsTrue(Enumerable.First<News>(posistions).Title == uTitle);
        }

        [TestMethod]
        public void NewsRepository_GetPagedTest()
        {
            IEnumerable<News> paged = IoCFactory.Instance.CurrentContainer.Resolve<INewsRepository>().GetPagedElements<string>(0, 3, (x => x.Title), 1 != 0);
            Assert.IsNotNull((object)paged);
            Assert.IsTrue(Enumerable.Count<News>(paged) == 3);
        }

        [TestMethod]
        public async Task NewsRepository_GetFirstOrDefaultAsyncTest_ExistingNews()
        {
            INewsRepository repo = IoCFactory.Instance.CurrentContainer.Resolve<INewsRepository>();
            string uTitle = "Phasellus scelerisque metus";
            News pos = await repo.GetFirstOrDefaultAsync((u => u.Title != (object)null && u.Title.ToLower() == uTitle.ToLower()), new CancellationToken());
            Assert.IsNotNull((object)pos);
            Assert.IsTrue(pos.Title.Equals(uTitle, StringComparison.InvariantCultureIgnoreCase));
        }


        [TestMethod]
        public async Task NewsRepository_GetFirstOrDefaultAsyncTest_NullFilter()
        {
            INewsRepository repo = IoCFactory.Instance.CurrentContainer.Resolve<INewsRepository>();
            News pos = await repo.GetFirstOrDefaultAsync(null, new CancellationToken());
            Assert.IsNotNull((object)pos);
        }

        [TestMethod]
        public async Task NewsRepository_GetFirstOrDefaultAsyncTest_InvalidUNews()
        {
            INewsRepository repo = IoCFactory.Instance.CurrentContainer.Resolve<INewsRepository>();
            string uTitle = "cccccccccccccccc";
            News user = await repo.GetFirstOrDefaultAsync((u => u.Title != (object)null && u.Title.ToLower() == uTitle.ToLower()), new CancellationToken());
            Assert.IsNull((object)user);
        }
    }
}
