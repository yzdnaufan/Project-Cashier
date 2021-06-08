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
    public partial class LoginPage : Form
    {
        private bool isadmin;

        public LoginPage()
        {
            InitializeComponent();
        }

        private void xButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            using (var db = new CashierDBEntities())
            {
                var query = from LoginData in db.LoginDatas where tbUsername.Text.ToLower().ToString() == LoginData.username select LoginData;
                foreach (var item in query)
                {
                    isadmin = item.isadmin;
                }
            }

            GetLoginStatus getLogin = new GetLoginStatus();
            if (getLogin.Method(tbUsername.Text.ToString(), tbPassword.Text.ToString()))
            {
                MessageBox.Show("Login Berhasil!");

                LoginHandler.Username = tbUsername.Text.ToString();
                LoginHandler.Loginstatus = true;
                LoginHandler.Isadmin = isadmin;

                MainForms mainForms = new MainForms();
                mainForms.Show();

                using (var db = new CashierDBEntities())
                {
                    var login = db.LoginDatas.First<LoginData>();
                    login.lastlogin = DateTime.Now;
                    db.SaveChanges();
                }

                this.Hide();
            }
            else
            {
                MessageBox.Show("Username atau password Anda salah");
            }
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }


        private void tbUsername_MouseClick(object sender, MouseEventArgs e)
        {
            tbUsername.Text = "";
        }

        private void tbPassword_MouseClick(object sender, MouseEventArgs e)
        {
            tbPassword.Text = "";
        }

        private void tbUsername_Leave(object sender, EventArgs e)
        {
            try
            {
                if (tbUsername.Text == "")
                {
                    tbUsername.Text = "Username";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tbPassword_Leave(object sender, EventArgs e)
        {
            try
            {
                if (tbPassword.Text == "")
                {
                    tbPassword.Text = "Password";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void WelcomeLabel_Click(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void LabelNama_Click(object sender, EventArgs e)
        {

        }

    }
}
