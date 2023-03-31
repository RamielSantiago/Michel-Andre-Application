using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMS.View
{
    public interface iIncident
    {
         int IncidentID { get; set; }
        DateTime DateOccurred { get; set; }
        DateTime DatePosted { get; set; }
        string EmployeesInvolved { get; set; }
        string TypeOfIncident { get; set; }
        string ReportedBy { get; set; }
        int ReportersID { get; set; }
        string Specifics { get; set; }
        string Instigator { get; set; }
        string Solution { get; set; }
        string Penalty { get; set; }
        string Remarks { get; set; }


        void setIncidentBS(BindingSource bs);
        void Show();
    }
}
