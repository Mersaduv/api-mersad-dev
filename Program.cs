global using FastEndpoints;
using mersad_dev.Configurations;
using mersad_dev.Data;
using Microsoft.EntityFrameworkCore;
using FluentValidation;
using mersad_dev.Utility;
using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(new WebApplicationOptions
{
    ApplicationName = typeof(Program).Assembly.FullName,
    ContentRootPath = Path.GetFullPath(Directory.GetCurrentDirectory()),
    WebRootPath = Path.GetFullPath(Directory.GetCurrentDirectory()),
    Args = args
});

builder.Services.AddFastendpoints();
builder.Services.AddSwagger();
builder.Services.AddHttpContextAccessor();
builder.Services.AddDbContext<ApiDbContext>(option =>
option.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddValidatorsFromAssemblyContaining<Program>();
builder.Services.AddRepositories();
builder.Services.AddSingleton<ByteFileUtility>();
builder.Services.AddHttpContextAccessor();

builder.Services.AddCors();

var app = builder.Build();
app.UseStaticFiles();
app.UseCors(b => b.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
app.UseAuthorization();
app.UseFastendpointsConfiguration();
app.UseSwagger();

app.Run();
