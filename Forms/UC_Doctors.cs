using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Hospital_Management_System_SQL.Interfaces;
using Hospital_Management_System_SQL.Logic;
using Hospital_Management_System_SQL.Models;

namespace Hospital_Management_System_SQL.Forms
{
    public partial class UC_Doctors : UserControl
    {
        private readonly IDoctorRepository _doctorRepo = new DoctorRepository();
        private List<Doctor> doctors = new List<Doctor>();

        public UC_Doctors()
        {
            InitializeComponent();
            txtID.Enabled = false;
            LoadDoctors(); // Load from SQL database via repository
            ShowDoctors(); // Bind to DataGridView
            GenerateNextID(); // Generate next Doctor ID from database
        }

        private void ClearForm()
        {
            errorProvider1.Clear();
            txtName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtRoom.Clear();
            txtFee.Clear();
            cmbSpeciality.SelectedIndex = 0;
            cmbStatus.SelectedIndex = 0;
            cmbShift.SelectedIndex = 0;
            picDoctor.Image = null;
            rbMale.Checked = true;
            dtpDOB.Value = DateTime.Now;
        }

        private void LoadDoctors()
        {
            // Retrieve doctor records directly from SQL database
            doctors = _doctorRepo.GetAll();
        }

        private void ShowDoctors()
        {
            dgvDoctors.DataSource = null;
            dgvDoctors.DataSource = doctors;
            FormatGrid();
        }

        private void FormatGrid()
        {
            if (dgvDoctors.Columns.Count > 0)
            {
                dgvDoctors.Columns["DoctorID"].HeaderText = "ID";
                dgvDoctors.Columns["FullName"].HeaderText = "Name";
                dgvDoctors.Columns["RoomNumber"].HeaderText = "Room";
                dgvDoctors.Columns["ConsultationFee"].HeaderText = "Fee($)";
                dgvDoctors.Columns["DateOfBirth"].HeaderText = "Birthdate";

                if (dgvDoctors.Columns.Contains("DoctorImage"))
                {
                    DataGridViewImageColumn imgCol = (DataGridViewImageColumn)dgvDoctors.Columns["DoctorImage"];
                    imgCol.HeaderText = "Photo";
                    imgCol.Visible = true;
                    imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;

                    dgvDoctors.RowTemplate.Height = 60;
                    foreach (DataGridViewRow row in dgvDoctors.Rows)
                    {
                        row.Height = 60;
                    }
                }
            }
        }

        private void GenerateNextID()
        {
            txtID.Text = _doctorRepo.GenerateNextID();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Images | *.jpg; *.jpeg; *.png";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                using (var tempImage = Image.FromFile(ofd.FileName))
                {
                    picDoctor.Image = new Bitmap(tempImage);
                }
            }
        }

