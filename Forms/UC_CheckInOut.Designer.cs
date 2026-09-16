using Guna.UI2.WinForms;
using System.Drawing;
using System.Windows.Forms;

namespace Hospital_Management_System_SQL.Forms
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabCheckIn = new System.Windows.Forms.TabPage();
            this.txtSearchPatient = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvPatient = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pnlCheckInForm = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAppID = new System.Windows.Forms.Label();
            this.txtAppID = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPatID = new System.Windows.Forms.Label();
            this.txtPatientID = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPatName = new System.Windows.Forms.Label();
            this.txtPatientName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblSpeciality = new System.Windows.Forms.Label();
            this.cmbSpeciality = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblDocName = new System.Windows.Forms.Label();
            this.cmbDoctor = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpAppTime = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblRoom = new System.Windows.Forms.Label();
            this.txtRoom = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblReason = new System.Windows.Forms.Label();
            this.Reason = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnRegister = new Guna.UI2.WinForms.Guna2Button();
            this.tabCheckOut = new System.Windows.Forms.TabPage();
            this.btnHistory = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearchActive = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvActiveVisits = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.pnlBillingSummary = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtReason = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblAppID_CO = new System.Windows.Forms.Label();
            this.txtAppID_CO = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPat_CO = new System.Windows.Forms.Label();
            this.txtPatient_CO = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblDoc_CO = new System.Windows.Forms.Label();
            this.txtDoctor_CO = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblRoom_CO = new System.Windows.Forms.Label();
            this.txtRoom_CO = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTotalLabel = new System.Windows.Forms.Label();
            this.lblFinalCost = new System.Windows.Forms.Label();
            this.btnCompleteVisit = new Guna.UI2.WinForms.Guna2Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl.SuspendLayout();
            this.tabCheckIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatient)).BeginInit();
            this.pnlCheckInForm.SuspendLayout();
            this.tabCheckOut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActiveVisits)).BeginInit();
            this.pnlBillingSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
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
            this.tabControl.Size = new System.Drawing.Size(980, 700);
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
            this.tabControl.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.tabControl.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tabCheckIn
            // 
            this.tabCheckIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.tabCheckIn.Controls.Add(this.txtSearchPatient);
            this.tabCheckIn.Controls.Add(this.dgvPatient);
            this.tabCheckIn.Controls.Add(this.pnlCheckInForm);
            this.tabCheckIn.Location = new System.Drawing.Point(4, 54);
            this.tabCheckIn.Name = "tabCheckIn";
            this.tabCheckIn.Size = new System.Drawing.Size(972, 642);
            this.tabCheckIn.TabIndex = 0;
            this.tabCheckIn.Text = "Patient Check-In";
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
            // dgvPatient
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvPatient.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPatient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPatient.ColumnHeadersHeight = 29;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPatient.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPatient.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPatient.Location = new System.Drawing.Point(20, 75);
            this.dgvPatient.Name = "dgvPatient";
            this.dgvPatient.ReadOnly = true;
            this.dgvPatient.RowHeadersVisible = false;
            this.dgvPatient.RowHeadersWidth = 51;
            this.dgvPatient.Size = new System.Drawing.Size(340, 545);
            this.dgvPatient.TabIndex = 1;
            this.dgvPatient.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPatient.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvPatient.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvPatient.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvPatient.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvPatient.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvPatient.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPatient.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvPatient.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPatient.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvPatient.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvPatient.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPatient.ThemeStyle.HeaderStyle.Height = 29;
            this.dgvPatient.ThemeStyle.ReadOnly = true;
            this.dgvPatient.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPatient.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPatient.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvPatient.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvPatient.ThemeStyle.RowsStyle.Height = 22;
            this.dgvPatient.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPatient.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // pnlCheckInForm
            // 
            this.pnlCheckInForm.BackColor = System.Drawing.Color.Transparent;
            this.pnlCheckInForm.BorderRadius = 20;
            this.pnlCheckInForm.Controls.Add(this.label2);
            this.pnlCheckInForm.Controls.Add(this.lblAppID);
            this.pnlCheckInForm.Controls.Add(this.txtAppID);
            this.pnlCheckInForm.Controls.Add(this.lblPatID);
            this.pnlCheckInForm.Controls.Add(this.txtPatientID);
            this.pnlCheckInForm.Controls.Add(this.lblPatName);
            this.pnlCheckInForm.Controls.Add(this.txtPatientName);
            this.pnlCheckInForm.Controls.Add(this.lblSpeciality);
            this.pnlCheckInForm.Controls.Add(this.cmbSpeciality);
            this.pnlCheckInForm.Controls.Add(this.lblDocName);
            this.pnlCheckInForm.Controls.Add(this.cmbDoctor);
            this.pnlCheckInForm.Controls.Add(this.lblDate);
            this.pnlCheckInForm.Controls.Add(this.dtpAppTime);
            this.pnlCheckInForm.Controls.Add(this.lblRoom);
            this.pnlCheckInForm.Controls.Add(this.txtRoom);
            this.pnlCheckInForm.Controls.Add(this.lblReason);
            this.pnlCheckInForm.Controls.Add(this.Reason);
            this.pnlCheckInForm.Controls.Add(this.btnRegister);
            this.pnlCheckInForm.FillColor = System.Drawing.Color.White;
            this.pnlCheckInForm.Location = new System.Drawing.Point(380, 20);
            this.pnlCheckInForm.Name = "pnlCheckInForm";
            this.pnlCheckInForm.ShadowDecoration.BorderRadius = 20;
            this.pnlCheckInForm.ShadowDecoration.Enabled = true;
            this.pnlCheckInForm.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.pnlCheckInForm.Size = new System.Drawing.Size(570, 600);
            this.pnlCheckInForm.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(174, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 32);
            this.label2.TabIndex = 17;
            this.label2.Text = "Appointment Details";
            // 
            // lblAppID
            // 
            this.lblAppID.AutoSize = true;
            this.lblAppID.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lblAppID.Location = new System.Drawing.Point(42, 95);
            this.lblAppID.Name = "lblAppID";
            this.lblAppID.Size = new System.Drawing.Size(64, 20);
            this.lblAppID.TabIndex = 0;
            this.lblAppID.Text = "App. ID:";
            // 
            // txtAppID
            // 
            this.txtAppID.BorderRadius = 8;
            this.txtAppID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAppID.DefaultText = "";
            this.txtAppID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAppID.Location = new System.Drawing.Point(174, 87);
            this.txtAppID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAppID.Name = "txtAppID";
            this.txtAppID.PlaceholderText = "";
            this.txtAppID.ReadOnly = true;
            this.txtAppID.SelectedText = "";
            this.txtAppID.Size = new System.Drawing.Size(350, 36);
            this.txtAppID.TabIndex = 1;
            // 
            // lblPatID
            // 
            this.lblPatID.AutoSize = true;
            this.lblPatID.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lblPatID.Location = new System.Drawing.Point(42, 140);
            this.lblPatID.Name = "lblPatID";
            this.lblPatID.Size = new System.Drawing.Size(80, 20);
            this.lblPatID.TabIndex = 2;
            this.lblPatID.Text = "Patient ID:";
            // 
            // txtPatientID
            // 
            this.txtPatientID.BorderRadius = 8;
            this.txtPatientID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPatientID.DefaultText = "";
            this.txtPatientID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPatientID.Location = new System.Drawing.Point(174, 132);
            this.txtPatientID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPatientID.Name = "txtPatientID";
            this.txtPatientID.PlaceholderText = "";
            this.txtPatientID.ReadOnly = true;
            this.txtPatientID.SelectedText = "";
            this.txtPatientID.Size = new System.Drawing.Size(350, 36);
            this.txtPatientID.TabIndex = 3;
            // 
            // lblPatName
            // 
            this.lblPatName.AutoSize = true;
            this.lblPatName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lblPatName.Location = new System.Drawing.Point(42, 185);
            this.lblPatName.Name = "lblPatName";
            this.lblPatName.Size = new System.Drawing.Size(54, 20);
            this.lblPatName.TabIndex = 4;
            this.lblPatName.Text = "Name:";
            // 
            // txtPatientName
            // 
            this.txtPatientName.BorderRadius = 8;
            this.txtPatientName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPatientName.DefaultText = "";
            this.txtPatientName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPatientName.Location = new System.Drawing.Point(174, 177);
            this.txtPatientName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.PlaceholderText = "";
            this.txtPatientName.ReadOnly = true;
            this.txtPatientName.SelectedText = "";
            this.txtPatientName.Size = new System.Drawing.Size(350, 36);
            this.txtPatientName.TabIndex = 5;
            // 
            // lblSpeciality
            // 
            this.lblSpeciality.AutoSize = true;
            this.lblSpeciality.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lblSpeciality.Location = new System.Drawing.Point(42, 230);
            this.lblSpeciality.Name = "lblSpeciality";
            this.lblSpeciality.Size = new System.Drawing.Size(78, 20);
            this.lblSpeciality.TabIndex = 6;
            this.lblSpeciality.Text = "Speciality:";
            // 
            // cmbSpeciality
            // 
            this.cmbSpeciality.BackColor = System.Drawing.Color.Transparent;
            this.cmbSpeciality.BorderRadius = 8;
            this.cmbSpeciality.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSpeciality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSpeciality.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbSpeciality.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbSpeciality.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbSpeciality.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbSpeciality.ItemHeight = 30;
            this.cmbSpeciality.Items.AddRange(new object[] {
            "Select speciality"});
            this.cmbSpeciality.Location = new System.Drawing.Point(174, 222);
            this.cmbSpeciality.Name = "cmbSpeciality";
            this.cmbSpeciality.Size = new System.Drawing.Size(350, 36);
            this.cmbSpeciality.TabIndex = 7;
            // 
            // lblDocName
            // 
            this.lblDocName.AutoSize = true;
            this.lblDocName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lblDocName.Location = new System.Drawing.Point(42, 275);
            this.lblDocName.Name = "lblDocName";
            this.lblDocName.Size = new System.Drawing.Size(61, 20);
            this.lblDocName.TabIndex = 8;
            this.lblDocName.Text = "Doctor:";
            // 
            // cmbDoctor
            // 
            this.cmbDoctor.BackColor = System.Drawing.Color.Transparent;
            this.cmbDoctor.BorderRadius = 8;
            this.cmbDoctor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDoctor.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbDoctor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbDoctor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbDoctor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbDoctor.ItemHeight = 30;
            this.cmbDoctor.Location = new System.Drawing.Point(174, 267);
            this.cmbDoctor.Name = "cmbDoctor";
            this.cmbDoctor.Size = new System.Drawing.Size(350, 36);
            this.cmbDoctor.TabIndex = 9;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lblDate.Location = new System.Drawing.Point(42, 320);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(45, 20);
            this.lblDate.TabIndex = 10;
            this.lblDate.Text = "Date:";
            // 
            // dtpAppTime
            // 
            this.dtpAppTime.BorderRadius = 8;
            this.dtpAppTime.Checked = true;
            this.dtpAppTime.FillColor = System.Drawing.Color.White;
            this.dtpAppTime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpAppTime.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpAppTime.Location = new System.Drawing.Point(174, 312);
            this.dtpAppTime.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpAppTime.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpAppTime.Name = "dtpAppTime";
            this.dtpAppTime.Size = new System.Drawing.Size(350, 36);
            this.dtpAppTime.TabIndex = 11;
            this.dtpAppTime.Value = new System.DateTime(2026, 2, 28, 8, 31, 13, 677);
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lblRoom.Location = new System.Drawing.Point(42, 365);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(78, 20);
            this.lblRoom.TabIndex = 12;
            this.lblRoom.Text = "Room No:";
            // 
            // txtRoom
            // 
            this.txtRoom.BorderRadius = 8;
            this.txtRoom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRoom.DefaultText = "";
            this.txtRoom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRoom.Location = new System.Drawing.Point(174, 357);
            this.txtRoom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRoom.Name = "txtRoom";
            this.txtRoom.PlaceholderText = "";
            this.txtRoom.ReadOnly = true;
            this.txtRoom.SelectedText = "";
            this.txtRoom.Size = new System.Drawing.Size(350, 36);
            this.txtRoom.TabIndex = 13;
            // 
            // lblReason
            // 
            this.lblReason.AutoSize = true;
            this.lblReason.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lblReason.Location = new System.Drawing.Point(42, 410);
            this.lblReason.Name = "lblReason";
            this.lblReason.Size = new System.Drawing.Size(62, 20);
            this.lblReason.TabIndex = 14;
            this.lblReason.Text = "Reason:";
            // 
            // Reason
            // 
            this.Reason.BorderRadius = 8;
            this.Reason.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Reason.DefaultText = "";
            this.Reason.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Reason.Location = new System.Drawing.Point(174, 402);
            this.Reason.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Reason.Multiline = true;
            this.Reason.Name = "Reason";
            this.Reason.PlaceholderText = "";
            this.Reason.SelectedText = "";
            this.Reason.Size = new System.Drawing.Size(350, 80);
            this.Reason.TabIndex = 15;
            // 
            // btnRegister
            // 
            this.btnRegister.BorderRadius = 12;
            this.btnRegister.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(102)))));
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(180, 522);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(274, 45);
            this.btnRegister.TabIndex = 16;
            this.btnRegister.Text = "CONFIRM CHECK-IN";
            // 
            // tabCheckOut
            // 
            this.tabCheckOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.tabCheckOut.Controls.Add(this.btnHistory);
            this.tabCheckOut.Controls.Add(this.txtSearchActive);
            this.tabCheckOut.Controls.Add(this.dgvActiveVisits);
            this.tabCheckOut.Controls.Add(this.btnRefresh);
            this.tabCheckOut.Controls.Add(this.pnlBillingSummary);
            this.tabCheckOut.Location = new System.Drawing.Point(4, 54);
            this.tabCheckOut.Name = "tabCheckOut";
            this.tabCheckOut.Size = new System.Drawing.Size(972, 642);
            this.tabCheckOut.TabIndex = 1;
            this.tabCheckOut.Text = "Finalize & Billing";
            // 
            // btnHistory
            // 
            this.btnHistory.BorderRadius = 10;
            this.btnHistory.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnHistory.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnHistory.ForeColor = System.Drawing.Color.White;
            this.btnHistory.Location = new System.Drawing.Point(191, 585);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(165, 45);
            this.btnHistory.TabIndex = 4;
            this.btnHistory.Text = "View History";
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
            this.txtSearchActive.TextChanged += new System.EventHandler(this.txtSearchActive_TextChanged);
            // 
            // dgvActiveVisits
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvActiveVisits.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvActiveVisits.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvActiveVisits.ColumnHeadersHeight = 29;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvActiveVisits.DefaultCellStyle = dataGridViewCellStyle6;
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
            this.dgvActiveVisits.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvActiveVisits.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvActiveVisits.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvActiveVisits.ThemeStyle.HeaderStyle.Height = 29;
            this.dgvActiveVisits.ThemeStyle.ReadOnly = false;
            this.dgvActiveVisits.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvActiveVisits.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvActiveVisits.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvActiveVisits.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvActiveVisits.ThemeStyle.RowsStyle.Height = 22;
            this.dgvActiveVisits.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvActiveVisits.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvActiveVisits.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvActiveVisits_CellContentClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BorderRadius = 10;
            this.btnRefresh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(20, 585);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(165, 45);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // pnlBillingSummary
            // 
            this.pnlBillingSummary.BackColor = System.Drawing.Color.Transparent;
            this.pnlBillingSummary.BorderRadius = 20;
            this.pnlBillingSummary.Controls.Add(this.label1);
            this.pnlBillingSummary.Controls.Add(this.txtReason);
            this.pnlBillingSummary.Controls.Add(this.lblAppID_CO);
            this.pnlBillingSummary.Controls.Add(this.txtAppID_CO);
            this.pnlBillingSummary.Controls.Add(this.lblPat_CO);
            this.pnlBillingSummary.Controls.Add(this.txtPatient_CO);
            this.pnlBillingSummary.Controls.Add(this.lblDoc_CO);
            this.pnlBillingSummary.Controls.Add(this.txtDoctor_CO);
            this.pnlBillingSummary.Controls.Add(this.lblRoom_CO);
            this.pnlBillingSummary.Controls.Add(this.txtRoom_CO);
            this.pnlBillingSummary.Controls.Add(this.lblTotalLabel);
            this.pnlBillingSummary.Controls.Add(this.lblFinalCost);
            this.pnlBillingSummary.Controls.Add(this.btnCompleteVisit);
            this.pnlBillingSummary.FillColor = System.Drawing.Color.White;
            this.pnlBillingSummary.Location = new System.Drawing.Point(380, 20);
            this.pnlBillingSummary.Name = "pnlBillingSummary";
            this.pnlBillingSummary.ShadowDecoration.BorderRadius = 20;
            this.pnlBillingSummary.ShadowDecoration.Enabled = true;
            this.pnlBillingSummary.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.pnlBillingSummary.Size = new System.Drawing.Size(570, 610);
            this.pnlBillingSummary.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.label1.Location = new System.Drawing.Point(30, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Reason:";
            // 
            // txtReason
            // 
            this.txtReason.BorderRadius = 8;
            this.txtReason.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtReason.DefaultText = "";
            this.txtReason.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtReason.Location = new System.Drawing.Point(180, 199);
            this.txtReason.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtReason.Name = "txtReason";
            this.txtReason.PlaceholderText = "";
            this.txtReason.ReadOnly = true;
            this.txtReason.SelectedText = "";
            this.txtReason.Size = new System.Drawing.Size(350, 36);
            this.txtReason.TabIndex = 12;
            this.txtReason.TextChanged += new System.EventHandler(this.txtReason_TextChanged);
            // 
            // lblAppID_CO
            // 
            this.lblAppID_CO.AutoSize = true;
            this.lblAppID_CO.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lblAppID_CO.Location = new System.Drawing.Point(30, 28);
            this.lblAppID_CO.Name = "lblAppID_CO";
            this.lblAppID_CO.Size = new System.Drawing.Size(61, 20);
            this.lblAppID_CO.TabIndex = 0;
            this.lblAppID_CO.Text = "Visit ID:";
            // 
            // txtAppID_CO
            // 
            this.txtAppID_CO.BorderRadius = 8;
            this.txtAppID_CO.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAppID_CO.DefaultText = "";
            this.txtAppID_CO.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAppID_CO.Location = new System.Drawing.Point(180, 20);
            this.txtAppID_CO.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAppID_CO.Name = "txtAppID_CO";
            this.txtAppID_CO.PlaceholderText = "";
            this.txtAppID_CO.ReadOnly = true;
            this.txtAppID_CO.SelectedText = "";
            this.txtAppID_CO.Size = new System.Drawing.Size(350, 36);
            this.txtAppID_CO.TabIndex = 1;
            this.txtAppID_CO.TextChanged += new System.EventHandler(this.txtAppID_CO_TextChanged);
            // 
            // lblPat_CO
            // 
            this.lblPat_CO.AutoSize = true;
            this.lblPat_CO.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lblPat_CO.Location = new System.Drawing.Point(30, 73);
            this.lblPat_CO.Name = "lblPat_CO";
            this.lblPat_CO.Size = new System.Drawing.Size(61, 20);
            this.lblPat_CO.TabIndex = 2;
            this.lblPat_CO.Text = "Patient:";
            // 
            // txtPatient_CO
            // 
            this.txtPatient_CO.BorderRadius = 8;
            this.txtPatient_CO.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPatient_CO.DefaultText = "";
            this.txtPatient_CO.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPatient_CO.Location = new System.Drawing.Point(180, 65);
            this.txtPatient_CO.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPatient_CO.Name = "txtPatient_CO";
            this.txtPatient_CO.PlaceholderText = "";
            this.txtPatient_CO.ReadOnly = true;
            this.txtPatient_CO.SelectedText = "";
            this.txtPatient_CO.Size = new System.Drawing.Size(350, 36);
            this.txtPatient_CO.TabIndex = 3;
            this.txtPatient_CO.TextChanged += new System.EventHandler(this.txtPatient_CO_TextChanged);
            // 
            // lblDoc_CO
            // 
            this.lblDoc_CO.AutoSize = true;
            this.lblDoc_CO.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lblDoc_CO.Location = new System.Drawing.Point(30, 118);
            this.lblDoc_CO.Name = "lblDoc_CO";
            this.lblDoc_CO.Size = new System.Drawing.Size(61, 20);
            this.lblDoc_CO.TabIndex = 4;
            this.lblDoc_CO.Text = "Doctor:";
            // 
            // txtDoctor_CO
            // 
            this.txtDoctor_CO.BorderRadius = 8;
            this.txtDoctor_CO.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDoctor_CO.DefaultText = "";
            this.txtDoctor_CO.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDoctor_CO.Location = new System.Drawing.Point(180, 110);
            this.txtDoctor_CO.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDoctor_CO.Name = "txtDoctor_CO";
            this.txtDoctor_CO.PlaceholderText = "";
            this.txtDoctor_CO.ReadOnly = true;
            this.txtDoctor_CO.SelectedText = "";
            this.txtDoctor_CO.Size = new System.Drawing.Size(350, 36);
            this.txtDoctor_CO.TabIndex = 5;
            this.txtDoctor_CO.TextChanged += new System.EventHandler(this.txtDoctor_CO_TextChanged);
            // 
            // lblRoom_CO
            // 
            this.lblRoom_CO.AutoSize = true;
            this.lblRoom_CO.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lblRoom_CO.Location = new System.Drawing.Point(30, 163);
            this.lblRoom_CO.Name = "lblRoom_CO";
            this.lblRoom_CO.Size = new System.Drawing.Size(53, 20);
            this.lblRoom_CO.TabIndex = 6;
            this.lblRoom_CO.Text = "Room:";
            // 
            // txtRoom_CO
            // 
            this.txtRoom_CO.BorderRadius = 8;
            this.txtRoom_CO.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRoom_CO.DefaultText = "";
            this.txtRoom_CO.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRoom_CO.Location = new System.Drawing.Point(180, 155);
            this.txtRoom_CO.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRoom_CO.Name = "txtRoom_CO";
            this.txtRoom_CO.PlaceholderText = "";
            this.txtRoom_CO.ReadOnly = true;
            this.txtRoom_CO.SelectedText = "";
            this.txtRoom_CO.Size = new System.Drawing.Size(350, 36);
            this.txtRoom_CO.TabIndex = 7;
            this.txtRoom_CO.TextChanged += new System.EventHandler(this.txtRoom_CO_TextChanged);
            // 
            // lblTotalLabel
            // 
            this.lblTotalLabel.AutoSize = true;
            this.lblTotalLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.lblTotalLabel.ForeColor = System.Drawing.Color.Gray;
            this.lblTotalLabel.Location = new System.Drawing.Point(30, 340);
            this.lblTotalLabel.Name = "lblTotalLabel";
            this.lblTotalLabel.Size = new System.Drawing.Size(174, 23);
            this.lblTotalLabel.TabIndex = 8;
            this.lblTotalLabel.Text = "TOTAL AMOUNT DUE";
            // 
            // lblFinalCost
            // 
            this.lblFinalCost.AutoSize = true;
            this.lblFinalCost.Font = new System.Drawing.Font("Segoe UI", 42F, System.Drawing.FontStyle.Bold);
            this.lblFinalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.lblFinalCost.Location = new System.Drawing.Point(20, 360);
            this.lblFinalCost.Name = "lblFinalCost";
            this.lblFinalCost.Size = new System.Drawing.Size(238, 93);
            this.lblFinalCost.TabIndex = 9;
            this.lblFinalCost.Text = "$ 0.00";
            this.lblFinalCost.Click += new System.EventHandler(this.lblFinalCost_Click);
            // 
            // btnCompleteVisit
            // 
            this.btnCompleteVisit.BorderRadius = 12;
            this.btnCompleteVisit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.btnCompleteVisit.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnCompleteVisit.ForeColor = System.Drawing.Color.White;
            this.btnCompleteVisit.Location = new System.Drawing.Point(110, 520);
            this.btnCompleteVisit.Name = "btnCompleteVisit";
            this.btnCompleteVisit.Size = new System.Drawing.Size(350, 50);
            this.btnCompleteVisit.TabIndex = 10;
            this.btnCompleteVisit.Text = "PROCESS PAYMENT";
            this.btnCompleteVisit.Click += new System.EventHandler(this.btnCompleteVisit_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // UC_CheckInOut
            // 
            this.Controls.Add(this.tabControl);
            this.Name = "UC_CheckInOut";
            this.Size = new System.Drawing.Size(980, 700);
            this.tabControl.ResumeLayout(false);
            this.tabCheckIn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatient)).EndInit();
            this.pnlCheckInForm.ResumeLayout(false);
            this.pnlCheckInForm.PerformLayout();
            this.tabCheckOut.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActiveVisits)).EndInit();
            this.pnlBillingSummary.ResumeLayout(false);
            this.pnlBillingSummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        private Guna2TabControl tabControl;
        private TabPage tabCheckIn, tabCheckOut;
        private Guna2TextBox txtSearchPatient, txtSearchActive, txtAppID, txtPatientID, txtPatientName, txtRoom, Reason, txtAppID_CO, txtPatient_CO, txtDoctor_CO, txtRoom_CO;
        private Label lblAppID, lblPatID, lblPatName, lblSpeciality, lblDocName, lblDate, lblRoom, lblReason, lblAppID_CO, lblPat_CO, lblDoc_CO, lblRoom_CO, lblTotalLabel, lblFinalCost;
        private Guna2ComboBox cmbSpeciality, cmbDoctor;
        private Guna2DateTimePicker dtpAppTime;
        private Guna2DataGridView dgvPatient, dgvActiveVisits;
        private Guna2Panel pnlCheckInForm, pnlBillingSummary;
        private Guna2Button btnRegister, btnRefresh, btnCompleteVisit;
        private Label label1;
        private Guna2TextBox txtReason;
        private Guna2Button btnHistory;
        private Label label2;
        private ErrorProvider errorProvider1;
    }
}