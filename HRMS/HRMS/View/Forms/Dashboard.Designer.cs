namespace HRMS.View
{
    partial class Dashboard
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
            this.SideBar = new System.Windows.Forms.FlowLayoutPanel();
            this.logopanel = new System.Windows.Forms.Panel();
            this.Company = new System.Windows.Forms.Label();
            this.appraisal = new System.Windows.Forms.Button();
            this.personnel = new System.Windows.Forms.Button();
            this.repmanagement = new System.Windows.Forms.Button();
            this.jobdesc = new System.Windows.Forms.Button();
            this.RuleButton = new System.Windows.Forms.Button();
            this.feedback = new System.Windows.Forms.Button();
            this.Incidents = new System.Windows.Forms.Button();
            this.orgchart = new System.Windows.Forms.Button();
            this.memorandum = new System.Windows.Forms.Button();
            this.Logout = new System.Windows.Forms.Button();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.SideBar.SuspendLayout();
            this.logopanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SideBar
            // 
            this.SideBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SideBar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.SideBar.Controls.Add(this.logopanel);
            this.SideBar.Controls.Add(this.appraisal);
            this.SideBar.Controls.Add(this.personnel);
            this.SideBar.Controls.Add(this.repmanagement);
            this.SideBar.Controls.Add(this.jobdesc);
            this.SideBar.Controls.Add(this.RuleButton);
            this.SideBar.Controls.Add(this.feedback);
            this.SideBar.Controls.Add(this.Incidents);
            this.SideBar.Controls.Add(this.orgchart);
            this.SideBar.Controls.Add(this.memorandum);
            this.SideBar.Controls.Add(this.Logout);
            this.SideBar.Font = new System.Drawing.Font("Arial", 12F);
            this.SideBar.Location = new System.Drawing.Point(2, 3);
            this.SideBar.Margin = new System.Windows.Forms.Padding(2);
            this.SideBar.Name = "SideBar";
            this.SideBar.Size = new System.Drawing.Size(219, 600);
            this.SideBar.TabIndex = 3;
            // 
            // logopanel
            // 
            this.logopanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.logopanel.Controls.Add(this.Company);
            this.logopanel.Location = new System.Drawing.Point(2, 2);
            this.logopanel.Margin = new System.Windows.Forms.Padding(2);
            this.logopanel.Name = "logopanel";
            this.logopanel.Size = new System.Drawing.Size(217, 85);
            this.logopanel.TabIndex = 4;
            // 
            // Company
            // 
            this.Company.AutoSize = true;
            this.Company.Font = new System.Drawing.Font("Bernard MT Condensed", 30F, System.Drawing.FontStyle.Italic);
            this.Company.Location = new System.Drawing.Point(2, 20);
            this.Company.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Company.Name = "Company";
            this.Company.Size = new System.Drawing.Size(217, 47);
            this.Company.TabIndex = 3;
            this.Company.Text = "Michel Andre";
            this.Company.Click += new System.EventHandler(this.Company_Click);
            // 
            // appraisal
            // 
            this.appraisal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.appraisal.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.appraisal.Font = new System.Drawing.Font("Arial", 12F);
            this.appraisal.Location = new System.Drawing.Point(2, 91);
            this.appraisal.Margin = new System.Windows.Forms.Padding(2);
            this.appraisal.Name = "appraisal";
            this.appraisal.Size = new System.Drawing.Size(211, 41);
            this.appraisal.TabIndex = 10;
            this.appraisal.Text = "Performance Appraisal";
            this.appraisal.UseVisualStyleBackColor = false;
            // 
            // personnel
            // 
            this.personnel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.personnel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.personnel.Font = new System.Drawing.Font("Arial", 12F);
            this.personnel.Location = new System.Drawing.Point(2, 136);
            this.personnel.Margin = new System.Windows.Forms.Padding(2);
            this.personnel.Name = "personnel";
            this.personnel.Size = new System.Drawing.Size(211, 41);
            this.personnel.TabIndex = 15;
            this.personnel.Text = "Personnel Action";
            this.personnel.UseVisualStyleBackColor = false;
            // 
            // repmanagement
            // 
            this.repmanagement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.repmanagement.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.repmanagement.Font = new System.Drawing.Font("Arial", 12F);
            this.repmanagement.Location = new System.Drawing.Point(2, 181);
            this.repmanagement.Margin = new System.Windows.Forms.Padding(2);
            this.repmanagement.Name = "repmanagement";
            this.repmanagement.Size = new System.Drawing.Size(211, 41);
            this.repmanagement.TabIndex = 14;
            this.repmanagement.Text = "Report Management";
            this.repmanagement.UseVisualStyleBackColor = false;
            // 
            // jobdesc
            // 
            this.jobdesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.jobdesc.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.jobdesc.Font = new System.Drawing.Font("Arial", 12F);
            this.jobdesc.Location = new System.Drawing.Point(2, 226);
            this.jobdesc.Margin = new System.Windows.Forms.Padding(2);
            this.jobdesc.Name = "jobdesc";
            this.jobdesc.Size = new System.Drawing.Size(211, 41);
            this.jobdesc.TabIndex = 16;
            this.jobdesc.Text = "Job Description";
            this.jobdesc.UseVisualStyleBackColor = false;
            // 
            // RuleButton
            // 
            this.RuleButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RuleButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.RuleButton.Font = new System.Drawing.Font("Arial", 10F);
            this.RuleButton.Location = new System.Drawing.Point(2, 271);
            this.RuleButton.Margin = new System.Windows.Forms.Padding(2);
            this.RuleButton.Name = "RuleButton";
            this.RuleButton.Size = new System.Drawing.Size(211, 41);
            this.RuleButton.TabIndex = 8;
            this.RuleButton.Text = "Company Rules and Regulations";
            this.RuleButton.UseVisualStyleBackColor = false;
            this.RuleButton.Click += new System.EventHandler(this.RuleButton_Click);
            // 
            // feedback
            // 
            this.feedback.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.feedback.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.feedback.Font = new System.Drawing.Font("Arial", 12F);
            this.feedback.Location = new System.Drawing.Point(2, 316);
            this.feedback.Margin = new System.Windows.Forms.Padding(2);
            this.feedback.Name = "feedback";
            this.feedback.Size = new System.Drawing.Size(211, 41);
            this.feedback.TabIndex = 17;
            this.feedback.Text = "Information Feedback Form";
            this.feedback.UseVisualStyleBackColor = false;
            // 
            // Incidents
            // 
            this.Incidents.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Incidents.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Incidents.Font = new System.Drawing.Font("Arial", 12F);
            this.Incidents.Location = new System.Drawing.Point(2, 361);
            this.Incidents.Margin = new System.Windows.Forms.Padding(2);
            this.Incidents.Name = "Incidents";
            this.Incidents.Size = new System.Drawing.Size(211, 41);
            this.Incidents.TabIndex = 11;
            this.Incidents.Text = "Incident Reports";
            this.Incidents.UseVisualStyleBackColor = false;
            this.Incidents.Click += new System.EventHandler(this.Incidents_Click);
            // 
            // orgchart
            // 
            this.orgchart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.orgchart.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.orgchart.Font = new System.Drawing.Font("Arial", 12F);
            this.orgchart.Location = new System.Drawing.Point(2, 406);
            this.orgchart.Margin = new System.Windows.Forms.Padding(2);
            this.orgchart.Name = "orgchart";
            this.orgchart.Size = new System.Drawing.Size(211, 41);
            this.orgchart.TabIndex = 12;
            this.orgchart.Text = "Organizational Chart";
            this.orgchart.UseVisualStyleBackColor = false;
            this.orgchart.Click += new System.EventHandler(this.Orgchart_Click);
            // 
            // memorandum
            // 
            this.memorandum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.memorandum.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.memorandum.Font = new System.Drawing.Font("Arial", 12F);
            this.memorandum.Location = new System.Drawing.Point(2, 451);
            this.memorandum.Margin = new System.Windows.Forms.Padding(2);
            this.memorandum.Name = "memorandum";
            this.memorandum.Size = new System.Drawing.Size(211, 41);
            this.memorandum.TabIndex = 13;
            this.memorandum.Text = "Memorandum Circulars";
            this.memorandum.UseVisualStyleBackColor = false;
            this.memorandum.Click += new System.EventHandler(this.memorandum_Click);
            // 
            // Logout
            // 
            this.Logout.BackColor = System.Drawing.Color.Red;
            this.Logout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Logout.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.Logout.Location = new System.Drawing.Point(2, 496);
            this.Logout.Margin = new System.Windows.Forms.Padding(2);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(211, 57);
            this.Logout.TabIndex = 19;
            this.Logout.Text = "Logout";
            this.Logout.UseVisualStyleBackColor = false;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // mainpanel
            // 
            this.mainpanel.AutoSize = true;
            this.mainpanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mainpanel.Location = new System.Drawing.Point(219, 3);
            this.mainpanel.Margin = new System.Windows.Forms.Padding(2);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(0, 0);
            this.mainpanel.TabIndex = 4;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1028, 555);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.SideBar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Human Resource Management System - Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.SideBar.ResumeLayout(false);
            this.logopanel.ResumeLayout(false);
            this.logopanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel SideBar;
        private System.Windows.Forms.Label Company;
        private System.Windows.Forms.Panel logopanel;
        private System.Windows.Forms.Button appraisal;
        private System.Windows.Forms.Button personnel;
        private System.Windows.Forms.Button repmanagement;
        private System.Windows.Forms.Button jobdesc;
        private System.Windows.Forms.Button RuleButton;
        private System.Windows.Forms.Button feedback;
        private System.Windows.Forms.Button Incidents;
        private System.Windows.Forms.Button orgchart;
        private System.Windows.Forms.Button memorandum;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Panel mainpanel;
    }
}