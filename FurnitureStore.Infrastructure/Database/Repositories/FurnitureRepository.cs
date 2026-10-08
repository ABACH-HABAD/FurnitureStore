using FurnitureStore.Domain.Models;
using FurnitureStore.Domain.Repositories;
using FurnitureStore.Infrastructure.Database.Entities;

namespace FurnitureStore.Infrastructure.Database.Repositories;

public class FurnitureRepository(ApplicationContext applicationContext) : BaseRepository<FurnitureModel, FurnitureEntity>
    (
        applicationContext,
        applicationContext.Furnitures,
        selector: entity => new FurnitureModel
        {
            Id = entity.Id,
            Name = entity.Name,
            Description = entity.Description,
            Price = entity.Price
        },
        createFunc: model => new FurnitureEntity
        {
            Id = model.Id,
            Name = model.Name,
            Description = model.Description,
            Price = model.Price
        },
        updateFunc: (model, entity) =>
            {
                entity.Name = model.Name;
                entity.Description = model.Description;
                entity.Price = model.Price;
            }
    ), IFurnitureRepository;