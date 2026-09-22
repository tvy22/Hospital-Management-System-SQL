using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Hospital_Management_System_SQL.Interfaces;
using Hospital_Management_System_SQL.Logic;
using Hospital_Management_System_SQL.Models;

namespace Hospital_Management_System_SQL.Forms
{
    public partial class VisitHistoryForm : Form
    {
        private readonly ICheckinRepository _checkinRepository;

        public VisitHistoryForm()
        {
            InitializeComponent();
            _checkinRepository = new CheckInOutRepository();
        }

        private void VisitHistoryForm_Load(object sender, EventArgs e)
        {
            LoadCompletedVisits();
        }

        private void LoadCompletedVisits()
        {
            try
            {
                List<Checkin> completedVisits = _checkinRepository.GetCompletedVisits();
                dgvVisitHistory.DataSource = completedVisits;

                // Customize column headers for display
                if (dgvVisitHistory.Columns["AppID"] != null) dgvVisitHistory.Columns["AppID"].HeaderText = "App ID";
                if (dgvVisitHistory.Columns["PatientID"] != null) dgvVisitHistory.Columns["PatientID"].HeaderText = "Patient ID";
                if (dgvVisitHistory.Columns["PatientName"] != null) dgvVisitHistory.Columns["PatientName"].HeaderText = "Patient";
                if (dgvVisitHistory.Columns["DocName"] != null) dgvVisitHistory.Columns["DocName"].HeaderText = "Doctor";
                if (dgvVisitHistory.Columns["DocSpeciality"] != null) dgvVisitHistory.Columns["DocSpeciality"].HeaderText = "Specialty";
                if (dgvVisitHistory.Columns["RoomNumber"] != null) dgvVisitHistory.Columns["RoomNumber"].HeaderText = "Room";
                if (dgvVisitHistory.Columns["Reason"] != null) dgvVisitHistory.Columns["Reason"].HeaderText = "Reason";
                if (dgvVisitHistory.Columns["Fee"] != null) dgvVisitHistory.Columns["Fee"].DefaultCellStyle.Format = "c";
                if (dgvVisitHistory.Columns["Date"] != null) dgvVisitHistory.Columns["Date"].HeaderText = "Date";

                // Hide Extra Columns
                if (dgvVisitHistory.Columns["Status"] != null) dgvVisitHistory.Columns["Status"].Visible = false;
                if (dgvVisitHistory.Columns["CheckoutDate"] != null) dgvVisitHistory.Columns["CheckoutDate"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load visit history: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string filter = txtSearch.Text.Trim().ToLower();

            if (dgvVisitHistory.DataSource is List<Checkin> list)
            {
                if (string.IsNullOrEmpty(filter))
                {
                    dgvVisitHistory.DataSource = _checkinRepository.GetCompletedVisits();
                }
                else
                {
                    var filteredList = list.FindAll(x =>
                        (x.PatientName != null && x.PatientName.ToLower().Contains(filter)) ||
                        (x.PatientID != null && x.PatientID.ToLower().Contains(filter)) ||
                        (x.DocName != null && x.DocName.ToLower().Contains(filter)) ||
                        (x.AppID != null && x.AppID.ToLower().Contains(filter))
                    );

                    dgvVisitHistory.DataSource = filteredList;
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}