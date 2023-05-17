using System;
using System.Windows.Forms;

namespace HotelManagementSystem.Controls
{
    public partial class EditClient : Form
    {
        string newFirstName;
        string newLastName;
        string newEmail;
        string newPhoneNumber;
        string newDateOfBirth;
        public EditClient(string clientID, string currentFirstName,
        string currentLastName,
        string currentEmail,
        string currentPhoneNumber,
        string currentDateOfBirth)
        {
            InitializeComponent();

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
    }
}
