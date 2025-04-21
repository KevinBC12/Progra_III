using System.ComponentModel.DataAnnotations;

namespace ProyectoFinalGestionInventario.Models
{
    public class Producto /// Aqui definimos la llave primaria de nuestra clase Producto
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public double Precio { get; set; }
        public string UbicacionInventario { get; set; }
        public virtual ICollection<ClienteProducto> ClienteProductos { get; set; }
    }
}
