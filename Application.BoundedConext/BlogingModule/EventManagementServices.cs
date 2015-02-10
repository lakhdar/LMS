namespace Application.BoundedContext.BlogingModule
{
    using Application.Core.BlogingModule;
    using Application.DTOs;
    using Domain.BoundedContext.BlogingModule;
    using Infrastructure.CrossCutting.Core;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    public class EventManagementServices : IEventManagementServices
    {
        private IEventRepository _evntRepository;
        private ILogger _logger;

        public EventManagementServices(IEventRepository evntRepository, ILogger logger)
        {
            if (evntRepository == null)
                throw new ArgumentNullException("evntRepository");
            if (logger == null)
                throw new ArgumentNullException("logger");
            this._evntRepository = evntRepository;
            this._logger = logger;
        }

        public async Task AddAsync(Event evnt)
        {
            if (evnt == (Event)null)
                throw new ArgumentNullException("evnt");
            this._evntRepository.Add(evnt);
            await this._evntRepository.UnitOfWork.CommitAsync();
        }

        public async Task UpdateAsync(Event evnt)
        {
            if (evnt == (Event)null)
                throw new ArgumentNullException("evnt");
            this._evntRepository.SetModified(evnt);
            await this._evntRepository.UnitOfWork.CommitAsync();
        }

        public async Task RemoveAsync(Event evnt)
        {
            if (evnt == (Event)null)
                throw new ArgumentNullException("evnt");
            this._evntRepository.Remove(evnt);
            await this._evntRepository.UnitOfWork.CommitAsync();
        }

        public Event GetById(Guid id)
        {
            return this._evntRepository.GetElementById(id);
        }

        public Task<Event> GetByIdAsync(Guid id, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this._evntRepository.GetElementByIdAsync(id, cancellationToken);
        }

        public Task<IEnumerable<Event>> GetLatestEventsAsync(int count, CancellationToken cancellationToken = default(CancellationToken))
        {
            cancellationToken.ThrowIfCancellationRequested();
            return Task.FromResult<IEnumerable<Event>>(this._evntRepository.GetPagedElements<DateTime>(0, count, (x => x.DateStart), 1 != 0));
        }


        public Task<ListWithTotalDTO> GetPagedEventsWithTotalAsync(int skip, int take, CancellationToken cancellationToken = default(CancellationToken))
        {
            cancellationToken.ThrowIfCancellationRequested();
            IQueryable<Event> all = this._evntRepository.GetAllElements();
            var result = new ListWithTotalDTO()
            {
                Total = all.Count(),
                List = all.Skip(skip).Take(take)
            };

            return Task.FromResult<ListWithTotalDTO>(result);
        }
    }
}
