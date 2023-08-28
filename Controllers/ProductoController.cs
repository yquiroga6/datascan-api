namespace WebApi.Controllers;

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
//using WebApi.Models.Persons;
using WebApi.Services;

[ApiController]
[Route("[controller]")]
public class ProductoController : ControllerBase
{
    private IProductoService _productoService;
    private IMapper _mapper;

    public ProductoController(
        IProductoService productoService,
        IMapper mapper)
    {
        _productoService = productoService;
        _mapper = mapper;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        var productos = _productoService.GetAll();
        return Ok(productos);
    }

    [HttpGet("{id}")]
    public IActionResult GetById(string id)
    {
        var product = _productoService.GetById(id);
        return Ok(product);
    }
}