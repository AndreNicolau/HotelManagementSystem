using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace HotelManagementSystem.Resources
{
    internal class Clients
    {
        private string message;
        private string caption;

        MessageBoxButtons buttons;
        DialogResult result;

        MySqlConnection connection = new MySqlConnection(Properties.Resources.connectionString);

        private void Insert(string firstName,
        string lastName,
        string phoneNumber,
        string email,
        string dateOfBirth)
        {
            MySqlCommand command = new MySqlCommand($"INSERT INTO clients_table (firstName, lastName, phoneNumber, email, dateOfBirth) VALUES ('{firstName}', '{lastName}', '{phoneNumber}', '{email}', '{dateOfBirth}')", connection);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                message = "Customer inserted successfully!\n Do you want to insert a new customer?";
                caption = "New customer";

                buttons = MessageBoxButtons.YesNo;
                result = MessageBox.Show(message, caption, buttons);
            }
            catch (Exception ex)
            {
                message = $"Não foi possível inserir o cliente na base de dados! Erro: \n{ex}";
                caption = $"Erro ao inserir o cliente!";

                buttons = MessageBoxButtons.OK;

                result = MessageBox.Show(message, caption, buttons);
            }
        }

        private void Update(int clientID,
        string newFirstName,
        string newLastName,
        string newPhoneNumber,
        string newEmail, string newDateOfBirth)
        {
            caption = "Updating client information";
            message = $"Are you sure that you would like to update this clients information?";

            buttons = MessageBoxButtons.YesNo;
            result = new DialogResult();

            MySqlCommand command = new MySqlCommand($"UPDATE clients_table " +
                $"SET firstName = '{newFirstName}', lastName = '{newLastName}', phoneNumber = '{newPhoneNumber}', email = '{newEmail}', dateOfBirth = '{newDateOfBirth}' " +
                $"WHERE clientID = '{clientID}' ", connection);

            result = MessageBox.Show(message, caption, buttons);

            if (result == DialogResult.Yes)
            {
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    caption = "Error updating client information";
                    message = $"It wasn't possible tu update the client information due to error:\n{ex} ";

                    buttons = MessageBoxButtons.OK;
                    result = MessageBox.Show(message, caption, buttons);
                }
            }
        }
    }
}
