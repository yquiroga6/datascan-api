namespace WebApi.Controllers;

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
//using WebApi.Models.Persons;
using WebApi.Services;

[ApiController]
[Route("[controller]")]
public class ClienteController : ControllerBase
{
    private IClienteService _clienteService;
    private IMapper _mapper;

    public ClienteController(
        IClienteService clienteService,
        IMapper mapper)
    {
        _clienteService = clienteService;
        _mapper = mapper;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        var clientes = _clienteService.GetAll();
        return Ok(clientes);
    }

    [HttpGet("{id}")]
    public IActionResult GetById(string id)
    {
        var user = _clienteService.GetById(id);
        return Ok(user);
    }
}