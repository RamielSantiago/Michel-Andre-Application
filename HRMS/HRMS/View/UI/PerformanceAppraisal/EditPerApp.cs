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

namespace HRMS.View.UI.PerformanceAppraisal
{
    public partial class EditPerApp : UserControl, iAppraisal
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
        public int Attendance { get { return attend; } set { attend = value; } }
        public int Accuracy { get { return accurate; } set {accurate = value; } }
        public int HouseKeeping { get { return house; } set { house = value; } }
        public int Efficiency { get { return efficient; } set { efficient = value; } }
        public int CourtesyAtt { get { return courteous; } set { courteous = value; } }
        public int Alertness { get { return alert; } set { alert = value; } }
        public int DRR { get { return DDR; } set { DDR = value; } }
        public int Cooperation { get { return coop; } set { coop = value; } }
        public int CCP { get { return compliance; } set { compliance = value; } }
        public int Judgement { get { return judge; } set {judge = value; } }
        public int Appearance { get { return appear; } set {appear = value; } }
        public int Friendliness { get { return friend; } set {friend = value; } }
        public int Total { get { return score; } set { score = value; } }
        public DateTime appDate { get { return DateTime.Now; } set { appDate = DateTime.Now; } }

        public EditPerApp()
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

            attendance.Enabled = false;
            accuracy.Enabled = false;
            housekeeping.Enabled = false;
            efficiency.Enabled = false;
            courtesy.Enabled = false;
            alertness.Enabled = false;
            ddr.Enabled = false;
            comply.Enabled = false;
            cooperation.Enabled = false;
            judgement.Enabled = false;
            appearance.Enabled = false;
            friendliness.Enabled = false;
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

