using FastEndpoints.Swagger;

namespace mersad_dev.Configurations;

public static class SwaggerConfigurationExtensions
{
    public static void AddSwagger(this IServiceCollection services)
    {
        services.AddSwaggerDoc(options =>
        {
            options.DocumentName = "Initial Release";
            options.Title = "Mersad-Dev.Api";
            options.Version = "v1.0";
        },
        maxEndpointVersion: 1);
    }

    public static void UseSwagger(this WebApplication app)
    {
        app.UseOpenApi();
        app.UseSwaggerUi3(s => s.ConfigureDefaults());
    }
}