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

        private void Search_User_Btn_Click(object sender, EventArgs e)
        {
            
        }

        private void SaveUser_Btn_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO users(first_name, last_name, address, age, curp) VALUES ('"+ first_name_Tbx.Text + "', '"+last_name_Tbx.Text + "','"+ address_Tbx.Text + "', '"+ int.Parse(age_Tbx.Text)+"', '"+curp_Tbx.Text + "')";
            MySqlConnection databaseConnection = Conexion.conexion();
            databaseConnection.Open();

            try
            {
                MySqlCommand command = new MySqlCommand(sql, databaseConnection);
                command.ExecuteNonQuery();
                // Se intenta dar el ID al usuario al registrarse para poder identificarse facilmente
                string queryId = "SELECT id FROM users WHERE first_name LIKE '" + first_name_Tbx.Text + "'";
                //***********************************************************************************
                MessageBox.Show("Registro Guardado, tu ID es: " + queryId); // Muestra todo un string y no solo el ID asignado
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
            finally
            {
                databaseConnection.Close();
            }
        }


        private void listUsers_Btn_Click(object sender, EventArgs e)
        {
           
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
