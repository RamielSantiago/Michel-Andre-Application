using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HRMS.Model;
using HRMS.View;

namespace HRMS.Presenter
{
    public class RegPresenter
    {
        private readonly IUser repo;
        private readonly IRegister view;


        public RegPresenter(IRegister view, IUser repo)
        {
            this.view = view;
            this.repo = repo;
            this.view.Show();
        }
        public void AddUser() {
            var validUser = new UserModel();
            validUser.FirstName = view.FirstName;
            validUser.LastName = view.LastName;
            validUser.MiddleName = view.MiddleName;
            validUser.UserName = view.UserName;
            validUser.Password = view.Password;
            validUser.Email = view.Email;
            validUser.EmployeeID = view.EmployeeID;
            validUser.AccessRights = view.AccessRights;
            repo.Add(validUser);
        }
    }
}
