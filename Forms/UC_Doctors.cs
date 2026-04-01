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
using System.Web.Configuration;

namespace Hospital_Management_System.Forms
{
    public partial class UC_Doctors : UserControl
    {
        string fileName = "doctors.dat";
        List<Doctor> doctors = new List<Doctor>();
        BinaryFormatter bf = new BinaryFormatter();

        public UC_Doctors()
        {
            InitializeComponent();
            txtID.Enabled = false;
            LoadDoctors(); //Get from file
            ShowDoctors(); //Show in grid
            GenerateNextID(); //Setup next id
        }

        //Function to clear form
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
            rbMale.Checked = true; //default
            dtpDOB.Value = DateTime.Now;
        }

        //Function to save data to file
        private void SaveAllToFile()
        {
            using (FileStream fs = new FileStream(fileName, FileMode.Create))
            {
                foreach (Doctor d in doctors)
                {
                    bf.Serialize(fs, d);
                }
            }
        }

        //Function to load all doctors
        private void LoadDoctors()
        {
            if (File.Exists(fileName))
            {
                FileStream fs = new FileStream(fileName, FileMode.Open);
                while (fs.Position != fs.Length)
                {
                    Doctor d = (Doctor)bf.Deserialize(fs);
                    doctors.Add(d);
                }
                fs.Close();
            }
        }

        //Function to show doctors in data grid view
        private void ShowDoctors()
        {
            dgvDoctors.DataSource = null;
            dgvDoctors.DataSource = doctors;
            FormatGrid();
        }

        //Function to rename the data grid header
        private void FormatGrid()
        {
            if (dgvDoctors.Columns.Count > 0)
            {
                dgvDoctors.Columns["DoctorID"].HeaderText = "ID";
                dgvDoctors.Columns["FullName"].HeaderText = "Name";
                dgvDoctors.Columns["RoomNumber"].HeaderText = "Room";
                dgvDoctors.Columns["ConsultationFee"].HeaderText = "Fee($)";
                dgvDoctors.Columns["DateOfBirth"].HeaderText = "Birthdate";

                //Handle image
                if (dgvDoctors.Columns.Contains("DoctorImage"))
                {
                    DataGridViewImageColumn imgCol = (DataGridViewImageColumn)dgvDoctors.Columns["DoctorImage"];
                    imgCol.HeaderText = "Photo";
                    imgCol.Visible = true;

                    //Make the image fits nicely in the cell
                    imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;

                    dgvDoctors.RowTemplate.Height = 60;
                    foreach (DataGridViewRow row in dgvDoctors.Rows)
                    {
                        row.Height = 60;
                    }
                }
            }
        }

        //Function to auto-generate doctor id
        //private void GenerateNextID()
        //{
        //    int nextId = doctors.Count + 1;
        //    txtID.Text = "DOC-" + nextId.ToString("000");
        //}

        private void GenerateNextID()
        {
            int maxId = 0;

            if (doctors.Count > 0)
            {
                foreach (var d in doctors)
                {
                    // Check if ID is not null, starts with DOC-, and is long enough
                    if (!string.IsNullOrEmpty(d.DoctorID) && d.DoctorID.StartsWith("DOC-") && d.DoctorID.Length > 4)
                    {
                        // Try to parse the number part safely
                        if (int.TryParse(d.DoctorID.Substring(4), out int idValue))
                        {
                            if (idValue > maxId) maxId = idValue;
                        }
                    }
                }
            }

            int nextId = maxId + 1;
            txtID.Text = "DOC-" + nextId.ToString("000");
        }

        //Function to show uploaded image
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

        //Function to convert image to byte
        private byte[] ImageToByteArray(Image imageIn)
        {
            if (imageIn == null) return null;

            using (MemoryStream ms = new MemoryStream())
            {
                imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

        //Function to validate the data fields in form
        private bool IsValid()
        {
            errorProvider1.Clear();
            bool isAllValid = true;

            //Check if name is empty
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                errorProvider1.SetError(txtName, "Doctor name is required.");
                isAllValid = false;
            }

            //Check email
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                errorProvider1.SetError(txtEmail, "Valid email address is required.");
                isAllValid = false;
            }

            //Check phone
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                errorProvider1.SetError(txtPhone, "Phone is required.");
                isAllValid = false;
            }

