using Demo.Application.ApplicationServices;
using Demo.Application.Contracts;
using Demo.Domain.Contracts.DomainServices;
using Demo.Domain.Contracts.Repositories;
using Demo.Domain.DomainServices;
using Demo.Infra.Repository.Repositories;

namespace Demo.Api.Configuration
{
    public static class DependencyInjectionConfiguration
    {
        public static WebApplicationBuilder AddDependencyInjectionResolver (this WebApplicationBuilder builder)
        {
            // Application Services
            builder.Services.AddScoped<IUserApplicationService, UserApplicationService>();

            // Domain Services
            builder.Services.AddScoped<IUserDomainService, UserDomainService>();

            // Repositories
            builder.Services.AddScoped<IUserRepository, UserRepository>();

            return builder;
        }
    }
}
