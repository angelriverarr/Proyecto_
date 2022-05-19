using Microsoft.EntityFrameworkCore;
using TiendaOnline.Models;

namespace TiendaOnline.Data
{
    public class ApplicationDBContext: DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
           : base(options)
        {
        }
        //genera el codigo para la migracion de las tablas
        protected override void OnModelCreating(ModelBuilder modelBuilder)//al momento que se ejecuta crea la tabla
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
