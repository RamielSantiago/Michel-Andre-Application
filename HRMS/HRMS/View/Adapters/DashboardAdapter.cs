using HRMS.Model;
using HRMS.Presenter;
using HRMS.Resources;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.View.Adapters
{
    public class DashboardAdapter
    {
        public IncidentPresenter IP;
        public iIncidentReport IIR;
        public DashboardAdapter(iIncident rep) { 
            this.IIR = new IncidentDBCRUD(ConfigurationManager.ConnectionStrings["SQLConnectionString"].ConnectionString);
            this.IP = new IncidentPresenter(rep, IIR);
        }
    }
}
