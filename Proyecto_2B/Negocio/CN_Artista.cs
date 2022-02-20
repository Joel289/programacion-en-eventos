using Base_Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class CN_Artista
    {
        Base_AzureDataContext db = new Base_AzureDataContext();
        public artista CrearArtista(string nombre)
        {
            artista a = new artista();
            a.nombre_artistico = nombre;
            db.artista.InsertOnSubmit(a);
            db.SubmitChanges();
            return a;
        }
        public artista BuscarArtista(string nombre)
        {
            artista ar = null;

            var arti = from a in db.artista
                       where a.nombre_artistico == nombre
                       select a;
            foreach (artista a in arti)
            {
                if (a == null)
                {
                    ar = CrearArtista(nombre);
                    return ar;
                }
                else
                {
                    return a;
                }

            }
            return ar;

        }
        public IQueryable<artista> CargarArtista()
        {
            Base_AzureDataContext db = new Base_AzureDataContext();
            var disq = from a in db.artista
                       select a;
            return disq;
        }
        public artista ObtenerArtista(int id)
        {
            var nombrea = from m in db.album_venta
                          join n in db.artista on m.album_artista_id equals n.id
                          where m.id == id
                          select n;
            artista ar = new artista();
            ar = (artista)nombrea.First();
            return ar;
        }
    }
}
