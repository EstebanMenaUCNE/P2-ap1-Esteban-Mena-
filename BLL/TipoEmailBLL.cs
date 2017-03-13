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
        public static bool Guardar(TipoEmail tipoEmail)
        {
            using (var repositorio = new Repositorio<TipoEmail>())
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

        public static TipoEmail Buscar(int id)
        {
            using (var repositorio = new Repositorio<TipoEmail>())
            {
                return repositorio.Buscar(R => R.TipoId == id);
            }
        }

        public static bool Eliminar(TipoEmail tipoEmail)
        {
            using (var repositorio = new Repositorio<TipoEmail>())
            {
                return repositorio.Eliminar(tipoEmail);
            }
        }

        public static List<Entidades.TipoEmail> GetList(Expression<Func<Entidades.TipoEmail, bool>> criterioBusqueda)
        {
            using (var repositorio = new Repositorio<Entidades.TipoEmail>())
            {
                return repositorio.GetList(criterioBusqueda);
            }
        }

    }
}
