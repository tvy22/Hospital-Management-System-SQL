using Guna.UI2.WinForms;

namespace Hospital_Management_System.Forms
{
    partial class UC_CheckInOut
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMain = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlCard = new Guna.UI2.WinForms.Guna2Panel();
            this.txtCheckInID = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbPatient = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbDoctor = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtpVisitDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cmbStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtNotes = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnCheckIn = new Guna.UI2.WinForms.Guna2Button();
            this.btnCheckOut = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvCheckInOut = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pnlMain.SuspendLayout();
            this.pnlCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckInOut)).BeginInit();
            this.SuspendLayout();

            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.lblTitle);
            this.pnlMain.Controls.Add(this.pnlCard);
            this.pnlMain.Controls.Add(this.txtSearch);
            this.pnlMain.Controls.Add(this.dgvCheckInOut);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.FillColor = System.Drawing.Color.FromArgb(242, 245, 250);
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(980, 750);

            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
            this.lblTitle.Location = new System.Drawing.Point(30, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(400, 50);
            this.lblTitle.Text = "Patient Check-In/Out";

            // 
            // pnlCard
            // 
            this.pnlCard.BackColor = System.Drawing.Color.Transparent;
            this.pnlCard.BorderRadius = 20;
            this.pnlCard.Controls.Add(this.txtCheckInID);
            this.pnlCard.Controls.Add(this.cmbPatient);
            this.pnlCard.Controls.Add(this.cmbDoctor);
            this.pnlCard.Controls.Add(this.dtpVisitDate);
            this.pnlCard.Controls.Add(this.cmbStatus);
            this.pnlCard.Controls.Add(this.txtNotes);
            this.pnlCard.Controls.Add(this.btnCheckIn);
            this.pnlCard.Controls.Add(this.btnCheckOut);
            this.pnlCard.Controls.Add(this.btnDelete);
            this.pnlCard.FillColor = System.Drawing.Color.White;
            this.pnlCard.Location = new System.Drawing.Point(30, 85);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.ShadowDecoration.Enabled = true;
            this.pnlCard.Size = new System.Drawing.Size(920, 310);

            // txtCheckInID
            this.txtCheckInID.BorderRadius = 8;
            this.txtCheckInID.FillColor = System.Drawing.Color.FromArgb(242, 245, 250);
            this.txtCheckInID.Location = new System.Drawing.Point(30, 30);
            this.txtCheckInID.Name = "txtCheckInID";
            this.txtCheckInID.PlaceholderText = "Check-In ID";
            this.txtCheckInID.Size = new System.Drawing.Size(180, 36);

            // cmbPatient (Dropdown for selecting existing patients)
            this.cmbPatient.BorderRadius = 8;
            this.cmbPatient.FillColor = System.Drawing.Color.FromArgb(242, 245, 250);
            this.cmbPatient.Items.AddRange(new object[] { "-- Select Patient --" });
            this.cmbPatient.Location = new System.Drawing.Point(230, 30);
            this.cmbPatient.Name = "cmbPatient";
            this.cmbPatient.Size = new System.Drawing.Size(320, 36);

            // cmbDoctor (Dropdown for selecting doctors)
            this.cmbDoctor.BorderRadius = 8;
            this.cmbDoctor.FillColor = System.Drawing.Color.FromArgb(242, 245, 250);
            this.cmbDoctor.Items.AddRange(new object[] { "-- Select Doctor --" });
            this.cmbDoctor.Location = new System.Drawing.Point(570, 30);
            this.cmbDoctor.Name = "cmbDoctor";
            this.cmbDoctor.Size = new System.Drawing.Size(320, 36);

            // dtpVisitDate
            this.dtpVisitDate.BorderRadius = 8;
            this.dtpVisitDate.FillColor = System.Drawing.Color.FromArgb(242, 245, 250);
            this.dtpVisitDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpVisitDate.Location = new System.Drawing.Point(30, 85);
            this.dtpVisitDate.Name = "dtpVisitDate";
            this.dtpVisitDate.Size = new System.Drawing.Size(380, 36);

            // cmbStatus
            this.cmbStatus.BorderRadius = 8;
            this.cmbStatus.FillColor = System.Drawing.Color.FromArgb(242, 245, 250);
            this.cmbStatus.Items.AddRange(new object[] { "Pending", "Checked-In", "Completed", "Cancelled" });
            this.cmbStatus.Location = new System.Drawing.Point(430, 85);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(460, 36);

            // txtNotes
            this.txtNotes.BorderRadius = 8;
            this.txtNotes.FillColor = System.Drawing.Color.FromArgb(242, 245, 250);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.PlaceholderText = "Visit Notes / Reason for Visit...";
            this.txtNotes.Size = new System.Drawing.Size(860, 80);
            this.txtNotes.Location = new System.Drawing.Point(30, 140);

            // Buttons
            this.btnCheckIn.BorderRadius = 10;
            this.btnCheckIn.FillColor = System.Drawing.Color.FromArgb(0, 171, 102); // Green
            this.btnCheckIn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCheckIn.ForeColor = System.Drawing.Color.White;
            this.btnCheckIn.Location = new System.Drawing.Point(540, 240);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(110, 45);
            this.btnCheckIn.Text = "Check-In";

            this.btnCheckOut.BorderRadius = 10;
            this.btnCheckOut.FillColor = System.Drawing.Color.FromArgb(44, 62, 80); // Dark Blue
            this.btnCheckOut.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCheckOut.ForeColor = System.Drawing.Color.White;
            this.btnCheckOut.Location = new System.Drawing.Point(660, 240);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(110, 45);
            this.btnCheckOut.Text = "Check-Out";

            this.btnDelete.BorderRadius = 10;
            this.btnDelete.FillColor = System.Drawing.Color.FromArgb(255, 71, 87); // Red
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(780, 240);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(110, 45);
            this.btnDelete.Text = "Delete";

            // txtSearch
            this.txtSearch.BorderRadius = 20;
            this.txtSearch.Location = new System.Drawing.Point(30, 410);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "🔍 Search visit history...";
            this.txtSearch.Size = new System.Drawing.Size(350, 40);

            // dgvCheckInOut
            this.dgvCheckInOut.BackgroundColor = System.Drawing.Color.White;
            this.dgvCheckInOut.ColumnHeadersHeight = 40;
            this.dgvCheckInOut.Location = new System.Drawing.Point(30, 465);
            this.dgvCheckInOut.Name = "dgvCheckInOut";
            this.dgvCheckInOut.RowHeadersVisible = false;
            this.dgvCheckInOut.Size = new System.Drawing.Size(920, 250);

            // UC_CheckInOut
            this.Controls.Add(this.pnlMain);
            this.Name = "UC_CheckInOut";
            this.Size = new System.Drawing.Size(980, 750);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckInOut)).EndInit();
            this.ResumeLayout(false);
        }

        private Guna2Panel pnlMain;
        private Guna2Panel pnlCard;
        private System.Windows.Forms.Label lblTitle;
        private Guna2TextBox txtCheckInID, txtNotes, txtSearch;
        private Guna2ComboBox cmbPatient, cmbDoctor, cmbStatus;
        private Guna2DateTimePicker dtpVisitDate;
        private Guna2Button btnCheckIn, btnCheckOut, btnDelete;
        private Guna2DataGridView dgvCheckInOut;
    }
}