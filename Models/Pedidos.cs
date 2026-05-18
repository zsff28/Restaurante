using Microsoft.EntityFrameworkCore;

namespace Restaurante.Models
{
    public class Pedido
    {
        public int Id { get; set; }

        // Clave Foránea
        public int ReservacionId { get; set; }

        // Propiedad de navegación: Un pedido pertenece a una reservación
        public virtual Reservacion? Reservacion { get; set; }
        public int ProductoApiId { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
    }
}
