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
    public partial class UC_Doctors : UserControl
    {

        public UC_Doctors()
        {
            InitializeComponent();

            SetupDataGrid();

            btnSave.Click += BtnSave_Click;
            btnUpdate.Click += BtnUpdate_Click;
            btnDelete.Click += BtnDelete_Click;
            btnUpload.Click += BtnUpload_Click;
            dgvDoctors.CellClick += DgvDoctors_CellClick;
        }
        private void SetupDataGrid()
        {
            if (dgvDoctors.Columns.Count > 0) return; // prevent duplicate

            dgvDoctors.ColumnCount = 11;

            dgvDoctors.Columns[0].Name = "ID";
            dgvDoctors.Columns[1].Name = "Name";
            dgvDoctors.Columns[2].Name = "Phone";
            dgvDoctors.Columns[3].Name = "Email";
            dgvDoctors.Columns[4].Name = "Speciality";
            dgvDoctors.Columns[5].Name = "Fee";
            dgvDoctors.Columns[6].Name = "Room";
            dgvDoctors.Columns[7].Name = "DOB";
            dgvDoctors.Columns[8].Name = "Gender";
            dgvDoctors.Columns[9].Name = "Status";
            dgvDoctors.Columns[10].Name = "Shift";

            dgvDoctors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            string gender = rbMale.Checked ? "Male" : "Female";

            dgvDoctors.Rows.Add(
                txtID.Text,
                txtName.Text,
                txtPhone.Text,
                txtEmail.Text,
                cmbSpeciality.Text,
                txtFee.Text,
                txtRoom.Text,
                dtpDOB.Value.ToShortDateString(),
                gender,
                cmbStatus.Text,
                shift.Text
            );
        }
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvDoctors.CurrentRow != null)
            {
                var row = dgvDoctors.CurrentRow;

                row.Cells[0].Value = txtID.Text;
                row.Cells[1].Value = txtName.Text;
                row.Cells[2].Value = txtPhone.Text;
                row.Cells[3].Value = txtEmail.Text;
                row.Cells[4].Value = cmbSpeciality.Text;
                row.Cells[5].Value = txtFee.Text;
                row.Cells[6].Value = txtRoom.Text;
                row.Cells[7].Value = dtpDOB.Value.ToShortDateString();
                row.Cells[8].Value = rbMale.Checked ? "Male" : "Female";
                row.Cells[9].Value = cmbStatus.Text;
                row.Cells[10].Value = shift.Text;
            }
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvDoctors.CurrentRow != null)
            {
                dgvDoctors.Rows.Remove(dgvDoctors.CurrentRow);
            }
        }
        private void BtnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Image Files|*.jpg;*.png;*.jpeg";

            if (op.ShowDialog() == DialogResult.OK)
            {
                picDoctor.Image = Image.FromFile(op.FileName);
            }
        }
        private void DgvDoctors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvDoctors.Rows[e.RowIndex];

                txtID.Text = row.Cells[0].Value?.ToString();
                txtName.Text = row.Cells[1].Value?.ToString();
                txtPhone.Text = row.Cells[2].Value?.ToString();
                txtEmail.Text = row.Cells[3].Value?.ToString();
                cmbSpeciality.Text = row.Cells[4].Value?.ToString();
                txtFee.Text = row.Cells[5].Value?.ToString();
                txtRoom.Text = row.Cells[6].Value?.ToString();

                DateTime.TryParse(row.Cells[7].Value?.ToString(), out DateTime dob);
                dtpDOB.Value = dob;

                string gender = row.Cells[8].Value?.ToString();
                rbMale.Checked = gender == "Male";
                rbFemale.Checked = gender == "Female";

                cmbStatus.Text = row.Cells[9].Value?.ToString();
                shift.Text = row.Cells[10].Value?.ToString();
            }
        }
    }
}
