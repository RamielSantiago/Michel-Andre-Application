using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using HRMS.View;

namespace HRMS.Tools
{
    public partial class Directory : UserControl
    {
        private static HRMSRegister regInstance;
        private static CompanyRandR rules;
        private static IncidentReport IR;
        private static MemorandumCircular MC;
        private static CompanyOrgChart COC;

       public static HRMSRegister Register
        {
            get
            {
                if (regInstance == null)
                {
                    regInstance = new HRMSRegister();
                }
                return regInstance;
            }
        }
        public static CompanyRandR company
        {
            get
            {
                if (rules == null)
                {
                    rules = new CompanyRandR();
                }
                return rules ;
            }
            set { rules = value ; }
        }
        public static IncidentReport report
        {
            get
            {
                if(IR == null)
                {
                    IR = new IncidentReport();
                }
                return IR;
            }
        }

        public static CompanyOrgChart coc
        {
            get
            {
                if (COC == null)
                {
                    COC = new CompanyOrgChart();
                }
                return COC;
            }
            set { COC = value; }
        }
        public static MemorandumCircular mc
        {
            get
            {
                if (MC == null)
                {
                    MC = new MemorandumCircular();
                }
                return MC;
            }
            set { MC = value; }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Directory
            // 
            this.Name = "Directory";
            this.Load += new System.EventHandler(this.Directory_Load);
            this.ResumeLayout(false);

        }

        private void Directory_Load(object sender, EventArgs e)
        {

        }
    }
}
