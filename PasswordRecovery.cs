using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prison_Project.RecoveryPasswordFC;

namespace Prison_Project
{
    public partial class PasswordRecovery : Form
    {
        public PasswordRecovery()
        {
            InitializeComponent();
        }

        RecoveryPasswordClass rpc = new RecoveryPasswordClass();

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        { 
            rpc.Email = txtEmailCheck.Text;
            rpc.Password = txtNewPassword.Text;

            if (rpc.Email.Equals(""))
                MessageBox.Show("Please enter your current Email.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (rpc.Password.Equals(""))
                MessageBox.Show("Please enter your new Password.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                bool success = rpc.ForgetPassword(rpc);

                if (success == true)
                {
                    MessageBox.Show("Password Updated Successfully");

                    this.Hide();
                    Login login = new Login();
                    login.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed, Email not found.");
                }
            }
        }

        private void lblGoBackToLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }
    }
}
