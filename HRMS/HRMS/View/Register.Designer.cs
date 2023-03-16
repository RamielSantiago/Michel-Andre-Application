namespace HRMS.View
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RegisterLabel = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.usernamelabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.regpass = new System.Windows.Forms.TextBox();
            this.conpass = new System.Windows.Forms.Label();
            this.regconpass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.eID = new System.Windows.Forms.TextBox();
            this.middle_name = new System.Windows.Forms.Label();
            this.mName = new System.Windows.Forms.TextBox();
            this.last_name = new System.Windows.Forms.Label();
            this.lName = new System.Windows.Forms.TextBox();
            this.first_name = new System.Windows.Forms.Label();
            this.fName = new System.Windows.Forms.TextBox();
            this.addUserButton = new System.Windows.Forms.Button();
            this.regErrorMsg = new System.Windows.Forms.TextBox();
            this.alLabel = new System.Windows.Forms.Label();
            this.ALINPUT = new System.Windows.Forms.TextBox();
            this.Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RegisterLabel
            // 
            this.RegisterLabel.AutoSize = true;
            this.RegisterLabel.Font = new System.Drawing.Font("Arial", 50F);
            this.RegisterLabel.Location = new System.Drawing.Point(529, 27);
            this.RegisterLabel.Name = "RegisterLabel";
            this.RegisterLabel.Size = new System.Drawing.Size(555, 94);
            this.RegisterLabel.TabIndex = 0;
            this.RegisterLabel.Text = "Register User";
            this.RegisterLabel.Click += new System.EventHandler(this.RegisterLabel_Click);
            // 
            // username
            // 
            this.username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.username.Font = new System.Drawing.Font("Arial", 14F);
            this.username.Location = new System.Drawing.Point(593, 329);
            this.username.Multiline = true;
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(300, 30);
            this.username.TabIndex = 1;
            // 
            // usernamelabel
            // 
            this.usernamelabel.AutoSize = true;
            this.usernamelabel.Font = new System.Drawing.Font("Arial", 14F);
            this.usernamelabel.Location = new System.Drawing.Point(593, 289);
            this.usernamelabel.Name = "usernamelabel";
            this.usernamelabel.Size = new System.Drawing.Size(122, 27);
            this.usernamelabel.TabIndex = 2;
            this.usernamelabel.Text = "Username";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Arial", 14F);
            this.emailLabel.Location = new System.Drawing.Point(956, 168);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(72, 27);
            this.emailLabel.TabIndex = 4;
            this.emailLabel.Text = "Email";
            // 
            // email
            // 
            this.email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.email.Font = new System.Drawing.Font("Arial", 14F);
            this.email.Location = new System.Drawing.Point(956, 208);
            this.email.Multiline = true;
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(300, 30);
            this.email.TabIndex = 3;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Arial", 14F);
            this.password.Location = new System.Drawing.Point(956, 289);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(117, 27);
            this.password.TabIndex = 6;
            this.password.Text = "Password";
            // 
            // regpass
            // 
            this.regpass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.regpass.Font = new System.Drawing.Font("Arial", 14F);
            this.regpass.Location = new System.Drawing.Point(956, 329);
            this.regpass.Multiline = true;
            this.regpass.Name = "regpass";
            this.regpass.PasswordChar = '*';
            this.regpass.Size = new System.Drawing.Size(300, 30);
            this.regpass.TabIndex = 5;
            // 
            // conpass
            // 
            this.conpass.AutoSize = true;
            this.conpass.Font = new System.Drawing.Font("Arial", 14F);
            this.conpass.Location = new System.Drawing.Point(956, 401);
            this.conpass.Name = "conpass";
            this.conpass.Size = new System.Drawing.Size(208, 27);
            this.conpass.TabIndex = 8;
            this.conpass.Text = "Confirm Password";
            // 
            // regconpass
            // 
            this.regconpass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.regconpass.Font = new System.Drawing.Font("Arial", 14F);
            this.regconpass.Location = new System.Drawing.Point(956, 450);
            this.regconpass.Multiline = true;
            this.regconpass.Name = "regconpass";
            this.regconpass.PasswordChar = '*';
            this.regconpass.Size = new System.Drawing.Size(300, 30);
            this.regconpass.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F);
            this.label1.Location = new System.Drawing.Point(593, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 27);
            this.label1.TabIndex = 16;
            this.label1.Text = "Employee ID";
            // 
            // eID
            // 
            this.eID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eID.Font = new System.Drawing.Font("Arial", 14F);
            this.eID.Location = new System.Drawing.Point(593, 208);
            this.eID.Multiline = true;
            this.eID.Name = "eID";
            this.eID.Size = new System.Drawing.Size(300, 30);
            this.eID.TabIndex = 15;
            // 
            // middle_name
            // 
            this.middle_name.AutoSize = true;
            this.middle_name.Font = new System.Drawing.Font("Arial", 14F);
            this.middle_name.Location = new System.Drawing.Point(240, 411);
            this.middle_name.Name = "middle_name";
            this.middle_name.Size = new System.Drawing.Size(153, 27);
            this.middle_name.TabIndex = 14;
            this.middle_name.Text = "Middle Name";
            this.middle_name.Click += new System.EventHandler(this.middle_name_Click);
            // 
            // mName
            // 
            this.mName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mName.Font = new System.Drawing.Font("Arial", 14F);
            this.mName.Location = new System.Drawing.Point(240, 450);
            this.mName.Multiline = true;
            this.mName.Name = "mName";
            this.mName.Size = new System.Drawing.Size(300, 30);
            this.mName.TabIndex = 13;
            this.mName.TextChanged += new System.EventHandler(this.mName_TextChanged);
            // 
            // last_name
            // 
            this.last_name.AutoSize = true;
            this.last_name.Font = new System.Drawing.Font("Arial", 14F);
            this.last_name.Location = new System.Drawing.Point(240, 290);
            this.last_name.Name = "last_name";
            this.last_name.Size = new System.Drawing.Size(127, 27);
            this.last_name.TabIndex = 12;
            this.last_name.Text = "Last Name";
            this.last_name.Click += new System.EventHandler(this.last_name_Click);
            // 
            // lName
            // 
            this.lName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lName.Font = new System.Drawing.Font("Arial", 14F);
            this.lName.Location = new System.Drawing.Point(245, 329);
            this.lName.Multiline = true;
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(300, 30);
            this.lName.TabIndex = 11;
            this.lName.TextChanged += new System.EventHandler(this.lName_TextChanged);
            // 
            // first_name
            // 
            this.first_name.AutoSize = true;
            this.first_name.Font = new System.Drawing.Font("Arial", 14F);
            this.first_name.Location = new System.Drawing.Point(240, 178);
            this.first_name.Name = "first_name";
            this.first_name.Size = new System.Drawing.Size(129, 27);
            this.first_name.TabIndex = 10;
            this.first_name.Text = "First Name";
            this.first_name.Click += new System.EventHandler(this.first_name_Click);
            // 
            // fName
            // 
            this.fName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fName.Font = new System.Drawing.Font("Arial", 14F);
            this.fName.Location = new System.Drawing.Point(240, 208);
            this.fName.Multiline = true;
            this.fName.Name = "fName";
            this.fName.Size = new System.Drawing.Size(300, 30);
            this.fName.TabIndex = 9;
            this.fName.TextChanged += new System.EventHandler(this.fName_TextChanged);
            // 
            // addUserButton
            // 
            this.addUserButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.addUserButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.addUserButton.FlatAppearance.BorderSize = 4;
            this.addUserButton.Font = new System.Drawing.Font("Arial Narrow", 18F);
            this.addUserButton.ForeColor = System.Drawing.Color.Black;
            this.addUserButton.Location = new System.Drawing.Point(657, 511);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(191, 61);
            this.addUserButton.TabIndex = 17;
            this.addUserButton.Text = "Register";
            this.addUserButton.UseVisualStyleBackColor = false;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // regErrorMsg
            // 
            this.regErrorMsg.BackColor = System.Drawing.SystemColors.ControlLight;
            this.regErrorMsg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.regErrorMsg.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.regErrorMsg.Location = new System.Drawing.Point(489, 578);
            this.regErrorMsg.Multiline = true;
            this.regErrorMsg.Name = "regErrorMsg";
            this.regErrorMsg.Size = new System.Drawing.Size(562, 109);
            this.regErrorMsg.TabIndex = 18;
            // 
            // alLabel
            // 
            this.alLabel.AutoSize = true;
            this.alLabel.Font = new System.Drawing.Font("Arial", 14F);
            this.alLabel.Location = new System.Drawing.Point(593, 410);
            this.alLabel.Name = "alLabel";
            this.alLabel.Size = new System.Drawing.Size(151, 27);
            this.alLabel.TabIndex = 20;
            this.alLabel.Text = "Access Level";
            this.alLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // ALINPUT
            // 
            this.ALINPUT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ALINPUT.Font = new System.Drawing.Font("Arial", 14F);
            this.ALINPUT.Location = new System.Drawing.Point(593, 450);
            this.ALINPUT.Multiline = true;
            this.ALINPUT.Name = "ALINPUT";
            this.ALINPUT.Size = new System.Drawing.Size(300, 30);
            this.ALINPUT.TabIndex = 19;
            this.ALINPUT.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Back.Font = new System.Drawing.Font("Arial", 15.2F);
            this.Back.Location = new System.Drawing.Point(12, 12);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(151, 58);
            this.Back.TabIndex = 21;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // HRMSRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1350, 747);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.alLabel);
            this.Controls.Add(this.ALINPUT);
            this.Controls.Add(this.regErrorMsg);
            this.Controls.Add(this.addUserButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.eID);
            this.Controls.Add(this.middle_name);
            this.Controls.Add(this.mName);
            this.Controls.Add(this.last_name);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.first_name);
            this.Controls.Add(this.fName);
            this.Controls.Add(this.conpass);
            this.Controls.Add(this.regconpass);
            this.Controls.Add(this.password);
            this.Controls.Add(this.regpass);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.email);
            this.Controls.Add(this.usernamelabel);
            this.Controls.Add(this.username);
            this.Controls.Add(this.RegisterLabel);
            this.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "HRMSRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Human Resource Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.HRMSRegister_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RegisterLabel;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label usernamelabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox regpass;
        private System.Windows.Forms.Label conpass;
        private System.Windows.Forms.TextBox regconpass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox eID;
        private System.Windows.Forms.Label middle_name;
        private System.Windows.Forms.TextBox mName;
        private System.Windows.Forms.Label last_name;
        private System.Windows.Forms.TextBox lName;
        private System.Windows.Forms.Label first_name;
        private System.Windows.Forms.TextBox fName;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.TextBox regErrorMsg;
        private System.Windows.Forms.Label alLabel;
        private System.Windows.Forms.TextBox ALINPUT;
        private System.Windows.Forms.Button Back;
    }
}