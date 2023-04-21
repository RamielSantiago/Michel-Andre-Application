using System;
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
using System.Xml.Linq;
using HRMS.Model.DBModels;
using HRMS.Resources.Tools;
using HRMS.View.Adapters;
using HRMS.View.Interfaces;

namespace HRMS.View.UI.IncidentReport
{
    public partial class viewReports : UserControl, iIncident
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

        DashAdapter IRA;
        Log_RegAdapter LRA;
        public viewReports()
        {
            InitializeComponent();
            this.IRA = new DashAdapter(this);
            this.LRA = new Log_RegAdapter(Directory.aList);
            RefreshNames();
            refreshList();
        }

        public string LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string FirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string MiddleInitial { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Position { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Department { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime DateOccurred { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime DatePosted { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string PeopleInvolved { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Incident { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Remarks { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string ApprovedBy { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void setIncidentBS(BindingSource bs)
        {
            reports.DataSource= bs;
            var deleteButton = new DataGridViewButtonColumn();
            deleteButton.Name = "btndelete";
            deleteButton.HeaderText = "Delete";
            deleteButton.UseColumnTextForButtonValue = true;
            deleteButton.Text = "Delete";
            reports.Columns.Add(deleteButton);
        }
        public void refreshList()
        {
            IRA.IR.LoadAllReports();
        }

        private void rSearchBtn_Click(object sender, EventArgs e)
        {
            if (LastNames.SelectedIndex == -1 && FNames.SelectedIndex == -1 && dept.SelectedIndex == -1 && position.SelectedIndex == -1)
            {
                MessageBox.Show("Please provide a criteria to search from the dropdowns above the table", "Human Resource Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int[] criterias = new int[4];
                string[] queries = new string[4];
                if(LastNames.SelectedIndex > -1)
                {
                    criterias[0] = 1;
                    queries[0] = LastNames.SelectedItem.ToString();
                }
                else
                {
                    criterias[0] = 0;
                    queries[0] = "";
                }

                if (FNames.SelectedIndex > -1)
                {
                    criterias[1] = 1;
                    queries[1] = FNames.SelectedItem.ToString();
                }
                else
                {
                    criterias[1] = 0;
                    queries[1] = "";
                }

                if (dept.SelectedIndex > -1)
                {
                    criterias[2] = 1;
                    queries[2] = dept.SelectedItem.ToString();
                }
                else
                {
                    criterias[2] = 0;
                    queries[2] = "";
                }

                if (position.SelectedIndex > -1)
                {
                    criterias[3] = 1;
                    queries[3] = position.SelectedItem.ToString();
                }
                else
                {
                    criterias[3] = 0;
                    queries[3] = "";
                }

                if(IRA.IR.SearchReport(criterias, queries) == -1)
                {
                    MessageBox.Show("No Results Found.", "Human Resource Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            LastNames.SelectedIndex = -1;
            FNames.SelectedIndex = -1;
            dept.SelectedIndex = -1;
            position.SelectedIndex = -1;
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

        public void RefreshNames()
        {
            LastNames.Items.Clear();
            FNames.Items.Clear();
            IEnumerable<UserModel> Names = LRA.crud.GetAll();
            for (int i = 0; i < Names.Count(); i++)
            {
                FNames.Items.Add(Names.ElementAt(i).FirstName);
                LastNames.Items.Add(Names.ElementAt(i).LastName);
            }
        }

        private void reports_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (reports.Columns[e.ColumnIndex].Name == "btndelete")
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLConnectionString"].ConnectionString))
                {
                    con.Open();
                    if (Convert.ToInt32(this.reports.Rows[e.RowIndex].Cells[1].Value) > 0)
                    {
                        using (SqlCommand command = new SqlCommand())
                        {
                            command.Connection = con;
                            command.CommandText = "DELETE FROM Incidents WHERE IncidentID = @iID";
                            command.Parameters.AddWithValue("@iID", Convert.ToInt32(this.reports.Rows[e.RowIndex].Cells[1].Value));
                            command.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Report with ID 0 cannot be deleted.", "Human Resource Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    con.Close();
                }
                refreshList();
            }
        }

        private void LastNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LastNames.SelectedIndex > -1)
            {
                FNames.SelectedIndex = LastNames.SelectedIndex;
            }
        }

        private void FNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FNames.SelectedIndex > -1)
            {
                LastNames.SelectedIndex = FNames.SelectedIndex;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
