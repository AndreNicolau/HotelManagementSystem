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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tpClients = new System.Windows.Forms.TabPage();
            this.tpRooms = new System.Windows.Forms.TabPage();
            this.clients1 = new HotelManagementSystem.Clients();
            this.rooms1 = new HotelManagementSystem.Rooms();
            this.tpEmployess = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
            this.tpClients.SuspendLayout();
            this.tpRooms.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(13, 9);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(99, 25);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "username";
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tpClients);
            this.tabControl.Controls.Add(this.tpRooms);
            this.tabControl.Controls.Add(this.tpEmployess);
            this.tabControl.Location = new System.Drawing.Point(12, 37);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1214, 606);
            this.tabControl.TabIndex = 3;
            // 
            // tpClients
            // 
            this.tpClients.Controls.Add(this.clients1);
            this.tpClients.Location = new System.Drawing.Point(4, 34);
            this.tpClients.Name = "tpClients";
            this.tpClients.Padding = new System.Windows.Forms.Padding(3);
            this.tpClients.Size = new System.Drawing.Size(1206, 568);
            this.tpClients.TabIndex = 0;
            this.tpClients.Text = "Clientes";
            this.tpClients.UseVisualStyleBackColor = true;
            // 
            // tpRooms
            // 
            this.tpRooms.Controls.Add(this.rooms1);
            this.tpRooms.Location = new System.Drawing.Point(4, 34);
            this.tpRooms.Name = "tpRooms";
            this.tpRooms.Padding = new System.Windows.Forms.Padding(3);
            this.tpRooms.Size = new System.Drawing.Size(1206, 568);
            this.tpRooms.TabIndex = 1;
            this.tpRooms.Text = "Quartos";
            this.tpRooms.UseVisualStyleBackColor = true;
            // 
            // clients1
            // 
            this.clients1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clients1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clients1.Location = new System.Drawing.Point(3, 3);
            this.clients1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clients1.Name = "clients1";
            this.clients1.Size = new System.Drawing.Size(1200, 562);
            this.clients1.TabIndex = 2;
            // 
            // rooms1
            // 
            this.rooms1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rooms1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rooms1.Location = new System.Drawing.Point(3, 3);
            this.rooms1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rooms1.Name = "rooms1";
            this.rooms1.Size = new System.Drawing.Size(1200, 562);
            this.rooms1.TabIndex = 0;
            // 
            // tpEmployess
            // 
            this.tpEmployess.Location = new System.Drawing.Point(4, 34);
            this.tpEmployess.Name = "tpEmployess";
            this.tpEmployess.Padding = new System.Windows.Forms.Padding(3);
            this.tpEmployess.Size = new System.Drawing.Size(1206, 568);
            this.tpEmployess.TabIndex = 2;
            this.tpEmployess.Text = "Empregados";
            this.tpEmployess.UseVisualStyleBackColor = true;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 643);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.lblUsername);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControl.ResumeLayout(false);
            this.tpClients.ResumeLayout(false);
            this.tpRooms.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblUsername;
        private Clients clients1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tpClients;
        private System.Windows.Forms.TabPage tpRooms;
        private Rooms rooms1;
        private System.Windows.Forms.TabPage tpEmployess;
    }
}