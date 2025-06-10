using API.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Configuração do SQLite e CORS
builder.Services.AddDbContext<AppDataContext>(options => 
    options.UseSqlite("Data Source=AvaliacaoFilmesSeries.db"));

builder.Services.AddCors(options =>
    options.AddPolicy("Acesso Total",
        configs => configs
            .AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod())
);

var app = builder.Build();

app.UseCors("Acesso Total");

app.Run();
