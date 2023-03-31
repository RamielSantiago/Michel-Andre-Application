using HRMS.Model.DB_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Model
{
    internal interface iReportManagement
    {
        void Add(ReportManagementModel user);
        void Update(ReportManagementModel user);
        void Delete(string criteria, string query);
        IEnumerable<ReportManagementModel> SearchReportManagement(string criteria, string query);
        IEnumerable<ReportManagementModel> GetAll();
    }
}