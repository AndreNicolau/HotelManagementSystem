using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
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
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            string firstName;
            string lastName;
            string group;
            string userInfo;

            string connectionString = Properties.Resources.connectionString;
            string fetchUsersCommand = $"SELECT * FROM users_table WHERE Username = '{username}'";

            DataTable usersDataTable = new DataTable();

            try
            {
                MySqlConnection connection = new MySqlConnection(connectionString);
                MySqlDataAdapter adapter = new MySqlDataAdapter(fetchUsersCommand, connection);

                adapter.Fill(usersDataTable);

                if (usersDataTable.Rows.Count == 0)
                {
                    MessageBox.Show("Utilizador não encontrado");
                }
                else if (password != usersDataTable.Rows[0][2].ToString())
                {
                    MessageBox.Show("Password errada!");
                }
                else
                {
                    
                    firstName = usersDataTable.Rows[0][3].ToString();
                    lastName = usersDataTable.Rows[0][4].ToString();
                    group = usersDataTable.Rows[0][5].ToString();
                    
                    userInfo = $"{firstName} {lastName} ({username} - {group})";
                    Dashboard dashboard = new Dashboard(userInfo, group);
                    dashboard.ShowDialog();
                    this.Hide();
                }
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
    }
}
