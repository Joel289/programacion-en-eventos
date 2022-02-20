using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CrudDatos
{
    public class Negocio_Estudiante
    {
        private DatosEstudiante de = new DatosEstudiante();
        public DataTable ListaEstudiante()
        {
            return de.TablaEstudiante();
        }
        public string EliminarEstudiante(string id)
        {
            string retorno;
            if(de.EliminarEstudiante(id) == true)
            {
                return retorno = "El Estudiante con id " + id + " ha sido eliminado correctamente";
            }
            else
            {
                return retorno = "El estudiante no ha sido eliminado";
            }
        }

        public string CrearEstudiante(Estudiante e)
        {
            string retorno;
            if (de.AgregarEstudiante(e) == true)
            {
                return retorno = "Se ha agregado a el estudiante " + e.Nombre ;
            }
            else
            {
                return retorno = "El estudiante no ha sido agragado";
            }
        }
    }
}
