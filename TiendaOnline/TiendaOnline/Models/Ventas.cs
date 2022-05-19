using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace TiendaOnline.Models
{
    public class Ventas
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int VentaId { get; set; }
        public DateTime Fecha { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioV { get; set; }
        public decimal SubTotal { get; set; }

        public int ArticuloID { get; set; }
        public int ClienteID { get; set; }
        public int FormaPagoID { get; set; }


        public Articulos Articulo { get; set; }
        public Clientes Cliente { get; set; }
        public Pagos Pago { get; set; }

        public ICollection<DetalleVentas> DetalleVentas { get; set; }
    }
}
