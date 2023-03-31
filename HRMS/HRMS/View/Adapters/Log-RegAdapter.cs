using HRMS.Model;
using HRMS.Presenter;
using HRMS.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;

namespace HRMS.View
{
    public class Log_RegAdapter
    {
        public IUser crud;
        public LogPresenter LP;
        public RegPresenter RP;
        public Log_RegAdapter(IRegister reg) { 
            this.crud = new UserDBCRUD(ConfigurationManager.ConnectionStrings["SQLConnectionString"].ConnectionString);
            this.RP = new RegPresenter(reg, crud);
        }
        public Log_RegAdapter(ILogin log) {
            this.crud = new UserDBCRUD(ConfigurationManager.ConnectionStrings["SQLConnectionString"].ConnectionString);
            this.LP = new LogPresenter(log, crud);
        }
    }
}
