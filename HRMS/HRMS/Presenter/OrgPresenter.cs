using HRMS.Model;
using HRMS.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRMS.View;
namespace HRMS.Presenter
{
    public class OrgPresenter
    {
        private readonly CompanyOrgChart coc;

        public OrgPresenter(CompanyOrgChart view)
        {
            this.coc = view;
        }
    }
}
