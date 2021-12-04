using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
namespace CRUD_VILLEGAS
{
    class conexion
    {
        public static MySqlConnection abrirConexion()
        {
            string servidor = "localhost";
            string bd = "tic31";
            string usuario = "root";
            string contra = "";

            string cadenaConexion = "Database="+ bd +"; Data Source="+ servidor +"; User Id=" +usuario+ "; Password="+contra+";";

            try
            {
                MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);
                return conexionBD;
            }
            catch(MySqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            return null;
        }
        public static String ejecutarQuery(String sql,String mensaje)
        {
            MySqlConnection conexionBD = abrirConexion();

            try
            {
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                comando.ExecuteNonQuery();
                return mensaje;
            }
            catch (MySqlException ex)
            {
               
            }
            finally
            {
                conexionBD.Close();
            }
            return "";
        }
        public static DataTable ConsultaQuery(String sql)
        {
            MySqlConnection conexionBD = conexion.abrirConexion();
            DataTable datosTabla = new DataTable();
            try
            {
                conexionBD.Open();
                MySqlDataAdapter adaptador = new MySqlDataAdapter(sql, conexionBD);  
                adaptador.Fill(datosTabla);
            }
            catch (MySqlException ex)
            {
                
            }
            finally
            {
                conexionBD.Close();
            }
            return datosTabla;
        }
    }
}
