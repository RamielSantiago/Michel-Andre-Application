using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRMS.Model;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Runtime.Remoting.Contexts;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Collections;
using HRMS.Model.DBInterfaces;
using HRMS.Model.DBModels;
using HRMS.Tools;

namespace HRMS.Resources
{
    public class UserDBCRUD : BaseRepository, iUser
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
                command.CommandText = "Select * from EmployeeList";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var sample = new UserModel();
                        sample.EmployeeID = reader.GetInt32(0);
                        sample.FirstName = reader.GetString(1);
                        sample.MiddleName = reader.GetString(2);
                        sample.LastName = reader.GetString(3);
                        sample.Department = reader.GetString(4);
                        sample.Position = reader.GetString(5);
                        sample.DateHired = reader.GetDateTime(6);
                        sample.UserName = reader.GetString(7);
                        sample.Password = reader.GetString(8);
                        sample.Email = reader.GetString(9);
                        userList.Add(sample);
                    }
                }
            }
            if(userList.Count() >= 2)
            {
                userList.RemoveAt(0);
            }
            return userList;
        }
        public IEnumerable<UserModel> SearchUsersByValue(string criteria, string query)
        {
            var userlist = new List<UserModel>();
            var connection = new SqlConnection(conString);
            connection.Open();
            SqlCommand[] searchTypes =
            {
                new SqlCommand("SELECT * FROM EmployeeList WHERE EmployeeID = @eID"),
                new SqlCommand("SELECT * FROM EmployeeList WHERE FirstName = @fName"),
                new SqlCommand("SELECT * FROM EmployeeList WHERE LastName = @lName"),
                new SqlCommand("SELECT * FROM EmployeeList WHERE Username = @uName"),
                new SqlCommand("SELECT * FROM EmployeeList WHERE Department = @dept"),
                new SqlCommand("SELECT * FROM EmployeeList WHERE Position = @pos"),
                new SqlCommand("SELECT * FROM EmployeeList WHERE Email = @email"),
                new SqlCommand("SELECT * FROM EmployeeList")
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
                case "Department": command = searchTypes[4];
                    break;
                case "Position": command = searchTypes[5];
                    break;
                case "Email":  command = searchTypes[6];
                    break;
                default: command = searchTypes[7];
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
                case "Department":
                    command.Parameters.AddWithValue("@dept", query);
                    break;
                case "Position":
                    command.Parameters.AddWithValue("@pos", query);
                    break;
                case "Email":
                    command.Parameters.AddWithValue("@email", query);
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
                    sample.Department = reader.GetString(4);
                    sample.Position = reader.GetString(5);
                    sample.DateHired = reader.GetDateTime(6);
                    sample.UserName = reader.GetString(7);
                    sample.Password = reader.GetString(8);
                    sample.Email = reader.GetString(9);
                    userlist.Add(sample);
                }
            }
            return userlist;
        }
        public void Add(UserModel user)
        {
            var connection = new SqlConnection(conString);
            connection.Open();
            SqlCommand command = new SqlCommand("INSERT INTO EmployeeList([EmployeeID], [FirstName], [MiddleName], [LastName], [Department], [Position], [DateHired], [Username], [Password], [Email])" +
                "VALUES(@EID, @FName, @MName, @LName, @Department, @Position, @DateHired, @Username, @Password, @Email)");
            command.Connection = connection;
            command.Parameters.AddWithValue("@EID", user.EmployeeID);
            command.Parameters.AddWithValue("@FName", user.FirstName);
            command.Parameters.AddWithValue("@MName", user.MiddleName);
            command.Parameters.AddWithValue("@LName", user.LastName);
            command.Parameters.AddWithValue("@Department", user.Department);
            command.Parameters.AddWithValue("@Position", user.Position);
            command.Parameters.AddWithValue("DateHired", user.DateHired);
            command.Parameters.AddWithValue("@Username", user.UserName);
            command.Parameters.AddWithValue("@Password", Encrypt.HashString(user.Password));
            command.Parameters.AddWithValue("@Email", user.Email);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void Update(UserModel user)
        {
            var connection = new SqlConnection(conString);
            connection.Open();
                if (!user.FirstName.Equals("-1"))
                {
                    SqlCommand command = new SqlCommand("UPDATE EmployeeList SET FirstName = @Firstname WHERE EmployeeID = @eID");
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@eID", user.EmployeeID);
                    command.Parameters.AddWithValue("@Firstname", user.FirstName);
                    command.ExecuteNonQuery();
                }
                if (!user.MiddleName.Equals("-1"))
                {
                    SqlCommand command = new SqlCommand("UPDATE EmployeeList SET  MiddleName = @Middlename WHERE EmployeeID = @eID");
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@eID", user.EmployeeID);
                    command.Parameters.AddWithValue("@Middlename", user.MiddleName);
                    command.ExecuteNonQuery();
                }
                if (!user.LastName.Equals("-1"))
                {
                    SqlCommand command = new SqlCommand("UPDATE EmployeeList SET LastName = @Lastname WHERE EmployeeID = @eID");
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@eID", user.EmployeeID);
                    command.Parameters.AddWithValue("@Lastname", user.LastName);
                    command.ExecuteNonQuery();
                }
                if (!user.Department.Equals("-1") && !user.Position.Equals("-1"))
                {
                    SqlCommand command = new SqlCommand("UPDATE EmployeeList SET Department = @dept WHERE EmployeeID = @eID");
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@eID", user.EmployeeID);
                    command.Parameters.AddWithValue("@dept", user.Department);
                    command.ExecuteNonQuery();

                    SqlCommand command2 = new SqlCommand("UPDATE EmployeeList SET Position = @pos WHERE EmployeeID = @eID");
                    command2.Connection = connection;
                    command2.Parameters.AddWithValue("@eID", user.EmployeeID);
                    command2.Parameters.AddWithValue("@pos", user.Position);
                    command2.ExecuteNonQuery();
            }
                if (!user.UserName.Equals("-1"))
                {
                    SqlCommand command = new SqlCommand("UPDATE EmployeeList SET Username = @username WHERE EmployeeID = @eID");
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@eID", user.EmployeeID);
                    command.Parameters.AddWithValue("@username", user.UserName);
                    command.ExecuteNonQuery();
                }
                if (!user.Email.Equals("-1"))
                {
                    SqlCommand command = new SqlCommand("UPDATE EmployeeList SET Email = @email WHERE EmployeeID = @eID");
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@eID", user.EmployeeID);
                    command.Parameters.AddWithValue("@email", user.Email);
                    command.ExecuteNonQuery();
                }
                if (!user.Password.Equals("-1"))
                {
                    SqlCommand command = new SqlCommand("UPDATE EmployeeList SET Password = @pass WHERE EmployeeID = @eID");
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@eID", user.EmployeeID);
                    command.Parameters.AddWithValue("@pass", Encrypt.HashString(user.Password));
                    command.ExecuteNonQuery();
                }
                if (!user.Password.Equals("-1"))
                {
                    SqlCommand command = new SqlCommand("UPDATE EmployeeList SET Password = @pass WHERE EmployeeID = @eID");
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@iID", user.EmployeeID);
                    command.Parameters.AddWithValue("@pass", Encrypt.HashString(user.Password));
                    command.ExecuteNonQuery();
                }
            if (!(user.DateHired == DateTime.MaxValue))
                {
                    SqlCommand command = new SqlCommand("UPDATE EmployeeList SET DateHired = @date WHERE EmployeeID = @eID");
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@eID", user.EmployeeID);
                    command.Parameters.AddWithValue("@date", user.DateHired);
                    command.ExecuteNonQuery();
                }
            connection.Close();
        }
        public int SearchLogin(string Username, string Password)
        {
            UserModel sample = new UserModel();

            var connection = new SqlConnection(conString);
            connection.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM EmployeeList WHERE username = @Username");
            command.Connection = connection;
            command.Parameters.AddWithValue("@Username", Username);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                sample.EmployeeID = reader.GetInt32(0);
                sample.UserName = reader.GetString(7);
                sample.Password = reader.GetString(8);
            }

            reader.Close();
            connection.Close();
            string savedPasswordHash = sample.Password;
            try
            {
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
                        return 0;
                    }
                }
            }
            catch (ArgumentNullException)
            {
                return 0;
            }
            return 99;
        }
        public int checkifExists(UserModel user)
        {
            var userlist = new List<UserModel>();
            var connection = new SqlConnection(conString);
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM EmployeeList WHERE FirstName = @fName AND LastName = @lName AND MiddleName = @mName AND " +
                                                "Department = @dept AND Position = @pos");
            command.Connection = connection;
            command.Parameters.AddWithValue("@fName", user.FirstName);
            command.Parameters.AddWithValue("@lName", user.LastName);
            command.Parameters.AddWithValue("@mName", user.MiddleName);
            command.Parameters.AddWithValue("@dept", user.Department);
            command.Parameters.AddWithValue("@pos", user.Position);
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var sample = new UserModel();
                    sample.EmployeeID = reader.GetInt32(0);
                    sample.FirstName = reader.GetString(1);
                    sample.MiddleName = reader.GetString(2);
                    sample.LastName = reader.GetString(3);
                    sample.Department = reader.GetString(4);
                    sample.Position = reader.GetString(5);
                    sample.DateHired = reader.GetDateTime(6);
                    sample.UserName = reader.GetString(7);
                    sample.Password = reader.GetString(8);
                    sample.Email = reader.GetString(9);
                    userlist.Add(sample);
                }
            }
            connection.Close();
            if (userlist.Any())
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public IEnumerable<UserModel> SearchUserByName(string first, string last)
        {
            var userlist = new List<UserModel>();
            var connection = new SqlConnection(conString);
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM EmployeeList WHERE FirstName = @fName AND LastName = @lName");
            command.Connection = connection;
            command.Parameters.AddWithValue("@fName", first);
            command.Parameters.AddWithValue("@lName", last);
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var sample = new UserModel();
                    sample.EmployeeID = reader.GetInt32(0);
                    sample.FirstName = reader.GetString(1);
                    sample.MiddleName = reader.GetString(2);
                    sample.LastName = reader.GetString(3);
                    sample.Department = reader.GetString(4);
                    sample.Position = reader.GetString(5);
                    sample.DateHired = reader.GetDateTime(6);
                    sample.UserName = reader.GetString(7);
                    sample.Password = reader.GetString(8);
                    sample.Email = reader.GetString(9);
                    userlist.Add(sample);
                }
            }
            return userlist;
        }
    }
}
