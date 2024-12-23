using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prison_Project.OfficerDbFC;

namespace Prison_Project
{
    public partial class OfficersTable : Form
    {
        public OfficersTable()
        {
            InitializeComponent();
        }

        OfficerDBClass odbc = new OfficerDBClass();

        // Insert a record
        private void btnCreateOfr_Click(object sender, EventArgs e)
        {
            // Get the values from Input Fields
            odbc.FirstName = txtFirstNameOfr.Text;
            odbc.LastName = txtLastNameOfr.Text;
            odbc.DOB = dtpDOBOfr.Text;

            if (rbMaleOfr.Checked)
                odbc.Gender = rbMaleOfr.Text;
            else if (rbFemaleOfr.Checked)
                odbc.Gender = rbFemaleOfr.Text;

            odbc.Country = cboCountryOfr.Text;
            odbc.OfficerRank = cboOfficerRank.Text;
            odbc.Email = txtEmailOfr.Text;
            odbc.Password = txtPasswordOfr.Text;

            if (odbc.FirstName.Equals(""))
                MessageBox.Show("Please enter the user's First Name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (odbc.LastName.Equals(""))
                MessageBox.Show("Please enter the user's Last Name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (odbc.DOB.Equals(""))
                MessageBox.Show("Please enter the user's Date Of Birth", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (!rbMaleOfr.Checked == !rbFemaleOfr.Checked)
                MessageBox.Show("Please enter the user's Gender", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (odbc.Country.Equals(""))
                MessageBox.Show("Please enter the user's Country", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (odbc.OfficerRank.Equals(""))
                MessageBox.Show("Please enter the user's Officer Rank", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (odbc.Email.Equals(""))
                MessageBox.Show("Please enter the user's Email", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (odbc.Password.Equals(""))
                MessageBox.Show("Please enter the user's Password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                // Insert a record to the table using the previous method
                bool success = odbc.CreateOfficer(odbc);

                if (success == true)
                {
                    MessageBox.Show("Congratulation, User created sccessfully");

                    Clear();
                }
                else
                {
                    MessageBox.Show("Failed to insert record");
                }

                // Refresh the DGV
                DataTable DT = odbc.SelectOfficers();
                dgvOfficersDB.DataSource = DT;
            }
        }

        // Update the wanted record 
        private void btnUpdateOfr_Click(object sender, EventArgs e)
        {
            odbc.OfficerID = int.Parse(txtOfficerIDOfr.Text);
            odbc.FirstName = txtFirstNameOfr.Text;
            odbc.LastName = txtLastNameOfr.Text;
            odbc.DOB = dtpDOBOfr.Text;
            if (rbMaleOfr.Checked)
                odbc.Gender = rbMaleOfr.Text;
            else if (rbFemaleOfr.Checked)
                odbc.Gender = rbFemaleOfr.Text;
            odbc.Country = cboCountryOfr.Text;
            odbc.OfficerRank = cboOfficerRank.Text;
            odbc.Email = txtEmailOfr.Text;
            odbc.Password = txtPasswordOfr.Text;

            // Check that all fields are full 
            if (odbc.FirstName.Equals(""))
                MessageBox.Show("Please enter the user's First Name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (odbc.LastName.Equals(""))
                MessageBox.Show("Please enter the user's Last Name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (odbc.DOB.Equals(""))
                MessageBox.Show("Please enter the user's Date Of Birth", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (!rbMaleOfr.Checked == !rbFemaleOfr.Checked)
                MessageBox.Show("Please enter the user's Gender", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (odbc.Country.Equals(""))
                MessageBox.Show("Please enter the user's Country", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (odbc.OfficerRank.Equals(""))
                MessageBox.Show("Please enter the user's Officer Rank", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (odbc.Email.Equals(""))
                MessageBox.Show("Please enter the user's Email", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (odbc.Password.Equals(""))
                MessageBox.Show("Please enter the user's Password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                bool success = odbc.UpdateOfficer(odbc);

                if (success == true)
                {
                    MessageBox.Show("Are you sure you want to update this row?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    MessageBox.Show("Congratulation, record has been updated");

                    DataTable DT = odbc.SelectOfficers();
                    dgvOfficersDB.DataSource = DT;

                    Clear();
                }
                else
                {
                    MessageBox.Show("Failed to update record");
                }
            }
        }

        private void OfficersDBForm_Load(object sender, EventArgs e)
        {
            DataTable DT = odbc.SelectOfficers();
            dgvOfficersDB.DataSource = DT;
        }

        // Imporant data form the DGV to their designed fields
        private void dgvOfficersDB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            DataGridViewRow row = dgvOfficersDB.Rows[rowIndex];

            txtOfficerIDOfr.Text = row.Cells[0].Value.ToString();
            txtFirstNameOfr.Text = row.Cells[1].Value.ToString();
            txtLastNameOfr.Text = row.Cells[2].Value.ToString();
            dtpDOBOfr.Value = DateTime.Parse(row.Cells[3].Value.ToString());
            if (row.Cells[4].Value.ToString() == rbMaleOfr.Text) rbMaleOfr.Checked = true;
            else rbFemaleOfr.Checked = true;
            cboCountryOfr.Text = row.Cells[5].Value.ToString();
            cboOfficerRank.Text = row.Cells[6].Value.ToString();
            txtEmailOfr.Text = row.Cells[7].Value.ToString();
            txtPasswordOfr.Text = row.Cells[8].Value.ToString();
        }

        private void btnDeleteOfr_Click(object sender, EventArgs e)
        {
            // Get the data from From
            odbc.OfficerID = int.Parse(txtOfficerIDOfr.Text);
            bool success = odbc.DeleteOfficers(odbc);
            if (success)
            {
                // Successfully deleted
                MessageBox.Show("Are you sure you want to delete this row?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                MessageBox.Show("Record has been deleted");
                // Refresh the DGV
                DataTable dt = odbc.SelectOfficers();
                dgvOfficersDB.DataSource = dt;

                Clear();
            }
            else
            {
                // Failed to delete
                MessageBox.Show("Faild to delete record");
            }
        }

        // View Prisoner Table
        private void lblViewPrisonersDBOfr_Click(object sender, EventArgs e)
        {
            this.Hide();
            PrisonersTable PnrDBForm = new PrisonersTable();
            PnrDBForm.ShowDialog();
            this.Close();
        }

        // Return to Login Form
        private void lblRetrunToLoginOfr_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }

        // Clear all fields
        public void Clear()
        {
            txtOfficerIDOfr.Text = "";
            txtFirstNameOfr.Text = "";
            txtLastNameOfr.Text = "";
            dtpDOBOfr.Text = "";
            rbMaleOfr.Checked = false;
            rbFemaleOfr.Checked = false;
            cboCountryOfr.Text = "";
            cboOfficerRank.Text = "";
            txtEmailOfr.Text = "";
            txtPasswordOfr.Text = "";
        }

        private void btnClearOfr_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
