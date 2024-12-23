using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prison_Project
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void btnOfficersView_Click(object sender, EventArgs e)
        {
            this.Hide();
            OfficersTable ofrTable = new OfficersTable();
            ofrTable.ShowDialog();
            this.Close();
        }

        private void btnPrisonersView_Click(object sender, EventArgs e)
        {
            this.Hide();
            PrisonersTable prnTable = new PrisonersTable();
            prnTable.ShowDialog();
            this.Close();
        }
    }
}
