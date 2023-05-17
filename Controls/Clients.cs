using HotelManagementSystem.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class Clients : UserControl
    {
        string clientID;
        string currentFirstName;
        string currentLastName;
        string currentPhoneNumber;
        string currentEmail;
        string currentDateOfBirth;

        public Clients()
        {
            InitializeComponent();
            LoadClients();

            // Hide first column (ClientID) from clients datagridview
            dgvClients.Columns[0].Visible = false;

            dgvClients.Columns[1].HeaderText = "First Name";
            dgvClients.Columns[2].HeaderText = "Last Name";
            dgvClients.Columns[3].HeaderText = "Phone Number";
            dgvClients.Columns[4].HeaderText = "Email";
            dgvClients.Columns[5].HeaderText = "Date of Birth";
        }

        public void LoadClients()
        {
            string fetchClientsCommand = "SELECT * FROM clients_table";

            try
            {
                MySqlConnection connection = new MySqlConnection(Properties.Resources.connectionString);
                MySqlDataAdapter adapter = new MySqlDataAdapter(fetchClientsCommand, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dgvClients.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                string message = $"Não foi possível obter os dados dos clientes a partir da base de dados! Erro: \n{ex}";
                string caption = $"Erro ao obter os dados dos clientes!";

                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);
            }
        }
        private void tsbInsertClient_Click(object sender, EventArgs e)
        {
            NewClient newClient = new NewClient();
            newClient.StartPosition = FormStartPosition.CenterScreen;
            newClient.Show();
        }

        private void Clients_MouseHover(object sender, EventArgs e)
        {
            LoadClients();
        }

        private void dgvClients_MouseHover(object sender, EventArgs e)
        {
            LoadClients();
        }

        private void tsbDeleteClient_Click(object sender, EventArgs e)
        {
            string clientID = dgvClients.SelectedCells[0].Value.ToString();
            string message = "Deseja mesmo eliminar o cliente da base de dados?";
            string caption = "Eliminar cliente";

            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);

            if (result == DialogResult.Yes)
            {
                try
                {
                    MySqlConnection connection = new MySqlConnection(Properties.Resources.connectionString);
                    MySqlCommand deleteCommand = new MySqlCommand($"DELETE FROM clients_table WHERE clientID ={clientID}", connection);

                    connection.Open();
                    deleteCommand.ExecuteNonQuery();
                    connection.Close();

                    LoadClients();
                }
                catch (Exception ex)
                {
                    message = $"Não foi possível o cliente da base de dados! Erro: \n{ex}";
                    caption = $"Erro ao cliente!";

                    buttons = MessageBoxButtons.OK;
                    result = MessageBox.Show(message, caption, buttons);
                }
            }
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            dgvClients.ReadOnly = false;
            dgvClients.SelectionMode = DataGridViewSelectionMode.CellSelect;

            saveToolStripMenuItem.Enabled = true;
            cancelToolStripMenuItem.Enabled = true;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string clientID = dgvClients.SelectedCells[0].Value.ToString();
            string newFirstName = dgvClients.SelectedCells[1].Value.ToString();
            string newLastName = dgvClients.SelectedCells[2].Value.ToString();
            string newPhoneNumber = dgvClients.SelectedCells[3].Value.ToString();
            string newEmail = dgvClients.SelectedCells[4].Value.ToString();
            string newDateOfBirth = dgvClients.SelectedCells[5].Value.ToString();

            string message = $"Os seguintes dados de cliente vão ser alterados: " +
                $"\nPrimeiro Nome de '{currentFirstName}' para '{newFirstName}'";
            string caption = "ATUALIZAR DADOS DE CLIENTE";

            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(caption, message, buttons);
        }

        private void dgvClients_SelectionChanged(object sender, EventArgs e)
        {

            
        }
    }
}
