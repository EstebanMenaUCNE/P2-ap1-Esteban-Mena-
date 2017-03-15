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
        public static bool Guardar(Retenciones retencion)
        {
            using (var repositorio = new Repositorio<Retenciones>())
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

        public static Retenciones Buscar(int id)
        {
            using (var repositorio = new Repositorio<Retenciones>())
            {
                return repositorio.Buscar(R => R.RetencionId == id);
            }
        }

        public static bool Eliminar(Retenciones retencion)
        {
            using (var repositorio = new Repositorio<Retenciones>())
            {
                return repositorio.Eliminar(retencion);
            }
        }

        public static List<Entidades.Retenciones> GetList(Expression<Func<Entidades.Retenciones, bool>> criterioBusqueda)
        {
            using (var repositorio = new Repositorio<Entidades.Retenciones>())
            {
                return repositorio.GetList(criterioBusqueda);
            }
        }

    }
}
