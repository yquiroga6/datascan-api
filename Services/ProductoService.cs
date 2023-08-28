namespace WebApi.Services;

using AutoMapper;
using BCrypt.Net;
using WebApi.Entities;
using WebApi.Helpers;

public interface IProductoService
{
    IEnumerable<Producto> GetAll();
    Producto GetById(string id);

}

public class ProductoService : IProductoService
{
    private ProductoDataContext _context;
    private readonly IMapper _mapper;

    public ProductoService(
        ProductoDataContext context,
        IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public IEnumerable<Producto> GetAll()
    {
        return _context.Productos;
    }
    
    public Producto GetById(string id)
    {
        return getProducto(id);
    }
   
    // helper methods
    
    private Producto getProducto(string id)
    {
        var producto = _context.Productos.Find(id);
        if (producto == null) throw new KeyNotFoundException("Producto no encontrado");
        return producto;
    }
}