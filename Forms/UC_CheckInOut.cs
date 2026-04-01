

using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Hospital_Management_System.Forms
{
    public partial class UC_CheckInOut : UserControl
    {
        DataTable billingTable = new DataTable();

        public UC_CheckInOut()
        {
            InitializeComponent();
            SetupSampleData();
        }

        private void SetupSampleData()
        {
            if (billingTable.Columns.Count == 0) 
            {
                billingTable.Columns.Add("VisitID");
                billingTable.Columns.Add("PatientName");
                billingTable.Columns.Add("DoctorName");
                billingTable.Columns.Add("RoomNumber");
                billingTable.Columns.Add("Reason");
                billingTable.Columns.Add("ConsultationFee", typeof(decimal));
            }

            billingTable.Rows.Clear();
            billingTable.Rows.Add("V-1001", "Vy", "Dr. Ta", "Room 10", "General Checkup", 150.00);
            billingTable.Rows.Add("V-1002", "John Doe", "Dr. Smith", "Room 05", "Fever/Flu", 200.00);
            billingTable.Rows.Add("V-1003", "Jane Smith", "Dr. Wilson", "Room 12", "Follow-up", 75.50);

            dgvActiveVisits.DataSource = billingTable;
        }

        private void dgvActiveVisits_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvActiveVisits.Rows[e.RowIndex];
                txtAppID_CO.Text = row.Cells["VisitID"].Value.ToString();
                txtPatient_CO.Text = row.Cells["PatientName"].Value.ToString();
                txtDoctor_CO.Text = row.Cells["DoctorName"].Value.ToString();
                txtRoom_CO.Text = row.Cells["RoomNumber"].Value.ToString();
                txtReason.Text = row.Cells["Reason"].Value.ToString();

                decimal fee = Convert.ToDecimal(row.Cells["ConsultationFee"].Value);
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
                    SetupSampleData();
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

        private void btnRefresh_Click(object sender, EventArgs e) => SetupSampleData();

        // Empty events to avoid Designer errors
        private void txtSearchActive_TextChanged(object sender, EventArgs e) 
        {
            // 1. Get the text from the search box
            string searchText = txtSearchActive.Text.Replace("'", "''"); // Escape single quotes for safety

            // 2. Create a DataView from your billingTable
            DataView dv = billingTable.DefaultView;

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