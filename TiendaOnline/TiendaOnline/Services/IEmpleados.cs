using TiendaOnline.Models;

namespace TiendaOnline.Services
{
    public interface IEmpleados
    {
        public void AddEmpleado(Empleados emp);
        public void UpdateEmpleado(Empleados emp);

        public void DeleteEmpleado(Empleados emp);

        public List<Empleados> GetAll();

        public Empleados loadEmpleado(Empleados emp);
    }
}
