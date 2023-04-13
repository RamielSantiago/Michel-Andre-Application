using Apitron.PDF.Rasterizer;
using HRMS.Model.DBModels;
using HRMS.Resources.DBOPs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace HRMS.View.UI
{
    public partial class MemorandumCircular : UserControl 
    {
        string username;
        bool exists = false;
        MemorandumDBCRUD crud;
        public MemorandumCircular(string username)
        {
            InitializeComponent();
            this.username = username;
            crud = new MemorandumDBCRUD(ConfigurationManager.ConnectionStrings["SQLConnectionString"].ConnectionString);
            pdfreader.Dock = DockStyle.Fill;
        }
        private void upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            CircularModel toOpen = new CircularModel();
            if (exists)
            {
                pdfreader.Document = null;
            }
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;
                string extn = new FileInfo(file).Extension;

                try
                {
                    byte[] fileBytes = File.ReadAllBytes(file);
                    toOpen = crud.uploadFile(username, extn, fileBytes);
                    MemoryStream ms = new MemoryStream();
                    fileBytes = ms.ToArray();
                    File.WriteAllBytes("CurrentCircular.pdf", toOpen.file);

                    FileStream fs = new FileStream(Application.StartupPath + "\\CurrentCircular.pdf", FileMode.Open);
                    pdfreader.Document = new Document(fs);
                }
                catch(IOException ex){
                    MessageBox.Show("IOException Occurred." + Environment.NewLine + ex.Message, "Human Resource Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            } else
            {
                FileStream fs = new FileStream(Application.StartupPath + "\\CurrentCircular.pdf", FileMode.Open);
                pdfreader.Document = new Document(fs);
            }
        }

        private void MemorandumCircular_Load(object sender, EventArgs e)
        {
            try
            {
                var models = crud.displayExisting();
                if (models.Any())
                {
                    exists = true;
                    try
                    {
                        //MemoryStream ms = new MemoryStream();
                        //models.ElementAt(0).file = ms.ToArray();
                        //File.WriteAllBytes("CurrentCircular.pdf", models.ElementAt(0).file);

                        FileStream fs = new FileStream(Application.StartupPath + "\\CurrentCircular.pdf", FileMode.Open);
                        pdfreader.Document = new Document(fs);
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show("IOException Occurred." + Environment.NewLine + ex.Message, "Human Resource Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("IOException Occurred." + Environment.NewLine + ex.Message, "Human Resource Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
