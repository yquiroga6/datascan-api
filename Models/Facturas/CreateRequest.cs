namespace WebApi.Models.Facturas;

using System.ComponentModel.DataAnnotations;
using WebApi.Entities;

public class CreateRequest
{
    [Required]
    public DateTime Fecha { get; set; }

    [Required]
    public string Cliente { get; set; }

    public int NumTRX { get; set; }
}