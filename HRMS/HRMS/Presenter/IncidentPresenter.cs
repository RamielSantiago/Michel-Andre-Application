using HRMS.Model;
using HRMS.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Presenter
{
    public class IncidentPresenter
    {
        private readonly iIncidentReport repo;
        private readonly iIncident view;


        public IncidentPresenter(iIncident view, iIncidentReport repo)
        {
            this.view = view;
            this.repo = repo;
            this.view.Show();
        }
        public void AddReport()
        {

        }
    }
}
