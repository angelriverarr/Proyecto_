using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TiendaOnline.Models
{
    public class DetalleVentas
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int DetalleVentaId { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }

        public int VentaID { get; set; }
        public Ventas Venta { get; set; }
        
    }
}
