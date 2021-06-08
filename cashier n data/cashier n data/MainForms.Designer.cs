namespace cashier_n_data
{
    partial class MainForms
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
            this.xButton = new System.Windows.Forms.Label();
            this.lblMngProd = new System.Windows.Forms.Label();
            this.lblKasir = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.pictBox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnDelItemCashier = new Guna.UI2.WinForms.Guna2Button();
            this.btnClearCashier = new Guna.UI2.WinForms.Guna2Button();
            this.btnClearAddProdCashier = new Guna.UI2.WinForms.Guna2Button();
            this.btnTambah = new Guna.UI2.WinForms.Guna2Button();
            this.lstViewCashier = new MetroFramework.Controls.MetroListView();
            this.nameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hargaCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.jumlahCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.totalCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbQtty = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbProdName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblRpTotal = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblJumlah = new System.Windows.Forms.Label();
            this.lblJudul = new System.Windows.Forms.Label();
            this.lblProduk = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblLogout = new System.Windows.Forms.Label();
            this.lblManageMember = new System.Windows.Forms.Label();
            this.itemDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // xButton
            // 
            this.xButton.AutoSize = true;
            this.xButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.xButton.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xButton.Location = new System.Drawing.Point(1084, 9);
            this.xButton.Name = "xButton";
            this.xButton.Size = new System.Drawing.Size(33, 35);
            this.xButton.TabIndex = 1;
            this.xButton.Text = "X";
            this.xButton.Click += new System.EventHandler(this.xButton_Click);
            // 
            // lblMngProd
            // 
            this.lblMngProd.AutoSize = true;
            this.lblMngProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMngProd.Font = new System.Drawing.Font("Segoe UI Black", 15F);
            this.lblMngProd.Location = new System.Drawing.Point(12, 156);
            this.lblMngProd.Name = "lblMngProd";
            this.lblMngProd.Size = new System.Drawing.Size(189, 35);
            this.lblMngProd.TabIndex = 2;
            this.lblMngProd.Text = "Kelola Produk";
            this.lblMngProd.Click += new System.EventHandler(this.lblMngProd_Click);
            // 
            // lblKasir
            // 
            this.lblKasir.AutoSize = true;
            this.lblKasir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblKasir.Font = new System.Drawing.Font("Segoe UI Black", 15F);
            this.lblKasir.Location = new System.Drawing.Point(12, 78);
            this.lblKasir.Name = "lblKasir";
            this.lblKasir.Size = new System.Drawing.Size(77, 35);
            this.lblKasir.TabIndex = 2;
            this.lblKasir.Text = "Kasir";
            this.lblKasir.Click += new System.EventHandler(this.lblKasir_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2Panel1.Controls.Add(this.pictBox);
            this.guna2Panel1.Controls.Add(this.btnDelItemCashier);
            this.guna2Panel1.Controls.Add(this.btnClearCashier);
            this.guna2Panel1.Controls.Add(this.btnClearAddProdCashier);
            this.guna2Panel1.Controls.Add(this.btnTambah);
            this.guna2Panel1.Controls.Add(this.lstViewCashier);
            this.guna2Panel1.Controls.Add(this.tbQtty);
            this.guna2Panel1.Controls.Add(this.tbProdName);
            this.guna2Panel1.Controls.Add(this.lblRpTotal);
            this.guna2Panel1.Controls.Add(this.lblTotal);
            this.guna2Panel1.Controls.Add(this.lblJumlah);
            this.guna2Panel1.Controls.Add(this.lblJudul);
            this.guna2Panel1.Controls.Add(this.lblProduk);
            this.guna2Panel1.Location = new System.Drawing.Point(239, 78);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(878, 606);
            this.guna2Panel1.TabIndex = 3;
            // 
            // pictBox
            // 
            this.pictBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictBox.ImageRotate = 0F;
            this.pictBox.Location = new System.Drawing.Point(143, 334);
            this.pictBox.Name = "pictBox";
            this.pictBox.ShadowDecoration.Parent = this.pictBox;
            this.pictBox.Size = new System.Drawing.Size(200, 246);
            this.pictBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictBox.TabIndex = 9;
            this.pictBox.TabStop = false;
            // 
            // btnDelItemCashier
            // 
            this.btnDelItemCashier.BackColor = System.Drawing.Color.Transparent;
            this.btnDelItemCashier.CheckedState.Parent = this.btnDelItemCashier;
            this.btnDelItemCashier.CustomImages.Parent = this.btnDelItemCashier;
            this.btnDelItemCashier.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelItemCashier.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelItemCashier.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelItemCashier.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelItemCashier.DisabledState.Parent = this.btnDelItemCashier;
            this.btnDelItemCashier.FillColor = System.Drawing.Color.Blue;
            this.btnDelItemCashier.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDelItemCashier.ForeColor = System.Drawing.Color.White;
            this.btnDelItemCashier.HoverState.Parent = this.btnDelItemCashier;
            this.btnDelItemCashier.Location = new System.Drawing.Point(563, 556);
            this.btnDelItemCashier.Name = "btnDelItemCashier";
            this.btnDelItemCashier.ShadowDecoration.Parent = this.btnDelItemCashier;
            this.btnDelItemCashier.Size = new System.Drawing.Size(185, 34);
            this.btnDelItemCashier.TabIndex = 5;
            this.btnDelItemCashier.Text = "Hapus Item Terpilih";
            this.btnDelItemCashier.Click += new System.EventHandler(this.btnDelItemCashier_Click);
            // 
            // btnClearCashier
            // 
            this.btnClearCashier.BackColor = System.Drawing.Color.Transparent;
            this.btnClearCashier.CheckedState.Parent = this.btnClearCashier;
            this.btnClearCashier.CustomImages.Parent = this.btnClearCashier;
            this.btnClearCashier.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClearCashier.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClearCashier.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClearCashier.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClearCashier.DisabledState.Parent = this.btnClearCashier;
            this.btnClearCashier.FillColor = System.Drawing.Color.Blue;
            this.btnClearCashier.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClearCashier.ForeColor = System.Drawing.Color.White;
            this.btnClearCashier.HoverState.Parent = this.btnClearCashier;
            this.btnClearCashier.Location = new System.Drawing.Point(754, 556);
            this.btnClearCashier.Name = "btnClearCashier";
            this.btnClearCashier.ShadowDecoration.Parent = this.btnClearCashier;
            this.btnClearCashier.Size = new System.Drawing.Size(88, 34);
            this.btnClearCashier.TabIndex = 6;
            this.btnClearCashier.Text = "Clear";
            this.btnClearCashier.Click += new System.EventHandler(this.btnClearCashier_Click);
            // 
            // btnClearAddProdCashier
            // 
            this.btnClearAddProdCashier.BackColor = System.Drawing.Color.Transparent;
            this.btnClearAddProdCashier.CheckedState.Parent = this.btnClearAddProdCashier;
            this.btnClearAddProdCashier.CustomImages.Parent = this.btnClearAddProdCashier;
            this.btnClearAddProdCashier.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClearAddProdCashier.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClearAddProdCashier.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClearAddProdCashier.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClearAddProdCashier.DisabledState.Parent = this.btnClearAddProdCashier;
            this.btnClearAddProdCashier.FillColor = System.Drawing.Color.Blue;
            this.btnClearAddProdCashier.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClearAddProdCashier.ForeColor = System.Drawing.Color.White;
            this.btnClearAddProdCashier.HoverState.Parent = this.btnClearAddProdCashier;
            this.btnClearAddProdCashier.Location = new System.Drawing.Point(255, 264);
            this.btnClearAddProdCashier.Name = "btnClearAddProdCashier";
            this.btnClearAddProdCashier.ShadowDecoration.Parent = this.btnClearAddProdCashier;
            this.btnClearAddProdCashier.Size = new System.Drawing.Size(88, 34);
            this.btnClearAddProdCashier.TabIndex = 7;
            this.btnClearAddProdCashier.Text = "Clear";
            this.btnClearAddProdCashier.Click += new System.EventHandler(this.btnClearAddProdCashier_Click);
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
            this.btnTambah.Location = new System.Drawing.Point(143, 264);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.ShadowDecoration.Parent = this.btnTambah;
            this.btnTambah.Size = new System.Drawing.Size(92, 34);
            this.btnTambah.TabIndex = 8;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // lstViewCashier
            // 
            this.lstViewCashier.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameCol,
            this.hargaCol,
            this.jumlahCol,
            this.totalCol});
            this.lstViewCashier.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lstViewCashier.FullRowSelect = true;
            this.lstViewCashier.Location = new System.Drawing.Point(382, 110);
            this.lstViewCashier.Name = "lstViewCashier";
            this.lstViewCashier.OwnerDraw = true;
            this.lstViewCashier.Size = new System.Drawing.Size(481, 401);
            this.lstViewCashier.TabIndex = 4;
            this.lstViewCashier.UseCompatibleStateImageBehavior = false;
            this.lstViewCashier.UseSelectable = true;
            this.lstViewCashier.View = System.Windows.Forms.View.Details;
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
            // jumlahCol
            // 
            this.jumlahCol.Text = "Jumlah";
            this.jumlahCol.Width = 75;
            // 
            // totalCol
            // 
            this.totalCol.Text = "Total";
            this.totalCol.Width = 100;
            // 
            // tbQtty
            // 
            this.tbQtty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbQtty.DefaultText = "";
            this.tbQtty.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbQtty.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbQtty.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbQtty.DisabledState.Parent = this.tbQtty;
            this.tbQtty.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbQtty.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbQtty.FocusedState.Parent = this.tbQtty;
            this.tbQtty.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbQtty.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbQtty.HoverState.Parent = this.tbQtty;
            this.tbQtty.Location = new System.Drawing.Point(143, 183);
            this.tbQtty.Name = "tbQtty";
            this.tbQtty.PasswordChar = '\0';
            this.tbQtty.PlaceholderText = "";
            this.tbQtty.SelectedText = "";
            this.tbQtty.ShadowDecoration.Parent = this.tbQtty;
            this.tbQtty.Size = new System.Drawing.Size(200, 36);
            this.tbQtty.TabIndex = 2;
            // 
            // tbProdName
            // 
            this.tbProdName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbProdName.DefaultText = "";
            this.tbProdName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbProdName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbProdName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbProdName.DisabledState.Parent = this.tbProdName;
            this.tbProdName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbProdName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbProdName.FocusedState.Parent = this.tbProdName;
            this.tbProdName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbProdName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbProdName.HoverState.Parent = this.tbProdName;
            this.tbProdName.Location = new System.Drawing.Point(143, 110);
            this.tbProdName.Name = "tbProdName";
            this.tbProdName.PasswordChar = '\0';
            this.tbProdName.PlaceholderText = "";
            this.tbProdName.SelectedText = "";
            this.tbProdName.ShadowDecoration.Parent = this.tbProdName;
            this.tbProdName.Size = new System.Drawing.Size(200, 36);
            this.tbProdName.TabIndex = 1;
            this.tbProdName.Leave += new System.EventHandler(this.tbProdName_Leave);
            // 
            // lblRpTotal
            // 
            this.lblRpTotal.AutoSize = true;
            this.lblRpTotal.Font = new System.Drawing.Font("Segoe UI Black", 12.5F);
            this.lblRpTotal.Location = new System.Drawing.Point(643, 514);
            this.lblRpTotal.Name = "lblRpTotal";
            this.lblRpTotal.Size = new System.Drawing.Size(59, 30);
            this.lblRpTotal.TabIndex = 0;
            this.lblRpTotal.Text = "Rp 0";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI Black", 12.5F);
            this.lblTotal.Location = new System.Drawing.Point(558, 514);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(79, 30);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Total :";
            // 
            // lblJumlah
            // 
            this.lblJumlah.AutoSize = true;
            this.lblJumlah.Font = new System.Drawing.Font("Segoe UI Black", 12.5F);
            this.lblJumlah.Location = new System.Drawing.Point(22, 183);
            this.lblJumlah.Name = "lblJumlah";
            this.lblJumlah.Size = new System.Drawing.Size(88, 30);
            this.lblJumlah.TabIndex = 0;
            this.lblJumlah.Text = "Jumlah";
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.Font = new System.Drawing.Font("SimSun-ExtB", 25F);
            this.lblJudul.Location = new System.Drawing.Point(365, 4);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(123, 42);
            this.lblJudul.TabIndex = 0;
            this.lblJudul.Text = "Kasir";
            // 
            // lblProduk
            // 
            this.lblProduk.AutoSize = true;
            this.lblProduk.Font = new System.Drawing.Font("Segoe UI Black", 12.5F);
            this.lblProduk.Location = new System.Drawing.Point(22, 110);
            this.lblProduk.Name = "lblProduk";
            this.lblProduk.Size = new System.Drawing.Size(87, 30);
            this.lblProduk.TabIndex = 0;
            this.lblProduk.Text = "Produk";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI Black", 15F);
            this.lblUser.Location = new System.Drawing.Point(12, 9);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(22, 35);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = " ";
            this.lblUser.Click += new System.EventHandler(this.lblKasir_Click);
            // 
            // lblLogout
            // 
            this.lblLogout.AutoSize = true;
            this.lblLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLogout.Font = new System.Drawing.Font("Segoe UI Black", 15F);
            this.lblLogout.Location = new System.Drawing.Point(12, 637);
            this.lblLogout.Name = "lblLogout";
            this.lblLogout.Size = new System.Drawing.Size(113, 35);
            this.lblLogout.TabIndex = 2;
            this.lblLogout.Text = "Log Out";
            this.lblLogout.Click += new System.EventHandler(this.lblLogout_Click);
            // 
            // lblManageMember
            // 
            this.lblManageMember.AutoSize = true;
            this.lblManageMember.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblManageMember.Font = new System.Drawing.Font("Segoe UI Black", 15F);
            this.lblManageMember.Location = new System.Drawing.Point(12, 234);
            this.lblManageMember.Name = "lblManageMember";
            this.lblManageMember.Size = new System.Drawing.Size(206, 35);
            this.lblManageMember.TabIndex = 0;
            this.lblManageMember.Text = "Kelola Anggota";
            this.lblManageMember.Click += new System.EventHandler(this.lblManageMember_Click);
            // 
            // itemDataBindingSource
            // 
            this.itemDataBindingSource.DataSource = typeof(cashier_n_data.itemData);
            // 
            // MainForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1129, 696);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblKasir);
            this.Controls.Add(this.lblLogout);
            this.Controls.Add(this.lblMngProd);
            this.Controls.Add(this.xButton);
            this.Controls.Add(this.lblManageMember);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForms";
            this.Load += new System.EventHandler(this.MainForms_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemDataBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label xButton;
        private System.Windows.Forms.Label lblMngProd;
        private System.Windows.Forms.Label lblKasir;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblLogout;
        private Guna.UI2.WinForms.Guna2TextBox tbQtty;
        private Guna.UI2.WinForms.Guna2TextBox tbProdName;
        private System.Windows.Forms.Label lblProduk;
        private MetroFramework.Controls.MetroListView lstViewCashier;
        private System.Windows.Forms.ColumnHeader nameCol;
        private System.Windows.Forms.ColumnHeader hargaCol;
        private System.Windows.Forms.ColumnHeader jumlahCol;
        private System.Windows.Forms.ColumnHeader totalCol;
        private System.Windows.Forms.Label lblRpTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblJumlah;
        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.BindingSource itemDataBindingSource;
        private Guna.UI2.WinForms.Guna2PictureBox pictBox;
        private Guna.UI2.WinForms.Guna2Button btnDelItemCashier;
        private Guna.UI2.WinForms.Guna2Button btnClearCashier;
        private Guna.UI2.WinForms.Guna2Button btnClearAddProdCashier;
        private Guna.UI2.WinForms.Guna2Button btnTambah;
        private System.Windows.Forms.Label lblManageMember;
    }
}