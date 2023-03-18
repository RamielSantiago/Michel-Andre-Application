using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HRMS.View;
namespace HRMS.Tools
{
    public class Directory
    {
        private static HRMSLogin logForm;
        private static HRMSRegister regForm;
        public static HRMSLogin login
        {
            get
            {
                if (logForm == null)
                {
                    logForm = new HRMSLogin();
                }
                return logForm;
            }
        }
        public static HRMSRegister register
        {
            get
            {
                if (regForm == null)
                {
                    regForm = new HRMSRegister(logForm);
                }
                return regForm;
            }
        }

        public static void ShowLoginForm()
        {
            logForm.Show();
        }

        public  void HideLoginForm()
        {
            logForm.Hide();
        }

        public void ShowRegisterForm()
        {
            regForm.Show();
        }

        public void HideRegisterForm()
        {
            regForm.Hide();
        }
    }
}
