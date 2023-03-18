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
            this.ActivityPanel = new System.Windows.Forms.Panel();
            this.Logout = new System.Windows.Forms.Button();
            this.Incidents = new System.Windows.Forms.Button();
            this.RuleButton = new System.Windows.Forms.Button();
            this.employeeButton = new System.Windows.Forms.Button();
            this.SideBar = new System.Windows.Forms.FlowLayoutPanel();
            this.logopanel = new System.Windows.Forms.Panel();
            this.Company = new System.Windows.Forms.Label();
            this.filler = new System.Windows.Forms.Panel();
            this.SideBar.SuspendLayout();
            this.logopanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ActivityPanel
            // 
            this.ActivityPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ActivityPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ActivityPanel.Location = new System.Drawing.Point(292, 1);
            this.ActivityPanel.Name = "ActivityPanel";
            this.ActivityPanel.Size = new System.Drawing.Size(1057, 746);
            this.ActivityPanel.TabIndex = 4;
            // 
            // Logout
            // 
            this.Logout.BackColor = System.Drawing.Color.Red;
            this.Logout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Logout.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.Logout.Location = new System.Drawing.Point(3, 688);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(281, 53);
            this.Logout.TabIndex = 0;
            this.Logout.Text = "Logout";
            this.Logout.UseVisualStyleBackColor = false;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // Incidents
            // 
            this.Incidents.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Incidents.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Incidents.Font = new System.Drawing.Font("Arial", 12F);
            this.Incidents.Location = new System.Drawing.Point(3, 114);
            this.Incidents.Name = "Incidents";
            this.Incidents.Size = new System.Drawing.Size(281, 50);
            this.Incidents.TabIndex = 2;
            this.Incidents.Text = "Incident Reports";
            this.Incidents.UseVisualStyleBackColor = false;
            this.Incidents.Click += new System.EventHandler(this.Incidents_Click_1);
            // 
            // RuleButton
            // 
            this.RuleButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RuleButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.RuleButton.Font = new System.Drawing.Font("Arial", 10F);
            this.RuleButton.Location = new System.Drawing.Point(3, 170);
            this.RuleButton.Name = "RuleButton";
            this.RuleButton.Size = new System.Drawing.Size(281, 50);
            this.RuleButton.TabIndex = 1;
            this.RuleButton.Text = "Company Rules and Regulations";
            this.RuleButton.UseVisualStyleBackColor = false;
            this.RuleButton.Click += new System.EventHandler(this.RuleButton_Click);
            // 
            // employeeButton
            // 
            this.employeeButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.employeeButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.employeeButton.Font = new System.Drawing.Font("Arial", 12F);
            this.employeeButton.Location = new System.Drawing.Point(3, 226);
            this.employeeButton.Name = "employeeButton";
            this.employeeButton.Size = new System.Drawing.Size(281, 50);
            this.employeeButton.TabIndex = 1;
            this.employeeButton.Text = "Employee List";
            this.employeeButton.UseVisualStyleBackColor = false;
            this.employeeButton.Click += new System.EventHandler(this.employeeButton_Click);
            // 
            // SideBar
            // 
            this.SideBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SideBar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.SideBar.Controls.Add(this.logopanel);
            this.SideBar.Controls.Add(this.Incidents);
            this.SideBar.Controls.Add(this.RuleButton);
            this.SideBar.Controls.Add(this.employeeButton);
            this.SideBar.Controls.Add(this.filler);
            this.SideBar.Controls.Add(this.Logout);
            this.SideBar.Font = new System.Drawing.Font("Arial", 12F);
            this.SideBar.Location = new System.Drawing.Point(2, 4);
            this.SideBar.Name = "SideBar";
            this.SideBar.Size = new System.Drawing.Size(292, 743);
            this.SideBar.TabIndex = 3;
            // 
            // logopanel
            // 
            this.logopanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.logopanel.Controls.Add(this.Company);
            this.logopanel.Location = new System.Drawing.Point(3, 3);
            this.logopanel.Name = "logopanel";
            this.logopanel.Size = new System.Drawing.Size(289, 105);
            this.logopanel.TabIndex = 4;
            // 
            // Company
            // 
            this.Company.AutoSize = true;
            this.Company.Font = new System.Drawing.Font("Bernard MT Condensed", 30F, System.Drawing.FontStyle.Italic);
            this.Company.Location = new System.Drawing.Point(3, 24);
            this.Company.Name = "Company";
            this.Company.Size = new System.Drawing.Size(269, 58);
            this.Company.TabIndex = 3;
            this.Company.Text = "Michel Andre";
            this.Company.Click += new System.EventHandler(this.Company_Click);
            // 
            // filler
            // 
            this.filler.BackColor = System.Drawing.SystemColors.ControlDark;
            this.filler.Location = new System.Drawing.Point(3, 282);
            this.filler.Name = "filler";
            this.filler.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.filler.Size = new System.Drawing.Size(276, 400);
            this.filler.TabIndex = 1;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1350, 747);
            this.Controls.Add(this.SideBar);
            this.Controls.Add(this.ActivityPanel);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Human Resource Management Syatem - Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.SideBar.ResumeLayout(false);
            this.logopanel.ResumeLayout(false);
            this.logopanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel ActivityPanel;
        private System.Windows.Forms.Button Incidents;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Button employeeButton;
        private System.Windows.Forms.Button RuleButton;
        private System.Windows.Forms.FlowLayoutPanel SideBar;
        private System.Windows.Forms.Label Company;
        private System.Windows.Forms.Panel logopanel;
        private System.Windows.Forms.Panel filler;
    }
}