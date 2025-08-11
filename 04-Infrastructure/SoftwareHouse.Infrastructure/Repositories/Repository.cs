using Microsoft.EntityFrameworkCore;
using SoftwareHouse.Infrastructure.Repositories.EFCore;
using System.Linq.Expressions;

namespace SoftwareHouse.Infrastructure.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly SoftwareHouseDbContext _dataBaseContext;
        private readonly DbSet<T> _dbSet;

        public Repository(SoftwareHouseDbContext dataBaseContext)
        {
            _dataBaseContext = dataBaseContext;
            _dbSet = dataBaseContext.Set<T>();
        }

        public async Task AddAsync(T entity, CancellationToken cancellationToken = default)
        {
            await _dbSet.AddAsync(entity, cancellationToken);
            await _dataBaseContext.SaveChangesAsync(cancellationToken);
        }

        public async Task DeleteAsync(Guid id, CancellationToken cancellationToken = default)
        {
            var entity = await _dbSet.FindAsync(new object[] { id.ToString() }, cancellationToken);
            if (entity != null)
            {
                _dbSet.Remove(entity);
                await _dataBaseContext.SaveChangesAsync(cancellationToken);
            }
        }

        public async Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken = default)
        {
            return await _dbSet.Where(predicate).ToListAsync(cancellationToken);
        }

        public async Task<T> FirstOrDefault(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken = default)
        {
            return await _dbSet.FirstOrDefaultAsync(predicate, cancellationToken);
        }

        public async Task<IEnumerable<T>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            return await _dbSet.ToListAsync(cancellationToken);
        }

        public async Task<T> GetByIdAsync(string id, CancellationToken cancellationToken = default)
        {
            return await _dbSet.FindAsync(new object[] { id }, cancellationToken);
        }

        public async Task UpdateAsync(string id, T entity, CancellationToken cancellationToken = default)
        {
            var existing = await _dbSet.FindAsync(new object[] { id }, cancellationToken);
            if (existing != null)
            {
                _dataBaseContext.Entry(existing).CurrentValues.SetValues(entity);
                await _dataBaseContext.SaveChangesAsync(cancellationToken);
            }
        }
    }
}
