using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DientesLimpios.Persistencia.Utilidades
{
    public static class IQueryableExtensions
    {
        public static IQueryable<T> Paginar<T>(this IQueryable<T> queryable, int page, int registerPerPage)
        {
            return queryable.Skip((page -1)*registerPerPage).Take(registerPerPage);
        }
    }
}
