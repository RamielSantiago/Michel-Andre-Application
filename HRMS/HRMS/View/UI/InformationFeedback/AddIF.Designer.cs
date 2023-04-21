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
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.complaint = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.subject = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Pres = new System.Windows.Forms.CheckBox();
            this.HRO = new System.Windows.Forms.CheckBox();
            this.SV = new System.Windows.Forms.CheckBox();
            this.from = new System.Windows.Forms.ComboBox();
            this.addIFBtn = new System.Windows.Forms.Button();
            this.to = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FBComments = new System.Windows.Forms.TextBox();
            this.RA = new System.Windows.Forms.TextBox();
            this.FBdetail = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Sitka Text", 14F);
            this.label10.Location = new System.Drawing.Point(186, 30);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(356, 84);
            this.label10.TabIndex = 43;
            this.label10.Text = "Fields with (*) are required.\r\nTicked Checkboxes mean the signature\r\nhas been add" +
    "ed. ";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Franklin Gothic Book", 10F);
            this.label8.Location = new System.Drawing.Point(258, 383);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 18);
            this.label8.TabIndex = 180;
            this.label8.Text = "Recommended Action*";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // complaint
            // 
            this.complaint.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.complaint.AutoSize = true;
            this.complaint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.complaint.Font = new System.Drawing.Font("Franklin Gothic Book", 10F);
            this.complaint.Location = new System.Drawing.Point(506, 414);
            this.complaint.Name = "complaint";
            this.complaint.Size = new System.Drawing.Size(85, 22);
            this.complaint.TabIndex = 178;
            this.complaint.Text = "Complaint";
            this.complaint.UseVisualStyleBackColor = true;
            this.complaint.CheckedChanged += new System.EventHandler(this.complaint_CheckedChanged);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Book", 10F);
            this.label7.Location = new System.Drawing.Point(20, 383);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 18);
            this.label7.TabIndex = 177;
            this.label7.Text = "Comments";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Book", 10F);
            this.label2.Location = new System.Drawing.Point(20, 275);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 18);
            this.label2.TabIndex = 175;
            this.label2.Text = "Details of Issue*";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // date
            // 
            this.date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.date.CalendarFont = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Cursor = System.Windows.Forms.Cursors.Hand;
            this.date.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(19, 233);
            this.date.Margin = new System.Windows.Forms.Padding(2);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(213, 22);
            this.date.TabIndex = 173;
            this.date.ValueChanged += new System.EventHandler(this.date_ValueChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Book", 10F);
            this.label6.Location = new System.Drawing.Point(16, 213);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 18);
            this.label6.TabIndex = 172;
            this.label6.Text = "Date Submitted*";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // subject
            // 
            this.subject.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.subject.BackColor = System.Drawing.Color.LightSkyBlue;
            this.subject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.subject.Font = new System.Drawing.Font("Franklin Gothic Book", 12F);
            this.subject.ForeColor = System.Drawing.Color.Black;
            this.subject.Location = new System.Drawing.Point(262, 234);
            this.subject.Margin = new System.Windows.Forms.Padding(2);
            this.subject.Name = "subject";
            this.subject.Size = new System.Drawing.Size(443, 26);
            this.subject.TabIndex = 171;
            this.subject.TextChanged += new System.EventHandler(this.subject_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Book", 10F);
            this.label4.Location = new System.Drawing.Point(259, 213);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 18);
            this.label4.TabIndex = 170;
            this.label4.Text = "Subject*";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Book", 10F);
            this.label5.Location = new System.Drawing.Point(555, 383);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 18);
            this.label5.TabIndex = 169;
            this.label5.Text = "Approved By";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Pres
            // 
            this.Pres.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Pres.AutoSize = true;
            this.Pres.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pres.Font = new System.Drawing.Font("Franklin Gothic Book", 10F);
            this.Pres.Location = new System.Drawing.Point(614, 446);
            this.Pres.Name = "Pres";
            this.Pres.Size = new System.Drawing.Size(84, 22);
            this.Pres.TabIndex = 168;
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
            this.HRO.Location = new System.Drawing.Point(614, 414);
            this.HRO.Name = "HRO";
            this.HRO.Size = new System.Drawing.Size(88, 22);
            this.HRO.TabIndex = 167;
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
            this.SV.Location = new System.Drawing.Point(506, 446);
            this.SV.Name = "SV";
            this.SV.Size = new System.Drawing.Size(90, 22);
            this.SV.TabIndex = 166;
            this.SV.Text = "Supervisor";
            this.SV.UseVisualStyleBackColor = true;
            this.SV.CheckedChanged += new System.EventHandler(this.SV_CheckedChanged);
            // 
            // from
            // 
            this.from.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.from.BackColor = System.Drawing.Color.Gainsboro;
            this.from.Cursor = System.Windows.Forms.Cursors.Hand;
            this.from.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.from.Font = new System.Drawing.Font("Franklin Gothic Book", 12F);
            this.from.FormattingEnabled = true;
            this.from.Location = new System.Drawing.Point(375, 160);
            this.from.Margin = new System.Windows.Forms.Padding(2);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(210, 29);
            this.from.TabIndex = 163;
            this.from.SelectedIndexChanged += new System.EventHandler(this.from_SelectedIndexChanged);
            // 
            // addIFBtn
            // 
            this.addIFBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addIFBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.addIFBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addIFBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addIFBtn.FlatAppearance.BorderSize = 0;
            this.addIFBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addIFBtn.Font = new System.Drawing.Font("Franklin Gothic Book", 10F);
            this.addIFBtn.ForeColor = System.Drawing.Color.White;
            this.addIFBtn.Location = new System.Drawing.Point(315, 505);
            this.addIFBtn.Margin = new System.Windows.Forms.Padding(2);
            this.addIFBtn.Name = "addIFBtn";
            this.addIFBtn.Size = new System.Drawing.Size(99, 46);
            this.addIFBtn.TabIndex = 162;
            this.addIFBtn.Text = "Add";
            this.addIFBtn.UseVisualStyleBackColor = false;
            this.addIFBtn.Click += new System.EventHandler(this.addIFBtn_Click);
            // 
            // to
            // 
            this.to.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.to.BackColor = System.Drawing.Color.Gainsboro;
            this.to.Cursor = System.Windows.Forms.Cursors.Hand;
            this.to.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.to.Font = new System.Drawing.Font("Franklin Gothic Book", 12F);
            this.to.FormattingEnabled = true;
            this.to.Location = new System.Drawing.Point(116, 160);
            this.to.Margin = new System.Windows.Forms.Padding(2);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(213, 29);
            this.to.TabIndex = 161;
            this.to.SelectedIndexChanged += new System.EventHandler(this.to_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Book", 10F);
            this.label3.Location = new System.Drawing.Point(372, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 18);
            this.label3.TabIndex = 160;
            this.label3.Text = "From*";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Book", 10F);
            this.label1.Location = new System.Drawing.Point(113, 140);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 18);
            this.label1.TabIndex = 159;
            this.label1.Text = "To*";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            //
            // panel1
            //
            this.panel1.Controls.Add(this.FBComments);
            this.panel1.Controls.Add(this.addIFBtn);
            this.panel1.Controls.Add(this.from);
            this.panel1.Controls.Add(this.subject);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.to);
            this.panel1.Controls.Add(this.date);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.complaint);
            this.panel1.Controls.Add(this.FBdetail);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.RA);
            this.panel1.Controls.Add(this.HRO);
            this.panel1.Controls.Add(this.SV);
            this.panel1.Controls.Add(this.Pres);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(728, 609);
            this.panel1.TabIndex = 181;
            //
            // FBComments
            //
            this.FBComments.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FBComments.BackColor = System.Drawing.Color.LightSkyBlue;
            this.FBComments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FBComments.Font = new System.Drawing.Font("Franklin Gothic Book", 12F);
            this.FBComments.ForeColor = System.Drawing.Color.Black;
            this.FBComments.Location = new System.Drawing.Point(23, 403);
            this.FBComments.Margin = new System.Windows.Forms.Padding(2);
            this.FBComments.Multiline = true;
            this.FBComments.Name = "FBComments";
            this.FBComments.Size = new System.Drawing.Size(209, 65);
            this.FBComments.TabIndex = 176;
            this.FBComments.TextChanged += new System.EventHandler(this.FBComments_TextChanged);
            //
            // RA
            //
            this.RA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RA.BackColor = System.Drawing.Color.LightSkyBlue;
            this.RA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RA.Font = new System.Drawing.Font("Franklin Gothic Book", 12F);
            this.RA.ForeColor = System.Drawing.Color.Black;
            this.RA.Location = new System.Drawing.Point(261, 403);
            this.RA.Margin = new System.Windows.Forms.Padding(2);
            this.RA.Multiline = true;
            this.RA.Name = "RA";
            this.RA.Size = new System.Drawing.Size(209, 65);
            this.RA.TabIndex = 179;
            this.RA.TextChanged += new System.EventHandler(this.RA_TextChanged);
            //
            // FBdetail
            //
            this.FBdetail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FBdetail.BackColor = System.Drawing.Color.LightSkyBlue;
            this.FBdetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FBdetail.Font = new System.Drawing.Font("Franklin Gothic Book", 12F);
            this.FBdetail.ForeColor = System.Drawing.Color.Black;
            this.FBdetail.Location = new System.Drawing.Point(23, 295);
            this.FBdetail.Margin = new System.Windows.Forms.Padding(2);
            this.FBdetail.Multiline = true;
            this.FBdetail.Name = "FBdetail";
            this.FBdetail.Size = new System.Drawing.Size(683, 65);
            this.FBdetail.TabIndex = 174;
            this.FBdetail.TextChanged += new System.EventHandler(this.FBdetail_TextChanged);
            // 
            // addIF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "addIF";
            this.Size = new System.Drawing.Size(728, 609);
            this.Load += new System.EventHandler(this.panel1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox complaint;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox subject;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox Pres;
        private System.Windows.Forms.CheckBox HRO;
        private System.Windows.Forms.CheckBox SV;
        private System.Windows.Forms.ComboBox from;
        private System.Windows.Forms.Button addIFBtn;
        private System.Windows.Forms.ComboBox to;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox FBComments;
        private System.Windows.Forms.TextBox FBdetail;
        private System.Windows.Forms.TextBox RA;
    }
}
