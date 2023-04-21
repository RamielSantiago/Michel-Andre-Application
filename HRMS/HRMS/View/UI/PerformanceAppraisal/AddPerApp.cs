﻿using HRMS.Model.DBModels;
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

namespace HRMS.View.UI.PerformanceAppraisal
{
    public partial class AddPerApp : UserControl, iAppraisal
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
        private int attend = 0, accurate = 0, house = 0, efficient = 0, courteous = 0, alert = 0, DDR = 0, compliance = 0, coop = 0, judge = 0, appear = 0, friend = 0;
        private int score = 0;

        public string FirstName { get { return fNames.SelectedItem.ToString(); } set { fNames.SelectedIndex = -1; } }
        public string LastName { get { return lNames.SelectedItem.ToString(); } set { lNames.SelectedIndex = -1; } }
        public string MiddleName { get { return mNames.SelectedItem.ToString(); } set { mNames.SelectedIndex = -1; } }
        public string Position { get { return position.SelectedItem.ToString(); } set { position.SelectedIndex = -1; } }
        public string Department { get { return dept.SelectedItem.ToString(); } set { dept.SelectedIndex = -1; } }
        public DateTime appDate { get { return DateTime.Now; } set { appDate = DateTime.Now; } }
        public int Attendance { get { return attendance.SelectedIndex; } set { Attendance = 0;} }
        public int Accuracy { get { return accuracy.SelectedIndex; } set { Accuracy = 0; } }
        public int HouseKeeping { get { return housekeeping.SelectedIndex; } set { HouseKeeping = 0; } }
        public int Efficiency { get { return efficiency.SelectedIndex; } set { Efficiency = 0; } }
        public int CourtesyAtt { get { return courtesy.SelectedIndex; } set { CourtesyAtt = 0; } }
        public int Alertness { get { return alertness.SelectedIndex; } set { Alertness = 0; } }
        public int DRR { get { return ddr.SelectedIndex; } set { DRR = 0; } }
        public int Cooperation { get { return cooperation.SelectedIndex; } set { Cooperation = 0; } }
        public int CCP { get { return comply.SelectedIndex; } set { CCP = 0; } }
        public int Judgement { get { return judgement.SelectedIndex; } set { Judgement = 0; } }
        public int Appearance { get { return appearance.SelectedIndex; } set { Appearance = 0; } }
        public int Friendliness { get { return friendliness.SelectedIndex; } set { Friendliness = 0; } }
        public int Total { get { return score; } set { score = 0; } }

        public AddPerApp()
        {
            InitializeComponent(); 
            this.LRA = new Log_RegAdapter(Directory.uList);
            this.IRA = new DashAdapter(this);
            RefreshNames();
            attendance.SelectedIndex = 0;
            accuracy.SelectedIndex = 0;
            housekeeping.SelectedIndex = 0;
            efficiency.SelectedIndex = 0;
            courtesy.SelectedIndex = 0;
            alertness.SelectedIndex = 0;
            ddr.SelectedIndex = 0;
            comply.SelectedIndex = 0;
            cooperation.SelectedIndex = 0;
            judgement.SelectedIndex = 0;
            appearance.SelectedIndex = 0;
            friendliness.SelectedIndex = 0;
        }
        public void RefreshNames()
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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
        private void addPA_Click(object sender, EventArgs e)
        {
            bool valid = true;
            string errorMsg = "";
            if(lNames.SelectedIndex == -1 || fNames.SelectedIndex == -1 || mNames.SelectedIndex == -1 || dept.SelectedIndex == -1 ||
                position.SelectedIndex == -1)
            {
                valid = false;
                MessageBox.Show("Please fill all the required fields", "Human Resource Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var test = new UserModel();
                test.FirstName = fNames.SelectedItem.ToString();
                test.LastName = lNames.SelectedItem.ToString();
                test.MiddleName = mNames.SelectedItem.ToString();
                test.Department = dept.SelectedItem.ToString();
                test.Position = position.SelectedItem.ToString();
                if (LRA.crud.checkifExists(test) == 0)
                {
                    valid = false;
                    errorMsg = errorMsg + "No such user exists." + Environment.NewLine;
                }
                if (valid)
                {
                    IRA.APP.Add();
                    MessageBox.Show("New Appraisal Added", "Human Resource Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                } else
                {
                    MessageBox.Show(errorMsg, "Human Resource Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            attendance.SelectedIndex = 0;
            accuracy.SelectedIndex = 0;
            housekeeping.SelectedIndex = 0;
            efficiency.SelectedIndex = 0;
            courtesy.SelectedIndex = 0;
            alertness.SelectedIndex = 0;
            ddr.SelectedIndex = 0;
            comply.SelectedIndex = 0;
            cooperation.SelectedIndex = 0;
            judgement.SelectedIndex = 0;
            appearance.SelectedIndex = 0;
            friendliness.SelectedIndex = 0;
        }

        private void housekeeping_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeTotalScore();
        }

        private void efficiency_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeTotalScore();
        }

        private void courtesy_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeTotalScore();
        }

        private void alertness_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeTotalScore();
        }

        private void ddr_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeTotalScore();
        }

        private void comply_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeTotalScore();
        }

        private void cooperation_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeTotalScore();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void position_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void judgement_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeTotalScore();
        }

        private void appearance_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeTotalScore();
        }

        private void friendliness_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeTotalScore();
        }

        private void attendance_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeTotalScore();
        }
        private void accuracy_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeTotalScore();
        }

        private void changeTotalScore()
        {
            attend = attendance.SelectedIndex;
            accurate = accuracy.SelectedIndex;
            house = housekeeping.SelectedIndex;
            efficient = efficiency.SelectedIndex;
            courteous = courtesy.SelectedIndex;
            alert = alertness.SelectedIndex;
            DDR = ddr.SelectedIndex;
            compliance = comply.SelectedIndex;
            coop = cooperation.SelectedIndex;
            judge = judgement.SelectedIndex;
            appear = appearance.SelectedIndex;
            friend = friendliness.SelectedIndex;

            score = attend + accurate + house + efficient + courteous + alert + DDR + compliance + coop + judge + appear + friend;
            total.Text = "Total: " + score.ToString() + "%";
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

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
            if (fNames.SelectedIndex > -1)
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

        public void setAppraisalBS(BindingSource bs)
        {
            Console.Write("Something");
        }
    }
}
