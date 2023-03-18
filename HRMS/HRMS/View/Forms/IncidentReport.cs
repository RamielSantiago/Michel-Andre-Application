using HRMS.View.Adapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMS.View
{
    public partial class IncidentReport : Form, iIncident
    {
        private DashboardAdapter da;
        public int IncidentID { get { return Convert.ToInt32(iID.Text); } set { iID.Text = value.ToString(); } }
        public DateTime DateOccurred { get { return dateOcc.Value; } set { dateOcc.Value = value; } }
        public DateTime DatePosted { get { return datePost.Value; } set { datePost.Value = value; } }
        public string EmployeesInvolved { get {return employeeinvolved.Text; } set {employeeinvolved.Text = value; } }
        public string TypeOfIncident { get { return incidenttypelist.SelectedItem.ToString(); } set {incidenttypelist.SelectedItem = value; } }
        public string Specifics { get { return specific.Text; } set { specific.Text = value; } }
        public string Instigator { get { return instigate.Text; } set{ instigate.Text = value; } }
        public string Solution { get { return solution.Text; } set { solution.Text = value; } }
        public string Penalty { get { return pen.Text; } set { pen.Text = value; } }
        public string Remarks { get {return remark.Text; } set { remark.Text = value; } }

        public IncidentReport()
        {
            da = new DashboardAdapter(this);
            InitializeComponent();
        }
        private void IncidentReport_Load_1(object sender, EventArgs e)
        {
            repErrorMsg.ReadOnly = true;
            // TODO: This line of code loads data into the 'hRMSDBDataSet.IncidentReports' table. You can move, or remove it, as needed.
            this.incidentReportsTableAdapter.Fill(this.hRMSDBDataSet.IncidentReports);

        }

        private void addreportpage_Click(object sender, EventArgs e)
        {

        }

        private void filter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void setIncidentBS(BindingSource bs)
        {
            incidentlist.DataSource = bs;
        }

        private void addReportButton_Click(object sender, EventArgs e)
        {
            bool valid = true;
            if(string.IsNullOrEmpty(iID.Text) || string.IsNullOrEmpty(employeeinvolved.Text) || incidenttypelist.SelectedIndex == -1 || string.IsNullOrEmpty(specific.Text) ||
                string.IsNullOrEmpty(instigate.Text) || string.IsNullOrEmpty(solution.Text) || string.IsNullOrEmpty(pen.Text))
            {
                valid = false;
                repErrorMsg.Text = repErrorMsg.Text + "Please fill all fields" + Environment.NewLine;
            } else
            {
                try
                {
                    var temp = Convert.ToInt32(iID.Text);
                }
                catch (FormatException)
                {
                    valid = false;
                    repErrorMsg.Text = repErrorMsg.Text + "Incident ID must consist of numbers only" + Environment.NewLine;

                }
                if(valid) { }
                {
                    MessageBox.Show("User Registered Successfully", "Human Resource Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
