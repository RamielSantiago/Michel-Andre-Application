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
    public interface iReportManagementV
    {
        int DeptID { get; set; }
        string ManagementReport { get; set; }

        DateTime DatePosted { get; set; }

        void setRepprtManagementBS(BindingSource bs);
        void Show();
    }
}
