
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using HRMS.Model;
using HRMS.Model.DBModels;

namespace HRMS.Model.DBInterfaces
{
    public interface iReport
    {
        void Add(IRModel user);
        void Update(IRModel user);
        int SearchID(int query);
        IEnumerable<IRModel> SearchIncident(int[] criterias, string[] queries);
        IEnumerable<IRModel> GetAll();

    }
}
