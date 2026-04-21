using Microsoft.OpenApi;

namespace RestWithASPNET10.Configurations
{
    public static class SwaggerConfig
    {
        private static readonly string AppName = "RestWithASPNET10";
        private static readonly string AppDescription = $"RESTful API developed in course {AppName}";

        public static IServiceCollection AddSwaggerConfig(this IServiceCollection services)
        {
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo
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
                options.CustomSchemaIds(x => x.FullName);
            });
            return services;
        }

        public static IApplicationBuilder UseSwaggerSpecification(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
                options.RoutePrefix = "swagger-ui";
                options.DocumentTitle = AppName;
            });
            return app;
        }
    }
}
