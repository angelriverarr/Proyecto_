using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace TiendaOnline.Models
{
    public class FormaPagos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int FormaPagoId { get; set; }
        public string FormaPago { get; set; }

        public ICollection<Pagos> Pagos { get; set; }
    }
}
