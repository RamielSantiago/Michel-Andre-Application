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
    public class IncidentPresenter
    {
        private readonly iIncidentReport repo;
        private BindingSource bs;
        private readonly iIncident view;
        private IEnumerable<IncidentReportModel> reports;

        public IncidentPresenter(iIncident view, iIncidentReport repo)
        {
            this.view = view;
            this.repo = repo;
            this.reports = new List<IncidentReportModel>();
            this.bs = new BindingSource();

            this.view.setIncidentBS(bs);
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
            reports = repo.SearchIncident(criteria, query);
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
            IncidentReportModel sample = new IncidentReportModel();
            sample.IncidentID = view.IncidentID;
            sample.DateOccurred = view.DateOccurred;
            sample.DatePosted = view.DatePosted;
            sample.EmployeesInvolved = view.EmployeesInvolved;
            sample.ReportedBy = view.ReportedBy;
            sample.ReportersID = view.ReportersID;
            sample.TypeOfIncident = view.TypeOfIncident;
            sample.Specifics = view.Specifics;
            sample.Instigator = view.Instigator;
            sample.Solution = view.Solution;
            sample.Penalty = view.Penalty;
            sample.Remarks = view.Remarks;
            repo.Add(sample);
            LoadAllReports();
        }
        public void UpdateReport(IncidentReportModel irm)
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
