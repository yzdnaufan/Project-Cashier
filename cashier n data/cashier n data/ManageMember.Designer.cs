namespace cashier_n_data
{
    partial class ManageMember
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
            this.passCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstViewAnggota = new MetroFramework.Controls.MetroListView();
            this.usernameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.adminCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblManageMember = new System.Windows.Forms.Label();
            this.btnHapus = new Guna.UI2.WinForms.Guna2Button();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnLoad = new Guna.UI2.WinForms.Guna2Button();
            this.cbAdmin = new Guna.UI2.WinForms.Guna2ComboBox();
            this.tbPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnTambah = new Guna.UI2.WinForms.Guna2Button();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblJudul = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblKasir = new System.Windows.Forms.Label();
            this.xButton = new System.Windows.Forms.Label();
            this.lblLogout = new System.Windows.Forms.Label();
            this.lblMngProd = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // passCol
            // 
            this.passCol.Text = "Password";
            this.passCol.Width = 100;
            // 
            // lstViewAnggota
            // 
            this.lstViewAnggota.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.usernameCol,
            this.passCol,
            this.adminCol});
            this.lstViewAnggota.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lstViewAnggota.FullRowSelect = true;
            this.lstViewAnggota.Location = new System.Drawing.Point(394, 110);
            this.lstViewAnggota.Name = "lstViewAnggota";
            this.lstViewAnggota.OwnerDraw = true;
            this.lstViewAnggota.Size = new System.Drawing.Size(468, 443);
            this.lstViewAnggota.TabIndex = 5;
            this.lstViewAnggota.UseCompatibleStateImageBehavior = false;
            this.lstViewAnggota.UseSelectable = true;
            this.lstViewAnggota.View = System.Windows.Forms.View.Details;
            // 
            // usernameCol
            // 
            this.usernameCol.Text = "Username";
            this.usernameCol.Width = 150;
            // 
            // adminCol
            // 
            this.adminCol.Text = "Admin";
            this.adminCol.Width = 75;
            // 
            // lblManageMember
            // 
            this.lblManageMember.AutoSize = true;
            this.lblManageMember.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblManageMember.Font = new System.Drawing.Font("Segoe UI Black", 15F);
            this.lblManageMember.Location = new System.Drawing.Point(12, 234);
            this.lblManageMember.Name = "lblManageMember";
            this.lblManageMember.Size = new System.Drawing.Size(206, 35);
            this.lblManageMember.TabIndex = 17;
            this.lblManageMember.Text = "Kelola Anggota";
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.Color.Transparent;
            this.btnHapus.CheckedState.Parent = this.btnHapus;
            this.btnHapus.CustomImages.Parent = this.btnHapus;
            this.btnHapus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHapus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHapus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHapus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHapus.DisabledState.Parent = this.btnHapus;
            this.btnHapus.FillColor = System.Drawing.Color.Blue;
            this.btnHapus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnHapus.ForeColor = System.Drawing.Color.White;
            this.btnHapus.HoverState.Parent = this.btnHapus;
            this.btnHapus.Location = new System.Drawing.Point(583, 559);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.ShadowDecoration.Parent = this.btnHapus;
            this.btnHapus.Size = new System.Drawing.Size(185, 34);
            this.btnHapus.TabIndex = 3;
            this.btnHapus.Text = "Hapus Item Terpilih";
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.CheckedState.Parent = this.btnClear;
            this.btnClear.CustomImages.Parent = this.btnClear;
            this.btnClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClear.DisabledState.Parent = this.btnClear;
            this.btnClear.FillColor = System.Drawing.Color.Blue;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.HoverState.Parent = this.btnClear;
            this.btnClear.Location = new System.Drawing.Point(288, 288);
            this.btnClear.Name = "btnClear";
            this.btnClear.ShadowDecoration.Parent = this.btnClear;
            this.btnClear.Size = new System.Drawing.Size(88, 34);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2Panel1.Controls.Add(this.btnLoad);
            this.guna2Panel1.Controls.Add(this.cbAdmin);
            this.guna2Panel1.Controls.Add(this.lstViewAnggota);
            this.guna2Panel1.Controls.Add(this.tbPassword);
            this.guna2Panel1.Controls.Add(this.tbUsername);
            this.guna2Panel1.Controls.Add(this.btnHapus);
            this.guna2Panel1.Controls.Add(this.btnClear);
            this.guna2Panel1.Controls.Add(this.btnTambah);
            this.guna2Panel1.Controls.Add(this.lblAdmin);
            this.guna2Panel1.Controls.Add(this.lblPassword);
            this.guna2Panel1.Controls.Add(this.lblJudul);
            this.guna2Panel1.Controls.Add(this.lblUsername);
            this.guna2Panel1.Location = new System.Drawing.Point(239, 80);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(878, 606);
            this.guna2Panel1.TabIndex = 16;
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.Transparent;
            this.btnLoad.CheckedState.Parent = this.btnLoad;
            this.btnLoad.CustomImages.Parent = this.btnLoad;
            this.btnLoad.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLoad.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLoad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLoad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLoad.DisabledState.Parent = this.btnLoad;
            this.btnLoad.FillColor = System.Drawing.Color.Blue;
            this.btnLoad.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLoad.ForeColor = System.Drawing.Color.White;
            this.btnLoad.HoverState.Parent = this.btnLoad;
            this.btnLoad.Location = new System.Drawing.Point(774, 558);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.ShadowDecoration.Parent = this.btnLoad;
            this.btnLoad.Size = new System.Drawing.Size(88, 34);
            this.btnLoad.TabIndex = 7;
            this.btnLoad.Text = "Muat";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // cbAdmin
            // 
            this.cbAdmin.BackColor = System.Drawing.Color.Transparent;
            this.cbAdmin.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbAdmin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAdmin.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbAdmin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbAdmin.FocusedState.Parent = this.cbAdmin;
            this.cbAdmin.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbAdmin.HoverState.Parent = this.cbAdmin;
            this.cbAdmin.ItemHeight = 30;
            this.cbAdmin.Items.AddRange(new object[] {
            "Tidak",
            "Ya"});
            this.cbAdmin.ItemsAppearance.Parent = this.cbAdmin;
            this.cbAdmin.Location = new System.Drawing.Point(211, 231);
            this.cbAdmin.Name = "cbAdmin";
            this.cbAdmin.ShadowDecoration.Parent = this.cbAdmin;
            this.cbAdmin.Size = new System.Drawing.Size(140, 36);
            this.cbAdmin.StartIndex = 0;
            this.cbAdmin.TabIndex = 6;
            // 
            // tbPassword
            // 
            this.tbPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPassword.DefaultText = "";
            this.tbPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPassword.DisabledState.Parent = this.tbPassword;
            this.tbPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPassword.FocusedState.Parent = this.tbPassword;
            this.tbPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPassword.HoverState.Parent = this.tbPassword;
            this.tbPassword.Location = new System.Drawing.Point(211, 152);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '\0';
            this.tbPassword.PlaceholderText = "";
            this.tbPassword.SelectedText = "";
            this.tbPassword.ShadowDecoration.Parent = this.tbPassword;
            this.tbPassword.Size = new System.Drawing.Size(165, 36);
            this.tbPassword.TabIndex = 2;
            // 
            // tbUsername
            // 
            this.tbUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbUsername.DefaultText = "";
            this.tbUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbUsername.DisabledState.Parent = this.tbUsername;
            this.tbUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbUsername.FocusedState.Parent = this.tbUsername;
            this.tbUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbUsername.HoverState.Parent = this.tbUsername;
            this.tbUsername.Location = new System.Drawing.Point(211, 110);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.PasswordChar = '\0';
            this.tbUsername.PlaceholderText = "";
            this.tbUsername.SelectedText = "";
            this.tbUsername.ShadowDecoration.Parent = this.tbUsername;
            this.tbUsername.Size = new System.Drawing.Size(165, 36);
            this.tbUsername.TabIndex = 1;
            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.Color.Transparent;
            this.btnTambah.CheckedState.Parent = this.btnTambah;
            this.btnTambah.CustomImages.Parent = this.btnTambah;
            this.btnTambah.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTambah.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTambah.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTambah.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTambah.DisabledState.Parent = this.btnTambah;
            this.btnTambah.FillColor = System.Drawing.Color.Blue;
            this.btnTambah.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTambah.ForeColor = System.Drawing.Color.White;
            this.btnTambah.HoverState.Parent = this.btnTambah;
            this.btnTambah.Location = new System.Drawing.Point(176, 288);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.ShadowDecoration.Parent = this.btnTambah;
            this.btnTambah.Size = new System.Drawing.Size(92, 34);
            this.btnTambah.TabIndex = 3;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Segoe UI Black", 10F);
            this.lblAdmin.Location = new System.Drawing.Point(23, 231);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(66, 23);
            this.lblAdmin.TabIndex = 0;
            this.lblAdmin.Text = "Admin";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI Black", 12.5F);
            this.lblPassword.Location = new System.Drawing.Point(22, 152);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(112, 30);
            this.lblPassword.TabIndex = 0;
            this.lblPassword.Text = "Password";
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.Font = new System.Drawing.Font("SimSun-ExtB", 25F);
            this.lblJudul.Location = new System.Drawing.Point(304, 12);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(312, 42);
            this.lblJudul.TabIndex = 0;
            this.lblJudul.Text = "Kelola Anggota";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI Black", 12.5F);
            this.lblUsername.Location = new System.Drawing.Point(22, 110);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(117, 30);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI Black", 15F);
            this.lblUser.Location = new System.Drawing.Point(12, 11);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(22, 35);
            this.lblUser.TabIndex = 12;
            this.lblUser.Text = " ";
            // 
            // lblKasir
            // 
            this.lblKasir.AutoSize = true;
            this.lblKasir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblKasir.Font = new System.Drawing.Font("Segoe UI Black", 15F);
            this.lblKasir.Location = new System.Drawing.Point(12, 78);
            this.lblKasir.Name = "lblKasir";
            this.lblKasir.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblKasir.Size = new System.Drawing.Size(77, 35);
            this.lblKasir.TabIndex = 13;
            this.lblKasir.Text = "Kasir";
            this.lblKasir.Click += new System.EventHandler(this.lblKasir_Click);
            // 
            // xButton
            // 
            this.xButton.AutoSize = true;
            this.xButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.xButton.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xButton.Location = new System.Drawing.Point(1084, 11);
            this.xButton.Name = "xButton";
            this.xButton.Size = new System.Drawing.Size(33, 35);
            this.xButton.TabIndex = 11;
            this.xButton.Text = "X";
            this.xButton.Click += new System.EventHandler(this.xButton_Click);
            // 
            // lblLogout
            // 
            this.lblLogout.AutoSize = true;
            this.lblLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLogout.Font = new System.Drawing.Font("Segoe UI Black", 15F);
            this.lblLogout.Location = new System.Drawing.Point(12, 638);
            this.lblLogout.Name = "lblLogout";
            this.lblLogout.Size = new System.Drawing.Size(113, 35);
            this.lblLogout.TabIndex = 14;
            this.lblLogout.Text = "Log Out";
            this.lblLogout.Click += new System.EventHandler(this.lblLogout_Click);
            // 
            // lblMngProd
            // 
            this.lblMngProd.AutoSize = true;
            this.lblMngProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMngProd.Font = new System.Drawing.Font("Segoe UI Black", 15F);
            this.lblMngProd.Location = new System.Drawing.Point(12, 156);
            this.lblMngProd.Name = "lblMngProd";
            this.lblMngProd.Size = new System.Drawing.Size(189, 35);
            this.lblMngProd.TabIndex = 15;
            this.lblMngProd.Text = "Kelola Produk";
            this.lblMngProd.Click += new System.EventHandler(this.lblMngProd_Click);
            // 
            // ManageMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1129, 696);
            this.Controls.Add(this.lblManageMember);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblKasir);
            this.Controls.Add(this.xButton);
            this.Controls.Add(this.lblLogout);
            this.Controls.Add(this.lblMngProd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageMember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageMember";
            this.Load += new System.EventHandler(this.ManageMember_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader passCol;
        private MetroFramework.Controls.MetroListView lstViewAnggota;
        private System.Windows.Forms.Label lblManageMember;
        private Guna.UI2.WinForms.Guna2Button btnHapus;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox tbPassword;
        private Guna.UI2.WinForms.Guna2TextBox tbUsername;
        private Guna.UI2.WinForms.Guna2Button btnTambah;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblKasir;
        private System.Windows.Forms.Label xButton;
        private System.Windows.Forms.Label lblLogout;
        private System.Windows.Forms.Label lblMngProd;
        private Guna.UI2.WinForms.Guna2ComboBox cbAdmin;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.ColumnHeader usernameCol;
        private System.Windows.Forms.ColumnHeader adminCol;
        private Guna.UI2.WinForms.Guna2Button btnLoad;
    }
}