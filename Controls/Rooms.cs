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
    public partial class Rooms : UserControl
    {
        public Rooms()
        {
            InitializeComponent();

            LoadRooms();
        }

        private void LoadRooms()
        {
            string fetchRoomsCommand = "SELECT * FROM rooms_table";

            try
            {
                MySqlConnection connection = new MySqlConnection(Properties.Resources.connectionString);
                MySqlDataAdapter adapter = new MySqlDataAdapter(fetchRoomsCommand, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dgvRooms.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                string message = $"Não foi possível obter os dados dos quartos a partir da base de dados! Erro: \n{ex}";
                string caption = $"Erro ao obter os dados dos quartos!";

                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);
            }
        }
    }
}
