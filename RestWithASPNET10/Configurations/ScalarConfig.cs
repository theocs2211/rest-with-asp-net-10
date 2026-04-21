using Scalar.AspNetCore;

namespace RestWithASPNET10.Configurations
{
    public static class ScalarConfig
    {
        private static readonly string AppName = "RestWithASPNET10";

        public static WebApplication UseScalarConfig(this WebApplication app)
        {
            app.MapScalarApiReference("/scalar", options =>
            {
                options
                   .WithTitle(AppName)
                   .WithOpenApiRoutePattern("/swagger/v1/swagger.json");
            });
            return app;
        }
    }
}
