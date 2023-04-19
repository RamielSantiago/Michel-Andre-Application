using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMS.View.Interfaces
{
    public interface iFeedback
    {
        string FirstName { get; set; }
        string MiddleInitial { get; set; }
        string LastName { get; set; }
        string Department { get; set; }
        string Position { get; set; }
        DateTime DatePosted { get; set; }
        string Topic { get; set; }
        string Detail { get; set; }
        string CourseOfAction { get; set; }
        bool HRofficer { get; set; }
        bool Supervisor { get; set; }
        bool President { get; set; }

        void setFeedbackBS(BindingSource bs);
        void Show();
    }
}
