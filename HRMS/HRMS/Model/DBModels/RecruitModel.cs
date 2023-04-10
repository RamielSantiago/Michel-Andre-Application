using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Model.DBModels
{
   public class RecruitModel
    {
        public int ApplicationID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Position { get; set; }
        public string Department { get; set; }
        public DateTime ApplicationDate { get; set; }
        public string Interview1 { get; set; }
        public string Interview2 { get; set; }
        public string Interview3 { get; set; }
        public string Training { get; set; }
        public string resume { get; set; }
        public string PSA { get; set; }
        public string SSS { get; set; }
        public string NBI { get; set; }
        public string Police { get; set; }
        public string PagIbig { get; set; }
        public string philhealth { get; set; }
        public string BIR { get; set; }
        public string TOR { get; set; }
        public string EmpCert { get; set; }
        public string MedExam { get; set; }
        public string OverallStatus { get; set; }
    }
}
