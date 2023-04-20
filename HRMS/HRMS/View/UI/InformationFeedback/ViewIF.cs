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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using HRMS.Model.DBModels;
using HRMS.Resources.Tools;
using HRMS.View.Adapters;
using HRMS.View.Interfaces;

namespace HRMS.View.UI.InformationFeedback
{
    public partial class ViewIF : UserControl, iFeedback
    {
        DashAdapter IRA;
        Log_RegAdapter LRA;
        public ViewIF()
        {
            InitializeComponent();
            this.IRA = new DashAdapter(this);
            this.LRA = new Log_RegAdapter(Directory.aList);
            RefreshNames();
            refreshList();
        }

        public string FirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string MiddleInitial { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Department { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Position { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime DatePosted { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Topic { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Detail { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string CourseOfAction { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool HRofficer { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool Supervisor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool President { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int FeedbackID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string To { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string From { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Subject { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime date { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Details { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string RecAct { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Comments { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool CompSig { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool HRSig { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool SuperSig { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool PresSig { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void setFeedbackBS(BindingSource bs)
        {
            feedback.DataSource = bs;
            var deleteButton = new DataGridViewButtonColumn();
            deleteButton.Name = "btndelete";
            deleteButton.HeaderText = "Delete";
            deleteButton.UseColumnTextForButtonValue = true;
            deleteButton.Text = "Delete";
            feedback.Columns.Add(deleteButton);
        }
        public void refreshList()
        {
            IRA.FB.LoadAllFeedback();
        }

        public void RefreshNames()
        {
            to.Items.Clear();
            from.Items.Clear();
            IEnumerable<UserModel> Names = LRA.crud.GetAll();
            for (int i = 0; i < Names.Count(); i++)
            {
                from.Items.Add(Names.ElementAt(i).LastName + ", " + Names.ElementAt(i).FirstName + Names.ElementAt(i).MiddleName);
                to.Items.Add(Names.ElementAt(i).LastName + ", " + Names.ElementAt(i).FirstName + Names.ElementAt(i).MiddleName);
            }
        }

        private void rSearchBtn_Click(object sender, EventArgs e)
        {
            if (to.SelectedIndex == -1 && from.SelectedIndex == -1)
            {
                MessageBox.Show("Please provide a criteria to search from the dropdowns above the table", "Human Resource Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int[] criterias = new int[2];
                string[] queries = new string[2];
                if (to.SelectedIndex > -1)
                {
                    criterias[0] = 1;
                    queries[0] = to.SelectedItem.ToString();
                }
                else
                {
                    criterias[0] = 0;
                    queries[0] = "";
                }

                if (from.SelectedIndex > -1)
                {
                    criterias[1] = 1;
                    queries[1] = from.SelectedItem.ToString();
                }
                else
                {
                    criterias[1] = 0;
                    queries[1] = "";
                }

                if (IRA.FB.Search(criterias, queries) == -1)
                {
                    MessageBox.Show("No Results Found.", "Human Resource Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            to.SelectedIndex = -1;
            from.SelectedIndex = -1;
        }

        private void feedback_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (feedback.Columns[e.ColumnIndex].Name == "btndelete")
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLConnectionString"].ConnectionString))
                {
                    con.Open();
                    if (Convert.ToInt32(this.feedback.Rows[e.RowIndex].Cells[1].Value) > 0)
                    {
                        using (SqlCommand command = new SqlCommand())
                        {
                            command.Connection = con;
                            command.CommandText = "DELETE FROM InformationFeedback WHERE FeedbackID = @iID";
                            command.Parameters.AddWithValue("@iID", Convert.ToInt32(this.feedback.Rows[e.RowIndex].Cells[1].Value));
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
    }
}
