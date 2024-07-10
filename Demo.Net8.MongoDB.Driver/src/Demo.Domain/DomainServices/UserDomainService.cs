using Demo.Domain.Contracts.DomainServices;
using Demo.Domain.Contracts.Repositories;
using Demo.Domain.Entities;

namespace Demo.Domain.DomainServices
{
    public class UserDomainService : BaseDomainService<User>, IUserDomainService
    {
        public UserDomainService(IUserRepository userRepository) : base(userRepository)
        {
        }
    }
}
