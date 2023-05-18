using HotelManagementSystem.Controls;
using System;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class Dashboard : Form
    {
        Reservations reservations = new Reservations();
        Clients clients = new Clients();
        Rooms rooms = new Rooms();

        public Dashboard(string userInfo, string userGroup)
        {
            InitializeComponent();
            RadioButtonChecked();

            lblUsername.Text = userInfo;

            mainPanel.Controls.Add(reservations);
            mainPanel.Controls.Add(clients);
            mainPanel.Controls.Add(rooms);

            reservations.Dock = DockStyle.Fill;
            clients.Dock = DockStyle.Fill;
            rooms.Dock = DockStyle.Fill;
        }

        private void RadioButtonChecked()
        {
            
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButtonChecked();

            if (rdoReservations.Checked)
            {
                reservations.BringToFront();
            }

            if (rdoClients.Checked)
            {
                clients.BringToFront();
            }

            if (rdoRooms.Checked)
            {
                rooms.BringToFront();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            
            Close();
        }
    }
}
