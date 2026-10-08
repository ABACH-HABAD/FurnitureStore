namespace FurnitureStore.Infrastructure.Database.Entities;

public class FurnitureEntity : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public double Price { get; set; }
}