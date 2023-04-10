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

        void setFeedbackBS(BindingSource bs);
        void Show();
    }
}
