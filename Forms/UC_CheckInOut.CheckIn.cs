using Hospital_Management_System.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms; // Added for DataGridView access

namespace Hospital_Management_System.Forms
{
    public partial class UC_CheckInOut
    {
        List<Patient> allPatients = new List<Patient>();
        List<Doctor> allDoctors = new List<Doctor>();
        List<Checkin> allCheckins = new List<Checkin>();
        string fileCheckin = "checkin.dat";
        BinaryFormatter bf = new BinaryFormatter();

        private void LoadDataForCheckIn()
        {
            GenerateAppID();

            // Load Patients
            if (File.Exists("patients.dat"))
            {
                using (FileStream fs = new FileStream("patients.dat", FileMode.Open))
                {
                    allPatients.Clear(); 
                    while (fs.Position != fs.Length)
                    {
                        Patient p = (Patient)bf.Deserialize(fs);
                        allPatients.Add(p);
                    }
                }
            }

            // Load Doctors 
            if (File.Exists("doctors.dat"))
            {
                using (FileStream fs = new FileStream("doctors.dat", FileMode.Open))
                {
                    allDoctors.Clear();
                    while(fs.Position != fs.Length)
                    {
                        Doctor d = (Doctor)bf.Deserialize(fs);
                        allDoctors.Add(d);
                    }
                }
            }

            var uniqueSpecialities = allDoctors.Select(d => d.Speciality).Distinct().ToList();
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

        private void cmbSpeciality_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ShowDoctorsInCheckIn();
        }

        private void cmbDoctor_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Doctor selectedDoc = cmbDoctor.SelectedItem as Doctor;
            if(selectedDoc != null && selectedDoc.DoctorID != "0")
            {
                cmbSpeciality.SelectedItem = selectedDoc.Speciality;
                txtRoom.Text = selectedDoc.RoomNumber;
            }
        }

        private void ShowDoctorsInCheckIn()
        {
            string sp = cmbSpeciality.SelectedItem.ToString();

            if(sp == "Select speciality")
            {
                var list = allDoctors.ToList();
                list.Insert(0, new Doctor { DoctorID = "0", FullName = "Select Doctor" });
                cmbDoctor.DataSource = list;
            }
            else
            {
                var filteredDoctors = allDoctors.Where(d => d.Speciality == sp).ToList();
                filteredDoctors.Insert(0, new Doctor { DoctorID = "0", FullName = "Select Doctor"});
                cmbDoctor.DataSource = filteredDoctors;
            }
            cmbDoctor.SelectedIndex = 0;
        }

        private void dgvPatient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPatient.Rows[e.RowIndex];
                txtPatientID.Text = row.Cells["PatientID"].Value.ToString();
                txtPatientName.Text = row.Cells["FullName"].Value.ToString();
            }
        }

        private void GenerateAppID()
        {
            int maxId = 0;

            if (allCheckins.Count > 0)
            {
                foreach (var c in allCheckins)
                {
                    // Check if ID is not null, starts with APP-, and is long enough
                    if (!string.IsNullOrEmpty(c.AppID) && c.AppID.StartsWith("APP-") && c.AppID.Length > 4)
                    {
                        // Try to parse the number part safely
                        if (int.TryParse(c.AppID.Substring(4), out int idValue))
                        {
                            if (idValue > maxId) maxId = idValue;
                        }
                    }
                }
            }

            int nextId = maxId + 1;
            txtAppID.Text = "APP-" + nextId.ToString("000");
        }

        private bool IsValid()
        {
            errorProvider1.Clear();
            bool isAllValid = true;

            //Check if id is empty
            if (string.IsNullOrWhiteSpace(txtAppID.Text))
            {
                errorProvider1.SetError(txtAppID, "ID is required.");
                isAllValid = false;
            }

            //Check patient id and name
            if (string.IsNullOrWhiteSpace(txtPatientID.Text) || string.IsNullOrWhiteSpace(txtPatientName.Text))
            {
                errorProvider1.SetError(txtPatientID, "Select a patient from the table.");
                isAllValid = false;
            }

            //Check doctor name and speciality
            if (cmbDoctor.SelectedIndex <= 0 || cmbSpeciality.SelectedIndex <= 0)
            {
                errorProvider1.SetError(cmbDoctor, "Select a doctor.");
                isAllValid = false;
            }

            return isAllValid;
        }

        private void SaveAllToFile()
        {
            using(FileStream fs = new FileStream(fileCheckin, FileMode.Create))
            {
                foreach(Checkin c in allCheckins)
                {
                    bf.Serialize(fs, c);
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (!IsValid()) return;

            //Create new appointment object
            Checkin newApp = new Checkin();
            newApp.AppID = txtAppID.Text;
            newApp.PatientID = txtPatientID.Text;
            newApp.PatientName = txtPatientName.Text;
            newApp.DocName = cmbDoctor.SelectedItem.ToString();
            newApp.DocSpeciality = cmbSpeciality.SelectedItem.ToString();
            newApp.Date = dtpAppTime.Value;
            newApp.RoomNumber = txtRoom.Text;
            newApp.Reason = txtReason.Text;

            allCheckins.Add(newApp);
            SaveAllToFile();
            MessageBox.Show("Appointment Saved Successfully!");
        }
    }
}