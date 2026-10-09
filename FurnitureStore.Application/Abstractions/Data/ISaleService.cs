using FurnitureStore.Application.Abstractions.Data.Common;
using FurnitureStore.Domain.Models;
using FurnitureStore.Domain.Repositories.Common;

namespace FurnitureStore.Application.Abstractions.Data;

public interface ISaleService : Common.IDataService<SaleModel>;