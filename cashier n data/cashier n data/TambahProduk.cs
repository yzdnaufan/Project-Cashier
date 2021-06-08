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
    public partial class TambahProduk : Form
    {
        public TambahProduk()
        {
            InitializeComponent();
        }
        
        private void dataLoad()
        {
            //clear list view first to prevent overdata
            try
            {
                foreach (ListViewItem item in lstvwProd.Items)
                {
                    lstvwProd.Items.Remove(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //load data
            using (var db = new CashierDBEntities())
            {
                var query = from itemData in db.itemDatas select itemData;
                foreach (var item in query)
                {
                    ListViewItem items = new ListViewItem();
                    items.Text = item.itemName.ToString();
                    items.SubItems.Add(item.itemPrice.ToString());

                    lstvwProd.Items.Add(items);
                }
            }
        }

        private void TambahProduk_Load(object sender, EventArgs e)
        {
            lblUser.Text = "Hai " + LoginHandler.Username + "!";
        }

        private void xButton_Click(object sender, EventArgs e)
        {
            LoginHandler.Loginstatus = false;
            LoginHandler.Username = "";
            Application.Exit();
        }

        private void lblKasir_Click(object sender, EventArgs e)
        {
            MainForms mainForms = new MainForms();
            mainForms.Show();
            this.Hide();
        }

        private void lblManageMember_Click(object sender, EventArgs e)
        {
            ManageMember tambah = new ManageMember();
            tambah.Show();
            this.Hide();
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

        private void pictBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog
            {
                Filter = "Image Files (*.png;*.jpg;*.jpeg;*.gif;)|*.png;*.jpg;*.jpeg;*.gif"
            };
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                pictBox.Image = new Bitmap(opnfd.FileName);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            dataLoad();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbNamaProd.Text = "";
            tbHargaProd.Text = "";
            pictBox.Image = null;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            int i;
            if (int.TryParse(tbHargaProd.Text.ToString(), out i))
            {
                //add data
                using (var db = new CashierDBEntities())
                {
                    itemData data = new itemData
                    {
                        itemName = tbNamaProd.Text.ToString(),
                        itemPrice = tbHargaProd.Text.ToString(),
                        itemDescription = "-",
                        itemBarcode = "-",
                    };
                    db.itemDatas.Add(data);
                    db.SaveChanges();

                    itemPicture item = new itemPicture
                    {
                        itemid = data.itemid,
                        itemPicture1 = ImgConverter.convertImgToByte(pictBox.Image),
                    };
                    itemBarcode barcode = new itemBarcode
                    {
                        itemid = data.itemid,
                        itemBarcode1 = null,
                    };

                    db.itemPictures.Add(item);
                    db.itemBarcodes.Add(barcode);
                    db.SaveChanges();
                }


                //clear list view to avoid overdata
                try
                {
                    foreach (ListViewItem item in lstvwProd.Items)
                    {
                        lstvwProd.Items.Remove(item);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                //reload data
                using (var db = new CashierDBEntities())
                {
                    var query = from itemData in db.itemDatas select itemData;
                    foreach (var item in query)
                    {
                        ListViewItem items = new ListViewItem();
                        items.Text = item.itemName.ToString();
                        items.SubItems.Add(item.itemPrice.ToString());

                        lstvwProd.Items.Add(items);
                    }
                }

                MessageBox.Show("Item Ditambahkan");
            }
            else
            {
                MessageBox.Show("Harga Harus Angka");
            }
            
        }

        private void btnDelItem_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (ListViewItem listView in lstvwProd.SelectedItems)
                {
                    listView.Remove();
                    using (var db = new CashierDBEntities())
                    {
                        var query = from itemData in db.itemDatas where itemData.itemName == listView.Text select itemData;
                        foreach (var item in query)
                        {
                            itemData data = new itemData
                            {
                                itemid = item.itemid,
                            };
                            db.itemBarcodes.RemoveRange(db.itemBarcodes.Where(p => p.itemid == data.itemid));
                            db.itemPictures.RemoveRange(db.itemPictures.Where(p => p.itemid == data.itemid));
                        }
                        db.itemDatas.RemoveRange(db.itemDatas.Where(item => item.itemName == listView.Text));
                        db.SaveChanges();
                    }
                }
                MessageBox.Show("Data berhasil dihapus");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
