namespace WebApi.Entities;

using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;

public class Producto
{
    [Key]
    public string Id { get; set; }
    public string Nombre { get; set; }
    public int Valor { get; set; }
}