namespace WebApi.Helpers;

using Microsoft.EntityFrameworkCore;
using WebApi.Entities;

public class FacturaDataContext : DbContext
{
    protected readonly IConfiguration Configuration;

    public FacturaDataContext(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        // in memory database used for simplicity, change to a real db for production applications
        options.UseInMemoryDatabase("datascan_db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Factura>(f => 
        { 
            f.Property(e => e.NumTRX).ValueGeneratedOnAdd();
        });
    }

    public DbSet<Factura> Facturas { get; set; }
    public DbSet<DetalleFactura> DetalleFacturas { get; set; }
}