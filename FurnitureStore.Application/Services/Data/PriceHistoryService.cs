using FurnitureStore.Domain.Models;
using FurnitureStore.Domain.Repositories;
using FurnitureStore.Application.Services.Data.Common;
using FurnitureStore.Application.Abstractions.Data;

namespace FurnitureStore.Application.Services.Data;

public class PriceHistoryService(IPriceHistoryRepository repository) : BaseDataSerive<PriceHistoryModel, IPriceHistoryRepository>(repository), IPriceHistoryService
{ }