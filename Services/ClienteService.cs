namespace WebApi.Services;

using AutoMapper;
using BCrypt.Net;
using WebApi.Entities;
using WebApi.Helpers;

public interface IClienteService
{
    IEnumerable<Cliente> GetAll();
    Cliente GetById(string id);
}

public class ClienteService : IClienteService
{
    private ClienteDataContext _context;
    private readonly IMapper _mapper;

    public ClienteService(
        ClienteDataContext context,
        IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public IEnumerable<Cliente> GetAll()
    {
        return _context.Clientes;
    }

    public Cliente GetById(string id)
    {
        return getCliente(id);
    }

    // helper methods

    private Cliente getCliente(string id)
    {
        var cliente = _context.Clientes.Find(id);
        if (cliente == null) throw new KeyNotFoundException("Cliente no encontrado");
        return cliente;
    }
}