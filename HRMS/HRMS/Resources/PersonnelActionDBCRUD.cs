using HRMS.Model;
using HRMS.Tools;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRMS.View;
using System.Windows.Forms;
using HRMS.Model.DB_Models;

namespace HRMS.Resources
{
    public class PersonnelActionDBCRUD : BaseRepository, iPersonnelAction
    {
        public PersonnelActionDBCRUD(string connectionString)
        {
            this.conString = connectionString;
        }

        public IEnumerable<PersonnelActionModel> GetAll()
        {
            var personnelActionList = new List<PersonnelActionModel>();
            using (var connection = new SqlConnection(conString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select * from PersonnelActionReports";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        PersonnelActionModel sample = new PersonnelActionModel();
                        sample.EmployeeID = reader.GetInt32(0);
                        sample.DateOfAdjustment = reader.GetDateTime(1);
                        sample.PersonnelActionReport = reader.GetString(2);
                        sample.Status = reader.GetBoolean(3);
                        personnelActionList.Add(sample);
                    }
                }
            }
            return personnelActionList;
        }
        public void Add(PersonnelActionModel report)
        {
            var connection = new SqlConnection(conString);
            connection.Open();
            SqlCommand command = new SqlCommand("INSERT INTO PersonnelActionReports([EmpID], [DateofAdj], [PersActionRep], [Stat])" +
                "VALUES(@eID, @DOA, @PAR, @STAT)");
            command.Connection = connection;
            command.Parameters.AddWithValue("@eID", report.EmployeeID);
            command.Parameters.AddWithValue("@DOA", report.DateOfAdjustment);
            command.Parameters.AddWithValue("@PAR", report.PersonnelActionReport);
            command.Parameters.AddWithValue("@STAT", report.Status);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void Update(PersonnelActionModel report)
        {
            var connection = new SqlConnection(conString);
            connection.Open();
            if (!report.Status.Equals("-1"))
            {
                SqlCommand command = new SqlCommand("UPDATE PersonnelActionReports SET Stat = @STAT WHERE EmpID = @eID");
                command.Connection = connection;
                command.Parameters.AddWithValue("@eID", report.EmployeeID);
                command.Parameters.AddWithValue("@STAT", report.Status);
                command.ExecuteNonQuery();
            }
            if (!report.PersonnelActionReport.Equals("-1"))
            {
                SqlCommand command = new SqlCommand("UPDATE PersonnelActionReports SET PersonnelActionReport = @PART WHERE EmpID = @eID");
                command.Connection = connection;
                command.Parameters.AddWithValue("e@ID", report.EmployeeID);
                command.Parameters.AddWithValue("@RB", report.PersonnelActionReport);
                command.ExecuteNonQuery();
            }
            connection.Close();
        }

        public IEnumerable<PersonnelActionModel> SearchPersonnelAction(string criteria, string query)
        {
            var reportlist = new List<PersonnelActionModel>();
            var connection = new SqlConnection(conString);
            connection.Open();
            SqlCommand[] searchTypes =
            {
                new SqlCommand("SELECT * FROM PersonnelActionReports WHERE EmpID = @eID"),
                new SqlCommand("SELECT * FROM PersonnelActionReports WHERE DateofAdj = @DOA"),
                new SqlCommand("SELECT * FROM PersonnelActionReports WHERE Status = @STAT"),
                new SqlCommand("SELECT * FROM PersonnelActionReports")
            };
            SqlCommand command = new SqlCommand();
            switch (criteria)
            {
                case "Employee ID":
                    command = searchTypes[0];
                    break;
                case "Date of Adjustment":
                    command = searchTypes[1];
                    break;
                case "Status":
                    command = searchTypes[2];
                    break;
                default:
                    command = searchTypes[3];
                    break;
            }
            command.Connection = connection;
            switch (criteria)
            {
                case "Employee ID":
                    command.Parameters.AddWithValue("@eID", Convert.ToInt32(query));
                    break;
                case "Date of Adjustment":
                    command.Parameters.AddWithValue("@DOA", query);
                    break;
                case "Status":
                    command.Parameters.AddWithValue("@STAT", query);
                    break;
            }
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    PersonnelActionModel sample = new PersonnelActionModel();
                    sample.EmployeeID = reader.GetInt32(0);
                    sample.DateOfAdjustment = reader.GetDateTime(1);
                    sample.PersonnelActionReport = reader.GetString(2);
                    sample.Status = reader.GetBoolean(3);
                    reportlist.Add(sample);
                }
            }
            return reportlist;
        }

        public void Delete(string criteria, string query)
        {
            var connection = new SqlConnection(conString);
            connection.Open();
            if (criteria.Equals("Employee ID"))
            {
                SqlCommand command = new SqlCommand("DELETE FROM PersonnelActionReports WHERE EmpID = @eID");
                command.Connection = connection;
                command.Parameters.AddWithValue("@eID", Convert.ToInt32(query));
                int hits = command.ExecuteNonQuery();
                if (hits < 1)
                {
                    MessageBox.Show("No such report exists.", "Human Resource Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            connection.Close();
        }
    }
}