        private bool IsValid()
        {
            errorProvider1.Clear();
            bool isAllValid = true;

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                errorProvider1.SetError(txtName, "Doctor name is required.");
                isAllValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                errorProvider1.SetError(txtEmail, "Valid email address is required.");
                isAllValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                errorProvider1.SetError(txtPhone, "Phone is required.");
                isAllValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtRoom.Text))
            {
                errorProvider1.SetError(txtRoom, "Room is required.");
                isAllValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtFee.Text))
            {
                errorProvider1.SetError(txtFee, "Fee is required.");
                isAllValid = false;
            }

            if (cmbSpeciality.SelectedIndex <= 0)
            {
                errorProvider1.SetError(cmbSpeciality, "Speciality is required.");
                isAllValid = false;
            }

            if (cmbStatus.SelectedIndex <= 0)
            {
                errorProvider1.SetError(cmbStatus, "Status is required.");
                isAllValid = false;
            }

            if (cmbShift.SelectedIndex <= 0)
            {
                errorProvider1.SetError(cmbShift, "Shift is required.");
                isAllValid = false;
            }

            return isAllValid;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!IsValid()) return;

            bool alreadyExists = doctors.Any(d => d.DoctorID == txtID.Text);

            if (alreadyExists)
            {
                MessageBox.Show("This doctor ID already exists. " +
                                "If you want to change their details, please use the Update button instead.",
                                "Duplicate ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Doctor newDoc = new Doctor
            {
                DoctorID = txtID.Text,
                FullName = txtName.Text,
                Email = txtEmail.Text,
                Phone = txtPhone.Text,
                Speciality = cmbSpeciality.Text,
                RoomNumber = txtRoom.Text,
                ConsultationFee = decimal.TryParse(txtFee.Text, out decimal fee) ? fee : 0,
                DateOfBirth = dtpDOB.Value,
                Gender = rbFemale.Checked ? "Female" : "Male",
                Status = cmbStatus.Text,
                Shift = cmbShift.Text,
                DoctorImage = _doctorRepo.ImageToByteArray(picDoctor.Image)
            };

            // Save to SQL database via repository
            _doctorRepo.Save(newDoc);

            LoadDoctors();
            ShowDoctors();
            ClearForm();
            GenerateNextID();

            MessageBox.Show("Doctor saved successfully to database!");
        }

        private void dgvDoctors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvDoctors.Rows[e.RowIndex].Cells["DoctorID"].Value != null)
            {
                string id = dgvDoctors.Rows[e.RowIndex].Cells["DoctorID"].Value.ToString();
                Doctor selectedDoc = doctors.FirstOrDefault(d => d.DoctorID == id);

                if (selectedDoc != null)
                {
                    txtID.Text = selectedDoc.DoctorID;
                    txtName.Text = selectedDoc.FullName;
                    txtEmail.Text = selectedDoc.Email;
                    txtPhone.Text = selectedDoc.Phone;
                    cmbSpeciality.Text = selectedDoc.Speciality;
                    txtRoom.Text = selectedDoc.RoomNumber;
                    txtFee.Text = selectedDoc.ConsultationFee.ToString();
                    dtpDOB.Value = selectedDoc.DateOfBirth;

                    if (selectedDoc.Gender == "Female") rbFemale.Checked = true;
                    else rbMale.Checked = true;

                    cmbStatus.Text = selectedDoc.Status;
                    cmbShift.Text = selectedDoc.Shift;

                    if (selectedDoc.DoctorImage != null)
                    {
                        using (MemoryStream ms = new MemoryStream(selectedDoc.DoctorImage))
                        {
                            picDoctor.Image = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        picDoctor.Image = null;
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Doctor docToUpdate = doctors.FirstOrDefault(d => d.DoctorID == txtID.Text);

            if (docToUpdate != null)
            {
                if (!IsValid()) return;

                docToUpdate.FullName = txtName.Text;
                docToUpdate.Email = txtEmail.Text;
                docToUpdate.Phone = txtPhone.Text;
                docToUpdate.Speciality = cmbSpeciality.Text;
                docToUpdate.RoomNumber = txtRoom.Text;

                decimal fee;
                decimal.TryParse(txtFee.Text, out fee);
                docToUpdate.ConsultationFee = fee;

                docToUpdate.DateOfBirth = dtpDOB.Value;
                docToUpdate.Gender = rbFemale.Checked ? "Female" : "Male";
                docToUpdate.Status = cmbStatus.Text;
                docToUpdate.Shift = cmbShift.Text;
                docToUpdate.DoctorImage = _doctorRepo.ImageToByteArray(picDoctor.Image);

                // Update in database
                _doctorRepo.Save(docToUpdate);

                LoadDoctors();
                ShowDoctors();
                ClearForm();
                GenerateNextID();
                MessageBox.Show("Doctor updated successfully!");
            }
            else
            {
                MessageBox.Show("Please select a doctor from the list first.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Doctor docToDelete = doctors.FirstOrDefault(d => d.DoctorID == txtID.Text);

            if (docToDelete != null)
            {
                DialogResult dialog = MessageBox.Show("Are you sure you want to delete this doctor?",
                    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialog == DialogResult.Yes)
                {
                    // Delete from database via repository
                    _doctorRepo.Delete(docToDelete.DoctorID);

                    LoadDoctors();
                    ShowDoctors();
                    ClearForm();
                    GenerateNextID();

                    MessageBox.Show("Doctor deleted successfully!");
                }
            }
            else
            {
                MessageBox.Show("Please select a doctor from the list to delete.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
            GenerateNextID();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(keyword))
            {
                ShowDoctors();
            }
            else
            {
                var results = doctors.Where(d =>
                    (d.FullName != null && d.FullName.ToLower().Contains(keyword)) ||
                    (d.DoctorID != null && d.DoctorID.ToLower().Contains(keyword))
                ).ToList();

                dgvDoctors.DataSource = null;
                dgvDoctors.DataSource = results;
                FormatGrid();
            }
        }
    }
}