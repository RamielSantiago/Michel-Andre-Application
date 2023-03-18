namespace HRMS.View
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.incidentReportsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hRMSDBDataSet = new HRMS.HRMSDBDataSet();
            this.incidentReportsTableAdapter = new HRMS.HRMSDBDataSetTableAdapters.IncidentReportsTableAdapter();
            this.list = new System.Windows.Forms.TabControl();
            this.viewreports = new System.Windows.Forms.TabPage();
            this.deleteregbutton = new System.Windows.Forms.Button();
            this.updateregbutton = new System.Windows.Forms.Button();
            this.queryErrorMsg = new System.Windows.Forms.TextBox();
            this.query = new System.Windows.Forms.Button();
            this.incidentlist = new System.Windows.Forms.DataGridView();
            this.incidentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOccuredDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datePostedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeesInvolvedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportedByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reporterseIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeOfIncidentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specificsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instigatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.solutionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.penaltyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.querydetail = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.incidentReportsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRMSDBDataSet)).BeginInit();
            this.list.SuspendLayout();
            this.viewreports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.incidentlist)).BeginInit();
            this.newreport.SuspendLayout();
            this.SuspendLayout();
            // 
            // incidentReportsBindingSource
            // 
            this.incidentReportsBindingSource.DataMember = "IncidentReports";
            this.incidentReportsBindingSource.DataSource = this.hRMSDBDataSet;
            // 
            // hRMSDBDataSet
            // 
            this.hRMSDBDataSet.DataSetName = "HRMSDBDataSet";
            this.hRMSDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // incidentReportsTableAdapter
            // 
            this.incidentReportsTableAdapter.ClearBeforeFill = true;
            // 
            // list
            // 
            this.list.Controls.Add(this.viewreports);
            this.list.Controls.Add(this.newreport);
            this.list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list.Font = new System.Drawing.Font("Arial", 12F);
            this.list.Location = new System.Drawing.Point(0, 0);
            this.list.Name = "list";
            this.list.SelectedIndex = 0;
            this.list.Size = new System.Drawing.Size(1350, 747);
            this.list.TabIndex = 24;
            // 
            // viewreports
            // 
            this.viewreports.BackColor = System.Drawing.SystemColors.ControlLight;
            this.viewreports.Controls.Add(this.deleteregbutton);
            this.viewreports.Controls.Add(this.updateregbutton);
            this.viewreports.Controls.Add(this.queryErrorMsg);
            this.viewreports.Controls.Add(this.query);
            this.viewreports.Controls.Add(this.incidentlist);
            this.viewreports.Controls.Add(this.querydetail);
            this.viewreports.Controls.Add(this.label2);
            this.viewreports.Controls.Add(this.filter);
            this.viewreports.Location = new System.Drawing.Point(4, 32);
            this.viewreports.Name = "viewreports";
            this.viewreports.Padding = new System.Windows.Forms.Padding(3);
            this.viewreports.Size = new System.Drawing.Size(1342, 711);
            this.viewreports.TabIndex = 1;
            this.viewreports.Text = "View Reports";
            // 
            // deleteregbutton
            // 
            this.deleteregbutton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.deleteregbutton.Location = new System.Drawing.Point(158, 29);
            this.deleteregbutton.Name = "deleteregbutton";
            this.deleteregbutton.Size = new System.Drawing.Size(144, 41);
            this.deleteregbutton.TabIndex = 92;
            this.deleteregbutton.Text = "Delete";
            this.deleteregbutton.UseVisualStyleBackColor = false;
            // 
            // updateregbutton
            // 
            this.updateregbutton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.updateregbutton.Location = new System.Drawing.Point(8, 29);
            this.updateregbutton.Name = "updateregbutton";
            this.updateregbutton.Size = new System.Drawing.Size(144, 41);
            this.updateregbutton.TabIndex = 91;
            this.updateregbutton.Text = "Update";
            this.updateregbutton.UseVisualStyleBackColor = false;
            // 
            // queryErrorMsg
            // 
            this.queryErrorMsg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.queryErrorMsg.BackColor = System.Drawing.SystemColors.ControlLight;
            this.queryErrorMsg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.queryErrorMsg.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.queryErrorMsg.Location = new System.Drawing.Point(442, 12);
            this.queryErrorMsg.Multiline = true;
            this.queryErrorMsg.Name = "queryErrorMsg";
            this.queryErrorMsg.Size = new System.Drawing.Size(649, 58);
            this.queryErrorMsg.TabIndex = 82;
            // 
            // query
            // 
            this.query.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.query.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.query.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.query.Font = new System.Drawing.Font("Arial", 10F);
            this.query.Location = new System.Drawing.Point(1097, 89);
            this.query.Name = "query";
            this.query.Size = new System.Drawing.Size(150, 31);
            this.query.TabIndex = 4;
            this.query.Text = "Submit";
            this.query.UseVisualStyleBackColor = false;
            // 
            // incidentlist
            // 
            this.incidentlist.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.incidentlist.AutoGenerateColumns = false;
            this.incidentlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.incidentlist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.incidentIDDataGridViewTextBoxColumn,
            this.dateOccuredDataGridViewTextBoxColumn,
            this.datePostedDataGridViewTextBoxColumn,
            this.employeesInvolvedDataGridViewTextBoxColumn,
            this.reportedByDataGridViewTextBoxColumn,
            this.reporterseIDDataGridViewTextBoxColumn,
            this.typeOfIncidentDataGridViewTextBoxColumn,
            this.specificsDataGridViewTextBoxColumn,
            this.instigatorDataGridViewTextBoxColumn,
            this.solutionDataGridViewTextBoxColumn,
            this.penaltyDataGridViewTextBoxColumn,
            this.remarksDataGridViewTextBoxColumn});
            this.incidentlist.DataSource = this.incidentReportsBindingSource;
            this.incidentlist.Location = new System.Drawing.Point(91, 121);
            this.incidentlist.Name = "incidentlist";
            this.incidentlist.RowHeadersWidth = 51;
            this.incidentlist.RowTemplate.Height = 24;
            this.incidentlist.Size = new System.Drawing.Size(1157, 551);
            this.incidentlist.TabIndex = 3;
            // 
            // incidentIDDataGridViewTextBoxColumn
            // 
            this.incidentIDDataGridViewTextBoxColumn.DataPropertyName = "Incident_ID";
            this.incidentIDDataGridViewTextBoxColumn.HeaderText = "Incident_ID";
            this.incidentIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.incidentIDDataGridViewTextBoxColumn.Name = "incidentIDDataGridViewTextBoxColumn";
            this.incidentIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateOccuredDataGridViewTextBoxColumn
            // 
            this.dateOccuredDataGridViewTextBoxColumn.DataPropertyName = "Date_Occured";
            this.dateOccuredDataGridViewTextBoxColumn.HeaderText = "Date_Occured";
            this.dateOccuredDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateOccuredDataGridViewTextBoxColumn.Name = "dateOccuredDataGridViewTextBoxColumn";
            this.dateOccuredDataGridViewTextBoxColumn.Width = 125;
            // 
            // datePostedDataGridViewTextBoxColumn
            // 
            this.datePostedDataGridViewTextBoxColumn.DataPropertyName = "Date_Posted";
            this.datePostedDataGridViewTextBoxColumn.HeaderText = "Date_Posted";
            this.datePostedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datePostedDataGridViewTextBoxColumn.Name = "datePostedDataGridViewTextBoxColumn";
            this.datePostedDataGridViewTextBoxColumn.Width = 125;
            // 
            // employeesInvolvedDataGridViewTextBoxColumn
            // 
            this.employeesInvolvedDataGridViewTextBoxColumn.DataPropertyName = "EmployeesInvolved";
            this.employeesInvolvedDataGridViewTextBoxColumn.HeaderText = "EmployeesInvolved";
            this.employeesInvolvedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.employeesInvolvedDataGridViewTextBoxColumn.Name = "employeesInvolvedDataGridViewTextBoxColumn";
            this.employeesInvolvedDataGridViewTextBoxColumn.Width = 125;
            // 
            // reportedByDataGridViewTextBoxColumn
            // 
            this.reportedByDataGridViewTextBoxColumn.DataPropertyName = "Reported_By";
            this.reportedByDataGridViewTextBoxColumn.HeaderText = "Reported_By";
            this.reportedByDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.reportedByDataGridViewTextBoxColumn.Name = "reportedByDataGridViewTextBoxColumn";
            this.reportedByDataGridViewTextBoxColumn.Width = 125;
            // 
            // reporterseIDDataGridViewTextBoxColumn
            // 
            this.reporterseIDDataGridViewTextBoxColumn.DataPropertyName = "Reporter\'s_eID";
            this.reporterseIDDataGridViewTextBoxColumn.HeaderText = "Reporter\'s_eID";
            this.reporterseIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.reporterseIDDataGridViewTextBoxColumn.Name = "reporterseIDDataGridViewTextBoxColumn";
            this.reporterseIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // typeOfIncidentDataGridViewTextBoxColumn
            // 
            this.typeOfIncidentDataGridViewTextBoxColumn.DataPropertyName = "TypeOfIncident";
            this.typeOfIncidentDataGridViewTextBoxColumn.HeaderText = "TypeOfIncident";
            this.typeOfIncidentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.typeOfIncidentDataGridViewTextBoxColumn.Name = "typeOfIncidentDataGridViewTextBoxColumn";
            this.typeOfIncidentDataGridViewTextBoxColumn.Width = 125;
            // 
            // specificsDataGridViewTextBoxColumn
            // 
            this.specificsDataGridViewTextBoxColumn.DataPropertyName = "Specifics";
            this.specificsDataGridViewTextBoxColumn.HeaderText = "Specifics";
            this.specificsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.specificsDataGridViewTextBoxColumn.Name = "specificsDataGridViewTextBoxColumn";
            this.specificsDataGridViewTextBoxColumn.Width = 125;
            // 
            // instigatorDataGridViewTextBoxColumn
            // 
            this.instigatorDataGridViewTextBoxColumn.DataPropertyName = "Instigator";
            this.instigatorDataGridViewTextBoxColumn.HeaderText = "Instigator";
            this.instigatorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.instigatorDataGridViewTextBoxColumn.Name = "instigatorDataGridViewTextBoxColumn";
            this.instigatorDataGridViewTextBoxColumn.Width = 125;
            // 
            // solutionDataGridViewTextBoxColumn
            // 
            this.solutionDataGridViewTextBoxColumn.DataPropertyName = "Solution";
            this.solutionDataGridViewTextBoxColumn.HeaderText = "Solution";
            this.solutionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.solutionDataGridViewTextBoxColumn.Name = "solutionDataGridViewTextBoxColumn";
            this.solutionDataGridViewTextBoxColumn.Width = 125;
            // 
            // penaltyDataGridViewTextBoxColumn
            // 
            this.penaltyDataGridViewTextBoxColumn.DataPropertyName = "Penalty";
            this.penaltyDataGridViewTextBoxColumn.HeaderText = "Penalty";
            this.penaltyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.penaltyDataGridViewTextBoxColumn.Name = "penaltyDataGridViewTextBoxColumn";
            this.penaltyDataGridViewTextBoxColumn.Width = 125;
            // 
            // remarksDataGridViewTextBoxColumn
            // 
            this.remarksDataGridViewTextBoxColumn.DataPropertyName = "Remarks";
            this.remarksDataGridViewTextBoxColumn.HeaderText = "Remarks";
            this.remarksDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.remarksDataGridViewTextBoxColumn.Name = "remarksDataGridViewTextBoxColumn";
            this.remarksDataGridViewTextBoxColumn.Width = 125;
            // 
            // querydetail
            // 
            this.querydetail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.querydetail.Location = new System.Drawing.Point(442, 91);
            this.querydetail.Name = "querydetail";
            this.querydetail.Size = new System.Drawing.Size(649, 30);
            this.querydetail.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14F);
            this.label2.Location = new System.Drawing.Point(86, 88);
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
            this.filter.Location = new System.Drawing.Point(209, 88);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(227, 31);
            this.filter.TabIndex = 0;
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
            this.newreport.Size = new System.Drawing.Size(1342, 711);
            this.newreport.TabIndex = 0;
            this.newreport.Text = "Post Incident Report";
            // 
            // addReportButton
            // 
            this.addReportButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addReportButton.BackColor = System.Drawing.Color.LightGreen;
            this.addReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addReportButton.Font = new System.Drawing.Font("Arial", 12F);
            this.addReportButton.Location = new System.Drawing.Point(496, 580);
            this.addReportButton.Name = "addReportButton";
            this.addReportButton.Size = new System.Drawing.Size(216, 65);
            this.addReportButton.TabIndex = 140;
            this.addReportButton.Text = "Register";
            this.addReportButton.UseVisualStyleBackColor = false;
            // 
            // repErrorMsg
            // 
            this.repErrorMsg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.repErrorMsg.BackColor = System.Drawing.SystemColors.ControlLight;
            this.repErrorMsg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.repErrorMsg.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.repErrorMsg.Location = new System.Drawing.Point(734, 570);
            this.repErrorMsg.Multiline = true;
            this.repErrorMsg.Name = "repErrorMsg";
            this.repErrorMsg.Size = new System.Drawing.Size(562, 92);
            this.repErrorMsg.TabIndex = 139;
            // 
            // specific
            // 
            this.specific.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.specific.Location = new System.Drawing.Point(51, 482);
            this.specific.Multiline = true;
            this.specific.Name = "specific";
            this.specific.Size = new System.Drawing.Size(332, 61);
            this.specific.TabIndex = 138;
            // 
            // solution
            // 
            this.solution.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.solution.Location = new System.Drawing.Point(433, 482);
            this.solution.Multiline = true;
            this.solution.Name = "solution";
            this.solution.Size = new System.Drawing.Size(332, 61);
            this.solution.TabIndex = 136;
            // 
            // remark
            // 
            this.remark.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.remark.Location = new System.Drawing.Point(844, 482);
            this.remark.Multiline = true;
            this.remark.Name = "remark";
            this.remark.Size = new System.Drawing.Size(332, 61);
            this.remark.TabIndex = 134;
            // 
            // employeeinvolved
            // 
            this.employeeinvolved.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.employeeinvolved.Location = new System.Drawing.Point(433, 391);
            this.employeeinvolved.Multiline = true;
            this.employeeinvolved.Name = "employeeinvolved";
            this.employeeinvolved.Size = new System.Drawing.Size(332, 51);
            this.employeeinvolved.TabIndex = 132;
            // 
            // pen
            // 
            this.pen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pen.Location = new System.Drawing.Point(844, 391);
            this.pen.Name = "pen";
            this.pen.Size = new System.Drawing.Size(332, 30);
            this.pen.TabIndex = 130;
            // 
            // instigate
            // 
            this.instigate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.instigate.Location = new System.Drawing.Point(433, 282);
            this.instigate.Name = "instigate";
            this.instigate.Size = new System.Drawing.Size(332, 30);
            this.instigate.TabIndex = 128;
            // 
            // reporterid
            // 
            this.reporterid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.reporterid.Location = new System.Drawing.Point(844, 282);
            this.reporterid.Name = "reporterid";
            this.reporterid.Size = new System.Drawing.Size(332, 30);
            this.reporterid.TabIndex = 124;
            // 
            // reportedby
            // 
            this.reportedby.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.reportedby.Location = new System.Drawing.Point(844, 196);
            this.reportedby.Name = "reportedby";
            this.reportedby.Size = new System.Drawing.Size(332, 30);
            this.reportedby.TabIndex = 122;
            // 
            // iID
            // 
            this.iID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iID.Location = new System.Drawing.Point(51, 197);
            this.iID.Name = "iID";
            this.iID.Size = new System.Drawing.Size(332, 30);
            this.iID.TabIndex = 116;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(47, 456);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 23);
            this.label12.TabIndex = 137;
            this.label12.Text = "Specifics";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(429, 456);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 23);
            this.label10.TabIndex = 135;
            this.label10.Text = "Solution";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(840, 456);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 23);
            this.label11.TabIndex = 133;
            this.label11.Text = "Remarks";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(429, 365);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(309, 23);
            this.label7.TabIndex = 131;
            this.label7.Text = "Employees Involved (Last Names)";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(840, 365);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 23);
            this.label8.TabIndex = 129;
            this.label8.Text = "Penalty";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(429, 256);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 23);
            this.label9.TabIndex = 127;
            this.label9.Text = "Instigator(s)";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(429, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 23);
            this.label5.TabIndex = 126;
            this.label5.Text = "Type of Incident";
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
            this.incidenttypelist.Location = new System.Drawing.Point(433, 196);
            this.incidenttypelist.Name = "incidenttypelist";
            this.incidenttypelist.Size = new System.Drawing.Size(332, 31);
            this.incidenttypelist.TabIndex = 125;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(840, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(221, 23);
            this.label6.TabIndex = 123;
            this.label6.Text = "Reporter\'s Employee ID";
            // 
            // repoLabel
            // 
            this.repoLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.repoLabel.AutoSize = true;
            this.repoLabel.Location = new System.Drawing.Point(840, 170);
            this.repoLabel.Name = "repoLabel";
            this.repoLabel.Size = new System.Drawing.Size(121, 23);
            this.repoLabel.TabIndex = 121;
            this.repoLabel.Text = "Reported By";
            // 
            // datePost
            // 
            this.datePost.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.datePost.CalendarMonthBackground = System.Drawing.SystemColors.GradientActiveCaption;
            this.datePost.Location = new System.Drawing.Point(51, 392);
            this.datePost.Name = "datePost";
            this.datePost.Size = new System.Drawing.Size(332, 30);
            this.datePost.TabIndex = 120;
            // 
            // postLabel
            // 
            this.postLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.postLabel.AutoSize = true;
            this.postLabel.Location = new System.Drawing.Point(47, 365);
            this.postLabel.Name = "postLabel";
            this.postLabel.Size = new System.Drawing.Size(133, 23);
            this.postLabel.TabIndex = 119;
            this.postLabel.Text = "Date Occured";
            // 
            // dateOcc
            // 
            this.dateOcc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateOcc.CalendarMonthBackground = System.Drawing.SystemColors.GradientActiveCaption;
            this.dateOcc.Location = new System.Drawing.Point(51, 284);
            this.dateOcc.Name = "dateOcc";
            this.dateOcc.Size = new System.Drawing.Size(332, 30);
            this.dateOcc.TabIndex = 118;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 23);
            this.label4.TabIndex = 117;
            this.label4.Text = "Date Occured";
            // 
            // idLabel
            // 
            this.idLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(47, 171);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(104, 23);
            this.idLabel.TabIndex = 115;
            this.idLabel.Text = "Incident ID";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 35F);
            this.label3.Location = new System.Drawing.Point(380, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(562, 66);
            this.label3.TabIndex = 114;
            this.label3.Text = "Post Incident Report";
            // 
            // IncidentReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1350, 747);
            this.Controls.Add(this.list);
            this.MinimizeBox = false;
            this.Name = "IncidentReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IncidentReport";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.IncidentReport_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.incidentReportsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRMSDBDataSet)).EndInit();
            this.list.ResumeLayout(false);
            this.viewreports.ResumeLayout(false);
            this.viewreports.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.incidentlist)).EndInit();
            this.newreport.ResumeLayout(false);
            this.newreport.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private HRMSDBDataSet hRMSDBDataSet;
        private System.Windows.Forms.BindingSource incidentReportsBindingSource;
        private HRMSDBDataSetTableAdapters.IncidentReportsTableAdapter incidentReportsTableAdapter;
        private System.Windows.Forms.TabControl list;
        private System.Windows.Forms.TabPage viewreports;
        private System.Windows.Forms.Button deleteregbutton;
        private System.Windows.Forms.Button updateregbutton;
        private System.Windows.Forms.TextBox queryErrorMsg;
        private System.Windows.Forms.Button query;
        private System.Windows.Forms.DataGridView incidentlist;
        private System.Windows.Forms.TextBox querydetail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox filter;
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
        private System.Windows.Forms.TextBox iID;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn incidentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOccuredDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datePostedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeesInvolvedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reportedByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reporterseIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeOfIncidentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specificsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn instigatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn solutionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn penaltyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarksDataGridViewTextBoxColumn;
    }
}