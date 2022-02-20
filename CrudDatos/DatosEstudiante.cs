using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CrudDatos
{
    class DatosEstudiante
    {
        private SqlConnection conexion = new SqlConnection();
        
        public DataTable TablaEstudiante()
        {
            DataTable dt = new DataTable();//crear un data table para almacenar los datos 
            conexion = MiBD.obtenerConexion();// se obtiene la conexion a traves de un metodo estatico
            string comando = "Select * from Estudiante";// se asigna el comando a ejecutar
            SqlDataAdapter adapter = new SqlDataAdapter();// creacion de un adapter para interactuar con la fuente de datos
            try
            {
                adapter.SelectCommand = new SqlCommand(comando, conexion);//La SelectCommandpropiedad de DataAdapteres un Commandobjeto que recupera datos de la fuente de datos.
                adapter.Fill(dt);//El Fill del DataAdapter se utiliza para rellenar una DataSetcon los resultados de la SelectCommandde la DataAdapter.
                MiBD.desconectar();// se desconecta de la BD
            }
            catch (Exception ex)// en caso de falla en el string comando
            {
                Console.WriteLine("Error: " + ex.Message);//Mensaje de la bd
            }
            return dt;
        }
        public bool EliminarEstudiante(string id)
        {
            bool retorno = false;
            string comando = "DELETE FROM Estudiante WHERE id = "+id;
            SqlDataAdapter adapter = new SqlDataAdapter();
            try
            {
                conexion = MiBD.obtenerConexion();
                adapter.InsertCommand = new SqlCommand(comando, conexion);
                adapter.InsertCommand.ExecuteNonQuery();
                MiBD.desconectar();
                return retorno = true;
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error" + ex.Message);
                return retorno;
            }
        }

        public bool AgregarEstudiante(Estudiante e)
        {
            bool retorno = false;
            string comando = "INSERT INTO Estudiante VALUES('"+e.Nombre+"', '"+e.Contraseña+"', "+e.Edad+"); " ;
            SqlDataAdapter adapter = new SqlDataAdapter();
            try
            {
                conexion = MiBD.obtenerConexion();
                adapter.InsertCommand = new SqlCommand(comando, conexion);
                adapter.InsertCommand.ExecuteNonQuery();
                MiBD.desconectar();
                return retorno = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex.Message);
                return retorno;
            }
        }
        
    }
}
