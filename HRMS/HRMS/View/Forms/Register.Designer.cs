namespace HRMS
{
    partial class HRMSRegister
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.newemployee = new System.Windows.Forms.TabPage();
            this.ALINPUT = new System.Windows.Forms.ComboBox();
            this.addUserButton = new System.Windows.Forms.Button();
            this.alLabel = new System.Windows.Forms.Label();
            this.regErrorMsg = new System.Windows.Forms.TextBox();
            this.eID = new System.Windows.Forms.TextBox();
            this.mName = new System.Windows.Forms.TextBox();
            this.lName = new System.Windows.Forms.TextBox();
            this.fName = new System.Windows.Forms.TextBox();
            this.regconpass = new System.Windows.Forms.TextBox();
            this.regpass = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.middle_name = new System.Windows.Forms.Label();
            this.last_name = new System.Windows.Forms.Label();
            this.first_name = new System.Windows.Forms.Label();
            this.conpass = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.usernamelabel = new System.Windows.Forms.Label();
            this.RegisterLabel = new System.Windows.Forms.Label();
            this.viewlist = new System.Windows.Forms.TabPage();
            this.employeelist = new System.Windows.Forms.DataGridView();
            this.deleteregbutton = new System.Windows.Forms.Button();
            this.updateregbutton = new System.Windows.Forms.Button();
            this.queryErrorMsg = new System.Windows.Forms.TextBox();
            this.querydetail = new System.Windows.Forms.TextBox();
            this.query = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.filter = new System.Windows.Forms.ComboBox();
            this.list = new System.Windows.Forms.TabControl();
            this.newemployee.SuspendLayout();
            this.viewlist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeelist)).BeginInit();
            this.list.SuspendLayout();
            this.SuspendLayout();
            // 
            // newemployee
            // 
            this.newemployee.BackColor = System.Drawing.SystemColors.ControlLight;
            this.newemployee.Controls.Add(this.ALINPUT);
            this.newemployee.Controls.Add(this.addUserButton);
            this.newemployee.Controls.Add(this.alLabel);
            this.newemployee.Controls.Add(this.regErrorMsg);
            this.newemployee.Controls.Add(this.eID);
            this.newemployee.Controls.Add(this.mName);
            this.newemployee.Controls.Add(this.lName);
            this.newemployee.Controls.Add(this.fName);
            this.newemployee.Controls.Add(this.regconpass);
            this.newemployee.Controls.Add(this.regpass);
            this.newemployee.Controls.Add(this.email);
            this.newemployee.Controls.Add(this.username);
            this.newemployee.Controls.Add(this.label1);
            this.newemployee.Controls.Add(this.middle_name);
            this.newemployee.Controls.Add(this.last_name);
            this.newemployee.Controls.Add(this.first_name);
            this.newemployee.Controls.Add(this.conpass);
            this.newemployee.Controls.Add(this.password);
            this.newemployee.Controls.Add(this.emailLabel);
            this.newemployee.Controls.Add(this.usernamelabel);
            this.newemployee.Controls.Add(this.RegisterLabel);
            this.newemployee.Location = new System.Drawing.Point(4, 32);
            this.newemployee.Name = "newemployee";
            this.newemployee.Padding = new System.Windows.Forms.Padding(3);
            this.newemployee.Size = new System.Drawing.Size(1216, 772);
            this.newemployee.TabIndex = 0;
            this.newemployee.Text = "Register Employee Record";
            // 
            // ALINPUT
            // 
            this.ALINPUT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ALINPUT.FormattingEnabled = true;
            this.ALINPUT.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.ALINPUT.Location = new System.Drawing.Point(478, 443);
            this.ALINPUT.Name = "ALINPUT";
            this.ALINPUT.Size = new System.Drawing.Size(234, 31);
            this.ALINPUT.TabIndex = 85;
            // 
            // addUserButton
            // 
            this.addUserButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addUserButton.BackColor = System.Drawing.Color.Goldenrod;
            this.addUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addUserButton.Font = new System.Drawing.Font("Arial", 12F);
            this.addUserButton.Location = new System.Drawing.Point(491, 510);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(216, 65);
            this.addUserButton.TabIndex = 84;
            this.addUserButton.Text = "Register";
            this.addUserButton.UseVisualStyleBackColor = false;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // alLabel
            // 
            this.alLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.alLabel.AutoSize = true;
            this.alLabel.Font = new System.Drawing.Font("Arial", 14F);
            this.alLabel.Location = new System.Drawing.Point(476, 407);
            this.alLabel.Name = "alLabel";
            this.alLabel.Size = new System.Drawing.Size(160, 27);
            this.alLabel.TabIndex = 83;
            this.alLabel.Text = "Access Level*";
            // 
            // regErrorMsg
            // 
            this.regErrorMsg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.regErrorMsg.BackColor = System.Drawing.SystemColors.ControlLight;
            this.regErrorMsg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.regErrorMsg.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.regErrorMsg.Location = new System.Drawing.Point(329, 593);
            this.regErrorMsg.Multiline = true;
            this.regErrorMsg.Name = "regErrorMsg";
            this.regErrorMsg.Size = new System.Drawing.Size(562, 92);
            this.regErrorMsg.TabIndex = 81;
            // 
            // eID
            // 
            this.eID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.eID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eID.Font = new System.Drawing.Font("Arial", 14F);
            this.eID.Location = new System.Drawing.Point(481, 205);
            this.eID.Multiline = true;
            this.eID.Name = "eID";
            this.eID.Size = new System.Drawing.Size(229, 30);
            this.eID.TabIndex = 78;
            // 
            // mName
            // 
            this.mName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mName.Font = new System.Drawing.Font("Arial", 14F);
            this.mName.Location = new System.Drawing.Point(164, 447);
            this.mName.Multiline = true;
            this.mName.Name = "mName";
            this.mName.Size = new System.Drawing.Size(229, 30);
            this.mName.TabIndex = 76;
            // 
            // lName
            // 
            this.lName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lName.Font = new System.Drawing.Font("Arial", 14F);
            this.lName.Location = new System.Drawing.Point(164, 326);
            this.lName.Multiline = true;
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(229, 30);
            this.lName.TabIndex = 74;
            // 
            // fName
            // 
            this.fName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fName.Font = new System.Drawing.Font("Arial", 14F);
            this.fName.Location = new System.Drawing.Point(164, 205);
            this.fName.Multiline = true;
            this.fName.Name = "fName";
            this.fName.Size = new System.Drawing.Size(229, 30);
            this.fName.TabIndex = 72;
            // 
            // regconpass
            // 
            this.regconpass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.regconpass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.regconpass.Font = new System.Drawing.Font("Arial", 14F);
            this.regconpass.Location = new System.Drawing.Point(800, 447);
            this.regconpass.Multiline = true;
            this.regconpass.Name = "regconpass";
            this.regconpass.PasswordChar = '*';
            this.regconpass.Size = new System.Drawing.Size(234, 30);
            this.regconpass.TabIndex = 70;
            // 
            // regpass
            // 
            this.regpass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.regpass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.regpass.Font = new System.Drawing.Font("Arial", 14F);
            this.regpass.Location = new System.Drawing.Point(800, 326);
            this.regpass.Multiline = true;
            this.regpass.Name = "regpass";
            this.regpass.PasswordChar = '*';
            this.regpass.Size = new System.Drawing.Size(239, 30);
            this.regpass.TabIndex = 68;
            // 
            // email
            // 
            this.email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.email.Font = new System.Drawing.Font("Arial", 14F);
            this.email.Location = new System.Drawing.Point(800, 205);
            this.email.Multiline = true;
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(239, 30);
            this.email.TabIndex = 66;
            // 
            // username
            // 
            this.username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.username.Font = new System.Drawing.Font("Arial", 14F);
            this.username.Location = new System.Drawing.Point(476, 326);
            this.username.Multiline = true;
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(234, 30);
            this.username.TabIndex = 64;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F);
            this.label1.Location = new System.Drawing.Point(476, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 27);
            this.label1.TabIndex = 79;
            this.label1.Text = "Employee ID*";
            // 
            // middle_name
            // 
            this.middle_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.middle_name.AutoSize = true;
            this.middle_name.Font = new System.Drawing.Font("Arial", 14F);
            this.middle_name.Location = new System.Drawing.Point(159, 407);
            this.middle_name.Name = "middle_name";
            this.middle_name.Size = new System.Drawing.Size(153, 27);
            this.middle_name.TabIndex = 77;
            this.middle_name.Text = "Middle Name";
            // 
            // last_name
            // 
            this.last_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.last_name.AutoSize = true;
            this.last_name.Font = new System.Drawing.Font("Arial", 14F);
            this.last_name.Location = new System.Drawing.Point(161, 286);
            this.last_name.Name = "last_name";
            this.last_name.Size = new System.Drawing.Size(136, 27);
            this.last_name.TabIndex = 75;
            this.last_name.Text = "Last Name*";
            // 
            // first_name
            // 
            this.first_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.first_name.AutoSize = true;
            this.first_name.Font = new System.Drawing.Font("Arial", 14F);
            this.first_name.Location = new System.Drawing.Point(159, 165);
            this.first_name.Name = "first_name";
            this.first_name.Size = new System.Drawing.Size(138, 27);
            this.first_name.TabIndex = 73;
            this.first_name.Text = "First Name*";
            // 
            // conpass
            // 
            this.conpass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.conpass.AutoSize = true;
            this.conpass.Font = new System.Drawing.Font("Arial", 14F);
            this.conpass.Location = new System.Drawing.Point(800, 407);
            this.conpass.Name = "conpass";
            this.conpass.Size = new System.Drawing.Size(217, 27);
            this.conpass.TabIndex = 71;
            this.conpass.Text = "Confirm Password*";
            // 
            // password
            // 
            this.password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Arial", 14F);
            this.password.Location = new System.Drawing.Point(800, 286);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(126, 27);
            this.password.TabIndex = 69;
            this.password.Text = "Password*";
            // 
            // emailLabel
            // 
            this.emailLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Arial", 14F);
            this.emailLabel.Location = new System.Drawing.Point(800, 165);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(81, 27);
            this.emailLabel.TabIndex = 67;
            this.emailLabel.Text = "Email*";
            // 
            // usernamelabel
            // 
            this.usernamelabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usernamelabel.AutoSize = true;
            this.usernamelabel.Font = new System.Drawing.Font("Arial", 14F);
            this.usernamelabel.Location = new System.Drawing.Point(476, 286);
            this.usernamelabel.Name = "usernamelabel";
            this.usernamelabel.Size = new System.Drawing.Size(131, 27);
            this.usernamelabel.TabIndex = 65;
            this.usernamelabel.Text = "Username*";
            // 
            // RegisterLabel
            // 
            this.RegisterLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RegisterLabel.AutoSize = true;
            this.RegisterLabel.Font = new System.Drawing.Font("Arial", 30F);
            this.RegisterLabel.Location = new System.Drawing.Point(369, 66);
            this.RegisterLabel.Name = "RegisterLabel";
            this.RegisterLabel.Size = new System.Drawing.Size(449, 57);
            this.RegisterLabel.TabIndex = 63;
            this.RegisterLabel.Text = "Register Employee";
            // 
            // viewlist
            // 
            this.viewlist.BackColor = System.Drawing.SystemColors.ControlLight;
            this.viewlist.Controls.Add(this.employeelist);
            this.viewlist.Controls.Add(this.deleteregbutton);
            this.viewlist.Controls.Add(this.updateregbutton);
            this.viewlist.Controls.Add(this.queryErrorMsg);
            this.viewlist.Controls.Add(this.querydetail);
            this.viewlist.Controls.Add(this.query);
            this.viewlist.Controls.Add(this.label2);
            this.viewlist.Controls.Add(this.filter);
            this.viewlist.Location = new System.Drawing.Point(4, 32);
            this.viewlist.Name = "viewlist";
            this.viewlist.Padding = new System.Windows.Forms.Padding(3);
            this.viewlist.Size = new System.Drawing.Size(1216, 772);
            this.viewlist.TabIndex = 1;
            this.viewlist.Text = "View Employees";
            // 
            // employeelist
            // 
            this.employeelist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeelist.Location = new System.Drawing.Point(114, 180);
            this.employeelist.Name = "employeelist";
            this.employeelist.RowHeadersWidth = 51;
            this.employeelist.RowTemplate.Height = 24;
            this.employeelist.Size = new System.Drawing.Size(991, 567);
            this.employeelist.TabIndex = 93;
            // 
            // deleteregbutton
            // 
            this.deleteregbutton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.deleteregbutton.Location = new System.Drawing.Point(632, 12);
            this.deleteregbutton.Name = "deleteregbutton";
            this.deleteregbutton.Size = new System.Drawing.Size(144, 41);
            this.deleteregbutton.TabIndex = 92;
            this.deleteregbutton.Text = "Delete";
            this.deleteregbutton.UseVisualStyleBackColor = false;
            this.deleteregbutton.Click += new System.EventHandler(this.deleteregbutton_Click);
            // 
            // updateregbutton
            // 
            this.updateregbutton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.updateregbutton.Location = new System.Drawing.Point(426, 12);
            this.updateregbutton.Name = "updateregbutton";
            this.updateregbutton.Size = new System.Drawing.Size(144, 41);
            this.updateregbutton.TabIndex = 91;
            this.updateregbutton.Text = "Update";
            this.updateregbutton.UseVisualStyleBackColor = false;
            this.updateregbutton.Click += new System.EventHandler(this.updateregbutton_Click);
            // 
            // queryErrorMsg
            // 
            this.queryErrorMsg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.queryErrorMsg.BackColor = System.Drawing.SystemColors.ControlLight;
            this.queryErrorMsg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.queryErrorMsg.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.queryErrorMsg.Location = new System.Drawing.Point(426, 59);
            this.queryErrorMsg.Multiline = true;
            this.queryErrorMsg.Name = "queryErrorMsg";
            this.queryErrorMsg.Size = new System.Drawing.Size(383, 58);
            this.queryErrorMsg.TabIndex = 82;
            // 
            // querydetail
            // 
            this.querydetail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.querydetail.Location = new System.Drawing.Point(476, 142);
            this.querydetail.Name = "querydetail";
            this.querydetail.Size = new System.Drawing.Size(473, 30);
            this.querydetail.TabIndex = 2;
            // 
            // query
            // 
            this.query.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.query.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.query.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.query.Font = new System.Drawing.Font("Arial", 10F);
            this.query.Location = new System.Drawing.Point(955, 143);
            this.query.Name = "query";
            this.query.Size = new System.Drawing.Size(150, 31);
            this.query.TabIndex = 4;
            this.query.Text = "Submit";
            this.query.UseVisualStyleBackColor = false;
            this.query.Click += new System.EventHandler(this.query_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14F);
            this.label2.Location = new System.Drawing.Point(109, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Search by:";
            // 
            // filter
            // 
            this.filter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.filter.FormattingEnabled = true;
            this.filter.Items.AddRange(new object[] {
            "Employee ID",
            "First Name",
            "Last Name",
            "Username",
            "Email"});
            this.filter.Location = new System.Drawing.Point(243, 141);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(227, 31);
            this.filter.TabIndex = 0;
            // 
            // list
            // 
            this.list.Controls.Add(this.viewlist);
            this.list.Controls.Add(this.newemployee);
            this.list.Font = new System.Drawing.Font("Arial", 12F);
            this.list.Location = new System.Drawing.Point(5, 0);
            this.list.Name = "list";
            this.list.SelectedIndex = 0;
            this.list.Size = new System.Drawing.Size(1224, 808);
            this.list.TabIndex = 25;
            // 
            // HRMSRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.list);
            this.Name = "HRMSRegister";
            this.Size = new System.Drawing.Size(1232, 808);
            this.newemployee.ResumeLayout(false);
            this.newemployee.PerformLayout();
            this.viewlist.ResumeLayout(false);
            this.viewlist.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeelist)).EndInit();
            this.list.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage newemployee;
        private System.Windows.Forms.ComboBox ALINPUT;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.Label alLabel;
        private System.Windows.Forms.TextBox regErrorMsg;
        private System.Windows.Forms.TextBox eID;
        private System.Windows.Forms.TextBox mName;
        private System.Windows.Forms.TextBox lName;
        private System.Windows.Forms.TextBox fName;
        private System.Windows.Forms.TextBox regconpass;
        private System.Windows.Forms.TextBox regpass;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label middle_name;
        private System.Windows.Forms.Label last_name;
        private System.Windows.Forms.Label first_name;
        private System.Windows.Forms.Label conpass;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label usernamelabel;
        private System.Windows.Forms.Label RegisterLabel;
        private System.Windows.Forms.TabPage viewlist;
        private System.Windows.Forms.DataGridView employeelist;
        private System.Windows.Forms.Button deleteregbutton;
        private System.Windows.Forms.Button updateregbutton;
        private System.Windows.Forms.TextBox queryErrorMsg;
        private System.Windows.Forms.TextBox querydetail;
        private System.Windows.Forms.Button query;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox filter;
        private System.Windows.Forms.TabControl list;
    }
}
