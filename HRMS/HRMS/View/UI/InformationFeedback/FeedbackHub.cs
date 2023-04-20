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

namespace HRMS.View.UI.InformationFeedback
{
    public partial class FeedbackHub : UserControl
    {
        public FeedbackHub()
        {
            InitializeComponent();
            if (!fbViewPanel.Controls.Contains(Directory.vif))
            {
                fbViewPanel.Controls.Add(Directory.vif);
                Directory.vif.Dock = DockStyle.Fill;
                Directory.vif.BringToFront();
            }
            else
            {
                Directory.vif.BringToFront();
            }
        }

        private void fbViewBtn_Click(object sender, EventArgs e)
        {
            if (!fbViewPanel.Controls.Contains(Directory.vif))
            {
                fbViewPanel.Controls.Add(Directory.vif);
                Directory.vif.Dock = DockStyle.Fill;
                Directory.vif.BringToFront();
                Directory.vif.refreshList();
                Directory.vif.RefreshNames();
            }
            else
            {
                Directory.vif.BringToFront();
                Directory.vif.refreshList();
                Directory.vif.RefreshNames();
            }
        }

        private void fbAddBtn_Click(object sender, EventArgs e)
        {
            if (!fbViewPanel.Controls.Contains(Directory.aif))
            {
                fbViewPanel.Controls.Add(Directory.aif);
                Directory.aif.Dock = DockStyle.Fill;
                Directory.aif.BringToFront();
                Directory.aif.RefreshNames();
            }
            else
            {
                Directory.aif.BringToFront();
                Directory.aif.RefreshNames();
            }
        }

        private void fbUpdateButton_Click(object sender, EventArgs e)
        {
            if (!fbViewPanel.Controls.Contains(Directory.eif))
            {
                fbViewPanel.Controls.Add(Directory.eif);
                Directory.eif.Dock = DockStyle.Fill;
                Directory.eif.BringToFront();
                Directory.eif.RefreshNames();
            }
            else
            {
                Directory.eif.BringToFront();
                Directory.vif.refreshList();
                Directory.eif.RefreshNames();
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Application.Exit();
        }
    }
}
