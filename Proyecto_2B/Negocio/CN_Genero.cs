using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio;
using Base_Datos;

namespace Negocio
{
    public class CN_Genero
    {
        public IQueryable<genero_musical> CargarGeneros()
        {
            Base_AzureDataContext db = new Base_AzureDataContext();
            var disq = from b in db.genero_musical
                       select b;
            return disq;
        }
        public genero_musical BuscarGenero(string nombre)
        {
            genero_musical ar = null;
            Base_AzureDataContext db = new Base_AzureDataContext();
            var arti = from a in db.genero_musical
                       where a.nombre == nombre
                       select a;
            foreach (genero_musical a in arti)
            {
                if (a == null)
                {
                    ar = CrearGenero(nombre);
                    return ar;
                }
                else
                {
                    return a;
                }

            }
            return ar;

        }
        public genero_musical CrearGenero(string nombre)
        {
            Base_AzureDataContext db = new Base_AzureDataContext();
            genero_musical a = new genero_musical();
            a.nombre= nombre;
            db.genero_musical.InsertOnSubmit(a);
            db.SubmitChanges();
            return a;
        }
    }
    

}
