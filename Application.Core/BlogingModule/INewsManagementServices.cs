
namespace Application.Core.BlogingModule
{
    using Application.DTOs;
    using Domain.BoundedContext.BlogingModule;
    using System;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public interface INewsManagementServices
    {
        Task AddAsync(News news);

        Task UpdateAsync(News news);

        Task RemoveAsync(News news);

        News GetById(Guid id);

        Task<News> GetByIdAsync(Guid id, CancellationToken cancellationToken = default(CancellationToken));

        Task<IEnumerable<News>> GetLatestNewsAsync(int count, CancellationToken cancellationToken = default(CancellationToken));

         Task<ListWithTotalDTO> GetPagedNewsWithTotalAsync(int skip, int take, CancellationToken cancellationToken = default(CancellationToken));

        Task<IEnumerable<News>> GetPagedNewsAsync(int skip, int take, CancellationToken cancellationToken = default(CancellationToken));
    }
}
