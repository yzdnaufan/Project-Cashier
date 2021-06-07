﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cashier_n_data
{
    public partial class MainForms : Form
    {

        public MainForms()
        {
            InitializeComponent();
        }

        private void xButton_Click(object sender, EventArgs e)
        {
            LoginHandler.Loginstatus = false;
            LoginHandler.Username = "";
            Application.Exit();
        }

        private void lblKasir_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void MainForms_Load(object sender, EventArgs e)
        {
            lblUser.Text = "Hai " + LoginHandler.Username + "!";
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            try
            {
                LoginHandler.Loginstatus = false;
                LoginHandler.Username = "";
                this.Hide();
                LoginPage login = new LoginPage();
                login.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lblAddProd_Click(object sender, EventArgs e)
        {
            TambahProduk tambah = new TambahProduk();
            tambah.Show();
            this.Hide();
        }
    }
}
