namespace WebApi.Helpers;

using Microsoft.EntityFrameworkCore;
using WebApi.Entities;

public class ClienteDataContext : DbContext
{
    protected readonly IConfiguration Configuration;

    public ClienteDataContext(IConfiguration configuration)
    {
        Configuration = configuration;

        this.Database.EnsureDeleted();
        this.Database.EnsureCreated();


        this.AddRange(
        new Cliente { Cedula = "234567896", Nombre = "JUAN CASAS", Telefono = "3102334567" },
        new Cliente { Cedula = "123983874", Nombre = "MARIA MESA", Telefono = "3102334561" },
        new Cliente { Cedula = "298767639", Nombre = "JULIO COCINA", Telefono = "3102334562" },
        new Cliente { Cedula = "098273646", Nombre = "ANDRES DIAS", Telefono = "3102334563" }
        );
        this.SaveChanges();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        // in memory database used for simplicity, change to a real db for production applications
        options.UseInMemoryDatabase("datascan_db");
    }

    public DbSet<Cliente> Clientes { get; set; }
}