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

namespace HRMS.View.UI.Recruitment
{
    public partial class Recruitment : UserControl
    {
        Panel ap;
        public Recruitment()
        {
            InitializeComponent();
            ap = recViewPanel;
            if (!ap.Controls.Contains(Directory.vrec))
            {
                ap.Controls.Add(Directory.vrec);
                Directory.vrec.Dock = DockStyle.Fill;
                Directory.vrec.BringToFront();
            }
            else
            {
                Directory.vrec.BringToFront();
                Directory.vrec.refreshList();
                Directory.vrec.RefreshNames();
            }
        }

        private void recViewBtn_Click(object sender, EventArgs e)
        {
            if (!ap.Controls.Contains(Directory.vrec))
            {
                ap.Controls.Add(Directory.vrec);
                Directory.vrec.Dock = DockStyle.Fill;
                Directory.vrec.BringToFront();
            }
            else
            {
                Directory.vrec.BringToFront();
                Directory.vrec.refreshList();
                Directory.vrec.RefreshNames();
            }
        }

        private void recAddBtn_Click(object sender, EventArgs e)
        {
            if (!ap.Controls.Contains(Directory.arec))
            {
                ap.Controls.Add(Directory.arec);
                Directory.arec.Dock = DockStyle.Fill;
                Directory.arec.BringToFront();
            }
            else
            {
                Directory.arec.BringToFront();
            }
        }

        private void recUpdateButton_Click(object sender, EventArgs e)
        {
            if (!ap.Controls.Contains(Directory.urec))
            {
                ap.Controls.Add(Directory.urec);
                Directory.urec.Dock = DockStyle.Fill;
                Directory.urec.BringToFront();
                Directory.urec.RefreshNames();
            }
            else
            {
                Directory.urec.BringToFront();
                Directory.urec.RefreshNames();
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Application.Exit();
        }
    }
}
