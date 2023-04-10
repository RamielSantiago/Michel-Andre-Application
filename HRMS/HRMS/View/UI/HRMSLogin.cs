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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMS.View.UI
{
    public partial class HRMSLogin : Form, iLogin
    {
        private Log_RegAdapter LRA;

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
    }
}
