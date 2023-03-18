using HRMS.Model;
using HRMS.Tools;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Resources
{
    public class IncidentDBCRUD : BaseRepository, iIncidentReport
    {
        public IncidentDBCRUD(string connectionString)
        {
            this.conString = connectionString;
        }

        public IEnumerable<UserModel> GetAll()
        {
            var incidentList = new List<UserModel>();
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

                    }
                }
            }
            return incidentList;
        }
        public void Add(IncidentReportModel user)
        {
            throw new NotImplementedException();
        }

        public void Update(IncidentReportModel user)
        {
            throw new NotImplementedException();
        }

        public bool SearchIncident(int IncidentID)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
