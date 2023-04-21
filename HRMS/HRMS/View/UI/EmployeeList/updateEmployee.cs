using HRMS.Model.DBModels;
using HRMS.View.Adapters;
using HRMS.View.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HRMS.View.UI.EmployeeList
{
    public partial class updateEmployee : UserControl, iRegister
    {
        private string[] acctPos = {"EVP Finance & Accounting",
                                    "Accounting Officer",
                                    "Accounts Receivable Staff",
                                    "Account Payable Staff",
                                    "General Accounting Staff",
                                    "Accounting General Services Staff"};
        private string[] retailPos = {"AVP - Sales & Marketing",
                                      "Retail Sales Officer",
                                      "Retail Sales Supervisor",
                                      "Sales Associates"};
        private string[] auditPos = {"Internal Audit Officer",
                                     "Field Auditor",
                                     "Audit Staff"};
        private string[] misPos = {"System Administrator",
                                   "IT Programmer",
                                   "System & Hardware Technical Support Staff",
                                   "EDP Staff"};
        private string[] securityPos = {"Security Services - Administration Officer",
                                        "Security Services - Senior Security Staff",
                                        "Security Services - Junior Securty Staff",
                                        "Maintenance & General Services - Senior Mechanic",
                                        "Maintenance & General Services - Junior General Services Staff",
                                        "Maintenance & General Services - Store & Building Maintenance Contractor",
                                        "Maintenance & General Services - Administrative General Services"};
        private string[] purchasingPos = {"Purchasing Officer",
                                          "Purchasing Staff"};
        private string[] merchPos = {"AVP - Retail Operation",
                                     "Merchandising Officer",
                                     "Merchandising & Planning Control Staff"};
        private string[] hrmdPos = {"HRMD Officer",
                                    "HR Consultant",
                                    "Recuitment, HRIS & OD Staff",
                                    "Compensation, Benefits & HR-Admin Staff",
                                    "Training, Employee, Relation & Record Management Staff",};
        private string[] marketPos = {"AVP Retail Operation",
                                      "Public Relations & Advertising Consultant",
                                      "Marketing Staff"};
        private string[] creativesPos = {"AVP - Retail Operation",
                                         "Graphic Artist"};
        private string[] warelogPos = {"Warehouse & Logistic Assistant Supervisor",
                                       "Warehouse Finished Goods - Receiving Staff",
                                       "Warehouse Finished Goods - Delivery Staff",
                                       "Logistic Section - Delivery Driver",
                                       "Logistic Section - Delivery Assistant",
                                       "Logistic Section - Logistic Assistant",
                                       "Raw Material Section - Raw Material Controller"};
        private string[] mcePos = {"Production Officer",
                                   "Cutting Subcontractor",
                                   "Prodcution Assistant",
                                   "Cut Goods & Raw Material Issuance - Subcontractor Coordinator",
                                   "Cut Goods & Raw Material Issuance - External Sewing Subcontractor",
                                   "Cut Goods & Raw Material Issuance - Cutting Subcontractor",
                                   "Cut Goods & Raw Material Issuance - Bundling Subcontractor",
                                   "Sewing - Sewing Supervisor",
                                   "Sewing - Fusers",
                                   "Sewing - Button Hole or Sew",
                                   "Sewing - Trimmers",
                                   "Sewing - Washers",
                                   "Sewing Assembly - Sewing Assembly Supervisor",
                                   "Sewing Assembly - Woven Shirt or Barong Sewinbg Subcontractors",
                                   "Sewing Assemby - Pants Sewing Subcontractors",
                                   "Pressing & Packing - Pressing & Packing Supervisor",
                                   "Pressing & Packing - Pressing Subcontractor"};
        private string[] mceqaPos = {"Assistant Supervisor Quality Assurance",
                                     "Sewing QA - In-House Pre-Final Subcon Pants",
                                     "Sewing QA - In-House Pre-Final Subcon Barong",
                                     "Sewing QA - QC Staff",
                                     "Raw Material QA - Juai Fabric, Embroidery, or Final QC Subcon",
                                     "Raw Material QA - Fabric Inspector"};
        private Log_RegAdapter LRA;
        public updateEmployee()
        {
            InitializeComponent();
            this.LRA = new Log_RegAdapter(this);
            if (!editDate.Checked)
            {
                hiredate.Enabled = false;
            }
        }

        public string FirstName { get { return fname.Text; } set { fname.Text = value; } }
        public string LastName { get { return lName.Text; } set { lName.Text = value; } }
        public string MiddleName { get { return MI.Text; } set { MI.Text = value; } }
        public string Position { get { return position.SelectedItem.ToString(); } set { position.SelectedIndex = Convert.ToInt32(value); } }
        public string Department { get { return dept.SelectedItem.ToString(); } set { dept.SelectedIndex = Convert.ToInt32(value); } }
        public string Email { get { return email.Text; } set { email.Text = value; } }
        public string Password { get { return regpass.Text; } set { regpass.Text = value; regconpass.Clear(); } }
        public string UserName { get { return username.Text; } set { username.Text = value; } }
        public DateTime DateHired { get { return hiredate.Value; } set { hiredate.Value = value; } }

        public void setEmployeeBS(BindingSource bs)
        {
            Console.Write("Nothing");
        }

        private void dept_SelectedIndexChanged(object sender, EventArgs e)
        {
            position.Items.Clear();
            switch (dept.SelectedIndex)
            {
                case 0:
                    position.Items.Add("President");
                    position.SelectedIndex = 0;
                    break;
                case 1:
                    position.Items.Add("General Manager");
                    position.SelectedIndex = 0;
                    break;
                case 2:
                    for (int i = 0; i < acctPos.Length; i++)
                    {
                        position.Items.Add(acctPos[i]);
                    }
                    break;
                case 3:
                    for (int i = 0; i < retailPos.Length; i++)
                    {
                        position.Items.Add(retailPos[i]);
                    }
                    break;
                case 4:
                    for (int i = 0; i < auditPos.Length; i++)
                    {
                        position.Items.Add(auditPos[i]);
                    }
                    break;
                case 5:
                    for (int i = 0; i < misPos.Length; i++)
                    {
                        position.Items.Add(misPos[i]);
                    }
                    break;
                case 6:
                    for (int i = 0; i < securityPos.Length; i++)
                    {
                        position.Items.Add(securityPos[i]);
                    }
                    break;
                case 7:
                    for (int i = 0; i < purchasingPos.Length; i++)
                    {
                        position.Items.Add(purchasingPos[i]);
                    }
                    break;
                case 8:
                    for (int i = 0; i < merchPos.Length; i++)
                    {
                        position.Items.Add(merchPos[i]);
                    }
                    break;
                case 9:
                    for (int i = 0; i < hrmdPos.Length; i++)
                    {
                        position.Items.Add(hrmdPos[i]);
                    }
                    break;
                case 10:
                    for (int i = 0; i < marketPos.Length; i++)
                    {
                        position.Items.Add(marketPos[i]);
                    }
                    break;
                case 11:
                    for (int i = 0; i < creativesPos.Length; i++)
                    {
                        position.Items.Add(creativesPos[i]);
                    }
                    break;
                case 12:
                    for (int i = 0; i < warelogPos.Length; i++)
                    {
                        position.Items.Add(warelogPos[i]);
                    }
                    break;
                case 13:
                    for (int i = 0; i < mcePos.Length; i++)
                    {
                        position.Items.Add(mcePos[i]);
                    }
                    break;
                case 14:
                    for (int i = 0; i < mceqaPos.Length; i++)
                    {
                        position.Items.Add(mceqaPos[i]);
                    }
                    break;
            }
        }

        private void editDate_CheckedChanged(object sender, EventArgs e)
        {
            if (!editDate.Checked)
            {
                hiredate.Enabled = false;
            }
            else
            {
                hiredate.Enabled = true;
            }
        }

        private void upEmpBtn_Click(object sender, EventArgs e)
        {
            var passwordRegex = new Regex("^(?=.{8,20})(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%^&+=!_]).*$"); //Min. 1 Special Char., 1 Uppercase, 1 Lowercase, 1 Number, & min. 8 Chars, Max 20
            string errorMsg = "";
            bool valid = true;
            bool isValidPassword = passwordRegex.IsMatch(Password);

            if (string.IsNullOrWhiteSpace(eID.Text))
            {
                errorMsg = errorMsg + "Please fill all required fields" + Environment.NewLine;
                valid = false;
            }
            else
            {
                try
                {
                    if (Convert.ToInt32(eID.Text) == 0)
                    {
                        errorMsg = errorMsg + "Default Account cannot be modified" + Environment.NewLine;
                        valid = false;
                    }
                }
                catch (FormatException)
                {
                    errorMsg = errorMsg + "Employee IDs are numerical" + Environment.NewLine;
                    valid = false;
                }
            }
            if (!string.IsNullOrWhiteSpace(eID.Text) && string.IsNullOrWhiteSpace(FirstName) && string.IsNullOrWhiteSpace(LastName) && string.IsNullOrWhiteSpace(Email) &&
                string.IsNullOrWhiteSpace(Password) && string.IsNullOrWhiteSpace(regconpass.Text) && string.IsNullOrWhiteSpace(UserName) &&
                position.SelectedIndex == -1 && dept.SelectedIndex == -1)
            {
                errorMsg = errorMsg + "Please select and fill a field to update" + Environment.NewLine;
                valid = false;
            }
            if (valid == false)
            {
                MessageBox.Show(errorMsg, "Human Resource Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    int temp = Convert.ToInt32(eID.Text);
                    if (LRA.RP.SearchUser("Employee ID", temp.ToString()) == -1)
                    {
                        valid = false;
                        errorMsg = errorMsg + "No such user exists" + Environment.NewLine;
                    }
                }
                catch (FormatException)
                {
                    valid = false;
                    errorMsg = errorMsg + "Employee ID must consist of numbers only" + Environment.NewLine;

                }
                if (dept.SelectedIndex > -1 && position.SelectedIndex == -1)
                {
                    valid = false;
                    errorMsg = errorMsg + "Please select a position in your chosen department" + Environment.NewLine;
                }
                if (hiredate.Value > DateTime.Now && editDate.Checked)
                {
                    valid = false;
                    errorMsg = errorMsg + "Date input cannot be a future date." + Environment.NewLine;
                }
                if ((!string.IsNullOrWhiteSpace(regpass.Text) && string.IsNullOrWhiteSpace(regconpass.Text)) ||
                    (string.IsNullOrWhiteSpace(regpass.Text) && !string.IsNullOrWhiteSpace(regconpass.Text)))
                {
                    valid = false;
                    errorMsg = errorMsg + "Both password fields must be filled to update password." + Environment.NewLine;
                }
                if (!string.IsNullOrWhiteSpace(regpass.Text) && !string.IsNullOrWhiteSpace(regconpass.Text))
                {
                    if (regpass.Text.Equals(regconpass.Text) == false)
                    {
                        valid = false;
                        errorMsg = errorMsg + "Passwords must match." + Environment.NewLine;
                    }
                    if (isValidPassword == false)
                    {
                        valid = false;
                        errorMsg = errorMsg + "Password must contain 8-20 Characters and have at least (1) Uppercase Letter, (1) Lowercase Letter, (1) Numeric Character, and (1) Special Character." + Environment.NewLine;
                    }
                }
                if (!string.IsNullOrWhiteSpace(UserName) && LRA.RP.SearchUser("Username", UserName) == 1)
                {
                    valid = false;
                    errorMsg = errorMsg + "This Username is taken." + Environment.NewLine;
                }
                if (!string.IsNullOrWhiteSpace(Email))
                {
                    try
                    {
                        MailAddress m = new MailAddress(Email);
                    }
                    catch (FormatException)
                    {
                        errorMsg = errorMsg + "Invalid Email." + Environment.NewLine;
                        valid = false;
                    }
                    if (LRA.RP.SearchUser("Email", Email) == 1)
                    {
                        valid = false;
                        errorMsg = errorMsg + "This Email is taken." + Environment.NewLine;
                    }
                }
                if (valid == true)
                {
                    var update = new UserModel();
                    update.EmployeeID = Convert.ToInt32(eID.Text);
                    if (string.IsNullOrWhiteSpace(FirstName))
                    {
                        update.FirstName = "-1";
                    }
                    else
                    {
                        update.FirstName = FirstName;
                    }
                    if (string.IsNullOrWhiteSpace(MiddleName))
                    {
                        update.MiddleName = "-1";
                    }
                    else
                    {
                        update.MiddleName = MiddleName;
                    }
                    if (string.IsNullOrWhiteSpace(LastName))
                    {
                        update.LastName = "-1";
                    }
                    else
                    {
                        update.LastName = LastName;
                    }
                    if (dept.SelectedIndex == -1)
                    {
                        update.Department = "-1";
                    }
                    else
                    {
                        update.Department = dept.SelectedItem.ToString();
                    }
                    if (position.SelectedIndex == -1)
                    {
                        update.Position = "-1";
                    }
                    else
                    {
                        update.Position = position.SelectedItem.ToString();
                    }
                    if (string.IsNullOrWhiteSpace(UserName))
                    {
                        update.UserName = "-1";
                    }
                    else
                    {
                        update.UserName = UserName;
                    }
                    if (string.IsNullOrWhiteSpace(Password) && string.IsNullOrWhiteSpace(regconpass.Text))
                    {
                        update.Password = "-1";
                    }
                    else
                    {
                        update.Password = Password;
                    }
                    if (string.IsNullOrWhiteSpace(Email))
                    {
                        update.Email = "-1";
                    }
                    else
                    {
                        update.Email = Email;
                    }
                    if (!editDate.Checked)
                    {
                        update.DateHired = DateTime.MaxValue;
                    }
                    else
                    {
                        update.DateHired = DateHired;
                    }
                    LRA.RP.UpdateUser(update);
                    MessageBox.Show("Update Successful", "Human Resource Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(errorMsg, "Human Resource Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            lName.Clear();
            fname.Clear();
            MI.Clear();
            username.Clear();
            email.Clear();
            regpass.Clear();
            regconpass.Clear();
            dept.SelectedIndex = -1;
            position.SelectedIndex = -1;
            hiredate.Value = DateTime.Now;
            eID.Clear();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void uName_Click(object sender, EventArgs e)
        {

        }

        private void regconpass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
