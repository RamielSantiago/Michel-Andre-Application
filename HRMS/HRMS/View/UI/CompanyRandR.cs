using AcroPDFLib;
using AxAcroPDFLib;
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
    public partial class randrReader : UserControl
    {
        public randrReader()
        {
            InitializeComponent();
        }

        private void randrReader_Load(object sender, EventArgs e)
        {
            pdfreader.Dock = DockStyle.Fill;
            pdfreader.setView("FitH");
            pdfreader.src = Application.StartupPath + "\\Resources\\PDFs\\Rules\\CompanyRules.pdf";
            pdfreader.setShowToolbar(true);
            pdfreader.setShowScrollbars(true);
        }
    }
}
