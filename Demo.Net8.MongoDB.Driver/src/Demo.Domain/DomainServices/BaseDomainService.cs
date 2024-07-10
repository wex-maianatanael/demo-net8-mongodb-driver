using Demo.Domain.Contracts.DomainServices;
using Demo.Domain.Contracts.Repositories;

namespace Demo.Domain.DomainServices
{
    public abstract class BaseDomainService<TEntity> : IBaseDomainService<TEntity>
        where TEntity : class
    {
        private readonly IBaseRepository<TEntity> _baseRepository;

        protected BaseDomainService(IBaseRepository<TEntity> baseRepository)
        {
            _baseRepository = baseRepository;
        }

        public async Task<TEntity> CreateAsync(TEntity entity)
        {
            return await _baseRepository.CreateAsync(entity);
        }

        public Task<bool> DeleteAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
            return await _baseRepository.GetAllAsync();
        }

        public async Task<TEntity?> GetByIdAsync(string id)
        {
            return await _baseRepository.GetByIdAsync(id);
        }

        public Task<bool> UpdateAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
