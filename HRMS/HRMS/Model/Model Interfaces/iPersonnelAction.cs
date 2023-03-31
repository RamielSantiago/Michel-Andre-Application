using HRMS.Model.DB_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Model
{
    internal interface iPersonnelAction
    {
        void Add(PersonnelActionModel user);
        void Update(PersonnelActionModel user);
        void Delete(string criteria, string query);
        IEnumerable<PersonnelActionModel> SearchPersonnalAction(string criteria, string query);
        IEnumerable<PersonnelActionModel> GetAll();
    }
}
