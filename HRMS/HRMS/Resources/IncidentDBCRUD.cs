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
    public class IncidentDBCRUD : BaseRepository, iIncidentReport
    {
        public IncidentDBCRUD(string connectionString)
        {
            this.conString = connectionString;
        }

        public IEnumerable<IncidentReportModel> GetAll()
        {
            var incidentList = new List<IncidentReportModel>();
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
                        IncidentReportModel sample = new IncidentReportModel();
                        sample.IncidentID = reader.GetInt32(0);
                        sample.DateOccurred = reader.GetDateTime(1);
                        sample.DatePosted = reader.GetDateTime(2);
                        sample.EmployeesInvolved = reader.GetString(3);
                        sample.ReportedBy = reader.GetString(4);
                        sample.ReportersID = reader.GetInt32(5);
                        sample.TypeOfIncident = reader.GetString(6);
                        sample.Specifics = reader.GetString(7);
                        sample.Instigator = reader.GetString(8);
                        sample.Solution = reader.GetString(9);
                        sample.Penalty = reader.GetString(10);
                        sample.Remarks = reader.GetString(11);
                        incidentList.Add(sample);
                    }
                }
            }
            return incidentList;
        }
        public void Add(IncidentReportModel report)
        {
            var connection = new SqlConnection(conString);
            connection.Open();
            SqlCommand command = new SqlCommand("INSERT INTO IncidentReports([Incident_ID], [Date_Occured], [Date_Posted], [EmployeesInvolved], [Reported_By], [Reporter's_eID], [TypeOfIncident], [Specifics], [Instigator], [Solution], [Penalty], [Remarks])" +
                "VALUES(@ID, @DO, @DP, @EI, @RB, @RID, @Type, @Spec, @Ins, @Sol, @Pen, @Rem)");
            command.Connection = connection;
            command.Parameters.AddWithValue("@ID", report.IncidentID);
            command.Parameters.AddWithValue("@DO", report.DateOccurred);
            command.Parameters.AddWithValue("@DP", report.DatePosted);
            command.Parameters.AddWithValue("@EI", report.EmployeesInvolved);
            command.Parameters.AddWithValue("@RB", report.ReportedBy);
            command.Parameters.AddWithValue("RID", report.ReportersID);
            command.Parameters.AddWithValue("@Type", report.TypeOfIncident);
            command.Parameters.AddWithValue("@Spec", report.Specifics);
            command.Parameters.AddWithValue("@Ins", report.Instigator);
            command.Parameters.AddWithValue("@Sol", report.Solution);
            command.Parameters.AddWithValue("@Pen", report.Penalty);
            command.Parameters.AddWithValue("@Rem", report.Remarks);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void Update(IncidentReportModel report)
        {
            var connection = new SqlConnection(conString);
            connection.Open();
            if (!report.EmployeesInvolved.Equals("-1"))
            {
                SqlCommand command = new SqlCommand("UPDATE IncidentReports SET EmployeesInvolved = @EI WHERE Incident_ID = @iID");
                command.Connection = connection;
                command.Parameters.AddWithValue("@iID", report.IncidentID);
                command.Parameters.AddWithValue("@EI", report.EmployeesInvolved);
                command.ExecuteNonQuery();
            }
            if (!report.ReportedBy.Equals("-1"))
            {
                SqlCommand command = new SqlCommand("UPDATE IncidentReports SET Reported_By = @RB WHERE Incident_ID = @iID");
                command.Connection = connection;
                command.Parameters.AddWithValue("@iID", report.IncidentID);
                command.Parameters.AddWithValue("@RB", report.ReportedBy);
                command.ExecuteNonQuery();
            }
            if (report.ReportersID > -1)
            {
                SqlCommand command = new SqlCommand("UPDATE IncidentReports SET [Reporter's_eID] = @RID WHERE Incident_ID = @iID");
                command.Connection = connection;
                command.Parameters.AddWithValue("@iID", report.IncidentID);
                command.Parameters.AddWithValue("@RID", report.ReportersID);
                command.ExecuteNonQuery();
            }
            if (!report.TypeOfIncident.Equals("-1"))
            {
                SqlCommand command = new SqlCommand("UPDATE IncidentReports SET TypeOfIncident = @Type WHERE Incident_ID = @iID");
                command.Connection = connection;
                command.Parameters.AddWithValue("@iID", report.IncidentID);
                command.Parameters.AddWithValue("@Type", report.TypeOfIncident);
                command.ExecuteNonQuery();
            }
            if (!report.Specifics.Equals("-1"))
            {
                SqlCommand command = new SqlCommand("UPDATE IncidentReports SET Specifics = @Spec WHERE Incident_ID = @iID");
                command.Connection = connection;
                command.Parameters.AddWithValue("@iID", report.IncidentID);
                command.Parameters.AddWithValue("@Spec", report.Specifics);
                command.ExecuteNonQuery();
            }
            if (!report.Instigator.Equals("-1"))
            {
                SqlCommand command = new SqlCommand("UPDATE IncidentReports SET Instigator = @Ins WHERE Incident_ID = @iID");
                command.Connection = connection;
                command.Parameters.AddWithValue("@iID", report.IncidentID);
                command.Parameters.AddWithValue("@Ins", report.Instigator);
                command.ExecuteNonQuery();
            }
            if (!report.Solution.Equals("-1"))
            {
                SqlCommand command = new SqlCommand("UPDATE IncidentReports SET Solution = @Sol WHERE Incident_ID = @iID");
                command.Connection = connection;
                command.Parameters.AddWithValue("@iID", report.IncidentID);
                command.Parameters.AddWithValue("@Sol", report.Solution);
                command.ExecuteNonQuery();
            }
            if (!report.Penalty.Equals("-1"))
            {
                SqlCommand command = new SqlCommand("UPDATE IncidentReports SET Penalty = @Pen WHERE Incident_ID = @iID");
                command.Connection = connection;
                command.Parameters.AddWithValue("@iID", report.IncidentID);
                command.Parameters.AddWithValue("@Pen", report.Penalty);
                command.ExecuteNonQuery();
            }
            if (!report.Remarks.Equals("-1"))
            {
                SqlCommand command = new SqlCommand("UPDATE IncidentReports SET Remarks = @Rem WHERE Incident_ID = @iID");
                command.Connection = connection;
                command.Parameters.AddWithValue("@iID", report.IncidentID);
                command.Parameters.AddWithValue("@Rem", report.Remarks);
                command.ExecuteNonQuery();
            }
            connection.Close();
        }

        public IEnumerable<IncidentReportModel> SearchIncident(string criteria, string query)
        {
            var reportlist = new List<IncidentReportModel>();
            var connection = new SqlConnection(conString);
            connection.Open();
            SqlCommand[] searchTypes =
            {
                new SqlCommand("SELECT * FROM IncidentReports WHERE Incident_ID = @iID"),
                new SqlCommand("SELECT * FROM IncidentReports WHERE Reported_By = @reporter"),
                new SqlCommand("SELECT * FROM IncidentReports")
            };
            SqlCommand command = new SqlCommand();
            switch (criteria)
            {
                case "Incident ID":
                    command = searchTypes[0];
                    break;
                case "Reported By":
                    command = searchTypes[1];
                    break;
                default:
                    command = searchTypes[2];
                    break;
            }
            command.Connection = connection;
            switch (criteria)
            {
                case "Incident ID":
                    command.Parameters.AddWithValue("@iID", Convert.ToInt32(query));
                    break;
                case "Reported By":
                    command.Parameters.AddWithValue("@reporter", query);
                    break;
            }
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    IncidentReportModel sample = new IncidentReportModel();
                    sample.IncidentID = reader.GetInt32(0);
                    sample.DateOccurred = reader.GetDateTime(1);
                    sample.DatePosted = reader.GetDateTime(2);
                    sample.EmployeesInvolved = reader.GetString(3);
                    sample.ReportedBy = reader.GetString(4);
                    sample.ReportersID = reader.GetInt32(5);
                    sample.TypeOfIncident = reader.GetString(6);
                    sample.Specifics = reader.GetString(7);
                    sample.Instigator = reader.GetString(8);
                    sample.Solution = reader.GetString(9);
                    sample.Penalty = reader.GetString(10);
                    sample.Remarks = reader.GetString(11);
                    reportlist.Add(sample);
                }
            }
            return reportlist;
        }

        public void Delete(string criteria, string query)
        {
            var connection = new SqlConnection(conString);
            connection.Open();
            if (criteria.Equals("Incident ID"))
            {
                SqlCommand command = new SqlCommand("DELETE FROM IncidentReports WHERE Incident_ID = @iID");
                command.Connection = connection;
                command.Parameters.AddWithValue("@iID", Convert.ToInt32(query));
                int hits = command.ExecuteNonQuery();
                if(hits < 1)
                {
                    MessageBox.Show("No such report exists.", "Human Resource Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            connection.Close();
        }
    }
}
