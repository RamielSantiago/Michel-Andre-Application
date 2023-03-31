using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Model
{
    public interface iDept
    {
        void Add(DeptModel dept);
        void Update(DeptModel dept);
        void Delete(string criteria, string query);
        IEnumerable<DeptModel> SearchDept(string criteria, string query);
        IEnumerable<DeptModel> GetAll();
    }
}
