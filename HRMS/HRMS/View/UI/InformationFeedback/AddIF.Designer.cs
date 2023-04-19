namespace HRMS.View.UI.InformationFeedback
{
    partial class addIF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addIF));
            this.label10 = new System.Windows.Forms.Label();
            this.mNames = new System.Windows.Forms.ComboBox();
            this.FBdetail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.subdate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dept = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.position = new System.Windows.Forms.ComboBox();
            this.lNames = new System.Windows.Forms.ComboBox();
            this.fNames = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.topic = new System.Windows.Forms.ComboBox();
            this.Pres = new System.Windows.Forms.CheckBox();
            this.HRO = new System.Windows.Forms.CheckBox();
            this.SV = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.FBcoa = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.addEmpBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Sitka Text", 14F);
            this.label10.Location = new System.Drawing.Point(302, 37);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(263, 28);
            this.label10.TabIndex = 43;
            this.label10.Text = "Fields with (*) are required.";
            // 
            // mNames
            // 
            this.mNames.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mNames.BackColor = System.Drawing.Color.LightSkyBlue;
            this.mNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mNames.Font = new System.Drawing.Font("Franklin Gothic Book", 12F);
            this.mNames.FormattingEnabled = true;
            this.mNames.Location = new System.Drawing.Point(321, 130);
            this.mNames.Margin = new System.Windows.Forms.Padding(2);
            this.mNames.Name = "mNames";
            this.mNames.Size = new System.Drawing.Size(198, 29);
            this.mNames.TabIndex = 103;
            // 
            // FBdetail
            // 
            this.FBdetail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FBdetail.BackColor = System.Drawing.Color.LightSkyBlue;
            this.FBdetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FBdetail.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FBdetail.ForeColor = System.Drawing.Color.Black;
            this.FBdetail.Location = new System.Drawing.Point(84, 409);
            this.FBdetail.Margin = new System.Windows.Forms.Padding(2);
            this.FBdetail.Multiline = true;
            this.FBdetail.Name = "FBdetail";
            this.FBdetail.Size = new System.Drawing.Size(683, 42);
            this.FBdetail.TabIndex = 102;
            this.FBdetail.TextChanged += new System.EventHandler(this.FBdetail_TextChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Book", 14F);
            this.label6.Location = new System.Drawing.Point(84, 374);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 24);
            this.label6.TabIndex = 101;
            this.label6.Text = "Detail*";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // subdate
            // 
            this.subdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.subdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.subdate.Font = new System.Drawing.Font("Franklin Gothic Book", 10F);
            this.subdate.Location = new System.Drawing.Point(567, 317);
            this.subdate.Margin = new System.Windows.Forms.Padding(2);
            this.subdate.Name = "subdate";
            this.subdate.Size = new System.Drawing.Size(200, 23);
            this.subdate.TabIndex = 100;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Franklin Gothic Book", 14F);
            this.label9.Location = new System.Drawing.Point(563, 281);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 24);
            this.label9.TabIndex = 99;
            this.label9.Text = "Date Submitted*";
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
            this.dept.Location = new System.Drawing.Point(84, 220);
            this.dept.Margin = new System.Windows.Forms.Padding(2);
            this.dept.Name = "dept";
            this.dept.Size = new System.Drawing.Size(193, 29);
            this.dept.TabIndex = 98;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Franklin Gothic Book", 14F);
            this.label8.Location = new System.Drawing.Point(80, 186);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 24);
            this.label8.TabIndex = 97;
            this.label8.Text = "Department*";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Book", 14F);
            this.label7.Location = new System.Drawing.Point(321, 186);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 24);
            this.label7.TabIndex = 96;
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
            this.position.Location = new System.Drawing.Point(325, 221);
            this.position.Margin = new System.Windows.Forms.Padding(2);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(442, 29);
            this.position.TabIndex = 95;
            // 
            // lNames
            // 
            this.lNames.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lNames.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lNames.Font = new System.Drawing.Font("Franklin Gothic Book", 12F);
            this.lNames.FormattingEnabled = true;
            this.lNames.Location = new System.Drawing.Point(569, 130);
            this.lNames.Margin = new System.Windows.Forms.Padding(2);
            this.lNames.Name = "lNames";
            this.lNames.Size = new System.Drawing.Size(198, 29);
            this.lNames.TabIndex = 94;
            // 
            // fNames
            // 
            this.fNames.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fNames.BackColor = System.Drawing.Color.LightSkyBlue;
            this.fNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fNames.Font = new System.Drawing.Font("Franklin Gothic Book", 12F);
            this.fNames.FormattingEnabled = true;
            this.fNames.Location = new System.Drawing.Point(84, 130);
            this.fNames.Margin = new System.Windows.Forms.Padding(2);
            this.fNames.Name = "fNames";
            this.fNames.Size = new System.Drawing.Size(198, 29);
            this.fNames.TabIndex = 93;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Book", 14F);
            this.label3.Location = new System.Drawing.Point(321, 95);
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
            this.label2.Location = new System.Drawing.Point(565, 95);
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
            this.label1.Location = new System.Drawing.Point(80, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 24);
            this.label1.TabIndex = 90;
            this.label1.Text = "First Name*";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Book", 14F);
            this.label4.Location = new System.Drawing.Point(80, 281);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 24);
            this.label4.TabIndex = 105;
            this.label4.Text = "Topic*";
            // 
            // topic
            // 
            this.topic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.topic.BackColor = System.Drawing.Color.LightSkyBlue;
            this.topic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.topic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.topic.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topic.ForeColor = System.Drawing.Color.Black;
            this.topic.FormattingEnabled = true;
            this.topic.Location = new System.Drawing.Point(84, 316);
            this.topic.Margin = new System.Windows.Forms.Padding(2);
            this.topic.Name = "topic";
            this.topic.Size = new System.Drawing.Size(442, 29);
            this.topic.TabIndex = 104;
            // 
            // Pres
            // 
            this.Pres.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pres.AutoSize = true;
            this.Pres.Font = new System.Drawing.Font("Franklin Gothic Book", 11F);
            this.Pres.Location = new System.Drawing.Point(298, 537);
            this.Pres.Name = "Pres";
            this.Pres.Size = new System.Drawing.Size(88, 24);
            this.Pres.TabIndex = 108;
            this.Pres.Text = "President";
            this.Pres.UseVisualStyleBackColor = true;
            this.Pres.CheckedChanged += new System.EventHandler(this.Int3_CheckedChanged);
            // 
            // HRO
            // 
            this.HRO.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HRO.AutoSize = true;
            this.HRO.Font = new System.Drawing.Font("Franklin Gothic Book", 11F);
            this.HRO.Location = new System.Drawing.Point(86, 537);
            this.HRO.Name = "HRO";
            this.HRO.Size = new System.Drawing.Size(93, 24);
            this.HRO.TabIndex = 107;
            this.HRO.Text = "HR Officer";
            this.HRO.UseVisualStyleBackColor = true;
            // 
            // SV
            // 
            this.SV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SV.AutoSize = true;
            this.SV.Font = new System.Drawing.Font("Franklin Gothic Book", 11F);
            this.SV.Location = new System.Drawing.Point(191, 537);
            this.SV.Name = "SV";
            this.SV.Size = new System.Drawing.Size(96, 24);
            this.SV.TabIndex = 106;
            this.SV.Text = "Supervisor";
            this.SV.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Book", 14F);
            this.label5.Location = new System.Drawing.Point(82, 488);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 24);
            this.label5.TabIndex = 109;
            this.label5.Text = "Approved By";
            // 
            // FBcoa
            // 
            this.FBcoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FBcoa.BackColor = System.Drawing.Color.LightSkyBlue;
            this.FBcoa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FBcoa.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FBcoa.ForeColor = System.Drawing.Color.Black;
            this.FBcoa.Location = new System.Drawing.Point(403, 519);
            this.FBcoa.Margin = new System.Windows.Forms.Padding(2);
            this.FBcoa.Multiline = true;
            this.FBcoa.Name = "FBcoa";
            this.FBcoa.Size = new System.Drawing.Size(364, 42);
            this.FBcoa.TabIndex = 111;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Franklin Gothic Book", 14F);
            this.label11.Location = new System.Drawing.Point(403, 484);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(141, 24);
            this.label11.TabIndex = 110;
            this.label11.Text = "Course of Action";
            // 
            // addEmpBtn
            // 
            this.addEmpBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addEmpBtn.BackColor = System.Drawing.Color.Transparent;
            this.addEmpBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addEmpBtn.BackgroundImage")));
            this.addEmpBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addEmpBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addEmpBtn.Location = new System.Drawing.Point(342, 604);
            this.addEmpBtn.Margin = new System.Windows.Forms.Padding(2);
            this.addEmpBtn.Name = "addEmpBtn";
            this.addEmpBtn.Size = new System.Drawing.Size(167, 56);
            this.addEmpBtn.TabIndex = 112;
            this.addEmpBtn.UseVisualStyleBackColor = false;
            // 
            // addIF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.addEmpBtn);
            this.Controls.Add(this.FBcoa);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Pres);
            this.Controls.Add(this.HRO);
            this.Controls.Add(this.SV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.topic);
            this.Controls.Add(this.mNames);
            this.Controls.Add(this.FBdetail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.subdate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dept);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.position);
            this.Controls.Add(this.lNames);
            this.Controls.Add(this.fNames);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "addIF";
            this.Size = new System.Drawing.Size(851, 700);
            this.Load += new System.EventHandler(this.panel1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox mNames;
        private System.Windows.Forms.TextBox FBdetail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker subdate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox dept;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox position;
        private System.Windows.Forms.ComboBox lNames;
        private System.Windows.Forms.ComboBox fNames;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox topic;
        private System.Windows.Forms.CheckBox Pres;
        private System.Windows.Forms.CheckBox HRO;
        private System.Windows.Forms.CheckBox SV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox FBcoa;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button addEmpBtn;
    }
}
