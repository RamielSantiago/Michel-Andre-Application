namespace HRMS.View.UI.EmployeeList
{
    partial class addEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addEmployee));
            this.panel1 = new System.Windows.Forms.Panel();
            this.addEmpBtn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.hiredate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dept = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.position = new System.Windows.Forms.ComboBox();
            this.regconpass = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.regpass = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.uName = new System.Windows.Forms.Label();
            this.MI = new System.Windows.Forms.TextBox();
            this.lName = new System.Windows.Forms.TextBox();
            this.fname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.employeeListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.employeeListBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.addEmpBtn);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.hiredate);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.dept);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.position);
            this.panel1.Controls.Add(this.regconpass);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.email);
            this.panel1.Controls.Add(this.regpass);
            this.panel1.Controls.Add(this.username);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.uName);
            this.panel1.Controls.Add(this.MI);
            this.panel1.Controls.Add(this.lName);
            this.panel1.Controls.Add(this.fname);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1144, 858);
            this.panel1.TabIndex = 22;
            // 
            // addEmpBtn
            // 
            this.addEmpBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addEmpBtn.BackColor = System.Drawing.Color.Transparent;
            this.addEmpBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addEmpBtn.BackgroundImage")));
            this.addEmpBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addEmpBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addEmpBtn.Location = new System.Drawing.Point(477, 641);
            this.addEmpBtn.Name = "addEmpBtn";
            this.addEmpBtn.Size = new System.Drawing.Size(223, 69);
            this.addEmpBtn.TabIndex = 43;
            this.addEmpBtn.UseVisualStyleBackColor = false;
            this.addEmpBtn.Click += new System.EventHandler(this.addEmpBtn_Click);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Sitka Text", 14F);
            this.label10.Location = new System.Drawing.Point(403, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(337, 35);
            this.label10.TabIndex = 42;
            this.label10.Text = "Fields with (*) are required.";
            // 
            // hiredate
            // 
            this.hiredate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hiredate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hiredate.Font = new System.Drawing.Font("Franklin Gothic Book", 10F);
            this.hiredate.Location = new System.Drawing.Point(443, 454);
            this.hiredate.Name = "hiredate";
            this.hiredate.Size = new System.Drawing.Size(265, 26);
            this.hiredate.TabIndex = 41;
            this.hiredate.ValueChanged += new System.EventHandler(this.hiredate_ValueChanged);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Franklin Gothic Book", 14F);
            this.label9.Location = new System.Drawing.Point(438, 411);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 30);
            this.label9.TabIndex = 40;
            this.label9.Text = "Date Hired*";
            // 
            // dept
            // 
            this.dept.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dept.BackColor = System.Drawing.Color.LightSkyBlue;
            this.dept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dept.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dept.ForeColor = System.Drawing.Color.Black;
            this.dept.FormattingEnabled = true;
            this.dept.Items.AddRange(new object[] {
            "President",
            "General Manager",
            "Accounting",
            "Retail Sales Operation",
            "Audit",
            "MIS",
            "Administration",
            "Purchasing",
            "Merchandising",
            "HRMD",
            "Marketing",
            "Creative",
            "Warehouse and Logistics",
            "MCE Production",
            "MCE Quality Assurance"});
            this.dept.Location = new System.Drawing.Point(121, 453);
            this.dept.Name = "dept";
            this.dept.Size = new System.Drawing.Size(256, 33);
            this.dept.TabIndex = 39;
            this.dept.SelectedIndexChanged += new System.EventHandler(this.dept_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Franklin Gothic Book", 14F);
            this.label8.Location = new System.Drawing.Point(116, 411);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 30);
            this.label8.TabIndex = 38;
            this.label8.Text = "Department*";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Book", 14F);
            this.label7.Location = new System.Drawing.Point(315, 519);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 30);
            this.label7.TabIndex = 37;
            this.label7.Text = "Position*";
            // 
            // position
            // 
            this.position.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.position.BackColor = System.Drawing.Color.LightSkyBlue;
            this.position.Cursor = System.Windows.Forms.Cursors.Hand;
            this.position.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.position.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.position.ForeColor = System.Drawing.Color.Black;
            this.position.FormattingEnabled = true;
            this.position.Location = new System.Drawing.Point(320, 562);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(527, 33);
            this.position.TabIndex = 36;
            // 
            // regconpass
            // 
            this.regconpass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.regconpass.BackColor = System.Drawing.Color.LightSkyBlue;
            this.regconpass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.regconpass.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regconpass.ForeColor = System.Drawing.Color.Black;
            this.regconpass.Location = new System.Drawing.Point(768, 454);
            this.regconpass.Name = "regconpass";
            this.regconpass.PasswordChar = '*';
            this.regconpass.Size = new System.Drawing.Size(262, 30);
            this.regconpass.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Book", 14F);
            this.label6.Location = new System.Drawing.Point(763, 411);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(210, 30);
            this.label6.TabIndex = 34;
            this.label6.Text = "Confirm Password*";
            // 
            // email
            // 
            this.email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.email.BackColor = System.Drawing.Color.LightSkyBlue;
            this.email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.email.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.ForeColor = System.Drawing.Color.Black;
            this.email.Location = new System.Drawing.Point(443, 325);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(262, 30);
            this.email.TabIndex = 33;
            // 
            // regpass
            // 
            this.regpass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.regpass.BackColor = System.Drawing.Color.LightSkyBlue;
            this.regpass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.regpass.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regpass.ForeColor = System.Drawing.Color.Black;
            this.regpass.Location = new System.Drawing.Point(768, 325);
            this.regpass.Name = "regpass";
            this.regpass.PasswordChar = '*';
            this.regpass.Size = new System.Drawing.Size(262, 30);
            this.regpass.TabIndex = 32;
            // 
            // username
            // 
            this.username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.username.BackColor = System.Drawing.Color.LightSkyBlue;
            this.username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.username.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.Color.Black;
            this.username.Location = new System.Drawing.Point(121, 325);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(262, 30);
            this.username.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Book", 14F);
            this.label4.Location = new System.Drawing.Point(438, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 30);
            this.label4.TabIndex = 30;
            this.label4.Text = "Email*";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Book", 14F);
            this.label5.Location = new System.Drawing.Point(763, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 30);
            this.label5.TabIndex = 29;
            this.label5.Text = "Password*";
            // 
            // uName
            // 
            this.uName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uName.AutoSize = true;
            this.uName.Font = new System.Drawing.Font("Franklin Gothic Book", 14F);
            this.uName.Location = new System.Drawing.Point(122, 282);
            this.uName.Name = "uName";
            this.uName.Size = new System.Drawing.Size(133, 30);
            this.uName.TabIndex = 28;
            this.uName.Text = "Username*";
            // 
            // MI
            // 
            this.MI.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MI.BackColor = System.Drawing.Color.LightSkyBlue;
            this.MI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MI.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MI.ForeColor = System.Drawing.Color.Black;
            this.MI.Location = new System.Drawing.Point(443, 197);
            this.MI.Name = "MI";
            this.MI.Size = new System.Drawing.Size(262, 30);
            this.MI.TabIndex = 27;
            // 
            // lName
            // 
            this.lName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lName.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lName.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lName.ForeColor = System.Drawing.Color.Black;
            this.lName.Location = new System.Drawing.Point(768, 197);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(262, 30);
            this.lName.TabIndex = 26;
            // 
            // fname
            // 
            this.fname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fname.BackColor = System.Drawing.Color.LightSkyBlue;
            this.fname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fname.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fname.ForeColor = System.Drawing.Color.Black;
            this.fname.Location = new System.Drawing.Point(121, 197);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(262, 30);
            this.fname.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Book", 14F);
            this.label3.Location = new System.Drawing.Point(438, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 30);
            this.label3.TabIndex = 24;
            this.label3.Text = "Middle Name";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Book", 14F);
            this.label2.Location = new System.Drawing.Point(763, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 30);
            this.label2.TabIndex = 23;
            this.label2.Text = "Last Name*";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Book", 14F);
            this.label1.Location = new System.Drawing.Point(116, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 30);
            this.label1.TabIndex = 22;
            this.label1.Text = "First Name*";
            // 
            // employeeListBindingSource
            // 
            this.employeeListBindingSource.DataMember = "EmployeeList";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(23, 23);
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
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 23);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 23);
            // 
            // employeeListBindingNavigatorSaveItem
            // 
            this.employeeListBindingNavigatorSaveItem.Name = "employeeListBindingNavigatorSaveItem";
            this.employeeListBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            // 
            // addEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "addEmployee";
            this.Size = new System.Drawing.Size(1144, 858);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeListBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addEmpBtn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker hiredate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox dept;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox position;
        private System.Windows.Forms.TextBox regconpass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox regpass;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label uName;
        private System.Windows.Forms.TextBox MI;
        private System.Windows.Forms.TextBox lName;
        private System.Windows.Forms.TextBox fname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource employeeListBindingSource;
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
        private System.Windows.Forms.ToolStripButton employeeListBindingNavigatorSaveItem;
    }
}
