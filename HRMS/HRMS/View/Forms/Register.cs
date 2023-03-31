using HRMS.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;
using System.Net.Mail;
using System.Text.RegularExpressions;
using HRMS.View.Forms;

namespace HRMS
{
    public partial class HRMSRegister : UserControl, IRegister
    {
        private Log_RegAdapter lRA;
        public HRMSRegister()
        {
            InitializeComponent();
            lRA = new Log_RegAdapter(this);
            regErrorMsg.ReadOnly = true;
            queryErrorMsg.ReadOnly = true;
            filter.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public int EmployeeID { get { return Convert.ToInt32(eID.Text); } set { eID.Text = value.ToString(); } }// ->
        public int AccessRights { get { return Convert.ToInt32(ALINPUT.Text); } set { ALINPUT.Text = value.ToString(); } }// *
        public string FirstName { get { return fName.Text; } set { fName.Text = value; } }// *
        public string LastName { get { return lName.Text; } set { lName.Text = value; } }// *
        public string MiddleName { get { return mName.Text; } set { mName.Text = value; } }// * Interface Variables
        public string Email { get { return email.Text; } set { email.Text = value; } }// *
        public string Password { get { return regpass.Text; } set { regpass.Text = value; } } // *
        public string UserName { get { return username.Text; } set { username.Text = value; } }// * 
        public string SearchValue { get; set; }// *
        public void setEmployeeBS(BindingSource bs)
        {
            employeelist.DataSource = bs;
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            var passwordRegex = new Regex("^(?=.{8,20})(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%^&+=!_]).*$"); //Min. 1 Special Char., 1 Uppercase, 1 Lowercase, 1 Number, & min. 8 Chars, Max 20

            bool isValidPassword = passwordRegex.IsMatch(Password);

            bool valid = true;

            regErrorMsg.Text = "";//Resets Error Message

            if (string.IsNullOrWhiteSpace(fName.Text) || string.IsNullOrWhiteSpace(lName.Text) || string.IsNullOrWhiteSpace(eID.Text) ||
                string.IsNullOrWhiteSpace(username.Text) || string.IsNullOrWhiteSpace(email.Text) || string.IsNullOrWhiteSpace(regpass.Text) || string.IsNullOrWhiteSpace(regconpass.Text) ||
                string.IsNullOrWhiteSpace(ALINPUT.Text))
            {
                valid = false;
                regErrorMsg.Text = regErrorMsg.Text + "Please fill all required fields" + Environment.NewLine;
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
                    if (temp > 5 || temp < 1)
                    {
                        regErrorMsg.Text = regErrorMsg.Text + "Please choose from the options in the dropdown" + Environment.NewLine;
                        valid = false;
                    }
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
                    regErrorMsg.Text = regErrorMsg.Text + "Invalid Email." + Environment.NewLine;
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
                MessageBox.Show("User Registered Successfully", "Human Resource Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void query_Click(object sender, EventArgs e)
        {
            string specifics = querydetail.Text;
            bool valid = true;
            queryErrorMsg.Text = "";
            if(filter.SelectedIndex == -1|| string.IsNullOrEmpty(specifics))
            {
                queryErrorMsg.Text = queryErrorMsg.Text + "Please fill all fields" + Environment.NewLine;
            }
            else
            {
                if (filter.SelectedItem.ToString().Equals("Employee ID"))
                {
                    try
                    {
                        Convert.ToInt32(specifics);
                    }
                    catch (FormatException)
                    {
                        queryErrorMsg.Text = queryErrorMsg.Text + "Employee IDs are numerical." + Environment.NewLine;
                        valid = false;
                    }
                }
                if(valid == true)
                {
                    int searchResult = lRA.RP.SearchUser(filter.SelectedItem.ToString(), specifics);
                    if(searchResult == -1)
                    {
                        queryErrorMsg.Text = queryErrorMsg.Text + "No Results found." + Environment.NewLine;
                    }
                }
            }
        }

        private void updateregbutton_Click(object sender, EventArgs e)
        {
            UpdateUser update = new UpdateUser(lRA);
            update.ShowDialog();
        }

        private void deleteregbutton_Click(object sender, EventArgs e)
        {
            DeleteUser delete = new DeleteUser(lRA);
            delete.ShowDialog();
        }
    }
}
