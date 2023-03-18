using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMS.View.Forms
{
    public partial class CompanyRandR : Form
    {
        public CompanyRandR()
        {
            InitializeComponent();
        }

        private void CompanyRandR_Load(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { ValidateNames = true, Multiselect = true, Filter = "PDF|*.pdf" })
            {
                ofd.InitialDirectory = "\\HRMS\\HRMS";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    axAcroPDF1.src = ofd.FileName;
                }
            }
        }

        private void CompanyRandR_Closing(object sender, CancelEventArgs e)
        {
            this.axAcroPDF1.Dispose();
            this.axAcroPDF1 = null;
        }
    }
}
