using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace BLL
{
    public class TipoEmailBLL
    {
        public static bool Guardar(TiposEmails tipoEmail)
        {
            using (var repositorio = new Repositorio<TiposEmails>())
            {
                if (Buscar(tipoEmail.TipoId) == null)
                {
                    return repositorio.Guardar(tipoEmail);
                }
                else
                {
                    return repositorio.Modificar(tipoEmail);
                }
            }
        }

        public static TiposEmails Buscar(int id)
        {
            using (var repositorio = new Repositorio<TiposEmails>())
            {
                return repositorio.Buscar(R => R.TipoId == id);
            }
        }

        public static bool Eliminar(TiposEmails tipoEmail)
        {
            using (var repositorio = new Repositorio<TiposEmails>())
            {
                return repositorio.Eliminar(tipoEmail);
            }
        }

        public static List<Entidades.TiposEmails> GetList(Expression<Func<Entidades.TiposEmails, bool>> criterioBusqueda)
        {
            using (var repositorio = new Repositorio<Entidades.TiposEmails>())
            {
                return repositorio.GetList(criterioBusqueda);
            }
        }

    }
}
