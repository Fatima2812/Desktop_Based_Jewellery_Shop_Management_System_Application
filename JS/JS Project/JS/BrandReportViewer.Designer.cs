namespace JS
{
    partial class BrandReportViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrandReportViewer));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Topbar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.CrossButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Jewelry_management_database_finalDataSet3 = new JS.Jewelry_management_database_finalDataSet3();
            this.Product_TypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Product_TypeTableAdapter = new JS.Jewelry_management_database_finalDataSet3TableAdapters.Product_TypeTableAdapter();
            this.Topbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CrossButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Jewelry_management_database_finalDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Product_TypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
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
            this.Topbar.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 19);
            this.label1.TabIndex = 19;
            this.label1.Text = "Brand Information Report";
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
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Product_TypeBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "JS.BrandReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 37);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 411);
            this.reportViewer1.TabIndex = 8;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load_1);
            // 
            // Jewelry_management_database_finalDataSet3
            // 
            this.Jewelry_management_database_finalDataSet3.DataSetName = "Jewelry_management_database_finalDataSet3";
            this.Jewelry_management_database_finalDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Product_TypeBindingSource
            // 
            this.Product_TypeBindingSource.DataMember = "Product_Type";
            this.Product_TypeBindingSource.DataSource = this.Jewelry_management_database_finalDataSet3;
            // 
            // Product_TypeTableAdapter
            // 
            this.Product_TypeTableAdapter.ClearBeforeFill = true;
            // 
            // BrandReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.Topbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BrandReportViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BrandReportViewer";
            this.Load += new System.EventHandler(this.BrandReportViewer_Load);
            this.Topbar.ResumeLayout(false);
            this.Topbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CrossButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Jewelry_management_database_finalDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Product_TypeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel Topbar;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton CrossButton;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Product_TypeBindingSource;
        private Jewelry_management_database_finalDataSet3 Jewelry_management_database_finalDataSet3;
        private Jewelry_management_database_finalDataSet3TableAdapters.Product_TypeTableAdapter Product_TypeTableAdapter;
    }
}