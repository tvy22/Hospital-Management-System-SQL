using System.Drawing;

namespace Hospital_Management_System.Forms
{
    partial class UC_Doctors
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.picDoctor = new System.Windows.Forms.PictureBox();
            this.btnUpload = new System.Windows.Forms.Button();

            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblDOB = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.lblGender = new System.Windows.Forms.Label();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.lblFee = new System.Windows.Forms.Label();
            this.txtFee = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();

            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();

            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvDoctors = new System.Windows.Forms.DataGridView();

            this.pnlMain.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDoctor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctors)).BeginInit();
            this.SuspendLayout();

            // MAIN PANEL
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(980, 700);
            this.pnlMain.TabIndex = 0;
            this.Controls.Add(this.pnlMain);

            // HEADER
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height = 60;
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlMain.Controls.Add(this.pnlHeader);

            this.lblTitle.Text = "👨‍⚕️ Doctor Management";
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(20, 17);
            this.pnlHeader.Controls.Add(this.lblTitle);

            // PROFILE IMAGE
            this.picDoctor.Location = new System.Drawing.Point(60, 110);
            this.picDoctor.Size = new System.Drawing.Size(150, 170);
            this.picDoctor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDoctor.BackColor = System.Drawing.Color.White;
            this.picDoctor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Controls.Add(this.picDoctor);

            this.btnUpload.Text = "📷 Upload";
            this.btnUpload.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnUpload.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnUpload.ForeColor = System.Drawing.Color.White;
            this.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpload.Location = new System.Drawing.Point(60, 290);
            this.btnUpload.Size = new System.Drawing.Size(150, 35);
            this.pnlMain.Controls.Add(this.btnUpload);

            // LEFT COLUMN (Calculated Numbers)
            this.lblID.Text = "Doctor ID:";
            this.lblID.Location = new System.Drawing.Point(260, 110);
            this.lblID.AutoSize = true;
            this.pnlMain.Controls.Add(this.lblID);

            this.txtID.Location = new System.Drawing.Point(380, 107);
            this.txtID.Width = 220;
            this.pnlMain.Controls.Add(this.txtID);

            this.lblName.Text = "Full Name:";
            this.lblName.Location = new System.Drawing.Point(260, 150);
            this.lblName.AutoSize = true;
            this.pnlMain.Controls.Add(this.lblName);

            this.txtName.Location = new System.Drawing.Point(380, 147);
            this.txtName.Width = 220;
            this.pnlMain.Controls.Add(this.txtName);

            this.lblDOB.Text = "Date of Birth:";
            this.lblDOB.Location = new System.Drawing.Point(260, 190);
            this.lblDOB.AutoSize = true;
            this.pnlMain.Controls.Add(this.lblDOB);

            this.dtpDOB.Location = new System.Drawing.Point(380, 187);
            this.dtpDOB.Width = 220;
            this.pnlMain.Controls.Add(this.dtpDOB);

            this.lblGender.Text = "Gender:";
            this.lblGender.Location = new System.Drawing.Point(260, 230);
            this.lblGender.AutoSize = true;
            this.pnlMain.Controls.Add(this.lblGender);

            this.rbMale.Text = "Male";
            this.rbMale.Location = new System.Drawing.Point(380, 227);
            this.rbMale.Size = new System.Drawing.Size(70, 24);
            this.pnlMain.Controls.Add(this.rbMale);

            this.rbFemale.Text = "Female";
            this.rbFemale.Location = new System.Drawing.Point(460, 227);
            this.rbFemale.Size = new System.Drawing.Size(80, 24);
            this.pnlMain.Controls.Add(this.rbFemale);

            // RIGHT COLUMN (Calculated Numbers)
            this.lblPhone.Text = "Phone:";
            this.lblPhone.Location = new System.Drawing.Point(600, 110);
            this.lblPhone.AutoSize = true;
            this.pnlMain.Controls.Add(this.lblPhone);

            this.txtPhone.Location = new System.Drawing.Point(720, 107);
            this.txtPhone.Width = 220;
            this.pnlMain.Controls.Add(this.txtPhone);

            this.lblEmail.Text = "Email:";
            this.lblEmail.Location = new System.Drawing.Point(600, 150);
            this.lblEmail.AutoSize = true;
            this.pnlMain.Controls.Add(this.lblEmail);

            this.txtEmail.Location = new System.Drawing.Point(720, 147);
            this.txtEmail.Width = 220;
            this.pnlMain.Controls.Add(this.txtEmail);

            this.lblFee.Text = "Consultation Fee:";
            this.lblFee.Location = new System.Drawing.Point(600, 190);
            this.lblFee.AutoSize = true;
            this.pnlMain.Controls.Add(this.lblFee);

            this.txtFee.Location = new System.Drawing.Point(720, 187);
            this.txtFee.Width = 220;
            this.pnlMain.Controls.Add(this.txtFee);

            this.lblStatus.Text = "Status:";
            this.lblStatus.Location = new System.Drawing.Point(600, 230);
            this.lblStatus.AutoSize = true;
            this.pnlMain.Controls.Add(this.lblStatus);

            this.cmbStatus.Location = new System.Drawing.Point(720, 227);
            this.cmbStatus.Width = 180;
            this.cmbStatus.Items.AddRange(new object[] { "Active", "Inactive" });
            this.pnlMain.Controls.Add(this.cmbStatus);

            // BUTTONS
            this.btnSave.Text = "💾 Save";
            this.btnSave.Location = new System.Drawing.Point(350, 320);
            this.btnSave.Size = new System.Drawing.Size(100, 40);
            this.pnlMain.Controls.Add(this.btnSave);

            this.btnUpdate.Text = "✏ Update";
            this.btnUpdate.Location = new System.Drawing.Point(480, 320);
            this.btnUpdate.Size = new System.Drawing.Size(100, 40);
            this.pnlMain.Controls.Add(this.btnUpdate);

            this.btnDelete.Text = "🗑 Delete";
            this.btnDelete.Location = new System.Drawing.Point(610, 320);
            this.btnDelete.Size = new System.Drawing.Size(100, 40);
            this.pnlMain.Controls.Add(this.btnDelete);

            // SEARCH
            this.lblSearch.Text = "🔍 Search:";
            this.lblSearch.Location = new System.Drawing.Point(60, 380);
            this.lblSearch.AutoSize = true;
            this.pnlMain.Controls.Add(this.lblSearch);

            this.txtSearch.Location = new System.Drawing.Point(150, 377);
            this.txtSearch.Width = 250;
            this.pnlMain.Controls.Add(this.txtSearch);

            // DATAGRID
            this.dgvDoctors.Location = new System.Drawing.Point(60, 420);
            this.dgvDoctors.Size = new System.Drawing.Size(840, 220);
            this.dgvDoctors.BackgroundColor = System.Drawing.Color.White;
            this.dgvDoctors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pnlMain.Controls.Add(this.dgvDoctors);

            this.Size = new System.Drawing.Size(980, 700);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDoctor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctors)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;

        private System.Windows.Forms.PictureBox picDoctor;
        private System.Windows.Forms.Button btnUpload;

        private System.Windows.Forms.Label lblID, lblName, lblPhone, lblEmail, lblDOB, lblGender, lblShift, lblFee, lblStatus, lblSearch;
        private System.Windows.Forms.TextBox txtID, txtName, txtPhone, txtEmail, txtFee, txtSearch;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.RadioButton rbMale, rbFemale;
        private System.Windows.Forms.ComboBox cmbShift, cmbStatus;

        private System.Windows.Forms.Button btnSave, btnUpdate, btnDelete;
        private System.Windows.Forms.DataGridView dgvDoctors;
    }
}