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
using System.Security.Cryptography;
using System.Runtime.Remoting.Contexts;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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
            var connection = new SqlConnection(conString);
            connection.Open();

            SqlCommand command = new SqlCommand("DELETE * FROM Employees WHERE EmployeeID = @EmployeeID");
            command.Connection = connection;
            command.Parameters.AddWithValue("@EmployeeID", eID);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public IEnumerable<UserModel> SearchUsersByValue(string criteria)
        {
            IEnumerable<UserModel> replist = new List<UserModel>();

            return replist;
        }
        public int SearchLogin(string Username, string Password)
        {
            UserModel sample = new UserModel();

            var connection = new SqlConnection(conString);
            connection.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM Employees WHERE username = @Username");
            command.Connection = connection;
            command.Parameters.AddWithValue("@Username", Username);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                sample.EmployeeID = reader.GetInt32(0);
                sample.UserName = reader.GetString(4);
                sample.Password = reader.GetString(6);
                sample.AccessRights = reader.GetInt32(7);
            }

            reader.Close();
            connection.Close();

            string savedPasswordHash = sample.Password;
            /* Extract the bytes */
            byte[] hashBytes = Convert.FromBase64String(savedPasswordHash);
            /* Get the salt */
            byte[] salt = new byte[16];
            Array.Copy(hashBytes, 0, salt, 0, 16);
            /* Compute the hash on the password the user entered */
            var pbkdf2 = new Rfc2898DeriveBytes(Password, salt, 100000);
            byte[] hash = pbkdf2.GetBytes(20);
            /* Compare the results */
            for (int i = 0; i < 20; i++)
            {
                if (hashBytes[i + 16] != hash[i])
                {
                    sample.AccessRights = 0;
                }
            }
            //MessageBox.Show(sample.Password + Environment.NewLine + Encrypt.HashString(Password));
            if (sample.AccessRights > 1 && !string.IsNullOrEmpty(sample.UserName))
            {
                return sample.AccessRights;
            }
            else
            {
                return 0;
            }

        }
    }
}
