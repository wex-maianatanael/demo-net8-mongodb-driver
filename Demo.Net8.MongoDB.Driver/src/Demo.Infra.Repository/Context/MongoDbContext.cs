using Demo.Domain;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace Demo.Infra.Repository.Context
{
    public class MongoDbContext
    {
        private readonly IMongoDatabase _database;

        public MongoDbContext(IConfiguration configuration)
        {
            var client = new MongoClient(configuration.GetConnectionString("MongoDb"));
            _database = client.GetDatabase(configuration["MongoDbSettings:DatabaseName"]);
        }

        public IMongoCollection<User> Users => _database.GetCollection<User>("users");
    }
}
