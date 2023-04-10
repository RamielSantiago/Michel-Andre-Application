using HRMS.Model.DBInterfaces;
using HRMS.Presenter;
using HRMS.Resources;
using HRMS.Resources.DBOPs;
using HRMS.View.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.View.Adapters
{
    public class DashAdapter
    {
        public iReport crudRep;
        public iNewbies crudRec;
        public iPerform crudApp;
        public RecruitPresenter RP;
        public IRPresenter IR;
        public AppraisalPresenter APP;
        public DashAdapter(iIncident reg)
        {
            this.crudRep = new IncidentDBCRUD(ConfigurationManager.ConnectionStrings["SQLConnectionString"].ConnectionString);
            this.IR = new IRPresenter(reg, crudRep);
        }

        public DashAdapter(iRecruit reg)
        {
            this.crudRec = new RecruitDBCRUD(ConfigurationManager.ConnectionStrings["SQLConnectionString"].ConnectionString);
            this.RP = new RecruitPresenter(reg, crudRec);
        }

        public DashAdapter(iAppraisal reg)
        {
            this.crudApp = new AppraisalDBCRUD(ConfigurationManager.ConnectionStrings["SQLConnectionString"].ConnectionString);
            this.APP = new AppraisalPresenter(reg, crudApp);
        }
    }
}
