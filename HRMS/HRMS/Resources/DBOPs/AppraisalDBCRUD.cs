﻿using HRMS.Model.DBInterfaces;
using HRMS.Model.DBModels;
using HRMS.View.Interfaces;
using System;
using System.Collections;
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

        public IEnumerable<AppraisalModel> Search(int criterias, string queries)
        {
            var appList = new List<AppraisalModel>();
            string sqlcommand = "Select * From PerformanceAppraisal Where ";
            var connection = new SqlConnection(conString);
            connection.Open();
            if (criterias == 0)
            {
                sqlcommand = sqlcommand + "AppraisalID = @id";
            }
            if (criterias == 1)
            {
                sqlcommand = sqlcommand + "LastName = @lName";
            }
            if (criterias == 2)
            {
                sqlcommand = sqlcommand + "FirstName = @fName";
            }
            if (criterias == 3)
            {
                sqlcommand = sqlcommand + "Department = @dept";
            }
            if (criterias == 4)
            {
                sqlcommand = sqlcommand + "Date Between @appdate And DateAdd(HOUR, 24, @appdate)";
            }

            SqlCommand command = new SqlCommand(sqlcommand);
            command.Connection = connection;
            if (criterias == 0)
            {
                command.Parameters.AddWithValue("@id", Convert.ToInt32(queries));
            }
            if (criterias == 1)
            {
                command.Parameters.AddWithValue("@lName", queries);
            }
            if (criterias == 2)
            {
                command.Parameters.AddWithValue("@fName", queries);
            }
            if (criterias == 3)
            {
                command.Parameters.AddWithValue("@dept", queries);
            }
            if (criterias == 4)
            {
                command.Parameters.AddWithValue("@appdate", Convert.ToDateTime(queries).Date);
            }

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
            connection.Close();
            return appList;
        }

        public int SearchID(int query)
        {
            throw new NotImplementedException();
        }

        public void Update(AppraisalModel user)
        {
            var connection = new SqlConnection(conString);
            connection.Open();
            if (user.Attendance > -1)
            {
                SqlCommand command = new SqlCommand("UPDATE PerformanceAppraisal SET Attendance = @att WHERE FirstName = @fName AND LastName = @lName AND MiddleName = @mName AND " +
                                                "Department = @dept AND Position = @pos AND Date Between @date AND DATEADD(Hour, 24, @date)");
                command.Connection = connection;
                command.Parameters.AddWithValue("@fName", user.FirstName);
                command.Parameters.AddWithValue("@lName", user.LastName);
                command.Parameters.AddWithValue("@mName", user.MiddleName);
                command.Parameters.AddWithValue("@dept", user.Department);
                command.Parameters.AddWithValue("@pos", user.Position);
                command.Parameters.AddWithValue("@date", user.appDate.Date);
                command.Parameters.AddWithValue("@att", user.Attendance);
                command.ExecuteNonQuery();
            }
            if (user.Accuracy > -1)
            {
                SqlCommand command = new SqlCommand("UPDATE PerformanceAppraisal SET Accuracy = @acc WHERE FirstName = @fName AND LastName = @lName AND MiddleName = @mName AND " +
                                                "Department = @dept AND Position = @pos AND Date Between @date AND DATEADD(Hour, 24, @date)");
                command.Connection = connection;
                command.Parameters.AddWithValue("@fName", user.FirstName);
                command.Parameters.AddWithValue("@lName", user.LastName);
                command.Parameters.AddWithValue("@mName", user.MiddleName);
                command.Parameters.AddWithValue("@dept", user.Department);
                command.Parameters.AddWithValue("@pos", user.Position);
                command.Parameters.AddWithValue("@date", user.appDate.Date);
                command.Parameters.AddWithValue("@acc", user.Accuracy);
                command.ExecuteNonQuery();
            }
            if (user.HouseKeeping > -1)
            {
                SqlCommand command = new SqlCommand("UPDATE PerformanceAppraisal SET Housekeeping = @hk WHERE FirstName = @fName AND LastName = @lName AND MiddleName = @mName AND " +
                                                "Department = @dept AND Position = @pos AND Date Between @date AND DATEADD(Hour, 24, @date)");
                command.Connection = connection;
                command.Parameters.AddWithValue("@fName", user.FirstName);
                command.Parameters.AddWithValue("@lName", user.LastName);
                command.Parameters.AddWithValue("@mName", user.MiddleName);
                command.Parameters.AddWithValue("@dept", user.Department);
                command.Parameters.AddWithValue("@pos", user.Position);
                command.Parameters.AddWithValue("@date", user.appDate.Date);
                command.Parameters.AddWithValue("@hk", user.HouseKeeping);
                command.ExecuteNonQuery();
            }
            if (user.Efficiency > -1)
            {
                SqlCommand command = new SqlCommand("UPDATE PerformanceAppraisal SET Efficiency = @eff WHERE FirstName = @fName AND LastName = @lName AND MiddleName = @mName AND " +
                                                "Department = @dept AND Position = @pos AND Date Between @date AND DATEADD(Hour, 24, @date)");
                command.Connection = connection;
                command.Parameters.AddWithValue("@fName", user.FirstName);
                command.Parameters.AddWithValue("@lName", user.LastName);
                command.Parameters.AddWithValue("@mName", user.MiddleName);
                command.Parameters.AddWithValue("@dept", user.Department);
                command.Parameters.AddWithValue("@pos", user.Position);
                command.Parameters.AddWithValue("@date", user.appDate.Date);
                command.Parameters.AddWithValue("@eff", user.Efficiency);
                command.ExecuteNonQuery();
            }
            if (user.CourtesyAtt > -1)
            {
                SqlCommand command = new SqlCommand("UPDATE PerformanceAppraisal SET CourtesyandAttitude = @caa WHERE FirstName = @fName AND LastName = @lName AND MiddleName = @mName AND " +
                                                "Department = @dept AND Position = @pos AND Date Between @date AND DATEADD(Hour, 24, @date)");
                command.Connection = connection;
                command.Parameters.AddWithValue("@fName", user.FirstName);
                command.Parameters.AddWithValue("@lName", user.LastName);
                command.Parameters.AddWithValue("@mName", user.MiddleName);
                command.Parameters.AddWithValue("@dept", user.Department);
                command.Parameters.AddWithValue("@pos", user.Position);
                command.Parameters.AddWithValue("@date", user.appDate.Date);
                command.Parameters.AddWithValue("@caa", user.CourtesyAtt);
                command.ExecuteNonQuery();
            }
            if (user.Alertness > -1)
            {
                SqlCommand command = new SqlCommand("UPDATE PerformanceAppraisal SET Alertness = @art WHERE FirstName = @fName AND LastName = @lName AND MiddleName = @mName AND " +
                                                "Department = @dept AND Position = @pos AND Date Between @date AND DATEADD(Hour, 24, @date)");
                command.Connection = connection;
                command.Parameters.AddWithValue("@fName", user.FirstName);
                command.Parameters.AddWithValue("@lName", user.LastName);
                command.Parameters.AddWithValue("@mName", user.MiddleName);
                command.Parameters.AddWithValue("@dept", user.Department);
                command.Parameters.AddWithValue("@pos", user.Position);
                command.Parameters.AddWithValue("@date", user.appDate.Date);
                command.Parameters.AddWithValue("@art", user.Alertness);
                command.ExecuteNonQuery();
            }
            if (user.DRR > -1)
            {
                SqlCommand command = new SqlCommand("UPDATE PerformanceAppraisal SET DependabilityReliabilityResourcefulness = @drr WHERE FirstName = @fName AND LastName = @lName AND MiddleName = @mName AND " +
                                                "Department = @dept AND Position = @pos AND Date Between @date AND DATEADD(Hour, 24, @date)");
                command.Connection = connection;
                command.Parameters.AddWithValue("@fName", user.FirstName);
                command.Parameters.AddWithValue("@lName", user.LastName);
                command.Parameters.AddWithValue("@mName", user.MiddleName);
                command.Parameters.AddWithValue("@dept", user.Department);
                command.Parameters.AddWithValue("@pos", user.Position);
                command.Parameters.AddWithValue("@date", user.appDate.Date);
                command.Parameters.AddWithValue("@drr", user.DRR);
                command.ExecuteNonQuery();
            }
            if (user.CCP > -1)
            {
                SqlCommand command = new SqlCommand("UPDATE PerformanceAppraisal SET CompliancewithCompanyRules = @ccp WHERE FirstName = @fName AND LastName = @lName AND MiddleName = @mName AND " +
                                                "Department = @dept AND Position = @pos AND Date Between @date AND DATEADD(Hour, 24, @date)");
                command.Connection = connection;
                command.Parameters.AddWithValue("@fName", user.FirstName);
                command.Parameters.AddWithValue("@lName", user.LastName);
                command.Parameters.AddWithValue("@mName", user.MiddleName);
                command.Parameters.AddWithValue("@dept", user.Department);
                command.Parameters.AddWithValue("@pos", user.Position);
                command.Parameters.AddWithValue("@date", user.appDate.Date);
                command.Parameters.AddWithValue("@ccp", user.CCP);
                command.ExecuteNonQuery();
            }
            if (user.Cooperation > -1)
            {
                SqlCommand command = new SqlCommand("UPDATE PerformanceAppraisal SET Cooperation = @coop WHERE FirstName = @fName AND LastName = @lName AND MiddleName = @mName AND " +
                                                "Department = @dept AND Position = @pos AND Date Between @date AND DATEADD(Hour, 24, @date)");
                command.Connection = connection;
                command.Parameters.AddWithValue("@fName", user.FirstName);
                command.Parameters.AddWithValue("@lName", user.LastName);
                command.Parameters.AddWithValue("@mName", user.MiddleName);
                command.Parameters.AddWithValue("@dept", user.Department);
                command.Parameters.AddWithValue("@pos", user.Position);
                command.Parameters.AddWithValue("@date", user.appDate.Date);
                command.Parameters.AddWithValue("@coop", user.Cooperation);
                command.ExecuteNonQuery();
            }
            if (user.Judgement > -1)
            {
                SqlCommand command = new SqlCommand("UPDATE PerformanceAppraisal SET Judgement = @jud WHERE FirstName = @fName AND LastName = @lName AND MiddleName = @mName AND " +
                                                "Department = @dept AND Position = @pos AND Date Between @date AND DATEADD(Hour, 24, @date)");
                command.Connection = connection;
                command.Parameters.AddWithValue("@fName", user.FirstName);
                command.Parameters.AddWithValue("@lName", user.LastName);
                command.Parameters.AddWithValue("@mName", user.MiddleName);
                command.Parameters.AddWithValue("@dept", user.Department);
                command.Parameters.AddWithValue("@pos", user.Position);
                command.Parameters.AddWithValue("@date", user.appDate.Date);
                command.Parameters.AddWithValue("@jud", user.Judgement);
                command.ExecuteNonQuery();
            }
            if (user.Appearance > -1)
            {
                SqlCommand command = new SqlCommand("UPDATE PerformanceAppraisal SET PersonalAppearance = @pa WHERE FirstName = @fName AND LastName = @lName AND MiddleName = @mName AND " +
                                                "Department = @dept AND Position = @pos AND Date Between @date AND DATEADD(Hour, 24, @date)");
                command.Connection = connection;
                command.Parameters.AddWithValue("@fName", user.FirstName);
                command.Parameters.AddWithValue("@lName", user.LastName);
                command.Parameters.AddWithValue("@mName", user.MiddleName);
                command.Parameters.AddWithValue("@dept", user.Department);
                command.Parameters.AddWithValue("@pos", user.Position);
                command.Parameters.AddWithValue("@date", user.appDate.Date);
                command.Parameters.AddWithValue("@pa", user.Appearance);
                command.ExecuteNonQuery();
            }
            if (user.Friendliness > -1)
            {
                SqlCommand command = new SqlCommand("UPDATE PerformanceAppraisal SET Friendliness = @ff WHERE FirstName = @fName AND LastName = @lName AND MiddleName = @mName AND " +
                                                "Department = @dept AND Position = @pos AND Date Between @date AND DATEADD(Hour, 24, @date)");
                command.Connection = connection;
                command.Parameters.AddWithValue("@fName", user.FirstName);
                command.Parameters.AddWithValue("@lName", user.LastName);
                command.Parameters.AddWithValue("@mName", user.MiddleName);
                command.Parameters.AddWithValue("@dept", user.Department);
                command.Parameters.AddWithValue("@pos", user.Position);
                command.Parameters.AddWithValue("@date", user.appDate.Date);
                command.Parameters.AddWithValue("@ff", user.Friendliness);
                command.ExecuteNonQuery();
            }
            if (user.Total > -1)
            {
                SqlCommand command = new SqlCommand("UPDATE PerformanceAppraisal SET Total = @tot WHERE FirstName = @fName AND LastName = @lName AND MiddleName = @mName AND " +
                                                "Department = @dept AND Position = @pos AND Date Between @date AND DATEADD(Hour, 24, @date)");
                command.Connection = connection;
                command.Parameters.AddWithValue("@fName", user.FirstName);
                command.Parameters.AddWithValue("@lName", user.LastName);
                command.Parameters.AddWithValue("@mName", user.MiddleName);
                command.Parameters.AddWithValue("@dept", user.Department);
                command.Parameters.AddWithValue("@pos", user.Position);
                command.Parameters.AddWithValue("@date", user.appDate.Date);
                command.Parameters.AddWithValue("@tot", user.Total);
                command.ExecuteNonQuery();
            }
            connection.Close();
        }

        public AppraisalModel getExisting(AppraisalModel user)
        {
            var userlist = new List<AppraisalModel>();
            var connection = new SqlConnection(conString);
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM PerformanceAppraisal WHERE FirstName = @fName AND LastName = @lName AND MiddleName = @mName AND " +
                                                "Department = @dept AND Position = @pos AND Date Between @date AND DATEADD(Hour, 24, @date)");
            command.Connection = connection;
            command.Parameters.AddWithValue("@fName", user.FirstName);
            command.Parameters.AddWithValue("@lName", user.LastName);
            command.Parameters.AddWithValue("@mName", user.MiddleName);
            command.Parameters.AddWithValue("@dept", user.Department);
            command.Parameters.AddWithValue("@pos", user.Position);
            command.Parameters.AddWithValue("@date", user.appDate);
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
                    userlist.Add(sample);
                }
            }

            connection.Close();
            if (userlist.Any())
            {
                return userlist.ElementAt(0);
            }
            else
            {
                var fail = new AppraisalModel();
                fail.FirstName = "";
                return fail;
            }
        }
    }
}
