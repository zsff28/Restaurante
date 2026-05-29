namespace Restaurante.Models
{
    public class Reservacion
    {
        public int Id { get; set; }

        // Clave Foránea
        public int ClienteId { get; set; }

        // Propiedad de navegación. Define la relación con la tabla (un reservación pertenece a un cliente). Permite conocer los valores de clientes.
        public virtual Cliente? Cliente { get; set; }
        public DateTime Fecha { get; set; }
        public decimal? Total { get; set; }
        public string Estado { get; set; } = "Confirmada";
    }
}
