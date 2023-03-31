using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMS
{
    public partial class CompanyOrgChart : UserControl
    {
        public CompanyOrgChart()
        {     
            InitializeComponent();
        }

        private void CompanyOrgChart_Load(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { ValidateNames = true, Multiselect = true, Filter = "PDF|*.pdf" })
            {
                ofd.InitialDirectory = "\\HRMS\\HRMS\\Docus\\OrgChart";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    axAcroPDF1.Dock = DockStyle.Fill;
                    axAcroPDF1.setView("FitH");
                    axAcroPDF1.src = ofd.FileName;
                    axAcroPDF1.setShowToolbar(true);
                    axAcroPDF1.setShowScrollbars(true);
                }
            }
        }

        private void CompanyOrgChart_Closing(object sender, CancelEventArgs e)
        {
            this.axAcroPDF1.Dispose();
            this.axAcroPDF1 = null;
        }
    }
}
