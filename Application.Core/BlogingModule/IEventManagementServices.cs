namespace Application.Core.BlogingModule
{
    using Application.DTOs;
    using Domain.BoundedContext.BlogingModule;
    using System;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public interface IEventManagementServices
    {
        Task AddAsync(Event evnt);

        Task UpdateAsync(Event evnt);

        Task RemoveAsync(Event evnt);

        Event GetById(Guid id);

        Task<Event> GetByIdAsync(Guid id, CancellationToken cancellationToken = default(CancellationToken));

        Task<IEnumerable<Event>> GetLatestEventsAsync(int count, CancellationToken cancellationToken = default(CancellationToken));
        Task<ListWithTotalDTO> GetPagedEventsWithTotalAsync(int skip, int take, CancellationToken cancellationToken = default(CancellationToken));
    }
}
