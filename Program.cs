global using FastEndpoints;
using mersad_dev.Configurations;
using mersad_dev.Data;
using Microsoft.EntityFrameworkCore;
using FluentValidation;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddFastendpoints();

builder.Services.AddSwagger();
builder.Services.AddDbContext<ApiDbContext>(option =>
option.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddValidatorsFromAssemblyContaining<Program>();
builder.Services.AddRepositories();

var app = builder.Build();
app.UseAuthorization();
app.UseFastendpointsConfiguration();
app.UseSwagger();

app.Run();
