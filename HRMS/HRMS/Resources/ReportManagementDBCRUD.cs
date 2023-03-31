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
    public class ReportManagementDBCRUD : BaseRepository, iReportManagement
    {
        public ReportManagementDBCRUD(string connectionString)
        {
            this.conString = connectionString;
        }

        public IEnumerable<ReportManagementModel> GetAll()
        {
            var ReportManagementList = new List<ReportManagementModel>();
            using (var connection = new SqlConnection(conString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select * from ReportManagementReports";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ReportManagementModel sample = new ReportManagementModel();
                        sample.DeptID = reader.GetInt32(0);
                        sample.ManagementReport = reader.GetString(1);
                        sample.DatePosted = reader.GetDateTime(2);
                        ReportManagementList.Add(sample);
                    }
                }
            }
            return ReportManagementList;
        }
        public void Add(ReportManagementModel report)
        {
            var connection = new SqlConnection(conString);
            connection.Open();
            SqlCommand command = new SqlCommand("INSERT INTO ReportManagementReports([DeptID], [ManageRep], [DatePos])" +
                "VALUES(@dID, @MR, @DP)");
            command.Connection = connection;
            command.Parameters.AddWithValue("@dID", report.DeptID);
            command.Parameters.AddWithValue("@MR", report.ManagementReport);
            command.Parameters.AddWithValue("@DP", report.DatePosted);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void Update(ReportManagementModel report)
        {
            var connection = new SqlConnection(conString);
            connection.Open();
            if (!report.ManagementReport.Equals("-1"))
            {
                SqlCommand command = new SqlCommand("UPDATE ReportManagementReports SET DatePos = @DP WHERE DeptID = @dID");
                command.Connection = connection;
                command.Parameters.AddWithValue("@dID", report.DeptID);
                command.Parameters.AddWithValue("@DP", report.ManagementReport);
                command.ExecuteNonQuery();
            }
            connection.Close();
        }

        public IEnumerable<ReportManagementModel> SearchReportManagement(string criteria, string query)
        {
            var reportlist = new List<ReportManagementModel>();
            var connection = new SqlConnection(conString);
            connection.Open();
            SqlCommand[] searchTypes =
            {
                new SqlCommand("SELECT * FROM ReportManagementReports WHERE DeptID = @dID"),
                new SqlCommand("SELECT * FROM ReportManagementReports WHERE DatePos = @DP"),
                new SqlCommand("SELECT * FROM ReportManagementReports")
            };
            SqlCommand command = new SqlCommand();
            switch (criteria)
            {
                case "Department ID":
                    command = searchTypes[0];
                    break;
                case "Date Posted":
                    command = searchTypes[1];
                    break;
                default:
                    command = searchTypes[3];
                    break;
            }
            command.Connection = connection;
            switch (criteria)
            {
                case "Department ID":
                    command.Parameters.AddWithValue("@dID", Convert.ToInt32(query));
                    break;
                case "Date Posted":
                    command.Parameters.AddWithValue("@DP", query);
                    break;
            }
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    ReportManagementModel sample = new ReportManagementModel();
                    sample.DeptID = reader.GetInt32(0);
                    sample.ManagementReport = reader.GetString(1);
                    sample.DatePosted = reader.GetDateTime(2);
                    reportlist.Add(sample);
                }
            }
            return reportlist;
        }

        public void Delete(string criteria, string query)
        {
            var connection = new SqlConnection(conString);
            connection.Open();
            if (criteria.Equals("Department ID"))
            {
                SqlCommand command = new SqlCommand("DELETE FROM ReportManagementReports WHERE DeptID = @dID");
                command.Connection = connection;
                command.Parameters.AddWithValue("@dID", Convert.ToInt32(query));
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
