namespace HRMS.View.Forms
{
    partial class UpdateUser
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nALINPUT = new System.Windows.Forms.ComboBox();
            this.updateUserButton = new System.Windows.Forms.Button();
            this.alLabel = new System.Windows.Forms.Label();
            this.upErrorMsg = new System.Windows.Forms.TextBox();
            this.eID = new System.Windows.Forms.TextBox();
            this.upmName = new System.Windows.Forms.TextBox();
            this.uplName = new System.Windows.Forms.TextBox();
            this.ufName = new System.Windows.Forms.TextBox();
            this.upconpass = new System.Windows.Forms.TextBox();
            this.uppass = new System.Windows.Forms.TextBox();
            this.upemail = new System.Windows.Forms.TextBox();
            this.Upusername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.middle_name = new System.Windows.Forms.Label();
            this.last_name = new System.Windows.Forms.Label();
            this.first_name = new System.Windows.Forms.Label();
            this.conpass = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.usernamelabel = new System.Windows.Forms.Label();
            this.RegisterLabel = new System.Windows.Forms.Label();
            this.guideline = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nALINPUT
            // 
            this.nALINPUT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nALINPUT.FormattingEnabled = true;
            this.nALINPUT.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.nALINPUT.Location = new System.Drawing.Point(45, 347);
            this.nALINPUT.Name = "nALINPUT";
            this.nALINPUT.Size = new System.Drawing.Size(184, 24);
            this.nALINPUT.TabIndex = 127;
            // 
            // updateUserButton
            // 
            this.updateUserButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.updateUserButton.BackColor = System.Drawing.Color.Goldenrod;
            this.updateUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updateUserButton.Font = new System.Drawing.Font("Arial", 12F);
            this.updateUserButton.Location = new System.Drawing.Point(277, 306);
            this.updateUserButton.Name = "updateUserButton";
            this.updateUserButton.Size = new System.Drawing.Size(166, 65);
            this.updateUserButton.TabIndex = 126;
            this.updateUserButton.Text = "Update";
            this.updateUserButton.UseVisualStyleBackColor = false;
            this.updateUserButton.Click += new System.EventHandler(this.updateUserButton_Click);
            // 
            // alLabel
            // 
            this.alLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.alLabel.AutoSize = true;
            this.alLabel.Font = new System.Drawing.Font("Arial", 14F);
            this.alLabel.Location = new System.Drawing.Point(43, 311);
            this.alLabel.Name = "alLabel";
            this.alLabel.Size = new System.Drawing.Size(151, 27);
            this.alLabel.TabIndex = 125;
            this.alLabel.Text = "Access Level";
            // 
            // upErrorMsg
            // 
            this.upErrorMsg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.upErrorMsg.BackColor = System.Drawing.SystemColors.ControlLight;
            this.upErrorMsg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.upErrorMsg.Font = new System.Drawing.Font("Arial Narrow", 8F);
            this.upErrorMsg.Location = new System.Drawing.Point(474, 306);
            this.upErrorMsg.Multiline = true;
            this.upErrorMsg.Name = "upErrorMsg";
            this.upErrorMsg.ReadOnly = true;
            this.upErrorMsg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.upErrorMsg.Size = new System.Drawing.Size(512, 65);
            this.upErrorMsg.TabIndex = 124;
            // 
            // eID
            // 
            this.eID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.eID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eID.Font = new System.Drawing.Font("Arial", 14F);
            this.eID.Location = new System.Drawing.Point(46, 145);
            this.eID.Multiline = true;
            this.eID.Name = "eID";
            this.eID.Size = new System.Drawing.Size(179, 30);
            this.eID.TabIndex = 122;
            // 
            // upmName
            // 
            this.upmName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.upmName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.upmName.Font = new System.Drawing.Font("Arial", 14F);
            this.upmName.Location = new System.Drawing.Point(753, 145);
            this.upmName.Multiline = true;
            this.upmName.Name = "upmName";
            this.upmName.Size = new System.Drawing.Size(179, 30);
            this.upmName.TabIndex = 120;
            // 
            // uplName
            // 
            this.uplName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uplName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uplName.Font = new System.Drawing.Font("Arial", 14F);
            this.uplName.Location = new System.Drawing.Point(525, 145);
            this.uplName.Multiline = true;
            this.uplName.Name = "uplName";
            this.uplName.Size = new System.Drawing.Size(179, 30);
            this.uplName.TabIndex = 118;
            // 
            // ufName
            // 
            this.ufName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ufName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ufName.Font = new System.Drawing.Font("Arial", 14F);
            this.ufName.Location = new System.Drawing.Point(274, 145);
            this.ufName.Multiline = true;
            this.ufName.Name = "ufName";
            this.ufName.Size = new System.Drawing.Size(179, 30);
            this.ufName.TabIndex = 116;
            // 
            // upconpass
            // 
            this.upconpass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.upconpass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.upconpass.Font = new System.Drawing.Font("Arial", 14F);
            this.upconpass.Location = new System.Drawing.Point(751, 247);
            this.upconpass.Multiline = true;
            this.upconpass.Name = "upconpass";
            this.upconpass.PasswordChar = '*';
            this.upconpass.Size = new System.Drawing.Size(184, 30);
            this.upconpass.TabIndex = 114;
            // 
            // uppass
            // 
            this.uppass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uppass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uppass.Font = new System.Drawing.Font("Arial", 14F);
            this.uppass.Location = new System.Drawing.Point(525, 247);
            this.uppass.Multiline = true;
            this.uppass.Name = "uppass";
            this.uppass.PasswordChar = '*';
            this.uppass.Size = new System.Drawing.Size(189, 30);
            this.uppass.TabIndex = 112;
            // 
            // upemail
            // 
            this.upemail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.upemail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.upemail.Font = new System.Drawing.Font("Arial", 14F);
            this.upemail.Location = new System.Drawing.Point(41, 247);
            this.upemail.Multiline = true;
            this.upemail.Name = "upemail";
            this.upemail.Size = new System.Drawing.Size(189, 30);
            this.upemail.TabIndex = 110;
            // 
            // Upusername
            // 
            this.Upusername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Upusername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Upusername.Font = new System.Drawing.Font("Arial", 14F);
            this.Upusername.Location = new System.Drawing.Point(272, 247);
            this.Upusername.Multiline = true;
            this.Upusername.Name = "Upusername";
            this.Upusername.Size = new System.Drawing.Size(184, 30);
            this.Upusername.TabIndex = 108;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F);
            this.label1.Location = new System.Drawing.Point(41, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 27);
            this.label1.TabIndex = 123;
            this.label1.Text = "Employee ID*";
            // 
            // middle_name
            // 
            this.middle_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.middle_name.AutoSize = true;
            this.middle_name.Font = new System.Drawing.Font("Arial", 14F);
            this.middle_name.Location = new System.Drawing.Point(751, 105);
            this.middle_name.Name = "middle_name";
            this.middle_name.Size = new System.Drawing.Size(153, 27);
            this.middle_name.TabIndex = 121;
            this.middle_name.Text = "Middle Name";
            // 
            // last_name
            // 
            this.last_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.last_name.AutoSize = true;
            this.last_name.Font = new System.Drawing.Font("Arial", 14F);
            this.last_name.Location = new System.Drawing.Point(525, 105);
            this.last_name.Name = "last_name";
            this.last_name.Size = new System.Drawing.Size(127, 27);
            this.last_name.TabIndex = 119;
            this.last_name.Text = "Last Name";
            // 
            // first_name
            // 
            this.first_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.first_name.AutoSize = true;
            this.first_name.Font = new System.Drawing.Font("Arial", 14F);
            this.first_name.Location = new System.Drawing.Point(272, 105);
            this.first_name.Name = "first_name";
            this.first_name.Size = new System.Drawing.Size(129, 27);
            this.first_name.TabIndex = 117;
            this.first_name.Text = "First Name";
            // 
            // conpass
            // 
            this.conpass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.conpass.AutoSize = true;
            this.conpass.Font = new System.Drawing.Font("Arial", 14F);
            this.conpass.Location = new System.Drawing.Point(751, 207);
            this.conpass.Name = "conpass";
            this.conpass.Size = new System.Drawing.Size(208, 27);
            this.conpass.TabIndex = 115;
            this.conpass.Text = "Confirm Password";
            // 
            // password
            // 
            this.password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Arial", 14F);
            this.password.Location = new System.Drawing.Point(525, 207);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(117, 27);
            this.password.TabIndex = 113;
            this.password.Text = "Password";
            // 
            // emailLabel
            // 
            this.emailLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Arial", 14F);
            this.emailLabel.Location = new System.Drawing.Point(41, 207);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(72, 27);
            this.emailLabel.TabIndex = 111;
            this.emailLabel.Text = "Email";
            // 
            // usernamelabel
            // 
            this.usernamelabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usernamelabel.AutoSize = true;
            this.usernamelabel.Font = new System.Drawing.Font("Arial", 14F);
            this.usernamelabel.Location = new System.Drawing.Point(272, 207);
            this.usernamelabel.Name = "usernamelabel";
            this.usernamelabel.Size = new System.Drawing.Size(122, 27);
            this.usernamelabel.TabIndex = 109;
            this.usernamelabel.Text = "Username";
            // 
            // RegisterLabel
            // 
            this.RegisterLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RegisterLabel.AutoSize = true;
            this.RegisterLabel.Font = new System.Drawing.Font("Arial", 30F);
            this.RegisterLabel.Location = new System.Drawing.Point(38, 19);
            this.RegisterLabel.Name = "RegisterLabel";
            this.RegisterLabel.Size = new System.Drawing.Size(423, 57);
            this.RegisterLabel.TabIndex = 107;
            this.RegisterLabel.Text = "Update Employee";
            // 
            // guideline
            // 
            this.guideline.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guideline.BackColor = System.Drawing.SystemColors.ControlLight;
            this.guideline.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.guideline.Font = new System.Drawing.Font("Arial Narrow", 8.5F);
            this.guideline.Location = new System.Drawing.Point(474, 19);
            this.guideline.Multiline = true;
            this.guideline.Name = "guideline";
            this.guideline.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.guideline.Size = new System.Drawing.Size(512, 65);
            this.guideline.TabIndex = 128;
            this.guideline.Text = "- Employee IDs cannot be changed and are only used to search the record to update" +
    ".\r\n- Employee IDs are numerical.\r\n- All fields are optional except Employee ID s" +
    "ince only filled items will be changed.";
            // 
            // UpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1026, 386);
            this.Controls.Add(this.guideline);
            this.Controls.Add(this.nALINPUT);
            this.Controls.Add(this.updateUserButton);
            this.Controls.Add(this.alLabel);
            this.Controls.Add(this.upErrorMsg);
            this.Controls.Add(this.eID);
            this.Controls.Add(this.upmName);
            this.Controls.Add(this.uplName);
            this.Controls.Add(this.ufName);
            this.Controls.Add(this.upconpass);
            this.Controls.Add(this.uppass);
            this.Controls.Add(this.upemail);
            this.Controls.Add(this.Upusername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.middle_name);
            this.Controls.Add(this.last_name);
            this.Controls.Add(this.first_name);
            this.Controls.Add(this.conpass);
            this.Controls.Add(this.password);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.usernamelabel);
            this.Controls.Add(this.RegisterLabel);
            this.Name = "UpdateUser";
            this.Text = "Human Resource Management System - Update Employee";
            this.Load += new System.EventHandler(this.UpdateUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox nALINPUT;
        private System.Windows.Forms.Button updateUserButton;
        private System.Windows.Forms.Label alLabel;
        private System.Windows.Forms.TextBox upErrorMsg;
        private System.Windows.Forms.TextBox eID;
        private System.Windows.Forms.TextBox upmName;
        private System.Windows.Forms.TextBox uplName;
        private System.Windows.Forms.TextBox ufName;
        private System.Windows.Forms.TextBox upconpass;
        private System.Windows.Forms.TextBox uppass;
        private System.Windows.Forms.TextBox upemail;
        private System.Windows.Forms.TextBox Upusername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label middle_name;
        private System.Windows.Forms.Label last_name;
        private System.Windows.Forms.Label first_name;
        private System.Windows.Forms.Label conpass;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label usernamelabel;
        private System.Windows.Forms.Label RegisterLabel;
        private System.Windows.Forms.TextBox guideline;
    }
}