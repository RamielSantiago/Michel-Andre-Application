using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMS.View.Forms
{
    public partial class DeleteUser : Form
    {
        Log_RegAdapter lRA;
        public DeleteUser(Log_RegAdapter lRA)
        {
            InitializeComponent();
            deletecriteria.DropDownStyle = ComboBoxStyle.DropDownList;
            this.lRA = lRA;
        }

        private void DeleteUser_Load(object sender, EventArgs e)
        {

        }

        private void deleteUserButton_Click(object sender, EventArgs e)
        {
            delErrorMsg.Text = "";
            bool valid = true;
            if(deletecriteria.SelectedIndex == -1)
            {
                delErrorMsg.Text = delErrorMsg.Text + "Please select a Search Criteria for deletion." + Environment.NewLine;
                valid = false;
            }
            if (string.IsNullOrWhiteSpace(deletequery.Text))
            {
                delErrorMsg.Text = delErrorMsg.Text + "Please select a value related to the record to delete." + Environment.NewLine;
                valid = false;
            }
            if(valid)
            {
                if (deletecriteria.Text.Equals("Employee ID"))
                {
                    try
                    {
                        int test = Convert.ToInt32(deletequery.Text);
                        lRA.RP.DeleteUser(deletecriteria.SelectedItem.ToString(), deletequery.Text);
                    }
                    catch (FormatException)
                    {
                        delErrorMsg.Text = delErrorMsg.Text + "Employee IDs are numerical" + Environment.NewLine;
                    }
                }
                else
                {
                    lRA.RP.DeleteUser(deletecriteria.SelectedItem.ToString(), deletequery.Text);
                }

            }
        }
    }
}
