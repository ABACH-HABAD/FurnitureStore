using FurnitureStore.Domain.Models;
using FurnitureStore.Domain.Repositories;
using FurnitureStore.Infrastructure.Database.Entities;

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
    ), ISaleRepository;