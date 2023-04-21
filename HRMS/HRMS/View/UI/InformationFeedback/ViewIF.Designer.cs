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
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 78);
            this.panel1.TabIndex = 1;
            // 
            // label56
            // 
            this.label56.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label56.AutoSize = true;
            this.label56.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label56.Location = new System.Drawing.Point(114, 13);
            this.label56.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(21, 17);
            this.label56.TabIndex = 128;
            this.label56.Text = "To";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(343, 13);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 127;
            this.label3.Text = "From";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(675, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(810, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 5;
            // 
            // rSearchBtn
            // 
            this.rSearchBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rSearchBtn.AutoSize = true;
            this.rSearchBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.rSearchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rSearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rSearchBtn.Font = new System.Drawing.Font("Franklin Gothic Book", 10F);
            this.rSearchBtn.ForeColor = System.Drawing.Color.White;
            this.rSearchBtn.Location = new System.Drawing.Point(569, 33);
            this.rSearchBtn.Margin = new System.Windows.Forms.Padding(2);
            this.rSearchBtn.Name = "rSearchBtn";
            this.rSearchBtn.Size = new System.Drawing.Size(97, 32);
            this.rSearchBtn.TabIndex = 1;
            this.rSearchBtn.Text = "Search";
            this.rSearchBtn.UseVisualStyleBackColor = false;
            this.rSearchBtn.Click += new System.EventHandler(this.rSearchBtn_Click);
            // 
            // to
            // 
            this.to.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.to.BackColor = System.Drawing.Color.Gainsboro;
            this.to.Cursor = System.Windows.Forms.Cursors.Hand;
            this.to.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.to.Font = new System.Drawing.Font("Franklin Gothic Book", 12F);
            this.to.FormattingEnabled = true;
            this.to.Location = new System.Drawing.Point(117, 34);
            this.to.Margin = new System.Windows.Forms.Padding(2, 8, 2, 2);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(217, 29);
            this.to.TabIndex = 4;
            // 
            // from
            // 
            this.from.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.from.BackColor = System.Drawing.Color.Gainsboro;
            this.from.Cursor = System.Windows.Forms.Cursors.Hand;
            this.from.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.from.Font = new System.Drawing.Font("Franklin Gothic Book", 12F);
            this.from.FormattingEnabled = true;
            this.from.Location = new System.Drawing.Point(343, 34);
            this.from.Margin = new System.Windows.Forms.Padding(2, 4, 2, 2);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(217, 29);
            this.from.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.feedback);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 78);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 608);
            this.panel2.TabIndex = 2;
            // 
            // feedback
            // 
            this.feedback.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.feedback.Dock = System.Windows.Forms.DockStyle.Fill;
            this.feedback.Location = new System.Drawing.Point(0, 0);
            this.feedback.Margin = new System.Windows.Forms.Padding(2);
            this.feedback.Name = "feedback";
            this.feedback.RowHeadersWidth = 51;
            this.feedback.Size = new System.Drawing.Size(776, 608);
            this.feedback.TabIndex = 0;
            this.feedback.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.feedback_CellContentClick);
            // 
            // ViewIF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ViewIF";
            this.Size = new System.Drawing.Size(776, 686);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.feedback)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button rSearchBtn;
        private System.Windows.Forms.ComboBox to;
        private System.Windows.Forms.ComboBox from;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView feedback;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label2;
    }
}
