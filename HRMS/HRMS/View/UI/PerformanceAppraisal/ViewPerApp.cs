using HRMS.Model.DBInterfaces;
using HRMS.Model.DBModels;
using HRMS.Resources.Tools;
using HRMS.View.Adapters;
using HRMS.View.Interfaces;
using HRMS.View.UI.Recruitment;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace HRMS.View.UI.PerformanceAppraisal
{
    public partial class ViewPerApp : UserControl, iAppraisal
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

        public string FirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string MiddleName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Position { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Department { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Attendance { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Accuracy { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int HouseKeeping { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Efficiency { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int CourtesyAtt { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Alertness { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int DRR { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Cooperation { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int CCP { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Judgement { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Appearance { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Friendliness { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Total { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime appDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public ViewPerApp()
        {
            InitializeComponent(); 
            this.LRA = new Log_RegAdapter(Directory.uList);
            this.IRA = new DashAdapter(this);
            DateAdd.Visible = false;
            refreshList();
        }

        public void refreshList()
        {
            IRA.APP.LoadAllAppraisals();
        }

        private void appraisals_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (appraisals.Columns[e.ColumnIndex].Name == "btndelete")
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLConnectionString"].ConnectionString))
                {
                    con.Open();
                    if (Convert.ToInt32(this.appraisals.Rows[e.RowIndex].Cells[1].Value) > 0)
                    {
                        using (SqlCommand command = new SqlCommand())
                        {
                            command.Connection = con;
                            command.CommandText = "DELETE FROM PerformanceAppraisal WHERE AppraisalID = @RID";
                            command.Parameters.AddWithValue("@RID", Convert.ToInt32(this.appraisals.Rows[e.RowIndex].Cells[1].Value));
                            command.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Record with ID 0 cannot be deleted.", "Human Resource Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    con.Close();
                }
                refreshList();
            }
        }

        private void searchapp_Click(object sender, EventArgs e)
       {
            bool valid = true;
            string errorMsg = "";
            if(appsearchcriteria.SelectedIndex == -1)
            {
                valid = false;
                MessageBox.Show("Please select a criteria for your query", "Human Resource Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(appsearchcriteria.SelectedIndex == 0 && string.IsNullOrWhiteSpace(aID.Text))
            {
                valid = false;
                MessageBox.Show("Please enter a value to search", "Human Resource Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else if (appsearchcriteria.SelectedIndex > 0 && appsearchcriteria.SelectedIndex < 4 && query.SelectedIndex == -1)
            {
                valid = false;
                MessageBox.Show("Please select a value to search", "Human Resource Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else if (appsearchcriteria.SelectedIndex == 4 && DateAdd.Value > DateTime.Now)
            {
                valid = false;
                MessageBox.Show("Date Input cannot be past the current date", "Human Resource Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (appsearchcriteria.SelectedIndex == 0)
            {
                try
                {
                    Convert.ToInt32(aID.Text);
                }
                catch (FormatException Ex)
                {
                    valid = false;
                    MessageBox.Show("Appraisal IDs are Numeric", "Human Resource Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            if (valid)
            {
                string finalquery = "";
                switch (appsearchcriteria.SelectedIndex)
                {
                    case 0:finalquery = aID.Text;
                        break;
                    case 1:finalquery = query.SelectedItem.ToString();
                        break;
                    case 2:
                        finalquery = query.SelectedItem.ToString();
                        break;
                    case 3:
                        finalquery = query.SelectedItem.ToString();
                        break;
                    case 4:
                        finalquery = DateAdd.Value.ToString();
                        break;
                }
                if(IRA.APP.Search(appsearchcriteria.SelectedIndex, finalquery) == -1)
                {
                    MessageBox.Show("No Results found", "Human Resource Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void lNamesChanged()
        {
            query.Items.Clear();
            var users = LRA.crud.GetAll();
            for(int i = 0; i < users.Count(); i++)
            {
                query.Items.Add(users.ElementAt(i).LastName);
            }
        }

        private void fNamesChanged()
        {
            query.Items.Clear();
            var users = LRA.crud.GetAll();
            for (int i = 0; i < users.Count(); i++)
            {
                query.Items.Add(users.ElementAt(i).FirstName);
            }
        }

        public void setAppraisalBS(BindingSource bs)
        {
            appraisals.DataSource = bs;
            var deleteButton = new DataGridViewButtonColumn();
            deleteButton.Name = "btndelete";
            deleteButton.HeaderText = "Delete";
            deleteButton.UseColumnTextForButtonValue = true;
            deleteButton.Text = "Delete";
            appraisals.Columns.Add(deleteButton);
        }

        private void appsearchcriteria_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(appsearchcriteria.SelectedIndex)
            {
                case 0:
                    aID.BringToFront();
                    DateAdd.SendToBack();
                    query.SendToBack();
                    query.Visible = false;
                    DateAdd.Visible = false;
                    aID.Visible = true;
                    break;
                case 1:
                    lNamesChanged();
                    aID.SendToBack();
                    DateAdd.SendToBack();
                    query.BringToFront();
                    query.Visible = true;
                    DateAdd.Visible = false;
                    aID.Visible = false;
                    break;
                case 2:
                    fNamesChanged();
                    aID.SendToBack();
                    DateAdd.SendToBack();
                    query.BringToFront();
                    query.Visible = true;
                    DateAdd.Visible = false;
                    aID.Visible = false;
                    break;
                case 3:
                    switchToDepts();
                    aID.SendToBack();
                    DateAdd.SendToBack();
                    query.BringToFront();
                    query.Visible = true;
                    DateAdd.Visible = false;
                    aID.Visible = false;
                    break;
                case 4:
                    aID.SendToBack();
                    DateAdd.BringToFront();
                    query.SendToBack();
                    query.Visible = false;
                    DateAdd.Visible = true;
                    aID.Visible = false;
                    break;
            }
        }

        private void switchToDepts()
        {
            query.Items.Clear();
            query.Items.Add("President");
            query.Items.Add("General Manager");
            query.Items.Add("Accounting");
            query.Items.Add("Retail Sales Operation");
            query.Items.Add("Audit");
            query.Items.Add("MIS");
            query.Items.Add("Administration");
            query.Items.Add("Purchasing");
            query.Items.Add("Merchandising");
            query.Items.Add("HRMD");
            query.Items.Add("Marketing");
            query.Items.Add("Creative");
            query.Items.Add("Warehouse and Logistics");
            query.Items.Add("MCE Production");
            query.Items.Add("MCE Quality Assurance");
        }

        private void query_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
