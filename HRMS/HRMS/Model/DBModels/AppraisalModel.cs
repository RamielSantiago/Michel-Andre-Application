using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Model.DBModels
{
    public class AppraisalModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Position { get; set; }
        public string Department { get; set; }
        public DateTime appDate { get; set; }
        public int Attendance { get; set; }
        public int Accuracy { get; set; }
        public int HouseKeeping { get; set; }
        public int Efficiency { get; set; }
        public int CourtesyAtt { get; set; }
        public int Alertness { get; set; }
        public int DRR { get; set; }
        public int Cooperation { get; set; }
        public int CCP { get; set; }
        public int Judgement { get; set; }
        public int Appearance { get; set; }
        public int Friendliness { get; set; }
        public int Total { get; set; }
    }
}
