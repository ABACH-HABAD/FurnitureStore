using FurnitureStore.Domain.Models;
using FurnitureStore.Domain.Repositories;
using FurnitureStore.Application.Abstractions.Data;
using FurnitureStore.Application.Services.Data.Common;
using FurnitureStore.Application.Services.Common;

namespace FurnitureStore.Application.Services.Data;

public class SaleService(ISaleRepository repository) : BaseDataSerive<SaleModel, ISaleRepository>(repository), ISaleService
{
    public async Task<Result<List<(string model, int saleCount)>>> GetSalesCountByFurnitureModelsAsync(CancellationToken cancellationToken = default)
    {
        try
        {
            List<(string model, int saleCount)> list = await _repository.GetSalesCountByFurnitureModelsAsync(cancellationToken).ConfigureAwait(false);

            return Result<List<(string model, int saleCount)>>.Success(list);
        }
        catch (Exception ex)
        {
            return Result<List<(string model, int saleCount)>>.Fail(ex.Message);
        }
    }
}