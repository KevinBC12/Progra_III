using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using ProyectoFinalGestionInventario.Areas.Identity.Data;

namespace ProyectoFinalGestionInventario.Models
{
    public class ClienteProducto
    {
        [Key]
        public int Id { get; set; } /// Aqui definimos la llave primaria de nuestra clase ClienteProductos
        public int ProductoId { get; set; }
        public int ClienteId { get; set; }
        [ForeignKey("ProductoId")]
        public virtual Producto Producto { get; set; }
        [ForeignKey("ClienteId")]
        public virtual Cliente Cliente { get; set; }
    }
}
