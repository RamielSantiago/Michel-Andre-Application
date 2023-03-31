using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.View
{
    public interface ILogin
    {
        string UserName { get; set; }
        string Password { get; set; }
        string SearchValue { get; set; }

        void Show();
    }
}
