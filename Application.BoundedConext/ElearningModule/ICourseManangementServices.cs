namespace Application.BoundedConext.ElearningModule
{
    using Domain.BoundedContext.ElearningModule;
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    public interface ICourseManangementServices
    {

        Task<Course> GetCourseByIdAsync(Guid id, CancellationToken cancellationToken = default(CancellationToken));
    }
}
