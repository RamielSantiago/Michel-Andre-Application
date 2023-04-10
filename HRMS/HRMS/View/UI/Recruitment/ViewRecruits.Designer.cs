namespace HRMS.View.UI.Recruitment
{
    partial class ViewRecruits
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
            this.label2 = new System.Windows.Forms.Label();
            this.PositionSearchDD = new System.Windows.Forms.ComboBox();
            this.DepartmentSearchDD = new System.Windows.Forms.ComboBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fNames = new System.Windows.Forms.ComboBox();
            this.lNames = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.recruitment = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recruitment)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-192, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 24;
            // 
            // PositionSearchDD
            // 
            this.PositionSearchDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PositionSearchDD.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PositionSearchDD.FormattingEnabled = true;
            this.PositionSearchDD.Location = new System.Drawing.Point(537, 31);
            this.PositionSearchDD.Margin = new System.Windows.Forms.Padding(4);
            this.PositionSearchDD.Name = "PositionSearchDD";
            this.PositionSearchDD.Size = new System.Drawing.Size(160, 33);
            this.PositionSearchDD.TabIndex = 29;
            this.PositionSearchDD.SelectedIndexChanged += new System.EventHandler(this.PositionSearchDD_SelectedIndexChanged);
            // 
            // DepartmentSearchDD
            // 
            this.DepartmentSearchDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DepartmentSearchDD.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepartmentSearchDD.FormattingEnabled = true;
            this.DepartmentSearchDD.Items.AddRange(new object[] {
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
            "MCE Quality Assurance"});
            this.DepartmentSearchDD.Location = new System.Drawing.Point(369, 32);
            this.DepartmentSearchDD.Margin = new System.Windows.Forms.Padding(4);
            this.DepartmentSearchDD.Name = "DepartmentSearchDD";
            this.DepartmentSearchDD.Size = new System.Drawing.Size(160, 33);
            this.DepartmentSearchDD.TabIndex = 28;
            this.DepartmentSearchDD.SelectedIndexChanged += new System.EventHandler(this.DepartmentSearchDD_SelectedIndexChanged);
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.SteelBlue;
            this.SearchButton.Font = new System.Drawing.Font("Sans Serif Collection", 7F);
            this.SearchButton.ForeColor = System.Drawing.Color.White;
            this.SearchButton.Location = new System.Drawing.Point(725, 32);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(4);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(140, 34);
            this.SearchButton.TabIndex = 27;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.fNames);
            this.panel1.Controls.Add(this.lNames);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.PositionSearchDD);
            this.panel1.Controls.Add(this.DepartmentSearchDD);
            this.panel1.Controls.Add(this.SearchButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(970, 100);
            this.panel1.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(533, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 24);
            this.label6.TabIndex = 134;
            this.label6.Text = "Position";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(365, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 24);
            this.label5.TabIndex = 133;
            this.label5.Text = "Department";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 24);
            this.label4.TabIndex = 132;
            this.label4.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(197, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 24);
            this.label3.TabIndex = 131;
            this.label3.Text = "First Name";
            // 
            // fNames
            // 
            this.fNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fNames.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fNames.FormattingEnabled = true;
            this.fNames.Location = new System.Drawing.Point(201, 32);
            this.fNames.Margin = new System.Windows.Forms.Padding(4);
            this.fNames.Name = "fNames";
            this.fNames.Size = new System.Drawing.Size(160, 33);
            this.fNames.TabIndex = 32;
            this.fNames.SelectedIndexChanged += new System.EventHandler(this.fNames_SelectedIndexChanged);
            // 
            // lNames
            // 
            this.lNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lNames.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNames.FormattingEnabled = true;
            this.lNames.Location = new System.Drawing.Point(33, 33);
            this.lNames.Margin = new System.Windows.Forms.Padding(4);
            this.lNames.Name = "lNames";
            this.lNames.Size = new System.Drawing.Size(160, 33);
            this.lNames.TabIndex = 31;
            this.lNames.SelectedIndexChanged += new System.EventHandler(this.lNames_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 30;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.recruitment);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(970, 687);
            this.panel2.TabIndex = 31;
            // 
            // recruitment
            // 
            this.recruitment.AllowUserToAddRows = false;
            this.recruitment.AllowUserToDeleteRows = false;
            this.recruitment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recruitment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recruitment.Location = new System.Drawing.Point(0, 0);
            this.recruitment.Name = "recruitment";
            this.recruitment.ReadOnly = true;
            this.recruitment.RowHeadersWidth = 51;
            this.recruitment.RowTemplate.Height = 24;
            this.recruitment.Size = new System.Drawing.Size(970, 687);
            this.recruitment.TabIndex = 0;
            this.recruitment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.recruitment_CellContentClick);
            // 
            // ViewRecruits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Name = "ViewRecruits";
            this.Size = new System.Drawing.Size(970, 787);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.recruitment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox PositionSearchDD;
        private System.Windows.Forms.ComboBox DepartmentSearchDD;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox fNames;
        private System.Windows.Forms.ComboBox lNames;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView recruitment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}
