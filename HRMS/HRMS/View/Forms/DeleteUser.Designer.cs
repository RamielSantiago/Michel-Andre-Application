namespace HRMS.View.Forms
{
    partial class DeleteUser
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
            this.label1 = new System.Windows.Forms.Label();
            this.RegisterLabel = new System.Windows.Forms.Label();
            this.deletequery = new System.Windows.Forms.TextBox();
            this.deleteUserButton = new System.Windows.Forms.Button();
            this.delErrorMsg = new System.Windows.Forms.TextBox();
            this.deletecriteria = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F);
            this.label1.Location = new System.Drawing.Point(22, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 23);
            this.label1.TabIndex = 126;
            this.label1.Text = "Search and Delete by:";
            // 
            // RegisterLabel
            // 
            this.RegisterLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RegisterLabel.AutoSize = true;
            this.RegisterLabel.Font = new System.Drawing.Font("Arial", 30F);
            this.RegisterLabel.Location = new System.Drawing.Point(204, 45);
            this.RegisterLabel.Name = "RegisterLabel";
            this.RegisterLabel.Size = new System.Drawing.Size(423, 57);
            this.RegisterLabel.TabIndex = 124;
            this.RegisterLabel.Text = "Update Employee";
            // 
            // deletequery
            // 
            this.deletequery.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deletequery.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.deletequery.Font = new System.Drawing.Font("Arial", 14F);
            this.deletequery.Location = new System.Drawing.Point(461, 118);
            this.deletequery.Multiline = true;
            this.deletequery.Name = "deletequery";
            this.deletequery.Size = new System.Drawing.Size(352, 30);
            this.deletequery.TabIndex = 125;
            // 
            // deleteUserButton
            // 
            this.deleteUserButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deleteUserButton.BackColor = System.Drawing.Color.Goldenrod;
            this.deleteUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteUserButton.Font = new System.Drawing.Font("Arial", 12F);
            this.deleteUserButton.Location = new System.Drawing.Point(283, 160);
            this.deleteUserButton.Name = "deleteUserButton";
            this.deleteUserButton.Size = new System.Drawing.Size(148, 49);
            this.deleteUserButton.TabIndex = 128;
            this.deleteUserButton.Text = "Delete";
            this.deleteUserButton.UseVisualStyleBackColor = false;
            this.deleteUserButton.Click += new System.EventHandler(this.deleteUserButton_Click);
            // 
            // delErrorMsg
            // 
            this.delErrorMsg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.delErrorMsg.BackColor = System.Drawing.SystemColors.ControlLight;
            this.delErrorMsg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.delErrorMsg.Font = new System.Drawing.Font("Arial Narrow", 8F);
            this.delErrorMsg.Location = new System.Drawing.Point(474, 157);
            this.delErrorMsg.Multiline = true;
            this.delErrorMsg.Name = "delErrorMsg";
            this.delErrorMsg.ReadOnly = true;
            this.delErrorMsg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.delErrorMsg.Size = new System.Drawing.Size(326, 65);
            this.delErrorMsg.TabIndex = 129;
            // 
            // deletecriteria
            // 
            this.deletecriteria.FormattingEnabled = true;
            this.deletecriteria.Items.AddRange(new object[] {
            "Employee ID",
            "Username"});
            this.deletecriteria.Location = new System.Drawing.Point(234, 118);
            this.deletecriteria.Name = "deletecriteria";
            this.deletecriteria.Size = new System.Drawing.Size(221, 24);
            this.deletecriteria.TabIndex = 130;
            // 
            // DeleteUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 232);
            this.Controls.Add(this.deletecriteria);
            this.Controls.Add(this.delErrorMsg);
            this.Controls.Add(this.deleteUserButton);
            this.Controls.Add(this.deletequery);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RegisterLabel);
            this.Name = "DeleteUser";
            this.Text = "DeleteUser";
            this.Load += new System.EventHandler(this.DeleteUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label RegisterLabel;
        private System.Windows.Forms.TextBox deletequery;
        private System.Windows.Forms.Button deleteUserButton;
        private System.Windows.Forms.TextBox delErrorMsg;
        private System.Windows.Forms.ComboBox deletecriteria;
    }
}