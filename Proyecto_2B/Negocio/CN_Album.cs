using Base_Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class CN_Album
    {
        
        
        public void CrearAlbum(string nombre, string precio, string artista, string cantidad, string disq,byte[] foto)
        {
            try
            {
                Base_AzureDataContext bd = new Base_AzureDataContext();
                CN_Artista ar = new CN_Artista();
                CN_Disquera di = new CN_Disquera();
                artista a =  ar.BuscarArtista(artista);
                disquera d = di.BuscarDisquera(disq);
                if(a == null)
                {
                    a = ar.CrearArtista(artista);
                }
                if (d == null)
                {
                    d = di.AgregarDisquera(disq);
                }
                bd.ingreso_album_venta(nombre, foto, a.id, Convert.ToDecimal(precio), Int32.Parse(cantidad), d.id_disquera);
                
            }
            catch (Exception ex)// en caso de falla en el string comando
            {
                Console.WriteLine("Error: " + ex.Message);//Mensaje de la bd
            }
            
        }
        public IQueryable<album_venta> CargarAlbunes()
        {
            Base_AzureDataContext db = new Base_AzureDataContext();
            var alb = from a in db.album_venta
                       select a;
            return alb;
        }
        public album_venta BuscarAlbum(string nombre)
        {
            Base_AzureDataContext db = new Base_AzureDataContext();
            album_venta ar = null;

            var arti = from a in db.album_venta
                       where a.nombre == nombre
                       select a;
            foreach (album_venta a in arti)
            {
                if (a == null)
                {
                    return ar;
                }
                else
                {
                    return a;
                }

            }
            return ar;

        }
        public album_venta CargarAPantalla(int id)
        {
            Base_AzureDataContext db = new Base_AzureDataContext();
            var titulo = from c in db.album_venta
                         where c.id == id
                         select c;
            album_venta av = new album_venta();
            av = (album_venta)titulo.First();
            return av;
        }
    }
}
