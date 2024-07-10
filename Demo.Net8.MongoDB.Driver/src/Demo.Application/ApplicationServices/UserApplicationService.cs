using Demo.Application.Contracts;
using Demo.Domain.Contracts.DomainServices;
using Demo.Domain.Entities;

namespace Demo.Application.ApplicationServices
{
    public class UserApplicationService : IUserApplicationService
    {
        private readonly IUserDomainService _userDomainService;

        public UserApplicationService(IUserDomainService userDomainService)
        {
            _userDomainService = userDomainService;
        }

        public Task<User> CreateAsync(User entity)
        {
            return _userDomainService.CreateAsync(entity);
        }

        public Task<bool> DeleteAsync(User entity)
        {
            throw new NotImplementedException();
        }

        public async Task<List<User>> GetAllAsync()
        {
            return await _userDomainService.GetAllAsync();
        }

        public async Task<User?> GetByIdAsync(string id)
        {
            return await _userDomainService.GetByIdAsync(id);
        }

        public Task<bool> UpdateAsync(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
