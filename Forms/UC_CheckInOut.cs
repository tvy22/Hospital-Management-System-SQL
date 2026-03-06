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
            billingTable.Columns.Add("VisitID");
            billingTable.Columns.Add("PatientName");
            billingTable.Columns.Add("DoctorName");
            billingTable.Columns.Add("RoomNumber");
            billingTable.Columns.Add("ConsultationFee", typeof(decimal));

            // 2. Insert some dummy data to test clicking
            billingTable.Rows.Add("V-1001", "Vy", "Dr. Ta", "Room 10", 150.00);
            billingTable.Rows.Add("V-1002", "John Doe", "Dr. Smith", "Room 05", 200.00);
            billingTable.Rows.Add("V-1003", "Jane Smith", "Dr. Wilson", "Room 12", 75.50);

            // 3. Bind the data to your DataGridView
            dgvActiveVisits.DataSource = billingTable;

            // Optional: Make it look clean
            dgvActiveVisits.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvActiveVisits.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvActiveVisits.MultiSelect = false;
        }

        private void txtSearchActive_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvActiveVisits_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvActiveVisits.Rows[e.RowIndex];

                // Map data from the table to your TextBoxes
                txtAppID_CO.Text = row.Cells["VisitID"].Value.ToString();
                txtPatient_CO.Text = row.Cells["PatientName"].Value.ToString();
                txtDoctor_CO.Text = row.Cells["DoctorName"].Value.ToString();
                txtRoom_CO.Text = row.Cells["RoomNumber"].Value.ToString();

                // For 'Reason', we can set a default or pull it if it exists
                txtReason.Text = "Routine Checkup";

                // Calculate and display the total
                decimal fee = Convert.ToDecimal(row.Cells["ConsultationFee"].Value);
                lblFinalCost.Text = fee.ToString("C2"); // Formats as currency like $ 150.00
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            SetupSampleData();
        }

        private void txtAppID_CO_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPatient_CO_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDoctor_CO_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRoom_CO_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtReason_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblFinalCost_Click(object sender, EventArgs e)
        {

        }

        private void btnCompleteVisit_Click(object sender, EventArgs e)
        {

        }
    }
}
