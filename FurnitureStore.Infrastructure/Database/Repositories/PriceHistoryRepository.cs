using FurnitureStore.Domain.Models;
using FurnitureStore.Domain.Repositories;
using FurnitureStore.Infrastructure.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace FurnitureStore.Infrastructure.Database.Repositories;

public class PriceHistoryRepository(ApplicationContext applicationContext) : BaseRepository<PriceHistoryModel, PriceHistoryEntity>
    (
        applicationContext,
        applicationContext.PriceHistories,
        selector: entity => new PriceHistoryModel
        {
            Id = entity.Id,
            ChangedPrice = entity.ChangedPrice,
            Date = entity.Date,
            Furniture = new FurnitureModel
            {
                Id = entity.Furniture.Id,
                Description = entity.Furniture.Description,
                Name = entity.Furniture.Name,
                Price = entity.Furniture.Price
            }
        },
        createFunc: model => new PriceHistoryEntity
        {
            Id = model.Id,
            ChangedPrice = model.ChangedPrice,
            Date = model.Date,
            FurnitureId = model.Furniture?.Id ?? Guid.Empty
        },
        updateFunc: (model, entity) =>
            {
                entity.ChangedPrice = model.ChangedPrice;
                entity.Date = model.Date;
                entity.FurnitureId = model.Furniture?.Id ?? entity.FurnitureId;
            }
    ), IPriceHistoryRepository
{
    public override async Task<List<PriceHistoryModel>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        List<PriceHistoryModel> list = await _entities
            .AsNoTracking()
            .OrderBy(x => x.Date)
            .Select(_selector)
            .ToListAsync(cancellationToken);

        return list;
    }
}