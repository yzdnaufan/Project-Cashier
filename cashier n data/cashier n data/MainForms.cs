using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cashier_n_data
{
    public partial class MainForms : Form
    {
        int itemId;
        int totalPrice;

        public MainForms()
        {
            InitializeComponent();

            using (var db = new CashierDBEntities())
            {
                var query = from itemData in db.itemDatas select itemData;
                foreach (var produk in query)
                {
                    tbProdName.AutoCompleteCustomSource.Add(produk.itemName.ToString());
                    tbProdName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    tbProdName.AutoCompleteSource = AutoCompleteSource.CustomSource;
                }
            }
        }

        private void xButton_Click(object sender, EventArgs e)
        {
            LoginHandler.Loginstatus = false;
            LoginHandler.Username = "";
            Application.Exit();
        }

        private void lblKasir_Click(object sender, EventArgs e)
        {

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

        private void lblMngProd_Click(object sender, EventArgs e)
        {
            TambahProduk tambah = new TambahProduk();
            tambah.Show();
            this.Hide();
        }

        private void lblManageMember_Click(object sender, EventArgs e)
        {
            ManageMember tambah = new ManageMember();
            tambah.Show();
            this.Hide();
        }

        private void btnClearAddProdCashier_Click(object sender, EventArgs e)
        {
            tbProdName.Text = "";
            tbQtty.Text = "";
            pictBox.Image = null;
        }

        private void btnClearCashier_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (ListViewItem item in lstViewCashier.Items)
                {
                    lstViewCashier.Items.Remove(item);
                }
                totalPrice = 0;
                lblRpTotal.Text = "Rp " + totalPrice.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelItemCashier_Click(object sender, EventArgs e)
        {
            

            try
            {
                foreach (ListViewItem item in lstViewCashier.SelectedItems)
                {
                    item.Remove();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


            foreach (ListViewItem list in lstViewCashier.Items)
            {
                totalPrice += Convert.ToInt32(list.SubItems[3].Text);
            }
            

            lblRpTotal.Text = "Rp " + totalPrice.ToString();
            totalPrice = 0;
        }

        private void tbProdName_Leave(object sender, EventArgs e)
        {
            try
            {
                using (var db = new CashierDBEntities())
                {
                    string itemName = tbProdName.Text.ToLower();
                    
                    var itemIdQuery = from itemData in db.itemDatas where itemData.itemName.ToLower() == itemName select itemData;
                    foreach (var itemname in itemIdQuery)
                    {
                        itemId = itemname.itemid;
                    }
                    var query = from itemPicture in db.itemPictures where itemPicture.itemid == itemId select itemPicture;
                    foreach (var picture in query)
                    {
                        pictBox.Image = Image.FromStream(new MemoryStream(picture.itemPicture1));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            using (var db = new CashierDBEntities())
            {
                string itemName = tbProdName.Text.ToLower();

                var query = from itemData in db.itemDatas where itemData.itemName.ToLower() == itemName select itemData;
                foreach (var produk in query)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = tbProdName.Text;
                    item.SubItems.Add(produk.itemPrice);
                    item.SubItems.Add(tbQtty.Text);
                    item.SubItems.Add (Convert.ToString(Convert.ToInt16(produk.itemPrice)*Convert.ToInt16(tbQtty.Text)));

                    lstViewCashier.Items.Add(item);
                }
            }
            foreach (ListViewItem list in lstViewCashier.Items)
            {
                totalPrice += Convert.ToInt32(list.SubItems[3].Text);
            }

            lblRpTotal.Text = "Rp " + totalPrice.ToString();

            totalPrice = 0;

        }
    }
}
