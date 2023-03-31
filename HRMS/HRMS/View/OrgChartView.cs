using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMS.View
{
    public partial class OrgChartView : UserControl
    {
        public OrgChartView()
        {
            InitializeComponent();
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void NewWdw_Click(object sender, EventArgs e)
        {
            OrgChartNewWindow oc = new OrgChartNewWindow();
            oc.Show();
        }
    }
}
