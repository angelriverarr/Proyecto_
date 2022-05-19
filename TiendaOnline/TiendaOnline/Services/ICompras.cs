using TiendaOnline.Models;

namespace TiendaOnline.Services
{
    public interface ICompras
    {
        public void AddCompra(Compras comp);
        public void UpdateCompra(Compras comp);

        public void DeleteCompra(Compras comp);

        public List<Compras> GetAll();

        public Compras loadCompra(Compras comp);
    }
}
