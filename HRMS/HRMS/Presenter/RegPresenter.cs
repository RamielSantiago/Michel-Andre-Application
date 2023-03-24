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
        private BindingSource bs;
        public IEnumerable<UserModel> EmployeeList;

        public RegPresenter(IRegister view, IUser repo)
        {
            this.view = view;
            this.repo = repo;
            this.bs = new BindingSource();
            this.view.setEmployeeBS(bs);
            LoadAllUsers();
            this.view.Show();
        }
        private void LoadAllUsers()
        {
            EmployeeList = repo.GetAll();
            bs.DataSource = EmployeeList;

        }
        public void AddUser() {
            var validUser = new UserModel();
            validUser.FirstName = view.FirstName;
            validUser.LastName = view.LastName;
            validUser.MiddleName = view.MiddleName;
            validUser.MiddleName = view.MiddleName;
            validUser.UserName = view.UserName;
            validUser.Password = view.Password;
            validUser.Email = view.Email;
            validUser.EmployeeID = view.EmployeeID;
            validUser.AccessRights = view.AccessRights;
            repo.Add(validUser);
            LoadAllUsers();
        }

        public int SearchUser(string criteria, string query)
        {
            EmployeeList = repo.SearchUsersByValue(criteria, query);
            if (!EmployeeList.Any())
            {
                LoadAllUsers();
                return -1;
            } else
            {
                bs.DataSource = EmployeeList;
                return 1;
            }
        }
        public void UpdateUser(UserModel update)
        {
            repo.Update(update);
            LoadAllUsers();
        }
        public void DeleteUser(string criteria, string query)
        {
            repo.Delete(criteria, query);
            LoadAllUsers();
        }
    }
}
