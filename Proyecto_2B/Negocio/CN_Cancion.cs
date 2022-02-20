using Base_Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Negocio
{
    public class CN_Cancion
    {
        public IQueryable CargarCancion(int id)
        {
            Base_AzureDataContext db = new Base_AzureDataContext();
            var canciones = from a in db.cancion_album
                            join b in db.cancion on a.cancion_id equals b.id_cancion
                            where a.album_id == id
                            select new { Nombre = b.nombre, Duración = b.duracion };
            
            return canciones;
        }
        public void CrearCancion(string nombre, string duracion, byte[] foto, string nRepro, string genero, album_venta album)
        {
            try
            {
                Base_AzureDataContext bd = new Base_AzureDataContext();
                CN_Genero ge = new CN_Genero();
                genero_musical g = ge.BuscarGenero(genero);
                bd.ingreso_cancion(nombre, duracion, foto,Int32.Parse(nRepro), g.id);
                cancion c = BuscarCancion(nombre);
                bd.ingreso_cancion_album(c.id_cancion,album.id);
                
            }
            catch (Exception ex)// en caso de falla en el string comando
            {
                Console.WriteLine("Error: " + ex.Message);//Mensaje de la bd
            }

        }
        public cancion BuscarCancion(string nombre)
        {
            Base_AzureDataContext db = new Base_AzureDataContext();
            cancion ar = null;

            var arti = from a in db.cancion
                       where a.nombre == nombre
                       select a;
            foreach (cancion a in arti)
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

    }
}
