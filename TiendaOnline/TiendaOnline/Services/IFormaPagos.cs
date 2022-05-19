using TiendaOnline.Models;

namespace TiendaOnline.Services
{
    public interface IFormaPagos
    {
        public void AddFormaPago(FormaPagos forP);
        public void UpdateFormaPago(FormaPagos forP);

        public void DeleteFormaPago(FormaPagos forP);

        public List<FormaPagos> GetAll();

        public FormaPagos loadFormaPago(FormaPagos forP);
    }
}
