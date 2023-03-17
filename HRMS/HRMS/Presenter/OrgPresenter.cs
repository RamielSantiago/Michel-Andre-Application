using HRMS.Model;
using HRMS.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Presenter
{
    public class OrgPresenter
    {
        private readonly View.OrgChartView view;

        public OrgPresenter(View.OrgChartView view)
        {
            this.view = view;
        }
    }
}
