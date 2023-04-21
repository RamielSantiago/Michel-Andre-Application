namespace HRMS.View.UI.PerformanceAppraisal
{
    partial class PerAppHub
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
            this.pAppViewPanel = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pAppViewBtn = new System.Windows.Forms.Button();
            this.pAppAddBtn = new System.Windows.Forms.Button();
            this.pAppUpdateButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.informationFeedbackTableAdapter1 = new HRMS.HRMSDataSetTableAdapters.InformationFeedbackTableAdapter();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pAppViewPanel
            // 
            this.pAppViewPanel.BackColor = System.Drawing.Color.White;
            this.pAppViewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pAppViewPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.pAppViewPanel.Location = new System.Drawing.Point(248, 75);
            this.pAppViewPanel.Margin = new System.Windows.Forms.Padding(2);
            this.pAppViewPanel.Name = "pAppViewPanel";
            this.pAppViewPanel.Size = new System.Drawing.Size(841, 699);
            this.pAppViewPanel.TabIndex = 28;
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1089, 75);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(8, 699);
            this.panel4.TabIndex = 27;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pAppViewBtn);
            this.panel2.Controls.Add(this.pAppAddBtn);
            this.panel2.Controls.Add(this.pAppUpdateButton);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(248, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(849, 75);
            this.panel2.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(658, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 22;
            // 
            // pAppViewBtn
            // 
            this.pAppViewBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pAppViewBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.pAppViewBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pAppViewBtn.FlatAppearance.BorderSize = 0;
            this.pAppViewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pAppViewBtn.Font = new System.Drawing.Font("Franklin Gothic Book", 10F);
            this.pAppViewBtn.ForeColor = System.Drawing.Color.White;
            this.pAppViewBtn.Location = new System.Drawing.Point(482, 14);
            this.pAppViewBtn.Margin = new System.Windows.Forms.Padding(2);
            this.pAppViewBtn.Name = "pAppViewBtn";
            this.pAppViewBtn.Size = new System.Drawing.Size(115, 47);
            this.pAppViewBtn.TabIndex = 21;
            this.pAppViewBtn.Text = "View / Search";
            this.pAppViewBtn.UseVisualStyleBackColor = false;
            this.pAppViewBtn.Click += new System.EventHandler(this.pAppViewBtn_Click);
            // 
            // pAppAddBtn
            // 
            this.pAppAddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pAppAddBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.pAppAddBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pAppAddBtn.FlatAppearance.BorderSize = 0;
            this.pAppAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pAppAddBtn.Font = new System.Drawing.Font("Franklin Gothic Book", 9F);
            this.pAppAddBtn.ForeColor = System.Drawing.Color.White;
            this.pAppAddBtn.Location = new System.Drawing.Point(601, 14);
            this.pAppAddBtn.Margin = new System.Windows.Forms.Padding(2);
            this.pAppAddBtn.Name = "pAppAddBtn";
            this.pAppAddBtn.Size = new System.Drawing.Size(118, 47);
            this.pAppAddBtn.TabIndex = 19;
            this.pAppAddBtn.Text = "Add Performace Appraisal";
            this.pAppAddBtn.UseVisualStyleBackColor = false;
            this.pAppAddBtn.Click += new System.EventHandler(this.pAppAddBtn_Click);
            // 
            // pAppUpdateButton
            // 
            this.pAppUpdateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pAppUpdateButton.BackColor = System.Drawing.Color.SteelBlue;
            this.pAppUpdateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pAppUpdateButton.FlatAppearance.BorderSize = 0;
            this.pAppUpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pAppUpdateButton.Font = new System.Drawing.Font("Franklin Gothic Book", 9F);
            this.pAppUpdateButton.ForeColor = System.Drawing.Color.White;
            this.pAppUpdateButton.Location = new System.Drawing.Point(723, 14);
            this.pAppUpdateButton.Margin = new System.Windows.Forms.Padding(2);
            this.pAppUpdateButton.Name = "pAppUpdateButton";
            this.pAppUpdateButton.Size = new System.Drawing.Size(110, 47);
            this.pAppUpdateButton.TabIndex = 20;
            this.pAppUpdateButton.Text = "Update Performance Appraisal";
            this.pAppUpdateButton.UseVisualStyleBackColor = false;
            this.pAppUpdateButton.Click += new System.EventHandler(this.pAppUpdateButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 24F);
            this.label1.Location = new System.Drawing.Point(16, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "Performance Appraisal";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 774);
            this.panel1.TabIndex = 26;
            // 
            // informationFeedbackTableAdapter1
            // 
            this.informationFeedbackTableAdapter1.ClearBeforeFill = true;
            // 
            // PerAppHub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pAppViewPanel);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PerAppHub";
            this.Size = new System.Drawing.Size(1097, 774);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pAppViewPanel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button pAppViewBtn;
        private System.Windows.Forms.Button pAppAddBtn;
        private System.Windows.Forms.Button pAppUpdateButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private HRMSDataSetTableAdapters.InformationFeedbackTableAdapter informationFeedbackTableAdapter1;
    }
}
