using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Template.Core.Configuration
{
    public static class ContainerConfigurationExtension
    {
        public static IServiceCollection AddCore(this IServiceCollection serviceCollection, IConfiguration configuration)
        {
            return serviceCollection;
        }
    }
}