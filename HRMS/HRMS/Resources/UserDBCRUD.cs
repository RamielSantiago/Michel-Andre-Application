using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRMS.Model;
using HRMS.Tools;
using System.Windows.Forms;

namespace HRMS.Resources
{
    public class UserDBCRUD : BaseRepository, IUser
    {
        public UserDBCRUD(string connectionString)
        {
            this.conString = connectionString;
        }

        public IEnumerable<UserModel> GetAll()
        {
            var userList = new List<UserModel>();
            using (var connection = new SqlConnection(conString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select * from Employees";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var sample = new UserModel();
                        sample.EmployeeID = reader.GetInt32(0);
                        sample.FirstName = reader.GetString(1);
                        sample.MiddleName = reader.GetString(2);
                        sample.LastName = reader.GetString(3);
                        sample.UserName = reader.GetString(4);
                        sample.Email = reader.GetString(5);
                        sample.Password = reader.GetString(6);
                        sample.AccessRights = reader.GetInt32(7);
                        userList.Add(sample);
                    }
                }
            }
            return userList;
        }

        public void Add(UserModel user)
        {
            var connection = new SqlConnection(conString);
            connection.Open();
            SqlCommand command = new SqlCommand("INSERT INTO Employees([EmployeeID], [First_Name], [Middle_Name], [Last_Name], [Username], [Email], [Password], [Access_Level]) VALUES(@EmployeeID, @First_Name, @Middle_Name, @Last_Name, @Username, @Email, @Password, @Access_Level)");
            command.Connection = connection;
            command.Parameters.Add("@EmployeeID", SqlDbType.Int).Value = user.EmployeeID;
            command.Parameters.Add("@First_Name", SqlDbType.VarChar).Value = user.FirstName;
            command.Parameters.Add("@Middle_Name", SqlDbType.VarChar).Value = user.MiddleName;
            command.Parameters.Add("@Last_Name", SqlDbType.VarChar).Value = user.LastName;
            command.Parameters.Add("@Email", SqlDbType.VarChar).Value = user.Email;
            command.Parameters.Add("@Username", SqlDbType.VarChar).Value = user.UserName;
            command.Parameters.Add("@Password", SqlDbType.VarChar).Value = Encrypt.HashString(user.Password);
            command.Parameters.Add("@Access_Level", SqlDbType.Int).Value = user.AccessRights;
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void Update(UserModel user)
        {

        }
        public void Delete(int eID)
        {

        }

        public int SearchLogin(string Username, string Password)
        {
            var connection = new SqlConnection(conString);
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT EXISTS (SELECT * FROM Employees WHERE username = @Username AND password = @Password");
            command.Connection = connection;
            command.Parameters.AddWithValue("@Username", Username);
            command.Parameters.AddWithValue("@Password", Encrypt.HashString(Password));
            int hits = command.ExecuteNonQuery();
            connection.Close();

            return hits;
        }
    }
}
