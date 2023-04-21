using HRMS.View.Adapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using HRMS.Model.DBModels;
using HRMS.Resources.Tools;
using HRMS.View.Adapters;
using HRMS.View.Interfaces;

namespace HRMS.View.UI.InformationFeedback
{
    public partial class addIF : UserControl, iFeedback
    {
        Log_RegAdapter LRA;
        DashAdapter IRA;

        public int FeedbackID { get; set; }
        public string To { get { return to.SelectedItem.ToString(); } set { to.SelectedIndex = -1; } }
        public string From { get { return from.SelectedItem.ToString(); } set { from.SelectedIndex = -1; } }
        public string Subject { get { return subject.Text; } set { subject.Text = value; } }
        DateTime iFeedback.date { get { return date.Value; } set { date.Value = DateTime.Now; } }
        public string Details { get { return FBdetail.Text; } set { FBdetail.Text = value; } }
        public string RecAct { get { return RA.Text; } set { RA.Text = value; } }
        public string Comments { get { return FBComments.Text; } set { FBComments.Text = value; } }
        public bool CompSig { get { return complaint.Checked; } set { complaint.Checked = value; } }
        public bool HRSig { get { return HRO.Checked; } set { HRO.Checked = value; } }
        public bool SuperSig { get { return SV.Checked; } set { SV.Checked = value; } }
        public bool PresSig { get { return Pres.Checked; } set {Pres.Checked = value; } }

        public addIF()
        {
            InitializeComponent();
            this.LRA = new Log_RegAdapter(Directory.aList);
            this.IRA = new DashAdapter(this);
            RefreshNames();
        }

        public void RefreshNames()
        {
            to.Items.Clear();
            from.Items.Clear();
            IEnumerable<UserModel> Names = LRA.crud.GetAll();
            for (int i = 0; i < Names.Count(); i++)
            {
                to.Items.Add(Names.ElementAt(i).LastName + ", " + Names.ElementAt(i).FirstName + " " + Names.ElementAt(i).MiddleName);
                from.Items.Add(Names.ElementAt(i).LastName + ", " + Names.ElementAt(i).FirstName + " " + Names.ElementAt(i).MiddleName);
            }
        }

        private void panel1_Load(object sender, EventArgs e)
        {

        }

        public void setFeedbackBS(BindingSource bs)
        {
            Console.Write("Something");
        }

        private void addIFBtn_Click(object sender, EventArgs e)
        {
            string errorMsg = "";
            bool valid = true;
            if (to.SelectedIndex == -1 || from.SelectedIndex == -1 || string.IsNullOrWhiteSpace(subject.Text) ||string.IsNullOrWhiteSpace(FBdetail.Text)
                || string.IsNullOrWhiteSpace(RA.Text))
            {
                valid = false;
                MessageBox.Show("Please fill all the required fields", "Human Resource Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (date.Value > DateTime.Now)
                {
                    valid = false;
                    errorMsg = errorMsg + "Date input cannot be a future date" + Environment.NewLine;
                }
                if (valid)
                {
                    IRA.FB.Add();
                    MessageBox.Show("New Feedback added", "Human Resource Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(errorMsg, "Human Resource Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            to.SelectedIndex = -1;
            from.SelectedIndex = -1;
            subject.Clear();
            FBdetail.Clear();
            FBComments.Clear();
            RA.Clear();
            date.Value = DateTime.Now;
            complaint.Checked = false;
            HRO.Checked = false;
            SV.Checked = false;
            Pres.Checked = false;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void from_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void subject_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void to_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FBComments_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void complaint_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FBdetail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void RA_TextChanged(object sender, EventArgs e)
        {

        }

        private void HRO_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void SV_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Pres_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
