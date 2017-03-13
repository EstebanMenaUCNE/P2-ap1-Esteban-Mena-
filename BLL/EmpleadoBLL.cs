using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace BLL
{
    public class EmpleadoBLL
    {
        public static bool Guardar(Entidades.Empleado empleado)
        {
            using (var repositorio = new Repositorio<Entidades.Empleado>())
            {
                if (Buscar(empleado.EmpleadoId) == null)
                {
                    Console.WriteLine("\n\nGuardando\n");
                    return repositorio.Guardar(empleado);
                }
                else
                {
                    Console.WriteLine("\n\nModificando\n");
                    return repositorio.Modificar(empleado);
                }
            }
        }

        public static Entidades.Empleado Buscar(int id)
        {
            using (var repositorio = new Repositorio<Entidades.Empleado>())
            {
                return repositorio.Buscar(R => R.EmpleadoId == id);
            }
        }

        public static bool Eliminar(Entidades.Empleado empleado)
        {
            using (var repositorio = new Repositorio<Entidades.Empleado>())
            {
                return repositorio.Eliminar(empleado);
            }
        }

        public static List<Entidades.Empleado> GetList(Expression<Func<Entidades.Empleado, bool>> criterioBusqueda)
        {
            using (var repositorio = new Repositorio<Entidades.Empleado>())
            {
                return repositorio.GetList(criterioBusqueda);
            }
        }

    }
}
