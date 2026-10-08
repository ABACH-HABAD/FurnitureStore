namespace FurnitureStore.Infrastructure.Database.Entities;

public class PriceHistoryEntity : BaseEntity
{
    public double ChangedPrice { get; set; }
    public DateTime Date { get; set; }

    public Guid FurnitureId { get; set; }

    public FurnitureEntity Furniture { get; set; } = null!;
}