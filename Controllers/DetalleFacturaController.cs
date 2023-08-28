namespace WebApi.Controllers;

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models.Facturas;
using WebApi.Services;

[ApiController]
[Route("[controller]")]
public class DetalleFacturaController : ControllerBase
{
    private IFacturaService _facturaService;
    private IMapper _mapper;

    public DetalleFacturaController(
        IFacturaService facturaService,
        IMapper mapper)
    {
        _facturaService = facturaService;
        _mapper = mapper;
    }

    [HttpGet("{trx}")]
    public IActionResult GetAllDetails(int trx)
    {
        var detalles = _facturaService.GetAllDetails(trx);
        return Ok(detalles);
    }

    [HttpPost]
    public IActionResult CreateDetail(CreateRequestDetail model)
    {
        _facturaService.CreateDetail(model);
        return Ok(new { message = "Detalle insertado en: " + model.NumTRX });
    }
}