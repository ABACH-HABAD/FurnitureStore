using FurnitureStore.Domain.Models;
using FurnitureStore.Domain.Repositories.Common;

namespace FurnitureStore.Domain.Repositories;

public interface ISaleRepository : IRepository<SaleModel>
{
    Task<List<(string modelName, int saleCount)>> GetSalesCountByFurnitureModelsAsync(CancellationToken cancellationToken = default);
}