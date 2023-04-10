using HRMS.Model.DBInterfaces;
using HRMS.Model.DBModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HRMS.Resources.DBOPs
{
    public class RecruitDBCRUD : BaseRepository, iNewbies
    {
        public RecruitDBCRUD(string connectionString)
        {
            this.conString = connectionString;
        }

        public void Add(RecruitModel user)
        {
            var connection = new SqlConnection(conString);
            connection.Open();
            SqlCommand command = new SqlCommand("INSERT INTO Recruitment([RecruitID], [LastName], [FirstName], [MiddleName], [Department], [Position], [ApplicationDate], [Interview1], [Interview2], [Interview3], [Training], [Resume], [BirthCertificate]," +
                " [SSS], [NBI], [Police], [PhilHealth], [PagIBIG], [BIR], [TOR], [CertificateofEmployment], [MedicalExam], [OverallStatus]) " +
                "VALUES (@RID, @lname, @fname, @mname, @dept, @pos, @date, @one, @two, @three, @train, @res,@bc, @sss, @nbi, @pol, @ph, @pi, @bir, @tor, @coe, @med, @os)");
            command.Connection = connection;
            command.Parameters.Add("@RID", SqlDbType.Int).Value = user.ApplicationID;
            command.Parameters.Add("@lname", SqlDbType.VarChar, 50).Value = user.LastName;
            command.Parameters.Add("@fname", SqlDbType.VarChar, 50).Value = user.FirstName;
            command.Parameters.Add("@mname", SqlDbType.VarChar, 50).Value = user.MiddleName;
            command.Parameters.Add("@dept", SqlDbType.VarChar, 50).Value = user.Department;
            command.Parameters.Add("@pos", SqlDbType.VarChar, 50).Value = user.Position;
            command.Parameters.Add("@date", SqlDbType.DateTime, 0).Value = user.ApplicationDate;
            command.Parameters.Add("@one", SqlDbType.VarChar, 50).Value = user.Interview1;
            command.Parameters.Add("@two", SqlDbType.VarChar, 50).Value = user.Interview2;
            command.Parameters.Add("@three", SqlDbType.VarChar, 50).Value = user.Interview3;
            command.Parameters.Add("@train", SqlDbType.VarChar, 50).Value = user.Training;
            command.Parameters.Add("@res", SqlDbType.VarChar, 50).Value = user.resume;
            command.Parameters.Add("@bc", SqlDbType.VarChar, 50).Value = user.PSA;
            command.Parameters.Add("@sss", SqlDbType.VarChar, 50).Value = user.SSS;
            command.Parameters.Add("@nbi", SqlDbType.VarChar, 50).Value = user.NBI;
            command.Parameters.Add("@pol", SqlDbType.VarChar, 50).Value = user.Police;
            command.Parameters.Add("@ph", SqlDbType.VarChar, 50).Value = user.philhealth;
            command.Parameters.Add("@pi", SqlDbType.VarChar, 50).Value = user.PagIbig;
            command.Parameters.Add("@bir", SqlDbType.VarChar, 50).Value = user.BIR;
            command.Parameters.Add("@tor", SqlDbType.VarChar, 50).Value = user.TOR;
            command.Parameters.Add("@coe", SqlDbType.VarChar, 50).Value = user.EmpCert;
            command.Parameters.Add("@med", SqlDbType.VarChar, 50).Value = user.MedExam;
            command.Parameters.Add("@os", SqlDbType.VarChar, 50).Value = user.OverallStatus;
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void Update(RecruitModel user)
        {
            var irList = new List<RecruitModel>();
            var connection = new SqlConnection(conString);
            connection.Open();
            SqlCommand getuser = new SqlCommand("Select * From Recruitment Where FirstName = @fName And LastName = @lName And MiddleName = @mName");
            getuser.Connection = connection;
            getuser.Parameters.AddWithValue("@lName", user.LastName);
            getuser.Parameters.AddWithValue("@fName", user.FirstName);
            getuser.Parameters.AddWithValue("@mName", user.MiddleName);
            getuser.Parameters.AddWithValue("@dept", user.Department);
            getuser.Parameters.AddWithValue("@pos", user.Position);
            using (var reader = getuser.ExecuteReader())
            {
                while (reader.Read())
                {
                    var sample = new RecruitModel();
                    sample.ApplicationID = reader.GetInt32(0);
                    sample.LastName = reader.GetString(1);
                    sample.FirstName = reader.GetString(2);
                    sample.MiddleName = reader.GetString(3);
                    sample.Department = reader.GetString(4);
                    sample.Position = reader.GetString(5);
                    sample.ApplicationDate = reader.GetDateTime(6);
                    sample.Interview1 = reader.GetString(7);
                    sample.Interview2 = reader.GetString(8);
                    sample.Interview3 = reader.GetString(9);
                    sample.Training = reader.GetString(10);
                    sample.resume = reader.GetString(11);
                    sample.PSA = reader.GetString(12);
                    sample.SSS = reader.GetString(13);
                    sample.NBI = reader.GetString(14);
                    sample.Police = reader.GetString(15);
                    sample.philhealth = reader.GetString(16);
                    sample.PagIbig = reader.GetString(17);
                    sample.BIR = reader.GetString(18);
                    sample.TOR = reader.GetString(19);
                    sample.EmpCert = reader.GetString(20);
                    sample.MedExam = reader.GetString(21);
                    sample.OverallStatus = reader.GetString(22);
                    irList.Add(sample);
                }
            }
            if (!irList.Any())
            {
                MessageBox.Show("No record found for update", "Human Resource Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (irList.Count() > 1)
            {
                MessageBox.Show("Multiple records found. Unable to update.", "Human Resource Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlCommand command = new SqlCommand("UPDATE Recruitment SET Department = @dept WHERE LastName = @lname AND FirstName = @fname AND MiddleName = @mname");
                command.Connection = connection;
                command.Parameters.Add("@dept", SqlDbType.VarChar, 50).Value = user.Department;
                command.Parameters.Add("@lname", SqlDbType.VarChar, 50).Value = user.LastName;
                command.Parameters.Add("@fname", SqlDbType.VarChar, 50).Value = user.FirstName;
                command.Parameters.Add("@mname", SqlDbType.VarChar, 50).Value = user.MiddleName;
                command.ExecuteNonQuery();

                SqlCommand command1 = new SqlCommand("UPDATE Recruitment SET Position = @pos WHERE LastName = @lname AND FirstName = @fname AND MiddleName = @mname");
                command1.Connection = connection;
                command1.Parameters.Add("@pos", SqlDbType.VarChar, 50).Value = user.Position;
                command1.Parameters.Add("@lname", SqlDbType.VarChar, 50).Value = user.LastName;
                command1.Parameters.Add("@fname", SqlDbType.VarChar, 50).Value = user.FirstName;
                command1.Parameters.Add("@mname", SqlDbType.VarChar, 50).Value = user.MiddleName;
                command1.ExecuteNonQuery();

                SqlCommand command2 = new SqlCommand("UPDATE Recruitment SET ApplicationDate = @date WHERE LastName = @lname AND FirstName = @fname AND MiddleName = @mname");
                command2.Connection = connection;
                command2.Parameters.Add("@date", SqlDbType.DateTime, 0).Value = user.ApplicationDate;
                command2.Parameters.Add("@lname", SqlDbType.VarChar, 50).Value = user.LastName;
                command2.Parameters.Add("@fname", SqlDbType.VarChar, 50).Value = user.FirstName;
                command2.Parameters.Add("@mname", SqlDbType.VarChar, 50).Value = user.MiddleName;
                command2.ExecuteNonQuery();


                SqlCommand command3 = new SqlCommand("UPDATE Recruitment SET Interview1 = @one WHERE LastName = @lname AND FirstName = @fname AND MiddleName = @mname");
                command3.Connection = connection;
                command3.Parameters.Add("@one", SqlDbType.VarChar, 50).Value = user.Interview1;
                command3.Parameters.Add("@lname", SqlDbType.VarChar, 50).Value = user.LastName;
                command3.Parameters.Add("@fname", SqlDbType.VarChar, 50).Value = user.FirstName;
                command3.Parameters.Add("@mname", SqlDbType.VarChar, 50).Value = user.MiddleName;
                command3.ExecuteNonQuery();


                SqlCommand command4 = new SqlCommand("UPDATE Recruitment SET Interview2 = @two WHERE LastName = @lname AND FirstName = @fname AND MiddleName = @mname");
                command4.Connection = connection;
                command4.Parameters.Add("@two", SqlDbType.VarChar, 50).Value = user.Interview2;
                command4.Parameters.Add("@lname", SqlDbType.VarChar, 50).Value = user.LastName;
                command4.Parameters.Add("@fname", SqlDbType.VarChar, 50).Value = user.FirstName;
                command4.Parameters.Add("@mname", SqlDbType.VarChar, 50).Value = user.MiddleName;
                command4.ExecuteNonQuery();


                SqlCommand command5 = new SqlCommand("UPDATE Recruitment SET Interview3 = @three WHERE LastName = @lname AND FirstName = @fname AND MiddleName = @mname");
                command5.Connection = connection;
                command5.Parameters.Add("@three", SqlDbType.VarChar, 50).Value = user.Interview3;
                command5.Parameters.Add("@lname", SqlDbType.VarChar, 50).Value = user.LastName;
                command5.Parameters.Add("@fname", SqlDbType.VarChar, 50).Value = user.FirstName;
                command5.Parameters.Add("@mname", SqlDbType.VarChar, 50).Value = user.MiddleName;
                command5.ExecuteNonQuery();


                SqlCommand command6 = new SqlCommand("UPDATE Recruitment SET Training = @train WHERE LastName = @lname AND FirstName = @fname AND MiddleName = @mname");
                command6.Connection = connection;
                command6.Parameters.Add("@train", SqlDbType.VarChar, 50).Value = user.Training;
                command6.Parameters.Add("@lname", SqlDbType.VarChar, 50).Value = user.LastName;
                command6.Parameters.Add("@fname", SqlDbType.VarChar, 50).Value = user.FirstName;
                command6.Parameters.Add("@mname", SqlDbType.VarChar, 50).Value = user.MiddleName;
                command6.ExecuteNonQuery();

                SqlCommand command7 = new SqlCommand("UPDATE Recruitment SET Resume = @res WHERE LastName = @lname AND FirstName = @fname AND MiddleName = @mname");
                command7.Connection = connection;
                command7.Parameters.Add("@res", SqlDbType.VarChar, 50).Value = user.resume;
                command7.Parameters.Add("@lname", SqlDbType.VarChar, 50).Value = user.LastName;
                command7.Parameters.Add("@fname", SqlDbType.VarChar, 50).Value = user.FirstName;
                command7.Parameters.Add("@mname", SqlDbType.VarChar, 50).Value = user.MiddleName;
                command7.ExecuteNonQuery();

                SqlCommand command8 = new SqlCommand("UPDATE Recruitment SET BirthCertificate = @bc WHERE LastName = @lname AND FirstName = @fname AND MiddleName = @mname");
                command8.Connection = connection;
                command8.Parameters.Add("@bc", SqlDbType.VarChar, 50).Value = user.PSA;
                command8.Parameters.Add("@lname", SqlDbType.VarChar, 50).Value = user.LastName;
                command8.Parameters.Add("@fname", SqlDbType.VarChar, 50).Value = user.FirstName;
                command8.Parameters.Add("@mname", SqlDbType.VarChar, 50).Value = user.MiddleName;
                command8.ExecuteNonQuery();

                SqlCommand command9 = new SqlCommand("UPDATE Recruitment SET SSS = @sss WHERE LastName = @lname AND FirstName = @fname AND MiddleName = @mname");
                command9.Connection = connection;
                command9.Parameters.Add("@sss", SqlDbType.VarChar, 50).Value = user.SSS;
                command9.Parameters.Add("@lname", SqlDbType.VarChar, 50).Value = user.LastName;
                command9.Parameters.Add("@fname", SqlDbType.VarChar, 50).Value = user.FirstName;
                command9.Parameters.Add("@mname", SqlDbType.VarChar, 50).Value = user.MiddleName;
                command9.ExecuteNonQuery();

                SqlCommand command10 = new SqlCommand("UPDATE Recruitment SET NBI = @nbi WHERE LastName = @lname AND FirstName = @fname AND MiddleName = @mname");
                command10.Connection = connection;
                command10.Parameters.Add("@nbi", SqlDbType.VarChar, 50).Value = user.NBI;
                command10.Parameters.Add("@lname", SqlDbType.VarChar, 50).Value = user.LastName;
                command10.Parameters.Add("@fname", SqlDbType.VarChar, 50).Value = user.FirstName;
                command10.Parameters.Add("@mname", SqlDbType.VarChar, 50).Value = user.MiddleName;
                command10.ExecuteNonQuery();

                SqlCommand command11 = new SqlCommand("UPDATE Recruitment SET Police = @pol WHERE LastName = @lname AND FirstName = @fname AND MiddleName = @mname");
                command11.Connection = connection;
                command11.Parameters.Add("@pol", SqlDbType.VarChar, 50).Value = user.Police;
                command11.Parameters.Add("@lname", SqlDbType.VarChar, 50).Value = user.LastName;
                command11.Parameters.Add("@fname", SqlDbType.VarChar, 50).Value = user.FirstName;
                command11.Parameters.Add("@mname", SqlDbType.VarChar, 50).Value = user.MiddleName;
                command11.ExecuteNonQuery();

                SqlCommand command12 = new SqlCommand("UPDATE Recruitment SET PhilHealth = @ph WHERE LastName = @lname AND FirstName = @fname AND MiddleName = @mname");
                command12.Connection = connection;
                command12.Parameters.Add("@ph", SqlDbType.VarChar, 50).Value = user.philhealth;
                command12.Parameters.Add("@lname", SqlDbType.VarChar, 50).Value = user.LastName;
                command12.Parameters.Add("@fname", SqlDbType.VarChar, 50).Value = user.FirstName;
                command12.Parameters.Add("@mname", SqlDbType.VarChar, 50).Value = user.MiddleName;
                command12.ExecuteNonQuery();

                SqlCommand command13 = new SqlCommand("UPDATE Recruitment SET PagIBIG = @pi WHERE LastName = @lname AND FirstName = @fname AND MiddleName = @mname");
                command13.Connection = connection;
                command13.Parameters.Add("@pi", SqlDbType.VarChar, 50).Value = user.PagIbig;
                command13.Parameters.Add("@lname", SqlDbType.VarChar, 50).Value = user.LastName;
                command13.Parameters.Add("@fname", SqlDbType.VarChar, 50).Value = user.FirstName;
                command13.Parameters.Add("@mname", SqlDbType.VarChar, 50).Value = user.MiddleName;
                command13.ExecuteNonQuery();

                SqlCommand command14 = new SqlCommand("UPDATE Recruitment SET BIR = @bir WHERE LastName = @lname AND FirstName = @fname AND MiddleName = @mname");
                command14.Connection = connection;
                command14.Parameters.Add("@bir", SqlDbType.VarChar, 50).Value = user.BIR;
                command14.Parameters.Add("@lname", SqlDbType.VarChar, 50).Value = user.LastName;
                command14.Parameters.Add("@fname", SqlDbType.VarChar, 50).Value = user.FirstName;
                command14.Parameters.Add("@mname", SqlDbType.VarChar, 50).Value = user.MiddleName;
                command14.ExecuteNonQuery();

                SqlCommand command15 = new SqlCommand("UPDATE Recruitment SET TOR = @tor WHERE LastName = @lname AND FirstName = @fname AND MiddleName = @mname");
                command15.Connection = connection;
                command15.Parameters.Add("@tor", SqlDbType.VarChar, 50).Value = user.TOR;
                command15.Parameters.Add("@lname", SqlDbType.VarChar, 50).Value = user.LastName;
                command15.Parameters.Add("@fname", SqlDbType.VarChar, 50).Value = user.FirstName;
                command15.Parameters.Add("@mname", SqlDbType.VarChar, 50).Value = user.MiddleName;
                command15.ExecuteNonQuery();

                SqlCommand command16 = new SqlCommand("UPDATE Recruitment SET CertificateofEmployment = @coe WHERE LastName = @lname AND FirstName = @fname AND MiddleName = @mname");
                command16.Connection = connection;
                command16.Parameters.Add("@coe", SqlDbType.VarChar, 50).Value = user.EmpCert;
                command16.Parameters.Add("@lname", SqlDbType.VarChar, 50).Value = user.LastName;
                command16.Parameters.Add("@fname", SqlDbType.VarChar, 50).Value = user.FirstName;
                command16.Parameters.Add("@mname", SqlDbType.VarChar, 50).Value = user.MiddleName;
                command16.ExecuteNonQuery();

                SqlCommand command17 = new SqlCommand("UPDATE Recruitment SET MedicalExam = @med WHERE LastName = @lname AND FirstName = @fname AND MiddleName = @mname");
                command17.Connection = connection;
                command17.Parameters.Add("@med", SqlDbType.VarChar, 50).Value = user.MedExam;
                command17.Parameters.Add("@lname", SqlDbType.VarChar, 50).Value = user.LastName;
                command17.Parameters.Add("@fname", SqlDbType.VarChar, 50).Value = user.FirstName;
                command17.Parameters.Add("@mname", SqlDbType.VarChar, 50).Value = user.MiddleName;
                command17.ExecuteNonQuery();

                SqlCommand command18 = new SqlCommand("UPDATE Recruitment SET OverallStatus = @os WHERE LastName = @lname AND FirstName = @fname AND MiddleName = @mname");
                command18.Connection = connection;
                command18.Parameters.Add("@os", SqlDbType.VarChar, 50).Value = user.OverallStatus;
                command18.Parameters.Add("@lname", SqlDbType.VarChar, 50).Value = user.LastName;
                command18.Parameters.Add("@fname", SqlDbType.VarChar, 50).Value = user.FirstName;
                command18.Parameters.Add("@mname", SqlDbType.VarChar, 50).Value = user.MiddleName;
                command18.ExecuteNonQuery();

                connection.Close();
            }
        }
        public IEnumerable<RecruitModel> Search(int[] criterias, string[] queries)
        {
            var irList = new List<RecruitModel>();
            string sqlcommand = "Select * From Recruitment Where ";
            var connection = new SqlConnection(conString);
            connection.Open();
            if (criterias[0] == 1)
            {
                sqlcommand = sqlcommand + "LastName = @lName";
                if (criterias[1] == 1 || criterias[2] == 1 || criterias[3] == 1)
                {
                    sqlcommand = sqlcommand + " And ";
                }
            }
            if (criterias[1] == 1)
            {
                sqlcommand = sqlcommand + "FirstName = @fName";
                if (criterias[2] == 1 || criterias[3] == 1)
                {
                    sqlcommand = sqlcommand + " And ";
                }
            }
            if (criterias[2] == 1)
            {
                sqlcommand = sqlcommand + "Department = @dept";
                if (criterias[3] == 1)
                {
                    sqlcommand = sqlcommand + " And ";
                };
            }
            if (criterias[3] == 1)
            {
                sqlcommand = sqlcommand + "Position = @pos";
            }

            SqlCommand command = new SqlCommand(sqlcommand);
            command.Connection = connection;
            if (criterias[0] == 1)
            {
                command.Parameters.AddWithValue("@lName", queries[0]);
            }
            if (criterias[1] == 1)
            {
                command.Parameters.AddWithValue("@fName", queries[1]);
            }
            if (criterias[2] == 1)
            {
                command.Parameters.AddWithValue("@dept", queries[2]);
            }
            if (criterias[3] == 1)
            {
                command.Parameters.AddWithValue("@pos", queries[3]);
            }

            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var sample = new RecruitModel();
                    sample.ApplicationID = reader.GetInt32(0);
                    sample.LastName = reader.GetString(1);
                    sample.FirstName = reader.GetString(2);
                    sample.MiddleName = reader.GetString(3);
                    sample.Department = reader.GetString(4);
                    sample.Position = reader.GetString(5);
                    sample.ApplicationDate = reader.GetDateTime(6);
                    sample.Interview1 = reader.GetString(7);
                    sample.Interview2 = reader.GetString(8);
                    sample.Interview3 = reader.GetString(9);
                    sample.Training = reader.GetString(10);
                    sample.resume = reader.GetString(11);
                    sample.PSA = reader.GetString(12);
                    sample.SSS = reader.GetString(13);
                    sample.NBI = reader.GetString(14);
                    sample.Police = reader.GetString(15);
                    sample.philhealth = reader.GetString(16);
                    sample.PagIbig = reader.GetString(17);
                    sample.BIR = reader.GetString(18);
                    sample.TOR = reader.GetString(19);
                    sample.EmpCert = reader.GetString(20);
                    sample.MedExam = reader.GetString(21);
                    sample.OverallStatus = reader.GetString(22);
                    irList.Add(sample);
                }
            }
            connection.Close();
            return irList;
        }
        public IEnumerable<RecruitModel> GetAll()
        {
            var irList = new List<RecruitModel>();
            using (var connection = new SqlConnection(conString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select * FROM Recruitment";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var sample = new RecruitModel();
                        sample.ApplicationID = reader.GetInt32(0);
                        sample.LastName = reader.GetString(1);
                        sample.FirstName = reader.GetString(2);
                        sample.MiddleName = reader.GetString(3);
                        sample.Department = reader.GetString(4);
                        sample.Position = reader.GetString(5);
                        sample.ApplicationDate = reader.GetDateTime(6);
                        sample.Interview1 = reader.GetString(7);
                        sample.Interview2 = reader.GetString(8);
                        sample.Interview3 = reader.GetString(9);
                        sample.Training = reader.GetString(10);
                        sample.resume = reader.GetString(11);
                        sample.PSA = reader.GetString(12);
                        sample.SSS = reader.GetString(13);
                        sample.NBI = reader.GetString(14);
                        sample.Police = reader.GetString(15);
                        sample.philhealth = reader.GetString(16);
                        sample.PagIbig = reader.GetString(17);
                        sample.BIR = reader.GetString(18);
                        sample.TOR = reader.GetString(19);
                        sample.EmpCert = reader.GetString(20);
                        sample.MedExam = reader.GetString(21);
                        sample.OverallStatus = reader.GetString(22);
                        irList.Add(sample);
                    }
                }
            }
            return irList;
        }
    }
}
