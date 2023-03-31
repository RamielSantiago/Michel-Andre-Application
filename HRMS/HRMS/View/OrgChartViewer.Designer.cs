namespace HRMS.View
{
    partial class OrgChartViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrgChartViewer));
            this.ToolBar = new System.Windows.Forms.ToolStrip();
            this.ZoomOut = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.ZoomVal = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.NewWindow = new System.Windows.Forms.ToolStripTextBox();
            this.orgChartPic = new System.Windows.Forms.PictureBox();
            this.tableAdapterManager1 = new HRMS.HRMSDBDataSetTableAdapters.TableAdapterManager();
            this.ToolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orgChartPic)).BeginInit();
            this.SuspendLayout();
            // 
            // ToolBar
            // 
            this.ToolBar.BackColor = System.Drawing.Color.Silver;
            this.ToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ZoomOut,
            this.toolStripButton1,
            this.ZoomVal,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.NewWindow});
            this.ToolBar.Location = new System.Drawing.Point(0, 0);
            this.ToolBar.Name = "ToolBar";
            this.ToolBar.Size = new System.Drawing.Size(774, 25);
            this.ToolBar.TabIndex = 0;
            this.ToolBar.Text = "toolStrip1";
            // 
            // ZoomOut
            // 
            this.ZoomOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ZoomOut.Image = ((System.Drawing.Image)(resources.GetObject("ZoomOut.Image")));
            this.ZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ZoomOut.Name = "ZoomOut";
            this.ZoomOut.Padding = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.ZoomOut.Size = new System.Drawing.Size(26, 22);
            this.ZoomOut.Text = "Zoom-";
            this.ZoomOut.Click += new System.EventHandler(this.ZoomOut_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Padding = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.toolStripButton1.Size = new System.Drawing.Size(26, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // ZoomVal
            // 
            this.ZoomVal.Name = "ZoomVal";
            this.ZoomVal.Padding = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.ZoomVal.Size = new System.Drawing.Size(75, 25);
            this.ZoomVal.Click += new System.EventHandler(this.toolStripComboBox1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Padding = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // NewWindow
            // 
            this.NewWindow.BackColor = System.Drawing.Color.LightGray;
            this.NewWindow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NewWindow.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.NewWindow.Margin = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.NewWindow.Name = "NewWindow";
            this.NewWindow.Size = new System.Drawing.Size(95, 25);
            this.NewWindow.Text = "Open in New Window";
            this.NewWindow.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NewWindow.Click += new System.EventHandler(this.toolStripTextBox1_Click);
            // 
            // orgChartPic
            // 
            this.orgChartPic.InitialImage = global::HRMS.Properties.Resources.orgchart;
            this.orgChartPic.Location = new System.Drawing.Point(0, 29);
            this.orgChartPic.Name = "orgChartPic";
            this.orgChartPic.Size = new System.Drawing.Size(774, 448);
            this.orgChartPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.orgChartPic.TabIndex = 1;
            this.orgChartPic.TabStop = false;
            this.orgChartPic.Click += new System.EventHandler(this.orgChartPic_Click);
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.EmployeesTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = HRMS.HRMSDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // OrgChartViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.orgChartPic);
            this.Controls.Add(this.ToolBar);
            this.Name = "OrgChartViewer";
            this.Size = new System.Drawing.Size(774, 480);
            this.ToolBar.ResumeLayout(false);
            this.ToolBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orgChartPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip ToolBar;
        private System.Windows.Forms.ToolStripButton ZoomOut;
        private System.Windows.Forms.ToolStripComboBox ZoomVal;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripTextBox NewWindow;
        private System.Windows.Forms.PictureBox orgChartPic;
        private HRMSDBDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
    }
}
