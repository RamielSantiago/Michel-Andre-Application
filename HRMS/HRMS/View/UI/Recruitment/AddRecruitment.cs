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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HRMS.View.UI.Recruitment
{
    public partial class AddRecruitment : UserControl, iRecruit
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

        private Log_RegAdapter LRA;
        private DashAdapter da;
        private string status = "";

        public string FirstName { get { return fName.Text; } set { fName.Text = value; } }
        public string LastName { get { return lName.Text; } set { lName.Text = value; } }
        public string MiddleName { get { return mName.Text; } set { mName.Text = value; } }
        public string Position { get { return PositionSearchDD.SelectedItem.ToString(); } set { PositionSearchDD.SelectedIndex = -1; } }
        public string Department { get { return DepartmentSearchDD.SelectedItem.ToString(); } set { DepartmentSearchDD.SelectedIndex = -1; } }
        public DateTime ApplicationDate { get { return DateAdd.Value; } set { DateAdd.Value = DateTime.Now; } }
        public bool InterInterview1 { get { return Int1.Checked; } set { Int1.Checked = false; } }
        public bool InterInterview2 { get { return Int2.Checked; } set { Int2.Checked = false; } }
        public bool InterInterview3 { get { return Int3.Checked; } set { Int3.Checked = false; } }
        public bool training { get { return Training.Checked; } set { Training.Checked = false; } }
        public bool resume { get { return Resume.Checked; } set { Resume.Checked = false; } }
        public bool PSA { get { return BC.Checked; } set { BC.Checked = false; } }
        public bool sss { get { return SSS.Checked; } set { SSS.Checked = false; } }
        public bool nbi { get { return NBI.Checked; } set { NBI.Checked = false; } }
        public bool police { get { return Police.Checked; } set { Police.Checked = false; } }
        public bool PagIbig { get { return PI.Checked; } set { PI.Checked = false; } }
        public bool philhealth { get { return PH.Checked; } set { PH.Checked = false; } }
        public bool bir { get { return BIR.Checked; } set { BIR.Checked = false; } }
        public bool tor { get { return TOR.Checked; } set { TOR.Checked = false; } }
        public bool EmpCert { get { return CoE.Checked; } set { CoE.Checked = false; } }
        public bool MedExam { get { return ME.Checked; } set { ME.Checked = false; } }
        public string OverallStatus { get { return status; } set { status = value; } }

        public AddRecruitment()
        {
            InitializeComponent();
            this.LRA = new Log_RegAdapter(Directory.aList);
            this.da = new DashAdapter(this);
        }

        public void setRecruitBS(BindingSource bs)
        {
            Console.Write("Something");
        }

        private void DepartmentSearchDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            PositionSearchDD.Items.Clear();
            switch (DepartmentSearchDD.SelectedIndex)
            {
                case 0:
                    PositionSearchDD.Items.Add("President");
                    PositionSearchDD.SelectedIndex = 0;
                    break;
                case 1:
                    PositionSearchDD.Items.Add("General Manager");
                    PositionSearchDD.SelectedIndex = 0;
                    break;
                case 2:
                    for (int i = 0; i < acctPos.Length; i++)
                    {
                        PositionSearchDD.Items.Add(acctPos[i]);
                    }
                    break;
                case 3:
                    for (int i = 0; i < retailPos.Length; i++)
                    {
                        PositionSearchDD.Items.Add(retailPos[i]);
                    }
                    break;
                case 4:
                    for (int i = 0; i < auditPos.Length; i++)
                    {
                        PositionSearchDD.Items.Add(auditPos[i]);
                    }
                    break;
                case 5:
                    for (int i = 0; i < misPos.Length; i++)
                    {
                        PositionSearchDD.Items.Add(misPos[i]);
                    }
                    break;
                case 6:
                    for (int i = 0; i < securityPos.Length; i++)
                    {
                        PositionSearchDD.Items.Add(securityPos[i]);
                    }
                    break;
                case 7:
                    for (int i = 0; i < purchasingPos.Length; i++)
                    {
                        PositionSearchDD.Items.Add(purchasingPos[i]);
                    }
                    break;
                case 8:
                    for (int i = 0; i < merchPos.Length; i++)
                    {
                        PositionSearchDD.Items.Add(merchPos[i]);
                    }
                    break;
                case 9:
                    for (int i = 0; i < hrmdPos.Length; i++)
                    {
                        PositionSearchDD.Items.Add(hrmdPos[i]);
                    }
                    break;
                case 10:
                    for (int i = 0; i < marketPos.Length; i++)
                    {
                        PositionSearchDD.Items.Add(marketPos[i]);
                    }
                    break;
                case 11:
                    for (int i = 0; i < creativesPos.Length; i++)
                    {
                        PositionSearchDD.Items.Add(creativesPos[i]);
                    }
                    break;
                case 12:
                    for (int i = 0; i < warelogPos.Length; i++)
                    {
                        PositionSearchDD.Items.Add(warelogPos[i]);
                    }
                    break;
                case 13:
                    for (int i = 0; i < mcePos.Length; i++)
                    {
                        PositionSearchDD.Items.Add(mcePos[i]);
                    }
                    break;
                case 14:
                    for (int i = 0; i < mceqaPos.Length; i++)
                    {
                        PositionSearchDD.Items.Add(mceqaPos[i]);
                    }
                    break;
            }
        }

        private void AddButton_Click_1(object sender, EventArgs e)
        {
            string errorMsg = "";
            bool valid = true;
            if (string.IsNullOrWhiteSpace(fName.Text) || string.IsNullOrWhiteSpace(lName.Text) || 
               (DepartmentSearchDD.SelectedIndex > -1 && PositionSearchDD.SelectedIndex == -1) || DepartmentSearchDD.SelectedIndex == -1)
            {
                valid = false;
                MessageBox.Show("Please fill all the required fields", "Human Resource Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (ApplicationDate > DateTime.Now)
                {
                    errorMsg = errorMsg + "Application Date cannot be a future date" + Environment.NewLine;
                    valid = false;
                }
                if (!Int1.Checked && (Int2.Checked || Int3.Checked))
                {
                    errorMsg = errorMsg + "You cannot have a Second or Third interview without the First." + Environment.NewLine;
                    valid = false;
                }
                if(Int3.Checked && !Int2.Checked)
                {
                    errorMsg = errorMsg + "You cannot have a Third interview without the Second." + Environment.NewLine;
                    valid = false;
                }
                if (valid == true)
                {

                    da.RP.Add();
                    MessageBox.Show("New Record Added", "Human Resource Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(errorMsg, "Human Resource Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            ApplicationDate = DateTime.Now;
            fName.Clear();
            lName.Clear();
            mName.Clear();
            DepartmentSearchDD.SelectedIndex = -1;
            PositionSearchDD.SelectedIndex = -1;
            Int1.Checked = false;
            Int2.Checked = false;
            Int3.Checked = false;
            Training.Checked = false;
            Resume.Checked = false;
            BC.Checked = false;
            SSS.Checked = false;
            NBI.Checked = false;
            Police.Checked = false;
            PI.Checked = false;
            PH.Checked = false;
            BIR.Checked = false;
            TOR.Checked = false;
            CoE.Checked = false;
            ME.Checked = false;
        }
    }
}
