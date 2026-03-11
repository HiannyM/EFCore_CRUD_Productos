using EFCore_CRUD.Models.Productos.Models;
using EFCore_CRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCore_CRUD.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Producto> Productos { get; set; }
}
