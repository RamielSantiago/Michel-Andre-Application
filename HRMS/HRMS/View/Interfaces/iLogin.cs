using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.View.Interfaces
{
    public interface iLogin
    {
        string UserName { get; set; }
        string Password { get; set; }
        void Show();
    }
}
