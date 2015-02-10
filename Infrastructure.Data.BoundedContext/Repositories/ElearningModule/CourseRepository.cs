namespace Infrastructure.Data.BoundedContext.ElearningModule
{
    using Domain.BoundedContext.ElearningModule;
    using Infrastructure.CrossCutting.Core;
    using Infrastructure.Data.BoundedContext.UnitOfWork;
    using Infrastructure.Data.Core;
    /// <summary>
    /// The Course repository implementation
    /// </summary>
    public class CourseRepository
        : Repository<Course>, ICourseRepository
    {
        #region Constructor

        /// <summary>
        /// Create a new instance
        /// </summary>
        /// <param name="unitOfWork">Associated unit of work</param>
        /// <param name="logger">Associated logger</param>
        public CourseRepository(IMainBCUnitOfWork unitOfWork, ILogger logger)
            : base(unitOfWork, logger)
        {
        }

        #endregion
    }
}
