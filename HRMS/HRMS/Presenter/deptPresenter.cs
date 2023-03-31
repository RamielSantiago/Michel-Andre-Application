using HRMS.Model;
using HRMS.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMS.Presenter
{
    public class deptPresenter
    {
        private readonly iDept repo;
        private BindingSource bs;
        private readonly iDeptV view;
        private IEnumerable<DeptModel> reports;

        public deptPresenter(iDeptV view, iDept repo)
        {
            this.view = view;
            this.repo = repo;
            this.reports = new List<DeptModel>();
            this.bs = new BindingSource();

            this.view.setDepartmentBS(bs);
            LoadAllReports();
            this.view.Show();
        }
        private void LoadAllReports()
        {
            reports = repo.GetAll();
            bs.DataSource = reports;
        }
        public int SearchReport(string criteria, string query)
        {
            reports = repo.SearchDept(criteria, query);
            if (!reports.Any())
            {
                LoadAllReports();
                return -1;
            }
            else
            {
                bs.DataSource = reports;
                return 1;
            }
        }
        public void AddReport()
        {
            DeptModel sample = new DeptModel();
            sample.jobID = view.jobID;
            sample.deptName = view.deptName;
            sample.accessRights = view.accessRights;
            sample.EmpPos = view.EmpPos;
            sample.jobLvl = view.jobLvl;
            sample.jobPosDoc = view.jobPosDoc;
            repo.Add(sample);
            LoadAllReports();
        }
        public void UpdateReport(DeptModel irm)
        {
            repo.Update(irm);
            LoadAllReports();
        }
        public void DeleteReport(string criteria, string query)
        {
            repo.Delete(criteria, query);
            LoadAllReports();
        }
    }
}
