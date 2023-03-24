using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Model
{
    public interface IUser
    {
        void Add(UserModel user);
        void Update(UserModel user);
        void Delete(string criteria, string query);
        int SearchLogin(string Userrname, string Password);
        IEnumerable<UserModel> SearchUsersByValue(string criteria, string query);
        IEnumerable<UserModel> GetAll();
    }
}
