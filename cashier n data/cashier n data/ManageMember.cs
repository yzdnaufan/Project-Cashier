using System;
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
    public partial class ManageMember : Form
    {
        public ManageMember()
        {
            InitializeComponent();
        }

        private void lblKasir_Click(object sender, EventArgs e)
        {
            MainForms tambah = new MainForms();
            tambah.Show();
            this.Hide();
        }

        private void lblMngProd_Click(object sender, EventArgs e)
        {
            TambahProduk tambah = new TambahProduk();
            tambah.Show();
            this.Hide();
        }

        private void ManageMember_Load(object sender, EventArgs e)
        {
            lblUser.Text = "Hai " + LoginHandler.Username + "!";
        }
    }
}
