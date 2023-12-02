using InventoryBackend.Data;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
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

//string connectionString = app.Configuration.GetConnectionString("AZURE_SQL_CONNECTIONSTRING")!;

//app.MapGet("/Item", () => {
//    var rows = new List<string>();

//    using var conn = new SqlConnection(connectionString);
//    conn.Open();

//    var command = new SqlCommand("SELECT ItemId, ItemName, WarehouseName FROM dbo.Item", conn);
//    using SqlDataReader reader = command.ExecuteReader();

//    if (reader.HasRows)
//    {
//        while (reader.Read())
//        {
//            rows.Add($"{reader.GetInt32(0)}, {reader.GetString(1)}, {reader.GetString(2)}");
//        }
//    }

//    return rows;
//})
//.WithName("GetItems")
//.WithOpenApi();


app.Run();
    