namespace HRMS.View.UI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.activityPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.employeelist = new System.Windows.Forms.Button();
            this.orgchart = new System.Windows.Forms.Button();
            this.randr = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MemCirc = new System.Windows.Forms.Button();
            this.recruitment = new System.Windows.Forms.Button();
            this.IncidentBtn = new System.Windows.Forms.Button();
            this.feedback = new System.Windows.Forms.Button();
            this.appraisal = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // activityPanel
            // 
            this.activityPanel.BackColor = System.Drawing.Color.White;
            this.activityPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.activityPanel.Location = new System.Drawing.Point(0, 0);
            this.activityPanel.Margin = new System.Windows.Forms.Padding(2);
            this.activityPanel.Name = "activityPanel";
            this.activityPanel.Size = new System.Drawing.Size(1028, 609);
            this.activityPanel.TabIndex = 28;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.employeelist);
            this.panel1.Controls.Add(this.orgchart);
            this.panel1.Controls.Add(this.randr);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.MemCirc);
            this.panel1.Controls.Add(this.recruitment);
            this.panel1.Controls.Add(this.IncidentBtn);
            this.panel1.Controls.Add(this.feedback);
            this.panel1.Controls.Add(this.appraisal);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 609);
            this.panel1.TabIndex = 29;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.logoutBtn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 539);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(248, 70);
            this.panel3.TabIndex = 0;
            // 
            // logoutBtn
            // 
            this.logoutBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logoutBtn.BackColor = System.Drawing.Color.Transparent;
            this.logoutBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logoutBtn.BackgroundImage")));
            this.logoutBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logoutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutBtn.FlatAppearance.BorderSize = 0;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.Location = new System.Drawing.Point(111, 21);
            this.logoutBtn.Margin = new System.Windows.Forms.Padding(2);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(32, 30);
            this.logoutBtn.TabIndex = 0;
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // employeelist
            // 
            this.employeelist.BackColor = System.Drawing.Color.SteelBlue;
            this.employeelist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.employeelist.FlatAppearance.BorderSize = 0;
            this.employeelist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employeelist.Font = new System.Drawing.Font("Franklin Gothic Book", 12F);
            this.employeelist.ForeColor = System.Drawing.Color.White;
            this.employeelist.Location = new System.Drawing.Point(17, 400);
            this.employeelist.Margin = new System.Windows.Forms.Padding(2);
            this.employeelist.Name = "employeelist";
            this.employeelist.Size = new System.Drawing.Size(212, 36);
            this.employeelist.TabIndex = 34;
            this.employeelist.Text = "Employee List";
            this.employeelist.UseVisualStyleBackColor = false;
            this.employeelist.Click += new System.EventHandler(this.employeelist_Click);
            // 
            // orgchart
            // 
            this.orgchart.BackColor = System.Drawing.Color.SteelBlue;
            this.orgchart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.orgchart.FlatAppearance.BorderSize = 0;
            this.orgchart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orgchart.Font = new System.Drawing.Font("Franklin Gothic Book", 12F);
            this.orgchart.ForeColor = System.Drawing.Color.White;
            this.orgchart.Location = new System.Drawing.Point(17, 448);
            this.orgchart.Margin = new System.Windows.Forms.Padding(2);
            this.orgchart.Name = "orgchart";
            this.orgchart.Size = new System.Drawing.Size(212, 36);
            this.orgchart.TabIndex = 37;
            this.orgchart.Text = "Organizational Chart";
            this.orgchart.UseVisualStyleBackColor = false;
            this.orgchart.Click += new System.EventHandler(this.orgchart_Click);
            // 
            // randr
            // 
            this.randr.BackColor = System.Drawing.Color.SteelBlue;
            this.randr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.randr.FlatAppearance.BorderSize = 0;
            this.randr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.randr.Font = new System.Drawing.Font("Franklin Gothic Book", 10F);
            this.randr.ForeColor = System.Drawing.Color.White;
            this.randr.Location = new System.Drawing.Point(17, 495);
            this.randr.Margin = new System.Windows.Forms.Padding(2);
            this.randr.Name = "randr";
            this.randr.Size = new System.Drawing.Size(212, 36);
            this.randr.TabIndex = 36;
            this.randr.Text = "Company Rules and Regulations";
            this.randr.UseVisualStyleBackColor = false;
            this.randr.Click += new System.EventHandler(this.randr_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(17, 21);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(212, 126);
            this.panel2.TabIndex = 28;
            // 
            // MemCirc
            // 
            this.MemCirc.BackColor = System.Drawing.Color.SteelBlue;
            this.MemCirc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MemCirc.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.MemCirc.FlatAppearance.BorderSize = 0;
            this.MemCirc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MemCirc.Font = new System.Drawing.Font("Franklin Gothic Book", 12F);
            this.MemCirc.ForeColor = System.Drawing.Color.White;
            this.MemCirc.Location = new System.Drawing.Point(17, 156);
            this.MemCirc.Margin = new System.Windows.Forms.Padding(2);
            this.MemCirc.Name = "MemCirc";
            this.MemCirc.Size = new System.Drawing.Size(212, 36);
            this.MemCirc.TabIndex = 33;
            this.MemCirc.Text = "Memorandum Circular";
            this.MemCirc.UseVisualStyleBackColor = false;
            this.MemCirc.Click += new System.EventHandler(this.MemCirc_Click);
            // 
            // recruitment
            // 
            this.recruitment.BackColor = System.Drawing.Color.SteelBlue;
            this.recruitment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.recruitment.FlatAppearance.BorderSize = 0;
            this.recruitment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.recruitment.Font = new System.Drawing.Font("Franklin Gothic Book", 12F);
            this.recruitment.ForeColor = System.Drawing.Color.White;
            this.recruitment.Location = new System.Drawing.Point(17, 205);
            this.recruitment.Margin = new System.Windows.Forms.Padding(2);
            this.recruitment.Name = "recruitment";
            this.recruitment.Size = new System.Drawing.Size(212, 36);
            this.recruitment.TabIndex = 39;
            this.recruitment.Text = "Recruitment";
            this.recruitment.UseVisualStyleBackColor = false;
            this.recruitment.Click += new System.EventHandler(this.recruitment_Click);
            // 
            // IncidentBtn
            // 
            this.IncidentBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.IncidentBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IncidentBtn.FlatAppearance.BorderSize = 0;
            this.IncidentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IncidentBtn.Font = new System.Drawing.Font("Franklin Gothic Book", 12F);
            this.IncidentBtn.ForeColor = System.Drawing.Color.White;
            this.IncidentBtn.Location = new System.Drawing.Point(17, 303);
            this.IncidentBtn.Margin = new System.Windows.Forms.Padding(2);
            this.IncidentBtn.Name = "IncidentBtn";
            this.IncidentBtn.Size = new System.Drawing.Size(212, 36);
            this.IncidentBtn.TabIndex = 38;
            this.IncidentBtn.Text = "Incident Report";
            this.IncidentBtn.UseVisualStyleBackColor = false;
            this.IncidentBtn.Click += new System.EventHandler(this.IncidentBtn_Click);
            // 
            // feedback
            // 
            this.feedback.BackColor = System.Drawing.Color.SteelBlue;
            this.feedback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.feedback.FlatAppearance.BorderSize = 0;
            this.feedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.feedback.Font = new System.Drawing.Font("Franklin Gothic Book", 12F);
            this.feedback.ForeColor = System.Drawing.Color.White;
            this.feedback.Location = new System.Drawing.Point(17, 351);
            this.feedback.Margin = new System.Windows.Forms.Padding(2);
            this.feedback.Name = "feedback";
            this.feedback.Size = new System.Drawing.Size(212, 36);
            this.feedback.TabIndex = 35;
            this.feedback.Text = "Information Feedback";
            this.feedback.UseVisualStyleBackColor = false;
            this.feedback.Click += new System.EventHandler(this.feedback_Click);
            // 
            // appraisal
            // 
            this.appraisal.BackColor = System.Drawing.Color.SteelBlue;
            this.appraisal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.appraisal.FlatAppearance.BorderSize = 0;
            this.appraisal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.appraisal.Font = new System.Drawing.Font("Franklin Gothic Book", 12F);
            this.appraisal.ForeColor = System.Drawing.Color.White;
            this.appraisal.Location = new System.Drawing.Point(17, 254);
            this.appraisal.Margin = new System.Windows.Forms.Padding(2);
            this.appraisal.Name = "appraisal";
            this.appraisal.Size = new System.Drawing.Size(212, 36);
            this.appraisal.TabIndex = 40;
            this.appraisal.Text = "Performance Appraisal";
            this.appraisal.UseVisualStyleBackColor = false;
            this.appraisal.Click += new System.EventHandler(this.appraisal_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 609);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.activityPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel activityPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button employeelist;
        private System.Windows.Forms.Button orgchart;
        private System.Windows.Forms.Button randr;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button MemCirc;
        private System.Windows.Forms.Button recruitment;
        private System.Windows.Forms.Button IncidentBtn;
        private System.Windows.Forms.Button feedback;
        private System.Windows.Forms.Button appraisal;
        private System.Windows.Forms.Panel panel3;
    }
}