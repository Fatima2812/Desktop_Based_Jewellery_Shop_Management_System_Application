namespace JS
{
    partial class CustomerOrdPayRepViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerOrdPayRepViewer));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.Topbar = new System.Windows.Forms.Panel();
            this.CustomerDataLabel = new System.Windows.Forms.Label();
            this.CrossButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Jewelry_management_database_finalDataSet16 = new JS.Jewelry_management_database_finalDataSet16();
            this.Cust_Order_paymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Cust_Order_paymentTableAdapter = new JS.Jewelry_management_database_finalDataSet16TableAdapters.Cust_Order_paymentTableAdapter();
            this.Topbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CrossButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Jewelry_management_database_finalDataSet16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cust_Order_paymentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Topbar
            // 
            this.Topbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(60)))), ((int)(((byte)(52)))));
            this.Topbar.Controls.Add(this.CustomerDataLabel);
            this.Topbar.Controls.Add(this.CrossButton);
            this.Topbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Topbar.Location = new System.Drawing.Point(0, 0);
            this.Topbar.Name = "Topbar";
            this.Topbar.Size = new System.Drawing.Size(800, 34);
            this.Topbar.TabIndex = 5;
            // 
            // CustomerDataLabel
            // 
            this.CustomerDataLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CustomerDataLabel.AutoSize = true;
            this.CustomerDataLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerDataLabel.ForeColor = System.Drawing.Color.White;
            this.CustomerDataLabel.Location = new System.Drawing.Point(3, 8);
            this.CustomerDataLabel.Name = "CustomerDataLabel";
            this.CustomerDataLabel.Size = new System.Drawing.Size(256, 19);
            this.CustomerDataLabel.TabIndex = 19;
            this.CustomerDataLabel.Text = "Customer Order Payment Report";
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
            reportDataSource1.Value = this.Cust_Order_paymentBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "JS.CustPayReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 31);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(797, 417);
            this.reportViewer1.TabIndex = 6;
            // 
            // Jewelry_management_database_finalDataSet16
            // 
            this.Jewelry_management_database_finalDataSet16.DataSetName = "Jewelry_management_database_finalDataSet16";
            this.Jewelry_management_database_finalDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Cust_Order_paymentBindingSource
            // 
            this.Cust_Order_paymentBindingSource.DataMember = "Cust_Order_payment";
            this.Cust_Order_paymentBindingSource.DataSource = this.Jewelry_management_database_finalDataSet16;
            // 
            // Cust_Order_paymentTableAdapter
            // 
            this.Cust_Order_paymentTableAdapter.ClearBeforeFill = true;
            // 
            // CustomerOrdPayRepViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.Topbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerOrdPayRepViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerOrdPayRepViewer";
            this.Load += new System.EventHandler(this.CustomerOrdPayRepViewer_Load);
            this.Topbar.ResumeLayout(false);
            this.Topbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CrossButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Jewelry_management_database_finalDataSet16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cust_Order_paymentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Topbar;
        private System.Windows.Forms.Label CustomerDataLabel;
        private Bunifu.Framework.UI.BunifuImageButton CrossButton;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Cust_Order_paymentBindingSource;
        private Jewelry_management_database_finalDataSet16 Jewelry_management_database_finalDataSet16;
        private Jewelry_management_database_finalDataSet16TableAdapters.Cust_Order_paymentTableAdapter Cust_Order_paymentTableAdapter;
    }
}