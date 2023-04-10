using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMS.View.Interfaces
{
    public interface iAppraisal
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string MiddleName { get; set; }
        string Position { get; set; }
        string Department { get; set; }
        int Year { get; set; }
        int Month { get; set; }
        int Attendance { get; set; }
        int Accuracy { get; set; }
        int HouseKeeping { get; set; }
        int Efficiency { get; set; }
        int CourtesyAtt { get; set; }
        int Alertness { get; set; }
        int DRR { get; set; }
        int Cooperation { get; set; }
        int CCP { get; set; }
        int Judgement { get; set; }
        int Appearance { get; set; }
        int Friendliness { get; set; }
        int Total { get; set; }

        void setAppraisalBS(BindingSource bs);
        void Show();
    }
}
