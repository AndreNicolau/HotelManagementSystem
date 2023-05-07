using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class Login : Form
    {
        private string connectionString = Properties.Resources.connectionString;
        public string username;

        private DataTable usersDataTable = new DataTable();
        public Login()
        {
            InitializeComponent();

            LoadUsers();
        }

        private void LoadUsers()
        {
            string fetchUsersCommand = "SELECT * FROM users_table";

            try
            {
                MySqlConnection connection = new MySqlConnection(connectionString);
                MySqlDataAdapter adapter = new MySqlDataAdapter(fetchUsersCommand, connection);

                adapter.Fill(usersDataTable);

                cmbUsername.DataSource = usersDataTable;
                cmbUsername.DisplayMember = "Username";
                cmbUsername.ValueMember = "Username";
            }
            catch (Exception ex)
            {
                string message = $"Não foi possível obter os dados dos utilizadores a partir da base de dados! Erro: \n{ex}";
                string caption = $"Erro ao obter os dados dos utilizadores!";

                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);
            }
        }

        private void chbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (ChbShowPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userPassword = usersDataTable.Rows[cmbUsername.SelectedIndex][4].ToString();

            if (txtPassword.Text == userPassword)
            {
                string firstName = usersDataTable.Rows[cmbUsername.SelectedIndex][1].ToString();
                string lastName = usersDataTable.Rows[cmbUsername.SelectedIndex][2].ToString();
                string username = $"Utilizador: {firstName} {lastName} ({cmbUsername.Text})";

                Dashboard dashboard = new Dashboard(username);
                dashboard.ShowDialog(); 
                this.Hide();
            }
            else
            {
                MessageBox.Show("Password Incorreta");
            }
        }
    }
}
