using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMS.View.Interfaces
{
    public interface iIncident
    {
        string LastName { get; set; }
        string FirstName { get; set; }
        string MiddleInitial { get; set; }
        string Position { get; set; }
        string Department { get; set; }
        DateTime DatePosted { get; set; }
        string PeopleInvolved { get; set; }
        string Incident { get; set; }
        string Remarks { get; set; }
        string ApprovedBy { get; set; }


        void setIncidentBS(BindingSource bs);
        void Show();
    }
}
