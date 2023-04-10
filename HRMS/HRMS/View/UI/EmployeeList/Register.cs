using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using HRMS.Resources.Tools;
using HRMS.View.Adapters;
using HRMS.View.Interfaces;
using HRMS.View.UI;

namespace HRMS.View
{
    public partial class HRMSRegister : UserControl
    {
        private Panel ePanel;
        public Log_RegAdapter lRA;
        public HRMSRegister()
        {
            InitializeComponent();
            this.ePanel = eViewPanel;
            if (!ePanel.Controls.Contains(Directory.eList))
            {
                ePanel.Controls.Add(Directory.eList);
                Directory.eList.Dock = DockStyle.Fill;
                Directory.eList.BringToFront();
            }
            else
            {
                Directory.eList.BringToFront();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void eViewBtn_Click(object sender, EventArgs e)
        {
            if (!ePanel.Controls.Contains(Directory.eList))
            {
                ePanel.Controls.Add(Directory.eList);
                Directory.eList.Dock = DockStyle.Fill;
                Directory.eList.BringToFront();
            }
            else
            {
                Directory.eList.BringToFront();
                Directory.eList.refreshList();
            }
        }

        private void eAddBtn_Click(object sender, EventArgs e)
        {
            if (!ePanel.Controls.Contains(Directory.aList))
            {
                ePanel.Controls.Add(Directory.aList);
                Directory.aList.Dock = DockStyle.Fill;
                Directory.aList.BringToFront();
            }
            else
            {
                Directory.aList.BringToFront();
            }
        }

        private void eUpdateButton_Click(object sender, EventArgs e)
        {
            if (!ePanel.Controls.Contains(Directory.uList))
            {
                ePanel.Controls.Add(Directory.uList);
                Directory.uList.Dock = DockStyle.Fill;
                Directory.uList.BringToFront();
            }
            else
            {
                Directory.uList.BringToFront();
            }
        }
    }
}
