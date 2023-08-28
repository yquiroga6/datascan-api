namespace WebApi.Entities;

using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;

public class Factura
{
    public DateTime Fecha { get; set; }
    public string Cliente { get; set; }
    [Key]
    public int NumTRX { get; set; }
}