using Demo.Domain.Contracts.Repositories;
using Demo.Infra.Repository.Context;

namespace Demo.Infra.Repository.Repositories
{
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity>
        where TEntity : class
    {
        private readonly MongoDbContext _context;

        protected BaseRepository(MongoDbContext context)
        {
            _context = context;
        }

        public virtual Task<TEntity> CreateAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public virtual Task<bool> DeleteAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public virtual async Task<List<TEntity>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public virtual Task<TEntity?> GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public virtual Task<bool> UpdateAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
