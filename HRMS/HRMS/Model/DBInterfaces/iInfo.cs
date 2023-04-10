using HRMS.Model.DBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Model.DBInterfaces
{
    public interface iInfo
    {
        void Add(FeedbackModel user);
        int Update(FeedbackModel user);
        IEnumerable<FeedbackModel> Search(int[] criterias, string[] queries);
        IEnumerable<FeedbackModel> GetAll();
    }
}
