using Base_Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class CN_Disquera
    {
        Base_AzureDataContext db = new Base_AzureDataContext();
        public disquera AgregarDisquera(string nombre)
        {
            disquera d = new disquera();
            d.nombre = nombre;
            db.disquera.InsertOnSubmit(d);
            db.SubmitChanges();
            return d;
        }
        public disquera BuscarDisquera(string nombre)
        {
            disquera ar = null;

            var disq = from a in db.disquera
                       where a.nombre == nombre
                       select a;
            foreach (disquera a in disq)
            {
                if (a == null)
                {
                    ar = AgregarDisquera(nombre);
                    return ar;
                }
                else
                {
                    return a;
                }

            }
            return ar;
        }
        public IQueryable<disquera> CargarDisquera()
        {
            Base_AzureDataContext db = new Base_AzureDataContext();
            var disq = from a in db.disquera
                       select a;
            return disq;
        }
    }
    
}
