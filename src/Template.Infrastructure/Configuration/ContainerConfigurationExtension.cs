using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Template.Infrastructure.Configuration
{
    public static class ContainerConfigurationExtension
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection serviceCollection, IConfiguration configuration)
        {
            return serviceCollection;
        }
    }
}