using System.Drawing;
using Guna.UI2.WinForms;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMain = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.pnlHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.picDoctor = new System.Windows.Forms.PictureBox();
            this.btnUpload = new Guna.UI2.WinForms.Guna2Button();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblDOB = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.lblGender = new System.Windows.Forms.Label();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblSpeciality = new System.Windows.Forms.Label();
            this.txtFee = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.shift = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvDoctors = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pnlMain.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDoctor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctors)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.cmbStatus);
            this.pnlMain.Controls.Add(this.pnlHeader);
            this.pnlMain.Controls.Add(this.picDoctor);
            this.pnlMain.Controls.Add(this.btnUpload);
            this.pnlMain.Controls.Add(this.lblID);
            this.pnlMain.Controls.Add(this.txtID);
            this.pnlMain.Controls.Add(this.lblName);
            this.pnlMain.Controls.Add(this.txtName);
            this.pnlMain.Controls.Add(this.lblDOB);
            this.pnlMain.Controls.Add(this.dtpDOB);
            this.pnlMain.Controls.Add(this.lblGender);
            this.pnlMain.Controls.Add(this.rbMale);
            this.pnlMain.Controls.Add(this.rbFemale);
            this.pnlMain.Controls.Add(this.lblPhone);
            this.pnlMain.Controls.Add(this.txtPhone);
            this.pnlMain.Controls.Add(this.lblEmail);
            this.pnlMain.Controls.Add(this.txtEmail);
            this.pnlMain.Controls.Add(this.lblSpeciality);
            this.pnlMain.Controls.Add(this.txtFee);
            this.pnlMain.Controls.Add(this.lblStatus);
            this.pnlMain.Controls.Add(this.shift);
            this.pnlMain.Controls.Add(this.btnSave);
            this.pnlMain.Controls.Add(this.btnUpdate);
            this.pnlMain.Controls.Add(this.btnDelete);
            this.pnlMain.Controls.Add(this.lblSearch);
            this.pnlMain.Controls.Add(this.txtSearch);
            this.pnlMain.Controls.Add(this.dgvDoctors);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(980, 700);
            this.pnlMain.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(600, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Status:";
            // 
            // cmbStatus
            // 
            this.cmbStatus.BackColor = System.Drawing.Color.Transparent;
            this.cmbStatus.BorderRadius = 6;
            this.cmbStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FocusedColor = System.Drawing.Color.Empty;
            this.cmbStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbStatus.ItemHeight = 30;
            this.cmbStatus.Items.AddRange(new object[] {
            "Available",
            "Busy",
            "On leave"});
            this.cmbStatus.Location = new System.Drawing.Point(720, 222);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(180, 36);
            this.cmbStatus.TabIndex = 1;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(980, 80);
            this.pnlHeader.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(234, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "👨‍⚕️ Doctor Management";
            // 
            // picDoctor
            // 
            this.picDoctor.BackColor = System.Drawing.Color.White;
            this.picDoctor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picDoctor.Location = new System.Drawing.Point(60, 112);
            this.picDoctor.Name = "picDoctor";
            this.picDoctor.Size = new System.Drawing.Size(150, 170);
            this.picDoctor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDoctor.TabIndex = 3;
            this.picDoctor.TabStop = false;
            // 
            // btnUpload
            // 
            this.btnUpload.BorderRadius = 8;
            this.btnUpload.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnUpload.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnUpload.ForeColor = System.Drawing.Color.White;
            this.btnUpload.Location = new System.Drawing.Point(60, 292);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(150, 35);
            this.btnUpload.TabIndex = 4;
            this.btnUpload.Text = "📷 Upload";
            // 
            // lblID
            // 
            this.lblID.Location = new System.Drawing.Point(249, 110);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(100, 23);
            this.lblID.TabIndex = 5;
            this.lblID.Text = "Doctor ID:";
            // 
            // txtID
            // 
            this.txtID.BorderRadius = 6;
            this.txtID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtID.DefaultText = "";
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtID.Location = new System.Drawing.Point(353, 107);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtID.Name = "txtID";
            this.txtID.PlaceholderText = "";
            this.txtID.SelectedText = "";
            this.txtID.Size = new System.Drawing.Size(220, 28);
            this.txtID.TabIndex = 6;
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(249, 150);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(100, 23);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Full Name:";
            // 
            // txtName
            // 
            this.txtName.BorderRadius = 6;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.DefaultText = "";
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtName.Location = new System.Drawing.Point(353, 147);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.PlaceholderText = "";
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(220, 28);
            this.txtName.TabIndex = 8;
            // 
            // lblDOB
            // 
            this.lblDOB.Location = new System.Drawing.Point(249, 190);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(100, 23);
            this.lblDOB.TabIndex = 9;
            this.lblDOB.Text = "Date of Birth:";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(353, 187);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(220, 22);
            this.dtpDOB.TabIndex = 10;
            // 
            // lblGender
            // 
            this.lblGender.Location = new System.Drawing.Point(249, 230);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(100, 23);
            this.lblGender.TabIndex = 11;
            this.lblGender.Text = "Gender:";
            // 
            // rbMale
            // 
            this.rbMale.Location = new System.Drawing.Point(353, 227);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(104, 24);
            this.rbMale.TabIndex = 12;
            this.rbMale.Text = "Male";
            // 
            // rbFemale
            // 
            this.rbFemale.Location = new System.Drawing.Point(470, 227);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(104, 24);
            this.rbFemale.TabIndex = 13;
            this.rbFemale.Text = "Female";
            // 
            // lblPhone
            // 
            this.lblPhone.Location = new System.Drawing.Point(251, 268);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(100, 23);
            this.lblPhone.TabIndex = 14;
            this.lblPhone.Text = "Phone:";
            // 
            // txtPhone
            // 
            this.txtPhone.BorderRadius = 6;
            this.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhone.DefaultText = "";
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPhone.Location = new System.Drawing.Point(353, 262);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PlaceholderText = "";
            this.txtPhone.SelectedText = "";
            this.txtPhone.Size = new System.Drawing.Size(220, 28);
            this.txtPhone.TabIndex = 15;
            // 
            // lblEmail
            // 
            this.lblEmail.Location = new System.Drawing.Point(598, 107);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(100, 23);
            this.lblEmail.TabIndex = 16;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderRadius = 6;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmail.Location = new System.Drawing.Point(718, 104);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceholderText = "";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(220, 28);
            this.txtEmail.TabIndex = 17;
            // 
            // lblSpeciality
            // 
            this.lblSpeciality.Location = new System.Drawing.Point(598, 147);
            this.lblSpeciality.Name = "lblSpeciality";
            this.lblSpeciality.Size = new System.Drawing.Size(100, 23);
            this.lblSpeciality.TabIndex = 18;
            this.lblSpeciality.Text = "Speciality:";
            // 
            // txtFee
            // 
            this.txtFee.BorderRadius = 6;
            this.txtFee.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFee.DefaultText = "";
            this.txtFee.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFee.Location = new System.Drawing.Point(718, 144);
            this.txtFee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFee.Name = "txtFee";
            this.txtFee.PlaceholderText = "";
            this.txtFee.SelectedText = "";
            this.txtFee.Size = new System.Drawing.Size(220, 28);
            this.txtFee.TabIndex = 19;
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(598, 187);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(100, 23);
            this.lblStatus.TabIndex = 20;
            this.lblStatus.Text = "Shift:";
            // 
            // shift
            // 
            this.shift.BackColor = System.Drawing.Color.Transparent;
            this.shift.BorderRadius = 6;
            this.shift.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.shift.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.shift.FocusedColor = System.Drawing.Color.Empty;
            this.shift.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.shift.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.shift.ItemHeight = 30;
            this.shift.Items.AddRange(new object[] {
            "Morning",
            "Afternoon",
            "Night"});
            this.shift.Location = new System.Drawing.Point(718, 179);
            this.shift.Name = "shift";
            this.shift.Size = new System.Drawing.Size(180, 36);
            this.shift.TabIndex = 21;
            // 
            // btnSave
            // 
            this.btnSave.BorderRadius = 8;
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(252, 318);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 40);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "💾 Save";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BorderRadius = 8;
            this.btnUpdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(382, 318);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(124, 40);
            this.btnUpdate.TabIndex = 23;
            this.btnUpdate.Text = "✏ Update";
            // 
            // btnDelete
            // 
            this.btnDelete.BorderRadius = 8;
            this.btnDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(532, 318);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 40);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.Text = "🗑 Delete";
            // 
            // lblSearch
            // 
            this.lblSearch.Location = new System.Drawing.Point(60, 380);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(100, 23);
            this.lblSearch.TabIndex = 25;
            this.lblSearch.Text = "🔍 Search:";
            // 
            // txtSearch
            // 
            this.txtSearch.BorderRadius = 6;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.Location = new System.Drawing.Point(186, 377);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(250, 28);
            this.txtSearch.TabIndex = 26;
            // 
            // dgvDoctors
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dgvDoctors.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDoctors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvDoctors.ColumnHeadersHeight = 29;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDoctors.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvDoctors.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDoctors.Location = new System.Drawing.Point(60, 420);
            this.dgvDoctors.Name = "dgvDoctors";
            this.dgvDoctors.RowHeadersVisible = false;
            this.dgvDoctors.RowHeadersWidth = 51;
            this.dgvDoctors.Size = new System.Drawing.Size(840, 220);
            this.dgvDoctors.TabIndex = 27;
            this.dgvDoctors.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDoctors.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDoctors.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDoctors.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDoctors.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDoctors.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvDoctors.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDoctors.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.dgvDoctors.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDoctors.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDoctors.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDoctors.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDoctors.ThemeStyle.HeaderStyle.Height = 29;
            this.dgvDoctors.ThemeStyle.ReadOnly = false;
            this.dgvDoctors.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDoctors.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDoctors.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDoctors.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvDoctors.ThemeStyle.RowsStyle.Height = 22;
            this.dgvDoctors.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.dgvDoctors.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // UC_Doctors
            // 
            this.Controls.Add(this.pnlMain);
            this.Name = "UC_Doctors";
            this.Size = new System.Drawing.Size(980, 700);
            this.pnlMain.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picDoctor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctors)).EndInit();
            this.ResumeLayout(false);

        }

        private Guna2Panel pnlMain;
        private Guna2Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox picDoctor;
        private Guna2Button btnUpload, btnSave, btnUpdate, btnDelete;
        private System.Windows.Forms.Label lblID, lblName, lblPhone, lblEmail, lblDOB, lblGender, lblSpeciality, lblStatus, lblSearch, label1;
        private Guna2TextBox txtID, txtName, txtPhone, txtEmail, txtFee, txtSearch;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.RadioButton rbMale, rbFemale;
        private Guna2ComboBox shift, cmbStatus;
        private Guna2DataGridView dgvDoctors;
    }
}