using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
<<<<<<< HEAD
using TheArtOfDevHtmlRenderer.Adapters;

=======
using Guna.UI2.WinForms; // ត្រូវប្រាកដថាមាន Library នេះ
>>>>>>> ae9204eff5f1cb4d2a2a45a51e898cb6f5993fc9



namespace Hospital_Management_System.Forms
{
    public partial class UC_Patients : UserControl
    {
        private DataTable table;

        public UC_Patients()
        {
            InitializeComponent();
<<<<<<< HEAD

            SetupGrid();       // 🔥 FIX GRID
            InitializeTable(); // 🔥 CREATE TABLE
            ConnectEvents();   // 🔥 EVENTS
=======
<<<<<<< HEAD

            // ១. រៀបចំតារាងនៅពេល Load
            SetupDataGrid();

            // ២. ចង Event ជាមួយ Button (ឈ្មោះត្រូវតាម Designer របស់អ្នក)
            btnSave.Click += BtnSave_Click;
            btnUpdate.Click += BtnUpdate_Click;
            btnDelete.Click += BtnDelete_Click;
            btnClear.Click += BtnClear_Click;

            // ៣. Event សម្រាប់ការស្វែងរក និងការចុចលើតារាង
            txtSearch.TextChanged += TxtSearch_TextChanged;
            dgvPatients.CellClick += DgvPatients_CellClick;
        }

        private void SetupDataGrid()
        {
            if (dgvPatients.Columns.Count > 0) return;

            // បង្កើត Column សម្រាប់ Guna2DataGridView
            dgvPatients.Columns.Add("PatientID", "Patient ID");
            dgvPatients.Columns.Add("FullName", "Full Name");
            dgvPatients.Columns.Add("Phone", "Phone");
            dgvPatients.Columns.Add("DOB", "Date of Birth");
            dgvPatients.Columns.Add("Gender", "Gender");
            dgvPatients.Columns.Add("MedHistory", "Medical History");

            dgvPatients.AllowUserToAddRows = false;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            // ប្រើ .Text សម្រាប់ Guna2TextBox
            if (string.IsNullOrEmpty(txtID.Text) || string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("សូមបំពេញព័ត៌មានចាំបាច់!");
                return;
            }

            string gender = rbMale.Checked ? "Male" : (rbFemale.Checked ? "Female" : "Other");

            dgvPatients.Rows.Add(
=======
            InitializeTable();
>>>>>>> ae9204eff5f1cb4d2a2a45a51e898cb6f5993fc9
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
>>>>>>> fbc22db7b9d27036daaa2a3b2e2d7ced7826333e
                txtID.Text,
                txtName.Text,
                txtPhone.Text,
                dtpDOB.Value.ToShortDateString(),
                gender,
<<<<<<< HEAD
                txtMedHistory.Text // ក្នុង Designer របស់អ្នកវាជា Guna2TextBox (Multiline)
            );

            ClearFields();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvPatients.CurrentRow != null)
            {
                var row = dgvPatients.CurrentRow;
                row.Cells[0].Value = txtID.Text;
                row.Cells[1].Value = txtName.Text;
                row.Cells[2].Value = txtPhone.Text;
                row.Cells[3].Value = dtpDOB.Value.ToShortDateString();
                row.Cells[4].Value = rbMale.Checked ? "Male" : "Female";
                row.Cells[5].Value = txtMedHistory.Text;

                MessageBox.Show("បានធ្វើបច្ចុប្បន្នភាព!");
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvPatients.CurrentRow != null)
            {
                dgvPatients.Rows.Remove(dgvPatients.CurrentRow);
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
=======
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
>>>>>>> fbc22db7b9d27036daaa2a3b2e2d7ced7826333e
        {
            ClearFields();
        }

        private void ClearFields()
        {
<<<<<<< HEAD
            txtID.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
            txtMedHistory.Text = "";
=======
            txtID.Clear();
            txtName.Clear();
            txtPhone.Clear();
            txtMedHistory.Clear();
<<<<<<< HEAD
            dtpDOB.Value = DateTime.Now;
            rbMale.Checked = false;
            rbFemale.Checked = false;
            txtSearch.Clear();
        }

        private void DgvPatients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvPatients.Rows[e.RowIndex];
                txtID.Text = row.Cells[0].Value?.ToString();
                txtName.Text = row.Cells[1].Value?.ToString();
                txtPhone.Text = row.Cells[2].Value?.ToString();

                if (DateTime.TryParse(row.Cells[3].Value?.ToString(), out DateTime dob))
                    dtpDOB.Value = dob;
                string gender = row.Cells[4].Value?.ToString();
                rbMale.Checked = (gender == "Male");
                rbFemale.Checked = (gender == "Female");

                txtMedHistory.Text = row.Cells[5].Value?.ToString();
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.ToLower();
            foreach (DataGridViewRow row in dgvPatients.Rows)
            {
                if (row.Cells[1].Value != null)
                {
                    row.Visible = row.Cells[1].Value.ToString().ToLower().Contains(keyword) ||
                                  row.Cells[0].Value.ToString().ToLower().Contains(keyword);
                }
            }
=======
>>>>>>> ae9204eff5f1cb4d2a2a45a51e898cb6f5993fc9
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

<<<<<<< HEAD
            if (string.IsNullOrEmpty(search))
                table.DefaultView.RowFilter = "";
            else
                table.DefaultView.RowFilter =
                    $"Name LIKE '%{search}%' OR Phone LIKE '%{search}%'";
=======
            DataView dv = table.DefaultView;
            dv.RowFilter = $"Name LIKE '%{search}%' OR Phone LIKE '%{search}%'";
            dgvPatients.DataSource = dv;
>>>>>>> fbc22db7b9d27036daaa2a3b2e2d7ced7826333e
>>>>>>> ae9204eff5f1cb4d2a2a45a51e898cb6f5993fc9
        }
    }
}