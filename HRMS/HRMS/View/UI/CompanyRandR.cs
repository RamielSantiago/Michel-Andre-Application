using AcroPDFLib;
using Apitron.PDF.Rasterizer;
using AxAcroPDFLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            try
            {
                FileStream fs = new FileStream(Path.GetFullPath("CompanyRules.pdf"), FileMode.Open);
                pdfreader.Document = new Document(fs);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Human Resource Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } 
    }
}
