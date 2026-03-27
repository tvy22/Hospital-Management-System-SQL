using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Hospital_Management_System.Forms
{
    public partial class UC_Patients : UserControl
    {
        DataTable table = new DataTable();

        public UC_Patients()
        {
            InitializeComponent();
            InitializeTable();
        }

        // =========================
        // CREATE TABLE STRUCTURE
        // =========================
        private void InitializeTable()
        {
            table.Columns.Add("ID");
            table.Columns.Add("Name");
            table.Columns.Add("Phone");
            table.Columns.Add("DOB");
            table.Columns.Add("Gender");
            table.Columns.Add("MedicalHistory");

            dgvPatients.DataSource = table;
        }

        // =========================
        // SAVE BUTTON
        // =========================
        private void btnSave_Click(object sender, EventArgs e)
        {
            string gender = rbMale.Checked ? "Male" : "Female";

            table.Rows.Add(
                txtID.Text,
                txtName.Text,
                txtPhone.Text,
                dtpDOB.Value.ToShortDateString(),
                gender,
                txtMedHistory.Text
            );

            MessageBox.Show("Patient Saved!");
            ClearFields();
        }

        // =========================
        // UPDATE BUTTON
        // =========================
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvPatients.SelectedRows.Count > 0)
            {
                int row = dgvPatients.SelectedRows[0].Index;

                string gender = rbMale.Checked ? "Male" : "Female";

                table.Rows[row]["ID"] = txtID.Text;
                table.Rows[row]["Name"] = txtName.Text;
                table.Rows[row]["Phone"] = txtPhone.Text;
                table.Rows[row]["DOB"] = dtpDOB.Value.ToShortDateString();
                table.Rows[row]["Gender"] = gender;
                table.Rows[row]["MedicalHistory"] = txtMedHistory.Text;

                MessageBox.Show("Patient Updated!");
            }
        }

        // =========================
        // DELETE BUTTON
        // =========================
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvPatients.SelectedRows.Count > 0)
            {
                dgvPatients.Rows.RemoveAt(dgvPatients.SelectedRows[0].Index);
                MessageBox.Show("Patient Deleted!");
            }
        }

        // =========================
        // CLEAR BUTTON
        // =========================
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            txtID.Clear();
            txtName.Clear();
            txtPhone.Clear();
            txtMedHistory.Clear();
            rbMale.Checked = false;
            rbFemale.Checked = false;
            dtpDOB.Value = DateTime.Now;
        }

        // =========================
        // CLICK ROW -> SHOW DATA
        // =========================
        private void dgvPatients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPatients.Rows[e.RowIndex];

                txtID.Text = row.Cells["ID"].Value.ToString();
                txtName.Text = row.Cells["Name"].Value.ToString();
                txtPhone.Text = row.Cells["Phone"].Value.ToString();
                dtpDOB.Value = Convert.ToDateTime(row.Cells["DOB"].Value);
                txtMedHistory.Text = row.Cells["MedicalHistory"].Value.ToString();

                string gender = row.Cells["Gender"].Value.ToString();
                rbMale.Checked = (gender == "Male");
                rbFemale.Checked = (gender == "Female");
            }
        }

        // =========================
        // SEARCH
        // =========================
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string search = txtSearch.Text.ToLower();

            DataView dv = table.DefaultView;
            dv.RowFilter = $"Name LIKE '%{search}%' OR Phone LIKE '%{search}%'";
            dgvPatients.DataSource = dv;
        }
    }
}