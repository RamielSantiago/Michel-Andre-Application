using HRMS.Model.DBInterfaces;
using HRMS.Presenter;
using HRMS.Resources;
using HRMS.View.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.View.Adapters
{
    public class Log_RegAdapter
    {
        public iUser crud;
        public LogPresenter LP;
        public RegPresenter RP;
        public Log_RegAdapter(iRegister reg)
        {
            this.crud = new UserDBCRUD(ConfigurationManager.ConnectionStrings["SQLConnectionString"].ConnectionString);
            this.RP = new RegPresenter(reg, crud);
        }
        public Log_RegAdapter(iLogin log)
        {
            this.crud = new UserDBCRUD(ConfigurationManager.ConnectionStrings["SQLConnectionString"].ConnectionString);
            this.LP = new LogPresenter(log, crud);
        }
    }
}
