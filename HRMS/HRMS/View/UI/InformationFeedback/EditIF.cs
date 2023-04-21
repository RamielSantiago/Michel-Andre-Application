using HRMS.Model.DBModels;
using HRMS.Resources.Tools;
using HRMS.View.Adapters;
using HRMS.View.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HRMS.View.UI.InformationFeedback
{
    public partial class EditIF : UserControl, iFeedback
    {
        Log_RegAdapter LRA;
        DashAdapter IRA;

        public int FeedbackID { get { return Convert.ToInt32(FBID.Text); } set { FBID.Text = ""; } }
        public string To { get { return to.SelectedItem.ToString(); } set { to.SelectedIndex = -1; } }
        public string From { get { return from.SelectedItem.ToString(); } set { from.SelectedIndex = -1; } }
        public string Subject { get { return subject.Text; } set { subject.Text = value; } }
        DateTime iFeedback.date { get { return FBdate.Value; } set { FBdate.Value = DateTime.Now; } }
        public string Details { get { return FBdetail.Text; } set { FBdetail.Text = value; } }
        public string RecAct { get { return RA.Text; } set { RA.Text = value; } }
        public string Comments { get { return FBComments.Text; } set { FBComments.Text = value; } }
        public bool CompSig { get { return complaint.Checked; } set { complaint.Checked = value; } }
        public bool HRSig { get { return HRO.Checked; } set { HRO.Checked = value; } }
        public bool SuperSig { get { return SV.Checked; } set { SV.Checked = value; } }
        public bool PresSig { get { return Pres.Checked; } set { Pres.Checked = value; } }

        public EditIF()
        {
            InitializeComponent();
            this.LRA = new Log_RegAdapter(Directory.uList);
            this.IRA = new DashAdapter(this);
            RefreshNames();
            FBdate.Enabled= false;
            complaint.Enabled = false;
            HRO.Enabled = false;
            Pres.Enabled = false;
            SV.Enabled = false;
        }
        public void RefreshNames()
        {
            to.Items.Clear();
            from.Items.Clear();
            IEnumerable<UserModel> Names = LRA.crud.GetAll();
            for (int i = 0; i < Names.Count(); i++)
            {
                to.Items.Add(Names.ElementAt(i).LastName + "," + Names.ElementAt(i).FirstName + " " + Names.ElementAt(i).MiddleName);
                from.Items.Add(Names.ElementAt(i).LastName + ", " + Names.ElementAt(i).FirstName + " " + Names.ElementAt(i).MiddleName);
            }
        }

        public void setFeedbackBS(BindingSource bs)
        {
            Console.Write("FeedbackBS set");
        }

        private void upRepBtn_Click(object sender, EventArgs e)
        {
            string errorMsg = "";
            bool valid = true;
            var sample = new FeedbackModel();
            if (string.IsNullOrWhiteSpace(FBID.Text))
            {
                valid = false;
                MessageBox.Show("Please fill all the required fields", "Human Resource Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    Convert.ToInt32 (FBID.Text);
                    sample.FeedbackID = Convert.ToInt32(FBID.Text);
                    if (IRA.crudFB.checkifExists(sample) == 0)
                    {
                        valid = false;
                        MessageBox.Show("No such record exists", "Human Resource Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                } catch(FormatException ex)
                {
                    valid = false;
                    MessageBox.Show("IDs are Numeric", "Human Resource Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            if (valid)
            {
                if(FBdate.Value > DateTime.Now && enableDate.Checked == true)
                {
                    valid = false;
                    errorMsg = errorMsg + "Date input cannot be a future date" + Environment.NewLine;
                }
                if (valid)
                {
                    if (to.SelectedIndex == -1)
                    {
                        sample.To = "-1";
                    }
                    else
                    {
                        sample.To = To;
                    }
                    if (from.SelectedIndex == -1)
                    {
                        sample.From = "-1";
                    }
                    else
                    {
                        sample.From = From;
                    }
                    if (string.IsNullOrWhiteSpace(Subject))
                    {
                        sample.Subject = "-1";
                    }
                    else
                    {
                        sample.Subject = Subject;
                    }
                    if (!enableDate.Checked)
                    {
                        sample.date = DateTime.MaxValue;
                    }
                    else
                    {
                        sample.date = FBdate.Value;
                    }
                    if (string.IsNullOrWhiteSpace(Details))
                    {
                        sample.Details = "-1";
                    }
                    else
                    {
                        sample.Details = Details;
                    }
                    if (string.IsNullOrWhiteSpace(RecAct))
                    {
                        sample.RecAct = "-1";
                    }
                    else
                    {
                        sample.RecAct = RecAct;
                    }
                    if (string.IsNullOrWhiteSpace(Comments))
                    {
                        sample.Comments = "-1";
                    }
                    else
                    {
                        sample.Comments = Comments;
                    }
                    if (eab.Checked)
                    {
                        if (CompSig)
                        {
                            sample.CompSig = "Complete";
                        }
                        else
                        {
                            sample.CompSig = "Incomplete";
                        }
                        if (HRSig)
                        {
                            sample.HRSig = "Complete";
                        }
                        else
                        {
                            sample.HRSig = "Incomplete";
                        }
                        if (SuperSig)
                        {
                            sample.SuperSig = "Complete";
                        }
                        else
                        {
                            sample.SuperSig = "Incomplete";
                        }
                        if (PresSig)
                        {
                            sample.PresSig = "Complete";
                        }
                        else
                        {
                            sample.PresSig = "Incomplete";
                        }
                    }
                    else
                    {
                        sample.CompSig = "No Change";
                        sample.HRSig = "No Change";
                        sample.SuperSig = "No Change";
                        sample.PresSig = "No Change";
                    }
                    IRA.FB.Update(sample);
                    MessageBox.Show("Update successful", "Human Resource Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(errorMsg, "Human Resource Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            FBID.Clear();
            to.SelectedIndex = -1;
            from.SelectedIndex = -1;
            subject.Clear();
            FBdetail.Clear();
            FBComments.Clear();
            RA.Clear();
            FBdate.Value = DateTime.Now;
            enableDate.Checked = false;
            eab.Checked = false;
            complaint.Checked = false;
            HRO.Checked = false;
            SV.Checked = false;
            Pres.Checked = false;
        }

        private void EditIF_Load(object sender, EventArgs e)
        {

        }

        private void SV_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void enableDate_CheckedChanged(object sender, EventArgs e)
        {
            if (enableDate.Checked == false)
            {
                FBdate.Enabled = false;
            }
            else
            {
                FBdate.Enabled = true;
            }
        }

        private void eab_CheckedChanged(object sender, EventArgs e)
        {
            if (eab.Checked)
            {
                complaint.Enabled = true;
                HRO.Enabled = true;
                SV.Enabled = true;
                Pres.Enabled = true;
            }
            else
            {
                complaint.Enabled = false;
                HRO.Enabled = false;
                SV.Enabled = false;
                Pres.Enabled = false;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void from_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void complaint_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Pres_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HRO_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
