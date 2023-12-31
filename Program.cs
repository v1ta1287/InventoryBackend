using InventoryBackend.Data;
using InventoryBackend.Interfaces;
using InventoryBackend.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddScoped<ItemRepositoryInterface, ItemRepository>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("AZURE_SQL_CONNECTIONSTRING"));
});

var app = builder.Build();

// For production scenarios, consider keeping Swagger configurations behind the environment check
// if (app.Environment.IsDevelopment())
// {
app.UseSwagger();
app.UseSwaggerUI();
// }

app.UseHttpsRedirection();
app.MapControllers();

app.Run();
    