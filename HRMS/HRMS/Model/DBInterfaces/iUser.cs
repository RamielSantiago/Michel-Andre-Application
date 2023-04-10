using HRMS.Model.DBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Model.DBInterfaces
{
    public interface iUser
    {
        void Add(UserModel user);
        void Update(UserModel user);
        int SearchLogin(string Userrname, string Password);
        int checkifExists(UserModel user);
        IEnumerable<UserModel> SearchUserByName(string first, string last);
        IEnumerable<UserModel> SearchUsersByValue(string criteria, string query);
        IEnumerable<UserModel> GetAll();
    }
}
