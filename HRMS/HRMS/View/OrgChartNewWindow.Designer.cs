namespace HRMS.View
{
    partial class OrgChartNewWindow
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
            this.orgChartView1 = new HRMS.View.OrgChartView();
            this.SuspendLayout();
            // 
            // orgChartView1
            // 
            this.orgChartView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.orgChartView1.Location = new System.Drawing.Point(-2, 2);
            this.orgChartView1.Name = "orgChartView1";
            this.orgChartView1.Size = new System.Drawing.Size(908, 537);
            this.orgChartView1.TabIndex = 0;
            // 
            // OrgCharNewWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 539);
            this.Controls.Add(this.orgChartView1);
            this.Name = "OrgCharNewWindow";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private OrgChartView orgChartView1;
    }
}