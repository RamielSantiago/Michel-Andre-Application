using HRMS.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMS.View
{
    public  interface IRegister
    {
        int EmployeeID { get; set; }
        int AccessRights { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string MiddleName { get; set; }
        string Email { get; set; }
        string Password { get; set; }
        string UserName { get; set; }

        string SearchValue { get; set; }
        void Show();

    }
}
