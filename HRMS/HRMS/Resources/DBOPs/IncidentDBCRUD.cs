using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRMS.Model;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Runtime.Remoting.Contexts;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Collections;
using HRMS.Model.DBInterfaces;
using HRMS.Model.DBModels;
using HRMS.View.Interfaces;
using HRMS.Tools;
using System.ComponentModel;
namespace HRMS.Resources.DBOPs
{
    public class IncidentDBCRUD : BaseRepository, iReport
    {
        public IncidentDBCRUD(string connectionString){
            this.conString = connectionString;
        }

        public void Add(IRModel user)
        {
            var connection = new SqlConnection(conString);
            connection.Open();
            SqlCommand command = new SqlCommand("INSERT INTO Incidents([IncidentID], [LastName], [FirstName], [MiddleName], [Department], [Position], [DateSubmitted], [PeopleInvolved], [Incident], [Remarks], [ApprovedBy])" +
                "VALUES(@ID, @lName, @fName, @mName, @dept, @pos, @date, @pis, @inc, @rems, @approve)");
            command.Connection = connection;
            command.Parameters.AddWithValue("@ID", user.IncidentID);
            command.Parameters.AddWithValue("@fName", user.FirstName);
            command.Parameters.AddWithValue("@lName", user.LastName);
            command.Parameters.AddWithValue("@mName", user.MiddleInitial);
            command.Parameters.AddWithValue("@dept", user.Department);
            command.Parameters.AddWithValue("@pos", user.Position);
            command.Parameters.AddWithValue("@date", user.DatePosted);
            command.Parameters.AddWithValue("@pis", user.PeopleInvolved);
            command.Parameters.AddWithValue("@inc", user.Incident);
            command.Parameters.AddWithValue("@rems", user.Remarks);
            command.Parameters.AddWithValue("@approve", user.ApprovedBy);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void Update(IRModel user)
        {
            var connection = new SqlConnection(conString);
            connection.Open();
            if (!user.FirstName.Equals("-1"))
            {
                SqlCommand command = new SqlCommand("UPDATE Incidents SET FirstName = @Firstname WHERE IncidentID = @iID");
                command.Connection = connection;
                command.Parameters.AddWithValue("@iID", user.IncidentID);
                command.Parameters.AddWithValue("@Firstname", user.FirstName);
                command.ExecuteNonQuery();
            }
            if (!user.MiddleInitial.Equals("-1"))
            {
                SqlCommand command = new SqlCommand("UPDATE Incidents SET MiddleName = @Middlename WHERE IncidentID = @iID");
                command.Connection = connection;
                command.Parameters.AddWithValue("@iID", user.IncidentID);
                command.Parameters.AddWithValue("@Middlename", user.MiddleInitial);
                command.ExecuteNonQuery();
            }
            if (!user.LastName.Equals("-1"))
            {
                SqlCommand command = new SqlCommand("UPDATE Incidents SET LastName = @Lastname WHERE IncidentID = @iID");
                command.Connection = connection;
                command.Parameters.AddWithValue("@iID", user.IncidentID);
                command.Parameters.AddWithValue("@Lastname", user.LastName);
                command.ExecuteNonQuery();
            }
            if (!user.Department.Equals("-1") && !user.Position.Equals("-1"))
            {
                SqlCommand command = new SqlCommand("UPDATE Incidents SET Department = @dept WHERE IncidentID = @iID");
                command.Connection = connection;
                command.Parameters.AddWithValue("@iID", user.IncidentID);
                command.Parameters.AddWithValue("@dept", user.Department);
                command.ExecuteNonQuery();

                SqlCommand command2 = new SqlCommand("UPDATE Incidents SET Position = @pos WHERE IncidentID = @iID");
                command2.Connection = connection;
                command2.Parameters.AddWithValue("@iID", user.IncidentID);
                command2.Parameters.AddWithValue("@pos", user.Position);
                command2.ExecuteNonQuery();
            }
            if (!user.Incident.Equals("-1"))
            {
                SqlCommand command = new SqlCommand("UPDATE Incidents SET Incident = @inc WHERE IncidentID = @iID");
                command.Connection = connection;
                command.Parameters.AddWithValue("@iID", user.IncidentID);
                command.Parameters.AddWithValue("@inc", user.Incident);
                command.ExecuteNonQuery();
            }
            if (!user.PeopleInvolved.Equals("-1"))
            {
                SqlCommand command = new SqlCommand("UPDATE Incidents SET PeopleInvolved = @pi WHERE IncidentID = @iID");
                command.Connection = connection;
                command.Parameters.AddWithValue("@iID", user.IncidentID);
                command.Parameters.AddWithValue("@pi", user.PeopleInvolved);
                command.ExecuteNonQuery();
            }
            if (!user.ApprovedBy.Equals("-1"))
            {
                SqlCommand command = new SqlCommand("UPDATE Incidents SET ApprovedBy = @ab WHERE IncidentID = @iID");
                command.Connection = connection;
                command.Parameters.AddWithValue("@iID", user.IncidentID);
                command.Parameters.AddWithValue("@ab", user.ApprovedBy);
                command.ExecuteNonQuery();
            }
            if (!user.Remarks.Equals("-1"))
            {
                SqlCommand command = new SqlCommand("UPDATE Incidents SET Remarks = @rem WHERE IncidentID = @iID");
                command.Connection = connection;
                command.Parameters.AddWithValue("@iID", user.IncidentID);
                command.Parameters.AddWithValue("@rem", user.Remarks);
                command.ExecuteNonQuery();
            }
            if (!(user.DatePosted == DateTime.MaxValue))
            {
                SqlCommand command = new SqlCommand("UPDATE Incidents SET DateSubmitted = @date WHERE IncidentID = @iID");
                command.Connection = connection;
                command.Parameters.AddWithValue("@iID", user.IncidentID);
                command.Parameters.AddWithValue("@date", DateTime.Now);
                command.ExecuteNonQuery();
            }
            connection.Close();
        }

        public IEnumerable<IRModel> GetAll()
        {
            var irList = new List<IRModel>();
            using (var connection = new SqlConnection(conString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select * FROM Incidents";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var sample = new IRModel();
                        sample.IncidentID = reader.GetInt32(0);
                        sample.LastName = reader.GetString(1);
                        sample.FirstName = reader.GetString(2);
                        sample.MiddleInitial = reader.GetString(3);
                        sample.Department = reader.GetString(4);
                        sample.Position = reader.GetString(5);
                        sample.DatePosted = reader.GetDateTime(6);
                        sample.PeopleInvolved = reader.GetString(7);
                        sample.Incident = reader.GetString(8);
                        sample.Remarks= reader.GetString(9);
                        sample.ApprovedBy = reader.GetString(10);
                        irList.Add(sample);
                    }
                }
            }
            return irList;
        }

