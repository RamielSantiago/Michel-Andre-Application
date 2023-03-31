using HRMS.Model;
using HRMS.Model.DB_Models;
using HRMS.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMS.Presenter
{
    public class PersonnelActionPresenter
    {
        private readonly iPersonnelAction repo;
        private BindingSource bs;
        private readonly iPersonnelActionV view;
        private IEnumerable<PersonnelActionModel> reports;

        public PersonnelActionPresenter(iDeptV view, iPersonnelAction repo)
        {
            this.view = view;
            this.repo = repo;
            this.reports = new List<PersonnelActionModel>();
            this.bs = new BindingSource();

            this.view.setPersonnelActionBS(bs);
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
            reports = repo.SearchPersonnalAction(criteria, query);
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
            PersonnelActionModel sample = new PersonnelActionModel();
            sample.EmployeeID = view.EmployeeID;
            sample.DateOfAdjustment = view.DateOfAdjustment;
            sample.PersonnelActionReport = view.PersonnelActionReport;
            sample.Status = view.Status;
            repo.Add(sample);
            LoadAllReports();
        }
        public void UpdateReport(PersonnelActionModel irm)
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
