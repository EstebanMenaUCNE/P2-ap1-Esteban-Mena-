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
        public static bool Guardar(Entidades.Empleados empleado)
        {
            using (var repositorio = new Repositorio<Entidades.Empleados>())
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

        public static Entidades.Empleados Buscar(int id)
        {
            using (var repositorio = new Repositorio<Entidades.Empleados>())
            {
                return repositorio.Buscar(R => R.EmpleadoId == id);
            }
        }

        public static bool Eliminar(Entidades.Empleados empleado)
        {
            using (var repositorio = new Repositorio<Entidades.Empleados>())
            {
                return repositorio.Eliminar(empleado);
            }
        }

        public static List<Entidades.Empleados> GetList(Expression<Func<Entidades.Empleados, bool>> criterioBusqueda)
        {
            using (var repositorio = new Repositorio<Entidades.Empleados>())
            {
                return repositorio.GetList(criterioBusqueda);
            }
        }

    }
}
