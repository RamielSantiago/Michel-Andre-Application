using System;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace HRMS.View
{
    public partial class HRMSRegister : Form, IRegister
    {
        private Log_RegAdapter lRA;
        private Dashboard dash;
        public HRMSRegister(Dashboard dash)
        {
            InitializeComponent();
            this.dash= dash;
        }
        public int EmployeeID { get { return Convert.ToInt32(eID.Text); } set { eID.Text = value.ToString(); } }// ->
        public int AccessRights { get { return Convert.ToInt32(ALINPUT.Text); } set { ALINPUT.Text = value.ToString(); } }// *
        public string FirstName { get { return fName.Text; } set { fName.Text = value; } }// *
        public string LastName { get { return lName.Text; } set { lName.Text = value; } }// *
        public string MiddleName { get { return mName.Text; } set { mName.Text = value; } }// * Interface Variables
        public string Email { get { return email.Text; } set { email.Text = value; } }// *
        public string Password { get { return regpass.Text; } set { regpass.Text = value; } } // *
        public string UserName { get { return username.Text; } set { username.Text = value; } }// * 
        public string SearchValue { get; set;}// *
        public void setEmployeeBS(BindingSource bs)
        {
            //employeelist.DataSource = bs;
        }
        private void HRMSRegister_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hRMSDBDataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.hRMSDBDataSet.Employees);
            regErrorMsg.ReadOnly = true;
            lRA = new Log_RegAdapter(this);//Initializes Presenter and CRUD Operations
        }//On Form Load

        private void addUserButton_Click_1(object sender, EventArgs e)
        {
            var passwordRegex = new Regex("^(?=.{8,20})(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%^&+=!_]).*$"); //Min. 1 Special Char., 1 Uppercase, 1 Lowercase, 1 Number, & min. 8 Chars, Max 20

            bool isValidPassword = passwordRegex.IsMatch(Password);

            bool valid = true;

            regErrorMsg.Text = "";//Resets Error Message

            if (string.IsNullOrWhiteSpace(fName.Text) || string.IsNullOrWhiteSpace(mName.Text) || string.IsNullOrWhiteSpace(lName.Text) || string.IsNullOrWhiteSpace(eID.Text) ||
                string.IsNullOrWhiteSpace(username.Text) || string.IsNullOrWhiteSpace(email.Text) || string.IsNullOrWhiteSpace(regpass.Text) || string.IsNullOrWhiteSpace(regconpass.Text) ||
                string.IsNullOrWhiteSpace(ALINPUT.Text))
            {
                valid = false;
                regErrorMsg.Text = regErrorMsg.Text + "Please fill all fields" + Environment.NewLine;
            }//Check for empty fields
            else
            {
                try
                {
                    var temp = Convert.ToInt32(eID.Text);
                }
                catch (FormatException)
                {
                    valid = false;
                    regErrorMsg.Text = regErrorMsg.Text + "Employee ID must consist of numbers only" + Environment.NewLine;

                }
                try
                {
                    var temp = Convert.ToInt32(ALINPUT.Text);
                }
                catch (FormatException)
                {
                    valid = false;
                    regErrorMsg.Text = regErrorMsg.Text + "Access Level must consist of numbers only" + Environment.NewLine;

                }
                try
                {
                    MailAddress m = new MailAddress(email.Text);
                }
                catch (FormatException)
                {
                    valid = false;
                }
                if (regpass.Text.Equals(regconpass.Text) == false)
                {
                    valid = false;
                    regErrorMsg.Text = regErrorMsg.Text + "Passwords must match." + Environment.NewLine;
                }
                if (isValidPassword == false)
                {
                    valid = false;
                    regErrorMsg.Text = regErrorMsg.Text + "Password must contain 8-20 Characters and have at least (1) Uppercase Letter, (1) Lowercase Letter, (1) Numeric Character, and (1) Special Character." + Environment.NewLine;
                }
            }
            if (valid == true)//Add Employee if true
            {
                lRA.RP.AddUser();
                MessageBox.Show("User Registered Successfully", "Human Resource Management System", MessageBoxButtons.OK ,MessageBoxIcon.Information);
            }
            eID.Text = "";
            ALINPUT.Text = "";
            FirstName = "";
            MiddleName = "";
            LastName = "";
            UserName = "";
            Email = "";
            Password = "";
            regconpass.Text = "";

        } //Submit Button w/ Email, Employee ID, Access Level, and Password Validation
    }
}
