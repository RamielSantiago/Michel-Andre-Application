namespace HRMS.View.UI.PerformanceAppraisal
{
    partial class ViewPerApp
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
            this.mNames = new System.Windows.Forms.ComboBox();
            this.lNames = new System.Windows.Forms.ComboBox();
            this.fNames = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.position = new System.Windows.Forms.ComboBox();
            this.dept = new System.Windows.Forms.ComboBox();
            this.DateAdd = new System.Windows.Forms.DateTimePicker();
            this.searchapp = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.appraisals = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appraisals)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.mNames);
            this.panel1.Controls.Add(this.lNames);
            this.panel1.Controls.Add(this.fNames);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.position);
            this.panel1.Controls.Add(this.dept);
            this.panel1.Controls.Add(this.DateAdd);
            this.panel1.Controls.Add(this.searchapp);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(987, 129);
            this.panel1.TabIndex = 0;
            // 
            // mNames
            // 
            this.mNames.BackColor = System.Drawing.Color.LightSkyBlue;
            this.mNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mNames.Font = new System.Drawing.Font("Franklin Gothic Book", 8F);
            this.mNames.FormattingEnabled = true;
            this.mNames.Location = new System.Drawing.Point(467, 33);
            this.mNames.Name = "mNames";
            this.mNames.Size = new System.Drawing.Size(188, 25);
            this.mNames.TabIndex = 129;
            this.mNames.SelectedIndexChanged += new System.EventHandler(this.mNames_SelectedIndexChanged);
            // 
            // lNames
            // 
            this.lNames.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lNames.Font = new System.Drawing.Font("Franklin Gothic Book", 8F);
            this.lNames.FormattingEnabled = true;
            this.lNames.Location = new System.Drawing.Point(37, 30);
            this.lNames.Name = "lNames";
            this.lNames.Size = new System.Drawing.Size(190, 25);
            this.lNames.TabIndex = 128;
            this.lNames.SelectedIndexChanged += new System.EventHandler(this.lNames_SelectedIndexChanged);
            // 
            // fNames
            // 
            this.fNames.BackColor = System.Drawing.Color.LightSkyBlue;
            this.fNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fNames.Font = new System.Drawing.Font("Franklin Gothic Book", 8F);
            this.fNames.FormattingEnabled = true;
            this.fNames.Location = new System.Drawing.Point(242, 30);
            this.fNames.Name = "fNames";
            this.fNames.Size = new System.Drawing.Size(210, 25);
            this.fNames.TabIndex = 127;
            this.fNames.SelectedIndexChanged += new System.EventHandler(this.fNames_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 24);
            this.label2.TabIndex = 126;
            this.label2.Text = "Last Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(665, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 30);
            this.label6.TabIndex = 121;
            this.label6.Text = "Appraisal Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(373, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 24);
            this.label5.TabIndex = 125;
            this.label5.Text = "Position";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(238, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 24);
            this.label4.TabIndex = 124;
            this.label4.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(463, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 24);
            this.label3.TabIndex = 123;
            this.label3.Text = "Middle Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 24);
            this.label1.TabIndex = 122;
            this.label1.Text = "Department";
            // 
            // position
            // 
            this.position.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.position.Font = new System.Drawing.Font("Franklin Gothic Book", 8F);
            this.position.FormattingEnabled = true;
            this.position.Location = new System.Drawing.Point(373, 93);
            this.position.Margin = new System.Windows.Forms.Padding(4);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(432, 25);
            this.position.TabIndex = 120;
            // 
            // dept
            // 
            this.dept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dept.Font = new System.Drawing.Font("Franklin Gothic Book", 10F);
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
            "MCE Quality Assurance"});
            this.dept.Location = new System.Drawing.Point(84, 92);
            this.dept.Margin = new System.Windows.Forms.Padding(4);
            this.dept.Name = "dept";
            this.dept.Size = new System.Drawing.Size(266, 29);
            this.dept.TabIndex = 119;
            this.dept.SelectedIndexChanged += new System.EventHandler(this.dept_SelectedIndexChanged_1);
            // 
            // DateAdd
            // 
            this.DateAdd.CalendarFont = new System.Drawing.Font("Franklin Gothic Book", 8F);
            this.DateAdd.Location = new System.Drawing.Point(669, 33);
            this.DateAdd.Margin = new System.Windows.Forms.Padding(4);
            this.DateAdd.Name = "DateAdd";
            this.DateAdd.Size = new System.Drawing.Size(230, 22);
            this.DateAdd.TabIndex = 118;
            // 
            // searchapp
            // 
            this.searchapp.BackColor = System.Drawing.Color.SteelBlue;
            this.searchapp.Font = new System.Drawing.Font("Sans Serif Collection", 7F);
            this.searchapp.ForeColor = System.Drawing.Color.White;
            this.searchapp.Location = new System.Drawing.Point(822, 80);
            this.searchapp.Name = "searchapp";
            this.searchapp.Size = new System.Drawing.Size(137, 43);
            this.searchapp.TabIndex = 21;
            this.searchapp.Text = "Search";
            this.searchapp.UseVisualStyleBackColor = false;
            this.searchapp.Click += new System.EventHandler(this.searchapp_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.appraisals);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 129);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(987, 658);
            this.panel2.TabIndex = 1;
            // 
            // appraisals
            // 
            this.appraisals.AllowUserToAddRows = false;
            this.appraisals.AllowUserToDeleteRows = false;
            this.appraisals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appraisals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.appraisals.Location = new System.Drawing.Point(0, 0);
            this.appraisals.Name = "appraisals";
            this.appraisals.ReadOnly = true;
            this.appraisals.RowHeadersWidth = 51;
            this.appraisals.RowTemplate.Height = 24;
            this.appraisals.Size = new System.Drawing.Size(987, 658);
            this.appraisals.TabIndex = 1;
            this.appraisals.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.appraisals_CellContentClick);
            // 
            // ViewPerApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ViewPerApp";
            this.Size = new System.Drawing.Size(987, 787);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.appraisals)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button searchapp;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView appraisals;
        private System.Windows.Forms.ComboBox mNames;
        private System.Windows.Forms.ComboBox lNames;
        private System.Windows.Forms.ComboBox fNames;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox position;
        private System.Windows.Forms.ComboBox dept;
        private System.Windows.Forms.DateTimePicker DateAdd;
    }
}
