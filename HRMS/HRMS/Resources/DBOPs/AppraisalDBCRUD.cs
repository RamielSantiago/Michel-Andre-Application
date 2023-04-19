using HRMS.Model.DBInterfaces;
using HRMS.Model.DBModels;
using HRMS.View.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Resources.DBOPs
{
    public class AppraisalDBCRUD : BaseRepository, iPerform
    {
        public AppraisalDBCRUD(string connectionString)
        {
            this.conString = connectionString;
        }

        public void Add(AppraisalModel user)
        {
            var connection = new SqlConnection(conString);
            connection.Open();
            SqlCommand command = new SqlCommand("INSERT INTO PerformanceAppraisal([AppraisalID], [LastName], [FirstName], [MiddleName], " +
                "[Department], [Position], [Date], [Attendance], [Accuracy], [Housekeeping], [Efficiency], [CourtesyandAttitude], [Alertness], " +
                "[DependabilityReliabilityResourcefulness], [CompliancewithCompanyRules], [Cooperation], [Judgement], [PersonalAppearance], " +
                "[Friendliness], [Total])" +
                "VALUES(@ID, @lName, @fName, @mName, @dept, @pos, @date, @att, @acc, @hk, @eff, @caa, @alrt, @drr, @ccr, @coop, @jud, @perapp," +
                " @friend, @sum)");
            command.Connection = connection;
            command.Parameters.AddWithValue("@ID", user.Id);
            command.Parameters.AddWithValue("@fName", user.FirstName);
            command.Parameters.AddWithValue("@lName", user.LastName);
            command.Parameters.AddWithValue("@mName", user.MiddleName);
            command.Parameters.AddWithValue("@dept", user.Department);
            command.Parameters.AddWithValue("@pos", user.Position);
            command.Parameters.AddWithValue("@date", user.appDate);
            command.Parameters.AddWithValue("@att", user.Attendance);
            command.Parameters.AddWithValue("@acc", user.Accuracy);
            command.Parameters.AddWithValue("@hk", user.HouseKeeping);
            command.Parameters.AddWithValue("@eff", user.Efficiency);
            command.Parameters.AddWithValue("@caa", user.CourtesyAtt);
            command.Parameters.AddWithValue("@alrt", user.Alertness);
            command.Parameters.AddWithValue("@drr", user.DRR);
            command.Parameters.AddWithValue("@ccr", user.CCP);
            command.Parameters.AddWithValue("@coop", user.Cooperation);
            command.Parameters.AddWithValue("@jud", user.Judgement);
            command.Parameters.AddWithValue("@perapp", user.Appearance);
            command.Parameters.AddWithValue("@friend", user.Friendliness);
            command.Parameters.AddWithValue("@sum", user.Total);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public IEnumerable<AppraisalModel> GetAll()
        {
            var appList = new List<AppraisalModel>();
            using (var connection = new SqlConnection(conString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select * FROM PerformanceAppraisal";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var sample = new AppraisalModel();
                        sample.Id = reader.GetInt32(0);
                        sample.LastName = reader.GetString(1);
                        sample.FirstName = reader.GetString(2);
                        sample.MiddleName = reader.GetString(3);
                        sample.Department = reader.GetString(4);
                        sample.Position = reader.GetString(5);
                        sample.appDate = reader.GetDateTime(6);
                        sample.Attendance = reader.GetInt32(7);
                        sample.Accuracy = reader.GetInt32(8);
                        sample.HouseKeeping = reader.GetInt32(9);
                        sample.Efficiency = reader.GetInt32(10);
                        sample.CourtesyAtt = reader.GetInt32(11);
                        sample.Alertness = reader.GetInt32(12);
                        sample.DRR = reader.GetInt32(13);
                        sample.CCP = reader.GetInt32(14);
                        sample.Cooperation = reader.GetInt32(15);
                        sample.Judgement = reader.GetInt32(16);
                        sample.Appearance = reader.GetInt32(17);
                        sample.Friendliness = reader.GetInt32(18);
                        sample.Total = reader.GetInt32(19);
                        appList.Add(sample);
                    }
                }
            }
            return appList;
        }

        public IEnumerable<AppraisalModel> Search(int[] criterias, string[] queries)
        {
            throw new NotImplementedException();
        }

        public int SearchID(int query)
        {
            throw new NotImplementedException();
        }

        public void Update(AppraisalModel user)
        {
            throw new NotImplementedException();
        }
    }
}
