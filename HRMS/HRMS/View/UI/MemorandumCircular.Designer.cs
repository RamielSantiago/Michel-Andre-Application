namespace HRMS.View.UI
{
    partial class MemorandumCircular
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemorandumCircular));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.delete = new System.Windows.Forms.Button();
            this.upload = new System.Windows.Forms.Button();
            this.pdfreader = new AxAcroPDFLib.AxAcroPDF();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pdfreader)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(331, 828);
            this.panel1.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 24F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(21, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(448, 58);
            this.label1.TabIndex = 1;
            this.label1.Text = "Memorandum Circular";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(877, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.delete);
            this.panel2.Controls.Add(this.upload);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(331, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1094, 92);
            this.panel2.TabIndex = 32;
            // 
            // delete
            // 
            this.delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("delete.BackgroundImage")));
            this.delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.delete.Location = new System.Drawing.Point(940, 15);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(53, 58);
            this.delete.TabIndex = 23;
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // upload
            // 
            this.upload.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("upload.BackgroundImage")));
            this.upload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.upload.Location = new System.Drawing.Point(999, 15);
            this.upload.Name = "upload";
            this.upload.Size = new System.Drawing.Size(53, 58);
            this.upload.TabIndex = 0;
            this.upload.UseVisualStyleBackColor = true;
            this.upload.Click += new System.EventHandler(this.upload_Click);
            // 
            // pdfreader
            // 
            this.pdfreader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pdfreader.Enabled = true;
            this.pdfreader.Location = new System.Drawing.Point(350, 113);
            this.pdfreader.Name = "pdfreader";
            this.pdfreader.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("pdfreader.OcxState")));
            this.pdfreader.Size = new System.Drawing.Size(1051, 695);
            this.pdfreader.TabIndex = 48;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(350, 92);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1051, 21);
            this.panel6.TabIndex = 46;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(331, 92);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(19, 716);
            this.panel5.TabIndex = 47;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1401, 92);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(24, 716);
            this.panel4.TabIndex = 45;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(331, 808);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1094, 20);
            this.panel3.TabIndex = 44;
            // 
            // MemorandumCircular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pdfreader);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MemorandumCircular";
            this.Size = new System.Drawing.Size(1425, 828);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pdfreader)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private AxAcroPDFLib.AxAcroPDF pdfreader;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button upload;
    }
}
