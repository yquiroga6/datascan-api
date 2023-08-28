namespace WebApi.Services;

using AutoMapper;
using BCrypt.Net;
using WebApi.Entities;
using WebApi.Helpers;
using WebApi.Models.Facturas;

public interface IFacturaService
{
    IEnumerable<Factura> GetAll();
    IEnumerable<DetalleFactura> GetAllDetails(int trx);
    int Create(CreateRequest model);
    void CreateDetail(CreateRequestDetail model);
}

public class FacturaService : IFacturaService
{
    private FacturaDataContext _context;
    private readonly IMapper _mapper;

    public FacturaService(
        FacturaDataContext context,
        IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public IEnumerable<Factura> GetAll()
    {
        return _context.Facturas;
    }

    public IEnumerable<DetalleFactura> GetAllDetails(int trx)
    {
        return _context.DetalleFacturas.Where(f => f.NumTRX == trx);
    }
    
    public int Create(CreateRequest model)
    {
        // validate
        if (_context.Facturas.Any(x => x.NumTRX == model.NumTRX))
            throw new AppException("La factura con el número '" + model.NumTRX + "' ya existe");

        // map model to new detalleFactura object
        var factura = _mapper.Map<Factura>(model);

        // save detalleFactura
        _context.Facturas.Add(factura);
        _context.SaveChanges();

        return factura.NumTRX;
    }

    public void CreateDetail(CreateRequestDetail model)
    {

        // map model to new detalleFactura object
        var detalleFactura = _mapper.Map<DetalleFactura>(model);

        // save detalleFactura
        _context.DetalleFacturas.Add(detalleFactura);
        _context.SaveChanges();
    }

    // helper methods

    private DetalleFactura getDetalleFactura(string trx)
    {
        var detalleFactura = _context.DetalleFacturas.Find(trx);
        if (detalleFactura == null) throw new KeyNotFoundException("Factura no encontrada");
        return detalleFactura;
    }
}