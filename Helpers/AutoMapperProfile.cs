namespace WebApi.Helpers;

using AutoMapper;
using WebApi.Entities;
using WebApi.Models.Facturas;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        // CreateRequest -> Person
        CreateMap<CreateRequest, Factura>();
    }
}