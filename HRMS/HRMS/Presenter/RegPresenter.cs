using HRMS.Model.DBInterfaces;
using HRMS.Model.DBModels;
using HRMS.View.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMS.Presenter
{
    public class RegPresenter
    {
        private readonly iUser repo;
        private readonly iRegister view;
        private BindingSource bs;
        public IEnumerable<UserModel> EmployeeList;

        public RegPresenter(iRegister view, iUser repo)
        {
            this.view = view;
            this.repo = repo;
            this.bs = new BindingSource();
            this.view.setEmployeeBS(bs);
            LoadAllUsers();
            this.view.Show();
        }
        public void LoadAllUsers()
        {
            EmployeeList = repo.GetAll();
            bs.DataSource = EmployeeList;
        }
        public void AddUser()
        {
            var validUser = new UserModel();
            validUser.EmployeeID = repo.GetAll().ElementAt(repo.GetAll().Count() - 1).EmployeeID + 1; ;
            validUser.FirstName = view.FirstName;
            validUser.MiddleName = view.MiddleName;
            validUser.LastName = view.LastName;
            validUser.Email = view.Email;
            validUser.Department = view.Department;
            validUser.Position = view.Position;
            validUser.Password = view.Password;
            validUser.UserName = view.UserName;
            validUser.DateHired = view.DateHired;
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
            }
            else
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

        public int SearchName(string first, string last)
        {
            var temp = repo.SearchUserByName(first, last);
            if (temp.Any())
            {
                return -1;
            }
            else
            {
                return 1;
            }
        }
    }
}
