using HRMS.Model.DBInterfaces;
using HRMS.View.Adapters;
using HRMS.View.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMS.View.UI.EmployeeList
{
    public partial class viewEmployeeList : UserControl, iRegister
    {
        private Log_RegAdapter LRA;
        public viewEmployeeList()
        {
            InitializeComponent();
            LRA = new Log_RegAdapter(this);
            depts.Enabled= false;
            depts.SendToBack();
        }
        public string FirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string MiddleName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Position { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Department { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime DateHired { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Email { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Password { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string UserName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void setEmployeeBS(BindingSource bs)
        {
            var deleteButton = new DataGridViewButtonColumn();
            deleteButton.Name = "btndelete";
            deleteButton.HeaderText = "Delete";
            deleteButton.UseColumnTextForButtonValue = true;
            deleteButton.Text = "Delete";
            employees.Columns.Add(deleteButton);
            employees.DataSource = bs;
        }

        private void eSearchBtn_Click(object sender, EventArgs e)
        {
            if (employeesearchcriteria.SelectedIndex == -1 || (employeesearchcriteria.SelectedIndex != 4 && string.IsNullOrWhiteSpace(querydetail.Text)) || (employeesearchcriteria.SelectedIndex == 4 && depts.SelectedIndex == -1))
            {
                MessageBox.Show("Please enter a search criteria and query.", "Human Resource Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if(employeesearchcriteria.SelectedIndex == 4)
                {
                    if(LRA.RP.SearchUser(employeesearchcriteria.SelectedItem.ToString(), depts.SelectedItem.ToString()) == -1)
                    {
                        MessageBox.Show("No Results Found", "Human Resource Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
               else 
                {
                    if (LRA.RP.SearchUser(employeesearchcriteria.SelectedItem.ToString(), querydetail.Text) == -1)
                    {
                        MessageBox.Show("No Results Found", "Human Resource Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }       
                }
            }
            employeesearchcriteria.SelectedIndex = -1;
            depts.SelectedIndex = -1;
            querydetail.Clear();
        }
        public void refreshList()
        {
            LRA.RP.LoadAllUsers();
        }

        private void employees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (employees.Columns[e.ColumnIndex].Name == "btndelete")
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLConnectionString"].ConnectionString))
                {
                    con.Open();
                    if (e.RowIndex > 0)
                    {
                        using (SqlCommand command = new SqlCommand())
                        {
                            command.Connection = con;
                            command.CommandText = "DELETE FROM EmployeeList WHERE EmployeeID = @eID";
                            command.Parameters.AddWithValue("@eID", Convert.ToInt32(this.employees.Rows[e.RowIndex].Cells[1].Value));
                            command.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        MessageBox.Show("User with ID 0 cannot be deleted.", "Human Resource Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    con.Close();
                }
                refreshList();
            }
        }

        private void viewEmployeeList_Load(object sender, EventArgs e)
        {
        }

        private void employeesearchcriteria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (employeesearchcriteria.SelectedIndex > -1)
            {
                if (employeesearchcriteria.SelectedItem.ToString().Equals("Department"))
                {
                    depts.Enabled = true;
                    depts.BringToFront();
                }
                else
                {
                    depts.SelectedIndex = -1;
                    depts.Enabled = false;
                    depts.SendToBack();
                }
            }
        }
    }
}
