using HRMS.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMS
{
    public partial class HRMSLogin : Form, ILogin
    {
        private Log_RegAdapter lRA;
        public HRMSLogin()
        {
            InitializeComponent();
        }
        public string UserName { get { return username.Text; } set { username.Text = value; } }
        public string Password { get { return logpass.Text; } set { logpass.Text = value; }  }
        public string SearchValue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        private void Form1_Load(object sender, EventArgs e) // Form1 = HRMSLogin Window
        {
            lRA = new Log_RegAdapter(this);
        }

        private void LoginTitle_Click(object sender, EventArgs e) // Login Label
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) // Username Textbox
        {

        }

        private void passwordlabel_Click(object sender, EventArgs e) // Password Label above textbox
        {

        }

        private void button1_Click(object sender, EventArgs e) // Login Button
        {
            string storedUsername = username.Text;
            string storedPassword = logpass.Text;

            if (string.IsNullOrEmpty(storedUsername) || string.IsNullOrEmpty(storedPassword))
            {
                logErrorMsg.Text = logErrorMsg.Text + "Please fill both fields.";
            } else
            {
                int verify = lRA.LP.SearchUser(storedUsername, storedPassword);

                if (verify == 1)
                {
                    this.Close();
                    Dashboard dash = new Dashboard(storedUsername, 1);// 1 Is a placeholder. Will try to see if I can retireve access level and username
                    dash.Show();
                } else
                {
                    logErrorMsg.Text = logErrorMsg.Text + "Username or Password is incorrect" + Environment.NewLine;
                }
            }
        }

        private void ToRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            HRMSRegister register= new HRMSRegister();
            register.Show();
        }
    }
}
