using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Prison_Project.LoginFC;

namespace Prison_Project
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        LoginClass lc = new LoginClass();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lc.Email = txtEmail.Text;
            lc.Password = txtPassword.Text;

            if (lc.Email.Equals(""))
                MessageBox.Show("Please enter your Email.");
            else if (lc.Password.Equals(""))
                MessageBox.Show("Please enter your Password.");

            else
            {
                bool success = lc.LoginOfficer(lc);

                if (success == true)
                {
                    this.Hide();
                    HomePage hp = new HomePage();
                    hp.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Incorrect Email or Password. Please try again");
                }
            }
        }

        private void lblForgetPassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            PasswordRecovery passRecov = new PasswordRecovery();
            passRecov.ShowDialog();
            this.Close();
        }
    }
}
