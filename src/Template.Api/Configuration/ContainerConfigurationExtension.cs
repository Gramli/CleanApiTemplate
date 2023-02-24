namespace Template.Api.Configuration
{
    public static class ContainerConfigurationExtension
    {
        public static WebApplicationBuilder AddLogging(this WebApplicationBuilder builder)
        {
            builder.Logging
                .ClearProviders()
                .AddConsole();
            return builder;
        }

    }
}