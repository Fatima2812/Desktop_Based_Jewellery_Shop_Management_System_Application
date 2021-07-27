namespace JS
{
    partial class CompanyOrderReportViewer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompanyOrderReportViewer));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.Topbar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.CrossButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Jewelry_management_database_finalDataSet9 = new JS.Jewelry_management_database_finalDataSet9();
            this.Sup_Order_detailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Sup_Order_detailTableAdapter = new JS.Jewelry_management_database_finalDataSet9TableAdapters.Sup_Order_detailTableAdapter();
            this.Topbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CrossButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Jewelry_management_database_finalDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sup_Order_detailBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Topbar
            // 
            this.Topbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(60)))), ((int)(((byte)(52)))));
            this.Topbar.Controls.Add(this.label1);
            this.Topbar.Controls.Add(this.CrossButton);
            this.Topbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Topbar.Location = new System.Drawing.Point(0, 0);
            this.Topbar.Name = "Topbar";
            this.Topbar.Size = new System.Drawing.Size(800, 34);
            this.Topbar.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 19);
            this.label1.TabIndex = 19;
            this.label1.Text = "Company Order Details Report";
            // 
            // CrossButton
            // 
            this.CrossButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CrossButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(60)))), ((int)(((byte)(52)))));
            this.CrossButton.Image = ((System.Drawing.Image)(resources.GetObject("CrossButton.Image")));
            this.CrossButton.ImageActive = null;
            this.CrossButton.Location = new System.Drawing.Point(766, 6);
            this.CrossButton.Name = "CrossButton";
            this.CrossButton.Size = new System.Drawing.Size(25, 25);
            this.CrossButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CrossButton.TabIndex = 6;
            this.CrossButton.TabStop = false;
            this.CrossButton.Zoom = 10;
            this.CrossButton.Click += new System.EventHandler(this.CrossButton_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Sup_Order_detailBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "JS.CompanyOrderDetailsReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 37);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 413);
            this.reportViewer1.TabIndex = 12;
            // 
            // Jewelry_management_database_finalDataSet9
            // 
            this.Jewelry_management_database_finalDataSet9.DataSetName = "Jewelry_management_database_finalDataSet9";
            this.Jewelry_management_database_finalDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Sup_Order_detailBindingSource
            // 
            this.Sup_Order_detailBindingSource.DataMember = "Sup_Order_detail";
            this.Sup_Order_detailBindingSource.DataSource = this.Jewelry_management_database_finalDataSet9;
            // 
            // Sup_Order_detailTableAdapter
            // 
            this.Sup_Order_detailTableAdapter.ClearBeforeFill = true;
            // 
            // CompanyOrderReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.Topbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CompanyOrderReportViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CompanyOrderReportViewer";
            this.Load += new System.EventHandler(this.CompanyOrderReportViewer_Load);
            this.Topbar.ResumeLayout(false);
            this.Topbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CrossButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Jewelry_management_database_finalDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sup_Order_detailBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Topbar;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton CrossButton;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Sup_Order_detailBindingSource;
        private Jewelry_management_database_finalDataSet9 Jewelry_management_database_finalDataSet9;
        private Jewelry_management_database_finalDataSet9TableAdapters.Sup_Order_detailTableAdapter Sup_Order_detailTableAdapter;
    }
}