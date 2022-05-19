using TiendaOnline.Models;

namespace TiendaOnline.Services
{
    public interface IDetalleCompras
    {
        public void AddDetalleCompra(DetalleCompras detalleC);
        public void UpdateDetalleCompra(DetalleCompras detalleC);

        public void DeleteDetalleCompra(DetalleCompras detalleC);

        public List<DetalleCompras> GetAll();

        public DetalleCompras loadDetalleCompra(DetalleCompras detalleC);
    }
}
