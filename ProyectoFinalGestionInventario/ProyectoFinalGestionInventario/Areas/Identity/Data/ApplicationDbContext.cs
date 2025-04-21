using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProyectoFinalGestionInventario.Areas.Identity.Data;
using ProyectoFinalGestionInventario.Models;

namespace ProyectoFinalGestionInventario.Data;

public class ApplicationDbContext : IdentityDbContext<Usuario>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)  
        ///El ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        //nos da el acceso a la libreria DbContect para ser utilizada en el programa

        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }

public DbSet<ProyectoFinalGestionInventario.Models.Cliente> Cliente { get; set; } = default!;

public DbSet<ProyectoFinalGestionInventario.Models.Producto> Producto { get; set; } = default!;

public DbSet<ProyectoFinalGestionInventario.Models.ClienteProducto> ClienteProducto { get; set; } = default!;
}
