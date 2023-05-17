using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace HotelManagementSystem.Forms
{
    public partial class NewClient : Form
    {
        public NewClient()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstname.Text;
            string lastName = txtLastName.Text;
            string phoneNumber = txtPhoneNumber.Text;
            string emai = txtEmail.Text;
            string dateOfBirth = dtpDateOfBirth.Value.ToString("yyyy-MM-dd");

            if (txtFirstname.Text == "")
            {
                MessageBox.Show("É necessário inserir o primeiro nome do cliente");
            }
            else if (txtLastName.Text == "")
            {
                MessageBox.Show("É necessário inserir o último nome do cliente");
            }
            else if (txtPhoneNumber.Text == "" || txtEmail.Text == "")
            {
                MessageBox.Show("É necessário pelo menus uma forma de contacto, email ou número de telemóvel");
            }
            else if (DateTime.Now.Year - dtpDateOfBirth.Value.Year < 18)
            {
                MessageBox.Show("É necessário que a pessoa que esteja a realizar a reserva seja maior de 18 anos");
            }
            else
            {

                try
                {
                    MySqlConnection connection = new MySqlConnection(Properties.Resources.connectionString);
                    MySqlCommand insertCommand = new MySqlCommand($"INSERT INTO clients_table (firstName, lastName, phoneNumber, email, dateOfBirth) VALUES ('{firstName}', '{lastName}', '{phoneNumber}', '{emai}', '{dateOfBirth}')", connection);

                    connection.Open();
                    insertCommand.ExecuteNonQuery();
                    connection.Close();

                    string message = "Cliente inserido com sucesso!\n Deseja inserir um novo cliente?";
                    string caption = "Novo cliente";

                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result;

                    result = MessageBox.Show(message, caption, buttons);

                    if (result == DialogResult.No)
                    {
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    string message = $"Não foi possível inserir o cliente na base de dados! Erro: \n{ex}";
                    string caption = $"Erro ao inserir o cliente!";

                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;

                    result = MessageBox.Show(message, caption, buttons);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
