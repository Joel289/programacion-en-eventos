using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Base_Datos;

namespace Negocio
{
    public class CN_Usuario
    {
        public usuario ObtenerUsuario(string nombreUsuario)
        {
            usuario u = new usuario();
            Base_AzureDataContext db = new Base_AzureDataContext();
            var usuario = from b in db.usuario
                          where b.nombre_usuario == nombreUsuario
                          select b;
            u = usuario.First();
            return u;
        }
    }
}
