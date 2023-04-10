namespace HRMS.View.UI.IncidentReport
{
    partial class addReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addReport));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.fNames = new System.Windows.Forms.ComboBox();
            this.lNames = new System.Windows.Forms.ComboBox();
            this.position = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dept = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.subdate = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PIs = new System.Windows.Forms.TextBox();
            this.incidentdetail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.approved = new System.Windows.Forms.TextBox();
            this.remarks = new System.Windows.Forms.TextBox();
            this.addEmpBtn = new System.Windows.Forms.Button();
            this.mNames = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mNames);
            this.panel1.Controls.Add(this.addEmpBtn);
            this.panel1.Controls.Add(this.remarks);
            this.panel1.Controls.Add(this.approved);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.incidentdetail);
            this.panel1.Controls.Add(this.PIs);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.subdate);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.dept);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.position);
            this.panel1.Controls.Add(this.lNames);
            this.panel1.Controls.Add(this.fNames);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1135, 861);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Book", 14F);
            this.label1.Location = new System.Drawing.Point(101, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 30);
            this.label1.TabIndex = 67;
            this.label1.Text = "First Name*";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Book", 14F);
            this.label2.Location = new System.Drawing.Point(748, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 30);
            this.label2.TabIndex = 68;
            this.label2.Text = "Last Name*";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Book", 14F);
            this.label3.Location = new System.Drawing.Point(423, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 30);
            this.label3.TabIndex = 69;
            this.label3.Text = "Middle Name";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Sitka Text", 14F);
            this.label10.Location = new System.Drawing.Point(387, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(337, 35);
            this.label10.TabIndex = 71;
            this.label10.Text = "Fields with (*) are required.";
            // 
            // fNames
            // 
            this.fNames.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fNames.BackColor = System.Drawing.Color.LightSkyBlue;
            this.fNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fNames.Font = new System.Drawing.Font("Franklin Gothic Book", 12F);
            this.fNames.FormattingEnabled = true;
            this.fNames.Location = new System.Drawing.Point(106, 160);
            this.fNames.Name = "fNames";
            this.fNames.Size = new System.Drawing.Size(262, 33);
            this.fNames.TabIndex = 72;
            this.fNames.SelectedIndexChanged += new System.EventHandler(this.fNames_SelectedIndexChanged);
            // 
            // lNames
            // 
            this.lNames.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lNames.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lNames.Font = new System.Drawing.Font("Franklin Gothic Book", 12F);
            this.lNames.FormattingEnabled = true;
            this.lNames.Location = new System.Drawing.Point(753, 160);
            this.lNames.Name = "lNames";
            this.lNames.Size = new System.Drawing.Size(262, 33);
            this.lNames.TabIndex = 73;
            this.lNames.SelectedIndexChanged += new System.EventHandler(this.lNames_SelectedIndexChanged);
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
            this.position.Location = new System.Drawing.Point(428, 276);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(527, 33);
            this.position.TabIndex = 74;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Book", 14F);
            this.label7.Location = new System.Drawing.Point(423, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 30);
            this.label7.TabIndex = 75;
            this.label7.Text = "Position*";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Franklin Gothic Book", 14F);
            this.label8.Location = new System.Drawing.Point(101, 233);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 30);
            this.label8.TabIndex = 76;
            this.label8.Text = "Department*";
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
            this.dept.Location = new System.Drawing.Point(106, 275);
            this.dept.Name = "dept";
            this.dept.Size = new System.Drawing.Size(256, 33);
            this.dept.TabIndex = 77;
            this.dept.SelectedIndexChanged += new System.EventHandler(this.dept_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Franklin Gothic Book", 14F);
            this.label9.Location = new System.Drawing.Point(101, 341);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(188, 30);
            this.label9.TabIndex = 78;
            this.label9.Text = "Date Submitted*";
            // 
            // subdate
            // 
            this.subdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.subdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.subdate.Font = new System.Drawing.Font("Franklin Gothic Book", 10F);
            this.subdate.Location = new System.Drawing.Point(106, 384);
            this.subdate.Name = "subdate";
            this.subdate.Size = new System.Drawing.Size(265, 26);
            this.subdate.TabIndex = 79;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Franklin Gothic Book", 14F);
            this.label11.Location = new System.Drawing.Point(101, 448);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(188, 30);
            this.label11.TabIndex = 80;
            this.label11.Text = "People Involved*";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Book", 14F);
            this.label6.Location = new System.Drawing.Point(418, 341);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 30);
            this.label6.TabIndex = 81;
            this.label6.Text = "Incident*";
            // 
            // PIs
            // 
            this.PIs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PIs.BackColor = System.Drawing.Color.LightSkyBlue;
            this.PIs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PIs.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PIs.ForeColor = System.Drawing.Color.Black;
            this.PIs.Location = new System.Drawing.Point(106, 491);
            this.PIs.Multiline = true;
            this.PIs.Name = "PIs";
            this.PIs.Size = new System.Drawing.Size(532, 51);
            this.PIs.TabIndex = 82;
            // 
            // incidentdetail
            // 
            this.incidentdetail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.incidentdetail.BackColor = System.Drawing.Color.LightSkyBlue;
            this.incidentdetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.incidentdetail.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incidentdetail.ForeColor = System.Drawing.Color.Black;
            this.incidentdetail.Location = new System.Drawing.Point(423, 384);
            this.incidentdetail.Multiline = true;
            this.incidentdetail.Name = "incidentdetail";
            this.incidentdetail.Size = new System.Drawing.Size(532, 51);
            this.incidentdetail.TabIndex = 83;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Book", 14F);
            this.label5.Location = new System.Drawing.Point(695, 512);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 30);
            this.label5.TabIndex = 84;
            this.label5.Text = "Approved By:*";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Book", 14F);
            this.label4.Location = new System.Drawing.Point(101, 572);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 30);
            this.label4.TabIndex = 85;
            this.label4.Text = "Remarks";
            // 
            // approved
            // 
            this.approved.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.approved.BackColor = System.Drawing.Color.LightSkyBlue;
            this.approved.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.approved.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.approved.ForeColor = System.Drawing.Color.Black;
            this.approved.Location = new System.Drawing.Point(700, 555);
            this.approved.Multiline = true;
            this.approved.Name = "approved";
            this.approved.Size = new System.Drawing.Size(333, 33);
            this.approved.TabIndex = 86;
            // 
            // remarks
            // 
            this.remarks.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.remarks.BackColor = System.Drawing.Color.LightSkyBlue;
            this.remarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.remarks.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remarks.ForeColor = System.Drawing.Color.Black;
            this.remarks.Location = new System.Drawing.Point(106, 615);
            this.remarks.Multiline = true;
            this.remarks.Name = "remarks";
            this.remarks.Size = new System.Drawing.Size(532, 51);
            this.remarks.TabIndex = 87;
            // 
            // addEmpBtn
            // 
            this.addEmpBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addEmpBtn.BackColor = System.Drawing.Color.Transparent;
            this.addEmpBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addEmpBtn.BackgroundImage")));
            this.addEmpBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addEmpBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addEmpBtn.Location = new System.Drawing.Point(457, 700);
            this.addEmpBtn.Name = "addEmpBtn";
            this.addEmpBtn.Size = new System.Drawing.Size(223, 69);
            this.addEmpBtn.TabIndex = 88;
            this.addEmpBtn.UseVisualStyleBackColor = false;
            this.addEmpBtn.Click += new System.EventHandler(this.addEmpBtn_Click);
            // 
            // mNames
            // 
            this.mNames.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mNames.BackColor = System.Drawing.Color.LightSkyBlue;
            this.mNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mNames.Font = new System.Drawing.Font("Franklin Gothic Book", 12F);
            this.mNames.FormattingEnabled = true;
            this.mNames.Location = new System.Drawing.Point(423, 160);
            this.mNames.Name = "mNames";
            this.mNames.Size = new System.Drawing.Size(262, 33);
            this.mNames.TabIndex = 89;
            this.mNames.SelectedIndexChanged += new System.EventHandler(this.mNames_SelectedIndexChanged);
            // 
            // addReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Name = "addReport";
            this.Size = new System.Drawing.Size(1135, 861);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox mNames;
        private System.Windows.Forms.Button addEmpBtn;
        private System.Windows.Forms.TextBox remarks;
        private System.Windows.Forms.TextBox approved;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox incidentdetail;
        private System.Windows.Forms.TextBox PIs;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker subdate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox dept;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox position;
        private System.Windows.Forms.ComboBox lNames;
        private System.Windows.Forms.ComboBox fNames;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
