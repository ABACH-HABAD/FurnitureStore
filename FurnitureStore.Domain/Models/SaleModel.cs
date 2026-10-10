using FurnitureStore.Domain.Models.Common;

namespace FurnitureStore.Domain.Models;

public class SaleModel : BaseModel
{
    public string Buyer { get; init; } = string.Empty;
    public DateTime SaleTime { get; init; }

    public FurnitureModel? Furniture { get; init; } = null;
}