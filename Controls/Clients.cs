using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class Clients : UserControl
    {
        public Clients()
        {
            InitializeComponent();
            LoadClients();

            // Hide first column from clients datagridview
            dgvClients.Columns[0].Visible = false;
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
    }
}
