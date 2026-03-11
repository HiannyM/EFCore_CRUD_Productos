using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;    

namespace EFCore_CRUD.Models.Productos.Models;

public class Producto
{
    public int Id { get; set; }
    [Required]
    public string Nombre { get; set; }
    [Precision(10, 2)]
    public decimal Precio { get; set; }
    public int Stock { get; set; }
}