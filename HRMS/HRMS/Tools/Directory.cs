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
        private static CompanyOrgChart orgchart;
        private static IncidentReport IR;
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
        }

        public static CompanyOrgChart orgChart
        {
            get
            {
                if (orgchart == null)
                {
                    orgchart = new CompanyOrgChart();
                }
                return orgchart ;
            }
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
