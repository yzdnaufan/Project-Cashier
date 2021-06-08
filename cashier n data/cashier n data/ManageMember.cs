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

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void ManageMember_Load(object sender, EventArgs e)
        {
            lblUser.Text = "Hai " + LoginHandler.Username + "!";
        }

        private void xButton_Click(object sender, EventArgs e)
        {
            LoginHandler.Loginstatus = false;
            LoginHandler.Username = "";
            Application.Exit();
        }

        private void lstViewAnggota_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void lblLogout_Click(object sender, EventArgs e)
        {
            LoginHandler.Loginstatus = false;
            LoginHandler.Username = "";
            this.Hide();
            LoginPage login = new LoginPage();
            login.Show();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem listView in lstViewAnggota.SelectedItems)
            {
                listView.Remove();
                using (var db = new CashierDBEntities())
                {
                    db.LoginDatas.RemoveRange(db.LoginDatas.Where(item => item.username == listView.Text));
                    db.SaveChanges();
                }
            }
            MessageBox.Show("Data berhasil dihapus");
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            //clear list view first to prevent overdata
            foreach (ListViewItem item in lstViewAnggota.Items)
            {
                lstViewAnggota.Items.Remove(item);
            }

            //load data
            using (var db = new CashierDBEntities())
            {
                var query = from LoginData in db.LoginDatas select LoginData;
                foreach (var item in query)
                {
                    ListViewItem items = new ListViewItem();
                    items.Text = item.username.ToString();
                    items.SubItems.Add(item.password.ToString());
                    items.SubItems.Add(item.isadmin.ToString());

                    lstViewAnggota.Items.Add(items);
                }
            }
        }

        private void lblJudul_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbPassword.Text = "";
            tbUsername.Text = "";
            cbAdmin.SelectedIndex = 0;
        }

        private void lblAdmin_Click(object sender, EventArgs e)
        {

        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (tbPassword.Text != "" && tbUsername.Text != "")
            {
                //add data
                bool boolValue = cbAdmin.SelectedIndex != 0;
                using (var db = new CashierDBEntities())
                {
                    LoginData data = new LoginData
                    {
                        username = tbUsername.Text.ToString(),
                        password = tbPassword.Text.ToString(),
                        isadmin = boolValue,
                    };
                    db.LoginDatas.Add(data);
                    db.SaveChanges();
                }


                //clear list view to avoid overdata
                foreach (ListViewItem item in lstViewAnggota.Items)
                {
                    lstViewAnggota.Items.Remove(item);
                }

                MessageBox.Show("Tambah data berhasil!");
            }
            else
            {
                MessageBox.Show("Username/Password tidak boleh kosong!");
            }
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
