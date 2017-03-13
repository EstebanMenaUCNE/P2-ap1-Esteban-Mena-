using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace BLL
{
    public class RetencionBLL
    {
        public static bool Guardar(Retencion retencion)
        {
            using (var repositorio = new Repositorio<Retencion>())
            {
                if (Buscar(retencion.RetencionId) == null)
                {
                    Console.WriteLine("\n\nGuardando\n");
                    return repositorio.Guardar(retencion);
                }
                else
                {
                    Console.WriteLine("\n\nModificando\n");
                    return repositorio.Modificar(retencion);
                }
            }
        }

        public static Retencion Buscar(int id)
        {
            using (var repositorio = new Repositorio<Retencion>())
            {
                return repositorio.Buscar(R => R.RetencionId == id);
            }
        }

        public static bool Eliminar(Retencion retencion)
        {
            using (var repositorio = new Repositorio<Retencion>())
            {
                return repositorio.Eliminar(retencion);
            }
        }

        public static List<Entidades.Retencion> GetList(Expression<Func<Entidades.Retencion, bool>> criterioBusqueda)
        {
            using (var repositorio = new Repositorio<Entidades.Retencion>())
            {
                return repositorio.GetList(criterioBusqueda);
            }
        }

    }
}
