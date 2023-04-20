﻿using System;
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

namespace HRMS.View.UI.IncidentReport
{
    public partial class addReport : UserControl, iIncident
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

        public string LastName { get {return lNames.SelectedItem.ToString(); } set {  lNames.SelectedIndex = -1;  } }
        public string FirstName { get { return fNames.SelectedItem.ToString(); } set { fNames.SelectedIndex = -1; } }
        public string MiddleInitial { get { return mNames.SelectedItem.ToString(); } set { mNames.SelectedIndex = -1; } }
        public string Position { get { return position.SelectedItem.ToString(); } set { position.SelectedIndex = -1; } }
        public string Department { get {return dept.SelectedItem.ToString(); ; } set { dept.SelectedIndex = -1; } }
        public DateTime DatePosted { get {return subdate.Value; } set { subdate.Value = value; } }
        public string PeopleInvolved { get {return PIs.Text; } set { PIs.Text = value; } }
        public string Incident { get {return incidentdetail.Text; } set { incidentdetail.Text = value; } }
        public string Remarks { get { return remarks.Text; } set {remarks.Text = value; } }
        public string ApprovedBy { get { return approved.Text; } set {approved.Text = value; } }

        public addReport()
        {
            InitializeComponent();
            this.LRA = new Log_RegAdapter(Directory.aList);
            this.IRA = new DashAdapter(this);
            RefreshNames();
        }

        public  void RefreshNames()
        {
          fNames.Items.Clear();
          lNames.Items.Clear();
          mNames.Items.Clear();
          IEnumerable<UserModel> Names = LRA.crud.GetAll();
            for (int i = 0; i < Names.Count(); i++)
            {
                fNames.Items.Add(Names.ElementAt(i).FirstName);
                lNames.Items.Add(Names.ElementAt(i).LastName);
                mNames.Items.Add(Names.ElementAt(i).MiddleName);
            }
        }

        private void dept_SelectedIndexChanged(object sender, EventArgs e)
        {
            position.Items.Clear();
            switch (dept.SelectedIndex)
            {
                case 0:
                    position.Items.Add("President");
                    position.SelectedIndex = 0;
                    break;
                case 1:
                    position.Items.Add("General Manager");
                    position.SelectedIndex = 0;
                    break;
                case 2:
                    for (int i = 0; i < acctPos.Length; i++)
                    {
                        position.Items.Add(acctPos[i]);
                    }
                    break;
                case 3:
                    for (int i = 0; i < retailPos.Length; i++)
                    {
                        position.Items.Add(retailPos[i]);
                    }
                    break;
                case 4:
                    for (int i = 0; i < auditPos.Length; i++)
                    {
                        position.Items.Add(auditPos[i]);
                    }
                    break;
                case 5:
                    for (int i = 0; i < misPos.Length; i++)
                    {
                        position.Items.Add(misPos[i]);
                    }
                    break;
                case 6:
                    for (int i = 0; i < securityPos.Length; i++)
                    {
                        position.Items.Add(securityPos[i]);
                    }
                    break;
                case 7:
                    for (int i = 0; i < purchasingPos.Length; i++)
                    {
                        position.Items.Add(purchasingPos[i]);
                    }
                    break;
                case 8:
                    for (int i = 0; i < merchPos.Length; i++)
                    {
                        position.Items.Add(merchPos[i]);
                    }
                    break;
                case 9:
                    for (int i = 0; i < hrmdPos.Length; i++)
                    {
                        position.Items.Add(hrmdPos[i]);
                    }
                    break;
                case 10:
                    for (int i = 0; i < marketPos.Length; i++)
                    {
                        position.Items.Add(marketPos[i]);
                    }
                    break;
                case 11:
                    for (int i = 0; i < creativesPos.Length; i++)
                    {
                        position.Items.Add(creativesPos[i]);
                    }
                    break;
                case 12:
                    for (int i = 0; i < warelogPos.Length; i++)
                    {
                        position.Items.Add(warelogPos[i]);
                    }
                    break;
                case 13:
                    for (int i = 0; i < mcePos.Length; i++)
                    {
                        position.Items.Add(mcePos[i]);
                    }
                    break;
                case 14:
                    for (int i = 0; i < mceqaPos.Length; i++)
                    {
                        position.Items.Add(mceqaPos[i]);
                    }
                    break;
            }
        }

        private void addEmpBtn_Click(object sender, EventArgs e)
        {
            string errorMsg = "";
            bool valid = true;
            if(lNames.SelectedIndex == -1 || fNames.SelectedIndex == -1 || dept.SelectedIndex == -1 ||
                position.SelectedIndex == -1 || string.IsNullOrWhiteSpace(incidentdetail.Text) || string.IsNullOrWhiteSpace(PIs.Text)||
                string.IsNullOrWhiteSpace(approved.Text))
            {
                valid = false;
                MessageBox.Show("Please fill all the required fields", "Human Resource Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else
            {
                UserModel test = new UserModel();
                test.LastName = LastName;
                test.FirstName = FirstName;
                test.MiddleName = MiddleInitial;
                test.Department = Department;
                test.Position = Position;
                if (dept.SelectedIndex > -1 && position.SelectedIndex == -1)
                {
                    valid = false;
                    errorMsg = errorMsg + "Please select a position in your chosen department" + Environment.NewLine;
                }
                if (subdate.Value > DateTime.Now)
                {
                    valid = false;
                    errorMsg = errorMsg + "Incident cannot happen past the current date." + Environment.NewLine;
                }
                if (LRA.crud.checkifExists(test) < 1)
                {
                    valid = false;
                    errorMsg = errorMsg + "An applicable employee does not exist." + Environment.NewLine;
                }
                if(valid == true)
                {
                    IRA.IR.AddReport();
                    Directory.vReport.refreshList();
                } else
                {
                    MessageBox.Show(errorMsg, "Human Resource Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            lNames.SelectedIndex = -1;
            fNames.SelectedIndex = -1;
            mNames.SelectedIndex = -1;
            dept.SelectedIndex = -1;
            position.SelectedIndex = -1;
            incidentdetail.Clear();
            PIs.Clear();
            subdate.Value = DateTime.Now;
            approved.Clear();
            remarks.Clear();
        }

        private void lNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lNames.SelectedIndex > -1)
            {
                fNames.SelectedIndex = lNames.SelectedIndex;
                mNames.SelectedIndex = lNames.SelectedIndex;
            }
        }

        private void fNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(fNames.SelectedIndex > -1)
            {
                lNames.SelectedIndex = fNames.SelectedIndex;
                mNames.SelectedIndex = fNames.SelectedIndex;
            }
        }

        private void mNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mNames.SelectedIndex > -1)
            {
                lNames.SelectedIndex = mNames.SelectedIndex;
                fNames.SelectedIndex = mNames.SelectedIndex;
            }
        }

        public void setIncidentBS(BindingSource bs)
        {
            Console.Write("Somwthing");
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
