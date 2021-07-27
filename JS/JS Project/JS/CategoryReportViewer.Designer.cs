namespace JS
{
    partial class CategoryReportViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryReportViewer));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.Product_CategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Jewelry_management_database_finalDataSet1 = new JS.Jewelry_management_database_finalDataSet1();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Topbar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.CrossButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Product_CategoryTableAdapter = new JS.Jewelry_management_database_finalDataSet1TableAdapters.Product_CategoryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Product_CategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Jewelry_management_database_finalDataSet1)).BeginInit();
            this.Topbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CrossButton)).BeginInit();
            this.SuspendLayout();
            // 
            // Product_CategoryBindingSource
            // 
            this.Product_CategoryBindingSource.DataMember = "Product_Category";
            this.Product_CategoryBindingSource.DataSource = this.Jewelry_management_database_finalDataSet1;
            // 
            // Jewelry_management_database_finalDataSet1
            // 
            this.Jewelry_management_database_finalDataSet1.DataSetName = "Jewelry_management_database_finalDataSet1";
            this.Jewelry_management_database_finalDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.Topbar.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 19);
            this.label1.TabIndex = 19;
            this.label1.Text = "Category Information Report";
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
            // reportViewer2
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Product_CategoryBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "JS.CategoryReport.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(4, 57);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(792, 382);
            this.reportViewer2.TabIndex = 7;
            this.reportViewer2.Load += new System.EventHandler(this.reportViewer2_Load);
            // 
            // Product_CategoryTableAdapter
            // 
            this.Product_CategoryTableAdapter.ClearBeforeFill = true;
            // 
            // CategoryReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer2);
            this.Controls.Add(this.Topbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CategoryReportViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CategoryReportViewer";
            this.Load += new System.EventHandler(this.CategoryReportViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Product_CategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Jewelry_management_database_finalDataSet1)).EndInit();
            this.Topbar.ResumeLayout(false);
            this.Topbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CrossButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel Topbar;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton CrossButton;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource Product_CategoryBindingSource;
        private Jewelry_management_database_finalDataSet1 Jewelry_management_database_finalDataSet1;
        private Jewelry_management_database_finalDataSet1TableAdapters.Product_CategoryTableAdapter Product_CategoryTableAdapter;
    }
}