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
    public partial class MemorandumCircular : UserControl
    {
        public MemorandumCircular()
        {
            InitializeComponent();
        }

        private void upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pdfreader.Dock = DockStyle.Fill;
                pdfreader.setView("FitH");
                pdfreader.src = openFileDialog1.FileName;
                pdfreader.setShowToolbar(true);
                pdfreader.setShowScrollbars(true);
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            pdfreader.src = "";
        }
    }
}
