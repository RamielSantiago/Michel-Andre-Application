using HRMS.Model;
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

namespace HRMS.View.Forms
{
    public partial class UpdateUser : Form
    {
        Log_RegAdapter lRA;
        public UpdateUser(Log_RegAdapter lRA)
        {
            InitializeComponent();
            nALINPUT.DropDownStyle = ComboBoxStyle.DropDownList;
            this.lRA = lRA;
        }

        private void updateUserButton_Click(object sender, EventArgs e)
        {
            upErrorMsg.Text = "";
            string employee = eID.Text;
            int id, access;
            bool valid = true, updatepassword = false;
            var passwordRegex = new Regex("^(?=.{8,20})(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%^&+=!_]).*$"); //Min. 1 Special Char., 1 Uppercase, 1 Lowercase, 1 Number, & min. 8 Chars, Max 20
            bool isValidPassword = passwordRegex.IsMatch(uppass.Text);
            if (string.IsNullOrEmpty(employee))
            {
                upErrorMsg.Text = upErrorMsg.Text + "Please enter the ID of the Employee." + Environment.NewLine;
            } else
            {
                try
                {
                    id = Convert.ToInt32(employee);
                } catch (FormatException) {
                    upErrorMsg.Text = upErrorMsg.Text + "Employee IDs are numerical." + Environment.NewLine;
                    valid = false;
                }
                if(!uppass.Text.Equals("") && !upconpass.Text.Equals(""))
                {
                    updatepassword = true;
                    if (uppass.Text.Equals(upconpass.Text) == false)
                    {
                         valid = false;
                         upErrorMsg.Text = upErrorMsg.Text + "Passwords must match." + Environment.NewLine;
                    }
                    if (isValidPassword == false)
                    {
                        valid = false;
                        upErrorMsg.Text = upErrorMsg.Text + "Password must contain 8-20 Characters and have at least (1) Uppercase Letter, (1) Lowercase Letter, (1) Numeric Character, and (1) Special Character." + Environment.NewLine;
                    }
                    if (!uppass.Text.Equals(upconpass.Text))
                    {
                        upErrorMsg.Text = upErrorMsg.Text + "Passwords don't match." + Environment.NewLine;
                    }
                } 
                if (!string.IsNullOrWhiteSpace(upemail.Text))
                {
                    try
                    {
                        MailAddress m = new MailAddress(upemail.Text);
                    }
                    catch (FormatException)
                    {
                        upErrorMsg.Text = upErrorMsg.Text + "Invalid Email." + Environment.NewLine;
                        valid = false;
                    }
                }
                if(nALINPUT.SelectedIndex > -1)
                {
                    try
                    {
                        access = Convert.ToInt32(nALINPUT.SelectedItem.ToString());
                        if (access > 5 || access < 1)
                        {
                            upErrorMsg.Text = upErrorMsg.Text + "Please choose from the options in the dropdown" + Environment.NewLine;
                            valid = false;
                        }
                    }
                    catch (FormatException)
                    {
                        upErrorMsg.Text = upErrorMsg.Text + "Please choose from the options in the dropdown" + Environment.NewLine;
                        valid = false;
                    }
                }

                if(valid)
                {
                    var update = new UserModel();
                    update.EmployeeID = Convert.ToInt32(eID.Text.ToString());
                    if (string.IsNullOrWhiteSpace(Upusername.Text))
                    {
                        update.UserName = "-1";
                    }
                    else
                    {
                        update.UserName = Upusername.Text;
                    }

                    if (string.IsNullOrWhiteSpace(ufName.Text))
                    {
                        update.FirstName = "-1";
                    }
                    else
                    {
                        update.FirstName = ufName.Text;
                    }

                    if (string.IsNullOrWhiteSpace(uplName.Text))
                    {
                        update.LastName = "-1";
                    }
                    else
                    {
                        update.LastName = uplName.Text;
                    }

                    if (string.IsNullOrWhiteSpace(upmName.Text))
                    {
                        update.MiddleName = "-1";
                    }
                    else
                    {
                        update.MiddleName = upmName.Text;
                    }

                    if (updatepassword == false)
                    {
                        update.Password = "-1";
                    }
                    else
                    {
                        update.Password = uppass.Text;
                    }

                    if (nALINPUT.SelectedIndex == -1)
                    {
                        update.AccessRights = 0;
                    }
                    else
                    {
                        update.AccessRights = Convert.ToInt32(nALINPUT.SelectedItem.ToString());
                    }

                    if (string.IsNullOrWhiteSpace(upemail.Text))
                    {
                        update.Email = "-1";
                    }
                    else
                    {
                        update.Email = upemail.Text;
                    }
                    lRA.RP.UpdateUser(update);                  
                }
            }
        }

        private void UpdateUser_Load(object sender, EventArgs e)
        {

        }
    }
}
