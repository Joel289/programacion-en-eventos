using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudDatos
{
    public class Estudiante
    {
        private static int aux = 0;
        private int id;
        private string nombre;
        private string contraseña;
        private int edad;

        public Estudiante(int edad, string Name, string Clave)
        {
            id = aux++;
            nombre = Name;
            contraseña = Clave;
            this.edad = edad;

        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }



        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Contraseña
        {
            get { return contraseña; }
            set { contraseña = value; }
        }


        public override string ToString()
        {
            return this.id + " " + this.nombre;
        }



    }
}
