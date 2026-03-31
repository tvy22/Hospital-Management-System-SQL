using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheArtOfDevHtmlRenderer.Adapters;




namespace Hospital_Management_System.Forms
{
    public partial class UC_Patients : UserControl
    {
        private DataTable table;

        public UC_Patients()
        {
            InitializeComponent();

            SetupGrid();       // 🔥 FIX GRID
            InitializeTable(); // 🔥 CREATE TABLE
            ConnectEvents();   // 🔥 EVENTS
        }

        // =========================
        // FIX GRID (IMPORTANT)
        // =========================
        private void SetupGrid()
        {
            dgvPatients.DataSource = null;
            dgvPatients.Columns.Clear(); // remove designer columns

            dgvPatients.AutoGenerateColumns = true;
            dgvPatients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPatients.MultiSelect = false;
        }

        // =========================
        // CREATE TABLE (MATCH DOCTOR STYLE)
        // =========================
        private void InitializeTable()
        {
            table = new DataTable();

            table.Columns.Add("ID");
            table.Columns.Add("Name");
            table.Columns.Add("Phone");
            table.Columns.Add("DOB");
            table.Columns.Add("Gender");
            table.Columns.Add("MedicalHistory");

            dgvPatients.DataSource = table;
        }

        // =========================
        // CONNECT EVENTS
        // =========================
        private void ConnectEvents()
        {
            btnSave.Click += btnSave_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnDelete.Click += btnDelete_Click;
            btnClear.Click += btnClear_Click;
            dgvPatients.CellClick += dgvPatients_CellClick;
            txtSearch.TextChanged += txtSearch_TextChanged;
        }

        // =========================
        // SAVE
        // =========================
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text) ||
                string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please fill ID and Name!");
                return;
            }

            string gender = rbMale.Checked ? "Male" :
                            rbFemale.Checked ? "Female" : "";

            table.Rows.Add(
                txtID.Text,
                txtName.Text,
                txtPhone.Text,
                dtpDOB.Value.ToShortDateString(),
                gender,
                txtMedHistory.Text
            );

            dgvPatients.Refresh(); // 🔥 FORCE SHOW

            MessageBox.Show("Saved!");
            ClearFields();
        }

        // =========================
        // UPDATE
        // =========================
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvPatients.CurrentRow != null)
            {
                int i = dgvPatients.CurrentRow.Index;

                string gender = rbMale.Checked ? "Male" :
                                rbFemale.Checked ? "Female" : "";

                table.Rows[i]["ID"] = txtID.Text;
                table.Rows[i]["Name"] = txtName.Text;
                table.Rows[i]["Phone"] = txtPhone.Text;
                table.Rows[i]["DOB"] = dtpDOB.Value.ToShortDateString();
                table.Rows[i]["Gender"] = gender;
                table.Rows[i]["MedicalHistory"] = txtMedHistory.Text;

                dgvPatients.Refresh();

                MessageBox.Show("Updated!");
            }
            else
            {
                MessageBox.Show("Select a row first!");
            }
        }

        // =========================
        // DELETE
        // =========================
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvPatients.CurrentRow != null)
            {
                dgvPatients.Rows.RemoveAt(dgvPatients.CurrentRow.Index);
                MessageBox.Show("Deleted!");
            }
            else
            {
                MessageBox.Show("Select a row first!");
            }
        }

        // =========================
        // CLEAR
        // =========================
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            txtID.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
            txtMedHistory.Text = "";
            rbMale.Checked = false;
            rbFemale.Checked = false;
            dtpDOB.Value = DateTime.Now;
        }

        // =========================
        // CLICK ROW
        // =========================
        private void dgvPatients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvPatients.Rows[e.RowIndex];

                txtID.Text = row.Cells["ID"].Value?.ToString();
                txtName.Text = row.Cells["Name"].Value?.ToString();
                txtPhone.Text = row.Cells["Phone"].Value?.ToString();
                txtMedHistory.Text = row.Cells["MedicalHistory"].Value?.ToString();

                DateTime dob;
                if (DateTime.TryParse(row.Cells["DOB"].Value?.ToString(), out dob))
                    dtpDOB.Value = dob;

                string gender = row.Cells["Gender"].Value?.ToString();
                rbMale.Checked = gender == "Male";
                rbFemale.Checked = gender == "Female";
            }
        }

        // =========================
        // SEARCH
        // =========================
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string search = txtSearch.Text.Replace("'", "''");

            if (string.IsNullOrEmpty(search))
                table.DefaultView.RowFilter = "";
            else
                table.DefaultView.RowFilter =
                    $"Name LIKE '%{search}%' OR Phone LIKE '%{search}%'";
        }
    }
}