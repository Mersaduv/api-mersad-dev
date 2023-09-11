using static mersad_dev.Features.Endpoints.Courses.Create.Data;
using static mersad_dev.Features.Endpoints.Courses.Get.Data;

namespace mersad_dev.Configurations;

public static class RepositoryExtensions
{
    public static void AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<ICreateRepository, CreateRepository>();
        services.AddScoped<IGetRepository, GetRepository>();
        // services.AddScoped<DeleteRepo.IRepository, DeleteRepo.Repository>();
        // services.AddScoped<UpdateRepo.IRepository, UpdateRepo.Repository>();
        // services.AddScoped<WebCreatorRepo.IRepository, WebCreatorRepo.Repository>();
        // services.AddScoped<WebGetRepo.IRepository, WebGetRepo.Repository>();
    }
}