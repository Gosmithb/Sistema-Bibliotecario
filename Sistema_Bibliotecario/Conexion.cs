using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Bibliotecario
{
    class Conexion
    {
        public static MySqlConnection conexion()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=sistema_bibliotecario_db;";

            try
            {
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);

                return databaseConnection;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }



        }
    }
}
