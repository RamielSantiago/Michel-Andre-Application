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
            this.components = new System.ComponentModel.Container();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hRMSDBDataSet = new HRMS.HRMSDBDataSet();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.employeesTableAdapter = new HRMS.HRMSDBDataSetTableAdapters.EmployeesTableAdapter();
            this.tableAdapterManager = new HRMS.HRMSDBDataSetTableAdapters.TableAdapterManager();
            this.newemployee = new System.Windows.Forms.TabPage();
            this.RegisterLabel = new System.Windows.Forms.Label();
            this.usernamelabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.conpass = new System.Windows.Forms.Label();
            this.first_name = new System.Windows.Forms.Label();
            this.last_name = new System.Windows.Forms.Label();
            this.middle_name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.regpass = new System.Windows.Forms.TextBox();
            this.regconpass = new System.Windows.Forms.TextBox();
            this.fName = new System.Windows.Forms.TextBox();
            this.lName = new System.Windows.Forms.TextBox();
            this.mName = new System.Windows.Forms.TextBox();
            this.eID = new System.Windows.Forms.TextBox();
            this.regErrorMsg = new System.Windows.Forms.TextBox();
            this.ALINPUT = new System.Windows.Forms.TextBox();
            this.alLabel = new System.Windows.Forms.Label();
            this.addUserButton = new System.Windows.Forms.Button();
            this.viewlist = new System.Windows.Forms.TabPage();
            this.filter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.querydetail = new System.Windows.Forms.TextBox();
            this.employeelist = new System.Windows.Forms.DataGridView();
            this.accessLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.query = new System.Windows.Forms.Button();
            this.queryErrorMsg = new System.Windows.Forms.TextBox();
            this.updateregbutton = new System.Windows.Forms.Button();
            this.deleteregbutton = new System.Windows.Forms.Button();
            this.list = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRMSDBDataSet)).BeginInit();
            this.newemployee.SuspendLayout();
            this.viewlist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeelist)).BeginInit();
            this.list.SuspendLayout();
            this.SuspendLayout();
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.hRMSDBDataSet;
            // 
            // hRMSDBDataSet
            // 
            this.hRMSDBDataSet.DataSetName = "HRMSDBDataSet";
            this.hRMSDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 23);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(23, 23);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 23);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 23);
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 23);
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(100, 27);
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 23);
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 23);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EmployeesTableAdapter = this.employeesTableAdapter;
            this.tableAdapterManager.IncidentReportsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = HRMS.HRMSDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // newemployee
            // 
            this.newemployee.BackColor = System.Drawing.SystemColors.ControlLight;
            this.newemployee.Controls.Add(this.addUserButton);
            this.newemployee.Controls.Add(this.alLabel);
            this.newemployee.Controls.Add(this.ALINPUT);
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
            this.newemployee.Size = new System.Drawing.Size(1342, 711);
            this.newemployee.TabIndex = 0;
            this.newemployee.Text = "Register Employee Record";
            // 
            // RegisterLabel
            // 
            this.RegisterLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RegisterLabel.AutoSize = true;
            this.RegisterLabel.Font = new System.Drawing.Font("Arial", 40F);
            this.RegisterLabel.Location = new System.Drawing.Point(336, 48);
            this.RegisterLabel.Name = "RegisterLabel";
            this.RegisterLabel.Size = new System.Drawing.Size(598, 75);
            this.RegisterLabel.TabIndex = 63;
            this.RegisterLabel.Text = "Register Employee";
            // 
            // usernamelabel
            // 
            this.usernamelabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usernamelabel.AutoSize = true;
            this.usernamelabel.Font = new System.Drawing.Font("Arial", 14F);
            this.usernamelabel.Location = new System.Drawing.Point(499, 273);
            this.usernamelabel.Name = "usernamelabel";
            this.usernamelabel.Size = new System.Drawing.Size(122, 27);
            this.usernamelabel.TabIndex = 65;
            this.usernamelabel.Text = "Username";
            // 
            // emailLabel
            // 
            this.emailLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Arial", 14F);
            this.emailLabel.Location = new System.Drawing.Point(862, 152);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(72, 27);
            this.emailLabel.TabIndex = 67;
            this.emailLabel.Text = "Email";
            // 
            // password
            // 
            this.password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Arial", 14F);
            this.password.Location = new System.Drawing.Point(862, 273);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(117, 27);
            this.password.TabIndex = 69;
            this.password.Text = "Password";
            // 
            // conpass
            // 
            this.conpass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.conpass.AutoSize = true;
            this.conpass.Font = new System.Drawing.Font("Arial", 14F);
            this.conpass.Location = new System.Drawing.Point(862, 385);
            this.conpass.Name = "conpass";
            this.conpass.Size = new System.Drawing.Size(208, 27);
            this.conpass.TabIndex = 71;
            this.conpass.Text = "Confirm Password";
            // 
            // first_name
            // 
            this.first_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.first_name.AutoSize = true;
            this.first_name.Font = new System.Drawing.Font("Arial", 14F);
            this.first_name.Location = new System.Drawing.Point(146, 162);
            this.first_name.Name = "first_name";
            this.first_name.Size = new System.Drawing.Size(129, 27);
            this.first_name.TabIndex = 73;
            this.first_name.Text = "First Name";
            // 
            // last_name
            // 
            this.last_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.last_name.AutoSize = true;
            this.last_name.Font = new System.Drawing.Font("Arial", 14F);
            this.last_name.Location = new System.Drawing.Point(146, 274);
            this.last_name.Name = "last_name";
            this.last_name.Size = new System.Drawing.Size(127, 27);
            this.last_name.TabIndex = 75;
            this.last_name.Text = "Last Name";
            // 
            // middle_name
            // 
            this.middle_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.middle_name.AutoSize = true;
            this.middle_name.Font = new System.Drawing.Font("Arial", 14F);
            this.middle_name.Location = new System.Drawing.Point(146, 395);
            this.middle_name.Name = "middle_name";
            this.middle_name.Size = new System.Drawing.Size(153, 27);
            this.middle_name.TabIndex = 77;
            this.middle_name.Text = "Middle Name";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F);
            this.label1.Location = new System.Drawing.Point(499, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 27);
            this.label1.TabIndex = 79;
            this.label1.Text = "Employee ID";
            // 
            // username
            // 
            this.username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.username.Font = new System.Drawing.Font("Arial", 14F);
            this.username.Location = new System.Drawing.Point(499, 313);
            this.username.Multiline = true;
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(300, 30);
            this.username.TabIndex = 64;
            // 
            // email
            // 
            this.email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.email.Font = new System.Drawing.Font("Arial", 14F);
            this.email.Location = new System.Drawing.Point(862, 192);
            this.email.Multiline = true;
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(300, 30);
            this.email.TabIndex = 66;
            // 
            // regpass
            // 
            this.regpass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.regpass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.regpass.Font = new System.Drawing.Font("Arial", 14F);
            this.regpass.Location = new System.Drawing.Point(862, 313);
            this.regpass.Multiline = true;
            this.regpass.Name = "regpass";
            this.regpass.PasswordChar = '*';
            this.regpass.Size = new System.Drawing.Size(300, 30);
            this.regpass.TabIndex = 68;
            // 
            // regconpass
            // 
            this.regconpass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.regconpass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.regconpass.Font = new System.Drawing.Font("Arial", 14F);
            this.regconpass.Location = new System.Drawing.Point(862, 434);
            this.regconpass.Multiline = true;
            this.regconpass.Name = "regconpass";
            this.regconpass.PasswordChar = '*';
            this.regconpass.Size = new System.Drawing.Size(300, 30);
            this.regconpass.TabIndex = 70;
            // 
            // fName
            // 
            this.fName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fName.Font = new System.Drawing.Font("Arial", 14F);
            this.fName.Location = new System.Drawing.Point(146, 192);
            this.fName.Multiline = true;
            this.fName.Name = "fName";
            this.fName.Size = new System.Drawing.Size(300, 30);
            this.fName.TabIndex = 72;
            // 
            // lName
            // 
            this.lName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lName.Font = new System.Drawing.Font("Arial", 14F);
            this.lName.Location = new System.Drawing.Point(151, 313);
            this.lName.Multiline = true;
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(300, 30);
            this.lName.TabIndex = 74;
            // 
            // mName
            // 
            this.mName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mName.Font = new System.Drawing.Font("Arial", 14F);
            this.mName.Location = new System.Drawing.Point(146, 434);
            this.mName.Multiline = true;
            this.mName.Name = "mName";
            this.mName.Size = new System.Drawing.Size(300, 30);
            this.mName.TabIndex = 76;
            // 
            // eID
            // 
            this.eID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.eID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eID.Font = new System.Drawing.Font("Arial", 14F);
            this.eID.Location = new System.Drawing.Point(499, 192);
            this.eID.Multiline = true;
            this.eID.Name = "eID";
            this.eID.Size = new System.Drawing.Size(300, 30);
            this.eID.TabIndex = 78;
            // 
            // regErrorMsg
            // 
            this.regErrorMsg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.regErrorMsg.BackColor = System.Drawing.SystemColors.ControlLight;
            this.regErrorMsg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.regErrorMsg.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.regErrorMsg.Location = new System.Drawing.Point(391, 580);
            this.regErrorMsg.Multiline = true;
            this.regErrorMsg.Name = "regErrorMsg";
            this.regErrorMsg.Size = new System.Drawing.Size(562, 92);
            this.regErrorMsg.TabIndex = 81;
            // 
            // ALINPUT
            // 
            this.ALINPUT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ALINPUT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ALINPUT.Font = new System.Drawing.Font("Arial", 14F);
            this.ALINPUT.Location = new System.Drawing.Point(499, 434);
            this.ALINPUT.Multiline = true;
            this.ALINPUT.Name = "ALINPUT";
            this.ALINPUT.Size = new System.Drawing.Size(300, 30);
            this.ALINPUT.TabIndex = 82;
            // 
            // alLabel
            // 
            this.alLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.alLabel.AutoSize = true;
            this.alLabel.Font = new System.Drawing.Font("Arial", 14F);
            this.alLabel.Location = new System.Drawing.Point(499, 394);
            this.alLabel.Name = "alLabel";
            this.alLabel.Size = new System.Drawing.Size(151, 27);
            this.alLabel.TabIndex = 83;
            this.alLabel.Text = "Access Level";
            // 
            // addUserButton
            // 
            this.addUserButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addUserButton.BackColor = System.Drawing.Color.Goldenrod;
            this.addUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addUserButton.Font = new System.Drawing.Font("Arial", 12F);
            this.addUserButton.Location = new System.Drawing.Point(553, 497);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(216, 65);
            this.addUserButton.TabIndex = 84;
            this.addUserButton.Text = "Register";
            this.addUserButton.UseVisualStyleBackColor = false;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click_1);
            // 
            // viewlist
            // 
            this.viewlist.BackColor = System.Drawing.SystemColors.ControlLight;
            this.viewlist.Controls.Add(this.deleteregbutton);
            this.viewlist.Controls.Add(this.updateregbutton);
            this.viewlist.Controls.Add(this.queryErrorMsg);
            this.viewlist.Controls.Add(this.querydetail);
            this.viewlist.Controls.Add(this.query);
            this.viewlist.Controls.Add(this.employeelist);
            this.viewlist.Controls.Add(this.label2);
            this.viewlist.Controls.Add(this.filter);
            this.viewlist.Location = new System.Drawing.Point(4, 32);
            this.viewlist.Name = "viewlist";
            this.viewlist.Padding = new System.Windows.Forms.Padding(3);
            this.viewlist.Size = new System.Drawing.Size(1342, 711);
            this.viewlist.TabIndex = 1;
            this.viewlist.Text = "View Employees";
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
            // querydetail
            // 
            this.querydetail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.querydetail.Location = new System.Drawing.Point(442, 91);
            this.querydetail.Name = "querydetail";
            this.querydetail.Size = new System.Drawing.Size(649, 30);
            this.querydetail.TabIndex = 2;
            // 
            // employeelist
            // 
            this.employeelist.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.employeelist.AutoGenerateColumns = false;
            this.employeelist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeelist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeIDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.middleNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.accessLevelDataGridViewTextBoxColumn});
            this.employeelist.DataSource = this.employeesBindingSource;
            this.employeelist.Location = new System.Drawing.Point(91, 121);
            this.employeelist.Name = "employeelist";
            this.employeelist.RowHeadersWidth = 51;
            this.employeelist.RowTemplate.Height = 24;
            this.employeelist.Size = new System.Drawing.Size(1157, 551);
            this.employeelist.TabIndex = 3;
            // 
            // accessLevelDataGridViewTextBoxColumn
            // 
            this.accessLevelDataGridViewTextBoxColumn.DataPropertyName = "Access_Level";
            this.accessLevelDataGridViewTextBoxColumn.HeaderText = "Access_Level";
            this.accessLevelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.accessLevelDataGridViewTextBoxColumn.Name = "accessLevelDataGridViewTextBoxColumn";
            this.accessLevelDataGridViewTextBoxColumn.Width = 125;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "Last_Name";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Last_Name";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // middleNameDataGridViewTextBoxColumn
            // 
            this.middleNameDataGridViewTextBoxColumn.DataPropertyName = "Middle_Name";
            this.middleNameDataGridViewTextBoxColumn.HeaderText = "Middle_Name";
            this.middleNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.middleNameDataGridViewTextBoxColumn.Name = "middleNameDataGridViewTextBoxColumn";
            this.middleNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "First_Name";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First_Name";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.HeaderText = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            this.employeeIDDataGridViewTextBoxColumn.Width = 125;
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
            // list
            // 
            this.list.Controls.Add(this.viewlist);
            this.list.Controls.Add(this.newemployee);
            this.list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list.Font = new System.Drawing.Font("Arial", 12F);
            this.list.Location = new System.Drawing.Point(0, 0);
            this.list.Name = "list";
            this.list.SelectedIndex = 0;
            this.list.Size = new System.Drawing.Size(1350, 747);
            this.list.TabIndex = 23;
            // 
            // HRMSRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1350, 747);
            this.Controls.Add(this.list);
            this.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "HRMSRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Human Resource Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.HRMSRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRMSDBDataSet)).EndInit();
            this.newemployee.ResumeLayout(false);
            this.newemployee.PerformLayout();
            this.viewlist.ResumeLayout(false);
            this.viewlist.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeelist)).EndInit();
            this.list.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private HRMSDBDataSet hRMSDBDataSet;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private HRMSDBDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private HRMSDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TabPage newemployee;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.Label alLabel;
        private System.Windows.Forms.TextBox ALINPUT;
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
        private System.Windows.Forms.Button deleteregbutton;
        private System.Windows.Forms.Button updateregbutton;
        private System.Windows.Forms.TextBox queryErrorMsg;
        private System.Windows.Forms.TextBox querydetail;
        private System.Windows.Forms.Button query;
        private System.Windows.Forms.DataGridView employeelist;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn middleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accessLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox filter;
        private System.Windows.Forms.TabControl list;
    }
}