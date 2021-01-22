using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Sistema_Bibliotecario
{
    public partial class Form1 : Form
    {
        string connectionString = "datasource=127.0.0.1; username=root;password=;database=usuarios;";
        string query = "SELECT * FROM usuarios";

        

        public Form1()
        {
            InitializeComponent();
        }

        private void conectar_Btn_Click(object sender, EventArgs e)
        {
            // Prepara la conexión
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;


            try
            {
                //Abrir base de datos
                databaseConnection.Open();
                //Ejecutar las consultas
                reader = commandDatabase.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3) };
                    }
                }
                else
                {
                    Console.WriteLine("No se encontraton datos.");
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SaveUser_Btn_Click(object sender, EventArgs e)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=usuarios;";
            string query = "INSERT INTO usuarios(`id`, `nombre`, `apellido_paterno`, `apellido_materno`) VALUES (NULL, '" + nombre_Tbx.Text + "', '" + apellidoPaterno_Tbx.Text + "', '" + apellidoMaterno_Tbx.Text + "')";
            // Que puede ser traducido con un valor a:
            // INSERT INTO user(`id`, `first_name`, `last_name`, `address`) VALUES (NULL, 'Bruce', 'Wayne', 'Rodriguez')

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                MessageBox.Show("Usuario insertado satisfactoriamente");

                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                // Mostrar cualquier error
                MessageBox.Show(ex.Message);
            }
        }


        private void listUsers_Btn_Click(object sender, EventArgs e)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=usuarios;";
            // Seleccionar todo
            string query = "SELECT * FROM usuarios";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();


                // Si se encontraron datos
                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        //                   ID                              Nombre                   Apellido Paterno               Apellido Materno
                        Console.WriteLine(reader.GetString(0) + " - " + reader.GetString(1) + " - " + reader.GetString(2) + " - " + reader.GetString(3));
                        // Ejemplo para mostrar en el listView :
                        string[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3) };
                        var listViewItem = new ListViewItem(row);
                        usersList_Lv.Items.Add(listViewItem);
                    }
                }
                else
                {
                    Console.WriteLine("No se encontro nada");
                }

                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteUser_Btn_Click(object sender, EventArgs e)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=usuarios;";
            // Borrar la fila con ID 1
            string query = "DELETE FROM `usuarios` WHERE id = 1";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();

                // Eliminado satisfactoriamente

                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                // Ops, quizás el id no existe
                MessageBox.Show(ex.Message);
            }
        }

        private void updateUser_Btn_Click(object sender, EventArgs e)
        {
            string connectionString = "datasource=127.0.0.1;username=root;password=;database=usuarios;";
            //Actualizar la fila user con ID 1
            string query = "UPDATE `usuarios` SET `nombre`= 'Willy',`apellido_paterno`='Wonka',`apellido_materno`='perez' WHERE id = 1";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();

                // Actualizadosatisfactoriamente
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                // Error
                MessageBox.Show(ex.Message);
            }
        }
    }
}
