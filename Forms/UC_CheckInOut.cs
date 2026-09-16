

using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Hospital_Management_System_SQL.Models;

namespace Hospital_Management_System_SQL.Forms
{
    public partial class UC_CheckInOut : UserControl
    {
        List<Checkin> checkinList = new List<Checkin>();
        DataTable checkinTable = new DataTable();

        public UC_CheckInOut()
        {
            InitializeComponent();
            LoadCheckins();
            LoadDataForCheckIn();
            dgvPatient.CellClick += dgvPatient_CellClick;
            cmbSpeciality.SelectionChangeCommitted += cmbSpeciality_SelectionChangeCommitted;
            cmbDoctor.SelectionChangeCommitted += cmbDoctor_SelectionChangeCommitted;
            btnRegister.Click += btnRegister_Click;
        }

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

            //Get checkin data from file
            if (File.Exists(fileCheckin))
            {
                FileStream fs = new FileStream(fileCheckin, FileMode.Open);
                while(fs.Position != fs.Length)
                {
                    Checkin c = (Checkin)bf.Deserialize(fs);
                    checkinList.Add(c);
                }
                fs.Close();

                foreach (Checkin c in checkinList)
                {
                    checkinTable.Rows.Add(
                        c.AppID,
                        c.PatientName,
                        c.DocName,
                        c.RoomNumber,
                        c.Reason
                    );
                }

                dgvActiveVisits.DataSource = checkinTable;
            }
        }

        private void dgvActiveVisits_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvActiveVisits.Rows[e.RowIndex];
                txtAppID_CO.Text = row.Cells["ID"].Value.ToString();
                txtPatient_CO.Text = row.Cells["Patient"].Value.ToString();
                txtDoctor_CO.Text = row.Cells["Doctor"].Value.ToString();
                txtRoom_CO.Text = row.Cells["Room"].Value.ToString();
                txtReason.Text = row.Cells["Reason"].Value.ToString();

                decimal fee = Convert.ToDecimal(row.Cells["Fee"].Value);
                lblFinalCost.Text = fee.ToString("C2");
            }
        }

        private void btnCompleteVisit_Click(object sender, EventArgs e)
        {
            // 1. Validate selection
            if (string.IsNullOrEmpty(txtAppID_CO.Text))
            {
                MessageBox.Show("Please select a visit from the list first.", "No Selection");
                return;
            }

            // 2. Confirmation
            DialogResult confirm = MessageBox.Show("Process payment and complete this visit?", "Confirm", MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    string filePath = "checkouts.dat";
                    BinaryFormatter BF = new BinaryFormatter();
                    List<CheckIn> updatedList = new List<CheckIn>();

                    // 3. Load from FileStream
                    if (File.Exists(filePath))
                    {
                        using (FileStream fsRead = new FileStream(filePath, FileMode.Open))
                        {
                            updatedList = (List<CheckIn>)BF.Deserialize(fsRead);
                        }
                    }

                    // 4. Update
                    CheckIn record = updatedList.Find(x => x.VisitID == txtAppID_CO.Text);
                    if (record != null)
                    {
                        record.Status = "Completed";
                        record.Cost = lblFinalCost.Text;
                    }

                    // 5. Save using FileStream (Overwriting)
                    FileStream Fn = new FileStream(filePath, FileMode.Create);
                    BF.Serialize(Fn, updatedList);
                    Fn.Close(); // 6. Important Closure

                    MessageBox.Show("Payment Processed Successfully!", "Success");

                    ClearFields();
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

        // Empty events to avoid Designer errors
        private void txtSearchActive_TextChanged(object sender, EventArgs e) 
        {
            // 1. Get the text from the search box
            string searchText = txtSearchActive.Text.Replace("'", "''"); // Escape single quotes for safety

            // 2. Create a DataView from your billingTable
            DataView dv = checkinTable.DefaultView;

            // 3. Apply the filter. 
            // This searches across VisitID OR PatientName. You can add more columns if needed.
            dv.RowFilter = string.Format("VisitID LIKE '%{0}%' OR PatientName LIKE '%{0}%'", searchText);

            // 4. Update the Grid display
            dgvActiveVisits.DataSource = dv;
        }
        private void txtAppID_CO_TextChanged(object sender, EventArgs e) { }
        private void txtPatient_CO_TextChanged(object sender, EventArgs e) { }
        private void txtDoctor_CO_TextChanged(object sender, EventArgs e) { }
        private void txtRoom_CO_TextChanged(object sender, EventArgs e) { }
        private void txtReason_TextChanged(object sender, EventArgs e) { }
        private void lblFinalCost_Click(object sender, EventArgs e) { }
    }

    // This class must be OUTSIDE the UC_CheckInOut class but INSIDE the namespace
    [Serializable]
    public class CheckIn
    {
        public string VisitID { get; set; }
        public string PatientName { get; set; }
        public string DoctorName { get; set; }
        public string RoomNumber { get; set; }
        public string Status { get; set; }
        public string Cost { get; set; }
    }
}