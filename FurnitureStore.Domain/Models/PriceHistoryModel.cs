namespace FurnitureStore.Domain.Models;

public class PriceHistoryModel : BaseModel
{
    public double ChangedPrice { get; init; }
    public DateTime Date { get; init; }

    public FurnitureModel? Furniture { get; init; } = null;
}