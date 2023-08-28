namespace WebApi.Helpers;

using Microsoft.EntityFrameworkCore;
using WebApi.Entities;

public class ProductoDataContext : DbContext
{
    protected readonly IConfiguration Configuration;

    public ProductoDataContext(IConfiguration configuration)
    {
        Configuration = configuration;

        this.Database.EnsureDeleted();
        this.Database.EnsureCreated();


        this.AddRange(
        new Producto { Id = "P000000001", Nombre = "MEDIAS LARGAS", Valor = 15200 },
        new Producto { Id = "P000000002", Nombre = "MEDIAS CORTAS", Valor = 12400 },
        new Producto { Id = "P000000003", Nombre = "MEDIAS AZULES", Valor = 14100 },
        new Producto { Id = "P000000004", Nombre = "MEDIAS ROTAS", Valor = 9900 }
        );
        this.SaveChanges();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        // in memory database used for simplicity, change to a real db for production applications
        options.UseInMemoryDatabase("datascan_db");
    }

    public DbSet<Producto> Productos { get; set; }
}