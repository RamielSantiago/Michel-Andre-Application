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

namespace HRMS.View.UI
{
    public partial class Dashboard : Form
    { 
        private Panel ap;
        private HRMSLogin loginform;
        public Dashboard(string Username, HRMSLogin loginform)
        {
            this.loginform = loginform;
            InitializeComponent();
            this.ap = activityPanel;
            Directory.username = Username;
        }

        private void orgchart_Click(object sender, EventArgs e)
        {
            if (!ap.Controls.Contains(Directory.og))
            {
                ap.Controls.Add(Directory.og);
                Directory.og.Dock = DockStyle.Fill;
                Directory.og.BringToFront();
            }
            else
            {
                Directory.og.BringToFront();
            }
        }

        private void MemCirc_Click(object sender, EventArgs e)
        {
            if (!ap.Controls.Contains(Directory.mem))
            {
                ap.Controls.Add(Directory.mem);
                Directory.mem.Dock = DockStyle.Fill;
                Directory.mem.BringToFront();
            }
            else
            {
                Directory.mem.BringToFront();
            }
        }

        private void recruitment_Click(object sender, EventArgs e)
        {
            if (!ap.Controls.Contains(Directory.rechub))
            {
                ap.Controls.Add(Directory.rechub);
                Directory.rechub.Dock = DockStyle.Fill;
                Directory.rechub.BringToFront();
            }
            else
            {
                Directory.rechub.BringToFront();
            }
        }

        private void appraisal_Click(object sender, EventArgs e)
        {
            if (!ap.Controls.Contains(Directory.pah))
            {
                ap.Controls.Add(Directory.pah);
                Directory.pah.Dock = DockStyle.Fill;
                Directory.pah.BringToFront();
            }
            else
            {
                Directory.pah.BringToFront();
                Directory.apa.RefreshNames();
                Directory.vpa.RefreshNames();
                Directory.epa.RefreshNames();
            }
        }

        private void IncidentBtn_Click(object sender, EventArgs e)
        {
            if (!ap.Controls.Contains(Directory.IReports))
            {
                ap.Controls.Add(Directory.IReports);
                Directory.IReports.Dock = DockStyle.Fill;
                Directory.IReports.BringToFront();
            }
            else
            {
                Directory.IReports.BringToFront();
                Directory.aReport.RefreshNames();
                Directory.vReport.RefreshNames();
                Directory.uReport.RefreshNames();
            }
        }

        private void feedback_Click(object sender, EventArgs e)
        {
            if (!ap.Controls.Contains(Directory.fh))
            {
                ap.Controls.Add(Directory.fh);
                Directory.fh.Dock = DockStyle.Fill;
                Directory.fh.BringToFront();
            }
            else
            {
                Directory.fh.BringToFront();
            }
        }

        private void employeelist_Click(object sender, EventArgs e)
        {
            if (!ap.Controls.Contains(Directory.Register))
            {
                ap.Controls.Add(Directory.Register);
                Directory.Register.Dock = DockStyle.Fill;
                Directory.Register.BringToFront();
            }
            else
            {
                Directory.Register.BringToFront();
            }
        }

        private void randr_Click(object sender, EventArgs e)
        {
            if (!ap.Controls.Contains(Directory.loadRules))
            {
                ap.Controls.Add(Directory.loadRules);
                Directory.loadRules.Dock = DockStyle.Fill;
                Directory.loadRules.BringToFront();
            }
            else
            {
                Directory.loadRules.BringToFront();
            }
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            loginform.Close();
            Application.Exit();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            loginform.Show();
            Directory.Register = null;
            Directory.aList = null;
            Directory.eList = null;
            Directory.uList = null;

            Directory.loadRules = null;
            Directory.mem = null;
            Directory.og = null;

            Directory.pah = null;
            Directory.vpa = null;
            Directory.apa = null;
            Directory.epa = null;

            Directory.rechub = null;
            Directory.arec = null;
            Directory.vrec = null;
            Directory.urec = null;

            Directory.IReports = null;
            Directory.aReport = null;
            Directory.vReport = null;
            Directory.uReport = null;

            Directory.fh = null;
            Directory.eif = null;
            Directory.aif = null;
            Directory.vif = null;
            this.Close();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Application.Exit();
        }
    }
}
