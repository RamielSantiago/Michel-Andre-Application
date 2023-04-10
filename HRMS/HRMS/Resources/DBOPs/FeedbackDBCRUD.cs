using HRMS.Model.DBInterfaces;
using HRMS.Model.DBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Resources.DBOPs
{
    internal class FeedbackDBCRUD : BaseRepository, iInfo
    {
        public FeedbackDBCRUD(string connectionString) { 
            conString= connectionString;
        }

        public void Add(FeedbackModel user)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<FeedbackModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<FeedbackModel> Search(int[] criterias, string[] queries)
        {
            throw new NotImplementedException();
        }

        public int Update(FeedbackModel user)
        {
            throw new NotImplementedException();
        }
    }
}
