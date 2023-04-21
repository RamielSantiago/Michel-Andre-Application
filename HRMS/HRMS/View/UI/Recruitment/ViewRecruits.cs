using HRMS.Model.DBModels;
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
using HRMS.View.Interfaces;
using HRMS.View.Adapters;
using HRMS.Resources.Tools;
using HRMS.Model.DBInterfaces;
using System.Configuration;
using System.Data.SqlClient;

namespace HRMS.View.UI.Recruitment
{
    public partial class ViewRecruits : UserControl, iRecruit
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
        
        

        public string FirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string MiddleName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Position { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Department { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime ApplicationDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool InterInterview1 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool InterInterview2 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool InterInterview3 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool training { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool resume { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool PSA { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool sss { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool nbi { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool police { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool PagIbig { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool philhealth { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool bir { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool tor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool EmpCert { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool MedExam { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string OverallStatus { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public ViewRecruits()
        {
            InitializeComponent();
            this.LRA = new Log_RegAdapter(Directory.uList);
            this.da = new DashAdapter(this);
            RefreshNames();
            refreshList();
        }

        private void lNames_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fNames_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void PositionSearchDD_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void RefreshNames()
        {
            fNames.Items.Clear();
            lNames.Items.Clear();
            IEnumerable<RecruitModel> Names = da.crudRec.GetAll();
            for (int i = 1; i < Names.Count(); i++)
            {
                fNames.Items.Add(Names.ElementAt(i).FirstName);
                lNames.Items.Add(Names.ElementAt(i).LastName);
            }
            //lNames.Items.RemoveAt(0);
            //fNames.Items.RemoveAt(0);
        }

        public void refreshList()
        {
            da.RP.LoadAllRecruits();
        }

        public void setRecruitBS(BindingSource bs)
        {
            recruitment.DataSource = bs;
            var deleteButton = new DataGridViewButtonColumn();
            deleteButton.Name = "btndelete";
            deleteButton.HeaderText = "Delete";
            deleteButton.UseColumnTextForButtonValue = true;
            deleteButton.Text = "Delete";
            recruitment.Columns.Add(deleteButton);
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (lNames.SelectedIndex == -1 && fNames.SelectedIndex == -1 && DepartmentSearchDD.SelectedIndex == -1 && PositionSearchDD.SelectedIndex == -1)
            {
                MessageBox.Show("Please provide a criteria to search from the dropdowns above the table", "Human Resource Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int[] criterias = new int[4];
                string[] queries = new string[4];
                if (lNames.SelectedIndex > -1)
                {
                    criterias[0] = 1;
                    queries[0] = lNames.SelectedItem.ToString();
                }
                else
                {
                    criterias[0] = 0;
                    queries[0] = "";
                }

                if (fNames.SelectedIndex > -1)
                {
                    criterias[1] = 1;
                    queries[1] = fNames.SelectedItem.ToString();
                }
                else
                {
                    criterias[1] = 0;
                    queries[1] = "";
                }

                if (DepartmentSearchDD.SelectedIndex > -1)
                {
                    criterias[2] = 1;
                    queries[2] = DepartmentSearchDD.SelectedItem.ToString();
                }
                else
                {
                    criterias[2] = 0;
                    queries[2] = "";
                }

                if (PositionSearchDD.SelectedIndex > -1)
                {
                    criterias[3] = 1;
                    queries[3] = PositionSearchDD.SelectedItem.ToString();
                }
                else
                {
                    criterias[3] = 0;
                    queries[3] = "";
                }

                if (da.RP.Search(criterias, queries) == -1)
                {
                    MessageBox.Show("No Results Found.", "Human Resource Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            fNames.SelectedIndex = -1;
            lNames.SelectedIndex = -1;
            DepartmentSearchDD.SelectedIndex = -1;
            PositionSearchDD.SelectedIndex = -1;
        }

        private void recruitment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (recruitment.Columns[e.ColumnIndex].Name == "btndelete")
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLConnectionString"].ConnectionString))
                {
                    con.Open();
                    if (Convert.ToInt32(this.recruitment.Rows[e.RowIndex].Cells[1].Value) > 0)
                    {
                        using (SqlCommand command = new SqlCommand())
                        {
                            command.Connection = con;
                            command.CommandText = "DELETE FROM Recruitment WHERE RecruitID = @RID";
                            command.Parameters.AddWithValue("@RID", Convert.ToInt32(this.recruitment.Rows[e.RowIndex].Cells[1].Value));
                            command.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Recruit with ID 0 cannot be deleted.", "Human Resource Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    con.Close();
                }
                refreshList();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
