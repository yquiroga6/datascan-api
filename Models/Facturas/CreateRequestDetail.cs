namespace WebApi.Models.Facturas;

using System.ComponentModel.DataAnnotations;
using WebApi.Entities;

public class CreateRequestDetail
{
    [Required]
    public int NumTRX { get; set; }

    [Required]
    public List<DetalleFactura> detalles { get; set; }
}