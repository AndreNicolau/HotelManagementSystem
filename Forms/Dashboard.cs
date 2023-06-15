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

            reservations.Dock = DockStyle.Fill;
            clients.Dock = DockStyle.Fill;
            rooms.Dock = DockStyle.Fill;
        }

        private void RadioButtonChecked()
        {

        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();

            Close();
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == employeesTab)
            {

            }

            if (tabControl.SelectedTab == clientsTab)
            {

            }

            if (tabControl.SelectedTab == roomsTab)
            {

            }
        }
    }
}
