using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Hospital_Management_System.Models;

namespace Hospital_Management_System.Forms
{
    public partial class UC_Patients : UserControl
    {
        string fileName = "patients.dat";
        List<Patient> patients = new List<Patient>();
        BinaryFormatter bf = new BinaryFormatter();

        public UC_Patients()
        {
            InitializeComponent();
            txtID.Enabled = false;
            LoadPatients();
            ShowPatients();
            GenerateNextID();
        }

        //Function to clear form
        private void ClearForm()
        {
            errorProvider1.Clear();
            txtName.Clear();
            txtPhone.Clear();
            txtMedHistory.Clear();
            rbMale.Checked = true;
            dtpDOB.Value = DateTime.Now;
            GenerateNextID();
        }

        //Function to save date to file
        private void SaveAllToFile()
        {
            using (FileStream fs = new FileStream(fileName, FileMode.Create))
            {
                foreach (Patient p in patients)
                {
                    bf.Serialize(fs, p);
                }
            }
        }

        //Function to load all patients
        private void LoadPatients()
        {
            if (File.Exists(fileName))
            {
                FileStream fs = new FileStream(fileName, FileMode.Open);
                while (fs.Position != fs.Length)
                {
                    Patient p = (Patient)bf.Deserialize(fs);
                    patients.Add(p);
                }
                fs.Close();
            }
        }

        //Function to show patients in data grid view
        private void ShowPatients()
        {
            dgvPatients.DataSource = null;
            dgvPatients.DataSource = patients;
            FormatGrid();
        }

        //Function to rename the data grid header
        private void FormatGrid()
        {
            if (dgvPatients.Columns.Count > 0)
            {
                dgvPatients.Columns["PatientID"].HeaderText = "ID";
                dgvPatients.Columns["FullName"].HeaderText = "Name";
                dgvPatients.Columns["MedicalHistory"].HeaderText = "Medical History";
                dgvPatients.Columns["DateOfBirth"].HeaderText = "Birthdate";
            }
        }

        //Function to auto-generate patient id
        private void GenerateNextID()
        {
            int maxId = 0;

            if (patients.Count > 0)
            {
                foreach (var p in patients)
                {
                    if (!string.IsNullOrEmpty(p.PatientID) && p.PatientID.StartsWith("PAT-") && p.PatientID.Length > 4)
                    {
                        if (int.TryParse(p.PatientID.Substring(4), out int idValue))
                        {
                            if (idValue > maxId) maxId = idValue;
                        }
                    }
                }
            }

            int nextId = maxId + 1;
            txtID.Text = "PAT-" + nextId.ToString("000");
        }

        //Function to validate the data fields in form
        private bool IsValid()
        {
            errorProvider1.Clear();
            bool isAllValid = true;

            //Check if name is empty
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                errorProvider1.SetError(txtName, "Patient name is required.");
                isAllValid = false;
            }

            //Check phone
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                errorProvider1.SetError(txtPhone, "Phone is required.");
                isAllValid = false;
            }

            return isAllValid;
        }

        //Function to save new patient object
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!IsValid()) return;

            //Check if the id already exists before saving
            bool alreadyExists = patients.Any(p => p.PatientID == txtID.Text);

            if (alreadyExists)
            {
                MessageBox.Show("This patient ID already exists." +
                                "If you want to change their details,please use the Update button instead.",
                                "Duplicate ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Create a new patient object
            Patient newPat = new Patient();
            newPat.PatientID = txtID.Text;
            newPat.FullName = txtName.Text;
            newPat.Phone = txtPhone.Text;
            newPat.DateOfBirth = dtpDOB.Value;
            newPat.MedicalHistory = txtMedHistory.Text;

            if (rbFemale.Checked) newPat.Gender = "Female";
            else if (rbMale.Checked) newPat.Gender = "Male";

            patients.Add(newPat);
            SaveAllToFile();
            ShowPatients();
            ClearForm();
            MessageBox.Show("Patient saved successfully!");
            GenerateNextID();
        }

        private void dgvPatients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Check if a valid row was clicked
            if (e.RowIndex >= 0 && dgvPatients.Rows[e.RowIndex].Cells["PatientID"].Value != null)
            {
                //Get the selected patient from the list
                string id = dgvPatients.Rows[e.RowIndex].Cells["PatientID"].Value.ToString();
                Patient selectedPat = patients.FirstOrDefault(p => p.PatientID == id);

                //Fill the form with their data
                txtID.Text = selectedPat.PatientID;
                txtName.Text = selectedPat.FullName;
                txtPhone.Text = selectedPat.Phone;
                txtMedHistory.Text = selectedPat.MedicalHistory;
                dtpDOB.Value = selectedPat.DateOfBirth;

                if (selectedPat.Gender == "Female") rbFemale.Checked = true;
                else rbMale.Checked = true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Find the patient in the list that matches the ID in the textbox
            Patient patToUpdate = patients.FirstOrDefault(p => p.PatientID == txtID.Text);

            if (patToUpdate != null)
            {
                if (!IsValid())
                {
                    return;
                }
                //Update the properties with data currently in the textboxes
                patToUpdate.FullName = txtName.Text;
                patToUpdate.Phone = txtPhone.Text;
                patToUpdate.Gender = rbFemale.Checked ? "Female" : "Male";
                patToUpdate.DateOfBirth = dtpDOB.Value;
                patToUpdate.MedicalHistory = !string.IsNullOrWhiteSpace(txtMedHistory.Text) ? txtMedHistory.Text : "";

                SaveAllToFile();

                ShowPatients();
                ClearForm();
                GenerateNextID();
                MessageBox.Show("Patient updated successfully!");
            }
            else
            {
                MessageBox.Show("Please select a patient from the list first.");
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Find the patient in the list using the id from the textbox
            Patient patToDelete = patients.FirstOrDefault(p => p.PatientID == txtID.Text);

            if (patToDelete != null)
            {
                //Ask for confirmation before deleting
                DialogResult dialog = MessageBox.Show("Are you sure you want to delete this patient?",
                    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialog == DialogResult.Yes)
                {
                    //Remove the selected patient from the list
                    patients.Remove(patToDelete);

                    //Overwrite the file with the updated list
                    SaveAllToFile();

                    //Refresh ui and reset id
                    ShowPatients();
                    ClearForm();
                    GenerateNextID();

                    MessageBox.Show("Patient deleted successfully!");
                }
            }
            else
            {
                MessageBox.Show("Please select or search a patient from the list to delete.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(keyword))
            {
                //if search is empty, show everyone
                ShowPatients();
            }
            else
            {
                //Filter the list
                var results = patients.Where(p =>
                    p.FullName.ToLower().Contains(keyword) ||
                    p.PatientID.ToLower().Contains(keyword)
                ).ToList();

                //Show the result on the grid
                dgvPatients.DataSource = null;
                dgvPatients.DataSource = results;
                FormatGrid();
            }
        }
    }
}
