using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Base_Datos;

namespace Negocio
{
    public class CN_Tienda
    {
        Base_AzureDataContext db = new Base_AzureDataContext();
        public tienda crearTienda(string nombre, string direccion, string ruc, string telefono)
        {
            tienda ti = new tienda();
            ti.nombre_tienda = nombre;
            ti.direccion_tienda = direccion;
            ti.ruc = ruc;
            ti.telefono = telefono;

            db.tienda.InsertOnSubmit(ti);
            db.SubmitChanges();
            return ti;
        }

        public tienda BuscarTienda(string nombre)
        {
            Base_AzureDataContext db = new Base_AzureDataContext();
            tienda t =  null;

            var tie = from a in db.tienda
                        where a.nombre_tienda == nombre
                        select a;
            foreach (tienda a in tie)
            {
                return a;
            }
            return t;

        }


        public IQueryable<tienda> cargarTienda()
        {
            Base_AzureDataContext db = new Base_AzureDataContext();
            var tiendas = from t in db.tienda
                      select t;
            return tiendas;
        }

    }
}
