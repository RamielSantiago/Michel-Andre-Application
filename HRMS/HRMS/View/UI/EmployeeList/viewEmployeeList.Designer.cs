﻿namespace HRMS.View.UI.EmployeeList
{
    partial class viewEmployeeList
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
            this.eSearchBtn = new System.Windows.Forms.Button();
            this.employeesearchcriteria = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.depts = new System.Windows.Forms.ComboBox();
            this.querydetail = new System.Windows.Forms.TextBox();
            this.employees = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employees)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // eSearchBtn
            // 
            this.eSearchBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.eSearchBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.eSearchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eSearchBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.eSearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eSearchBtn.Font = new System.Drawing.Font("Franklin Gothic Book", 12F);
            this.eSearchBtn.ForeColor = System.Drawing.Color.White;
            this.eSearchBtn.Location = new System.Drawing.Point(611, 41);
            this.eSearchBtn.Margin = new System.Windows.Forms.Padding(2);
            this.eSearchBtn.Name = "eSearchBtn";
            this.eSearchBtn.Size = new System.Drawing.Size(99, 29);
            this.eSearchBtn.TabIndex = 10;
            this.eSearchBtn.Text = "Search";
            this.eSearchBtn.UseVisualStyleBackColor = false;
            this.eSearchBtn.Click += new System.EventHandler(this.eSearchBtn_Click);
            // 
            // employeesearchcriteria
            // 
            this.employeesearchcriteria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.employeesearchcriteria.BackColor = System.Drawing.Color.Gainsboro;
            this.employeesearchcriteria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.employeesearchcriteria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.employeesearchcriteria.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeesearchcriteria.FormattingEnabled = true;
            this.employeesearchcriteria.Items.AddRange(new object[] {
            "Employee ID",
            "Last Name",
            "First Name",
            "Username",
            "Department",
            "Email",
            "--Search Criteria--"});
            this.employeesearchcriteria.Location = new System.Drawing.Point(147, 39);
            this.employeesearchcriteria.Margin = new System.Windows.Forms.Padding(2);
            this.employeesearchcriteria.Name = "employeesearchcriteria";
            this.employeesearchcriteria.Size = new System.Drawing.Size(156, 29);
            this.employeesearchcriteria.TabIndex = 8;
            this.employeesearchcriteria.SelectedIndexChanged += new System.EventHandler(this.employeesearchcriteria_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Search By:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(565, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.employeesearchcriteria);
            this.panel1.Controls.Add(this.eSearchBtn);
            this.panel1.Controls.Add(this.depts);
            this.panel1.Controls.Add(this.querydetail);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 84);
            this.panel1.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Book", 10F);
            this.label4.Location = new System.Drawing.Point(144, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 18);
            this.label4.TabIndex = 132;
            this.label4.Text = "Criteria";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Book", 10F);
            this.label3.Location = new System.Drawing.Point(321, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 18);
            this.label3.TabIndex = 131;
            this.label3.Text = "Query";
            // 
            // depts
            //
            this.depts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.depts.BackColor = System.Drawing.Color.Gainsboro;
            this.depts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.depts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.depts.Font = new System.Drawing.Font("Franklin Gothic Book", 10F);
            this.depts.Items.AddRange(new object[] {
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
            "MCE Quality Assurance",
            "--Department--"});
            this.depts.Location = new System.Drawing.Point(324, 41);
            this.depts.Margin = new System.Windows.Forms.Padding(2);
            this.depts.Name = "depts";
            this.depts.Size = new System.Drawing.Size(268, 25);
            this.depts.TabIndex = 0;
            //
            // querydetail
            //
            this.querydetail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.querydetail.BackColor = System.Drawing.Color.LightSkyBlue;
            this.querydetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.querydetail.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.querydetail.Location = new System.Drawing.Point(324, 41);
            this.querydetail.Margin = new System.Windows.Forms.Padding(2);
            this.querydetail.Name = "querydetail";
            this.querydetail.Size = new System.Drawing.Size(268, 26);
            this.querydetail.TabIndex = 9;
            //
            // employees
            // 
            this.employees.AllowUserToAddRows = false;
            this.employees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employees.Location = new System.Drawing.Point(0, 0);
            this.employees.Margin = new System.Windows.Forms.Padding(2);
            this.employees.Name = "employees";
            this.employees.RowHeadersWidth = 51;
            this.employees.RowTemplate.Height = 24;
            this.employees.Size = new System.Drawing.Size(776, 602);
            this.employees.TabIndex = 12;
            this.employees.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employees_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.employees);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 84);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 602);
            this.panel2.TabIndex = 14;
            // 
            // viewEmployeeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "viewEmployeeList";
            this.Size = new System.Drawing.Size(776, 686);
            this.Load += new System.EventHandler(this.viewEmployeeList_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employees)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button eSearchBtn;
        private System.Windows.Forms.ComboBox employeesearchcriteria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView employees;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox querydetail;
        private System.Windows.Forms.ComboBox depts;
    }
}
