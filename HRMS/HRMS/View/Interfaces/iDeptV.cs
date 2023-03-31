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
    public interface iDeptV
    {
        int jobID { get; set; }
        string deptName { get; set; }
        int accessRights { get; set; }
        string EmpPos { get; set; }
        int jobLvl { get; set; }
        string jobPosDoc { get; set; }

        void setDepartmentBS(BindingSource bs);
        void Show();
    }
}
