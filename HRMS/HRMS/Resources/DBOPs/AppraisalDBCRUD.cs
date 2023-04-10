using HRMS.Model.DBInterfaces;
using HRMS.Model.DBModels;
using HRMS.View.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Resources.DBOPs
{
    public class AppraisalDBCRUD : BaseRepository, iPerform
    {
        public AppraisalDBCRUD(string connectionString)
        {
            this.conString = connectionString;
        }

        public void Add(AppraisalModel user)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AppraisalModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AppraisalModel> Search(int[] criterias, string[] queries)
        {
            throw new NotImplementedException();
        }

        public int SearchID(int query)
        {
            throw new NotImplementedException();
        }

        public void Update(AppraisalModel user)
        {
            throw new NotImplementedException();
        }
    }
}
