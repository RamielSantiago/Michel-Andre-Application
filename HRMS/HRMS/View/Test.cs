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
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        public OrgChartView pv = new OrgChartView();
        public Nav nav = new Nav();

        public void loadUI()
        {
            this.Controls.Add(pv);
            this.Controls.Add(nav);
        }
    }
}
