namespace HRMS
{
    partial class IncidentReport
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
            this.components = new System.ComponentModel.Container();
            this.list = new System.Windows.Forms.TabControl();
            this.viewreports = new System.Windows.Forms.TabPage();
            this.reports = new System.Windows.Forms.DataGridView();
            this.deleterepbutton = new System.Windows.Forms.Button();
            this.updaterepbutton = new System.Windows.Forms.Button();
            this.queryErrorMsg = new System.Windows.Forms.TextBox();
            this.querydetail = new System.Windows.Forms.TextBox();
            this.query = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.filter = new System.Windows.Forms.ComboBox();
            this.newreport = new System.Windows.Forms.TabPage();
            this.addReportButton = new System.Windows.Forms.Button();
            this.repErrorMsg = new System.Windows.Forms.TextBox();
            this.specific = new System.Windows.Forms.TextBox();
            this.solution = new System.Windows.Forms.TextBox();
            this.remark = new System.Windows.Forms.TextBox();
            this.employeeinvolved = new System.Windows.Forms.TextBox();
            this.pen = new System.Windows.Forms.TextBox();
            this.instigate = new System.Windows.Forms.TextBox();
            this.reporterid = new System.Windows.Forms.TextBox();
            this.reportedby = new System.Windows.Forms.TextBox();
            this.iID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.incidenttypelist = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.repoLabel = new System.Windows.Forms.Label();
            this.datePost = new System.Windows.Forms.DateTimePicker();
            this.postLabel = new System.Windows.Forms.Label();
            this.dateOcc = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.hRMSDBDataSet = new HRMS.HRMSDBDataSet();
            this.incidentReportsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.incidentReportsTableAdapter = new HRMS.HRMSDBDataSetTableAdapters.IncidentReportsTableAdapter();
            this.list.SuspendLayout();
            this.viewreports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reports)).BeginInit();
            this.newreport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hRMSDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidentReportsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // list
            // 
            this.list.Controls.Add(this.viewreports);
            this.list.Controls.Add(this.newreport);
            this.list.Font = new System.Drawing.Font("Arial", 12F);
            this.list.Location = new System.Drawing.Point(8, 3);
            this.list.Name = "list";
            this.list.SelectedIndex = 0;
            this.list.Size = new System.Drawing.Size(1221, 802);
            this.list.TabIndex = 25;
            // 
            // viewreports
            // 
            this.viewreports.BackColor = System.Drawing.SystemColors.ControlLight;
            this.viewreports.Controls.Add(this.reports);
            this.viewreports.Controls.Add(this.deleterepbutton);
            this.viewreports.Controls.Add(this.updaterepbutton);
            this.viewreports.Controls.Add(this.queryErrorMsg);
            this.viewreports.Controls.Add(this.querydetail);
            this.viewreports.Controls.Add(this.query);
            this.viewreports.Controls.Add(this.label2);
            this.viewreports.Controls.Add(this.filter);
            this.viewreports.Location = new System.Drawing.Point(4, 32);
            this.viewreports.Name = "viewreports";
            this.viewreports.Padding = new System.Windows.Forms.Padding(3);
            this.viewreports.Size = new System.Drawing.Size(1213, 766);
            this.viewreports.TabIndex = 1;
            this.viewreports.Text = "View Reports";
            // 
            // reports
            // 
            this.reports.AllowUserToAddRows = false;
            this.reports.AllowUserToDeleteRows = false;
            this.reports.AllowUserToResizeColumns = false;
            this.reports.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.reports.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.reports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reports.Location = new System.Drawing.Point(113, 194);
            this.reports.Name = "reports";
            this.reports.RowHeadersWidth = 51;
            this.reports.RowTemplate.Height = 24;
            this.reports.Size = new System.Drawing.Size(991, 548);
            this.reports.TabIndex = 102;
            // 
            // deleterepbutton
            // 
            this.deleterepbutton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.deleterepbutton.Location = new System.Drawing.Point(631, 19);
            this.deleterepbutton.Name = "deleterepbutton";
            this.deleterepbutton.Size = new System.Drawing.Size(144, 41);
            this.deleterepbutton.TabIndex = 101;
            this.deleterepbutton.Text = "Delete";
            this.deleterepbutton.UseVisualStyleBackColor = false;
            this.deleterepbutton.Click += new System.EventHandler(this.deleterepbutton_Click);
            // 
            // updaterepbutton
            // 
            this.updaterepbutton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.updaterepbutton.Location = new System.Drawing.Point(425, 19);
            this.updaterepbutton.Name = "updaterepbutton";
            this.updaterepbutton.Size = new System.Drawing.Size(144, 41);
            this.updaterepbutton.TabIndex = 100;
            this.updaterepbutton.Text = "Update";
            this.updaterepbutton.UseVisualStyleBackColor = false;
            this.updaterepbutton.Click += new System.EventHandler(this.updaterepbutton_Click);
            // 
            // queryErrorMsg
            // 
            this.queryErrorMsg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.queryErrorMsg.BackColor = System.Drawing.SystemColors.ControlLight;
            this.queryErrorMsg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.queryErrorMsg.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.queryErrorMsg.Location = new System.Drawing.Point(425, 66);
            this.queryErrorMsg.Multiline = true;
            this.queryErrorMsg.Name = "queryErrorMsg";
            this.queryErrorMsg.Size = new System.Drawing.Size(383, 58);
            this.queryErrorMsg.TabIndex = 99;
            // 
            // querydetail
            // 
            this.querydetail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.querydetail.Location = new System.Drawing.Point(475, 150);
            this.querydetail.Name = "querydetail";
            this.querydetail.Size = new System.Drawing.Size(473, 30);
            this.querydetail.TabIndex = 97;
            // 
            // query
            // 
            this.query.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.query.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.query.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.query.Font = new System.Drawing.Font("Arial", 10F);
            this.query.Location = new System.Drawing.Point(954, 146);
            this.query.Name = "query";
            this.query.Size = new System.Drawing.Size(150, 31);
            this.query.TabIndex = 98;
            this.query.Text = "Submit";
            this.query.UseVisualStyleBackColor = false;
            this.query.Click += new System.EventHandler(this.query_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14F);
            this.label2.Location = new System.Drawing.Point(108, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 27);
            this.label2.TabIndex = 96;
            this.label2.Text = "Search by:";
            // 
            // filter
            // 
            this.filter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.filter.FormattingEnabled = true;
            this.filter.Items.AddRange(new object[] {
            "Incident ID",
            "Reported By"});
            this.filter.Location = new System.Drawing.Point(242, 148);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(227, 31);
            this.filter.TabIndex = 95;
            // 
            // newreport
            // 
            this.newreport.BackColor = System.Drawing.SystemColors.ControlLight;
            this.newreport.Controls.Add(this.addReportButton);
            this.newreport.Controls.Add(this.repErrorMsg);
            this.newreport.Controls.Add(this.specific);
            this.newreport.Controls.Add(this.solution);
            this.newreport.Controls.Add(this.remark);
            this.newreport.Controls.Add(this.employeeinvolved);
            this.newreport.Controls.Add(this.pen);
            this.newreport.Controls.Add(this.instigate);
            this.newreport.Controls.Add(this.reporterid);
            this.newreport.Controls.Add(this.reportedby);
            this.newreport.Controls.Add(this.iID);
            this.newreport.Controls.Add(this.label12);
            this.newreport.Controls.Add(this.label10);
            this.newreport.Controls.Add(this.label11);
            this.newreport.Controls.Add(this.label7);
            this.newreport.Controls.Add(this.label8);
            this.newreport.Controls.Add(this.label9);
            this.newreport.Controls.Add(this.label5);
            this.newreport.Controls.Add(this.incidenttypelist);
            this.newreport.Controls.Add(this.label6);
            this.newreport.Controls.Add(this.repoLabel);
            this.newreport.Controls.Add(this.datePost);
            this.newreport.Controls.Add(this.postLabel);
            this.newreport.Controls.Add(this.dateOcc);
            this.newreport.Controls.Add(this.label4);
            this.newreport.Controls.Add(this.idLabel);
            this.newreport.Controls.Add(this.label3);
            this.newreport.Location = new System.Drawing.Point(4, 32);
            this.newreport.Name = "newreport";
            this.newreport.Padding = new System.Windows.Forms.Padding(3);
            this.newreport.Size = new System.Drawing.Size(1213, 766);
            this.newreport.TabIndex = 0;
            this.newreport.Text = "Post Incident Report";
            // 
            // addReportButton
            // 
            this.addReportButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addReportButton.BackColor = System.Drawing.Color.LightGreen;
            this.addReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addReportButton.Font = new System.Drawing.Font("Arial", 12F);
            this.addReportButton.Location = new System.Drawing.Point(509, 590);
            this.addReportButton.Name = "addReportButton";
            this.addReportButton.Size = new System.Drawing.Size(216, 65);
            this.addReportButton.TabIndex = 140;
            this.addReportButton.Text = "Post";
            this.addReportButton.UseVisualStyleBackColor = false;
            this.addReportButton.Click += new System.EventHandler(this.addReportButton_Click);
            // 
            // repErrorMsg
            // 
            this.repErrorMsg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.repErrorMsg.BackColor = System.Drawing.SystemColors.ControlLight;
            this.repErrorMsg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.repErrorMsg.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.repErrorMsg.Location = new System.Drawing.Point(731, 576);
            this.repErrorMsg.Multiline = true;
            this.repErrorMsg.Name = "repErrorMsg";
            this.repErrorMsg.Size = new System.Drawing.Size(373, 92);
            this.repErrorMsg.TabIndex = 139;
            this.repErrorMsg.TextChanged += new System.EventHandler(this.repErrorMsg_TextChanged);
            // 
            // specific
            // 
            this.specific.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.specific.Location = new System.Drawing.Point(169, 473);
            this.specific.Multiline = true;
            this.specific.Name = "specific";
            this.specific.Size = new System.Drawing.Size(245, 61);
            this.specific.TabIndex = 138;
            this.specific.TextChanged += new System.EventHandler(this.specific_TextChanged);
            // 
            // solution
            // 
            this.solution.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.solution.Location = new System.Drawing.Point(493, 472);
            this.solution.Multiline = true;
            this.solution.Name = "solution";
            this.solution.Size = new System.Drawing.Size(245, 61);
            this.solution.TabIndex = 136;
            this.solution.TextChanged += new System.EventHandler(this.solution_TextChanged);
            // 
            // remark
            // 
            this.remark.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.remark.Location = new System.Drawing.Point(831, 473);
            this.remark.Multiline = true;
            this.remark.Name = "remark";
            this.remark.Size = new System.Drawing.Size(245, 61);
            this.remark.TabIndex = 134;
            this.remark.TextChanged += new System.EventHandler(this.remark_TextChanged);
            // 
            // employeeinvolved
            // 
            this.employeeinvolved.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.employeeinvolved.Location = new System.Drawing.Point(493, 381);
            this.employeeinvolved.Multiline = true;
            this.employeeinvolved.Name = "employeeinvolved";
            this.employeeinvolved.Size = new System.Drawing.Size(245, 51);
            this.employeeinvolved.TabIndex = 132;
            this.employeeinvolved.TextChanged += new System.EventHandler(this.employeeinvolved_TextChanged);
            // 
            // pen
            // 
            this.pen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pen.Location = new System.Drawing.Point(831, 382);
            this.pen.Name = "pen";
            this.pen.Size = new System.Drawing.Size(245, 30);
            this.pen.TabIndex = 130;
            this.pen.TextChanged += new System.EventHandler(this.pen_TextChanged);
            // 
            // instigate
            // 
            this.instigate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.instigate.Location = new System.Drawing.Point(493, 293);
            this.instigate.Name = "instigate";
            this.instigate.Size = new System.Drawing.Size(245, 30);
            this.instigate.TabIndex = 128;
            this.instigate.TextChanged += new System.EventHandler(this.instigate_TextChanged);
            // 
            // reporterid
            // 
            this.reporterid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.reporterid.Location = new System.Drawing.Point(831, 294);
            this.reporterid.Name = "reporterid";
            this.reporterid.Size = new System.Drawing.Size(245, 30);
            this.reporterid.TabIndex = 124;
            this.reporterid.TextChanged += new System.EventHandler(this.reporterid_TextChanged);
            // 
            // reportedby
            // 
            this.reportedby.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.reportedby.Location = new System.Drawing.Point(831, 210);
            this.reportedby.Name = "reportedby";
            this.reportedby.Size = new System.Drawing.Size(245, 30);
            this.reportedby.TabIndex = 122;
            this.reportedby.TextChanged += new System.EventHandler(this.reportedby_TextChanged);
            // 
            // iID
            // 
            this.iID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iID.Location = new System.Drawing.Point(169, 221);
            this.iID.Name = "iID";
            this.iID.Size = new System.Drawing.Size(245, 30);
            this.iID.TabIndex = 116;
            this.iID.TextChanged += new System.EventHandler(this.iID_TextChanged);
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(165, 446);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 23);
            this.label12.TabIndex = 137;
            this.label12.Text = "Specifics*";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(479, 446);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 23);
            this.label10.TabIndex = 135;
            this.label10.Text = "Solution*";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(827, 447);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 23);
            this.label11.TabIndex = 133;
            this.label11.Text = "Remarks";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(479, 355);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(317, 23);
            this.label7.TabIndex = 131;
            this.label7.Text = "Employees Involved (Last Names)*";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(827, 356);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 23);
            this.label8.TabIndex = 129;
            this.label8.Text = "Penalty*";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(479, 267);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 23);
            this.label9.TabIndex = 127;
            this.label9.Text = "Instigator(s)*";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(479, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 23);
            this.label5.TabIndex = 126;
            this.label5.Text = "Type of Incident*";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // incidenttypelist
            // 
            this.incidenttypelist.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.incidenttypelist.FormattingEnabled = true;
            this.incidenttypelist.Items.AddRange(new object[] {
            "Accident",
            "Criminal",
            "Environment",
            "Financial",
            "Harassment",
            "Personal Complaint",
            ""});
            this.incidenttypelist.Location = new System.Drawing.Point(483, 220);
            this.incidenttypelist.Name = "incidenttypelist";
            this.incidenttypelist.Size = new System.Drawing.Size(255, 31);
            this.incidenttypelist.TabIndex = 125;
            this.incidenttypelist.SelectedIndexChanged += new System.EventHandler(this.incidenttypelist_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(827, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(229, 23);
            this.label6.TabIndex = 123;
            this.label6.Text = "Reporter\'s Employee ID*";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // repoLabel
            // 
            this.repoLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.repoLabel.AutoSize = true;
            this.repoLabel.Location = new System.Drawing.Point(827, 182);
            this.repoLabel.Name = "repoLabel";
            this.repoLabel.Size = new System.Drawing.Size(129, 23);
            this.repoLabel.TabIndex = 121;
            this.repoLabel.Text = "Reported By*";
            this.repoLabel.Click += new System.EventHandler(this.repoLabel_Click);
            // 
            // datePost
            // 
            this.datePost.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.datePost.CalendarMonthBackground = System.Drawing.SystemColors.GradientActiveCaption;
            this.datePost.Location = new System.Drawing.Point(99, 383);
            this.datePost.Name = "datePost";
            this.datePost.Size = new System.Drawing.Size(352, 30);
            this.datePost.TabIndex = 120;
            this.datePost.ValueChanged += new System.EventHandler(this.datePost_ValueChanged);
            // 
            // postLabel
            // 
            this.postLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.postLabel.AutoSize = true;
            this.postLabel.Location = new System.Drawing.Point(165, 356);
            this.postLabel.Name = "postLabel";
            this.postLabel.Size = new System.Drawing.Size(148, 23);
            this.postLabel.TabIndex = 119;
            this.postLabel.Text = "Date Reported*";
            this.postLabel.Click += new System.EventHandler(this.postLabel_Click);
            // 
            // dateOcc
            // 
            this.dateOcc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateOcc.CalendarMonthBackground = System.Drawing.SystemColors.GradientActiveCaption;
            this.dateOcc.Location = new System.Drawing.Point(99, 294);
            this.dateOcc.Name = "dateOcc";
            this.dateOcc.Size = new System.Drawing.Size(352, 30);
            this.dateOcc.TabIndex = 118;
            this.dateOcc.ValueChanged += new System.EventHandler(this.dateOcc_ValueChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(165, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 23);
            this.label4.TabIndex = 117;
            this.label4.Text = "Date Occured*";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // idLabel
            // 
            this.idLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(165, 183);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(112, 23);
            this.idLabel.TabIndex = 115;
            this.idLabel.Text = "Incident ID*";
            this.idLabel.Click += new System.EventHandler(this.idLabel_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 35F);
            this.label3.Location = new System.Drawing.Point(315, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(562, 66);
            this.label3.TabIndex = 114;
            this.label3.Text = "Post Incident Report";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // hRMSDBDataSet
            // 
            this.hRMSDBDataSet.DataSetName = "HRMSDBDataSet";
            this.hRMSDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // incidentReportsBindingSource
            // 
            this.incidentReportsBindingSource.DataMember = "IncidentReports";
            this.incidentReportsBindingSource.DataSource = this.hRMSDBDataSet;
            // 
            // incidentReportsTableAdapter
            // 
            this.incidentReportsTableAdapter.ClearBeforeFill = true;
            // 
            // IncidentReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.list);
            this.Name = "IncidentReport";
            this.Size = new System.Drawing.Size(1232, 808);
            this.list.ResumeLayout(false);
            this.viewreports.ResumeLayout(false);
            this.viewreports.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reports)).EndInit();
            this.newreport.ResumeLayout(false);
            this.newreport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hRMSDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidentReportsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl list;
        private System.Windows.Forms.TabPage viewreports;
        private System.Windows.Forms.TabPage newreport;
        private System.Windows.Forms.Button addReportButton;
        private System.Windows.Forms.TextBox repErrorMsg;
        private System.Windows.Forms.TextBox specific;
        private System.Windows.Forms.TextBox solution;
        private System.Windows.Forms.TextBox remark;
        private System.Windows.Forms.TextBox employeeinvolved;
        private System.Windows.Forms.TextBox pen;
        private System.Windows.Forms.TextBox instigate;
        private System.Windows.Forms.TextBox reporterid;
        private System.Windows.Forms.TextBox reportedby;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox incidenttypelist;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label repoLabel;
        private System.Windows.Forms.DateTimePicker datePost;
        private System.Windows.Forms.Label postLabel;
        private System.Windows.Forms.DateTimePicker dateOcc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button deleterepbutton;
        private System.Windows.Forms.Button updaterepbutton;
        private System.Windows.Forms.TextBox queryErrorMsg;
        private System.Windows.Forms.TextBox querydetail;
        private System.Windows.Forms.Button query;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox filter;
        private System.Windows.Forms.TextBox iID;
        private HRMSDBDataSet hRMSDBDataSet;
        private System.Windows.Forms.BindingSource incidentReportsBindingSource;
        private HRMSDBDataSetTableAdapters.IncidentReportsTableAdapter incidentReportsTableAdapter;
        private System.Windows.Forms.DataGridView reports;
    }
}
