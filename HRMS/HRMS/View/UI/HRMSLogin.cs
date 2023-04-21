using HRMS.Tools;
using HRMS.View.Adapters;
using HRMS.View.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMS.View.UI
{
    public partial class HRMSLogin : Form, iLogin
    {
        private Log_RegAdapter LRA;
        private bool dbExist = false;
        public string UserName { get { return logname.Text; } set { logname.Text = value; } }
        public string Password { get { return logpass.Text; } set { logpass.Text = value; } }
        public HRMSLogin()
        {
            InitializeComponent();
            this.LRA = new Log_RegAdapter(this);
        }
        private void HRMSLogin_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            //checkIfDBExist();
            //if (!dbExist)
            //{
            //    CreateDB();
            //}
        }
        //private void CreateDB()
        //{
        //    bool success = false;
        //        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DBCreation"].ConnectionString);
        //        if (conn.State != ConnectionState.Open)
        //        {
        //            conn.Open();
        //        }

        //        //Create Database .mdf and.ldf Files
        //        string dbPath1 = Application.StartupPath + "\\Resources\\Database\\HRMSDB.mdf";
        //        string dbPath2 = Application.StartupPath + "\\Resources\\Database\\HRMSDB.ldf";
        //        string createCmd = "CREATE DATABASE HRMSDB ON PRIMARY"
        //        + "(Name=N'HRMSDB', filename = '" + dbPath1 + "',"
        //        + "SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB)log on"
        //        + "(name=N'HRMS_log',filename='" + dbPath2 + "',"
        //        + "SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB)";
        //        //-------------------------------------------------------------------//


        //        //Create Database
        //        SqlCommand newDB = new SqlCommand(createCmd, conn);
        //        try
        //        {
        //            int db = newDB.ExecuteNonQuery();
        //            success = true;
        //        }
        //        catch (Exception e)
        //        {
        //        MessageBox.Show("Database could not be built (TryCatch)" + Environment.NewLine + e.Message, "Human Resource Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //        //-------------------------------------------------------------------//
        //    conn.Close();
        //    conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLConnectionString"].ConnectionString);
        //    conn.Open();
        //    //Create Table EmployeeList
        //    createCmd = "CREATE TABLE EmployeeList" +
        //    "(EmployeeID INTEGER NOT NULL," +
        //    "FirstName VARCHAR(50) NOT NULL, MiddleName VARCHAR(50) NOT NULL, LastName VARCHAR(50) NOT NULL," +
        //    "Department VARCHAR(50) NOT NULL, Position VARCHAR(50) NOT NULL, DateHired DateTime NOT NULL," +
        //    "Username VARCHAR(50) NOT NULL, Password VARCHAR(50) NOT NULL, Email VARCHAR(50) NOT NULL, PRIMARY KEY(EmployeeID))";
        //    SqlCommand newTable = new SqlCommand(createCmd, conn);
        //    try
        //    {
        //        newTable.ExecuteNonQuery();
        //        createCmd = string.Format("INSERT INTO EmployeeList(EmployeeID, FirstName, MiddleName, LastName, Department, " +
        //            "Position, DateHired, Username, Password, Email) " +
        //            "VALUES (0, '--', '--', '--', 'Default', 'Account', @date, 'Admin', @pass, 'admin@gmail.com')");
        //        newTable = new SqlCommand(createCmd, conn);
        //        newTable.Parameters.Add("@date", SqlDbType.DateTime, 0).Value = new DateTime(2023, 01, 01);
        //        newTable.Parameters.Add("@pass", SqlDbType.VarChar, 0).Value = Encrypt.HashString("V1rtual!");

        //        newTable.ExecuteNonQuery();
        //    }
        //    catch (Exception e)
        //    {
        //    }
        //    //-------------------------------------------------------------------//

        //    //Create Table Incidents
        //    createCmd = "CREATE TABLE Incidents" +
        //    "(IncidentID INTEGER NOT NULL," +
        //    "LastName VARCHAR(50) NOT NULL, FirstName VARCHAR(50) NOT NULL, MiddleName VARCHAR(50) NOT NULL," +
        //    "Department VARCHAR(50) NOT NULL, Position VARCHAR(50) NOT NULL, DateSubmitted DateTime NOT NULL," +
        //    "PeopleInvolved VARCHAR(50) NOT NULL, Incident VARCHAR(50) NOT NULL, Remarks VARCHAR(50) NOT NULL, ApprovedBy VARCHAR(50) NOT NULL, PRIMARY KEY(IncidentID))";
        //    newTable = new SqlCommand(createCmd, conn);
        //    try
        //    {
        //        newTable.ExecuteNonQuery();
        //        createCmd = string.Format("INSERT INTO Incidents(IncidentID, LastName, FirstName, MiddleName, Department, " +
        //            "Position, DateSubmitted, PeopleInvolved, Incident, Remarks, ApprovedBy) " +
        //            "VALUES (0, '--', '--', '--', 'Default', 'Report', @date, 'Someone', 'Something Happened', 'Comment', 'Admin')");
        //        newTable = new SqlCommand(createCmd, conn);
        //        newTable.Parameters.Add("@date", SqlDbType.DateTime, 0).Value = new DateTime(2023, 01, 01);
        //        newTable.ExecuteNonQuery();
        //    }
        //    catch (Exception e)
        //    {
        //    }
        //    //-------------------------------------------------------------------//

        //    //Create Table Recruitment
        //    createCmd = "CREATE TABLE Recruitment" +
        //    "(RecruitID INTEGER NOT NULL," +
        //    "LastName VARCHAR(50) NOT NULL, FirstName VARCHAR(50) NOT NULL, MiddleName VARCHAR(50) NOT NULL," +
        //    "Department VARCHAR(50) NOT NULL, Position VARCHAR(50) NOT NULL, ApplicationDate DateTime NOT NULL," +
        //    "Interview1 VARCHAR(50) NOT NULL, Interview2 VARCHAR(50) NOT NULL, Interview3 VARCHAR(50) NOT NULL, Training VARCHAR(50) NOT NULL, " +
        //    "Resume VARCHAR(50) NOT NULL, BirthCertificate VARCHAR(50) NOT NULL, SSS VARCHAR(50) NOT NULL, NBI VARCHAR(50) NOT NULL," +
        //    "Police VARCHAR(50) NOT NULL, PhilHealth VARCHAR(50) NOT NULL, PagIBIG VARCHAR(50) NOT NULL, BIR VARCHAR(50) NOT NULL," +
        //    "TOR VARCHAR(50) NOT NULL, CertificateofEmployment VARCHAR(50) NOT NULL, MedicalExam VARCHAR(50) NOT NULL, OverallStatus VARCHAR(50) NOT NULL, PRIMARY KEY(RecruitID))";
        //    newTable = new SqlCommand(createCmd, conn);
        //    try
        //    {
        //        newTable.ExecuteNonQuery();
        //        createCmd = string.Format("INSERT INTO Recruitment(RecruitID, LastName, FirstName, MiddleName, Department, " +
        //            "Position, ApplicationDate, Interview1, Interview2, Interview3, Training, Resume, BirthCertificate, SSS, NBI, Police, PhilHealth, PagIBIG, BIR, TOR, CertificateofEmployment, MedicalExam, OverallStatus)" +
        //            "VALUES (0, '--', '--', '--', 'Default', 'Recruit', @date, 'Complete', 'Complete', 'Complete', 'Complete', 'Complete', 'Complete', 'Complete', 'Complete', 'Complete', 'Complete', 'Complete', 'Complete', " +
        //            "'Complete', 'Complete', 'Complete', 'Requirements Complete')", new DateTime(2023, 01, 01));
        //        newTable = new SqlCommand(createCmd, conn);
        //        newTable.Parameters.Add("@date", SqlDbType.DateTime, 0).Value = new DateTime(2023, 01, 01);
        //        newTable.ExecuteNonQuery();
        //    }
        //    catch (Exception e)
        //    {
        //    }
        //    //-------------------------------------------------------------------//

        //    //Create Table PerformanceAppraisal
        //    createCmd = "CREATE TABLE PerformanceAppraisal" +
        //    "(AppraisalID INTEGER NOT NULL," +
        //    "LastName VARCHAR(50) NOT NULL, FirstName VARCHAR(50) NOT NULL, MiddleName VARCHAR(50) NOT NULL," +
        //    "Department VARCHAR(50) NOT NULL, Position VARCHAR(50) NOT NULL, Date DateTime NOT NULL," +
        //    "Attendance INTEGER NOT NULL, Accuracy INTEGER NOT NULL, Housekeeping INTEGER NOT NULL, Efficiency INTEGER NOT NULL, " +
        //    "CourtesyandAttitude INTEGER NOT NULL, Alertness INTEGER NOT NULL, DependabilityReliabilityResourcefulness INTEGER NOT NULL, " +
        //    "CompliancewithCompanyRules INTEGER NOT NULL, Cooperation INTEGER NOT NULL, Judgement INTEGER NOT NULL, PersonalAppearance INTEGER NOT NULL, " +
        //    "Friendliness INTEGER NOT NULL, Total INTEGER NOT NULL, PRIMARY KEY(AppraisalID))";
        //    newTable = new SqlCommand(createCmd, conn);
        //    try
        //    {
        //        newTable.ExecuteNonQuery();
        //        createCmd = string.Format("INSERT INTO PerformanceAppraisal(AppraisalID, LastName, FirstName, MiddleName, Department, " +
        //            "Position, Date, Attendance, Accuracy, Housekeeping, Efficiency, CourtesyandAttitude, Alertness, DependabilityReliabilityResourcefulness, CompliancewithCompanyRules, Cooperation, Judgement, PersonalAppearance, Friendliness, Total) " +
        //            "VALUES (0, '--', '--', '--', 'Sample', 'Appraisal', @date, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 100)", new DateTime(2023, 01, 01));
        //        newTable = new SqlCommand(createCmd, conn);
        //        newTable.Parameters.Add("@date", SqlDbType.DateTime, 0).Value = new DateTime(2023, 01, 01);
        //        newTable.ExecuteNonQuery();
        //    }
        //    catch (Exception e)
        //    {
        //    }
        //    //-------------------------------------------------------------------//

        //    //Create Table InformationFeedback
        //    createCmd = "CREATE TABLE InformationFeedback" +
        //    "(FeedbackID INTEGER NOT NULL, PRIMARY KEY(FeedbackID))";
        //    newTable = new SqlCommand(createCmd, conn);
        //    try
        //    {
        //        newTable.ExecuteNonQuery();
        //        newTable = new SqlCommand("ALTER TABLE InformationFeedback ADD [To] VARCHAR(50) DEFAULT 0 NOT NULL");
        //        newTable.Connection = conn;
        //        newTable.ExecuteNonQuery();
        //        newTable = new SqlCommand("ALTER TABLE InformationFeedback ADD [From] VARCHAR(50) DEFAULT 0 NOT NULL");
        //        newTable.Connection = conn;
        //        newTable.ExecuteNonQuery();
        //        newTable = new SqlCommand("ALTER TABLE InformationFeedback ADD [Subject] VARCHAR(50) DEFAULT 0 NOT NULL");
        //        newTable.Connection = conn;
        //        newTable.ExecuteNonQuery();
        //        newTable = new SqlCommand("ALTER TABLE InformationFeedback ADD [Date] DATETIME DEFAULT 0 NOT NULL");
        //        newTable.Connection = conn;
        //        newTable.ExecuteNonQuery();
        //        newTable = new SqlCommand("ALTER TABLE InformationFeedback ADD [DetailsofIssue] VARCHAR(50) DEFAULT 0 NOT NULL");
        //        newTable.Connection = conn;
        //        newTable.ExecuteNonQuery();
        //        newTable = new SqlCommand("ALTER TABLE InformationFeedback ADD [RecommendedAction] VARCHAR(50) DEFAULT 0 NOT NULL");
        //        newTable.Connection = conn;
        //        newTable.ExecuteNonQuery();
        //        newTable = new SqlCommand("ALTER TABLE InformationFeedback ADD [Comments] VARCHAR(50) DEFAULT 0 NOT NULL");
        //        newTable.Connection = conn;
        //        newTable.ExecuteNonQuery();
        //        newTable = new SqlCommand("ALTER TABLE InformationFeedback ADD [ComplaintSig] VARCHAR(50) DEFAULT 0 NOT NULL");
        //        newTable.Connection = conn;
        //        newTable.ExecuteNonQuery();
        //        newTable = new SqlCommand("ALTER TABLE InformationFeedback ADD [SupervisorSig] VARCHAR(50) DEFAULT 0 NOT NULL");
        //        newTable.Connection = conn;
        //        newTable.ExecuteNonQuery();
        //        newTable = new SqlCommand("ALTER TABLE InformationFeedback ADD [HROfficerSig] VARCHAR(50) DEFAULT 0 NOT NULL");
        //        newTable.Connection = conn;
        //        newTable.ExecuteNonQuery();
        //        newTable = new SqlCommand("ALTER TABLE InformationFeedback ADD [PresidentSig] VARCHAR(50) DEFAULT 0 NOT NULL");
        //        newTable.Connection = conn;
        //        newTable.ExecuteNonQuery();
        //        createCmd = string.Format("INSERT INTO InformationFeedback([FeedbackID], [To], [From], [Subject], [Date], " +
        //            "[DetailsofIssue], [RecommendedAction], [Comments], [ComplaintSig], [SupervisorSig], [HROfficerSig], [PresidentSig]) " +
        //            "VALUES (0, '--', '--', 'Something', @date, 'Something', 'Something Happened', 'Leave as is', 'Complete', 'Complete', 'Complete', 'Complete')");
        //        newTable = new SqlCommand(createCmd, conn);
        //        newTable.Parameters.Add("@date", SqlDbType.DateTime, 0).Value = new DateTime(2023, 01, 01);
        //        newTable.ExecuteNonQuery();
        //    }
        //    catch (Exception e)
        //    {
        //    }
        //    conn.Close();
        //    MessageBox.Show("Database successfully built", "Human Resource Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //}

        private void checkIfDBExist()
        {
            string[] names;
            int counter = 0;
            try
            {
                SqlConnection tempConn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Integrated Security=True");
                tempConn.Open();
                DataTable databases = tempConn.GetSchema("Databases");
                names = new string[databases.Rows.Count];
                foreach (DataRow database in databases.Rows)
                {
                    String databaseName = database.Field<String>("database_name");
                    names[counter] = databaseName;
                    counter++;
                }
                for (int i = 0; i < names.Length; i++)
                {
                    if (names[i].Equals("HRMSDB"))
                    {
                        dbExist = true;
                    }
                    else
                    {
                        dbExist = false;
                    }
                }
                tempConn.Close();
            }
            catch (Exception e)
            {
                dbExist = false;
            }
        }
        private void logBtn_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UserName) || string.IsNullOrWhiteSpace(Password))
            {
                MessageBox.Show("Please fill all fields", "Human Resource Management System - Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                int verify = LRA.LP.SearchUser(UserName, Password);

                if (verify > 1)
                {
                    Dashboard dash = new Dashboard(UserName, this);// 1 Is a placeholder. Will try to see if I can retrieve access level and username\
                    this.Hide();
                    dash.Show();
                }
                else
                {
                    MessageBox.Show("Username or Password is Incorrect", "Human Resource Management System - Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            logname.Clear();
            logpass.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
