namespace FurnitureStore.Infrastructure.Database.Entities;

public class SaleEntity : BaseEntity
{
    public string Buyer { get; set; } = string.Empty;
    public DateTime SaleTime {  get; set; }

    public Guid FurnitureId { get; set; }

    public FurnitureEntity Furniture { get; set; } = null!;
}