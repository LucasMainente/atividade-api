using Api_Filmes_Senai.Interfaces;
using Api_Filmes_Senai.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IGeneroRepository,GeneroRepository>();

builder.Services.AddControllers();

builder.Services.AddDbContext<Filmes_Context>(options =>
    options.UseSqlServer("Server=NOTE41-S28\\SQLEXPRESS;Database=Filmes;User ID=sa;Password=Senai@134;TrustServerCertificate=true"));

builder.Services.AddControllers();  


var app = builder.Build();

app.MapControllers();


app.Run();


