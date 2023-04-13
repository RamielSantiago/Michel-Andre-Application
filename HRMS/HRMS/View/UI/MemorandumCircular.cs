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
                try
                {
                    FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open);
                    pdfreader.Document = new Document(fs);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Human Resource Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            pdfreader.Document = null;
        }
    }
}
