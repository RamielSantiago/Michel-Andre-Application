using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMS.View.Interfaces
{
    public interface iRecruit
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string MiddleName { get; set; }
        string Position { get; set; }
        string Department { get; set; }
        DateTime ApplicationDate { get; set; }
        bool InterInterview1 { get; set; }
        bool InterInterview2 { get; set; }
        bool InterInterview3 { get; set; }
        bool training { get; set; }
        bool resume { get; set; }
        bool PSA { get; set; }
        bool sss { get; set; }
        bool nbi { get; set; }
        bool police { get; set; }
        bool PagIbig { get; set; }
        bool philhealth { get; set; }
        bool bir { get; set; }
        bool tor { get; set; }
        bool EmpCert { get; set; }
        bool MedExam { get; set; }
        string OverallStatus { get; set; }

        void setRecruitBS(BindingSource bs);
        void Show();
    }
}
