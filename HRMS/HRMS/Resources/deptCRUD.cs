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

namespace HRMS.Resources
{
    public class deptCRUD : BaseRepository, iDept
    {
        public deptCRUD(string connectionString)
        {
            this.conString = connectionString;
        }

        public IEnumerable<DeptModel> GetAll()
        {
            var deptList = new List<DeptModel>();
            using (var connection = new SqlConnection(conString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select * from IncidentReports";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DeptModel sample = new DeptModel();
                        sample.jobID = reader.GetInt32(0);
                        sample.deptName = reader.GetString(1);
                        sample.accessRights = reader.GetInt32(2);
                        sample.EmpPos = reader.GetString(3);
                        sample.jobLvl = reader.GetInt32(4);
                        sample.jobPosDoc = reader.GetString(5);
                        deptList.Add(sample);
                    }
                }
            }
            return deptList;
        }
        public void Add(DeptModel report)
        {
            var connection = new SqlConnection(conString);
            connection.Open();
            SqlCommand command = new SqlCommand("INSERT INTO DeptReports([jobID], [deptName], [accessRights], [EmpPos], [jobLvl], [jobPosDoc])" +
                "VALUES(@ID, @DN, @AR, @EP, @JL, @JPD)");
            command.Connection = connection;
            command.Parameters.AddWithValue("@ID", report.jobID);
            command.Parameters.AddWithValue("@DN", report.deptName);
            command.Parameters.AddWithValue("@AR", report.accessRights);
            command.Parameters.AddWithValue("@EP", report.EmpPos);
            command.Parameters.AddWithValue("@JL", report.jobLvl);
            command.Parameters.AddWithValue("@JPD", report.jobPosDoc);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void Update(DeptModel report)
        {
            var connection = new SqlConnection(conString);
            connection.Open();
            if (!report.accessRights.Equals("-1"))
            {
                SqlCommand command = new SqlCommand("UPDATE DeptReports SET accessRights = @AR WHERE jobID = @ID");
                command.Connection = connection;
                command.Parameters.AddWithValue("@ID", report.jobID);
                command.Parameters.AddWithValue("@AR", report.accessRights);
                command.ExecuteNonQuery();
            }
            if (!report.jobLvl.Equals("-1"))
            {
                SqlCommand command = new SqlCommand("UPDATE DeptReports SET jobLvl = @JL WHERE jobID = @ID");
                command.Connection = connection;
                command.Parameters.AddWithValue("@ID", report.jobID);
                command.Parameters.AddWithValue("@JL", report.jobLvl);
                command.ExecuteNonQuery();
            }
            if (!report.jobPosDoc.Equals("-1"))
            {
                SqlCommand command = new SqlCommand("UPDATE DeptReports SET jobPosDoc = @JPD WHERE jobID = @ID");
                command.Connection = connection;
                command.Parameters.AddWithValue("@ID", report.jobID);
                command.Parameters.AddWithValue("@JPD", report.jobPosDoc);
                command.ExecuteNonQuery();
            }
            connection.Close();
        }

        public IEnumerable<DeptModel> SearchDept(string criteria, string query)
        {
            var reportlist = new List<DeptModel>();
            var connection = new SqlConnection(conString);
            connection.Open();
            SqlCommand[] searchTypes =
            {
                new SqlCommand("SELECT * FROM DeptReports WHERE jobID = @ID"),
                new SqlCommand("SELECT * FROM DeptReports WHERE deptName = @DN"),
                new SqlCommand("SELECT * FROM DeptReports")
            };
            SqlCommand command = new SqlCommand();
            switch (criteria)
            {
                case "Job ID":
                    command = searchTypes[0];
                    break;
                case "Department Name":
                    command = searchTypes[1];
                    break;
                default:
                    command = searchTypes[2];
                    break;
            }
            command.Connection = connection;
            switch (criteria)
            {
                case "Job ID":
                    command.Parameters.AddWithValue("@ID", Convert.ToInt32(query));
                    break;
                case "Department Name":
                    command.Parameters.AddWithValue("@DN", query);
                    break;
            }
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    DeptModel sample = new DeptModel();
                    sample.jobID = reader.GetInt32(0);
                    sample.deptName = reader.GetString(1);
                    sample.accessRights = reader.GetInt32(2);
                    sample.EmpPos = reader.GetString(3);
                    sample.jobLvl = reader.GetInt32(4);
                    sample.jobPosDoc = reader.GetString(5);
                    reportlist.Add(sample);
                }
            }
            return reportlist;
        }

        public void Delete(string criteria, string query)
        {
            var connection = new SqlConnection(conString);
            connection.Open();
            if (criteria.Equals("Job ID"))
            {
                SqlCommand command = new SqlCommand("DELETE FROM DeptReports WHERE jobID = @ID");
                command.Connection = connection;
                command.Parameters.AddWithValue("@ID", Convert.ToInt32(query));
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
