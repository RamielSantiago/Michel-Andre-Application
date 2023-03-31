namespace HRMS.View.Forms
{
    partial class DeleteReport
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
            this.delErrorMsg = new System.Windows.Forms.TextBox();
            this.deleteReportButton = new System.Windows.Forms.Button();
            this.deletecriteria = new System.Windows.Forms.ComboBox();
            this.deletequery = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RegisterLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // delErrorMsg
            // 
            this.delErrorMsg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.delErrorMsg.BackColor = System.Drawing.SystemColors.ControlLight;
            this.delErrorMsg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.delErrorMsg.Font = new System.Drawing.Font("Arial Narrow", 8F);
            this.delErrorMsg.Location = new System.Drawing.Point(472, 159);
            this.delErrorMsg.Multiline = true;
            this.delErrorMsg.Name = "delErrorMsg";
            this.delErrorMsg.ReadOnly = true;
            this.delErrorMsg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.delErrorMsg.Size = new System.Drawing.Size(326, 65);
            this.delErrorMsg.TabIndex = 135;
            // 
            // deleteReportButton
            // 
            this.deleteReportButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deleteReportButton.BackColor = System.Drawing.Color.Goldenrod;
            this.deleteReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteReportButton.Font = new System.Drawing.Font("Arial", 12F);
            this.deleteReportButton.Location = new System.Drawing.Point(281, 162);
            this.deleteReportButton.Name = "deleteReportButton";
            this.deleteReportButton.Size = new System.Drawing.Size(148, 49);
            this.deleteReportButton.TabIndex = 134;
            this.deleteReportButton.Text = "Delete";
            this.deleteReportButton.UseVisualStyleBackColor = false;
            this.deleteReportButton.Click += new System.EventHandler(this.deleteReportButton_Click);
            // 
            // deletecriteria
            // 
            this.deletecriteria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deletecriteria.FormattingEnabled = true;
            this.deletecriteria.Items.AddRange(new object[] {
            "Incident ID"});
            this.deletecriteria.Location = new System.Drawing.Point(232, 121);
            this.deletecriteria.Name = "deletecriteria";
            this.deletecriteria.Size = new System.Drawing.Size(221, 24);
            this.deletecriteria.TabIndex = 133;
            // 
            // deletequery
            // 
            this.deletequery.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deletequery.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.deletequery.Font = new System.Drawing.Font("Arial", 14F);
            this.deletequery.Location = new System.Drawing.Point(459, 120);
            this.deletequery.Multiline = true;
            this.deletequery.Name = "deletequery";
            this.deletequery.Size = new System.Drawing.Size(352, 30);
            this.deletequery.TabIndex = 131;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F);
            this.label1.Location = new System.Drawing.Point(20, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 23);
            this.label1.TabIndex = 132;
            this.label1.Text = "Search and Delete by:";
            // 
            // RegisterLabel
            // 
            this.RegisterLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RegisterLabel.AutoSize = true;
            this.RegisterLabel.Font = new System.Drawing.Font("Arial", 30F);
            this.RegisterLabel.Location = new System.Drawing.Point(139, 48);
            this.RegisterLabel.Name = "RegisterLabel";
            this.RegisterLabel.Size = new System.Drawing.Size(527, 57);
            this.RegisterLabel.TabIndex = 130;
            this.RegisterLabel.Text = "Delete Incident Report";
            // 
            // DeleteReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 270);
            this.Controls.Add(this.delErrorMsg);
            this.Controls.Add(this.deleteReportButton);
            this.Controls.Add(this.deletecriteria);
            this.Controls.Add(this.deletequery);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RegisterLabel);
            this.Name = "DeleteReport";
            this.Text = "DeleteReport";
            this.Load += new System.EventHandler(this.DeleteReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox delErrorMsg;
        private System.Windows.Forms.Button deleteReportButton;
        private System.Windows.Forms.ComboBox deletecriteria;
        private System.Windows.Forms.TextBox deletequery;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label RegisterLabel;
    }
}