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

namespace HRMS.View.UI.PerformanceAppraisal
{
    public partial class PerAppHub : UserControl
    {
        Panel ap;
        public PerAppHub()
        {
            InitializeComponent();
            this.ap = pAppViewPanel;
            if (!ap.Controls.Contains(Directory.vpa))
            {
                ap.Controls.Add(Directory.vpa);
                Directory.vpa.Dock = DockStyle.Fill;
                Directory.vpa.BringToFront();
            }
            else
            {
                Directory.vpa.BringToFront();
                Directory.vpa.refreshList();
                Directory.vpa.RefreshNames();
            }
        }

        private void pAppViewBtn_Click(object sender, EventArgs e)
        {
            if (!ap.Controls.Contains(Directory.vpa))
            {
                ap.Controls.Add(Directory.vpa);
                Directory.vpa.Dock = DockStyle.Fill;
                Directory.vpa.BringToFront();
            }
            else
            {
                Directory.vpa.BringToFront();
                Directory.vpa.refreshList();
                Directory.vpa.RefreshNames();
            }
        }

        private void pAppAddBtn_Click(object sender, EventArgs e)
        {
            if (!ap.Controls.Contains(Directory.apa))
            {
                ap.Controls.Add(Directory.apa);
                Directory.apa.Dock = DockStyle.Fill;
                Directory.apa.BringToFront();
            }
            else
            {
                Directory.apa.BringToFront();
            }
        }

        private void pAppUpdateButton_Click(object sender, EventArgs e)
        {
            if (!ap.Controls.Contains(Directory.epa))
            {
                ap.Controls.Add(Directory.epa);
                Directory.epa.Dock = DockStyle.Fill;
                Directory.epa.BringToFront();
            }
            else
            {
                Directory.epa.BringToFront();
                Directory.epa.RefreshNames();
            }
        }
    }
}
