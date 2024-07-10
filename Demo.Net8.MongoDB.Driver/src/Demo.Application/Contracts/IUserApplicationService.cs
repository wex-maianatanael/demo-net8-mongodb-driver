using Demo.Domain.Entities;

namespace Demo.Application.Contracts
{
    public interface IUserApplicationService
    {
        // info: both parameter and response should be a dto or view model instead of domain class (reason: make it simple for demo purposes)
        Task<User> CreateAsync(User entity);

        Task<bool> UpdateAsync(User entity);

        Task<bool> DeleteAsync(User entity);

        Task<List<User>> GetAllAsync();

        Task<User?> GetByIdAsync(string id);
    }
}
