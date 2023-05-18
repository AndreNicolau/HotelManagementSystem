using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace HotelManagementSystem.Controls
{
    public partial class EditClient : Form
    {

        public EditClient(string clientID, string currentFirstName,
string currentLastName,
string currentEmail,
string currentPhoneNumber,
string currentDateOfBirth)
        {
            InitializeComponent();

            // Fill all textboxes with data 
            lblClientID.Text = clientID;
            txtFirstname.Text = currentFirstName;
            txtLastName.Text = currentLastName;
            txtEmail.Text = currentEmail;
            txtPhoneNumber.Text = currentPhoneNumber;
            dtpDateOfBirth.Value = DateTime.Parse(currentDateOfBirth);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int clientID = Int32.Parse(lblClientID.Text);
            string newFirstName = txtFirstname.Text.Trim();
            string newLastName = txtLastName.Text.Trim();
            string newPhoneNumber = txtPhoneNumber.Text.Trim();
            string newEmail = txtEmail.Text.Trim();
            string newDateOfBirth = dtpDateOfBirth.Value.ToString("yyyy-MM-dd");

            string caption = "Updating client information";
            string message = $"Are you sure that you would like to update this clients information?";

            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = new DialogResult();

            MySqlConnection connection = new MySqlConnection(Properties.Resources.connectionString);
            MySqlCommand updateCommand = new MySqlCommand($"UPDATE clients_table " +
                $"SET firstName = '{newFirstName}', lastName = '{newLastName}', phoneNumber = '{newPhoneNumber}', email = '{newEmail}', dateOfBirth = '{newDateOfBirth}' " +
                $"WHERE clientID = '{clientID}' ", connection);

            result = MessageBox.Show(message, caption, buttons);

            if (result == DialogResult.Yes)
            {
                try
                {
                    connection.Open();
                    updateCommand.ExecuteNonQuery();
                    connection.Close();
                    this.Close();
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
