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
    public partial class MainDashboard : Form
    {
        public MainDashboard()
        {
            InitializeComponent();
            LoadHomeView(); // We moved the design logic to a separate method to keep it clean
        }

        private void LoadHomeView()
        {
            pnlContent.Controls.Clear();
            UC_Home home = new UC_Home();
            home.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(home);
        }

        private void btnDoctors_Click(object sender, EventArgs e)
        {
            // 1. Clear the current screen (remove UC_Home or whatever is there)
            pnlContent.Controls.Clear();

            // 2. Create an instance of your new Doctor screen
            UC_Doctors ucDoctors = new UC_Doctors();

            // 3. Make it big enough to fill the whole panel
            ucDoctors.Dock = DockStyle.Fill;

            // 4. Add it to the panel and bring it to the front
            pnlContent.Controls.Add(ucDoctors);
            ucDoctors.BringToFront();
        }

        private void btnPatients_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            UC_Patients ucPatients = new UC_Patients();
            ucPatients.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(ucPatients);
            ucPatients.BringToFront();
        }

        private void btnAppointments_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            UC_CheckInOut ucCheckInOut = new UC_CheckInOut();
            ucCheckInOut.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(ucCheckInOut);
            ucCheckInOut.BringToFront();
        }
    }
}