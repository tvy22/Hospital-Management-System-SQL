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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabCheckIn = new System.Windows.Forms.TabPage();
            this.txtSearchPatient = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvPatientSearch = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pnlCheckInForm = new Guna.UI2.WinForms.Guna2Panel();
            this.txtAppID = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPatientID_CI = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPatientName_CI = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbDoctorID = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtDoctorName = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtpAppTime = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cmbStatus_CI = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtRoom_CI = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtReason_CI = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnRegisterAppointment = new Guna.UI2.WinForms.Guna2Button();
            this.tabCheckOut = new System.Windows.Forms.TabPage();
            this.splitCheckOut = new System.Windows.Forms.SplitContainer();
            this.txtSearchActive = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvActiveVisits = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnFinalizeBillLeft = new Guna.UI2.WinForms.Guna2Button();
            this.pnlBillingSummary = new Guna.UI2.WinForms.Guna2Panel();
            this.txtAppID_CO = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPatient_CO = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDoctor_CO = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtRoom_CO = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTotalLabel = new System.Windows.Forms.Label();
            this.lblFinalCost = new System.Windows.Forms.Label();
            this.btnCompleteVisit = new Guna.UI2.WinForms.Guna2Button();
            this.tabControl.SuspendLayout();
            this.tabCheckIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientSearch)).BeginInit();
            this.pnlCheckInForm.SuspendLayout();
            this.tabCheckOut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitCheckOut)).BeginInit();
            this.splitCheckOut.Panel1.SuspendLayout();
            this.splitCheckOut.Panel2.SuspendLayout();
            this.splitCheckOut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActiveVisits)).BeginInit();
            this.pnlBillingSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabCheckIn);
            this.tabControl.Controls.Add(this.tabCheckOut);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.ItemSize = new System.Drawing.Size(485, 50);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(980, 750);
            this.tabControl.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tabControl.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tabControl.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabControl.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tabControl.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tabControl.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tabControl.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.tabControl.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabControl.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.tabControl.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tabControl.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tabControl.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(102)))));
            this.tabControl.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabControl.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tabControl.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.tabControl.TabButtonSize = new System.Drawing.Size(485, 50);
            this.tabControl.TabIndex = 0;
            this.tabControl.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tabControl.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tabCheckIn
            // 
            this.tabCheckIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.tabCheckIn.Controls.Add(this.txtSearchPatient);
            this.tabCheckIn.Controls.Add(this.dgvPatientSearch);
            this.tabCheckIn.Controls.Add(this.pnlCheckInForm);
            this.tabCheckIn.Location = new System.Drawing.Point(4, 54);
            this.tabCheckIn.Name = "tabCheckIn";
            this.tabCheckIn.Size = new System.Drawing.Size(972, 692);
            this.tabCheckIn.TabIndex = 0;
            this.tabCheckIn.Text = "Appointment Registration";
            // 
            // txtSearchPatient
            // 
            this.txtSearchPatient.BorderRadius = 15;
            this.txtSearchPatient.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchPatient.DefaultText = "";
            this.txtSearchPatient.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearchPatient.Location = new System.Drawing.Point(20, 20);
            this.txtSearchPatient.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearchPatient.Name = "txtSearchPatient";
            this.txtSearchPatient.PlaceholderText = "🔍 Search Patient...";
            this.txtSearchPatient.SelectedText = "";
            this.txtSearchPatient.Size = new System.Drawing.Size(340, 40);
            this.txtSearchPatient.TabIndex = 0;
            // 
            // dgvPatientSearch
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.dgvPatientSearch.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPatientSearch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvPatientSearch.ColumnHeadersHeight = 29;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPatientSearch.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvPatientSearch.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPatientSearch.Location = new System.Drawing.Point(20, 75);
            this.dgvPatientSearch.Name = "dgvPatientSearch";
            this.dgvPatientSearch.RowHeadersVisible = false;
            this.dgvPatientSearch.RowHeadersWidth = 51;
            this.dgvPatientSearch.Size = new System.Drawing.Size(340, 580);
            this.dgvPatientSearch.TabIndex = 1;
            this.dgvPatientSearch.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPatientSearch.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvPatientSearch.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvPatientSearch.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvPatientSearch.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvPatientSearch.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvPatientSearch.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPatientSearch.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvPatientSearch.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPatientSearch.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPatientSearch.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvPatientSearch.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPatientSearch.ThemeStyle.HeaderStyle.Height = 29;
            this.dgvPatientSearch.ThemeStyle.ReadOnly = false;
            this.dgvPatientSearch.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPatientSearch.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPatientSearch.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPatientSearch.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvPatientSearch.ThemeStyle.RowsStyle.Height = 22;
            this.dgvPatientSearch.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPatientSearch.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // pnlCheckInForm
            // 
            this.pnlCheckInForm.BackColor = System.Drawing.Color.Transparent;
            this.pnlCheckInForm.BorderRadius = 20;
            this.pnlCheckInForm.Controls.Add(this.txtAppID);
            this.pnlCheckInForm.Controls.Add(this.txtPatientID_CI);
            this.pnlCheckInForm.Controls.Add(this.txtPatientName_CI);
            this.pnlCheckInForm.Controls.Add(this.cmbDoctorID);
            this.pnlCheckInForm.Controls.Add(this.txtDoctorName);
            this.pnlCheckInForm.Controls.Add(this.dtpAppTime);
            this.pnlCheckInForm.Controls.Add(this.cmbStatus_CI);
            this.pnlCheckInForm.Controls.Add(this.txtRoom_CI);
            this.pnlCheckInForm.Controls.Add(this.txtReason_CI);
            this.pnlCheckInForm.Controls.Add(this.btnRegisterAppointment);
            this.pnlCheckInForm.Location = new System.Drawing.Point(380, 20);
            this.pnlCheckInForm.Name = "pnlCheckInForm";
            this.pnlCheckInForm.ShadowDecoration.Enabled = true;
            this.pnlCheckInForm.Size = new System.Drawing.Size(565, 635);
            this.pnlCheckInForm.TabIndex = 2;
            // 
            // txtAppID
            // 
            this.txtAppID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAppID.DefaultText = "";
            this.txtAppID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAppID.Location = new System.Drawing.Point(30, 30);
            this.txtAppID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAppID.Name = "txtAppID";
            this.txtAppID.PlaceholderText = "";
            this.txtAppID.SelectedText = "";
            this.txtAppID.Size = new System.Drawing.Size(500, 36);
            this.txtAppID.TabIndex = 0;
            // 
            // txtPatientID_CI
            // 
            this.txtPatientID_CI.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPatientID_CI.DefaultText = "";
            this.txtPatientID_CI.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPatientID_CI.Location = new System.Drawing.Point(30, 85);
            this.txtPatientID_CI.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPatientID_CI.Name = "txtPatientID_CI";
            this.txtPatientID_CI.PlaceholderText = "";
            this.txtPatientID_CI.SelectedText = "";
            this.txtPatientID_CI.Size = new System.Drawing.Size(500, 36);
            this.txtPatientID_CI.TabIndex = 1;
            // 
            // txtPatientName_CI
            // 
            this.txtPatientName_CI.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPatientName_CI.DefaultText = "";
            this.txtPatientName_CI.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPatientName_CI.Location = new System.Drawing.Point(30, 140);
            this.txtPatientName_CI.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPatientName_CI.Name = "txtPatientName_CI";
            this.txtPatientName_CI.PlaceholderText = "";
            this.txtPatientName_CI.SelectedText = "";
            this.txtPatientName_CI.Size = new System.Drawing.Size(500, 36);
            this.txtPatientName_CI.TabIndex = 2;
            // 
            // cmbDoctorID
            // 
            this.cmbDoctorID.BackColor = System.Drawing.Color.Transparent;
            this.cmbDoctorID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbDoctorID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDoctorID.FocusedColor = System.Drawing.Color.Empty;
            this.cmbDoctorID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbDoctorID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbDoctorID.ItemHeight = 30;
            this.cmbDoctorID.Location = new System.Drawing.Point(30, 195);
            this.cmbDoctorID.Name = "cmbDoctorID";
            this.cmbDoctorID.Size = new System.Drawing.Size(500, 36);
            this.cmbDoctorID.TabIndex = 3;
            // 
            // txtDoctorName
            // 
            this.txtDoctorName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDoctorName.DefaultText = "";
            this.txtDoctorName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDoctorName.Location = new System.Drawing.Point(30, 250);
            this.txtDoctorName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDoctorName.Name = "txtDoctorName";
            this.txtDoctorName.PlaceholderText = "";
            this.txtDoctorName.SelectedText = "";
            this.txtDoctorName.Size = new System.Drawing.Size(500, 36);
            this.txtDoctorName.TabIndex = 4;
            // 
            // dtpAppTime
            // 
            this.dtpAppTime.Checked = true;
            this.dtpAppTime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpAppTime.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpAppTime.Location = new System.Drawing.Point(30, 305);
            this.dtpAppTime.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpAppTime.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpAppTime.Name = "dtpAppTime";
            this.dtpAppTime.Size = new System.Drawing.Size(500, 36);
            this.dtpAppTime.TabIndex = 5;
            this.dtpAppTime.Value = new System.DateTime(2026, 2, 27, 22, 50, 22, 407);
            // 
            // cmbStatus_CI
            // 
            this.cmbStatus_CI.BackColor = System.Drawing.Color.Transparent;
            this.cmbStatus_CI.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbStatus_CI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus_CI.FocusedColor = System.Drawing.Color.Empty;
            this.cmbStatus_CI.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbStatus_CI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbStatus_CI.ItemHeight = 30;
            this.cmbStatus_CI.Location = new System.Drawing.Point(30, 360);
            this.cmbStatus_CI.Name = "cmbStatus_CI";
            this.cmbStatus_CI.Size = new System.Drawing.Size(500, 36);
            this.cmbStatus_CI.TabIndex = 6;
            // 
            // txtRoom_CI
            // 
            this.txtRoom_CI.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRoom_CI.DefaultText = "";
            this.txtRoom_CI.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRoom_CI.Location = new System.Drawing.Point(30, 415);
            this.txtRoom_CI.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRoom_CI.Name = "txtRoom_CI";
            this.txtRoom_CI.PlaceholderText = "";
            this.txtRoom_CI.SelectedText = "";
            this.txtRoom_CI.Size = new System.Drawing.Size(500, 36);
            this.txtRoom_CI.TabIndex = 7;
            // 
            // txtReason_CI
            // 
            this.txtReason_CI.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtReason_CI.DefaultText = "";
            this.txtReason_CI.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtReason_CI.Location = new System.Drawing.Point(30, 470);
            this.txtReason_CI.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtReason_CI.Multiline = true;
            this.txtReason_CI.Name = "txtReason_CI";
            this.txtReason_CI.PlaceholderText = "";
            this.txtReason_CI.SelectedText = "";
            this.txtReason_CI.Size = new System.Drawing.Size(500, 60);
            this.txtReason_CI.TabIndex = 8;
            // 
            // btnRegisterAppointment
            // 
            this.btnRegisterAppointment.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(102)))));
            this.btnRegisterAppointment.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRegisterAppointment.ForeColor = System.Drawing.Color.White;
            this.btnRegisterAppointment.Location = new System.Drawing.Point(30, 560);
            this.btnRegisterAppointment.Name = "btnRegisterAppointment";
            this.btnRegisterAppointment.Size = new System.Drawing.Size(500, 45);
            this.btnRegisterAppointment.TabIndex = 9;
            this.btnRegisterAppointment.Text = "Register Appointment";
            // 
            // tabCheckOut
            // 
            this.tabCheckOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.tabCheckOut.Controls.Add(this.splitCheckOut);
            this.tabCheckOut.Location = new System.Drawing.Point(4, 54);
            this.tabCheckOut.Name = "tabCheckOut";
            this.tabCheckOut.Size = new System.Drawing.Size(972, 692);
            this.tabCheckOut.TabIndex = 1;
            this.tabCheckOut.Text = "Finalize & Billing";
            // 
            // splitCheckOut
            // 
            this.splitCheckOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitCheckOut.IsSplitterFixed = true;
            this.splitCheckOut.Location = new System.Drawing.Point(0, 0);
            this.splitCheckOut.Name = "splitCheckOut";
            this.splitCheckOut.Size = new System.Drawing.Size(972, 692);
            this.splitCheckOut.SplitterDistance = 380; // ✅ MATCHES APPOINTMENT TAB
            this.splitCheckOut.TabIndex = 0;
            // 
            // splitCheckOut.Panel1
            // 
            this.splitCheckOut.Panel1.Controls.Add(this.txtSearchActive);
            this.splitCheckOut.Panel1.Controls.Add(this.dgvActiveVisits);
            this.splitCheckOut.Panel1.Controls.Add(this.btnFinalizeBillLeft);
            // 
            // splitCheckOut.Panel2
            // 
            this.splitCheckOut.Panel2.Controls.Add(this.pnlBillingSummary);
            this.splitCheckOut.Size = new System.Drawing.Size(972, 692);
            this.splitCheckOut.SplitterDistance = 380;
            this.splitCheckOut.TabIndex = 0;
            // 
            // txtSearchActive
            // 
            this.txtSearchActive.BorderRadius = 15;
            this.txtSearchActive.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchActive.DefaultText = "";
            this.txtSearchActive.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearchActive.Location = new System.Drawing.Point(20, 20);
            this.txtSearchActive.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearchActive.Name = "txtSearchActive";
            this.txtSearchActive.PlaceholderText = "🔍 Search Active Visits...";
            this.txtSearchActive.SelectedText = "";
            this.txtSearchActive.Size = new System.Drawing.Size(340, 40);
            this.txtSearchActive.TabIndex = 0;
            // 
            // dgvActiveVisits
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dgvActiveVisits.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvActiveVisits.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvActiveVisits.ColumnHeadersHeight = 29;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvActiveVisits.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvActiveVisits.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvActiveVisits.Location = new System.Drawing.Point(20, 75);
            this.dgvActiveVisits.Name = "dgvActiveVisits";
            this.dgvActiveVisits.RowHeadersVisible = false;
            this.dgvActiveVisits.RowHeadersWidth = 51;
            this.dgvActiveVisits.Size = new System.Drawing.Size(340, 500);
            this.dgvActiveVisits.TabIndex = 1;
            this.dgvActiveVisits.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvActiveVisits.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvActiveVisits.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvActiveVisits.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvActiveVisits.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvActiveVisits.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvActiveVisits.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvActiveVisits.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvActiveVisits.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvActiveVisits.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvActiveVisits.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvActiveVisits.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvActiveVisits.ThemeStyle.HeaderStyle.Height = 29;
            this.dgvActiveVisits.ThemeStyle.ReadOnly = false;
            this.dgvActiveVisits.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvActiveVisits.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvActiveVisits.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvActiveVisits.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvActiveVisits.ThemeStyle.RowsStyle.Height = 22;
            this.dgvActiveVisits.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvActiveVisits.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btnFinalizeBillLeft
            // 
            this.btnFinalizeBillLeft.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnFinalizeBillLeft.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFinalizeBillLeft.ForeColor = System.Drawing.Color.White;
            this.btnFinalizeBillLeft.Location = new System.Drawing.Point(20, 590);
            this.btnFinalizeBillLeft.Name = "btnFinalizeBillLeft";
            this.btnFinalizeBillLeft.Size = new System.Drawing.Size(340, 45);
            this.btnFinalizeBillLeft.TabIndex = 2;
            this.btnFinalizeBillLeft.Text = "Finalize Selection";
            // 
            // pnlBillingSummary
            // 
            this.pnlBillingSummary.BackColor = System.Drawing.Color.Transparent;
            this.pnlBillingSummary.BorderRadius = 20;
            this.pnlBillingSummary.Controls.Add(this.txtAppID_CO);
            this.pnlBillingSummary.Controls.Add(this.txtPatient_CO);
            this.pnlBillingSummary.Controls.Add(this.txtDoctor_CO);
            this.pnlBillingSummary.Controls.Add(this.txtRoom_CO);
            this.pnlBillingSummary.Controls.Add(this.lblTotalLabel);
            this.pnlBillingSummary.Controls.Add(this.lblFinalCost);
            this.pnlBillingSummary.Controls.Add(this.btnCompleteVisit);
            this.pnlBillingSummary.Location = new System.Drawing.Point(20, 20);
            this.pnlBillingSummary.Name = "pnlBillingSummary";
            this.pnlBillingSummary.ShadowDecoration.Enabled = true;
            this.pnlBillingSummary.Size = new System.Drawing.Size(565, 635);
            this.pnlBillingSummary.TabIndex = 0;
            // 
            // txtAppID_CO
            // 
            this.txtAppID_CO.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAppID_CO.DefaultText = "";
            this.txtAppID_CO.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAppID_CO.Location = new System.Drawing.Point(30, 30);
            this.txtAppID_CO.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAppID_CO.Name = "txtAppID_CO";
            this.txtAppID_CO.PlaceholderText = "";
            this.txtAppID_CO.SelectedText = "";
            this.txtAppID_CO.Size = new System.Drawing.Size(500, 36);
            this.txtAppID_CO.TabIndex = 0;
            // 
            // txtPatient_CO
            // 
            this.txtPatient_CO.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPatient_CO.DefaultText = "";
            this.txtPatient_CO.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPatient_CO.Location = new System.Drawing.Point(30, 85);
            this.txtPatient_CO.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPatient_CO.Name = "txtPatient_CO";
            this.txtPatient_CO.PlaceholderText = "";
            this.txtPatient_CO.SelectedText = "";
            this.txtPatient_CO.Size = new System.Drawing.Size(500, 36);
            this.txtPatient_CO.TabIndex = 1;
            // 
            // txtDoctor_CO
            // 
            this.txtDoctor_CO.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDoctor_CO.DefaultText = "";
            this.txtDoctor_CO.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDoctor_CO.Location = new System.Drawing.Point(30, 140);
            this.txtDoctor_CO.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDoctor_CO.Name = "txtDoctor_CO";
            this.txtDoctor_CO.PlaceholderText = "";
            this.txtDoctor_CO.SelectedText = "";
            this.txtDoctor_CO.Size = new System.Drawing.Size(500, 36);
            this.txtDoctor_CO.TabIndex = 2;
            // 
            // txtRoom_CO
            // 
            this.txtRoom_CO.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRoom_CO.DefaultText = "";
            this.txtRoom_CO.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRoom_CO.Location = new System.Drawing.Point(30, 195);
            this.txtRoom_CO.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRoom_CO.Name = "txtRoom_CO";
            this.txtRoom_CO.PlaceholderText = "";
            this.txtRoom_CO.SelectedText = "";
            this.txtRoom_CO.Size = new System.Drawing.Size(500, 36);
            this.txtRoom_CO.TabIndex = 3;
            // 
            // lblTotalLabel
            // 
            this.lblTotalLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalLabel.Location = new System.Drawing.Point(30, 430);
            this.lblTotalLabel.Name = "lblTotalLabel";
            this.lblTotalLabel.Size = new System.Drawing.Size(100, 23);
            this.lblTotalLabel.TabIndex = 4;
            this.lblTotalLabel.Text = "TOTAL DUE:";
            // 
            // lblFinalCost
            // 
            this.lblFinalCost.AutoSize = true;
            this.lblFinalCost.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
            this.lblFinalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.lblFinalCost.Location = new System.Drawing.Point(30, 460);
            this.lblFinalCost.Name = "lblFinalCost";
            this.lblFinalCost.Size = new System.Drawing.Size(191, 81);
            this.lblFinalCost.TabIndex = 5;
            this.lblFinalCost.Text = "$0.00";
            // 
            // btnCompleteVisit
            // 
            this.btnCompleteVisit.BorderRadius = 10;
            this.btnCompleteVisit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.btnCompleteVisit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCompleteVisit.ForeColor = System.Drawing.Color.White;
            this.btnCompleteVisit.Location = new System.Drawing.Point(30, 560);
            this.btnCompleteVisit.Name = "btnCompleteVisit";
            this.btnCompleteVisit.Size = new System.Drawing.Size(500, 50);
            this.btnCompleteVisit.TabIndex = 6;
            this.btnCompleteVisit.Text = "Complete Visit & Print Receipt";
            // 
            // UC_CheckInOut
            // 
            this.Controls.Add(this.tabControl);
            this.Name = "UC_CheckInOut";
            this.Size = new System.Drawing.Size(980, 750);
            this.tabControl.ResumeLayout(false);
            this.tabCheckIn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientSearch)).EndInit();
            this.pnlCheckInForm.ResumeLayout(false);
            this.tabCheckOut.ResumeLayout(false);
            this.splitCheckOut.Panel1.ResumeLayout(false);
            this.splitCheckOut.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitCheckOut)).EndInit();
            this.splitCheckOut.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActiveVisits)).EndInit();
            this.pnlBillingSummary.ResumeLayout(false);
            this.pnlBillingSummary.PerformLayout();
            this.ResumeLayout(false);

        }

        private Guna2TabControl tabControl;
        private System.Windows.Forms.TabPage tabCheckIn, tabCheckOut;
        private Guna2TextBox txtSearchPatient, txtSearchActive, txtAppID, txtPatientID_CI, txtPatientName_CI, txtDoctorName, txtRoom_CI, txtReason_CI;
        private Guna2ComboBox cmbDoctorID, cmbStatus_CI;
        private Guna2DateTimePicker dtpAppTime;
        private Guna2DataGridView dgvPatientSearch, dgvActiveVisits;
        private Guna2Panel pnlCheckInForm, pnlBillingSummary;
        private Guna2Button btnRegisterAppointment, btnFinalizeBillLeft, btnCompleteVisit;
        private System.Windows.Forms.SplitContainer splitCheckOut;

        private Guna2TextBox txtAppID_CO, txtPatient_CO, txtDoctor_CO, txtRoom_CO;
        private System.Windows.Forms.Label lblTotalLabel, lblFinalCost;
    }
}