using FurnitureStore.Application.Abstractions;
using FurnitureStore.Domain.Models;

namespace FurnitureStore.Application.Services;

internal class BaseDataSerive<T> : IDataService<T> where T : BaseModel
{
    public Task<T?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<List<T>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
    public Task AddAsync(T model, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(T model, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Guid id, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}