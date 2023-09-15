using static mersad_dev.Features.Endpoints.Courses.Create.Data;
using static mersad_dev.Features.Endpoints.Courses.Delete.Data;
using static mersad_dev.Features.Endpoints.Courses.Get.Data;
using static mersad_dev.Features.Endpoints.Courses.Update.Data;

namespace mersad_dev.Configurations;

public static class RepositoryExtensions
{
    public static void AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<ICreateRepository, CreateRepository>();
        services.AddScoped<IGetRepository, GetRepository>();
        services.AddScoped<IDeleteRepository, DeleteRepository>();
        services.AddScoped<IUpdateRepository, UpdateRepository>();
    }
}