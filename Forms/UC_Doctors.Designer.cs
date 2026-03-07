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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMain = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlCard = new Guna.UI2.WinForms.Guna2Panel();
            this.picDoctor = new System.Windows.Forms.PictureBox();
            this.btnUpload = new Guna.UI2.WinForms.Guna2Button();
            this.txtID = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbSpeciality = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtFee = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtRoom = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtpDOB = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.rbMale = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbFemale = new Guna.UI2.WinForms.Guna2RadioButton();
            this.cmbStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.shift = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvDoctors = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2RadioButton1 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.pnlMain.SuspendLayout();
            this.pnlCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDoctor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctors)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.lblTitle);
            this.pnlMain.Controls.Add(this.pnlCard);
            this.pnlMain.Controls.Add(this.txtSearch);
            this.pnlMain.Controls.Add(this.dgvDoctors);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(980, 700);
            this.pnlMain.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblTitle.Location = new System.Drawing.Point(30, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(382, 50);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Doctor Management";
            // 
            // pnlCard
            // 
            this.pnlCard.BackColor = System.Drawing.Color.Transparent;
            this.pnlCard.BorderRadius = 20;
            this.pnlCard.Controls.Add(this.guna2RadioButton1);
            this.pnlCard.Controls.Add(this.picDoctor);
            this.pnlCard.Controls.Add(this.btnUpload);
            this.pnlCard.Controls.Add(this.txtID);
            this.pnlCard.Controls.Add(this.txtName);
            this.pnlCard.Controls.Add(this.txtPhone);
            this.pnlCard.Controls.Add(this.txtEmail);
            this.pnlCard.Controls.Add(this.cmbSpeciality);
            this.pnlCard.Controls.Add(this.txtFee);
            this.pnlCard.Controls.Add(this.txtRoom);
            this.pnlCard.Controls.Add(this.dtpDOB);
            this.pnlCard.Controls.Add(this.rbMale);
            this.pnlCard.Controls.Add(this.rbFemale);
            this.pnlCard.Controls.Add(this.cmbStatus);
            this.pnlCard.Controls.Add(this.shift);
            this.pnlCard.Controls.Add(this.btnSave);
            this.pnlCard.Controls.Add(this.btnUpdate);
            this.pnlCard.Controls.Add(this.btnDelete);
            this.pnlCard.FillColor = System.Drawing.Color.White;
            this.pnlCard.Location = new System.Drawing.Point(30, 85);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.ShadowDecoration.BorderRadius = 20;
            this.pnlCard.ShadowDecoration.Color = System.Drawing.Color.Gainsboro;
            this.pnlCard.ShadowDecoration.Enabled = true;
            this.pnlCard.Size = new System.Drawing.Size(920, 310);
            this.pnlCard.TabIndex = 1;
            // 
            // picDoctor
            // 
            this.picDoctor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.picDoctor.Location = new System.Drawing.Point(25, 33);
            this.picDoctor.Name = "picDoctor";
            this.picDoctor.Size = new System.Drawing.Size(120, 133);
            this.picDoctor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDoctor.TabIndex = 0;
            this.picDoctor.TabStop = false;
            // 
            // btnUpload
            // 
            this.btnUpload.BorderRadius = 10;
            this.btnUpload.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.btnUpload.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnUpload.ForeColor = System.Drawing.Color.DimGray;
            this.btnUpload.Location = new System.Drawing.Point(25, 186);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(120, 30);
            this.btnUpload.TabIndex = 1;
            this.btnUpload.Text = "Change Photo";
            // 
            // txtID
            // 
            this.txtID.BorderRadius = 8;
            this.txtID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtID.DefaultText = "";
            this.txtID.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txtID.Location = new System.Drawing.Point(170, 30);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtID.Name = "txtID";
            this.txtID.PlaceholderText = "ID";
            this.txtID.SelectedText = "";
            this.txtID.Size = new System.Drawing.Size(220, 36);
            this.txtID.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.BorderRadius = 8;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.DefaultText = "";
            this.txtName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txtName.Location = new System.Drawing.Point(170, 80);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.PlaceholderText = "Full Name";
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(220, 36);
            this.txtName.TabIndex = 3;
            // 
            // txtPhone
            // 
            this.txtPhone.BorderRadius = 8;
            this.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhone.DefaultText = "";
            this.txtPhone.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txtPhone.Location = new System.Drawing.Point(420, 80);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PlaceholderText = "Phone";
            this.txtPhone.SelectedText = "";
            this.txtPhone.Size = new System.Drawing.Size(220, 36);
            this.txtPhone.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderRadius = 8;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txtEmail.Location = new System.Drawing.Point(420, 30);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceholderText = "Email";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(220, 36);
            this.txtEmail.TabIndex = 5;
            // 
            // cmbSpeciality
            // 
            this.cmbSpeciality.BackColor = System.Drawing.Color.Transparent;
            this.cmbSpeciality.BorderRadius = 8;
            this.cmbSpeciality.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSpeciality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSpeciality.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.cmbSpeciality.FocusedColor = System.Drawing.Color.Empty;
            this.cmbSpeciality.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbSpeciality.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbSpeciality.ItemHeight = 30;
            this.cmbSpeciality.Items.AddRange(new object[] {
            "Select Speciality",
            "Cardiology",
            "Dermatology",
            "Pediatrics",
            "Neurology",
            "Orthopedics",
            "General Medicine"});
            this.cmbSpeciality.Location = new System.Drawing.Point(170, 130);
            this.cmbSpeciality.Name = "cmbSpeciality";
            this.cmbSpeciality.Size = new System.Drawing.Size(220, 36);
            this.cmbSpeciality.StartIndex = 0;
            this.cmbSpeciality.TabIndex = 6;
            // 
            // txtFee
            // 
            this.txtFee.BorderRadius = 8;
            this.txtFee.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFee.DefaultText = "";
            this.txtFee.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.txtFee.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtFee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txtFee.Location = new System.Drawing.Point(170, 180);
            this.txtFee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFee.Name = "txtFee";
            this.txtFee.PlaceholderText = "Consultation Fee";
            this.txtFee.SelectedText = "";
            this.txtFee.Size = new System.Drawing.Size(220, 36);
            this.txtFee.TabIndex = 7;
            // 
            // txtRoom
            // 
            this.txtRoom.BorderRadius = 8;
            this.txtRoom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRoom.DefaultText = "";
            this.txtRoom.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.txtRoom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txtRoom.Location = new System.Drawing.Point(420, 130);
            this.txtRoom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRoom.Name = "txtRoom";
            this.txtRoom.PlaceholderText = "Room Number";
            this.txtRoom.SelectedText = "";
            this.txtRoom.Size = new System.Drawing.Size(220, 36);
            this.txtRoom.TabIndex = 8;
            // 
            // dtpDOB
            // 
            this.dtpDOB.BorderRadius = 8;
            this.dtpDOB.Checked = true;
            this.dtpDOB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dtpDOB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDOB.Location = new System.Drawing.Point(420, 180);
            this.dtpDOB.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDOB.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(220, 36);
            this.dtpDOB.TabIndex = 9;
            this.dtpDOB.Value = new System.DateTime(2026, 2, 27, 14, 21, 39, 146);
            // 
            // rbMale
            // 
            this.rbMale.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(102)))));
            this.rbMale.CheckedState.BorderThickness = 0;
            this.rbMale.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(102)))));
            this.rbMale.Location = new System.Drawing.Point(675, 135);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(104, 24);
            this.rbMale.TabIndex = 10;
            this.rbMale.Text = "Male";
            this.rbMale.UncheckedState.BorderThickness = 0;
            // 
            // rbFemale
            // 
            this.rbFemale.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(102)))));
            this.rbFemale.CheckedState.BorderThickness = 0;
            this.rbFemale.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(102)))));
            this.rbFemale.Location = new System.Drawing.Point(760, 135);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(104, 24);
            this.rbFemale.TabIndex = 11;
            this.rbFemale.Text = "Female";
            this.rbFemale.UncheckedState.BorderThickness = 0;
            // 
            // cmbStatus
            // 
            this.cmbStatus.BackColor = System.Drawing.Color.Transparent;
            this.cmbStatus.BorderRadius = 8;
            this.cmbStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.cmbStatus.FocusedColor = System.Drawing.Color.Empty;
            this.cmbStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbStatus.ItemHeight = 30;
            this.cmbStatus.Items.AddRange(new object[] {
            "Select Status",
            "Available",
            "Busy",
            "On Leave"});
            this.cmbStatus.Location = new System.Drawing.Point(670, 30);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(220, 36);
            this.cmbStatus.StartIndex = 0;
            this.cmbStatus.TabIndex = 12;
            // 
            // shift
            // 
            this.shift.BackColor = System.Drawing.Color.Transparent;
            this.shift.BorderRadius = 8;
            this.shift.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.shift.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.shift.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.shift.FocusedColor = System.Drawing.Color.Empty;
            this.shift.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.shift.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.shift.ItemHeight = 30;
            this.shift.Items.AddRange(new object[] {
            "Select Shift",
            "Morning",
            "Afternoon",
            "Night"});
            this.shift.Location = new System.Drawing.Point(670, 80);
            this.shift.Name = "shift";
            this.shift.Size = new System.Drawing.Size(220, 36);
            this.shift.StartIndex = 0;
            this.shift.TabIndex = 13;
            // 
            // btnSave
            // 
            this.btnSave.BorderRadius = 10;
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(102)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(540, 240);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 45);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BorderRadius = 10;
            this.btnUpdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(660, 240);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(110, 45);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update";
            // 
            // btnDelete
            // 
            this.btnDelete.BorderRadius = 10;
            this.btnDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(71)))), ((int)(((byte)(87)))));
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(780, 240);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(110, 45);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            // 
            // txtSearch
            // 
            this.txtSearch.BorderRadius = 20;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.Location = new System.Drawing.Point(30, 410);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "🔍 Search doctors...";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(350, 40);
            this.txtSearch.TabIndex = 2;
            // 
            // dgvDoctors
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvDoctors.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDoctors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDoctors.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDoctors.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDoctors.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDoctors.Location = new System.Drawing.Point(30, 465);
            this.dgvDoctors.Name = "dgvDoctors";
            this.dgvDoctors.RowHeadersVisible = false;
            this.dgvDoctors.RowHeadersWidth = 51;
            this.dgvDoctors.RowTemplate.Height = 35;
            this.dgvDoctors.Size = new System.Drawing.Size(920, 205);
            this.dgvDoctors.TabIndex = 3;
            this.dgvDoctors.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDoctors.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDoctors.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDoctors.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDoctors.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDoctors.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvDoctors.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDoctors.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvDoctors.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDoctors.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvDoctors.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.DimGray;
            this.dgvDoctors.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDoctors.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvDoctors.ThemeStyle.ReadOnly = false;
            this.dgvDoctors.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDoctors.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDoctors.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDoctors.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDoctors.ThemeStyle.RowsStyle.Height = 35;
            this.dgvDoctors.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDoctors.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // guna2RadioButton1
            // 
            this.guna2RadioButton1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(102)))));
            this.guna2RadioButton1.CheckedState.BorderThickness = 0;
            this.guna2RadioButton1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(102)))));
            this.guna2RadioButton1.Location = new System.Drawing.Point(670, 180);
            this.guna2RadioButton1.Name = "guna2RadioButton1";
            this.guna2RadioButton1.Size = new System.Drawing.Size(104, 24);
            this.guna2RadioButton1.TabIndex = 17;
            this.guna2RadioButton1.Text = "child";
            this.guna2RadioButton1.UncheckedState.BorderThickness = 0;
            // 
            // UC_Doctors
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.pnlMain);
            this.Name = "UC_Doctors";
            this.Size = new System.Drawing.Size(980, 700);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picDoctor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctors)).EndInit();
            this.ResumeLayout(false);

        }

        private Guna2Panel pnlMain;
        private Guna2Panel pnlCard;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox picDoctor;
        private Guna2Button btnUpload, btnSave, btnUpdate, btnDelete;
        private Guna2TextBox txtID, txtName, txtPhone, txtEmail, txtRoom, txtSearch, txtFee; // Added txtFee
        private Guna2DateTimePicker dtpDOB;
        private Guna2RadioButton rbMale, rbFemale;
        private Guna2ComboBox shift, cmbStatus, cmbSpeciality;
        private Guna2DataGridView dgvDoctors;
        private Guna2RadioButton guna2RadioButton1;
    }
}