        public void setAppraisalBS(BindingSource bs)
        {
            Console.Write("Something");
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

        private void updateApp_Click(object sender, EventArgs e)
        {
            bool valid = true;
            string errorMsg = "";
            if (lNames.SelectedIndex == -1 || fNames.SelectedIndex == -1 || mNames.SelectedIndex == -1 || dept.SelectedIndex == -1 ||
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
                var toUpdate = new AppraisalModel();
                toUpdate.FirstName = fNames.SelectedItem.ToString();
                toUpdate.LastName = lNames.SelectedItem.ToString();
                toUpdate.MiddleName = mNames.SelectedItem.ToString();
                toUpdate.Department = dept.SelectedItem.ToString();
                toUpdate.Position = position.SelectedItem.ToString();
                toUpdate.appDate = appDatePick.Value.Date;
                toUpdate = IRA.crudApp.getExisting(toUpdate);
                if (toUpdate.FirstName.Equals(""))
                {
                    valid = false;
                    errorMsg = errorMsg + "No such record exists." + Environment.NewLine;
                }
                if (valid)
                {
                    int upTotal = 0; ;
                    int count = 0 ;
                    if (eAtt.Checked)
                    {
                        count++;
                        toUpdate.Attendance = Attendance;
                        upTotal += toUpdate.Attendance;
                    }
                    else
                    {
                        upTotal += toUpdate.Attendance;
                        toUpdate.Attendance = -1;
                    }
                    if (eAcc.Checked)
                    {
                        count++;
                        toUpdate.Accuracy = Accuracy;
                        upTotal += toUpdate.Accuracy;
                    }
                    else
                    {
                        upTotal += toUpdate.Accuracy;
                        toUpdate.Accuracy = -1;
                    }
                    if (eHK.Checked)
                    {
                        count++;
                        toUpdate.HouseKeeping = HouseKeeping;
                        upTotal += toUpdate.HouseKeeping;
                    }
                    else
                    {
                        upTotal += toUpdate.HouseKeeping;
                        toUpdate.HouseKeeping = -1;
                    }
                    if (eEff.Checked)
                    {
                        count++;
                        toUpdate.Efficiency = Efficiency;
                        upTotal += toUpdate.Efficiency;
                    }
                    else
                    {
                        upTotal += toUpdate.Efficiency;
                        toUpdate.Efficiency = -1;
                    }
                    if (eCAA.Checked)
                    {
                        count++;
                        toUpdate.CourtesyAtt = CourtesyAtt;
                        upTotal += toUpdate.CourtesyAtt;
                    }
                    else
                    {
                        upTotal += toUpdate.CourtesyAtt;
                        toUpdate.CourtesyAtt = -1;
                    }
                    if (eAl.Checked)
                    {
                        count++;
                        toUpdate.Alertness = Alertness;
                        upTotal += toUpdate.Alertness;
                    }
                    else
                    {
                        upTotal += toUpdate.Alertness;
                        toUpdate.Alertness = -1;
                    }
                    if (eDRR.Checked)
                    {
                        count++;
                        toUpdate.DRR = DRR;
                        upTotal += toUpdate.DRR;
                    }
                    else
                    {
                        upTotal += toUpdate.DRR;
                        toUpdate.DRR = -1;
                    }
                    if (eCRR.Checked)
                    {
                        count++;
                        toUpdate.CCP = CCP;
                        upTotal += toUpdate.CCP;
                    }
                    else
                    {
                        upTotal += toUpdate.CCP;
                        toUpdate.CCP = -1;
                    }
                    if (eCoop.Checked)
                    {
                        count++;
                        toUpdate.Cooperation = Cooperation;
                        upTotal += toUpdate.Cooperation;
                    }
                    else
                    {
                        upTotal += toUpdate.Cooperation;
                        toUpdate.Cooperation = -1;
                    }
                    if (eJud.Checked)
                    {
                        count++;
                        toUpdate.Judgement = Judgement;
                        upTotal += toUpdate.Judgement;
                    }
                    else
                    {
                        upTotal += toUpdate.Judgement;
                        toUpdate.Judgement = -1;
                    }
                    if (ePA.Checked)
                    {
                        count++;
                        toUpdate.Appearance = Appearance;
                        upTotal += toUpdate.Appearance;
                    }
                    else
                    {
                        upTotal += toUpdate.Appearance;
                        toUpdate.Appearance = -1;
                    }
                    if (eFF.Checked)
                    {
                        count++;
                        toUpdate.Friendliness = Friendliness;
                        upTotal += toUpdate.Friendliness;
                    }
                    else
                    {
                        upTotal += toUpdate.Friendliness;
                        toUpdate.Friendliness = -1;
                    }
                    toUpdate.Total = upTotal;

                    IRA.APP.Update(toUpdate);
                    MessageBox.Show("Update Successful", "Human Resource Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(errorMsg, "Human Resource Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
                
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

        private void eAtt_CheckedChanged(object sender, EventArgs e)
        {
            if (eAtt.Checked)
            {
                attendance.Enabled = true;
            }
            else
            {
                attendance.Enabled = false;
            }
        }

        private void eAcc_CheckedChanged(object sender, EventArgs e)
        {
            if (eAcc.Checked)
            {
                accuracy.Enabled = true;
            }
            else
            {
                accuracy.Enabled = false;
            }
        }

        private void eHK_CheckedChanged(object sender, EventArgs e)
        {
            if (eHK.Checked)
            {
                housekeeping.Enabled = true;
            }
            else
            {
                housekeeping.Enabled = false;
            }
        }

        private void eEff_CheckedChanged(object sender, EventArgs e)
        {
            if (eEff.Checked)
            {
                efficiency.Enabled = true;
            }
            else
            {
                efficiency.Enabled = false;
            }
        }

        private void eCAA_CheckedChanged(object sender, EventArgs e)
        {
            if (eCAA.Checked)
            {
                courtesy.Enabled = true;
            }
            else
            {
                courtesy.Enabled = false;
            }
        }

        private void eAl_CheckedChanged(object sender, EventArgs e)
        {
            if (eAl.Checked)
            {
                alertness.Enabled = true;
            }
            else
            {
                alertness.Enabled = false;
            }
        }

        private void eDRR_CheckedChanged(object sender, EventArgs e)
        {
            if (eDRR.Checked)
            {
                ddr.Enabled = true;
            }
            else
            {
                ddr.Enabled = false;
            }
        }

        private void eCRR_CheckedChanged(object sender, EventArgs e)
        {
            if (eCRR.Checked)
            {
                comply.Enabled = true;
            }
            else
            {
                comply.Enabled = false;
            }
        }

        private void eCoop_CheckedChanged(object sender, EventArgs e)
        {
            if (eCoop.Checked)
            {
                cooperation.Enabled = true;
            }
            else
            {
                cooperation.Enabled = false;
            }
        }

        private void eJud_CheckedChanged(object sender, EventArgs e)
        {
            if (eJud.Checked)
            {
                judgement.Enabled = true;
            }
            else
            {
                judgement.Enabled = false;
            }
        }

        private void ePA_CheckedChanged(object sender, EventArgs e)
        {
            if (ePA.Checked)
            {
                appearance.Enabled = true;
            }
            else
            {
                appearance.Enabled = false;
            }
        }

        private void eFF_CheckedChanged(object sender, EventArgs e)
        {
            if (eFF.Checked)
            {
                friendliness.Enabled = true;
            }
            else
            {
                friendliness.Enabled = false;
            }
        }
    }
}
