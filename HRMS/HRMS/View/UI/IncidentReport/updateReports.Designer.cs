namespace HRMS.View.UI.IncidentReport
{
    partial class updateReports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(updateReports));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.iID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.mNames = new System.Windows.Forms.ComboBox();
            this.upRepBtn = new System.Windows.Forms.Button();
            this.remarks = new System.Windows.Forms.TextBox();
            this.approved = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.incidentdetail = new System.Windows.Forms.TextBox();
            this.PIs = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dept = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.position = new System.Windows.Forms.ComboBox();
            this.lNames = new System.Windows.Forms.ComboBox();
            this.fNames = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.iID);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.mNames);
            this.panel1.Controls.Add(this.upRepBtn);
            this.panel1.Controls.Add(this.remarks);
            this.panel1.Controls.Add(this.approved);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.incidentdetail);
            this.panel1.Controls.Add(this.PIs);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.dept);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.position);
            this.panel1.Controls.Add(this.lNames);
            this.panel1.Controls.Add(this.fNames);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(849, 697);
            this.panel1.TabIndex = 48;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.label10.Location = new System.Drawing.Point(268, 54);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(339, 69);
            this.label10.TabIndex = 115;
            this.label10.Text = "Fields with (*) are required.\r\nFields left blank will not be updated.\r\nEmployee I" +
    "nformation is required to update\r\n";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iID
            // 
            this.iID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iID.BackColor = System.Drawing.Color.LightSkyBlue;
            this.iID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.iID.Font = new System.Drawing.Font("Franklin Gothic Book", 12F);
            this.iID.ForeColor = System.Drawing.Color.Black;
            this.iID.Location = new System.Drawing.Point(506, 457);
            this.iID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.iID.Name = "iID";
            this.iID.Size = new System.Drawing.Size(248, 26);
            this.iID.TabIndex = 113;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Franklin Gothic Book", 14F);
            this.label12.Location = new System.Drawing.Point(502, 422);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 24);
            this.label12.TabIndex = 112;
            this.label12.Text = "Incident ID*";
            // 
            // mNames
            // 
            this.mNames.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mNames.BackColor = System.Drawing.Color.LightSkyBlue;
            this.mNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mNames.Font = new System.Drawing.Font("Franklin Gothic Book", 12F);
            this.mNames.FormattingEnabled = true;
            this.mNames.Location = new System.Drawing.Point(317, 175);
            this.mNames.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mNames.Name = "mNames";
            this.mNames.Size = new System.Drawing.Size(198, 29);
            this.mNames.TabIndex = 111;
            this.mNames.SelectedIndexChanged += new System.EventHandler(this.mNames_SelectedIndexChanged);
            // 
            // upRepBtn
            // 
            this.upRepBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.upRepBtn.BackColor = System.Drawing.Color.Transparent;
            this.upRepBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("upRepBtn.BackgroundImage")));
            this.upRepBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.upRepBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.upRepBtn.Location = new System.Drawing.Point(549, 530);
            this.upRepBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.upRepBtn.Name = "upRepBtn";
            this.upRepBtn.Size = new System.Drawing.Size(167, 56);
            this.upRepBtn.TabIndex = 110;
            this.upRepBtn.UseVisualStyleBackColor = false;
            this.upRepBtn.Click += new System.EventHandler(this.upRepBtn_Click);
            // 
            // remarks
            // 
            this.remarks.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.remarks.BackColor = System.Drawing.Color.LightSkyBlue;
            this.remarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.remarks.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remarks.ForeColor = System.Drawing.Color.Black;
            this.remarks.Location = new System.Drawing.Point(80, 544);
            this.remarks.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.remarks.Multiline = true;
            this.remarks.Name = "remarks";
            this.remarks.Size = new System.Drawing.Size(400, 42);
            this.remarks.TabIndex = 109;
            // 
            // approved
            // 
            this.approved.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.approved.BackColor = System.Drawing.Color.LightSkyBlue;
            this.approved.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.approved.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.approved.ForeColor = System.Drawing.Color.Black;
            this.approved.Location = new System.Drawing.Point(506, 351);
            this.approved.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.approved.Multiline = true;
            this.approved.Name = "approved";
            this.approved.Size = new System.Drawing.Size(250, 27);
            this.approved.TabIndex = 108;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Book", 14F);
            this.label4.Location = new System.Drawing.Point(76, 509);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 24);
            this.label4.TabIndex = 107;
            this.label4.Text = "Remarks";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Book", 14F);
            this.label5.Location = new System.Drawing.Point(502, 316);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 24);
            this.label5.TabIndex = 106;
            this.label5.Text = "Approved By:";
            // 
            // incidentdetail
            // 
            this.incidentdetail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.incidentdetail.BackColor = System.Drawing.Color.LightSkyBlue;
            this.incidentdetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.incidentdetail.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incidentdetail.ForeColor = System.Drawing.Color.Black;
            this.incidentdetail.Location = new System.Drawing.Point(80, 351);
            this.incidentdetail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.incidentdetail.Multiline = true;
            this.incidentdetail.Name = "incidentdetail";
            this.incidentdetail.Size = new System.Drawing.Size(400, 42);
            this.incidentdetail.TabIndex = 105;
            // 
            // PIs
            // 
            this.PIs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PIs.BackColor = System.Drawing.Color.LightSkyBlue;
            this.PIs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PIs.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PIs.ForeColor = System.Drawing.Color.Black;
            this.PIs.Location = new System.Drawing.Point(80, 444);
            this.PIs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PIs.Multiline = true;
            this.PIs.Name = "PIs";
            this.PIs.Size = new System.Drawing.Size(400, 42);
            this.PIs.TabIndex = 104;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Book", 14F);
            this.label6.Location = new System.Drawing.Point(76, 316);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 24);
            this.label6.TabIndex = 103;
            this.label6.Text = "Incident";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Franklin Gothic Book", 14F);
            this.label11.Location = new System.Drawing.Point(76, 409);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(137, 24);
            this.label11.TabIndex = 102;
            this.label11.Text = "People Involved";
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
            this.dept.Location = new System.Drawing.Point(80, 268);
            this.dept.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dept.Name = "dept";
            this.dept.Size = new System.Drawing.Size(193, 29);
            this.dept.TabIndex = 99;
            this.dept.SelectedIndexChanged += new System.EventHandler(this.dept_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Franklin Gothic Book", 14F);
            this.label8.Location = new System.Drawing.Point(76, 234);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 24);
            this.label8.TabIndex = 98;
            this.label8.Text = "Department*";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Book", 14F);
            this.label7.Location = new System.Drawing.Point(317, 234);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 24);
            this.label7.TabIndex = 97;
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
            this.position.Location = new System.Drawing.Point(321, 269);
            this.position.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(442, 29);
            this.position.TabIndex = 96;
            this.position.SelectedIndexChanged += new System.EventHandler(this.position_SelectedIndexChanged);
            // 
            // lNames
            // 
            this.lNames.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lNames.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lNames.Font = new System.Drawing.Font("Franklin Gothic Book", 12F);
            this.lNames.FormattingEnabled = true;
            this.lNames.Location = new System.Drawing.Point(565, 175);
            this.lNames.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lNames.Name = "lNames";
            this.lNames.Size = new System.Drawing.Size(198, 29);
            this.lNames.TabIndex = 95;
            this.lNames.SelectedIndexChanged += new System.EventHandler(this.lNames_SelectedIndexChanged);
            // 
            // fNames
            // 
            this.fNames.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fNames.BackColor = System.Drawing.Color.LightSkyBlue;
            this.fNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fNames.Font = new System.Drawing.Font("Franklin Gothic Book", 12F);
            this.fNames.FormattingEnabled = true;
            this.fNames.Location = new System.Drawing.Point(80, 175);
            this.fNames.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fNames.Name = "fNames";
            this.fNames.Size = new System.Drawing.Size(198, 29);
            this.fNames.TabIndex = 94;
            this.fNames.SelectedIndexChanged += new System.EventHandler(this.fNames_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Book", 14F);
            this.label3.Location = new System.Drawing.Point(317, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 24);
            this.label3.TabIndex = 92;
            this.label3.Text = "Middle Name";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Book", 14F);
            this.label2.Location = new System.Drawing.Point(561, 140);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 24);
            this.label2.TabIndex = 91;
            this.label2.Text = "Last Name*";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Book", 14F);
            this.label1.Location = new System.Drawing.Point(76, 140);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 24);
            this.label1.TabIndex = 90;
            this.label1.Text = "First Name*";
            // 
            // updateReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "updateReports";
            this.Size = new System.Drawing.Size(849, 697);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox mNames;
        private System.Windows.Forms.Button upRepBtn;
        private System.Windows.Forms.TextBox remarks;
        private System.Windows.Forms.TextBox approved;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox incidentdetail;
        private System.Windows.Forms.TextBox PIs;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox dept;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox position;
        private System.Windows.Forms.ComboBox lNames;
        private System.Windows.Forms.ComboBox fNames;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox iID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
    }
}
