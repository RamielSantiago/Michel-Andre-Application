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
using System.Collections;

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
            var connection = new SqlConnection(conString);
            connection.Open();
                if (!user.UserName.Equals("-1"))
                {
                    SqlCommand command = new SqlCommand("UPDATE Employees SET Username = @Username WHERE EmployeeID = @eID");
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@eID", user.EmployeeID);
                    command.Parameters.AddWithValue("@Username", user.UserName);
                    command.ExecuteNonQuery();
                }
                if (!user.FirstName.Equals("-1"))
                {
                    SqlCommand command = new SqlCommand("UPDATE Employees SET First_Name = @Firstname WHERE EmployeeID = @eID");
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@eID", user.EmployeeID);
                    command.Parameters.AddWithValue("@Firstname", user.FirstName);
                    command.ExecuteNonQuery();
                }
                if (!user.MiddleName.Equals("-1"))
                {
                    SqlCommand command = new SqlCommand("UPDATE Employees SET  Middle_Name = @Middlename WHERE EmployeeID = @eID");
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@eID", user.EmployeeID);
                    command.Parameters.AddWithValue("@Middlename", user.MiddleName);
                    command.ExecuteNonQuery();
                }
                if (!user.LastName.Equals("-1"))
                {
                    SqlCommand command = new SqlCommand("UPDATE Employees SET Last_Name = @Lastname WHERE EmployeeID = @eID");
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@eID", user.EmployeeID);
                    command.Parameters.AddWithValue("@Lastname", user.LastName);
                    command.ExecuteNonQuery();
                }
                if (!user.Email.Equals("-1"))
                {
                    SqlCommand command = new SqlCommand("UPDATE Employees SET Email = @Email WHERE EmployeeID = @eID");
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@eID", user.EmployeeID);
                    command.Parameters.AddWithValue("@Email", user.Email);
                    command.ExecuteNonQuery();
                }
                if (user.AccessRights > 0)
                {
                    SqlCommand command = new SqlCommand("UPDATE Employees SET Access_Level = @Access WHERE EmployeeID = @eID");
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@eID", user.EmployeeID);
                    command.Parameters.AddWithValue("@Access", user.AccessRights);
                    command.ExecuteNonQuery();
                }
                if (!user.Password.Equals("-1"))
                {
                    SqlCommand command = new SqlCommand("UPDATE Employees SET Password = @Password WHERE EmployeeID = @eID");
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@eID", user.EmployeeID);
                    command.Parameters.AddWithValue("@Password", Encrypt.HashString(user.Password));
                    command.ExecuteNonQuery();
                }
            connection.Close();
        }
        public int Delete(string criteria, string query)
        {
            int affected = 0;
            var connection = new SqlConnection(conString);
            connection.Open();
            if (criteria.Equals("Employee ID"))
            {
                SqlCommand command = new SqlCommand("DELETE FROM Employees WHERE EmployeeID = @eID");
                command.Connection = connection;
                command.Parameters.AddWithValue("@eID", Convert.ToInt32(query));
                affected =  command.ExecuteNonQuery();
            } else if (criteria.Equals("Username"))
            {
                SqlCommand command = new SqlCommand("DELETE FROM Employees WHERE Username = @username");
                command.Connection = connection;
                command.Parameters.AddWithValue("@username", query);
                affected =  command.ExecuteNonQuery();
            }
            connection.Close();
            return affected;
        }

        public IEnumerable<UserModel> SearchUsersByValue(string criteria, string query)
        {
            var  userlist = new List<UserModel>();
            var connection = new SqlConnection(conString);
            connection.Open();
            SqlCommand[] searchTypes =
            {
                new SqlCommand("SELECT * FROM Employees WHERE EmployeeID = @eID"),
                new SqlCommand("SELECT * FROM Employees WHERE First_Name = @fName"),
                new SqlCommand("SELECT * FROM Employees WHERE Last_Name = @lName"),
                new SqlCommand("SELECT * FROM Employees WHERE Username = @uName"),
                new SqlCommand("SELECT * FROM Employees WHERE Email = @email"),
                new SqlCommand("SELECT * FROM Employees")
            };
            SqlCommand command = new SqlCommand();
            switch (criteria)
            {
                case "Employee ID": command = searchTypes[0];
                    break;
                case "First Name": command = searchTypes[1];
                    break;
                case "Last Name": command = searchTypes[2];
                    break;
                case "Username": command = searchTypes[3];
                     break;
                case "Email": command = searchTypes[4];
                     break;
                default: command = searchTypes[5];
                    break;
            }
            command.Connection = connection;
            switch (criteria)
            {
                case "Employee ID":
                    command.Parameters.AddWithValue("@eID", Convert.ToInt32(query));
                    break;
                case "First Name":
                    command.Parameters.AddWithValue("@fName", query);
                    break;
                case "Last Name":
                    command.Parameters.AddWithValue("@lName", query);
                    break;
                case "Username":
                    command.Parameters.AddWithValue("@uName", query);
                    break;
                case "Email":command.Parameters.AddWithValue("@email", query);
                    break;
            }
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
                    userlist.Add(sample);
                }
            }
            return userlist;
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
