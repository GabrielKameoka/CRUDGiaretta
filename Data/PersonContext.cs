using CRUDGiaretta.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDGiaretta.Data;

public class PersonContext : DbContext
{
    private readonly IConfiguration _configuration;

    public PersonContext(DbContextOptions<PersonContext> options, IConfiguration configuration) : base(options)
    {
        _configuration = configuration;
    }

    public DbSet<PersonModel> Peaple { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(_configuration.GetConnectionString("ConexaoPadraoPerson"));
    }
}

