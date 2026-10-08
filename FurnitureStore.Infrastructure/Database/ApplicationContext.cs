using FurnitureStore.Infrastructure.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace FurnitureStore.Infrastructure.Database;

public sealed class ApplicationContext : DbContext
{
    internal DbSet<FurnitureEntity> Furnitures => Set<FurnitureEntity>();
    internal DbSet<SaleEntity> Sales => Set<SaleEntity>();
    internal DbSet<PriceHistoryEntity> PriceHistories => Set<PriceHistoryEntity>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
    }
}