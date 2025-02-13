
using ProductsWebAPI.Repositories;
using ProductsWebAPI.Services;
using ProductWebApi.Manager;
using ProductWebApi.Repository;
using ProductWebApi.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<IProductRepo, ProductRepo>();

builder.Services.AddTransient<IProductService, ProductService>();

builder.Services.AddTransient<IProductManager,ProductManager>();

var app = builder.Build();

// Configure middleware
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
