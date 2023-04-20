using HRMS.Model.DBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Model.DBInterfaces
{
    public interface iPerform
    {
        void Add(AppraisalModel user);
        void Update(AppraisalModel user);
        int SearchID(int query);
        AppraisalModel getExisting(AppraisalModel user);
        IEnumerable<AppraisalModel> Search(int criterias, string queries);
        IEnumerable<AppraisalModel> GetAll();
    }
}
