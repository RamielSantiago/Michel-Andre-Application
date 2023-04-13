namespace HRMS.View.UI
{
    partial class HRMSLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HRMSLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.logBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.logpass = new System.Windows.Forms.TextBox();
            this.logname = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(343, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 211);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.logBtn);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.logpass);
            this.panel2.Controls.Add(this.logname);
            this.panel2.Location = new System.Drawing.Point(245, 276);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(521, 296);
            this.panel2.TabIndex = 1;
            // 
            // logBtn
            // 
            this.logBtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.logBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.logBtn.FlatAppearance.BorderSize = 2;
            this.logBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.logBtn.Font = new System.Drawing.Font("Sans Serif Collection", 8F);
            this.logBtn.ForeColor = System.Drawing.Color.Black;
            this.logBtn.Location = new System.Drawing.Point(203, 218);
            this.logBtn.Name = "logBtn";
            this.logBtn.Size = new System.Drawing.Size(101, 40);
            this.logBtn.TabIndex = 4;
            this.logBtn.Text = "Login";
            this.logBtn.UseVisualStyleBackColor = false;
            this.logBtn.Click += new System.EventHandler(this.logBtn_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 16F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(30, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 16F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // logpass
            // 
            this.logpass.BackColor = System.Drawing.Color.LightSkyBlue;
            this.logpass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logpass.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.logpass.ForeColor = System.Drawing.Color.Black;
            this.logpass.Location = new System.Drawing.Point(37, 157);
            this.logpass.Name = "logpass";
            this.logpass.PasswordChar = '*';
            this.logpass.Size = new System.Drawing.Size(441, 33);
            this.logpass.TabIndex = 1;
            // 
            // logname
            // 
            this.logname.BackColor = System.Drawing.Color.LightSkyBlue;
            this.logname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logname.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.logname.ForeColor = System.Drawing.Color.Black;
            this.logname.Location = new System.Drawing.Point(37, 64);
            this.logname.Name = "logname";
            this.logname.Size = new System.Drawing.Size(441, 33);
            this.logname.TabIndex = 0;
            // 
            // HRMSLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1002, 653);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "HRMSLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Human Resource Management System";
            this.Load += new System.EventHandler(this.HRMSLogin_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button logBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox logpass;
        private System.Windows.Forms.TextBox logname;
    }
}