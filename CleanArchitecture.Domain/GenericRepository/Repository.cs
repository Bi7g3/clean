
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace GenericRepository;

public class Repository<TEntity, TContext> : IRepository<TEntity>
    where TEntity : class
    where TContext : DbContext
{

    private readonly TContext _context;
    private DbSet<TEntity> Entity;

    public Repository(TContext context)
    {
        _context = context;
        Entity = _context.Set<TEntity>();
    }

    public void Add(TEntity entity)
    {
        throw new NotImplementedException();
    }

    public Task AddAsync(TEntity entity, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public void AddRange(ICollection<TEntity> entities)
    {
        throw new NotImplementedException();
    }

    public Task AddRangeAsync(ICollection<TEntity> entities, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public bool Any(Expression<Func<TEntity, bool>> expression)
    {
        throw new NotImplementedException();
    }

    public Task<bool> AnyAsync(Expression<Func<TEntity, bool>> expression, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public IQueryable<TEntity> AsQueryable()
    {
        throw new NotImplementedException();
    }

    public int Count()
    {
        throw new NotImplementedException();
    }

    public int Count(Expression<Func<TEntity, bool>> expression)
    {
        throw new NotImplementedException();
    }

    public Task<int> CountAsync(CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<int> CountAsync(Expression<Func<TEntity, bool>> expression, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public IQueryable<KeyValuePair<bool, int>> CountBy(Expression<Func<TEntity, bool>> expression, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public void Delete(TEntity entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteByExpressionAsync(Expression<Func<TEntity, bool>> expression, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task DeleteByIdAsync(string id)
    {
        throw new NotImplementedException();
    }

    public void DeleteRange(ICollection<TEntity> entities)
    {
        throw new NotImplementedException();
    }

    public int ExecuteDelete()
    {
        throw new NotImplementedException();
    }

    public Task<int> ExecuteDeleteAsync(CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public int ExecuteUpdate(Action<UpdateSettersBuilder<TEntity>> setPropertyCalls)
    {
        throw new NotImplementedException();
    }

    public Task<int> ExecuteUpdateAsync(Action<UpdateSettersBuilder<TEntity>> setPropertyCalls, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public TEntity First(Expression<Func<TEntity, bool>> expression, bool isTrackingActive = true)
    {
        throw new NotImplementedException();
    }

    public Task<TEntity> FirstAsync(Expression<Func<TEntity, bool>> expression, CancellationToken cancellationToken = default, bool isTrackingActive = true)
    {
        throw new NotImplementedException();
    }

    public TEntity FirstOrDefault(Expression<Func<TEntity, bool>> expression, bool isTrackingActive = true)
    {
        throw new NotImplementedException();
    }

    public Task<TEntity> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> expression, CancellationToken cancellationToken = default, bool isTrackingActive = true)
    {
        throw new NotImplementedException();
    }

    public IQueryable<TEntity> GetAll()
    {
        throw new NotImplementedException();
    }

    public IQueryable<TEntity> GetAllWithTracking()
    {
        throw new NotImplementedException();
    }

    public TEntity GetByExpression(Expression<Func<TEntity, bool>> expression)
    {
        throw new NotImplementedException();
    }

    public Task<TEntity> GetByExpressionAsync(Expression<Func<TEntity, bool>> expression, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public TEntity GetByExpressionWithTracking(Expression<Func<TEntity, bool>> expression)
    {
        throw new NotImplementedException();
    }

    public Task<TEntity> GetByExpressionWithTrackingAsync(Expression<Func<TEntity, bool>> expression, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public TEntity GetFirst()
    {
        throw new NotImplementedException();
    }

    public Task<TEntity> GetFirstAsync(CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public void Update(TEntity entity)
    {
        throw new NotImplementedException();
    }

    public void UpdateRange(ICollection<TEntity> entities)
    {
        throw new NotImplementedException();
    }

    public IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> expression)
    {
        throw new NotImplementedException();
    }

    public IQueryable<TEntity> WhereWithTracking(Expression<Func<TEntity, bool>> expression)
    {
        throw new NotImplementedException();
    }
}