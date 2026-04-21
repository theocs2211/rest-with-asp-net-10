using Microsoft.OpenApi;

namespace RestWithASPNET10.Configurations
{
    public static class OpenAPIConfig
    {
        private static readonly string AppName = "RestWithASPNET10";
        private static readonly string AppDescription = $"RESTful API developed in course {AppName}";

        public static IServiceCollection AddOpenAPIConfig(this IServiceCollection services)
        {
            services.AddSingleton(new OpenApiInfo
            {
                Title = AppName,
                Version = "v1",
                Description = AppDescription,
                Contact = new OpenApiContact
                {
                    Name = "Théo",
                    Email = "theocs2211@gmail.com",
                }
            });
            return services;
        }
    }
}
