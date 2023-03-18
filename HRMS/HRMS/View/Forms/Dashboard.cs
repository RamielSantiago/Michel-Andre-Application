using HRMS.View.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMS.View
{
    public partial class Dashboard : Form
    {
        private IncidentReport IR;
        private CompanyRandR crr;
        private Panel activityPanel;
        private HRMSLogin loginform;
        private HRMSRegister employee;
        public Dashboard(string Username, int AccessLevel, HRMSLogin loginform)
        {
            this.loginform = loginform;
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            activityPanel = ActivityPanel;  //Stores local reference to Dashboard Panel

            IR = new IncidentReport(); // Stores local reference to Incident Report
            employee = new HRMSRegister(this);
            crr = new CompanyRandR(); // Stores local reference to CompanyRandR 
            crr.FormBorderStyle = FormBorderStyle.Fixed3D;
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            loginform.Show();
            this.Close();
        }

        private void Incidents_Click(object sender, EventArgs e)
        {

        }

        private void RuleButton_Click(object sender, EventArgs e)
        {
            IR.Hide(); //Hides Incident Reports
            employee.Hide();
            crr.TopLevel = false;
            activityPanel.Controls.Add(crr);
            crr.Dock = DockStyle.Fill;
            crr.Show();
            
        }

        private void Incidents_Click_1(object sender, EventArgs e)
        {
            crr.Hide();
            employee.Hide();
            IR.FormBorderStyle = FormBorderStyle.None; //Form Border; Cosmetic Only
            IR.TopLevel = false;
            crr.Dock = DockStyle.Fill;
            activityPanel.Controls.Add(IR);
            IR.Show();
        }

        private void Company_Click(object sender, EventArgs e)
        {

        }

        private void employeeButton_Click(object sender, EventArgs e)
        {
            crr.Hide();
            IR.Hide();
            employee.FormBorderStyle = FormBorderStyle.None; //Form Border; Cosmetic Only
            employee.TopLevel = false;
            activityPanel.Controls.Add(employee);
            employee.Show();
        }
    }
}
