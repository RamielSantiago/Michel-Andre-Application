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
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.appsearchcriteria = new System.Windows.Forms.ComboBox();
            this.query = new System.Windows.Forms.ComboBox();
            this.DateAdd = new System.Windows.Forms.DateTimePicker();
            this.searchapp = new System.Windows.Forms.Button();
            this.aID = new System.Windows.Forms.TextBox();
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
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.appsearchcriteria);
            this.panel1.Controls.Add(this.query);
            this.panel1.Controls.Add(this.DateAdd);
            this.panel1.Controls.Add(this.searchapp);
            this.panel1.Controls.Add(this.aID);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 105);
            this.panel1.TabIndex = 0;
            // 
            // label6
            //
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 50);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 21);
            this.label6.TabIndex = 142;
            this.label6.Text = "Search By:";
            //
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Book", 10F);
            this.label4.Location = new System.Drawing.Point(128, 28);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 18);
            this.label4.TabIndex = 140;
            this.label4.Text = "Criteria";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Book", 10F);
            this.label3.Location = new System.Drawing.Point(306, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 18);
            this.label3.TabIndex = 139;
            this.label3.Text = "Query";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(549, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 138;
            // 
            // appsearchcriteria
            // 
            this.appsearchcriteria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.appsearchcriteria.BackColor = System.Drawing.Color.Gainsboro;
            this.appsearchcriteria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.appsearchcriteria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.appsearchcriteria.Font = new System.Drawing.Font("Franklin Gothic Book", 12F);
            this.appsearchcriteria.FormattingEnabled = true;
            this.appsearchcriteria.Items.AddRange(new object[] {
            "Appraisal ID",
            "Last Name",
            "First Name",
            "Department",
            "Date"});
            this.appsearchcriteria.Location = new System.Drawing.Point(133, 50);
            this.appsearchcriteria.Margin = new System.Windows.Forms.Padding(2);
            this.appsearchcriteria.Name = "appsearchcriteria";
            this.appsearchcriteria.Size = new System.Drawing.Size(156, 29);
            this.appsearchcriteria.TabIndex = 135;
            this.appsearchcriteria.SelectedIndexChanged += new System.EventHandler(this.appsearchcriteria_SelectedIndexChanged);
            // 
            // query
            // 
            this.query.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.query.BackColor = System.Drawing.Color.Gainsboro;
            this.query.Cursor = System.Windows.Forms.Cursors.Hand;
            this.query.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.query.Font = new System.Drawing.Font("Franklin Gothic Book", 12F);
            this.query.Items.AddRange(new object[] {
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
            this.query.Location = new System.Drawing.Point(310, 50);
            this.query.Margin = new System.Windows.Forms.Padding(2);
            this.query.Name = "query";
            this.query.Size = new System.Drawing.Size(268, 29);
            this.query.TabIndex = 133;
            this.query.SelectedIndexChanged += new System.EventHandler(this.query_SelectedIndexChanged);
            // 
            // DateAdd
            // 
            this.DateAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DateAdd.CalendarFont = new System.Drawing.Font("Franklin Gothic Book", 8F);
            this.DateAdd.Font = new System.Drawing.Font("Franklin Gothic Book", 12F);
            this.DateAdd.Location = new System.Drawing.Point(310, 53);
            this.DateAdd.Name = "DateAdd";
            this.DateAdd.Size = new System.Drawing.Size(268, 26);
            this.DateAdd.TabIndex = 118;
            // 
            // searchapp
            // 
            this.searchapp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchapp.BackColor = System.Drawing.Color.SteelBlue;
            this.searchapp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchapp.FlatAppearance.BorderSize = 0;
            this.searchapp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchapp.Font = new System.Drawing.Font("Franklin Gothic Book", 10F);
            this.searchapp.ForeColor = System.Drawing.Color.White;
            this.searchapp.Location = new System.Drawing.Point(592, 47);
            this.searchapp.Margin = new System.Windows.Forms.Padding(2);
            this.searchapp.Name = "searchapp";
            this.searchapp.Size = new System.Drawing.Size(103, 35);
            this.searchapp.TabIndex = 21;
            this.searchapp.Text = "Search";
            this.searchapp.UseVisualStyleBackColor = false;
            this.searchapp.Click += new System.EventHandler(this.searchapp_Click);
            // 
            // aID
            // 
            this.aID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.aID.BackColor = System.Drawing.Color.LightSkyBlue;
            this.aID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aID.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aID.ForeColor = System.Drawing.Color.Black;
            this.aID.Location = new System.Drawing.Point(310, 53);
            this.aID.Margin = new System.Windows.Forms.Padding(2);
            this.aID.Name = "aID";
            this.aID.Size = new System.Drawing.Size(268, 26);
            this.aID.TabIndex = 141;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.appraisals);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 105);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(740, 534);
            this.panel2.TabIndex = 1;
            // 
            // appraisals
            // 
            this.appraisals.AllowUserToAddRows = false;
            this.appraisals.AllowUserToDeleteRows = false;
            this.appraisals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appraisals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.appraisals.Location = new System.Drawing.Point(0, 0);
            this.appraisals.Margin = new System.Windows.Forms.Padding(2);
            this.appraisals.Name = "appraisals";
            this.appraisals.ReadOnly = true;
            this.appraisals.RowHeadersWidth = 51;
            this.appraisals.RowTemplate.Height = 24;
            this.appraisals.Size = new System.Drawing.Size(740, 534);
            this.appraisals.TabIndex = 1;
            this.appraisals.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.appraisals_CellContentClick);
            // 
            // ViewPerApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ViewPerApp";
            this.Size = new System.Drawing.Size(740, 639);
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
        private System.Windows.Forms.DateTimePicker DateAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox appsearchcriteria;
        private System.Windows.Forms.ComboBox query;
        private System.Windows.Forms.TextBox aID;
        private System.Windows.Forms.Label label6;
    }
}
