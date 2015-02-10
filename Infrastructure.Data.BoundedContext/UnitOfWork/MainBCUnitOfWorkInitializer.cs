using Domain.BoundedContext.BlogingModule;
using Domain.BoundedContext.ERPModule;
using Domain.BoundedContext.MembershipModule;
using System.Data.Entity;

namespace Infrastructure.Data.BoundedContext.UnitOfWork 
{
    public class MainBCUnitOfWorkInitializer : DropCreateDatabaseAlways<MainBCUnitOfWork>
    {
        protected override void Seed(MainBCUnitOfWork unitOfWork)
        {
            InitialMemorySet initialMemorySet = new InitialMemorySet();
            foreach (Customer entity in initialMemorySet.Customers)
                unitOfWork.Customers.Add(entity);
            foreach (User entity in initialMemorySet.Users)
                unitOfWork.Users.Add(entity);
            foreach (News entity in initialMemorySet.News)
                unitOfWork.News.Add(entity);
            unitOfWork.Commit();
        }
    }
}
