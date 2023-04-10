namespace HRMS.View
{
    partial class HRMSRegister
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.eViewBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.eAddBtn = new System.Windows.Forms.Button();
            this.eUpdateButton = new System.Windows.Forms.Button();
            this.eViewPanel = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(331, 953);
            this.panel2.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(331, 953);
            this.panel1.TabIndex = 13;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.eViewBtn);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.eAddBtn);
            this.panel3.Controls.Add(this.eUpdateButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(331, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1132, 92);
            this.panel3.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(883, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 19;
            // 
            // eViewBtn
            // 
            this.eViewBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.eViewBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.eViewBtn.Font = new System.Drawing.Font("Franklin Gothic Book", 12F);
            this.eViewBtn.ForeColor = System.Drawing.Color.White;
            this.eViewBtn.Location = new System.Drawing.Point(673, 15);
            this.eViewBtn.Name = "eViewBtn";
            this.eViewBtn.Size = new System.Drawing.Size(144, 58);
            this.eViewBtn.TabIndex = 18;
            this.eViewBtn.Text = "View/Search";
            this.eViewBtn.UseVisualStyleBackColor = false;
            this.eViewBtn.Click += new System.EventHandler(this.eViewBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 24F);
            this.label1.Location = new System.Drawing.Point(20, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 58);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employee List";
            // 
            // eAddBtn
            // 
            this.eAddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.eAddBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.eAddBtn.Font = new System.Drawing.Font("Franklin Gothic Book", 12F);
            this.eAddBtn.ForeColor = System.Drawing.Color.White;
            this.eAddBtn.Location = new System.Drawing.Point(823, 15);
            this.eAddBtn.Name = "eAddBtn";
            this.eAddBtn.Size = new System.Drawing.Size(145, 58);
            this.eAddBtn.TabIndex = 16;
            this.eAddBtn.Text = "Add Employee";
            this.eAddBtn.UseVisualStyleBackColor = false;
            this.eAddBtn.Click += new System.EventHandler(this.eAddBtn_Click);
            // 
            // eUpdateButton
            // 
            this.eUpdateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.eUpdateButton.BackColor = System.Drawing.Color.SteelBlue;
            this.eUpdateButton.Font = new System.Drawing.Font("Franklin Gothic Book", 10F);
            this.eUpdateButton.ForeColor = System.Drawing.Color.White;
            this.eUpdateButton.Location = new System.Drawing.Point(974, 15);
            this.eUpdateButton.Name = "eUpdateButton";
            this.eUpdateButton.Size = new System.Drawing.Size(137, 58);
            this.eUpdateButton.TabIndex = 17;
            this.eUpdateButton.Text = "Update Employee";
            this.eUpdateButton.UseVisualStyleBackColor = false;
            this.eUpdateButton.Click += new System.EventHandler(this.eUpdateButton_Click);
            // 
            // eViewPanel
            // 
            this.eViewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eViewPanel.Location = new System.Drawing.Point(331, 92);
            this.eViewPanel.Name = "eViewPanel";
            this.eViewPanel.Size = new System.Drawing.Size(1132, 861);
            this.eViewPanel.TabIndex = 17;
            // 
            // panel5
            // 
            this.panel5.AutoScroll = true;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(331, 943);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1122, 10);
            this.panel5.TabIndex = 21;
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1453, 92);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 861);
            this.panel4.TabIndex = 19;
            // 
            // HRMSRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.eViewPanel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "HRMSRegister";
            this.Size = new System.Drawing.Size(1463, 953);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button eViewBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button eAddBtn;
        private System.Windows.Forms.Panel eViewPanel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button eUpdateButton;
    }
}
