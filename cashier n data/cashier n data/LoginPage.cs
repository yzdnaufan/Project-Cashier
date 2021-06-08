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
        private bool loginStatus;
        private bool isadmin;

        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void xButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            GetLoginStatus(tbUsername.Text.ToString(), tbPassword.Text.ToString());

            using (var db = new CashierDBEntities())
            {
                var query = from LoginData in db.LoginDatas where tbUsername.Text.ToLower().ToString() == LoginData.username select LoginData;
                foreach (var item in query)
                {
                    isadmin = item.isadmin;
                }
            }

            if (loginStatus)
            {
                MessageBox.Show("Login Berhasil!");
                LoginHandler.Username = tbUsername.Text.ToString();
                LoginHandler.Loginstatus = true;
                LoginHandler.Isadmin = isadmin;
                MainForms mainForms = new MainForms();
                mainForms.Show();
                MessageBox.Show(LoginHandler.Isadmin.ToString());
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username atau password Anda salah");
            }
        }

        private void GetLoginStatus(string LoginName, string LoginPass)
        {
            using (var db = new CashierDBEntities())
            {

                //get query for matching txtbox text and database
                var query = from LoginData in db.LoginDatas where LoginData.username == LoginName && LoginData.password == LoginPass select LoginData;
                if (query.Any())
                {
                    loginStatus = true;
                }
                else
                {
                    loginStatus = false;
                }
                    
            }
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
        
    }
}
