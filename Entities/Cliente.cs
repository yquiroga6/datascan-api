namespace WebApi.Entities;

using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;

public class Cliente
{
    [Key]
    public string Cedula { get; set; }
    public string Nombre { get; set; }
    public string Telefono { get; set; }
}