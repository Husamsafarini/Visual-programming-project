using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prison_Project.PrisonersDbFC;

namespace Prison_Project
{
    public partial class PrisonersTable : Form
    {
        public PrisonersTable()
        {
            InitializeComponent();
        }

        PrisonerDBClass pdbc = new PrisonerDBClass();

        // Return to Login Form
        private void lblRetrunToLoginPnr_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }

        // View Officers table
        private void lblViewOfficersDBPnr_Click(object sender, EventArgs e)
        {
            this.Hide();
            OfficersTable ofrTable = new OfficersTable();
            ofrTable.ShowDialog();
            this.Close();
        }

        //Insert records into the database
        private void btnInsertPnr_Click(object sender, EventArgs e)
        {
            string diseasePicker = "", crimePicker = "", visitorsPicker = "", extraInfoVisitors = " ";

            // Get the values from Input Fields
            pdbc.FirstName = txtFirstNamePnr.Text;
            pdbc.LastName = txtLastNamePnr.Text;
            pdbc.DOB = dtpDOBPnr.Text;

            if (rbMalePnr.Checked)
                pdbc.Gender = rbMalePnr.Text;
            else if (rbFemalePnr.Checked)
                pdbc.Gender = rbFemalePnr.Text;

            pdbc.Country = cboCountryPnr.Text;
            pdbc.Height = txtHeightPnr.Text;
            pdbc.Weight = txtWeightPnr.Text;
            pdbc.Colour = cboColourPnr.Text;

            if (chkInfectiousPnr.Checked)
                diseasePicker = chkInfectiousPnr.Text;
            if (chkDeficiencyPnr.Checked)
                diseasePicker = diseasePicker + " " + chkDeficiencyPnr.Text;
            if (chkHereditaryPnr.Checked)
                diseasePicker = diseasePicker + " " + chkHereditaryPnr.Text;
            if (chkPhysiologicalPnr.Checked)
                diseasePicker = diseasePicker + " " + chkPhysiologicalPnr.Text;
            if (chkNonePnr.Checked)
                diseasePicker = chkNonePnr.Text;
            pdbc.Disease = diseasePicker;

            if (rbSinglePnr.Checked)
                pdbc.MaritalStatus = rbSinglePnr.Text;
            else if (rbMarriedPnr.Checked)
                pdbc.MaritalStatus = rbMarriedPnr.Text;
            else if (rbDivorcedPnr.Checked)
                pdbc.MaritalStatus = rbDivorcedPnr.Text;

            if (chkViolentPnr.Checked)
                crimePicker = chkViolentPnr.Text;
            if (chkPropertyPnr.Checked)
                crimePicker = crimePicker + " " + chkPropertyPnr.Text;
            if (chkWhiteCollarPnr.Checked)
                crimePicker = crimePicker + " " + chkWhiteCollarPnr.Text;
            if (chkConsensualVictimlessPnr.Checked)
                crimePicker = crimePicker + " " + chkConsensualVictimlessPnr.Text;
            pdbc.Crime = crimePicker;

            pdbc.DateOfCrime = dtpDateOfCrimePnr.Text;
            pdbc.ImprisonmentDate = dtpImprisonmentDatePnr.Text;
            pdbc.ReleaseDate = dtpReleaseDatePnr.Text;
            pdbc.PrisonCell = cboPrisonCellPnr.Text;

            if (chkFamilyPnr.Checked)
                visitorsPicker = chkFamilyPnr.Text;
            if (chkFriendsPnr.Checked)
                visitorsPicker = visitorsPicker + " " + chkFriendsPnr.Text;
            if (chkBusinessPnr.Checked)
                visitorsPicker = visitorsPicker + " " + chkBusinessPnr.Text;
            if (chkOtherPnr.Checked)
                visitorsPicker = visitorsPicker + " " + chkOtherPnr.Text;
            pdbc.Visitors = visitorsPicker;

            if (txtOtherPnr.Text != "") extraInfoVisitors = txtOtherPnr.Text;
            pdbc.ExtraInfo = extraInfoVisitors;

            // Check if the user missed any input fields
            if (pdbc.FirstName.Equals(""))
                MessageBox.Show("Please enter the Prisoner's First Name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (pdbc.LastName.Equals(""))
                MessageBox.Show("Please enter the Prisoner's Last Name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (pdbc.DOB.Equals(""))
                MessageBox.Show("Please enter the Prisoner's Date Of Birth", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (!rbMalePnr.Checked == !rbFemalePnr.Checked)
                MessageBox.Show("Please enter the Prisoner's Gender", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (pdbc.Country.Equals(""))
                MessageBox.Show("Please enter the Prisoner's Country", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (pdbc.Height.Equals(""))
                MessageBox.Show("Please enter the Prisoner's Height", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (pdbc.Weight.Equals(""))
                MessageBox.Show("Please enter the Prisoner's Weight", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (pdbc.Colour.Equals(""))
                MessageBox.Show("Please enter the Prisoner's Colour", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (pdbc.Disease.Equals(""))
                MessageBox.Show("Please enter the Prisoner's Disease", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (!rbSinglePnr.Checked == !rbMarriedPnr.Checked == !rbDivorcedPnr.Checked)
                MessageBox.Show("Please enter the Prisoner's Marital Status", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (pdbc.Crime.Equals(""))
                MessageBox.Show("Please enter the Prisoner's Crime", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (pdbc.DateOfCrime.Equals(""))
                MessageBox.Show("Please enter the Prisoner's Date Of Crime", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (pdbc.ImprisonmentDate.Equals(""))
                MessageBox.Show("Please enter the Prisoner's Imprisonment Date", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (pdbc.ReleaseDate.Equals(""))
                MessageBox.Show("Please enter the Prisoner's Release Date", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (pdbc.PrisonCell.Equals(""))
                MessageBox.Show("Please enter the Prisoner's Prison Cell", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (pdbc.Visitors.Equals(""))
                MessageBox.Show("Please enter the Prisoner's Visitors", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                // Insert a record to the table using the previous method
                bool success = pdbc.InsertPrisoners(pdbc);

                if (success == true)
                {
                    MessageBox.Show("Congratulation, a new prisoner has been inserted into the table");

                    Clear();
                }
                else
                {
                    MessageBox.Show("Failed");
                }

                DataTable DT = pdbc.SelectPrisoners();
                dgvPrisonerDB.DataSource = DT;
            }
        }

        // Clear all components
        public void Clear()
        {
            txtPrisonerIDPnr.Text = "";
            txtFirstNamePnr.Text = "";
            txtLastNamePnr.Text = "";
            dtpDOBPnr.Text = "";
            rbMalePnr.Checked = false;
            rbFemalePnr.Checked = false;
            cboCountryPnr.Text = "";
            txtHeightPnr.Text = "";
            txtWeightPnr.Text = "";
            cboColourPnr.Text = "";
            chkInfectiousPnr.Checked = false;
            chkDeficiencyPnr.Checked = false;
            chkHereditaryPnr.Checked = false;
            chkPhysiologicalPnr.Checked = false;
            chkNonePnr.Checked = false;
            rbSinglePnr.Checked = false;
            rbMarriedPnr.Checked = false;
            rbDivorcedPnr.Checked = false;
            chkViolentPnr.Checked = false;
            chkPropertyPnr.Checked = false;
            chkWhiteCollarPnr.Checked = false;
            chkConsensualVictimlessPnr.Checked = false;
            dtpDateOfCrimePnr.Text = "";
            dtpImprisonmentDatePnr.Text = "";
            dtpReleaseDatePnr.Text = "";
            cboPrisonCellPnr.Text = "";
            chkFamilyPnr.Checked = false;
            chkFriendsPnr.Checked = false;
            chkBusinessPnr.Checked = false;
            chkOtherPnr.Checked = false;
            txtOtherPnr.Text = "";
        }

        private void btnClearPnr_Click(object sender, EventArgs e)
        {
            Clear();
        }

        // Place a minimum value on the current DTP, depending on the previous DTP
        private void PrisonersDBForm_Load(object sender, EventArgs e)
        {
            DataTable DT = pdbc.SelectPrisoners();
            dgvPrisonerDB.DataSource = DT;
        }

        private void dtpDOBPnr_ValueChanged(object sender, EventArgs e)
        {
            DateTime dt = dtpDOBPnr.Value;
            dtpDateOfCrimePnr.MinDate = dt;
        }

        private void dtpDateOfCrimePnr_ValueChanged(object sender, EventArgs e)
        {
            DateTime dt = dtpDateOfCrimePnr.Value;
            dtpImprisonmentDatePnr.MinDate = dt;
        }

        private void dtpImprisonmentDatePnr_ValueChanged(object sender, EventArgs e)
        {
            DateTime dt = dtpImprisonmentDatePnr.Value;
            dtpReleaseDatePnr.MinDate = dt;
        }

        // Update data into database
        private void btnUpdatePnr_Click(object sender, EventArgs e)
        {
            string diseasePicker = "", crimePicker = "", visitorsPicker = "", extraInfoVisitors = " ";

            pdbc.PrisonerID = int.Parse(txtPrisonerIDPnr.Text);
            pdbc.FirstName = txtFirstNamePnr.Text;
            pdbc.LastName = txtLastNamePnr.Text;
            pdbc.DOB = dtpDOBPnr.Text;

            if (rbMalePnr.Checked)
                pdbc.Gender = rbMalePnr.Text;
            else if (rbFemalePnr.Checked)
                pdbc.Gender = rbFemalePnr.Text;

            pdbc.Country = cboCountryPnr.Text;
            pdbc.Height = txtHeightPnr.Text;
            pdbc.Weight = txtWeightPnr.Text;
            pdbc.Colour = cboColourPnr.Text;

            if (chkInfectiousPnr.Checked)
                diseasePicker = chkInfectiousPnr.Text;
            if (chkDeficiencyPnr.Checked)
                diseasePicker = diseasePicker + " " + chkDeficiencyPnr.Text;
            if (chkHereditaryPnr.Checked)
                diseasePicker = diseasePicker + " " + chkHereditaryPnr.Text;
            if (chkPhysiologicalPnr.Checked)
                diseasePicker = diseasePicker + " " + chkPhysiologicalPnr.Text;
            if (chkNonePnr.Checked)
                diseasePicker = chkNonePnr.Text;
            pdbc.Disease = diseasePicker;

            if (rbSinglePnr.Checked)
                pdbc.MaritalStatus = rbSinglePnr.Text;
            else if (rbMarriedPnr.Checked)
                pdbc.MaritalStatus = rbMarriedPnr.Text;
            else if (rbDivorcedPnr.Checked)
                pdbc.MaritalStatus = rbDivorcedPnr.Text;

            if (chkViolentPnr.Checked)
                crimePicker = chkViolentPnr.Text;
            if (chkPropertyPnr.Checked)
                crimePicker = crimePicker + " " + chkPropertyPnr.Text;
            if (chkWhiteCollarPnr.Checked)
                crimePicker = crimePicker + " " + chkWhiteCollarPnr.Text;
            if (chkConsensualVictimlessPnr.Checked)
                crimePicker = crimePicker + " " + chkConsensualVictimlessPnr.Text;
            pdbc.Crime = crimePicker;

            pdbc.DateOfCrime = dtpDateOfCrimePnr.Text;
            pdbc.ImprisonmentDate = dtpImprisonmentDatePnr.Text;
            pdbc.ReleaseDate = dtpImprisonmentDatePnr.Text;
            pdbc.PrisonCell = cboPrisonCellPnr.Text;

            if (chkFamilyPnr.Checked)
                visitorsPicker = chkFamilyPnr.Text;
            if (chkFriendsPnr.Checked)
                visitorsPicker = visitorsPicker + " " + chkFriendsPnr.Text;
            if (chkBusinessPnr.Checked)
                visitorsPicker = visitorsPicker + " " + chkBusinessPnr.Text;
            if (chkOtherPnr.Checked)
                visitorsPicker = visitorsPicker + " " + chkOtherPnr.Text;
            pdbc.Visitors = visitorsPicker;

            if (txtOtherPnr.Text != "") extraInfoVisitors = txtOtherPnr.Text;
            pdbc.ExtraInfo = extraInfoVisitors;

            if (pdbc.FirstName.Equals(""))
                MessageBox.Show("Please enter the Prisoner's First Name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (pdbc.LastName.Equals(""))
                MessageBox.Show("Please enter the Prisoner's Last Name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (pdbc.DOB.Equals(""))
                MessageBox.Show("Please enter the Prisoner's Date Of Birth", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (!rbMalePnr.Checked == !rbFemalePnr.Checked)
                MessageBox.Show("Please enter the Prisoner's Gender", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (pdbc.Country.Equals(""))
                MessageBox.Show("Please enter the Prisoner's Country", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (pdbc.Height.Equals(""))
                MessageBox.Show("Please enter the Prisoner's Height", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (pdbc.Weight.Equals(""))
                MessageBox.Show("Please enter the Prisoner's Weight", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (pdbc.Colour.Equals(""))
                MessageBox.Show("Please enter the Prisoner's Colour", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (pdbc.Disease.Equals(""))
                MessageBox.Show("Please enter the Prisoner's Disease", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (!rbSinglePnr.Checked == !rbMarriedPnr.Checked == !rbDivorcedPnr.Checked)
                MessageBox.Show("Please enter the Prisoner's Marital Status", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (pdbc.Crime.Equals(""))
                MessageBox.Show("Please enter the Prisoner's Crime", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (pdbc.DateOfCrime.Equals(""))
                MessageBox.Show("Please enter the Prisoner's Date Of Crime", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (pdbc.ImprisonmentDate.Equals(""))
                MessageBox.Show("Please enter the Prisoner's Imprisonment Date", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (pdbc.ReleaseDate.Equals(""))
                MessageBox.Show("Please enter the Prisoner's Release Date", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (pdbc.PrisonCell.Equals(""))
                MessageBox.Show("Please enter the Prisoner's Prison Cell", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (pdbc.Visitors.Equals(""))
                MessageBox.Show("Please enter the Prisoner's Visitors", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                bool success = pdbc.UpdatePrisoner(pdbc);

                if (success == true)
                {
                    MessageBox.Show("Are you sure you want to update this row?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    MessageBox.Show("Congratulation, Record has been updated");

                    DataTable DT = pdbc.SelectPrisoners();
                    dgvPrisonerDB.DataSource = DT;

                    Clear();
                }
                else
                {
                    MessageBox.Show("Update failed");
                }
            }
        }

        // Delete data from database
        private void btnDeletePnr_Click(object sender, EventArgs e)
        {
            pdbc.PrisonerID = int.Parse(txtPrisonerIDPnr.Text);
            bool success = pdbc.DeletePrısoners(pdbc);

            if (success)
            {
                MessageBox.Show("Are you sure you want to Delete thıs row?", "Warnıng", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                MessageBox.Show("Record has been Deleted");

                DataTable DT = pdbc.SelectPrisoners();

                dgvPrisonerDB.DataSource = DT;

                Clear();
            }
            else
            {
                MessageBox.Show("Record has been Deleted");
            }
        }

        private void dgvPrisonerDB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            DataGridViewRow row = dgvPrisonerDB.Rows[rowIndex];

            txtPrisonerIDPnr.Text = row.Cells[0].Value.ToString();
            txtFirstNamePnr.Text = row.Cells[1].Value.ToString();
            txtLastNamePnr.Text = row.Cells[2].Value.ToString();
            dtpDOBPnr.Text = row.Cells[3].Value.ToString();

            if (row.Cells[4].Value.ToString() == rbMalePnr.Text) rbMalePnr.Checked = true;
            else rbFemalePnr.Checked = true;

            cboCountryPnr.Text = row.Cells[5].Value.ToString();
            txtHeightPnr.Text = row.Cells[6].Value.ToString();
            txtWeightPnr.Text = row.Cells[7].Value.ToString();
            cboColourPnr.Text = row.Cells[8].Value.ToString();

            if (row.Cells[9].Value.ToString().Contains(chkInfectiousPnr.Text)) chkInfectiousPnr.Checked = true;
            else chkInfectiousPnr.Checked = false;
            if (row.Cells[9].Value.ToString().Contains(chkDeficiencyPnr.Text)) chkDeficiencyPnr.Checked = true;
            else chkDeficiencyPnr.Checked = false;
            if (row.Cells[9].Value.ToString().Contains(chkHereditaryPnr.Text)) chkHereditaryPnr.Checked = true;
            else chkHereditaryPnr.Checked = false;
            if (row.Cells[9].Value.ToString().Contains(chkPhysiologicalPnr.Text)) chkPhysiologicalPnr.Checked = true;
            else chkPhysiologicalPnr.Checked = false;
            if (row.Cells[9].Value.ToString().Contains(chkNonePnr.Text)) chkNonePnr.Checked = true;
            else chkNonePnr.Checked = false;

            if (row.Cells[10].Value.ToString() == rbSinglePnr.Text) rbSinglePnr.Checked = true;
            else if (row.Cells[10].Value.ToString() == rbDivorcedPnr.Text) rbDivorcedPnr.Checked = true;
            else rbMarriedPnr.Checked = true;

            if (row.Cells[11].Value.ToString().Contains(chkViolentPnr.Text)) chkViolentPnr.Checked = true;
            else chkViolentPnr.Checked = false;
            if (row.Cells[11].Value.ToString().Contains(chkPropertyPnr.Text)) chkPropertyPnr.Checked = true;
            else chkPropertyPnr.Checked = false;
            if (row.Cells[11].Value.ToString().Contains(chkWhiteCollarPnr.Text)) chkWhiteCollarPnr.Checked = true;
            else chkWhiteCollarPnr.Checked = false;
            if (row.Cells[11].Value.ToString().Contains(chkConsensualVictimlessPnr.Text)) chkConsensualVictimlessPnr.Checked = true;
            else chkConsensualVictimlessPnr.Checked = false;

            dtpDateOfCrimePnr.Text = row.Cells[12].Value.ToString();
            dtpImprisonmentDatePnr.Text = row.Cells[13].Value.ToString();
            dtpReleaseDatePnr.Text = row.Cells[14].Value.ToString();
            cboPrisonCellPnr.Text = row.Cells[15].Value.ToString();

            if (row.Cells[16].Value.ToString().Contains(chkFamilyPnr.Text)) chkFamilyPnr.Checked = true;
            else chkFamilyPnr.Checked = false;
            if (row.Cells[16].Value.ToString().Contains(chkFriendsPnr.Text)) chkFriendsPnr.Checked = true;
            else chkFriendsPnr.Checked = false;
            if (row.Cells[16].Value.ToString().Contains(chkBusinessPnr.Text)) chkBusinessPnr.Checked = true;
            else chkBusinessPnr.Checked = false;
            if (row.Cells[16].Value.ToString().Contains(chkOtherPnr.Text)) chkOtherPnr.Checked = true;
            else chkOtherPnr.Checked = false;

            txtOtherPnr.Text = row.Cells[17].Value.ToString();
        }
    }
}
