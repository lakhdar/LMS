namespace Infrastructure.Data.BoundedContext.BlogingModule
{
    using Domain.BoundedContext.BlogingModule;
    using Infrastructure.CrossCutting.Core;
    using Infrastructure.Data.BoundedContext.UnitOfWork;
    using Infrastructure.Data.Core;
    /// <summary>
    /// The Comment repository implementation
    /// </summary>
    public class CommentRepository
        : Repository<Comment>, ICommentRepository
    {
        #region Constructor

        /// <summary>
        /// Create a new instance
        /// </summary>
        /// <param name="unitOfWork">Associated unit of work</param>
        /// <param name="logger">Associated logger</param>
        public CommentRepository(IMainBCUnitOfWork unitOfWork, ILogger logger)
            : base(unitOfWork, logger)
        {
        }

        #endregion
    }
}
