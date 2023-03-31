using HRMS.View.Adapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMS.View.Forms
{
    public partial class DeleteReport : Form
    {
        DashboardAdapter da;
        public DeleteReport(DashboardAdapter da)
        {
            InitializeComponent();
            this.da = da;
        }

        private void DeleteReport_Load(object sender, EventArgs e)
        {

        }

        private void deleteReportButton_Click(object sender, EventArgs e)
        {
            delErrorMsg.Text = "";
            bool valid = true;
            if (deletecriteria.SelectedIndex == -1 || deletecriteria.SelectedIndex == 2)
            {
                delErrorMsg.Text = delErrorMsg.Text + "Please select a Search Criteria for deletion." + Environment.NewLine;
                valid = false;
            }
            if (string.IsNullOrWhiteSpace(deletequery.Text))
            {
                delErrorMsg.Text = delErrorMsg.Text + "Please select a value related to the record to delete." + Environment.NewLine;
                valid = false;
            }
            if (valid)
            {
                if (deletecriteria.Text.Equals("Incident ID"))
                {
                    try
                    {
                        int test = Convert.ToInt32(deletequery.Text);
                        da.IP.DeleteReport(deletecriteria.SelectedItem.ToString(), deletequery.Text) ;
                    }
                    catch (FormatException)
                    {
                        delErrorMsg.Text = delErrorMsg.Text + "Incident IDs are numerical" + Environment.NewLine;
                    }
                }
                else
                {
                    da.IP.DeleteReport(deletecriteria.SelectedItem.ToString(), deletequery.Text);
                }

            }
        }
    }
}
