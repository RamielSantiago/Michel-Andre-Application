using HRMS.Model.DBInterfaces;
using HRMS.Model.DBModels;
using HRMS.View.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMS.Presenter
{
    public class IRPresenter
    {
        private readonly iReport repo;
        private readonly iIncident view;
        private BindingSource bs;
        public IEnumerable<IRModel> IRList;

        public IRPresenter(iIncident view, iReport repo) {
            this.view = view;
            this.repo = repo;
            this.bs = new BindingSource();
            this.view.setIncidentBS(bs);
            LoadAllReports();
            this.view.Show();
        }

        public void LoadAllReports()
        {
            IRList = repo.GetAll();
            bs.DataSource = IRList;
        }

        public void AddReport()
        {
            var test = new IRModel();
            test.IncidentID = IRList.ElementAt(IRList.Count()-1).IncidentID+1;
            test.LastName = view.LastName;
            test.FirstName = view.FirstName;
            test.MiddleInitial = view.MiddleInitial;
            test.Department = view.Department;
            test.Position = view.Position;
            test.DatePosted = view.DatePosted;
            test.Remarks = view.Remarks;
            test.PeopleInvolved = view.PeopleInvolved;
            test.Incident = view.Incident;
            test.ApprovedBy = view.ApprovedBy;
            repo.Add(test);
            LoadAllReports();
        }

        public int SearchReport(int[] criteria, string[] query) {
            IRList = repo.SearchIncident(criteria, query);
            if (!IRList.Any())
            {
                LoadAllReports();
                return -1;
            }
            else
            {
                bs.DataSource = IRList;
                return 1;
            }
        }

        public void UpdateReport(IRModel ir)
        {
            repo.Update(ir);
            LoadAllReports();
        }
    }
}