            //Check room
            if (string.IsNullOrWhiteSpace(txtRoom.Text))
            {
                errorProvider1.SetError(txtRoom, "Room is required.");
                isAllValid = false;
            }

            //Check fee
            if (string.IsNullOrWhiteSpace(txtFee.Text))
            {
                errorProvider1.SetError(txtFee, "Fee is required.");
                isAllValid = false;
            }

            //Check speciality
            if (cmbSpeciality.SelectedIndex <= 0)
            {
                errorProvider1.SetError(cmbSpeciality, "Speciality is required.");
                isAllValid = false;
            }

            //Check status
            if (cmbStatus.SelectedIndex <= 0)
            {
                errorProvider1.SetError(cmbStatus, "Status is required.");
                isAllValid = false;
            }

            //Check shift
            if (cmbShift.SelectedIndex <= 0)
            {
                errorProvider1.SetError(cmbShift, "Shift is required.");
                isAllValid = false;
            }

            return isAllValid;
        }

        //Function to save new doctor object
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!IsValid()) return;

            //Check if the id already exists before saving
            bool alreadyExists = doctors.Any(d => d.DoctorID == txtID.Text);

            if (alreadyExists)
            {
                MessageBox.Show("This doctor ID already exists." +
                                "If you want to change their details, please use the Update button instead.",
                                "Duplicate ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Create a new doctor object
            Doctor newDoc = new Doctor();
            newDoc.DoctorID = txtID.Text;
            newDoc.FullName = txtName.Text;
            newDoc.Email = txtEmail.Text;
            newDoc.Phone = txtPhone.Text;
            newDoc.Speciality = cmbSpeciality.Text;
            newDoc.RoomNumber = txtRoom.Text;
            decimal fee;
            decimal.TryParse(txtFee.Text, out fee);
            newDoc.ConsultationFee = fee;
            newDoc.DateOfBirth = dtpDOB.Value;

            //Gender 
            if (rbFemale.Checked) newDoc.Gender = "Female";
            else if (rbMale.Checked) newDoc.Gender = "Male";

            newDoc.Status = cmbStatus.Text;
            newDoc.Shift = cmbShift.Text;

            //Convert image
            newDoc.DoctorImage = ImageToByteArray(picDoctor.Image);

            doctors.Add(newDoc);
            SaveAllToFile();
            ShowDoctors();
            ClearForm();
            MessageBox.Show("Doctor saved successfully!");

            GenerateNextID();
        }

        private void dgvDoctors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Check if a valid row was clicked
            if (e.RowIndex >= 0 && dgvDoctors.Rows[e.RowIndex].Cells["DoctorID"].Value != null)
            {
                //Get the selected doctor from the list
                string id = dgvDoctors.Rows[e.RowIndex].Cells["DoctorID"].Value.ToString();
                Doctor selectedDoc = doctors.FirstOrDefault(d => d.DoctorID == id);

                //Fill the form with their data
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

                //Handle image
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Find the doctor in the list that matches the ID in the textbox
            Doctor docToUpdate = doctors.FirstOrDefault(d => d.DoctorID == txtID.Text);

            if (docToUpdate != null)
            {
                if (!IsValid())
                {
                    return;
                }

                // Update the properties with data currently in the textboxes
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
                docToUpdate.DoctorImage = ImageToByteArray(picDoctor.Image);

                SaveAllToFile();

                //Refresh the UI
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
            //Find the doctor in the list using the id from the textbox
            Doctor docToDelete = doctors.FirstOrDefault(d => d.DoctorID == txtID.Text);

            if (docToDelete != null)
            {
                //Ask for confirmation before deleting
                DialogResult dialog = MessageBox.Show("Are you sure you want to delete this doctor?",
                    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialog == DialogResult.Yes)
                {
                    //Remove the selected doctor from the list
                    doctors.Remove(docToDelete);

                    //Overwrite the file with the updated list
                    SaveAllToFile();

                    //Refresh ui and reset id
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
                //if search is empty, show everyone
                ShowDoctors();
            }
            else
            {
                //Filter the list
                var results = doctors.Where(d =>
                    d.FullName.ToLower().Contains(keyword) ||
                    d.DoctorID.ToLower().Contains(keyword)
                ).ToList();

                //Show the result on the grid
                dgvDoctors.DataSource = null;
                dgvDoctors.DataSource = results;
                FormatGrid();
            }
        }
    }
}
