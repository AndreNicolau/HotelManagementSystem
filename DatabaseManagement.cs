using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    internal class DatabaseManagement
    {
        public string connectionString = "server=localhost;uid=root;pwd=;database=hoteldatabase";

        public void CreateDatabaseAndTables()
        {
            string createDatabaseCommand = "CREATE DATABASE HotelDatabase;";

            try
            {
                MySqlConnection connection = new MySqlConnection(connectionString);
                MySqlDataAdapter adapter = new MySqlDataAdapter(createDatabaseCommand, connection);

                connection.Open();

                // Execute the command 

                connection.Close();

            }
            catch (Exception ex)
            {

                string message = $"Não foi possível criar a base de dados! Erro: {ex}";
                string caption = "Erro ao criar a base de dados";

                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);
            }
        }

        public void CreateTables()
        {
            //string createUserTableCommand = "CREATE TABLE Users_Table(userID int, firstName varchar(50), lastName varchar(50), password varchar(50););";
            //string createEmployeesTableCommand = "";
        }

        public void FetchUsers()
        {
            string fetchUsersCommand = "SELECT * FROM users_table";

            try
            {
                MySqlConnection connection = new MySqlConnection(connectionString);
                MySqlDataAdapter adapter = new MySqlDataAdapter(fetchUsersCommand, connection);

                DataTable usersDataTable = new DataTable();

                adapter.Fill(usersDataTable);
            }
            catch (Exception ex)
            {
                string message = $"Não foi possível obter os dados dos utilizadores a partir da base de dados! Erro: {ex}";
                string caption = $"Erro ao obter os dados dos utilizadores!";
            }
        }
    }
}
