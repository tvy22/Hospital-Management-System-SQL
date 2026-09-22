using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Hospital_Management_System_SQL.Logic;
using Hospital_Management_System_SQL.Models;

namespace Hospital_Management_System_SQL.Forms
{
    public partial class UC_CheckInOut : UserControl
    {
        private readonly CheckInOutRepository _checkInOutRepo = new CheckInOutRepository();
        private readonly PatientRepository _patientRepo = new PatientRepository();
        private readonly DoctorRepository _doctorRepo = new DoctorRepository();

        private List<Checkin> checkinList = new List<Checkin>();
        private List<Patient> allPatients = new List<Patient>();
        private List<Doctor> allDoctors = new List<Doctor>();
        private DataTable checkinTable = new DataTable();

        public UC_CheckInOut()
        {
            InitializeComponent();
            this.Load += UC_CheckInOut_Load;
            ConfigureGridProperties();

            // Wire up event handlers cleanly (prevent duplicates)
            dgvPatient.CellClick -= dgvPatient_CellClick;
            dgvPatient.CellClick += dgvPatient_CellClick;

            dgvActiveVisits.SelectionChanged -= dgvActiveVisits_SelectionChanged;
            dgvActiveVisits.SelectionChanged += dgvActiveVisits_SelectionChanged;

            // Automatically clear selection whenever grid data finishes loading
            dgvActiveVisits.DataBindingComplete -= dgvActiveVisits_DataBindingComplete;
            dgvActiveVisits.DataBindingComplete += dgvActiveVisits_DataBindingComplete;

            cmbSpeciality.SelectionChangeCommitted -= cmbSpeciality_SelectionChangeCommitted;
            cmbSpeciality.SelectionChangeCommitted += cmbSpeciality_SelectionChangeCommitted;

            cmbDoctor.SelectionChangeCommitted -= cmbDoctor_SelectionChangeCommitted;
            cmbDoctor.SelectionChangeCommitted += cmbDoctor_SelectionChangeCommitted;

            btnRegister.Click -= btnRegister_Click;
            btnRegister.Click += btnRegister_Click;

            btnCompleteVisit.Click -= btnCompleteVisit_Click;
            btnCompleteVisit.Click += btnCompleteVisit_Click;

            LoadCheckins();
            LoadDataForCheckIn();
        }

        private void ConfigureGridProperties()
        {
            dgvActiveVisits.ReadOnly = true;
            dgvActiveVisits.AllowUserToAddRows = false;
            dgvActiveVisits.AllowUserToDeleteRows = false;
            dgvActiveVisits.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvActiveVisits.MultiSelect = false;

            dgvPatient.ReadOnly = true;
            dgvPatient.AllowUserToAddRows = false;
            dgvPatient.AllowUserToDeleteRows = false;
            dgvPatient.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPatient.MultiSelect = false;
        }

        // ================= CHECK-IN LOGIC =================

        private void LoadDataForCheckIn()
        {
            txtAppID.Text = _checkInOutRepo.GenerateNextID();

            allPatients = _patientRepo.GetAll();
            allDoctors = _doctorRepo.GetAll();

            var uniqueSpecialities = allDoctors
                .Select(d => d.Speciality)
                .Where(s => !string.IsNullOrEmpty(s))
                .Distinct()
                .ToList();

            uniqueSpecialities.Insert(0, "Select speciality");
            cmbSpeciality.DataSource = uniqueSpecialities;

            ShowPatientsInCheckIn();
            ShowDoctorsInCheckIn();
        }

        private void ShowPatientsInCheckIn()
        {
            dgvPatient.DataSource = null;
            dgvPatient.DataSource = allPatients;

            if (dgvPatient.Columns.Count > 0)
            {
                dgvPatient.Columns["PatientID"].HeaderText = "ID";
                dgvPatient.Columns["FullName"].HeaderText = "Name";
                dgvPatient.Columns["DateOfBirth"].HeaderText = "Birthdate";

                if (dgvPatient.Columns.Contains("MedicalHistory"))
                    dgvPatient.Columns["MedicalHistory"].Visible = false;
            }
        }

