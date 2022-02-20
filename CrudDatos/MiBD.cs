using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CrudDatos
{
    public class MiBD
    {
        private static SqlConnection conexion;
        public static SqlConnection obtenerConexion()
        {

            conexion = new SqlConnection("Data Source=LAPTOP-KL07H5O1;Initial Catalog=CrudEstudiante;Integrated Security=True");
            conexion.Open();
            return conexion;

        }
        public static void desconectar()
        {
            if (conexion != null)
            {
                conexion.Close();
            }
        }
        ///Base de Datos
        ///
        /*
         use CrudEstudiante
            go 
            create table Estudiante(
            id int IDENTITY(1,1),
            nombre varchar(50) not null,
            contrasenia varchar(50) not null,
            edad int not null
            PRIMARY KEY (id)
            );
            go
            --drop table Estudiante
            INSERT INTO Estudiante 
              VALUES ('Juan Perez','A123',18);
              INSERT INTO Estudiante 
              VALUES ('Luis Torres','B123',20);
              INSERT INTO Estudiante 
              VALUES ('Maria Perez','C123',30);
              INSERT INTO Estudiante
              VALUES ('Luisa Perez','D123',25);
              INSERT INTO Estudiante
              VALUES ('Tomas Solis','E123',19);
         */
    }
}
