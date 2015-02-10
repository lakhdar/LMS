
namespace Application.BoundedConext.ElearningModule
{
    using Domain.BoundedContext.ElearningModule;
    using Infrastructure.CrossCutting.Core;
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    public class CourseManangementServices : ICourseManangementServices
    {
        private ICourseRepository _courseRepository;
        private ILogger _logger;

        public CourseManangementServices(ICourseRepository courseRepository, ILogger logger)
        {
            if (courseRepository == null)
                throw new ArgumentNullException("courseRepository");
            if (logger == null)
                throw new ArgumentNullException("logger");
            this._courseRepository = courseRepository;
            this._logger = logger;
        }

        public Task<Course> GetCourseByIdAsync(Guid id, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this._courseRepository.GetElementByIdAsync(id, cancellationToken);
        }
    }
}
