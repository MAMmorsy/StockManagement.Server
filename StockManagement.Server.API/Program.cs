using GeneralAPI.API.Utilities.DependenciesResolver;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using StockManagement.Server.API.HubConfig;
using StockManagement.Server.API.Utilities.DependenciesResolver;
using StockManagement.Server.CORE.Helpers;
using StockManagement.Server.EF.Context;
using System;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy", config =>
    {
        config.WithOrigins(builder.Configuration["AllowedOrigins"]);
        config.AllowAnyMethod();
        config.AllowAnyHeader();
        config.AllowCredentials();
    });
});

//// Add services to the container.
//builder.Services.AddCors(options =>
//{
//    options.AddPolicy("CorsPolicy", builder => builder
//        .WithOrigins("http://localhost:4200")
//        .AllowAnyMethod()
//        .AllowAnyHeader()
//        .AllowCredentials());
//}); 
builder.Services.AddSignalR();
builder.Services.AddControllers();

ServicesDependenciesResolver.Register(builder.Services);
RepositoriesDependenciesResolver.Register(builder.Services);
MapperDependenciesResolver.Register(builder.Services);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<StocksDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("ConStr"));
});


builder.Services.AddHostedService<StockHostedService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors("CorsPolicy");
app.UseAuthorization();

app.MapControllers();

app.MapHub<StocksHub>("/stocks");
Console.WriteLine("started");
app.Run();
