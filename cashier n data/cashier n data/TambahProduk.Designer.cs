namespace cashier_n_data
{
    partial class TambahProduk
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lstvwProd = new MetroFramework.Controls.MetroListView();
            this.nameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hargaCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictBox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.tbHargaProd = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbNamaProd = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.btnLoad = new Guna.UI2.WinForms.Guna2Button();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.btnTambah = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHarga = new System.Windows.Forms.Label();
            this.lblJudul = new System.Windows.Forms.Label();
            this.lblProduk = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblKasir = new System.Windows.Forms.Label();
            this.lblLogout = new System.Windows.Forms.Label();
            this.lblMngProd = new System.Windows.Forms.Label();
            this.xButton = new System.Windows.Forms.Label();
            this.lblManageMember = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictBox)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2Panel1.Controls.Add(this.lstvwProd);
            this.guna2Panel1.Controls.Add(this.pictBox);
            this.guna2Panel1.Controls.Add(this.tbHargaProd);
            this.guna2Panel1.Controls.Add(this.tbNamaProd);
            this.guna2Panel1.Controls.Add(this.guna2Button3);
            this.guna2Panel1.Controls.Add(this.btnLoad);
            this.guna2Panel1.Controls.Add(this.btnClear);
            this.guna2Panel1.Controls.Add(this.btnTambah);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.lblHarga);
            this.guna2Panel1.Controls.Add(this.lblJudul);
            this.guna2Panel1.Controls.Add(this.lblProduk);
            this.guna2Panel1.Location = new System.Drawing.Point(239, 80);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(878, 606);
            this.guna2Panel1.TabIndex = 9;
            // 
            // lstvwProd
            // 
            this.lstvwProd.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameCol,
            this.hargaCol});
            this.lstvwProd.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lstvwProd.FullRowSelect = true;
            this.lstvwProd.Location = new System.Drawing.Point(394, 110);
            this.lstvwProd.Name = "lstvwProd";
            this.lstvwProd.OwnerDraw = true;
            this.lstvwProd.Size = new System.Drawing.Size(468, 443);
            this.lstvwProd.TabIndex = 5;
            this.lstvwProd.UseCompatibleStateImageBehavior = false;
            this.lstvwProd.UseSelectable = true;
            this.lstvwProd.View = System.Windows.Forms.View.Details;
            // 
            // nameCol
            // 
            this.nameCol.Text = "Nama Produk";
            this.nameCol.Width = 200;
            // 
            // hargaCol
            // 
            this.hargaCol.Text = "Harga";
            this.hargaCol.Width = 100;
            // 
            // pictBox
            // 
            this.pictBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictBox.ImageRotate = 0F;
            this.pictBox.Location = new System.Drawing.Point(176, 347);
            this.pictBox.Name = "pictBox";
            this.pictBox.ShadowDecoration.Parent = this.pictBox;
            this.pictBox.Size = new System.Drawing.Size(200, 246);
            this.pictBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictBox.TabIndex = 4;
            this.pictBox.TabStop = false;
            this.pictBox.Click += new System.EventHandler(this.pictBox_Click);
            // 
            // tbHargaProd
            // 
            this.tbHargaProd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbHargaProd.DefaultText = "";
            this.tbHargaProd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbHargaProd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbHargaProd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbHargaProd.DisabledState.Parent = this.tbHargaProd;
            this.tbHargaProd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbHargaProd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbHargaProd.FocusedState.Parent = this.tbHargaProd;
            this.tbHargaProd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbHargaProd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbHargaProd.HoverState.Parent = this.tbHargaProd;
            this.tbHargaProd.Location = new System.Drawing.Point(211, 183);
            this.tbHargaProd.Name = "tbHargaProd";
            this.tbHargaProd.PasswordChar = '\0';
            this.tbHargaProd.PlaceholderText = "";
            this.tbHargaProd.SelectedText = "";
            this.tbHargaProd.ShadowDecoration.Parent = this.tbHargaProd;
            this.tbHargaProd.Size = new System.Drawing.Size(165, 36);
            this.tbHargaProd.TabIndex = 2;
            // 
            // tbNamaProd
            // 
            this.tbNamaProd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbNamaProd.DefaultText = "";
            this.tbNamaProd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbNamaProd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbNamaProd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbNamaProd.DisabledState.Parent = this.tbNamaProd;
            this.tbNamaProd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbNamaProd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNamaProd.FocusedState.Parent = this.tbNamaProd;
            this.tbNamaProd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbNamaProd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNamaProd.HoverState.Parent = this.tbNamaProd;
            this.tbNamaProd.Location = new System.Drawing.Point(211, 110);
            this.tbNamaProd.Name = "tbNamaProd";
            this.tbNamaProd.PasswordChar = '\0';
            this.tbNamaProd.PlaceholderText = "";
            this.tbNamaProd.SelectedText = "";
            this.tbNamaProd.ShadowDecoration.Parent = this.tbNamaProd;
            this.tbNamaProd.Size = new System.Drawing.Size(165, 36);
            this.tbNamaProd.TabIndex = 1;
            // 
            // guna2Button3
            // 
            this.guna2Button3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button3.CheckedState.Parent = this.guna2Button3;
            this.guna2Button3.CustomImages.Parent = this.guna2Button3;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.DisabledState.Parent = this.guna2Button3;
            this.guna2Button3.FillColor = System.Drawing.Color.Blue;
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.HoverState.Parent = this.guna2Button3;
            this.guna2Button3.Location = new System.Drawing.Point(583, 558);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.ShadowDecoration.Parent = this.guna2Button3;
            this.guna2Button3.Size = new System.Drawing.Size(185, 34);
            this.guna2Button3.TabIndex = 3;
            this.guna2Button3.Text = "Hapus Item Terpilih";
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
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "Muat";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
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
            this.btnClear.Location = new System.Drawing.Point(288, 267);
            this.btnClear.Name = "btnClear";
            this.btnClear.ShadowDecoration.Parent = this.btnClear;
            this.btnClear.Size = new System.Drawing.Size(88, 34);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
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
            this.btnTambah.Location = new System.Drawing.Point(176, 267);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.ShadowDecoration.Parent = this.btnTambah;
            this.btnTambah.Size = new System.Drawing.Size(92, 34);
            this.btnTambah.TabIndex = 3;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 12.5F);
            this.label1.Location = new System.Drawing.Point(22, 347);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gambar";
            // 
            // lblHarga
            // 
            this.lblHarga.AutoSize = true;
            this.lblHarga.Font = new System.Drawing.Font("Segoe UI Black", 12.5F);
            this.lblHarga.Location = new System.Drawing.Point(22, 183);
            this.lblHarga.Name = "lblHarga";
            this.lblHarga.Size = new System.Drawing.Size(76, 30);
            this.lblHarga.TabIndex = 0;
            this.lblHarga.Text = "Harga";
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.Font = new System.Drawing.Font("SimSun-ExtB", 25F);
            this.lblJudul.Location = new System.Drawing.Point(304, 12);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(291, 42);
            this.lblJudul.TabIndex = 0;
            this.lblJudul.Text = "Tambah Produk";
            // 
            // lblProduk
            // 
            this.lblProduk.AutoSize = true;
            this.lblProduk.Font = new System.Drawing.Font("Segoe UI Black", 12.5F);
            this.lblProduk.Location = new System.Drawing.Point(22, 110);
            this.lblProduk.Name = "lblProduk";
            this.lblProduk.Size = new System.Drawing.Size(154, 30);
            this.lblProduk.TabIndex = 0;
            this.lblProduk.Text = "Nama Produk";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI Black", 15F);
            this.lblUser.Location = new System.Drawing.Point(12, 11);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(22, 35);
            this.lblUser.TabIndex = 5;
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
            this.lblKasir.TabIndex = 6;
            this.lblKasir.Text = "Kasir";
            this.lblKasir.Click += new System.EventHandler(this.lblKasir_Click);
            // 
            // lblLogout
            // 
            this.lblLogout.AutoSize = true;
            this.lblLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLogout.Font = new System.Drawing.Font("Segoe UI Black", 15F);
            this.lblLogout.Location = new System.Drawing.Point(12, 638);
            this.lblLogout.Name = "lblLogout";
            this.lblLogout.Size = new System.Drawing.Size(113, 35);
            this.lblLogout.TabIndex = 7;
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
            this.lblMngProd.TabIndex = 8;
            this.lblMngProd.Text = "Kelola Produk";
            // 
            // xButton
            // 
            this.xButton.AutoSize = true;
            this.xButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.xButton.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xButton.Location = new System.Drawing.Point(1084, 11);
            this.xButton.Name = "xButton";
            this.xButton.Size = new System.Drawing.Size(33, 35);
            this.xButton.TabIndex = 4;
            this.xButton.Text = "X";
            this.xButton.Click += new System.EventHandler(this.xButton_Click);
            // 
            // lblManageMember
            // 
            this.lblManageMember.AutoSize = true;
            this.lblManageMember.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblManageMember.Font = new System.Drawing.Font("Segoe UI Black", 15F);
            this.lblManageMember.Location = new System.Drawing.Point(12, 234);
            this.lblManageMember.Name = "lblManageMember";
            this.lblManageMember.Size = new System.Drawing.Size(206, 35);
            this.lblManageMember.TabIndex = 10;
            this.lblManageMember.Text = "Kelola Anggota";
            this.lblManageMember.Click += new System.EventHandler(this.lblManageMember_Click);
            // 
            // TambahProduk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1129, 696);
            this.Controls.Add(this.lblManageMember);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblKasir);
            this.Controls.Add(this.lblLogout);
            this.Controls.Add(this.lblMngProd);
            this.Controls.Add(this.xButton);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TambahProduk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TambahProduk";
            this.Load += new System.EventHandler(this.TambahProduk_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox tbHargaProd;
        private Guna.UI2.WinForms.Guna2TextBox tbNamaProd;
        private Guna.UI2.WinForms.Guna2Button btnTambah;
        private System.Windows.Forms.Label lblHarga;
        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.Label lblProduk;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblKasir;
        private System.Windows.Forms.Label lblLogout;
        private System.Windows.Forms.Label lblMngProd;
        private System.Windows.Forms.Label xButton;
        private Guna.UI2.WinForms.Guna2PictureBox pictBox;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private System.Windows.Forms.Label lblManageMember;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroListView lstvwProd;
        private System.Windows.Forms.ColumnHeader nameCol;
        private System.Windows.Forms.ColumnHeader hargaCol;
        private Guna.UI2.WinForms.Guna2Button btnLoad;
    }
}