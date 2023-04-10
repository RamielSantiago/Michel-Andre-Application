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
    public class RecruitPresenter
    {
        private readonly iNewbies repo;
        private readonly iRecruit view;
        private BindingSource bs;
        public IEnumerable<RecruitModel> RecruitList;

        public RecruitPresenter(iRecruit view, iNewbies repo)
        {
            this.view = view;
            this.repo = repo;
            this.bs = new BindingSource();
            this.view.setRecruitBS(bs);
            LoadAllRecruits();
            this.view.Show();
        }
        public void LoadAllRecruits()
        {
            RecruitList = repo.GetAll();
            bs.DataSource = RecruitList;
        }
        public void Add()
        {
            var validUser = new RecruitModel();
            validUser.ApplicationID = repo.GetAll().ElementAt(repo.GetAll().Count() - 1).ApplicationID + 1;
            validUser.FirstName = view.FirstName;
            validUser.MiddleName = view.MiddleName;
            validUser.LastName = view.LastName;
            validUser.Department = view.Department;
            validUser.Position = view.Position;
            validUser.ApplicationDate = view.ApplicationDate;
            if (view.InterInterview1 == true)
            {
                validUser.Interview1 = "Complete";
            }
            else
            {
                validUser.Interview1 = "Incomplete";
            }
            if (view.InterInterview2 == true)
            {
                validUser.Interview2 = "Complete";
            }
            else
            {
                validUser.Interview2 = "Incomplete";
            }
            if (view.InterInterview3 == true)
            {
                validUser.Interview3 = "Complete";
            }
            else
            {
                validUser.Interview3 = "Incomplete";
            }
            if (view.training == true)
            {
                validUser.Training = "Complete";
            }
            else
            {
                validUser.Training = "Incomplete";
            }
            if (view.resume == true)
            {
                validUser.resume = "Complete";
            }
            else
            {
                validUser.resume = "Incomplete";
            }
            if (view.PSA == true)
            {
                validUser.PSA = "Complete";
            }
            else
            {
                validUser.PSA = "Incomplete";
            }
            if (view.sss == true)
            {
                validUser.SSS = "Complete";
            }
            else
            {
                validUser.SSS = "Incomplete";
            }
            if (view.nbi == true)
            {
                validUser.NBI = "Complete";
            }
            else
            {
                validUser.NBI = "Incomplete";
            }
            if (view.police == true)
            {
                validUser.Police = "Complete";
            }
            else
            {
                validUser.Police = "Incomplete";
            }
            if (view.PagIbig == true)
            {
                validUser.PagIbig = "Complete";
            }
            else
            {
                validUser.PagIbig = "Incomplete";
            }
            if (view.philhealth == true)
            {
                validUser.philhealth = "Complete";
            }
            else
            {
                validUser.philhealth = "Incomplete";
            }
            if (view.bir == true)
            {
                validUser.BIR = "Complete";
            }
            else
            {
                validUser.BIR = "Incomplete";
            }
            if (view.tor == true)
            {
                validUser.TOR = "Complete";
            }
            else
            {
                validUser.TOR = "Incomplete";
            }
            if (view.EmpCert == true)
            {
                validUser.EmpCert = "Complete";
            }
            else
            {
                validUser.EmpCert = "Incomplete";
            }
            if (view.MedExam == true)
            {
                validUser.MedExam = "Complete";
            }
            else
            {
                validUser.MedExam = "Incomplete";
            }
            if (view.InterInterview1 == true && view.InterInterview2 == true && view.InterInterview3 == true && view.training == true &&
               view.resume == true && view.PSA == true && view.sss == true && view.nbi == true &&
               view.police == true && view.philhealth == true && view.bir == true && view.tor == true &&
               view.PagIbig == true && view.EmpCert == true && view.MedExam == true)
            {
                validUser.OverallStatus = "Requirements Complete";
            }
            else
            {
                validUser.OverallStatus = "Requirements Incomplete";
            }
            repo.Add(validUser);
            LoadAllRecruits();
        }

        public int Search(int[] criterias, string[] queries)
        {
            RecruitList = repo.Search(criterias, queries);
            if (!RecruitList.Any())
            {
                LoadAllRecruits();
                return -1;
            }
            else
            {
                bs.DataSource = RecruitList;
                return 1;
            }
        }
        public void Update()
        {
            var validUser = new RecruitModel();
            validUser.FirstName = view.FirstName;
            validUser.MiddleName = view.MiddleName;
            validUser.LastName = view.LastName;
            validUser.Department = view.Department;
            validUser.Position = view.Position;
            validUser.ApplicationDate = view.ApplicationDate;
            if (view.InterInterview1 == true)
            {
                validUser.Interview1 = "Complete";
            }
            else
            {
                validUser.Interview1 = "Incomplete";
            }
            if (view.InterInterview2 == true)
            {
                validUser.Interview2 = "Complete";
            }
            else
            {
                validUser.Interview2 = "Incomplete";
            }
            if (view.InterInterview3 == true)
            {
                validUser.Interview3 = "Complete";
            }
            else
            {
                validUser.Interview3 = "Incomplete";
            }
            if (view.training == true)
            {
                validUser.Training = "Complete";
            }
            else
            {
                validUser.Training = "Incomplete";
            }
            if (view.resume == true)
            {
                validUser.resume = "Complete";
            }
            else
            {
                validUser.resume = "Incomplete";
            }
            if (view.PSA == true)
            {
                validUser.PSA = "Complete";
            }
            else
            {
                validUser.PSA = "Incomplete";
            }
            if (view.sss == true)
            {
                validUser.SSS = "Complete";
            }
            else
            {
                validUser.SSS = "Incomplete";
            }
            if (view.nbi == true)
            {
                validUser.NBI = "Complete";
            }
            else
            {
                validUser.NBI = "Incomplete";
            }
            if (view.police == true)
            {
                validUser.Police = "Complete";
            }
            else
            {
                validUser.Police = "Incomplete";
            }
            if (view.PagIbig == true)
            {
                validUser.PagIbig = "Complete";
            }
            else
            {
                validUser.PagIbig = "Incomplete";
            }
            if (view.philhealth == true)
            {
                validUser.philhealth = "Complete";
            }
            else
            {
                validUser.philhealth = "Incomplete";
            }
            if (view.bir == true)
            {
                validUser.BIR = "Complete";
            }
            else
            {
                validUser.BIR = "Incomplete";
            }
            if (view.tor == true)
            {
                validUser.TOR = "Complete";
            }
            else
            {
                validUser.TOR = "Incomplete";
            }
            if (view.EmpCert == true)
            {
                validUser.EmpCert = "Complete";
            }
            else
            {
                validUser.EmpCert = "Incomplete";
            }
            if (view.MedExam == true)
            {
                validUser.MedExam = "Complete";
            }
            else
            {
                validUser.MedExam = "Incomplete";
            }
            if (view.InterInterview1 == true && view.InterInterview2 == true && view.InterInterview3 == true && view.training == true &&
               view.resume == true && view.PSA == true && view.sss == true && view.nbi == true &&
               view.police == true && view.philhealth == true && view.bir == true && view.tor == true &&
               view.PagIbig == true && view.EmpCert == true && view.MedExam == true)
            {
                validUser.OverallStatus = "Requirements Complete";
            }
            else
            {
                validUser.OverallStatus = "Requirements Incomplete";
            }
            repo.Update(validUser);
            LoadAllRecruits();
        }

        public int SearchName(string first, string last)
        {
            //var temp = repo.SearchUserByName(first, last);
            //if (temp.Any())
            //{
            //    return -1;
            //}
            //else
            //{
            return 1;
            //}
        }
    }
}
