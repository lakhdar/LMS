using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain.BoundedContext.ERPModule;
using Infrastructure.CrossCutting.IoC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Infrastructure.Data.BoundedContext.tests
{
    [TestClass]
    public class PositionRepositoryTests
    {
        [TestMethod]
        public void PositionRepository_GetElementByIdValidIdTest()
        {
            Guid id = new Guid("5a0971d4-3205-ce80-fa51-08d1b453d5ac");
            Position byId = IoCFactory.Instance.CurrentContainer.Resolve<IPositionRepository>().GetElementById(id);
            Assert.IsNotNull((object)byId);
            Assert.IsTrue(byId.Id == id);
        }

        [TestMethod]
        public void PositionRepository_GetAllElementsTest()
        {
            IQueryable<Position> all = IoCFactory.Instance.CurrentContainer.Resolve<IPositionRepository>().GetAllElements();
            Assert.IsNotNull((object)all);
            Assert.IsTrue(Queryable.Count<Position>(all) > 0);
        }

        [TestMethod]
        public void PositionRepository_AddTest()
        {
            IPositionRepository positionRepository = IoCFactory.Instance.CurrentContainer.Resolve<IPositionRepository>();
            Position position1 = new Position() 
            { 
               Id = new Guid("0c11fc14-c881-c335-e1e8-08d1b45385cd"),
               Title = "testPosition"
            };

            positionRepository.Add(position1);
            positionRepository.UnitOfWork.Commit();
            Position byId = positionRepository.GetElementById(position1.Id);
            Assert.IsNotNull((object)byId);
            Assert.IsTrue(byId.Id == position1.Id);
        }

        [TestMethod]
        public void PositionRepository_RemoveTest()
        {
            IPositionRepository positionRepository = IoCFactory.Instance.CurrentContainer.Resolve<IPositionRepository>();
            Guid id = new Guid("ff9b26b1-8c8c-c649-318e-08d1e2d77734");
            Position byId = positionRepository.GetElementById(id);
            positionRepository.Remove(byId);
            positionRepository.UnitOfWork.Commit();
            Assert.IsNull((object)positionRepository.GetElementById(byId.Id));
        }

        [TestMethod]
        public void PositionRepository_ModifyTest()
        {
            IPositionRepository positionRepository = IoCFactory.Instance.CurrentContainer.Resolve<IPositionRepository>();
            Guid id = new Guid("ba9fdac0-6fdb-c65c-73fa-08d1c048b23e");
            Position byId1 = positionRepository.GetElementById(id);
            Assert.IsNotNull((object)byId1);
            byId1.Title = "Modified";
            positionRepository.SetModified(byId1);
            positionRepository.UnitOfWork.Commit();
            Position byId2 = positionRepository.GetElementById(byId1.Id);
            Assert.IsNotNull((object)byId2);
            Assert.IsTrue(byId2.Title == "Modified");
        }

        [TestMethod]
        public void PositionRepository_GetFilteredTest()
        {
            IPositionRepository positionRepository = IoCFactory.Instance.CurrentContainer.Resolve<IPositionRepository>();
            string title = "Owner";
            IEnumerable<Position> filteredElements = positionRepository.GetFilteredElements((x => x.Title != (object)null && x.Title.ToLower() == title.ToLower()));
            Assert.IsNotNull((object)filteredElements);
            Assert.IsTrue(Enumerable.Count<Position>(filteredElements) == 1);
            Assert.IsTrue(Enumerable.First<Position>(filteredElements).Title == title);
        }

        [TestMethod]
        public void PositionRepository_GetPagedTest()
        {
            IEnumerable<Position> paged = IoCFactory.Instance.CurrentContainer.Resolve<IPositionRepository>().GetPagedElements<string>(0, 3, (x => x.Title), 1 != 0);
            Assert.IsNotNull((object)paged);
            Assert.IsTrue(Enumerable.Count<Position>(paged) >= 2 && Enumerable.Count<Position>(paged) <= 4);
        }
    }
}
