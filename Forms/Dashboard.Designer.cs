namespace HotelManagementSystem
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblUsername = new System.Windows.Forms.Label();
            this.rdoClients = new System.Windows.Forms.RadioButton();
            this.rdoReservations = new System.Windows.Forms.RadioButton();
            this.rdoRooms = new System.Windows.Forms.RadioButton();
            this.rdoEmployees = new System.Windows.Forms.RadioButton();
            this.rdoUsers = new System.Windows.Forms.RadioButton();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.leftPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Black;
            this.lblUsername.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(0, 618);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(99, 25);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "username";
            // 
            // rdoClients
            // 
            this.rdoClients.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoClients.BackColor = System.Drawing.Color.White;
            this.rdoClients.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.rdoClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoClients.ForeColor = System.Drawing.Color.Black;
            this.rdoClients.Location = new System.Drawing.Point(0, 70);
            this.rdoClients.Margin = new System.Windows.Forms.Padding(0);
            this.rdoClients.Name = "rdoClients";
            this.rdoClients.Size = new System.Drawing.Size(200, 35);
            this.rdoClients.TabIndex = 3;
            this.rdoClients.Text = "Clientes";
            this.rdoClients.UseVisualStyleBackColor = false;
            this.rdoClients.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            this.rdoClients.MouseHover += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // rdoReservations
            // 
            this.rdoReservations.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoReservations.BackColor = System.Drawing.Color.White;
            this.rdoReservations.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.rdoReservations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoReservations.ForeColor = System.Drawing.Color.Black;
            this.rdoReservations.Location = new System.Drawing.Point(0, 175);
            this.rdoReservations.Margin = new System.Windows.Forms.Padding(0);
            this.rdoReservations.Name = "rdoReservations";
            this.rdoReservations.Size = new System.Drawing.Size(200, 35);
            this.rdoReservations.TabIndex = 2;
            this.rdoReservations.Text = "Reservas";
            this.rdoReservations.UseVisualStyleBackColor = false;
            this.rdoReservations.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            this.rdoReservations.MouseHover += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // rdoRooms
            // 
            this.rdoRooms.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoRooms.BackColor = System.Drawing.Color.White;
            this.rdoRooms.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.rdoRooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoRooms.ForeColor = System.Drawing.Color.Black;
            this.rdoRooms.Location = new System.Drawing.Point(0, 105);
            this.rdoRooms.Margin = new System.Windows.Forms.Padding(0);
            this.rdoRooms.Name = "rdoRooms";
            this.rdoRooms.Size = new System.Drawing.Size(200, 35);
            this.rdoRooms.TabIndex = 4;
            this.rdoRooms.Text = "Quartos";
            this.rdoRooms.UseVisualStyleBackColor = false;
            this.rdoRooms.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            this.rdoRooms.MouseHover += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // rdoEmployees
            // 
            this.rdoEmployees.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoEmployees.BackColor = System.Drawing.Color.White;
            this.rdoEmployees.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.rdoEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoEmployees.ForeColor = System.Drawing.Color.Black;
            this.rdoEmployees.Location = new System.Drawing.Point(0, 35);
            this.rdoEmployees.Margin = new System.Windows.Forms.Padding(0);
            this.rdoEmployees.Name = "rdoEmployees";
            this.rdoEmployees.Size = new System.Drawing.Size(200, 35);
            this.rdoEmployees.TabIndex = 5;
            this.rdoEmployees.Text = "Empregados";
            this.rdoEmployees.UseVisualStyleBackColor = false;
            this.rdoEmployees.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            this.rdoEmployees.MouseHover += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // rdoUsers
            // 
            this.rdoUsers.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoUsers.BackColor = System.Drawing.Color.White;
            this.rdoUsers.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.rdoUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoUsers.ForeColor = System.Drawing.Color.Black;
            this.rdoUsers.Location = new System.Drawing.Point(0, 140);
            this.rdoUsers.Margin = new System.Windows.Forms.Padding(0);
            this.rdoUsers.Name = "rdoUsers";
            this.rdoUsers.Size = new System.Drawing.Size(200, 35);
            this.rdoUsers.TabIndex = 6;
            this.rdoUsers.Text = "Utilizadores";
            this.rdoUsers.UseVisualStyleBackColor = false;
            this.rdoUsers.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            this.rdoUsers.MouseHover += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.flowLayoutPanel1);
            this.leftPanel.Controls.Add(this.lblUsername);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(200, 643);
            this.leftPanel.TabIndex = 7;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.radioButton1);
            this.flowLayoutPanel1.Controls.Add(this.rdoEmployees);
            this.flowLayoutPanel1.Controls.Add(this.rdoClients);
            this.flowLayoutPanel1.Controls.Add(this.rdoRooms);
            this.flowLayoutPanel1.Controls.Add(this.rdoUsers);
            this.flowLayoutPanel1.Controls.Add(this.rdoReservations);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 252);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // radioButton1
            // 
            this.radioButton1.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton1.BackColor = System.Drawing.Color.White;
            this.radioButton1.Checked = true;
            this.radioButton1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton1.ForeColor = System.Drawing.Color.Black;
            this.radioButton1.Location = new System.Drawing.Point(0, 0);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(0);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(200, 35);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Dashboard";
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            this.radioButton1.MouseHover += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(200, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1038, 643);
            this.mainPanel.TabIndex = 8;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1238, 643);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.leftPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.RadioButton rdoClients;
        private System.Windows.Forms.RadioButton rdoReservations;
        private System.Windows.Forms.RadioButton rdoRooms;
        private System.Windows.Forms.RadioButton rdoEmployees;
        private System.Windows.Forms.RadioButton rdoUsers;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}