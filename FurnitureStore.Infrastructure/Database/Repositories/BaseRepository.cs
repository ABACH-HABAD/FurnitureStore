using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using FurnitureStore.Domain.Models;
using FurnitureStore.Infrastructure.Database.Entities;
using FurnitureStore.Domain.Repositories.Common;

namespace FurnitureStore.Infrastructure.Database.Repositories;

public abstract class BaseRepository<TModel, TEntity>
    (
        ApplicationContext context,
        DbSet<TEntity> entities,
        Expression<Func<TEntity, TModel>> selector,
        Func<TModel, TEntity> createFunc,
        Action<TModel, TEntity> updateFunc
    )
    : IRepository<TModel> 
    where TModel : BaseModel 
    where TEntity : BaseEntity
{
    protected readonly ApplicationContext _context = context;
    protected readonly DbSet<TEntity> _entities = entities;
    protected readonly Expression<Func<TEntity, TModel>> _selector = selector;
    protected readonly Func<TModel, TEntity> _createFunc = createFunc;
    protected readonly Action<TModel, TEntity> _updateFunc = updateFunc;

    public async Task<TModel?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        TModel? model = await _entities
            .AsNoTracking()
            .Where(e => e.Id == id)
            .Select(_selector)
            .SingleOrDefaultAsync(cancellationToken);

        return model;
    }

    public async Task<List<TModel>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        List<TModel> list = await _entities
            .AsNoTracking()
            .Select(_selector)
            .ToListAsync(cancellationToken);

        return list;
    }

    public async Task AddAsync(TModel model, CancellationToken cancellationToken = default)
    {
        TEntity entity = _createFunc(model);

        await _entities
            .AddAsync(entity, cancellationToken);

        await _context.SaveChangesAsync(cancellationToken);
    }

    public async Task UpdateAsync(TModel model, CancellationToken cancellationToken = default)
    {
        TEntity? entity = await _entities
            .AsNoTracking()
            .Where(e => e.Id == model.Id)
            .SingleOrDefaultAsync(cancellationToken);

        if (entity != null) _updateFunc(model, entity);

        await _context.SaveChangesAsync(cancellationToken);
    }

    public async Task DeleteAsync(Guid id, CancellationToken cancellationToken = default)
    {
        await _entities
            .Where(e => e.Id == id)
            .ExecuteDeleteAsync(cancellationToken);

        await _context.SaveChangesAsync(cancellationToken);
    }
}