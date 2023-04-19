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
            AppList = repo.GetAll();
            bs.DataSource = AppList;
        }

        public void Add()
        {
            var test = new AppraisalModel();
            test.Id = AppList.ElementAt(AppList.Count() - 1).Id + 1;
            test.FirstName = view.FirstName;
            test.LastName = view.LastName;
            test.MiddleName = view.MiddleName;
            test.Department= view.Department;
            test.Position = view.Position;
            test.appDate = view.appDate;
            test.Attendance= view.Attendance;
            test.Accuracy= view.Accuracy;
            test.HouseKeeping= view.HouseKeeping;
            test.Efficiency= view.Efficiency;
            test.CourtesyAtt = view.CourtesyAtt;
            test.Alertness = view.Alertness;
            test.DRR= view.DRR;
            test.Cooperation= view.Cooperation;
            test.Judgement= view.Judgement;
            test.CCP = view.CCP;
            test.Appearance = view.Appearance;
            test.Friendliness= view.Friendliness;
            test.Total = view.Total;
            repo.Add(test);
            LoadAllAppraisals();
        }

        public int Search(int[] criteria, string[] query)
        {
            //AppList = repo.SearchIncident(criteria, query);
            //if (!AppList.Any())
            //{
            //    LoadAllAppraisals();
            //    return -1;
            //}
            //else
            //{
            //    bs.DataSource = AppList;
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
