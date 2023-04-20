using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Model.DBModels
{
    public class FeedbackModel
    {
        public int FeedbackID { get; set; }
        public string To { get; set; }
        public string From { get; set; }
        public string Subject { get; set; }
        public DateTime date { get; set; }
        public string Details { get; set; }
        public string RecAct { get; set; }
        public string Comments { get; set; } 
        public string CompSig { get; set; }
        public string HRSig { get; set; }
        public string SuperSig { get; set; }
        public string PresSig { get; set; }
    }
}
