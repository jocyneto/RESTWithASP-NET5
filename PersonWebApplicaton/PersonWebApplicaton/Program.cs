using Microsoft.EntityFrameworkCore;
using PersonWebApplicaton.Model.Context;
using PersonWebApplicaton.Services;
using PersonWebApplicaton.Services.Implemenatation;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

var connection = builder.Configuration["SQLServerConnection:SQLServerConnectionString"];
builder.Services.AddDbContext<SQLServerConxtext>(options => options.UseSqlServer(
    connection
    )
    );

// Dependency Injection
builder.Services.AddScoped<IPersonService, PersonServiceImplementation>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
