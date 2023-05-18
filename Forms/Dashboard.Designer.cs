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
            this.btnExit = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.leftPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(4, 531);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(83, 20);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "username";
            // 
            // rdoClients
            // 
            this.rdoClients.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoClients.FlatAppearance.BorderSize = 0;
            this.rdoClients.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.rdoClients.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.rdoClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoClients.ForeColor = System.Drawing.Color.White;
            this.rdoClients.Location = new System.Drawing.Point(0, 89);
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
            this.rdoReservations.FlatAppearance.BorderSize = 0;
            this.rdoReservations.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.rdoReservations.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.rdoReservations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoReservations.ForeColor = System.Drawing.Color.White;
            this.rdoReservations.Location = new System.Drawing.Point(0, 194);
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
            this.rdoRooms.FlatAppearance.BorderSize = 0;
            this.rdoRooms.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.rdoRooms.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.rdoRooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoRooms.ForeColor = System.Drawing.Color.White;
            this.rdoRooms.Location = new System.Drawing.Point(0, 124);
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
            this.rdoEmployees.FlatAppearance.BorderSize = 0;
            this.rdoEmployees.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.rdoEmployees.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.rdoEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoEmployees.ForeColor = System.Drawing.Color.White;
            this.rdoEmployees.Location = new System.Drawing.Point(0, 54);
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
            this.rdoUsers.FlatAppearance.BorderSize = 0;
            this.rdoUsers.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.rdoUsers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.rdoUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoUsers.ForeColor = System.Drawing.Color.White;
            this.rdoUsers.Location = new System.Drawing.Point(0, 159);
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
            this.leftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.leftPanel.Controls.Add(this.label1);
            this.leftPanel.Controls.Add(this.rdoEmployees);
            this.leftPanel.Controls.Add(this.btnExit);
            this.leftPanel.Controls.Add(this.rdoClients);
            this.leftPanel.Controls.Add(this.rdoRooms);
            this.leftPanel.Controls.Add(this.lblUsername);
            this.leftPanel.Controls.Add(this.rdoUsers);
            this.leftPanel.Controls.Add(this.rdoReservations);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Margin = new System.Windows.Forms.Padding(0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(200, 600);
            this.leftPanel.TabIndex = 7;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(0, 551);
            this.btnExit.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(200, 35);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.leftPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1200, 600);
            this.mainPanel.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hotel Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.mainPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.mainPanel.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
    }
}