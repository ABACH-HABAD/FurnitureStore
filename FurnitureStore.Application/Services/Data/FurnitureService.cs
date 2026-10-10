using FurnitureStore.Domain.Models;
using FurnitureStore.Domain.Repositories;
using FurnitureStore.Application.Services.Data.Common;
using FurnitureStore.Application.Abstractions.Data;

namespace FurnitureStore.Application.Services.Data;

public class FurnitureService(IFurnitureRepository repository) : BaseDataSerive<FurnitureModel, IFurnitureRepository>(repository), IFurnitureService
{ }