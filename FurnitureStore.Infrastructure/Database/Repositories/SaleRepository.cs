using FurnitureStore.Domain.Models;
using FurnitureStore.Domain.Repositories;
using FurnitureStore.Infrastructure.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace FurnitureStore.Infrastructure.Database.Repositories;

public class SaleRepository(ApplicationContext applicationContext) : BaseRepository<SaleModel, SaleEntity>
    (
        applicationContext,
        applicationContext.Sales,
        selector: entity => new SaleModel
        {
            Id = entity.Id,
            SaleTime = entity.SaleTime,
            Buyer = entity.Buyer,
            Furniture = new FurnitureModel
            {
                Id = entity.Furniture.Id,
                Description = entity.Furniture.Description,
                Name = entity.Furniture.Name,
                Price = entity.Furniture.Price
            }
        },
        createFunc: model => new SaleEntity
        {
            Id = model.Id,
            SaleTime = model.SaleTime,
            Buyer = model.Buyer,
            FurnitureId = model.Furniture?.Id ?? Guid.Empty
        },
        updateFunc: (model, entity) =>
        {
            entity.SaleTime = model.SaleTime;
            entity.Buyer = model.Buyer;
            entity.FurnitureId = model.Furniture?.Id ?? entity.FurnitureId;
        }
    ), ISaleRepository
{
    public async Task<List<(string modelName, int saleCount)>> GetSalesCountByFurnitureModelsAsync(CancellationToken cancellationToken = default)
    {
        List<(string modelName, int saleCount)> list = [];

        var q = _entities
            .AsNoTracking()
            .GroupBy(s => s.FurnitureId);

        foreach (var group in q)
        {
            list.AddRange(group.Select(s => (s.Furniture.Name, group.Count())));
        }

        return list;
    }
}