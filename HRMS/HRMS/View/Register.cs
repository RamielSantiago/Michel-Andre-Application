using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Net.Mail;
using System.Windows.Forms;

namespace HRMS.View
{
    public partial class HRMSRegister : Form, IRegister
    {
        private Log_RegAdapter lRA;
        public HRMSRegister()
        {
            InitializeComponent(); 
        }
        public int EmployeeID { get { return Convert.ToInt32(eID.Text); } set { eID.Text = value.ToString(); } }// ->
        public int AccessRights { get { return Convert.ToInt32(ALINPUT.Text); } set { ALINPUT.Text = value.ToString(); } }// *
        public string FirstName { get { return fName.Text; } set { fName.Text = value; } }// *
        public string LastName { get { return lName.Text; } set { lName.Text = value; } }// *
        public string MiddleName { get { return mName.Text; } set { mName.Text = value; } }// * Interface Variables
        public string Email { get { return email.Text; } set { email.Text = value; } }// *
        public string Password { get { return regpass.Text; } set { regpass.Text = value; } } // *
        public string UserName { get { return username.Text; } set { username.Text = value; } }// * 
        public string SearchValue { get; set; }//TBD on Removal ->

        private void HRMSRegister_Load(object sender, EventArgs e)
        {
            regErrorMsg.ReadOnly = true;
            lRA = new Log_RegAdapter(this);//Initializes Presenter and CRUD Operations
        }//On Form Load

        private void RegisterLabel_Click(object sender, EventArgs e)
        {

        }//Register Title label (Cosmetic)

        private void addUserButton_Click(object sender, EventArgs e)
        {
            var passwordRegex = new Regex("^(?=.{8,20})(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%^&+=!_]).*$"); //Min. 1 Special Char., 1 Uppercase, 1 Lowercase, 1 Number, & min. 8 Chars, Max 20

            bool isValidPassword = passwordRegex.IsMatch(Password);

            bool valid = true;

            regErrorMsg.Text = "";//Resets Error Message

            if(string.IsNullOrWhiteSpace(fName.Text) || string.IsNullOrWhiteSpace(mName.Text) || string.IsNullOrWhiteSpace(lName.Text) || string.IsNullOrWhiteSpace(eID.Text) || 
                string.IsNullOrWhiteSpace(username.Text) || string.IsNullOrWhiteSpace(email.Text) ||string.IsNullOrWhiteSpace(regpass.Text) || string.IsNullOrWhiteSpace(regconpass.Text) ||
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
            if(valid == true)//Add Employee if true
            {
                lRA.RP.AddUser();
            }
        } //Submit Button w/ Email, Employee ID, and Password Validation

        private void Back_Click(object sender, EventArgs e)//Back Button; returns to login page
        {
            this.Hide();
            HRMSLogin login = new HRMSLogin();
            login.Show();
        }

        private void fName_TextChanged(object sender, EventArgs e)
        {

        }//Unnecessary

        private void last_name_Click(object sender, EventArgs e)
        {

        }//Unnecessary

        private void lName_TextChanged(object sender, EventArgs e)
        {

        }//Unnecessary

        private void middle_name_Click(object sender, EventArgs e)
        {

        }//Unnecessary

        private void mName_TextChanged(object sender, EventArgs e)
        {

        }//Unnecessary

        private void first_name_Click(object sender, EventArgs e)
        {

        }//Unnecessary

        private void label2_Click(object sender, EventArgs e)
        {

        }//(Cosmetic Only)

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }//(Cosmetic Only)
    }
}
