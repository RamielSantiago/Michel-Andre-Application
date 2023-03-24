using HRMS.Model;
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
using System.Xml.Linq;

namespace HRMS.View.Forms
{
    public partial class UpdateReport : Form
    {
        DashboardAdapter da;
        public UpdateReport(DashboardAdapter da)
        {
            InitializeComponent();
            this.da = da;
            incidenttypelist.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void UpdateReport_Load(object sender, EventArgs e)
        {

        }

        private void updateReportButton_Click(object sender, EventArgs e)
        {
            upErrorMsg.Text = "";
            bool valid = true;
            if (string.IsNullOrWhiteSpace(iID.Text))
            {
                upErrorMsg.Text = upErrorMsg.Text + "Incident ID is required to search record to update" + Environment.NewLine;
                valid = false;
            }
            else
            {
                try
                {
                    Convert.ToInt32(iID.Text);
                }
                catch (FormatException)
                {
                    upErrorMsg.Text = upErrorMsg.Text + "Incident IDs are numerical" + Environment.NewLine;
                    valid= false;
                }
                try
                {
                    if (!string.IsNullOrWhiteSpace(reporterid.Text)) {
                        Convert.ToInt32(reporterid.Text);
                    }
                }
                catch (FormatException)
                {
                    upErrorMsg.Text = upErrorMsg.Text + "Employee IDs are numerical" + Environment.NewLine;
                    valid= false;
                }
                if (valid)
                {
                    var update = new IncidentReportModel();
                    update.IncidentID = Convert.ToInt32(iID.Text);
                    if(incidenttypelist.SelectedIndex == -1 || incidenttypelist.SelectedIndex == 6)
                    {
                        update.TypeOfIncident = "-1";
                    }
                    else
                    {
                        update.TypeOfIncident = incidenttypelist.SelectedItem.ToString();
                    }
                    if (string.IsNullOrWhiteSpace(reportedby.Text))
                    {
                        update.ReportedBy = "-1";
                    }
                    else
                    {
                        update.ReportedBy = reportedby.Text;
                    }
                    if (string.IsNullOrWhiteSpace(reporterid.Text))
                    {
                        update.ReportersID = -1;
                    }
                    else
                    {
                        update.ReportersID = Convert.ToInt32(reporterid.Text);
                    }
                    if (string.IsNullOrWhiteSpace(instigate.Text))
                    {
                        update.Instigator = "-1";
                    }
                    else
                    {
                        update.Instigator = instigate.Text;
                    }
                    if (string.IsNullOrWhiteSpace(pen.Text))
                    {
                        update.Penalty = "-1";
                    }
                    else
                    {
                        update.Penalty = pen.Text;
                    }
                    if (string.IsNullOrWhiteSpace(solution.Text))
                    {
                        update.Solution = "-1";
                    }
                    else
                    {
                        update.Solution = solution.Text;
                    }
                    if (string.IsNullOrWhiteSpace(remark.Text))
                    {
                        update.Remarks = "-1";
                    }
                    else
                    {
                        update.Remarks = remark.Text;
                    }
                    if (string.IsNullOrWhiteSpace(employeeinvolved.Text))
                    {
                        update.EmployeesInvolved = "-1";
                    }
                    else
                    {
                        update.EmployeesInvolved = employeeinvolved.Text;
                    }
                    if (string.IsNullOrWhiteSpace(specific.Text))
                    {
                        update.Specifics = "-1";
                    }
                    else
                    {
                        update.Specifics = specific.Text;
                    }

                    da.IP.UpdateReport(update);
                }
            }
        }
    }
}
