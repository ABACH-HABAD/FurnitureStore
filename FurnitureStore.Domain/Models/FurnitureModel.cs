using FurnitureStore.Domain.Models.Common;

namespace FurnitureStore.Domain.Models;

public class FurnitureModel : BaseModel
{
    public string Name { get; init; } = string.Empty;
    public string Description { get; init; } = string.Empty;
    public double Price { get; init; }
}