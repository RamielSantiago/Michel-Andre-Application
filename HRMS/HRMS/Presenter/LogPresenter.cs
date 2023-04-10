using HRMS.Model.DBInterfaces;
using HRMS.View.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Presenter
{
    public class LogPresenter
    {
            private readonly iUser repo;
            private readonly iLogin view;


            public LogPresenter(iLogin view, iUser repo)
            {
                this.view = view;
                this.repo = repo;
                this.view.Show();
            }

            public int SearchUser(string Username, string Password)
            {
                return repo.SearchLogin(Username, Password);
            }
    }
}
