using HRMS.Model;
using HRMS.Model.DB_Models;
using HRMS.View;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMS.Presenter
{
    internal class ReportManagementPresenter
    {
        private readonly iReportManagement repo;
        private BindingSource bs;
        private readonly iReportManagementV view;
        private IEnumerable<ReportManagementModel> reports;

        public ReportManagementPresenter(iReportManagementV view, iReportManagement repo)
        {
            this.view = view;
            this.repo = repo;
            this.reports = new List<ReportManagementModel>();
            this.bs = new BindingSource();

            this.view.setReportManagementBS(bs);
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
            reports = repo.SearchReportManagement(criteria, query);
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
            ReportManagementModel sample = new ReportManagementModel();
            sample.DeptID = view.DeptID;
            sample.ManagementReport = view.ManagementReport;
            sample.DatePosted = view.DatePosted;
            repo.Add(sample);
            LoadAllReports();
        }
        public void UpdateReport(ReportManagementModel irm)
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
