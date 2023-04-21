namespace HRMS.View.UI.InformationFeedback
{
    partial class EditIF
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
            this.label10 = new System.Windows.Forms.Label();
            this.FBID = new System.Windows.Forms.TextBox();
            this.fID = new System.Windows.Forms.Label();
            this.from = new System.Windows.Forms.ComboBox();
            this.upRepBtn = new System.Windows.Forms.Button();
            this.to = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Pres = new System.Windows.Forms.CheckBox();
            this.HRO = new System.Windows.Forms.CheckBox();
            this.SV = new System.Windows.Forms.CheckBox();
            this.subject = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.FBdate = new System.Windows.Forms.DateTimePicker();
            this.FBdetail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.FBComments = new System.Windows.Forms.TextBox();
            this.complaint = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.RA = new System.Windows.Forms.TextBox();
            this.enableDate = new System.Windows.Forms.CheckBox();
            this.eab = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.label10.Location = new System.Drawing.Point(221, 46);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(285, 69);
            this.label10.TabIndex = 137;
            this.label10.Text = "Fields with (*) are required.\r\nFields left blank will not be updated.\r\n\r\n";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FBID
            // 
            this.FBID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FBID.BackColor = System.Drawing.Color.LightSkyBlue;
            this.FBID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FBID.Font = new System.Drawing.Font("Franklin Gothic Book", 12F);
            this.FBID.ForeColor = System.Drawing.Color.Black;
            this.FBID.Location = new System.Drawing.Point(495, 413);
            this.FBID.Margin = new System.Windows.Forms.Padding(2);
            this.FBID.Name = "FBID";
            this.FBID.Size = new System.Drawing.Size(213, 26);
            this.FBID.TabIndex = 136;
            // 
            // fID
            // 
            this.fID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fID.Font = new System.Drawing.Font("Franklin Gothic Book", 10F);
            this.fID.Location = new System.Drawing.Point(492, 387);
            this.fID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fID.Name = "fID";
            this.fID.Size = new System.Drawing.Size(194, 24);
            this.fID.TabIndex = 135;
            this.fID.Text = "Feedback ID*";
            // 
            // from
            // 
            this.from.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.from.BackColor = System.Drawing.Color.Gainsboro;
            this.from.Cursor = System.Windows.Forms.Cursors.Hand;
            this.from.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.from.Font = new System.Drawing.Font("Franklin Gothic Book", 12F);
            this.from.FormattingEnabled = true;
            this.from.Location = new System.Drawing.Point(378, 154);
            this.from.Margin = new System.Windows.Forms.Padding(2);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(210, 29);
            this.from.TabIndex = 134;
            this.from.SelectedIndexChanged += new System.EventHandler(this.from_SelectedIndexChanged);
            // 
            // upRepBtn
            // 
            this.upRepBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.upRepBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.upRepBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.upRepBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.upRepBtn.FlatAppearance.BorderSize = 0;
            this.upRepBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.upRepBtn.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upRepBtn.ForeColor = System.Drawing.Color.White;
            this.upRepBtn.Location = new System.Drawing.Point(315, 512);
            this.upRepBtn.Margin = new System.Windows.Forms.Padding(2);
            this.upRepBtn.Name = "upRepBtn";
            this.upRepBtn.Size = new System.Drawing.Size(99, 46);
            this.upRepBtn.TabIndex = 133;
            this.upRepBtn.Text = "Update";
            this.upRepBtn.UseVisualStyleBackColor = false;
            this.upRepBtn.Click += new System.EventHandler(this.upRepBtn_Click);
            // 
            // to
            // 
            this.to.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.to.BackColor = System.Drawing.Color.Gainsboro;
            this.to.Cursor = System.Windows.Forms.Cursors.Hand;
            this.to.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.to.Font = new System.Drawing.Font("Franklin Gothic Book", 12F);
            this.to.FormattingEnabled = true;
            this.to.Location = new System.Drawing.Point(119, 154);
            this.to.Margin = new System.Windows.Forms.Padding(2);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(213, 29);
            this.to.TabIndex = 119;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Book", 10F);
            this.label3.Location = new System.Drawing.Point(375, 134);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 24);
            this.label3.TabIndex = 118;
            this.label3.Text = "From";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Book", 10F);
            this.label1.Location = new System.Drawing.Point(116, 134);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 24);
            this.label1.TabIndex = 116;
            this.label1.Text = "To";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Book", 10F);
            this.label5.Location = new System.Drawing.Point(534, 282);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 24);
            this.label5.TabIndex = 145;
            this.label5.Text = "Approved By";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Pres
            // 
            this.Pres.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Pres.AutoSize = true;
            this.Pres.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pres.Font = new System.Drawing.Font("Franklin Gothic Book", 10F);
            this.Pres.Location = new System.Drawing.Point(608, 340);
            this.Pres.Name = "Pres";
            this.Pres.Size = new System.Drawing.Size(84, 22);
            this.Pres.TabIndex = 144;
            this.Pres.Text = "President";
            this.Pres.UseVisualStyleBackColor = true;
            this.Pres.CheckedChanged += new System.EventHandler(this.Pres_CheckedChanged);
            // 
            // HRO
            // 
            this.HRO.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HRO.AutoSize = true;
            this.HRO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HRO.Font = new System.Drawing.Font("Franklin Gothic Book", 10F);
            this.HRO.Location = new System.Drawing.Point(608, 310);
            this.HRO.Name = "HRO";
            this.HRO.Size = new System.Drawing.Size(88, 22);
            this.HRO.TabIndex = 143;
            this.HRO.Text = "HR Officer";
            this.HRO.UseVisualStyleBackColor = true;
            this.HRO.CheckedChanged += new System.EventHandler(this.HRO_CheckedChanged);
            // 
            // SV
            // 
            this.SV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SV.AutoSize = true;
            this.SV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SV.Font = new System.Drawing.Font("Franklin Gothic Book", 10F);
            this.SV.Location = new System.Drawing.Point(512, 339);
            this.SV.Name = "SV";
            this.SV.Size = new System.Drawing.Size(90, 22);
            this.SV.TabIndex = 142;
            this.SV.Text = "Supervisor";
            this.SV.UseVisualStyleBackColor = true;
            this.SV.CheckedChanged += new System.EventHandler(this.SV_CheckedChanged);
            // 
            // subject
            // 
            this.subject.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.subject.BackColor = System.Drawing.Color.LightSkyBlue;
            this.subject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.subject.Font = new System.Drawing.Font("Franklin Gothic Book", 12F);
            this.subject.ForeColor = System.Drawing.Color.Black;
            this.subject.Location = new System.Drawing.Point(265, 236);
            this.subject.Margin = new System.Windows.Forms.Padding(2);
            this.subject.Name = "subject";
            this.subject.Size = new System.Drawing.Size(443, 26);
            this.subject.TabIndex = 149;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Book", 10F);
            this.label4.Location = new System.Drawing.Point(260, 210);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(281, 24);
            this.label4.TabIndex = 148;
            this.label4.Text = "Subject";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Book", 10F);
            this.label6.Location = new System.Drawing.Point(19, 214);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 24);
            this.label6.TabIndex = 150;
            this.label6.Text = "Date";
            // 
            // FBdate
            // 
            this.FBdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FBdate.CalendarFont = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FBdate.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FBdate.Location = new System.Drawing.Point(22, 235);
            this.FBdate.Margin = new System.Windows.Forms.Padding(2);
            this.FBdate.Name = "FBdate";
            this.FBdate.Size = new System.Drawing.Size(213, 22);
            this.FBdate.TabIndex = 151;
            // 
            // FBdetail
            // 
            this.FBdetail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FBdetail.BackColor = System.Drawing.Color.LightSkyBlue;
            this.FBdetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FBdetail.Font = new System.Drawing.Font("Franklin Gothic Book", 12F);
            this.FBdetail.ForeColor = System.Drawing.Color.Black;
            this.FBdetail.Location = new System.Drawing.Point(27, 301);
            this.FBdetail.Margin = new System.Windows.Forms.Padding(2);
            this.FBdetail.Multiline = true;
            this.FBdetail.Name = "FBdetail";
            this.FBdetail.Size = new System.Drawing.Size(446, 65);
            this.FBdetail.TabIndex = 152;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Book", 10F);
            this.label2.Location = new System.Drawing.Point(24, 281);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 18);
            this.label2.TabIndex = 153;
            this.label2.Text = "Details of Issue";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Book", 10F);
            this.label7.Location = new System.Drawing.Point(24, 385);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 24);
            this.label7.TabIndex = 155;
            this.label7.Text = "Comments";
            // 
            // FBComments
            // 
            this.FBComments.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FBComments.BackColor = System.Drawing.Color.LightSkyBlue;
            this.FBComments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FBComments.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FBComments.ForeColor = System.Drawing.Color.Black;
            this.FBComments.Location = new System.Drawing.Point(26, 411);
            this.FBComments.Margin = new System.Windows.Forms.Padding(2);
            this.FBComments.Multiline = true;
            this.FBComments.Name = "FBComments";
            this.FBComments.Size = new System.Drawing.Size(209, 64);
            this.FBComments.TabIndex = 154;
            // 
            // complaint
            // 
            this.complaint.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.complaint.AutoSize = true;
            this.complaint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.complaint.Font = new System.Drawing.Font("Franklin Gothic Book", 10F);
            this.complaint.Location = new System.Drawing.Point(512, 310);
            this.complaint.Name = "complaint";
            this.complaint.Size = new System.Drawing.Size(85, 22);
            this.complaint.TabIndex = 156;
            this.complaint.Text = "Complaint";
            this.complaint.UseVisualStyleBackColor = true;
            this.complaint.CheckedChanged += new System.EventHandler(this.complaint_CheckedChanged);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Franklin Gothic Book", 10F);
            this.label8.Location = new System.Drawing.Point(260, 386);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(198, 24);
            this.label8.TabIndex = 158;
            this.label8.Text = "Recommended Action";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // RA
            // 
            this.RA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RA.BackColor = System.Drawing.Color.LightSkyBlue;
            this.RA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RA.Font = new System.Drawing.Font("Franklin Gothic Book", 12F);
            this.RA.ForeColor = System.Drawing.Color.Black;
            this.RA.Location = new System.Drawing.Point(265, 412);
            this.RA.Margin = new System.Windows.Forms.Padding(2);
            this.RA.Multiline = true;
            this.RA.Name = "RA";
            this.RA.Size = new System.Drawing.Size(208, 64);
            this.RA.TabIndex = 157;
            // 
            // enableDate
            // 
            this.enableDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.enableDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enableDate.Font = new System.Drawing.Font("Franklin Gothic Book", 10F);
            this.enableDate.Location = new System.Drawing.Point(57, 210);
            this.enableDate.Name = "enableDate";
            this.enableDate.Size = new System.Drawing.Size(61, 22);
            this.enableDate.TabIndex = 159;
            this.enableDate.Text = "Edit?";
            this.enableDate.UseVisualStyleBackColor = true;
            this.enableDate.CheckedChanged += new System.EventHandler(this.enableDate_CheckedChanged);
            // 
            // eab
            // 
            this.eab.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.eab.AutoSize = true;
            this.eab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eab.Font = new System.Drawing.Font("Franklin Gothic Book", 10F);
            this.eab.Location = new System.Drawing.Point(618, 282);
            this.eab.Name = "eab";
            this.eab.Size = new System.Drawing.Size(57, 22);
            this.eab.TabIndex = 160;
            this.eab.Text = "Edit?";
            this.eab.UseVisualStyleBackColor = true;
            this.eab.CheckedChanged += new System.EventHandler(this.eab_CheckedChanged);
            // 
            // panel1
            //
            this.panel1.Controls.Add(this.FBComments);
            this.panel1.Controls.Add(this.eab);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.complaint);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Pres);
            this.panel1.Controls.Add(this.subject);
            this.panel1.Controls.Add(this.HRO);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.SV);
            this.panel1.Controls.Add(this.enableDate);
            this.panel1.Controls.Add(this.RA);
            this.panel1.Controls.Add(this.FBdetail);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.FBdate);
            this.panel1.Controls.Add(this.from);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.to);
            this.panel1.Controls.Add(this.upRepBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.FBID);
            this.panel1.Controls.Add(this.fID);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(728, 609);
            this.panel1.TabIndex = 161;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            //
            // EditIF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "EditIF";
            this.Size = new System.Drawing.Size(728, 609);
            this.Load += new System.EventHandler(this.EditIF_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox FBID;
        private System.Windows.Forms.Label fID;
        private System.Windows.Forms.ComboBox from;
        private System.Windows.Forms.Button upRepBtn;
        private System.Windows.Forms.ComboBox to;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox Pres;
        private System.Windows.Forms.CheckBox HRO;
        private System.Windows.Forms.CheckBox SV;
        private System.Windows.Forms.TextBox subject;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker FBdate;
        private System.Windows.Forms.TextBox FBdetail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox FBComments;
        private System.Windows.Forms.CheckBox complaint;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox RA;
        private System.Windows.Forms.CheckBox enableDate;
        private System.Windows.Forms.CheckBox eab;
        private System.Windows.Forms.Panel panel1;
    }
}
