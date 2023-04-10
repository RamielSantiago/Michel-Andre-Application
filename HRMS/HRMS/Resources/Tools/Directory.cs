using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HRMS.View;
using HRMS.View.UI.EmployeeList;
using HRMS.View.UI;
using HRMS.View.UI.IncidentReport;
using HRMS.View.UI.Recruitment;
using HRMS.View.UI.PerformanceAppraisal;
using HRMS.View.UI.InformationFeedback;

namespace HRMS.Resources.Tools
{
    public partial class Directory : UserControl
    {
        private static HRMSRegister regInstance;
        private static viewEmployeeList vEList;
        private static updateEmployee uEList;
        private static addEmployee eAList;
        private static randrReader rules;
        private static MemorandumCircular mc;
        private static ReportHub RH;
        private static addReport AR;
        private static viewReports VR;
        private static updateReports UR;
        private static Recruitment REC;
        private static ViewRecruits VREC;
        private static AddRecruitment AREC;
        private static EditRecruitment UREC;
        private static PerAppHub PAH;
        private static EditPerApp EPA;
        private static AddPerApp APA;
        private static ViewPerApp VPA;
        private static FeedbackHub FBH;
        private static OrgChart OG;

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
            set { regInstance = value; }
        }
        public static viewEmployeeList eList
        {
            get
            {
                if (vEList== null)
                {
                    vEList = new viewEmployeeList();
                }
                return vEList;
            }
            set { vEList = value; }
        }
        public static updateEmployee uList
        {
            get
            {
                if (uEList == null)
                {
                    uEList = new updateEmployee();
                }
                return uEList;
            }
            set { uEList = value; }
        }
        public static addEmployee aList
        {
            get
            {
                if (eAList == null)
                {
                    eAList = new addEmployee();
                }
                return eAList;
            }
            set { eAList = value; }
        }

        public static ReportHub IReports
        {
            get
            {
                if (RH == null)
                {
                    RH = new ReportHub();
                }
                return RH;
            }
            set {RH = value; }
        }

        public static addReport aReport
        {
            get
            {
                if (AR == null)
                {
                    AR = new addReport();
                }
                return AR;
            }
            set { AR = value; }
        }

        public static updateReports uReport
        {
            get
            {
                if (UR == null)
                {
                    UR = new updateReports();
                }
                return UR;
            }
            set { UR = value; }
        }

        public static viewReports vReport
        {
            get
            {
                if (VR == null)
                {
                    VR = new viewReports();
                }
                return VR;
            }
            set { VR = value; }
        }

        public static Recruitment rechub
        {
            get
            {
                if (REC == null)
                {
                    REC = new Recruitment();
                }
                return REC;
            }
            set { REC = value; }
        }

        public static AddRecruitment arec
        {
            get
            {
                if (AREC == null)
                {
                    AREC = new AddRecruitment();
                }
                return AREC;
            }
            set { AREC = value; }
        }

        public static EditRecruitment urec
        {
            get
            {
                if (UREC == null)
                {
                    UREC = new EditRecruitment();
                }
                return UREC;
            }
            set { UREC = value; }
        }

        public static ViewRecruits vrec
        {
            get
            {
                if (VREC == null)
                {
                    VREC = new ViewRecruits();
                }
                return VREC;
            }
            set { VREC = value; }
        }

        public static randrReader loadRules
        {
            get
            {
                if (rules == null)
                {
                    rules = new randrReader();
                }
                return rules;
            }
            set { rules = value; }
        }

        public static MemorandumCircular mem
        {
            get
            {
                if(mc == null)
                {
                    mc = new MemorandumCircular();
                }
                return mc;
            }
            set { mc = value; }
        }

        public static PerAppHub pah
        {
            get
            {
                if (PAH == null)
                {
                    PAH = new PerAppHub();
                }
                return PAH;
            }
            set { PAH = value; }
        }

        public static ViewPerApp vpa
        {
            get
            {
                if (VPA == null)
                {
                    VPA = new ViewPerApp();
                }
                return VPA;
            }
            set { VPA = value; }
        }

        public static EditPerApp epa
        {
            get
            {
                if (EPA == null)
                {
                    EPA = new EditPerApp();
                }
                return EPA;
            }
            set { EPA = value; }
        }

        public static AddPerApp apa
        {
            get
            {
                if (APA == null)
                {
                    APA = new AddPerApp();
                }
                return APA;
            }
            set { APA = value; }
        }

        public static FeedbackHub fbh
        {
            get
            {
                if (FBH == null)
                {
                    FBH = new FeedbackHub();
                }
                return FBH;
            }
            set { FBH = value; }
        }

        public static OrgChart og
        {
            get
            {
                if (OG == null)
                {
                   OG = new OrgChart();
                }
                return OG;
            }
            set { OG = value; }
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
