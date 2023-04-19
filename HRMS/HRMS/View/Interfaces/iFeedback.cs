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
        int FeedbackID { get; set; }
        string To { get; set; }
        string From { get; set; }
        string Subject { get; set; }
        DateTime date { get; set; }
        string Details { get; set; }
        string RecAct { get; set; }
        string Comments { get; set; }
        bool CompSig { get; set; }
        bool HRSig { get; set; }
        bool SuperSig { get; set; }
        bool PresSig { get; set; }

        void setFeedbackBS(BindingSource bs);
        void Show();
    }
}
