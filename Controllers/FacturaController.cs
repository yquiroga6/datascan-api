namespace WebApi.Controllers;

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models.Facturas;
using WebApi.Services;

[ApiController]
[Route("[controller]")]
public class FacturaController : ControllerBase
{
    private IFacturaService _facturaService;
    private IMapper _mapper;

    public FacturaController(
        IFacturaService facturaService,
        IMapper mapper)
    {
        _facturaService = facturaService;
        _mapper = mapper;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        var facturas = _facturaService.GetAll();
        return Ok(facturas);
    }

    [HttpGet("{trx}")]
    public IActionResult GetDetails(int trx)
    {
        var detalleFactura = _facturaService.GetAllDetails(trx);
        return Ok(detalleFactura);
    }

    [HttpPost]
    public IActionResult Create(CreateRequest model)
    {
        int trx = _facturaService.Create(model);
        return Ok(new { message = "Factura creada", trx = trx });
    }
}