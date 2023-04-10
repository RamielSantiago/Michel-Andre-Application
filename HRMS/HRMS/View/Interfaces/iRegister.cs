using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMS.View.Interfaces
{
    public interface iRegister
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string MiddleName { get; set; }
        string Position { get; set; }
        string Department { get; set; }
        DateTime DateHired { get; set; }
        string Email { get; set; }
        string Password { get; set; }
        string UserName { get; set; }

        void setEmployeeBS(BindingSource bs);
        void Show();
    }
}
