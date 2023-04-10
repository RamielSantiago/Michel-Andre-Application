using HRMS.Model.DBInterfaces;
using HRMS.Model.DBModels;
using HRMS.View.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMS.Presenter
{
    public class AppraisalPresenter
    {
        private readonly iPerform repo;
        private readonly iAppraisal view;
        private BindingSource bs;
        public IEnumerable<AppraisalModel> AppList;

        public AppraisalPresenter(iAppraisal view, iPerform repo)
        {
            this.view = view;
            this.repo = repo;
            this.bs = new BindingSource();
            this.view.setAppraisalBS(bs);
            LoadAllAppraisals();
            this.view.Show();
        }

        public void LoadAllAppraisals()
        {
            //AppList = repo.GetAll();
            //bs.DataSource = AppList;
        }

        public void Add()
        {
            var test = new AppraisalModel();
            //repo.Add(test);
            LoadAllAppraisals();
        }

        public int Search(int[] criteria, string[] query)
        {
            //IRList = repo.SearchIncident(criteria, query);
            //if (!IRList.Any())
            //{
            //    LoadAllReports();
            //    return -1;
            //}
            //else
            //{
            //    bs.DataSource = IRList;
            return 1;
            //}
        }

        public void Update(AppraisalModel pa)
        {
            //repo.Update(ir);
            //LoadAllReports();
        }
    }
}
