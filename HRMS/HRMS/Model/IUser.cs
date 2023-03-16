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
        void Delete(int id);
        int SearchLogin(string Userrname, string Password);
        IEnumerable<UserModel> GetAll();
    }
}
