using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace HotelManagementSystem.Forms
{
    public partial class NewClient : Form
    {
        string firstName;
        string lastName;
        string phoneNumber;
        string email;
        string dateOfBirth;

        public NewClient()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            firstName = txtFirstname.Text.Trim();
            lastName = txtLastName.Text.Trim();
            phoneNumber = txtPhoneNumber.Text.Trim();
            email = txtEmail.Text.Trim();
            dateOfBirth = dtpDateOfBirth.Value.ToString("yyyy-MM-dd");

            if (CheckTextBoxes() == true && DataExists() == false)
            {
                InsertDataIntoTable();
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool DataExists()
        {
            string command = "SELECT * FROM clients_table";

            MySqlConnection connection = new MySqlConnection(Properties.Resources.connectionString);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command, connection);
            DataTable clientsDataTable = new DataTable();

            adapter.Fill(clientsDataTable);

            //Check Phone Number
            DataRow[] foundPhoneNumber = clientsDataTable.Select($"phoneNumber = '{phoneNumber}'");
            if (foundPhoneNumber.Length != 0)
            {
                MessageBox.Show("This phone number already exists!");
                return true;
            }

            // Check Email
            DataRow[] foundEmail = clientsDataTable.Select($"email = '{email}'");
            if (foundEmail.Length != 0)
            {
                MessageBox.Show("This email already exists!");
                return true;
            }

            return false;
        }

        private bool CheckTextBoxes()
        {
            if (txtFirstname.Text == "")
            {
                MessageBox.Show("É necessário inserir o primeiro nome do cliente");
                return false;
            }
            else if (txtLastName.Text == "")
            {
                MessageBox.Show("É necessário inserir o último nome do cliente");
                return false;
            }
            else if (txtPhoneNumber.Text == "" && txtEmail.Text == "")
            {
                MessageBox.Show("É necessário pelo menus uma forma de contacto, email ou número de telemóvel");
                return false;
            }
            else if (DateTime.Now.Year - dtpDateOfBirth.Value.Year < 18)
            {
                MessageBox.Show("Não é possível registar clientes menores de idade!");
                return false;
            }

            return true;
        }

        private void InsertDataIntoTable()
        {
            string message;
            string caption;

            MySqlConnection connection = new MySqlConnection(Properties.Resources.connectionString);
            MySqlCommand insertCommand = new MySqlCommand($"INSERT INTO clients_table (firstName, lastName, phoneNumber, email, dateOfBirth) VALUES ('{firstName}', '{lastName}', '{phoneNumber}', '{email}', '{dateOfBirth}')", connection);

            MessageBoxButtons buttons;
            DialogResult result;

            try
            {
                connection.Open();
                insertCommand.ExecuteNonQuery();
                connection.Close();

                message = "Cliente inserido com sucesso!\n Deseja inserir um novo cliente?";
                caption = "Novo cliente";

                buttons = MessageBoxButtons.YesNo;
                result = MessageBox.Show(message, caption, buttons);

                if (result == DialogResult.No)
                {
                    this.Close();
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                message = $"Não foi possível inserir o cliente na base de dados! Erro: \n{ex}";
                caption = $"Erro ao inserir o cliente!";

                buttons = MessageBoxButtons.OK;

                result = MessageBox.Show(message, caption, buttons);
            }
        }
    }
}

