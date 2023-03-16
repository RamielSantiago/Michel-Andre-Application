using HRMS.Model;
using HRMS.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Presenter
{
     public class LogPresenter
    {
        private readonly IUser repo;
        private readonly ILogin view;


        public LogPresenter(ILogin view, IUser repo)
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
