using TiendaOnline.Models;

namespace TiendaOnline.Services
{
    public interface IArticulos
    {
        public void AddArticulo(Articulos ar);
        public void UpdateAticulo(Articulos ar);

        public void DeleteArticulo(Articulos ar);

        public List<Articulos> GetAll();

        public Articulos loadArticulo(Articulos ar);
        
        //comit

    }
}
