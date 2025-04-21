namespace ProyectoFinalGestionInventario.Models
{
    public class Cliente
    {
        public int Id { get; set; }  /// Aqui definimos la llave primaria de nuestra clase cliente
        
        public string Nombre { get; set; }

        public int Cedula { get; set; }

        public virtual ICollection<ClienteProducto> ClienteProductos { get; set; }

    }
}
