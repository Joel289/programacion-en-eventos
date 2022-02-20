using Base_Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class CN_Roles
    {
        public IQueryable<rol> CargarRoles()
        {
            Base_AzureDataContext db = new Base_AzureDataContext();
            var alb = from a in db.rol
                      select a;
            return alb;
        }
    }
}
