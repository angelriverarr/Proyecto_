using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TiendaOnline.Models
{
    public class Pagos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int PagoId { get; set; }
        public string Codtransaccion { get; set; }
        public DateTime Fecha { get; set; }

        public int FormaPagoID { get; set; }
        public FormaPagos FormaPago { get; set; }

        public ICollection<Ventas> Ventas { get; set; }
    }
}
