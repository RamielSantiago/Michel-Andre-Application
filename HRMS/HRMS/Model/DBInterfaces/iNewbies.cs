using HRMS.Model.DBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Model.DBInterfaces
{
    public interface iNewbies
    {
        void Add(RecruitModel user);
        void Update(RecruitModel user);
        IEnumerable<RecruitModel> Search(int[] criterias, string[] queries);
        IEnumerable<RecruitModel> GetAll();
    }
}
