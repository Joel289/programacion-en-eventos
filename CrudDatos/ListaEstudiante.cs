using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudDatos
{
    public class ListaEstudiante
    {
        private ArrayList ListE;

        public ListaEstudiante()
        {
            ListE = new ArrayList();
        }
        public void setListaE(ArrayList e)
        {
            ListE = e;
        }
        public ArrayList getListaE()
        {
            return ListE;
        }
        public void agregarEstudiante(Estudiante e)
        {
            ListE.Add(e);

        }
        public void eliminarEstudiante(Estudiante e)
        {
            ListE.Remove(e);
        }
        public Boolean buscarEstudiante(Estudiante e)
        {
            Boolean retorno = false;
            foreach(Estudiante i in ListE)
            {
                if(i.Id == e.Id)
                {
                    retorno = true;
                }
            }
            return retorno;
        }
        public void editarEstudiante(int vid,int columna, string variable)
        {
            foreach(Estudiante i in ListE)
            {
                if (i.Id == vid)
                    if (columna == 1)
                        i.Edad = int.Parse(variable);
                    else if (columna == 2)
                        i.Nombre = variable;
                    else if (columna == 3)
                        i.Contraseña = variable;
            }
        }
        public Estudiante buscarEstudiante(int vId)
        {
            foreach(Estudiante i in ListE)
            {
                if (i.Id == vId)
                    return i;

            }
            return null;
        }

        public int contar()
        {
            return ListE.Count;
        }
        public void imprimir()
        {
            foreach(Estudiante i in ListE)
            {
                Console.WriteLine(i);
            }
        }
    }
    
}
