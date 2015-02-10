namespace Domain.BoundedContext.BlogingModule
{
    using Domain.Core;

    /// <summary>
    /// News repository contract
    /// <see cref="Domain.Core.IRepository{News}"/>
    /// </summary>
    public interface INewsRepository : IRepository<News>
    {

    }
}

