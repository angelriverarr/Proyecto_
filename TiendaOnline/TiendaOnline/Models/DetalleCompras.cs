using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace TiendaOnline.Models
{
    public class DetalleCompras
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int DetalleCompraId { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }

        public int CompraID { get; set; }
        public Compras Compras { get; set; }

    }
}
