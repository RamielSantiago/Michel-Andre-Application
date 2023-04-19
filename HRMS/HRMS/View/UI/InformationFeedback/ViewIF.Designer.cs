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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.to = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rSearchBtn = new System.Windows.Forms.Button();
            this.position = new System.Windows.Forms.ComboBox();
            this.LastNames = new System.Windows.Forms.ComboBox();
            this.dept = new System.Windows.Forms.ComboBox();
            this.FNames = new System.Windows.Forms.ComboBox();
            this.reports = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reports)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.to);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.rSearchBtn);
            this.panel1.Controls.Add(this.position);
            this.panel1.Controls.Add(this.LastNames);
            this.panel1.Controls.Add(this.dept);
            this.panel1.Controls.Add(this.FNames);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(970, 93);
            this.panel1.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(577, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 24);
            this.label6.TabIndex = 130;
            this.label6.Text = "Position";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(356, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 24);
            this.label5.TabIndex = 129;
            this.label5.Text = "Department";
            // 
            // to
            // 
            this.to.AutoSize = true;
            this.to.Font = new System.Drawing.Font("Sitka Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.to.Location = new System.Drawing.Point(3, 4);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(27, 24);
            this.to.TabIndex = 128;
            this.to.Text = "To";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(177, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 24);
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
            this.rSearchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rSearchBtn.AutoSize = true;
            this.rSearchBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.rSearchBtn.Font = new System.Drawing.Font("Sans Serif Collection", 7F);
            this.rSearchBtn.ForeColor = System.Drawing.Color.White;
            this.rSearchBtn.Location = new System.Drawing.Point(836, 26);
            this.rSearchBtn.Name = "rSearchBtn";
            this.rSearchBtn.Size = new System.Drawing.Size(121, 39);
            this.rSearchBtn.TabIndex = 1;
            this.rSearchBtn.Text = "Search";
            this.rSearchBtn.UseVisualStyleBackColor = false;
            this.rSearchBtn.Click += new System.EventHandler(this.rSearchBtn_Click);
            // 
            // position
            // 
            this.position.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.position.BackColor = System.Drawing.Color.LightSkyBlue;
            this.position.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.position.Font = new System.Drawing.Font("Sans Serif Collection", 5F);
            this.position.FormattingEnabled = true;
            this.position.Location = new System.Drawing.Point(581, 34);
            this.position.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(418, 28);
            this.position.TabIndex = 3;
            // 
            // LastNames
            // 
            this.LastNames.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LastNames.BackColor = System.Drawing.Color.LightSkyBlue;
            this.LastNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LastNames.Font = new System.Drawing.Font("Sans Serif Collection", 5F);
            this.LastNames.FormattingEnabled = true;
            this.LastNames.Location = new System.Drawing.Point(2, 33);
            this.LastNames.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.LastNames.Name = "LastNames";
            this.LastNames.Size = new System.Drawing.Size(216, 28);
            this.LastNames.TabIndex = 4;
            // 
            // dept
            // 
            this.dept.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dept.BackColor = System.Drawing.Color.LightSkyBlue;
            this.dept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dept.Font = new System.Drawing.Font("Sans Serif Collection", 5F);
            this.dept.FormattingEnabled = true;
            this.dept.Items.AddRange(new object[] {
            "President",
            "General Manager",
            "Accounting",
            "Retail Sales Operation",
            "Audit",
            "MIS",
            "Administration",
            "Purchasing",
            "Merchandising",
            "HRMD",
            "Marketing",
            "Creative",
            "Warehouse and Logistics",
            "MCE Production",
            "MCE Quality Assurance",
            "--Department--"});
            this.dept.Location = new System.Drawing.Point(360, 33);
            this.dept.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.dept.Name = "dept";
            this.dept.Size = new System.Drawing.Size(269, 28);
            this.dept.TabIndex = 2;
            this.dept.SelectedIndexChanged += new System.EventHandler(this.dept_SelectedIndexChanged);
            // 
            // FNames
            // 
            this.FNames.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.FNames.BackColor = System.Drawing.Color.LightSkyBlue;
            this.FNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FNames.Font = new System.Drawing.Font("Sans Serif Collection", 5F);
            this.FNames.FormattingEnabled = true;
            this.FNames.Location = new System.Drawing.Point(181, 33);
            this.FNames.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.FNames.Name = "FNames";
            this.FNames.Size = new System.Drawing.Size(216, 28);
            this.FNames.TabIndex = 1;
            // 
            // reports
            // 
            this.reports.AllowUserToAddRows = false;
            this.reports.AllowUserToDeleteRows = false;
            this.reports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reports.Location = new System.Drawing.Point(0, 0);
            this.reports.Name = "reports";
            this.reports.ReadOnly = true;
            this.reports.RowHeadersWidth = 51;
            this.reports.RowTemplate.Height = 24;
            this.reports.Size = new System.Drawing.Size(970, 857);
            this.reports.TabIndex = 2;
            this.reports.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.reports_CellContentClick);
            // 
            // ViewIF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.reports);
            this.Name = "ViewIF";
            this.Size = new System.Drawing.Size(970, 857);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reports)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label to;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button rSearchBtn;
        private System.Windows.Forms.ComboBox position;
        private System.Windows.Forms.ComboBox LastNames;
        private System.Windows.Forms.ComboBox dept;
        private System.Windows.Forms.ComboBox FNames;
        private System.Windows.Forms.DataGridView reports;
    }
}
