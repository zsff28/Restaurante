namespace Restaurante.Models
{
    public class Reservacion
    {
        public int Id { get; set; }

        // Clave Foránea
        public int ClienteId { get; set; }

        // Propiedad de navegación: Un pedido pertenece a un cliente
        public virtual Cliente? Cliente { get; set; }
        public DateTime Fecha { get; set; }
        public decimal? Total { get; set; }
        public bool Estado { get; set; }
    }
}
