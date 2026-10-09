using FurnitureStore.Application.Abstractions.Data.Common;
using FurnitureStore.Domain.Models;
using FurnitureStore.Domain.Repositories.Common;

namespace FurnitureStore.Application.Abstractions.Data;

public interface IPriceHistoryService : Common.IDataService<PriceHistoryModel>;