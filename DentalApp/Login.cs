using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalApp
{
    public partial class Login : Form
    {
        DbHelper dbHelper;
        public Login()
        {
            InitializeComponent(); 
        }

        private void Login_Load(object sender, EventArgs e)
        {
            lblWarning.Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            dbHelper = new DbHelper();
            String username = tbxUsername.Text;
            String password = tbxPassword.Text;

            if (username != String.Empty && password != String.Empty)
            {
                if (dbHelper.Login(username, password))
                {
                    dbHelper = new DbHelper();
                    ArrayList doctorInfo = dbHelper.GetLoggedDoctor(username);
                    Form1 form1 = new Form1(Convert.ToInt32(doctorInfo[0]), doctorInfo[1].ToString());
                    form1.Show();
                    this.Hide();
                }
                else
                {
                    lblWarning.Text = "Username or Password is wrong!";
                    lblWarning.Visible = true;
                }
            }
            else
            {
                lblWarning.Text = "Please enter username/password";
                lblWarning.Visible = true;
            }

            //Burayı veritabanından check et
            
        }

        private void tbxUsername_TextChanged(object sender, EventArgs e)
        {
            lblWarning.Visible = false;
        }

        private void tbxPassword_TextChanged(object sender, EventArgs e)
        {
            lblWarning.Visible = false;
        }

        
    }
}
