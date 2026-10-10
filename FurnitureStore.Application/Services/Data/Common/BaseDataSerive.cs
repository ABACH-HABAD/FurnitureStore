using FurnitureStore.Domain.Repositories.Common;
using FurnitureStore.Application.Abstractions.Data.Common;
using FurnitureStore.Application.Services.Common;
using FurnitureStore.Domain.Models.Common;

namespace FurnitureStore.Application.Services.Data.Common;

public class BaseDataSerive<TModel, TRepository>(TRepository repository) : IDataService<TModel> where TModel : BaseModel where TRepository : IRepository<TModel>
{
    protected TRepository _repository = repository;

    public async Task<Result<TModel>> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        try
        {
            TModel? model = await _repository.GetByIdAsync(id, cancellationToken).ConfigureAwait(false);

            if (model == null) return Result<TModel>.Fail("Не найдено");
            else return Result<TModel>.Success(model);
        }
        catch (Exception ex)
        {
            return Result<TModel>.Fail(ex.Message);
        }
    }

    public async Task<Result<List<TModel>>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        try
        {
            List<TModel> list = await _repository.GetAllAsync(cancellationToken).ConfigureAwait(false);

            return Result<List<TModel>>.Success(list);
        }
        catch (Exception ex)
        {
            return Result<List<TModel>>.Fail(ex.Message);
        }
    }

    public async Task<Result> AddAsync(TModel model, CancellationToken cancellationToken = default)
    {
        try
        {
            await _repository.AddAsync(model, cancellationToken).ConfigureAwait(false);
            return Result.Success();
        }
        catch (Exception ex)
        {
            return Result.Fail(ex.Message);
        }
    }

    public async Task<Result> UpdateAsync(TModel model, CancellationToken cancellationToken = default)
    {
        try
        {
            await _repository.UpdateAsync(model, cancellationToken).ConfigureAwait(false);
            return Result.Success();
        }
        catch (Exception ex)
        {
            return Result.Fail(ex.Message);
        }
    }

    public async Task<Result> DeleteAsync(Guid id, CancellationToken cancellationToken = default)
    {
        try
        {
            await _repository.DeleteAsync(id, cancellationToken).ConfigureAwait(false);
            return Result.Success();
        }
        catch (Exception ex)
        {
            return Result.Fail(ex.Message);
        }
    }
}