using FurnitureStore.Application.Services.Common;
using FurnitureStore.Domain.Models;

namespace FurnitureStore.Application.Abstractions.Data.Common;

public interface IDataService<T> where T : BaseModel
{
    public Task<Result<T>> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    public Task<Result<List<T>>> GetAllAsync(CancellationToken cancellationToken = default);
    public Task<Result> AddAsync(T model, CancellationToken cancellationToken = default);
    public Task<Result> UpdateAsync(T model, CancellationToken cancellationToken = default);
    public Task<Result> DeleteAsync(Guid id, CancellationToken cancellationToken = default);
    public Task<Result> DeleteAsync(T model, CancellationToken cancellationToken = default) => DeleteAsync(model.Id, cancellationToken);
}