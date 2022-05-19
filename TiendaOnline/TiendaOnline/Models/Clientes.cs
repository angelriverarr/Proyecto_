using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace TiendaOnline.Models
{
    public class Clientes
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int ClienteId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Clave { get; set; }

        public int DepartamentoID { get; set; }
        public int MunicipioID { get; set; }
        public int TipoUsuarioID { get; set; }

        public Departamentos Departamento { get; set; }
        public Municipios Municipio { get; set; }
        public TipoUsuarios TipoUsuario { get; set; }

        public ICollection<Ventas> Ventas { get; set; }
    }
}
