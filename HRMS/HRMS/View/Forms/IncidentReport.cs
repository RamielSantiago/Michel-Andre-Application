using HRMS.View;
using HRMS.View.Adapters;
using HRMS.View.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMS
{
    public partial class IncidentReport : UserControl, iIncident
    {
        private DashboardAdapter da;
        public int IncidentID { get { return Convert.ToInt32(iID.Text); } set { iID.Text = value.ToString(); } }
        public DateTime DateOccurred { get { return dateOcc.Value; } set { dateOcc.Value = value; } }
        public DateTime DatePosted { get { return datePost.Value; } set { datePost.Value = value; } }
        public string EmployeesInvolved { get { return employeeinvolved.Text; } set { employeeinvolved.Text = value; } }
        public string TypeOfIncident { get { return incidenttypelist.SelectedItem.ToString(); } set { incidenttypelist.SelectedItem = value; } }
        public string ReportedBy { get { return reportedby.Text; } set { reportedby.Text = value; } }
        public int ReportersID { get { return Convert.ToInt32(reporterid.Text); } set {reporterid.Text = value.ToString(); } }
        public string Specifics { get { return specific.Text; } set { specific.Text = value; } }
        public string Instigator { get { return instigate.Text; } set { instigate.Text = value; } }
        public string Solution { get { return solution.Text; } set { solution.Text = value; } }
        public string Penalty { get { return pen.Text; } set { pen.Text = value; } }
        public string Remarks { get { return remark.Text; } set { remark.Text = value; } }

        public IncidentReport()
        {
            InitializeComponent();
            da = new DashboardAdapter(this);
            incidenttypelist.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void addReportButton_Click(object sender, EventArgs e)
        {
            bool valid = true;
            if (string.IsNullOrWhiteSpace(iID.Text) || string.IsNullOrWhiteSpace(employeeinvolved.Text) || incidenttypelist.SelectedIndex == -1 || string.IsNullOrWhiteSpace(specific.Text) ||
                string.IsNullOrWhiteSpace(reporterid.Text) || string.IsNullOrWhiteSpace(reportedby.Text) || string.IsNullOrWhiteSpace(instigate.Text) || string.IsNullOrWhiteSpace(solution.Text) ||
                string.IsNullOrWhiteSpace(pen.Text))
            {
                valid = false;
                repErrorMsg.Text = repErrorMsg.Text + "Please fill all required(*) fields" + Environment.NewLine;
            }
            else
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
                try
                {
                    var temp = Convert.ToInt32(reporterid.Text);
                }
                catch (FormatException)
                {
                    valid = false;
                    repErrorMsg.Text = repErrorMsg.Text + "Employee ID must consist of numbers only" + Environment.NewLine;

                }
                if(dateOcc.Value > DateTime.Now || datePost.Value > DateTime.Now)
                {
                    MessageBox.Show("Date inputs cannot be past the current date", "Human Resource Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    valid = false;
                }
                if(dateOcc.Value < datePost.Value)
                {
                    repErrorMsg.Text = repErrorMsg.Text + "Date & Time Occured cannot be past the Date & Time Reported" + Environment.NewLine;
                }
                if (valid == true) 
                {
                    da.IP.AddReport();
                    MessageBox.Show("Reported Successfully", "Human Resource Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        public void setIncidentBS(BindingSource bs)
        {
            reports.DataSource = bs;
        }

        private void query_Click(object sender, EventArgs e)
        {
            bool valid = true;
            queryErrorMsg.Text = "";
            if (filter.SelectedIndex == -1 || string.IsNullOrEmpty(querydetail.Text))
            {
                queryErrorMsg.Text = queryErrorMsg.Text + "Please fill all fields to begin search" + Environment.NewLine;
            }
            else
            {
                if (filter.SelectedItem.ToString().Equals("Incident ID"))
                {
                    try
                    {
                        Convert.ToInt32(querydetail.Text);
                    }
                    catch (FormatException)
                    {
                        queryErrorMsg.Text = queryErrorMsg.Text + "Incident IDs are numerical." + Environment.NewLine;
                        valid = false;
                    }
                }
                if (valid == true)
                {
                    int searchResult =  da.IP.SearchReport(filter.SelectedItem.ToString(), querydetail.Text);
                    if (searchResult == -1)
                    {
                        queryErrorMsg.Text = queryErrorMsg.Text + "No Results found." + Environment.NewLine;
                    }
                }
            }
        }

        private void updaterepbutton_Click(object sender, EventArgs e)
        {
            UpdateReport update = new UpdateReport(da);
            update.ShowDialog();
        }

        private void deleterepbutton_Click(object sender, EventArgs e)
        {
            DeleteReport delete = new DeleteReport(da);
            delete.ShowDialog();
        }

        private void repErrorMsg_TextChanged(object sender, EventArgs e)
        {

        }

        private void specific_TextChanged(object sender, EventArgs e)
        {

        }

        private void solution_TextChanged(object sender, EventArgs e)
        {

        }

        private void remark_TextChanged(object sender, EventArgs e)
        {

        }

        private void employeeinvolved_TextChanged(object sender, EventArgs e)
        {

        }

        private void pen_TextChanged(object sender, EventArgs e)
        {

        }

        private void instigate_TextChanged(object sender, EventArgs e)
        {

        }

        private void reporterid_TextChanged(object sender, EventArgs e)
        {

        }

        private void reportedby_TextChanged(object sender, EventArgs e)
        {

        }

        private void iID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void incidenttypelist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void repoLabel_Click(object sender, EventArgs e)
        {

        }

        private void datePost_ValueChanged(object sender, EventArgs e)
        {

        }

        private void postLabel_Click(object sender, EventArgs e)
        {

        }

        private void dateOcc_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void idLabel_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
