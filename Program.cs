using CRUDGiaretta.Data;
using CRUDGiaretta.Routes;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<PersonContext>();

builder.Services.AddDbContext<PersonContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("ConexaoPadraoPerson"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.PersonRoutes();

app.UseHttpsRedirection();
app.Run();