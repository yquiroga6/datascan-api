namespace WebApi.Entities;

using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;

public class DetalleFactura
{
    [Key]
    public int NumTRX { get; set; }
    public string Producto { get; set; }
    public int Cantidad { get; set; }
    public int Precio { get; set; }
    public float Descuento { get; set; }
    public int Total { get; set; }
}