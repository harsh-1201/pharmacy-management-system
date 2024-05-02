namespace Pharmacy_Management_System
{
    partial class Administrator
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administrator));
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.btnLogOut = new Guna.UI.WinForms.GunaButton();
            this.btnProfile = new Guna.UI.WinForms.GunaButton();
            this.btnViewUser = new Guna.UI.WinForms.GunaButton();
            this.btnAddUser = new Guna.UI.WinForms.GunaButton();
            this.btnDashboard = new Guna.UI.WinForms.GunaButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse2 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse3 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse4 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse5 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.btnLedger = new Guna.UI.WinForms.GunaButton();
            this.gunaElipse6 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.uC_A_Report1 = new Pharmacy_Management_System.AdministratorUC.UC_A_Report();
            this.uC_Profile1 = new Pharmacy_Management_System.UC_Profile();
            this.uC_ViewUser1 = new Pharmacy_Management_System.UC_ViewUser();
            this.uC_AddUser1 = new Pharmacy_Management_System.AdministratorUC.UC_AddUser();
            this.uC_Dashboard1 = new Pharmacy_Management_System.AdministratorUC.UC_Dashboard();
            this.uC_A_Ledger1 = new Pharmacy_Management_System.AdministratorUC.UC_A_Ledger();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btnLedger);
            this.panel1.Controls.Add(this.gunaButton1);
            this.panel1.Controls.Add(this.UserNameLabel);
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnProfile);
            this.panel1.Controls.Add(this.btnViewUser);
            this.panel1.Controls.Add(this.btnAddUser);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 1500);
            this.panel1.TabIndex = 0;
            // 
            // gunaButton1
            // 
            this.gunaButton1.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton1.Image")));
            this.gunaButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.ImageSize = new System.Drawing.Size(40, 40);
            this.gunaButton1.Location = new System.Drawing.Point(3, 840);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Size = new System.Drawing.Size(388, 62);
            this.gunaButton1.TabIndex = 8;
            this.gunaButton1.Text = "REPORTS";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click_1);
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLabel.ForeColor = System.Drawing.Color.Yellow;
            this.UserNameLabel.Location = new System.Drawing.Point(3, 991);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(382, 37);
            this.UserNameLabel.TabIndex = 7;
            this.UserNameLabel.Text = "harsh";
            this.UserNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogOut
            // 
            this.btnLogOut.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            this.btnLogOut.AnimationHoverSpeed = 0.07F;
            this.btnLogOut.AnimationSpeed = 0.03F;
            this.btnLogOut.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogOut.BorderColor = System.Drawing.Color.Black;
            this.btnLogOut.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLogOut.FocusedColor = System.Drawing.Color.Empty;
            this.btnLogOut.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLogOut.ImageSize = new System.Drawing.Size(40, 40);
            this.btnLogOut.Location = new System.Drawing.Point(5, 919);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.OnHoverBaseColor = System.Drawing.Color.White;
            this.btnLogOut.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLogOut.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnLogOut.OnHoverImage = null;
            this.btnLogOut.OnPressedColor = System.Drawing.Color.Black;
            this.btnLogOut.Size = new System.Drawing.Size(388, 62);
            this.btnLogOut.TabIndex = 6;
            this.btnLogOut.Text = "LOGOUT";
            this.btnLogOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            this.btnProfile.AnimationHoverSpeed = 0.07F;
            this.btnProfile.AnimationSpeed = 0.03F;
            this.btnProfile.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnProfile.BorderColor = System.Drawing.Color.Black;
            this.btnProfile.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnProfile.FocusedColor = System.Drawing.Color.Empty;
            this.btnProfile.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.ForeColor = System.Drawing.Color.White;
            this.btnProfile.Image = ((System.Drawing.Image)(resources.GetObject("btnProfile.Image")));
            this.btnProfile.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnProfile.ImageSize = new System.Drawing.Size(40, 40);
            this.btnProfile.Location = new System.Drawing.Point(5, 673);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.OnHoverBaseColor = System.Drawing.Color.White;
            this.btnProfile.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnProfile.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnProfile.OnHoverImage = null;
            this.btnProfile.OnPressedColor = System.Drawing.Color.Black;
            this.btnProfile.Size = new System.Drawing.Size(388, 62);
            this.btnProfile.TabIndex = 5;
            this.btnProfile.Text = "PROFILE";
            this.btnProfile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnViewUser
            // 
            this.btnViewUser.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            this.btnViewUser.AnimationHoverSpeed = 0.07F;
            this.btnViewUser.AnimationSpeed = 0.03F;
            this.btnViewUser.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnViewUser.BorderColor = System.Drawing.Color.Black;
            this.btnViewUser.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnViewUser.FocusedColor = System.Drawing.Color.Empty;
            this.btnViewUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewUser.ForeColor = System.Drawing.Color.White;
            this.btnViewUser.Image = ((System.Drawing.Image)(resources.GetObject("btnViewUser.Image")));
            this.btnViewUser.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnViewUser.ImageSize = new System.Drawing.Size(40, 40);
            this.btnViewUser.Location = new System.Drawing.Point(7, 595);
            this.btnViewUser.Name = "btnViewUser";
            this.btnViewUser.OnHoverBaseColor = System.Drawing.Color.White;
            this.btnViewUser.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnViewUser.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnViewUser.OnHoverImage = null;
            this.btnViewUser.OnPressedColor = System.Drawing.Color.Black;
            this.btnViewUser.Size = new System.Drawing.Size(380, 62);
            this.btnViewUser.TabIndex = 4;
            this.btnViewUser.Text = "VIEW USER";
            this.btnViewUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnViewUser.Click += new System.EventHandler(this.btnViewUser_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            this.btnAddUser.AnimationHoverSpeed = 0.07F;
            this.btnAddUser.AnimationSpeed = 0.03F;
            this.btnAddUser.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddUser.BorderColor = System.Drawing.Color.Black;
            this.btnAddUser.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddUser.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.ForeColor = System.Drawing.Color.White;
            this.btnAddUser.Image = ((System.Drawing.Image)(resources.GetObject("btnAddUser.Image")));
            this.btnAddUser.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddUser.ImageSize = new System.Drawing.Size(40, 40);
            this.btnAddUser.Location = new System.Drawing.Point(5, 510);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.OnHoverBaseColor = System.Drawing.Color.White;
            this.btnAddUser.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddUser.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnAddUser.OnHoverImage = null;
            this.btnAddUser.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddUser.Size = new System.Drawing.Size(388, 62);
            this.btnAddUser.TabIndex = 3;
            this.btnAddUser.Text = "ADD USER";
            this.btnAddUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddUser.Click += new System.EventHandler(this.gunaButton2_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            this.btnDashboard.AnimationHoverSpeed = 0.07F;
            this.btnDashboard.AnimationSpeed = 0.03F;
            this.btnDashboard.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDashboard.BorderColor = System.Drawing.Color.Black;
            this.btnDashboard.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDashboard.FocusedColor = System.Drawing.Color.Empty;
            this.btnDashboard.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDashboard.ImageSize = new System.Drawing.Size(40, 40);
            this.btnDashboard.Location = new System.Drawing.Point(5, 427);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.OnHoverBaseColor = System.Drawing.Color.White;
            this.btnDashboard.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDashboard.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnDashboard.OnHoverImage = null;
            this.btnDashboard.OnPressedColor = System.Drawing.Color.White;
            this.btnDashboard.Size = new System.Drawing.Size(388, 62);
            this.btnDashboard.TabIndex = 2;
            this.btnDashboard.Text = "DASHBOARD";
            this.btnDashboard.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDashboard.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(66, 337);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 49);
            this.label1.TabIndex = 1;
            this.label1.Text = "Administrator";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(64, 102);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 232);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            this.panel2.Controls.Add(this.uC_A_Ledger1);
            this.panel2.Controls.Add(this.uC_A_Report1);
            this.panel2.Controls.Add(this.uC_Profile1);
            this.panel2.Controls.Add(this.uC_ViewUser1);
            this.panel2.Controls.Add(this.uC_AddUser1);
            this.panel2.Controls.Add(this.uC_Dashboard1);
            this.panel2.Location = new System.Drawing.Point(388, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1500, 1500);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this.panel2;
            // 
            // gunaElipse2
            // 
            this.gunaElipse2.TargetControl = this.panel2;
            // 
            // gunaElipse3
            // 
            this.gunaElipse3.TargetControl = this.panel2;
            // 
            // gunaElipse4
            // 
            this.gunaElipse4.TargetControl = this.panel2;
            // 
            // gunaElipse5
            // 
            this.gunaElipse5.TargetControl = this;
            // 
            // btnLedger
            // 
            this.btnLedger.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            this.btnLedger.AnimationHoverSpeed = 0.07F;
            this.btnLedger.AnimationSpeed = 0.03F;
            this.btnLedger.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLedger.BorderColor = System.Drawing.Color.Black;
            this.btnLedger.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLedger.FocusedColor = System.Drawing.Color.Empty;
            this.btnLedger.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLedger.ForeColor = System.Drawing.Color.White;
            this.btnLedger.Image = ((System.Drawing.Image)(resources.GetObject("btnLedger.Image")));
            this.btnLedger.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLedger.ImageSize = new System.Drawing.Size(40, 40);
            this.btnLedger.Location = new System.Drawing.Point(8, 757);
            this.btnLedger.Name = "btnLedger";
            this.btnLedger.OnHoverBaseColor = System.Drawing.Color.White;
            this.btnLedger.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLedger.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnLedger.OnHoverImage = null;
            this.btnLedger.OnPressedColor = System.Drawing.Color.Black;
            this.btnLedger.Size = new System.Drawing.Size(388, 62);
            this.btnLedger.TabIndex = 9;
            this.btnLedger.Text = "LEDGERS";
            this.btnLedger.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLedger.Click += new System.EventHandler(this.btnLedger_Click);
            // 
            // gunaElipse6
            // 
            this.gunaElipse6.TargetControl = this;
            // 
            // uC_A_Report1
            // 
            this.uC_A_Report1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uC_A_Report1.Location = new System.Drawing.Point(0, 3);
            this.uC_A_Report1.Margin = new System.Windows.Forms.Padding(4);
            this.uC_A_Report1.Name = "uC_A_Report1";
            this.uC_A_Report1.Size = new System.Drawing.Size(2408, 2127);
            this.uC_A_Report1.TabIndex = 4;
            // 
            // uC_Profile1
            // 
            this.uC_Profile1.BackColor = System.Drawing.Color.White;
            this.uC_Profile1.Location = new System.Drawing.Point(0, 0);
            this.uC_Profile1.Name = "uC_Profile1";
            this.uC_Profile1.Size = new System.Drawing.Size(2159, 2022);
            this.uC_Profile1.TabIndex = 3;
            this.uC_Profile1.Load += new System.EventHandler(this.uC_Profile1_Load);
            // 
            // uC_ViewUser1
            // 
            this.uC_ViewUser1.BackColor = System.Drawing.Color.White;
            this.uC_ViewUser1.Location = new System.Drawing.Point(0, 0);
            this.uC_ViewUser1.Name = "uC_ViewUser1";
            this.uC_ViewUser1.Size = new System.Drawing.Size(1965, 1960);
            this.uC_ViewUser1.TabIndex = 2;
            // 
            // uC_AddUser1
            // 
            this.uC_AddUser1.BackColor = System.Drawing.Color.White;
            this.uC_AddUser1.Location = new System.Drawing.Point(0, 0);
            this.uC_AddUser1.Name = "uC_AddUser1";
            this.uC_AddUser1.Size = new System.Drawing.Size(1950, 1960);
            this.uC_AddUser1.TabIndex = 1;
            this.uC_AddUser1.Load += new System.EventHandler(this.uC_AddUser1_Load);
            // 
            // uC_Dashboard1
            // 
            this.uC_Dashboard1.BackColor = System.Drawing.Color.White;
            this.uC_Dashboard1.Location = new System.Drawing.Point(0, 0);
            this.uC_Dashboard1.Name = "uC_Dashboard1";
            this.uC_Dashboard1.Size = new System.Drawing.Size(1902, 1584);
            this.uC_Dashboard1.TabIndex = 0;
            this.uC_Dashboard1.Load += new System.EventHandler(this.uC_Dashboard1_Load);
            // 
            // uC_A_Ledger1
            // 
            this.uC_A_Ledger1.BackColor = System.Drawing.Color.White;
            this.uC_A_Ledger1.Location = new System.Drawing.Point(3, 3);
            this.uC_A_Ledger1.Name = "uC_A_Ledger1";
            this.uC_A_Ledger1.Size = new System.Drawing.Size(1547, 1587);
            this.uC_A_Ledger1.TabIndex = 5;
            // 
            // Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1572, 1055);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Administrator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Administrator_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaButton btnAddUser;
        private Guna.UI.WinForms.GunaButton btnDashboard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaButton btnLogOut;
        private Guna.UI.WinForms.GunaButton btnProfile;
        private Guna.UI.WinForms.GunaButton btnViewUser;
        private System.Windows.Forms.Label UserNameLabel;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private AdministratorUC.UC_Dashboard uC_Dashboard1;
        private Guna.UI.WinForms.GunaElipse gunaElipse2;
        private AdministratorUC.UC_AddUser uC_AddUser1;
        private Guna.UI.WinForms.GunaElipse gunaElipse3;
        private UC_ViewUser uC_ViewUser1;
        private Guna.UI.WinForms.GunaElipse gunaElipse4;
        private UC_Profile uC_Profile1;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaElipse gunaElipse5;
        private AdministratorUC.UC_A_Report uC_A_Report1;
        private Guna.UI.WinForms.GunaButton btnLedger;
        private Guna.UI.WinForms.GunaElipse gunaElipse6;
        private AdministratorUC.UC_A_Ledger uC_A_Ledger1;
    }
}