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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HRMS.View.UI.InformationFeedback
{
    public partial class EditIF : UserControl, iFeedback
    {
        private string[] acctPos = {"EVP Finance & Accounting",
                                    "Accounting Officer",
                                    "Accounts Receivable Staff",
                                    "Account Payable Staff",
                                    "General Accounting Staff",
                                    "Accounting General Services Staff"};
        private string[] retailPos = {"AVP - Sales & Marketing",
                                      "Retail Sales Officer",
                                      "Retail Sales Supervisor",
                                      "Sales Associates"};
        private string[] auditPos = {"Internal Audit Officer",
                                     "Field Auditor",
                                     "Audit Staff"};
        private string[] misPos = {"System Administrator",
                                   "IT Programmer",
                                   "System & Hardware Technical Support Staff",
                                   "EDP Staff"};
        private string[] securityPos = {"Security Services - Administration Officer",
                                        "Security Services - Senior Security Staff",
                                        "Security Services - Junior Securty Staff",
                                        "Maintenance & General Services - Senior Mechanic",
                                        "Maintenance & General Services - Junior General Services Staff",
                                        "Maintenance & General Services - Store & Building Maintenance Contractor",
                                        "Maintenance & General Services - Administrative General Services"};
        private string[] purchasingPos = {"Purchasing Officer",
                                          "Purchasing Staff"};
        private string[] merchPos = {"AVP - Retail Operation",
                                     "Merchandising Officer",
                                     "Merchandising & Planning Control Staff"};
        private string[] hrmdPos = {"HRMD Officer",
                                    "HR Consultant",
                                    "Recuitment, HRIS & OD Staff",
                                    "Compensation, Benefits & HR-Admin Staff",
                                    "Training, Employee, Relation & Record Management Staff",};
        private string[] marketPos = {"AVP Retail Operation",
                                      "Public Relations & Advertising Consultant",
                                      "Marketing Staff"};
        private string[] creativesPos = {"AVP - Retail Operation",
                                         "Graphic Artist"};
        private string[] warelogPos = {"Warehouse & Logistic Assistant Supervisor",
                                       "Warehouse Finished Goods - Receiving Staff",
                                       "Warehouse Finished Goods - Delivery Staff",
                                       "Logistic Section - Delivery Driver",
                                       "Logistic Section - Delivery Assistant",
                                       "Logistic Section - Logistic Assistant",
                                       "Raw Material Section - Raw Material Controller"};
        private string[] mcePos = {"Production Officer",
                                   "Cutting Subcontractor",
                                   "Prodcution Assistant",
                                   "Cut Goods & Raw Material Issuance - Subcontractor Coordinator",
                                   "Cut Goods & Raw Material Issuance - External Sewing Subcontractor",
                                   "Cut Goods & Raw Material Issuance - Cutting Subcontractor",
                                   "Cut Goods & Raw Material Issuance - Bundling Subcontractor",
                                   "Sewing - Sewing Supervisor",
                                   "Sewing - Fusers",
                                   "Sewing - Button Hole or Sew",
                                   "Sewing - Trimmers",
                                   "Sewing - Washers",
                                   "Sewing Assembly - Sewing Assembly Supervisor",
                                   "Sewing Assembly - Woven Shirt or Barong Sewinbg Subcontractors",
                                   "Sewing Assemby - Pants Sewing Subcontractors",
                                   "Pressing & Packing - Pressing & Packing Supervisor",
                                   "Pressing & Packing - Pressing Subcontractor"};
        private string[] mceqaPos = {"Assistant Supervisor Quality Assurance",
                                     "Sewing QA - In-House Pre-Final Subcon Pants",
                                     "Sewing QA - In-House Pre-Final Subcon Barong",
                                     "Sewing QA - QC Staff",
                                     "Raw Material QA - Juai Fabric, Embroidery, or Final QC Subcon",
                                     "Raw Material QA - Fabric Inspector"};

        Log_RegAdapter LRA;
        DashAdapter IRA;

        public int FeedbackID { get { return Convert.ToInt32(FBID.Text); } set { FBID.Text = ""; } }
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
        public bool PresSig { get { return Pres.Checked; } set { Pres.Checked = value; } }

        public EditIF()
        {
            InitializeComponent();
            this.LRA = new Log_RegAdapter(Directory.uList);
            this.IRA = new DashAdapter(this);
            RefreshNames();
            if(enableDate.Checked == false)
            {
                date.Enabled= false;
            }
        }
        public void RefreshNames()
        {
            to.Items.Clear();
            from.Items.Clear();
            IEnumerable<UserModel> Names = LRA.crud.GetAll();
            for (int i = 0; i < Names.Count(); i++)
            {
                to.Items.Add(Names.ElementAt(i).FirstName + ", " + Names.ElementAt(i).FirstName + " " + Names.ElementAt(i).MiddleName);
                from.Items.Add(Names.ElementAt(i).FirstName + ", " + Names.ElementAt(i).FirstName + " " + Names.ElementAt(i).MiddleName);
            }
            to.Items.RemoveAt(0);
            from.Items.RemoveAt(0);
        }

        public void setFeedbackBS(BindingSource bs)
        {
            Console.Write("FeedbackBS set");
        }

        private void upRepBtn_Click(object sender, EventArgs e)
        {
            string errorMsg = "";
            bool valid = true;
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
                } catch(FormatException ex)
                {
                    MessageBox.Show("IDs are Numeric", "Human Resource Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            if (valid)
            {
                if(date.Value > DateTime.Now && enableDate.Checked == true)
                {
                    valid = false;
                    errorMsg = errorMsg + "Date input cannot be a future date" + Environment.NewLine;
                }
                if (valid)
                {
                    IRA.FB.Update();
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
            date.Value = DateTime.Now;
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
                date.Enabled = false;
            }
            else
            {
                date.Enabled = true;
            }
        }
    }
}
