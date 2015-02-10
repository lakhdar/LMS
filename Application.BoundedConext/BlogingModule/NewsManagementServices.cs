namespace Application.BoundedContext.BlogingModule
{
    using Application.Core.BlogingModule;
    using Application.DTOs;
    using Domain.BoundedContext.BlogingModule;
    using Infrastructure.CrossCutting.Core;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Threading;
    using System.Threading.Tasks;
    public class NewsManagementServices : INewsManagementServices
    {
        private INewsRepository _newsRepository;
        private ILogger _logger;

        public NewsManagementServices(INewsRepository newsRepository, ILogger logger)
        {
            if (newsRepository == null)
                throw new ArgumentNullException("newsRepository");
            if (logger == null)
                throw new ArgumentNullException("logger");
            this._newsRepository = newsRepository;
            this._logger = logger;
        }

        public async Task AddAsync(News news)
        {
            if (news == (News)null)
                throw new ArgumentNullException("news");
            this._newsRepository.Add(news);
            await this._newsRepository.UnitOfWork.CommitAsync();
        }

        public async Task UpdateAsync(News news)
        {
            if (news == (News)null)
                throw new ArgumentNullException("news");
            this._newsRepository.SetModified (news);
            await this._newsRepository.UnitOfWork.CommitAsync();
        }

        public async Task RemoveAsync(News news)
        {
            if (news == (News)null)
                throw new ArgumentNullException("news");
            this._newsRepository.Remove(news);
            await this._newsRepository.UnitOfWork.CommitAsync();
        }

        public News GetById(Guid id)
        {
            return this._newsRepository.GetElementById(id);
        }

        public Task<News> GetByIdAsync(Guid id, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this._newsRepository.GetElementByIdAsync(id, cancellationToken);
        }

        public Task<IEnumerable<News>> GetLatestNewsAsync(int count, CancellationToken cancellationToken = default(CancellationToken))
        {
            cancellationToken.ThrowIfCancellationRequested();
            return Task.FromResult<IEnumerable<News>>(this._newsRepository.GetPagedElements<DateTime>(0, count, (Expression<Func<News, DateTime>>)(x => x.CreationDate), 1 != 0));
        }

        public Task<ListWithTotalDTO> GetPagedNewsWithTotalAsync(int skip, int take, CancellationToken cancellationToken = default(CancellationToken))
        {
            cancellationToken.ThrowIfCancellationRequested();
            IQueryable<News> all = this._newsRepository.GetAllElements();
            var result = new ListWithTotalDTO()
            {
                Total = all.Count(),
                List=all.Skip(skip).Take(take)
            };

            return Task.FromResult<ListWithTotalDTO>(result);
        }

        public Task<IEnumerable<News>> GetPagedNewsAsync(int skip, int take, CancellationToken cancellationToken = default(CancellationToken))
        {
            cancellationToken.ThrowIfCancellationRequested();
            return Task.FromResult<IEnumerable<News>>(this._newsRepository.GetPagedElements<DateTime>(skip, take, (x => x.CreationDate), true));
        }
    }
}
