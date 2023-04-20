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
    public class FeedbackPresenter
    {
        private readonly iInfo repo;
        private readonly iFeedback view;
        private BindingSource bs;
        public IEnumerable<FeedbackModel> FBList;

        public FeedbackPresenter(iFeedback view, iInfo repo)
        {
            this.view = view;
            this.repo = repo;
            this.bs = new BindingSource();
            this.view.setFeedbackBS(bs);
            LoadAllFeedback();
            this.view.Show();
        }

        public void LoadAllFeedback()
        {
            FBList = repo.GetAll();
            bs.DataSource = FBList;
        }

        public void Add()
        {
            var test = new FeedbackModel();
            test.FeedbackID = FBList.ElementAt(FBList.Count() - 1).FeedbackID + 1;
            test.To = view.To;
            test.From = view.From; 
            test.Subject = view.Subject;
            test.Comments = view.Comments;
            test.RecAct= view.RecAct;
            test.Details = view.Details;
            test.date = view.date;
            if (view.CompSig)
            {
                test.CompSig = "Complete";
            }
            else
            {
                test.CompSig = "Incomplete";
            }
            if (view.HRSig)
            {
                test.HRSig = "Complete";
            }
            else
            {
                test.HRSig = "Incomplete";
            }
            if (view.SuperSig)
            {
                test.SuperSig = "Complete";
            }
            else
            {
                test.SuperSig = "Incomplete";
            }
            if (view.PresSig)
            {
                test.PresSig = "Complete";
            }
            else
            {
                test.PresSig = "Incomplete";
            }
            repo.Add(test);
            LoadAllFeedback();
        }

        public void Update(FeedbackModel fb)
        {
            repo.Update(fb);
            LoadAllFeedback();
        }

        public int Search(int[] criterias, string[] queries)
        {
            FBList = repo.Search(criterias, queries);
            if (!FBList.Any())
            {
                LoadAllFeedback();
                return -1;
            }
            else
            {
                bs.DataSource = FBList;
                return 1;
            }
        }
    }
}