        public IEnumerable<IRModel> SearchIncident(int[] criterias, string[] queries)
        {
            var irList = new List<IRModel>();
            string sqlcommand = "Select * From Incidents Where ";
            var connection = new SqlConnection(conString);
            connection.Open();
            if (criterias[0] == 1)
            {
                sqlcommand = sqlcommand + "LastName = @lName";
                if (criterias[1] == 1 || criterias[2] == 1 || criterias[3] == 1)
                {
                    sqlcommand = sqlcommand + " And ";
                }
            }
            if (criterias[1] == 1)
            {
                sqlcommand = sqlcommand + "FirstName = @fName";
                if (criterias[2] == 1 || criterias[3] == 1) {
                    sqlcommand = sqlcommand + " And ";
                }
            }
            if (criterias[2] == 1)
            {
                sqlcommand = sqlcommand + "Department = @dept";
                if (criterias[3] == 1)
                {
                    sqlcommand = sqlcommand + " And ";
                };
            }
            if (criterias[3] == 1)
            {
                sqlcommand = sqlcommand + "Position = @pos";
            }

            SqlCommand command = new SqlCommand(sqlcommand);
            command.Connection = connection;
            if (criterias[0] == 1)
            {
                command.Parameters.AddWithValue("@lName", queries[0]);
            }
            if (criterias[1] == 1)
            {
                command.Parameters.AddWithValue("@fName", queries[1]);
            }
            if (criterias[2] == 1)
            {
                command.Parameters.AddWithValue("@dept", queries[2]);
            }
            if (criterias[3] == 1)
            {
                command.Parameters.AddWithValue("@pos", queries[3]);
            }

            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var sample = new IRModel();
                    sample.IncidentID = reader.GetInt32(0);
                    sample.LastName = reader.GetString(1);
                    sample.FirstName = reader.GetString(2);
                    sample.MiddleInitial = reader.GetString(3);
                    sample.Department = reader.GetString(4);
                    sample.Position = reader.GetString(5);
                    sample.DatePosted = reader.GetDateTime(6);
                    sample.PeopleInvolved = reader.GetString(7);
                    sample.Incident = reader.GetString(8);
                    sample.Remarks = reader.GetString(9);
                    sample.ApprovedBy = reader.GetString(10);
                    irList.Add(sample);
                }
            }
            connection.Close();
            return irList;
        }

        public int SearchID(int query)
        {
            var irList = new List<IRModel>();
            var connection = new SqlConnection(conString);
            connection.Open();
            SqlCommand command = new SqlCommand("Select * From Incidents Where IncidentID = @iID");
            command.Connection = connection;
            command.Parameters.AddWithValue("@iID", query);

            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var sample = new IRModel();
                    sample.IncidentID = reader.GetInt32(0);
                    sample.LastName = reader.GetString(1);
                    sample.FirstName = reader.GetString(2);
                    sample.MiddleInitial = reader.GetString(3);
                    sample.Department = reader.GetString(4);
                    sample.Position = reader.GetString(5);
                    sample.DatePosted = reader.GetDateTime(6);
                    sample.PeopleInvolved = reader.GetString(7);
                    sample.Incident = reader.GetString(8);
                    sample.Remarks = reader.GetString(9);
                    sample.ApprovedBy = reader.GetString(10);
                    irList.Add(sample);
                }
            }
            connection.Close();
            if (irList.Any())
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
    }
}
