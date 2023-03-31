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
    public partial class CompanyRandR : UserControl
    {
        public string fileName = "\\HRMS\\HRMS\\CompanyRules.pdf";
        
        public CompanyRandR()
        {      
            InitializeComponent();
        }

        private void CompanyRandR_Load(object sender, EventArgs e)
        {
            axAcroPDF1.Dock = DockStyle.Fill;
            axAcroPDF1.setView("FitH");
            axAcroPDF1.src = fileName;
            axAcroPDF1.setShowToolbar(true);
            axAcroPDF1.setShowScrollbars(true);
        }

        private void CompanyRandR_Closing(object sender, CancelEventArgs e)
        {
            this.axAcroPDF1.Dispose();
            this.axAcroPDF1 = null;
        }
    }
}
