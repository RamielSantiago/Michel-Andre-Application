namespace HRMS
{
    partial class HRMSLogin
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
            this.LoginTitle = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.logpass = new System.Windows.Forms.TextBox();
            this.HRMSTM = new System.Windows.Forms.Label();
            this.usernamelabel = new System.Windows.Forms.Label();
            this.passwordlabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.ToRegister = new System.Windows.Forms.Button();
            this.logErrorMsg = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LoginTitle
            // 
            this.LoginTitle.AutoSize = true;
            this.LoginTitle.Font = new System.Drawing.Font("Arial", 65F);
            this.LoginTitle.Location = new System.Drawing.Point(659, 70);
            this.LoginTitle.Name = "LoginTitle";
            this.LoginTitle.Size = new System.Drawing.Size(320, 122);
            this.LoginTitle.TabIndex = 0;
            this.LoginTitle.Text = "Login";
            this.LoginTitle.Click += new System.EventHandler(this.LoginTitle_Click);
            // 
            // username
            // 
            this.username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.username.Location = new System.Drawing.Point(539, 264);
            this.username.Multiline = true;
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(500, 30);
            this.username.TabIndex = 5;
            // 
            // logpass
            // 
            this.logpass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logpass.Location = new System.Drawing.Point(539, 428);
            this.logpass.Multiline = true;
            this.logpass.Name = "logpass";
            this.logpass.Size = new System.Drawing.Size(500, 30);
            this.logpass.TabIndex = 6;
            // 
            // HRMSTM
            // 
            this.HRMSTM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.HRMSTM.AutoSize = true;
            this.HRMSTM.Font = new System.Drawing.Font("Arial", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HRMSTM.Location = new System.Drawing.Point(12, 718);
            this.HRMSTM.Name = "HRMSTM";
            this.HRMSTM.Size = new System.Drawing.Size(414, 20);
            this.HRMSTM.TabIndex = 7;
            this.HRMSTM.Text = "Human Resource Management System - Michel Andre";
            // 
            // usernamelabel
            // 
            this.usernamelabel.AutoSize = true;
            this.usernamelabel.Font = new System.Drawing.Font("Arial", 18F);
            this.usernamelabel.Location = new System.Drawing.Point(543, 217);
            this.usernamelabel.Name = "usernamelabel";
            this.usernamelabel.Size = new System.Drawing.Size(152, 35);
            this.usernamelabel.TabIndex = 8;
            this.usernamelabel.Text = "Username";
            // 
            // passwordlabel
            // 
            this.passwordlabel.AutoSize = true;
            this.passwordlabel.Font = new System.Drawing.Font("Arial", 18F);
            this.passwordlabel.Location = new System.Drawing.Point(550, 372);
            this.passwordlabel.Name = "passwordlabel";
            this.passwordlabel.Size = new System.Drawing.Size(145, 35);
            this.passwordlabel.TabIndex = 9;
            this.passwordlabel.Text = "Password";
            this.passwordlabel.Click += new System.EventHandler(this.passwordlabel_Click);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.loginButton.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Location = new System.Drawing.Point(525, 517);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(249, 67);
            this.loginButton.TabIndex = 10;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ToRegister
            // 
            this.ToRegister.BackColor = System.Drawing.Color.Red;
            this.ToRegister.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold);
            this.ToRegister.Location = new System.Drawing.Point(821, 517);
            this.ToRegister.Name = "ToRegister";
            this.ToRegister.Size = new System.Drawing.Size(249, 67);
            this.ToRegister.TabIndex = 11;
            this.ToRegister.Text = "Register";
            this.ToRegister.UseVisualStyleBackColor = false;
            this.ToRegister.Click += new System.EventHandler(this.ToRegister_Click);
            // 
            // logErrorMsg
            // 
            this.logErrorMsg.BackColor = System.Drawing.SystemColors.ControlLight;
            this.logErrorMsg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logErrorMsg.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.logErrorMsg.Location = new System.Drawing.Point(525, 601);
            this.logErrorMsg.Multiline = true;
            this.logErrorMsg.Name = "logErrorMsg";
            this.logErrorMsg.Size = new System.Drawing.Size(562, 109);
            this.logErrorMsg.TabIndex = 19;
            // 
            // HRMSLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1350, 747);
            this.Controls.Add(this.logErrorMsg);
            this.Controls.Add(this.ToRegister);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordlabel);
            this.Controls.Add(this.usernamelabel);
            this.Controls.Add(this.HRMSTM);
            this.Controls.Add(this.logpass);
            this.Controls.Add(this.username);
            this.Controls.Add(this.LoginTitle);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "HRMSLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Human Resource Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LoginTitle;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox logpass;
        private System.Windows.Forms.Label HRMSTM;
        private System.Windows.Forms.Label usernamelabel;
        private System.Windows.Forms.Label passwordlabel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button ToRegister;
        private System.Windows.Forms.TextBox logErrorMsg;
    }
}

