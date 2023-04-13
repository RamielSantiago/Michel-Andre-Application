using HRMS.Resources.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMS.View.UI.IncidentReport
{
    public partial class ReportHub : UserControl
    {
        Panel rPanel;
        public ReportHub()
        {
            InitializeComponent();
            this.rPanel = eViewPanel;
            if (!rPanel.Controls.Contains(Directory.vReport))
            {
                rPanel.Controls.Add(Directory.vReport);
                Directory.vReport.Dock = DockStyle.Fill;
                Directory.vReport.BringToFront();
            }
            else
            {
                Directory.vReport.BringToFront();
                Directory.vReport.refreshList();
            }
        }

        private void rViewBtn_Click(object sender, EventArgs e)
        {
            if (!rPanel.Controls.Contains(Directory.vReport))
            {
                rPanel.Controls.Add(Directory.vReport);
                Directory.vReport.Dock = DockStyle.Fill;
                Directory.vReport.BringToFront();
            }
            else
            {
                Directory.vReport.BringToFront();
                Directory.vReport.refreshList();
                Directory.vReport.RefreshNames();
            }
        }

        private void rAddBtn_Click(object sender, EventArgs e)
        {
            if (!rPanel.Controls.Contains(Directory.aReport))
            {
                rPanel.Controls.Add(Directory.aReport);
                Directory.aReport.Dock = DockStyle.Fill;
                Directory.aReport.BringToFront();
            }
            else
            {
                Directory.aReport.BringToFront();
            }
        }

        private void rUpdateButton_Click(object sender, EventArgs e)
        {
            if (!rPanel.Controls.Contains(Directory.uReport))
            {
                rPanel.Controls.Add(Directory.uReport);
                Directory.uReport.Dock = DockStyle.Fill;
                Directory.uReport.BringToFront();
            }
            else
            {
                Directory.uReport.BringToFront();
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Application.Exit();
        }
    }
}
