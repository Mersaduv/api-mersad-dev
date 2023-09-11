namespace mersad_dev.Configurations;

public static class FastendpointsConfigurationExtensions
{
    public static void AddFastendpoints(this IServiceCollection services)
    {
        services.AddFastEndpoints();
    }

    public static void UseFastendpointsConfiguration(this WebApplication app)
    {
        app.UseFastEndpoints(c =>
        {
            c.Versioning.Prefix = "v";
            c.Endpoints.RoutePrefix = "api";

        });
    }
}