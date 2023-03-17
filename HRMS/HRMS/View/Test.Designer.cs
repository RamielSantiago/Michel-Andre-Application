using System;

namespace HRMS.View
{
    partial class Test
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
            this.nav1 = new HRMS.View.Nav();
            this.orgChartView1 = new HRMS.View.OrgChartView();
            this.SuspendLayout();
            // 
            // nav1
            // 
            this.nav1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nav1.Location = new System.Drawing.Point(-5, -3);
            this.nav1.Name = "nav1";
            this.nav1.Size = new System.Drawing.Size(307, 711);
            this.nav1.TabIndex = 0;
            // 
            // orgChartView1
            // 
            this.orgChartView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.orgChartView1.Location = new System.Drawing.Point(302, -3);
            this.orgChartView1.Name = "orgChartView1";
            this.orgChartView1.Size = new System.Drawing.Size(967, 711);
            this.orgChartView1.TabIndex = 1;
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 706);
            this.Controls.Add(this.orgChartView1);
            this.Controls.Add(this.nav1);
            this.Name = "Test";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        private void orgChartView1_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Nav nav1;
        private OrgChartView orgChartView1;
    }
}