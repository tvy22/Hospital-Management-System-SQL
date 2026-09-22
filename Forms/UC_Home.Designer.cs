namespace Hospital_Management_System_SQL.Forms
{
    partial class UC_Home
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblHelp = new System.Windows.Forms.Label();
            this.picHero = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picHero)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblTitle.Location = new System.Drawing.Point(47, 40);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(591, 54);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Hospital Management System";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.Gray;
            this.lblSubtitle.Location = new System.Drawing.Point(55, 95);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(328, 28);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Main control panel for hospital staff.";
            // 
            // lblHelp
            // 
            this.lblHelp.AutoSize = true;
            this.lblHelp.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.lblHelp.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblHelp.Location = new System.Drawing.Point(55, 570);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(644, 23);
            this.lblHelp.TabIndex = 3;
            this.lblHelp.Text = "Use the navigation menu on the left to manage doctors, patients, or process check" +
    "-ins.";
            // 
            // picHero
            // 
            this.picHero.Image = global::Hospital_Management_System_SQL.Properties.Resources.hospital3;
            this.picHero.Location = new System.Drawing.Point(50, 150);
            this.picHero.Name = "picHero";
            this.picHero.Size = new System.Drawing.Size(850, 400);
            this.picHero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHero.TabIndex = 2;
            this.picHero.TabStop = false;
            // 
            // UC_Home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.lblHelp);
            this.Controls.Add(this.picHero);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.lblTitle);
            this.Name = "UC_Home";
            this.Size = new System.Drawing.Size(980, 700);
            ((System.ComponentModel.ISupportInitialize)(this.picHero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.PictureBox picHero;
        private System.Windows.Forms.Label lblHelp;

        #endregion
    }
}