        private void ShowDoctorsInCheckIn()
        {
            string sp = cmbSpeciality.SelectedItem?.ToString();

            if (sp == "Select speciality" || string.IsNullOrEmpty(sp))
            {
                var list = allDoctors.ToList();
                list.Insert(0, new Doctor { DoctorID = "0", FullName = "Select Doctor" });
                cmbDoctor.DataSource = list;
            }
            else
            {
                var filteredDoctors = allDoctors.Where(d => d.Speciality == sp).ToList();
                filteredDoctors.Insert(0, new Doctor { DoctorID = "0", FullName = "Select Doctor" });
                cmbDoctor.DataSource = filteredDoctors;
            }
            cmbDoctor.SelectedIndex = 0;
        }

        private void cmbSpeciality_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ShowDoctorsInCheckIn();
        }

        private void cmbDoctor_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Doctor selectedDoc = cmbDoctor.SelectedItem as Doctor;
            if (selectedDoc != null && selectedDoc.DoctorID != "0")
            {
                cmbSpeciality.SelectedItem = selectedDoc.Speciality;
                txtRoom.Text = selectedDoc.RoomNumber;
            }
        }

        private void dgvPatient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPatient.Rows[e.RowIndex];
                txtPatientID.Text = row.Cells["PatientID"].Value?.ToString();
                txtPatientName.Text = row.Cells["FullName"].Value?.ToString();
            }
        }

        private bool IsValidCheckIn()
        {
            errorProvider1.Clear();
            bool isAllValid = true;

            if (string.IsNullOrWhiteSpace(txtAppID.Text))
            {
                errorProvider1.SetError(txtAppID, "ID is required.");
                isAllValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtPatientID.Text) || string.IsNullOrWhiteSpace(txtPatientName.Text))
            {
                errorProvider1.SetError(txtPatientID, "Select a patient from the table.");
                isAllValid = false;
            }

            if (cmbDoctor.SelectedIndex <= 0 || cmbSpeciality.SelectedIndex <= 0)
            {
                errorProvider1.SetError(cmbDoctor, "Select a doctor.");
                isAllValid = false;
            }

            return isAllValid;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Doctor selectedDoc = cmbDoctor.SelectedItem as Doctor;
            decimal doctorFee = selectedDoc?.ConsultationFee ?? 0.00m;

            if (!IsValidCheckIn()) return;

            Checkin newApp = new Checkin
            {
                AppID = txtAppID.Text,
                PatientID = txtPatientID.Text,
                PatientName = txtPatientName.Text,
                DocName = cmbDoctor.SelectedItem.ToString(),
                DocSpeciality = cmbSpeciality.SelectedItem.ToString(),
                Date = dtpAppTime.Value,
                RoomNumber = txtRoom.Text,
                Reason = Reason.Text,
                Fee = doctorFee
            };

            _checkInOutRepo.Save(newApp);

            MessageBox.Show("Appointment Saved Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ClearCheckInFields();
            LoadCheckins();
            txtAppID.Text = _checkInOutRepo.GenerateNextID();
        }

        private void ClearCheckInFields()
        {
            txtPatientID.Clear();
            txtPatientName.Clear();
            txtRoom.Clear();
            txtReason.Clear();

            if (cmbSpeciality.Items.Count > 0)
                cmbSpeciality.SelectedIndex = 0;

            if (cmbDoctor.Items.Count > 0)
                cmbDoctor.SelectedIndex = 0;

            dtpAppTime.Value = DateTime.Now;

            dgvPatient.ClearSelection();
            errorProvider1.Clear();
        }

        // ================= CHECK-OUT LOGIC =================

        private void LoadCheckins()
        {
            if (checkinTable.Columns.Count == 0)
            {
                checkinTable.Columns.Add("ID");
                checkinTable.Columns.Add("Patient");
                checkinTable.Columns.Add("Doctor");
                checkinTable.Columns.Add("Room");
                checkinTable.Columns.Add("Reason");
                checkinTable.Columns.Add("Fee", typeof(decimal));
            }

            checkinTable.Rows.Clear();

            checkinList = _checkInOutRepo.GetActiveVisits();

            foreach (Checkin c in checkinList)
            {
                checkinTable.Rows.Add(
                    c.AppID,
                    c.PatientName,
                    c.DocName,
                    c.RoomNumber,
                    c.Reason,
                    c.Fee
                );
            }

            // Setting DataSource automatically causes DataBindingComplete to trigger
            dgvActiveVisits.DataSource = checkinTable;
        }

        // Fires after DataGridView finishes binding to DataSource
        private void dgvActiveVisits_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvActiveVisits.ClearSelection();
            ClearFields();
        }

        private void dgvActiveVisits_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvActiveVisits.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvActiveVisits.SelectedRows[0];

                txtAppID_CO.Text = row.Cells["ID"].Value?.ToString() ?? string.Empty;
                txtPatient_CO.Text = row.Cells["Patient"].Value?.ToString() ?? string.Empty;
                txtDoctor_CO.Text = row.Cells["Doctor"].Value?.ToString() ?? string.Empty;
                txtRoom_CO.Text = row.Cells["Room"].Value?.ToString() ?? string.Empty;
                txtReason.Text = row.Cells["Reason"].Value?.ToString() ?? string.Empty;

                var feeObj = row.Cells["Fee"].Value;
                if (feeObj != null && feeObj != DBNull.Value && decimal.TryParse(feeObj.ToString(), out decimal fee))
                {
                    lblFinalCost.Text = fee.ToString("C2");
                }
                else
                {
                    lblFinalCost.Text = "$0.00";
                }
            }
            else
            {
                // Clear textboxes if no row is selected
                ClearFields();
            }
        }

        private void btnCompleteVisit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAppID_CO.Text))
            {
                MessageBox.Show("Please select a visit from the list first.", "No Selection");
                return;
            }

            DialogResult confirm = MessageBox.Show("Process payment and complete this visit?", "Confirm", MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    decimal cost = decimal.TryParse(lblFinalCost.Text.Replace("$", "").Trim(), out decimal parsed) ? parsed : 0.00m;

                    _checkInOutRepo.CompleteCheckOut(txtAppID_CO.Text, cost);

                    MessageBox.Show("Payment Processed Successfully!", "Success");

                    LoadCheckins();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void ClearFields()
        {
            txtAppID_CO.Clear();
            txtPatient_CO.Clear();
            txtDoctor_CO.Clear();
            txtRoom_CO.Clear();
            txtReason.Clear();
            lblFinalCost.Text = "$ 0.00";
        }

        private void btnRefresh_Click(object sender, EventArgs e) => LoadCheckins();

        private void txtSearchActive_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearchActive.Text.Replace("'", "''");

            DataView dv = checkinTable.DefaultView;
            dv.RowFilter = string.Format("ID LIKE '%{0}%' OR Patient LIKE '%{0}%'", searchText);

            dgvActiveVisits.DataSource = dv;
        }

        // Empty events to avoid Designer errors
        private void txtAppID_CO_TextChanged(object sender, EventArgs e) { }
        private void txtPatient_CO_TextChanged(object sender, EventArgs e) { }
        private void txtDoctor_CO_TextChanged(object sender, EventArgs e) { }
        private void txtRoom_CO_TextChanged(object sender, EventArgs e) { }
        private void txtReason_TextChanged(object sender, EventArgs e) { }
        private void lblFinalCost_Click(object sender, EventArgs e) { }

        private void UC_CheckInOut_Load(object sender, EventArgs e)
        {
            dgvActiveVisits.ClearSelection();
            ClearFields();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            using(VisitHistoryForm historyForm = new VisitHistoryForm())
            {
                historyForm.ShowDialog(this);
            }
        }
    }
}