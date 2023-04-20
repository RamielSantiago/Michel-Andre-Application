using HRMS.Model.DBInterfaces;
using HRMS.Model.DBModels;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Resources.DBOPs
{
    internal class FeedbackDBCRUD : BaseRepository, iInfo
    {
        public FeedbackDBCRUD(string connectionString) { 
            conString= connectionString;
        }

        public void Add(FeedbackModel user)
        {
            var connection = new SqlConnection(conString);
            connection.Open();
            SqlCommand command = new SqlCommand("INSERT INTO InformationFeedback([FeedbackID], [To], [From], [Subject], [Date], [DetailsofIssue], [RecommendedAction], [Comments], [ComplaintSig], [SupervisorSig], [HROfficerSig], [PresidentSig])" +
                "VALUES(@ID, @to, @from, @subject, @date, @detail, @RA, @comment, @cs, @ss, @hrs, @ps)");
            command.Connection = connection;
            command.Parameters.AddWithValue("@ID", user.FeedbackID);
            command.Parameters.AddWithValue("@to", user.To);
            command.Parameters.AddWithValue("@from", user.From);
            command.Parameters.AddWithValue("@subject", user.Subject);
            command.Parameters.AddWithValue("@date", user.date);
            command.Parameters.AddWithValue("@detail", user.Details);
            command.Parameters.AddWithValue("@RA", user.RecAct);
            command.Parameters.AddWithValue("@comment", user.Comments);
            command.Parameters.AddWithValue("@cs", user.CompSig);
            command.Parameters.AddWithValue("@ss", user.SuperSig);
            command.Parameters.AddWithValue("@hrs", user.HRSig);
            command.Parameters.AddWithValue("@ps", user.PresSig);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public IEnumerable<FeedbackModel> GetAll()
        {
            var IFList = new List<FeedbackModel>();
            using (var connection = new SqlConnection(conString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select * FROM InformationFeedback";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var sample = new FeedbackModel();
                        sample.FeedbackID = reader.GetInt32(0);
                        sample.To = reader.GetString(1);
                        sample.From = reader.GetString(2);
                        sample.Subject = reader.GetString(3);
                        sample.date = reader.GetDateTime(4);
                        sample.Details = reader.GetString(5);
                        sample.RecAct = reader.GetString(6);
                        sample.Comments = reader.GetString(7);
                        sample.CompSig = reader.GetString(8);
                        sample.HRSig = reader.GetString(9);
                        sample.SuperSig = reader.GetString(10);
                        sample.PresSig = reader.GetString(11);
                        IFList.Add(sample);
                    }
                }
            }
            return IFList;
        }

        public IEnumerable<FeedbackModel> Search(int[] criterias, string[] queries)
        {
            var IFList = new List<FeedbackModel>();
            string sqlcommand = "Select * From InformationFeedback Where ";
            var connection = new SqlConnection(conString);
            connection.Open();
            if (criterias[0] == 1)
            {
                sqlcommand = sqlcommand + "[To] = @to";
                if (criterias[1] == 1)
                {
                    sqlcommand = sqlcommand + " And ";
                }
            }
            if (criterias[1] == 1)
            {
                sqlcommand = sqlcommand + "[From] = @from";
            }

            SqlCommand command = new SqlCommand(sqlcommand);
            command.Connection = connection;
            if (criterias[0] == 1)
            {
                command.Parameters.AddWithValue("@to", queries[0]);
            }
            if (criterias[1] == 1)
            {
                command.Parameters.AddWithValue("@from", queries[1]);
            }

            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var sample = new FeedbackModel();
                    sample.FeedbackID = reader.GetInt32(0);
                    sample.To = reader.GetString(1);
                    sample.From = reader.GetString(2);
                    sample.Subject = reader.GetString(3);
                    sample.date = reader.GetDateTime(4);
                    sample.Details = reader.GetString(5);
                    sample.RecAct = reader.GetString(6);
                    sample.Comments = reader.GetString(7);
                    sample.CompSig = reader.GetString(8);
                    sample.HRSig = reader.GetString(9);
                    sample.SuperSig = reader.GetString(10);
                    sample.PresSig = reader.GetString(11);
                    IFList.Add(sample);
                }
            }
            connection.Close();
            return IFList;
        }

        public void Update(FeedbackModel fb)
        {
            var connection = new SqlConnection(conString);
            connection.Open();
            if (!fb.To.Equals("-1"))
            {
                SqlCommand command = new SqlCommand("UPDATE InformationFeedback SET [To] = @to WHERE FeedbackID = @iID");
                command.Connection = connection;
                command.Parameters.AddWithValue("@iID", fb.FeedbackID);
                command.Parameters.AddWithValue("@to", fb.To);
                command.ExecuteNonQuery();
            }
            if (!fb.From.Equals("-1"))
            {
                SqlCommand command = new SqlCommand("UPDATE InformationFeedback SET [From] = @from WHERE FeedbackID = @iID");
                command.Connection = connection;
                command.Parameters.AddWithValue("@iID", fb.FeedbackID);
                command.Parameters.AddWithValue("@from", fb.From);
                command.ExecuteNonQuery();
            }
            if (!fb.Subject.Equals("-1"))
            {
                SqlCommand command = new SqlCommand("UPDATE InformationFeedback SET Subject = @sub WHERE FeedbackID = @iID");
                command.Connection = connection;
                command.Parameters.AddWithValue("@iID", fb.FeedbackID);
                command.Parameters.AddWithValue("@sub", fb.Subject);
                command.ExecuteNonQuery();
            }
            if (fb.date < DateTime.MaxValue)
            {
                SqlCommand command = new SqlCommand("UPDATE InformationFeedback SET Date = @date WHERE FeedbackID = @iID");
                command.Connection = connection;
                command.Parameters.AddWithValue("@iID", fb.FeedbackID);
                command.Parameters.AddWithValue("@date", fb.date);
                command.ExecuteNonQuery();
            }
            if (!fb.RecAct.Equals("-1"))
            {
                SqlCommand command = new SqlCommand("UPDATE InformationFeedback SET RecommendedAction = @RA WHERE FeedbackID = @iID");
                command.Connection = connection;
                command.Parameters.AddWithValue("@iID", fb.FeedbackID);
                command.Parameters.AddWithValue("@RA", fb.RecAct);
                command.ExecuteNonQuery();
            }
            if (!fb.Details.Equals("-1"))
            {
                SqlCommand command = new SqlCommand("UPDATE InformationFeedback SET DetailsofIssue = @doi WHERE FeedbackID = @iID");
                command.Connection = connection;
                command.Parameters.AddWithValue("@iID", fb.FeedbackID);
                command.Parameters.AddWithValue("@doi", fb.Details);
                command.ExecuteNonQuery();
            }
            if (!fb.Comments.Equals("-1"))
            {
                SqlCommand command = new SqlCommand("UPDATE InformationFeedback SET Comments = @com WHERE FeedbackID = @iID");
                command.Connection = connection;
                command.Parameters.AddWithValue("@iID", fb.FeedbackID);
                command.Parameters.AddWithValue("@com", fb.Comments);
                command.ExecuteNonQuery();
            }
            if (!fb.CompSig.Equals("No Change"))
            {
                SqlCommand command = new SqlCommand("UPDATE InformationFeedback SET ComplaintSig = @cs WHERE FeedbackID = @iID");
                command.Connection = connection;
                command.Parameters.AddWithValue("@iID", fb.FeedbackID);
                command.Parameters.AddWithValue("@cs", fb.CompSig);
                command.ExecuteNonQuery();
            }
            if (!fb.HRSig.Equals("No Change"))
            {
                SqlCommand command = new SqlCommand("UPDATE InformationFeedback SET HROfficerSig = @hro WHERE FeedbackID = @iID");
                command.Connection = connection;
                command.Parameters.AddWithValue("@iID", fb.FeedbackID);
                command.Parameters.AddWithValue("@hro", fb.HRSig);
                command.ExecuteNonQuery();
            }
            if (!fb.CompSig.Equals("No Change"))
            {
                SqlCommand command = new SqlCommand("UPDATE InformationFeedback SET SupervisorSig = @ss WHERE FeedbackID = @iID");
                command.Connection = connection;
                command.Parameters.AddWithValue("@iID", fb.FeedbackID);
                command.Parameters.AddWithValue("@ss", fb.SuperSig);
                command.ExecuteNonQuery();
            }
            if (!fb.CompSig.Equals("No Change"))
            {
                SqlCommand command = new SqlCommand("UPDATE InformationFeedback SET PresidentSig = @ps WHERE FeedbackID = @iID");
                command.Connection = connection;
                command.Parameters.AddWithValue("@iID", fb.FeedbackID);
                command.Parameters.AddWithValue("@ps", fb.PresSig);
                command.ExecuteNonQuery();
            }
            connection.Close();
        }

        public int checkifExists(FeedbackModel fb)
        {
            var IFList = new List<FeedbackModel>();
            var connection = new SqlConnection(conString);
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM InformationFeedback WHERE FeedbackID = @id");
            command.Connection = connection;
            command.Parameters.AddWithValue("@id", fb.FeedbackID);
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var sample = new FeedbackModel();
                    sample.FeedbackID = reader.GetInt32(0);
                    sample.To = reader.GetString(1);
                    sample.From = reader.GetString(2);
                    sample.Subject = reader.GetString(3);
                    sample.date = reader.GetDateTime(4);
                    sample.Details = reader.GetString(5);
                    sample.RecAct = reader.GetString(6);
                    sample.Comments = reader.GetString(7);
                    sample.CompSig = reader.GetString(8);
                    sample.HRSig = reader.GetString(9);
                    sample.SuperSig = reader.GetString(10);
                    sample.PresSig = reader.GetString(11);
                    IFList.Add(sample);
                }
            }
            connection.Close();
            if (IFList.Any())
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
