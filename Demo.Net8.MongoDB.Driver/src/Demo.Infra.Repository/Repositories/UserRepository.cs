using Demo.Domain;
using Demo.Domain.Contracts.Repositories;
using Demo.Infra.Repository.Context;
using MongoDB.Driver;

namespace Demo.Infra.Repository.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        private readonly MongoDbContext _context;

        public UserRepository(MongoDbContext context) : base(context)
        {
            _context = context;
        }

        public override async Task<User?> GetByIdAsync(string id)
            => await _context.Users.Find(p => p.Id == id).FirstOrDefaultAsync();

        public override async Task<List<User>> GetAllAsync()
            => await _context.Users.Find(_ => true).ToListAsync();

        public override async Task<User> CreateAsync(User entity)
        {
            await _context.Users.InsertOneAsync(entity);
            return new User() { Id = entity.Id, Name = entity.Name, Age = entity.Age };
        }
    }
}
