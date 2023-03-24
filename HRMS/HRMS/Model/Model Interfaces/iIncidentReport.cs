using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Model
{
    public interface iIncidentReport
    {
        void Add(IncidentReportModel user);
        void Update(IncidentReportModel user);
        void Delete(string criteria, string query);
        IEnumerable<IncidentReportModel> SearchIncident(string criteria, string query);
        IEnumerable<IncidentReportModel> GetAll();
    }
}
