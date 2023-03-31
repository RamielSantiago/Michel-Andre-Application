using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMS.View
{
    public interface iPersonnelActionV
    {
        int EmployeeID { get; set; }
        DateTime DateOfAdjustment { get; set; }
        string PersonnelActionReport { get; set; }
        bool Status { get; set; }

        void setPersonnelActionBS(BindingSource bs);
        void Show();
    }
}
