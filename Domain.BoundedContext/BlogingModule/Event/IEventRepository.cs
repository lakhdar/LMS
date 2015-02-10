namespace Domain.BoundedContext.BlogingModule
{
    using Domain.Core;

    /// <summary>
    /// Event repository contract
    /// <see cref="Domain.Core.IRepository{Event}"/>
    /// </summary>
    public interface IEventRepository : IRepository<Event>
    {

    }
}

