namespace HRMS.View.UI.InformationFeedback
{
    partial class ViewIF
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label56 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rSearchBtn = new System.Windows.Forms.Button();
            this.to = new System.Windows.Forms.ComboBox();
            this.from = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.feedback = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.feedback)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label56);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.rSearchBtn);
            this.panel1.Controls.Add(this.to);
            this.panel1.Controls.Add(this.from);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(970, 98);
            this.panel1.TabIndex = 1;
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.label56.Location = new System.Drawing.Point(134, 0);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(36, 29);
            this.label56.TabIndex = 128;
            this.label56.Text = "To";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.label3.Location = new System.Drawing.Point(410, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 29);
            this.label3.TabIndex = 127;
            this.label3.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(847, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1012, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 5;
            // 
            // rSearchBtn
            // 
            this.rSearchBtn.AutoSize = true;
            this.rSearchBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.rSearchBtn.Font = new System.Drawing.Font("Sans Serif Collection", 7F);
            this.rSearchBtn.ForeColor = System.Drawing.Color.White;
            this.rSearchBtn.Location = new System.Drawing.Point(691, 40);
            this.rSearchBtn.Name = "rSearchBtn";
            this.rSearchBtn.Size = new System.Drawing.Size(121, 39);
            this.rSearchBtn.TabIndex = 1;
            this.rSearchBtn.Text = "Search";
            this.rSearchBtn.UseVisualStyleBackColor = false;
            this.rSearchBtn.Click += new System.EventHandler(this.rSearchBtn_Click);
            // 
            // to
            // 
            this.to.BackColor = System.Drawing.Color.LightSkyBlue;
            this.to.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.to.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.to.FormattingEnabled = true;
            this.to.Location = new System.Drawing.Point(139, 41);
            this.to.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(270, 37);
            this.to.TabIndex = 4;
            // 
            // from
            // 
            this.from.BackColor = System.Drawing.Color.LightSkyBlue;
            this.from.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.from.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.from.FormattingEnabled = true;
            this.from.Location = new System.Drawing.Point(415, 41);
            this.from.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(270, 37);
            this.from.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.feedback);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 98);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(970, 759);
            this.panel2.TabIndex = 2;
            // 
            // feedback
            // 
            this.feedback.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.feedback.Dock = System.Windows.Forms.DockStyle.Fill;
            this.feedback.Location = new System.Drawing.Point(0, 0);
            this.feedback.Name = "feedback";
            this.feedback.RowHeadersWidth = 51;
            this.feedback.Size = new System.Drawing.Size(970, 759);
            this.feedback.TabIndex = 0;
            this.feedback.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.feedback_CellContentClick);
            // 
            // ViewIF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ViewIF";
            this.Size = new System.Drawing.Size(970, 857);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.feedback)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button rSearchBtn;
        private System.Windows.Forms.ComboBox to;
        private System.Windows.Forms.ComboBox from;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView feedback;
    }
}
