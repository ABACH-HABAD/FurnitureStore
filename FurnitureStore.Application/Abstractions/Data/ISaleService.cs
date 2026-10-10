using FurnitureStore.Application.Abstractions.Data.Common;
using FurnitureStore.Application.Services.Common;
using FurnitureStore.Domain.Models;

namespace FurnitureStore.Application.Abstractions.Data;

public interface ISaleService : IDataService<SaleModel>
{
    public Task<Result<List<(string model, int saleCount)>>> GetSalesCountByFurnitureModelsAsync(CancellationToken cancellationToken = default);
}