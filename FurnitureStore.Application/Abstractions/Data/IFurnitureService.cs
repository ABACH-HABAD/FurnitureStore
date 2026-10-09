using FurnitureStore.Domain.Models;
using FurnitureStore.Domain.Repositories.Common;

namespace FurnitureStore.Application.Abstractions.Data;

public interface IFurnitureService : IRepository<FurnitureModel>;