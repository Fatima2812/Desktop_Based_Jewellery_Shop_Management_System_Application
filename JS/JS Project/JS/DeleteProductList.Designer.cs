﻿namespace JS
{
    partial class DeleteProductList
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
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.AddCustBtnOnAddCustWindow = new Guna.UI2.WinForms.Guna2Button();
            this.deletepermissionlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // AddCustBtnOnAddCustWindow
            // 
            this.AddCustBtnOnAddCustWindow.AutoRoundedCorners = true;
            this.AddCustBtnOnAddCustWindow.BackColor = System.Drawing.Color.Transparent;
            this.AddCustBtnOnAddCustWindow.BorderRadius = 12;
            this.AddCustBtnOnAddCustWindow.CheckedState.Parent = this.AddCustBtnOnAddCustWindow;
            this.AddCustBtnOnAddCustWindow.CustomImages.Parent = this.AddCustBtnOnAddCustWindow;
            this.AddCustBtnOnAddCustWindow.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(60)))), ((int)(((byte)(52)))));
            this.AddCustBtnOnAddCustWindow.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCustBtnOnAddCustWindow.ForeColor = System.Drawing.Color.White;
            this.AddCustBtnOnAddCustWindow.HoverState.Parent = this.AddCustBtnOnAddCustWindow;
            this.AddCustBtnOnAddCustWindow.Location = new System.Drawing.Point(128, 47);
            this.AddCustBtnOnAddCustWindow.Name = "AddCustBtnOnAddCustWindow";
            this.AddCustBtnOnAddCustWindow.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(60)))), ((int)(((byte)(52)))));
            this.AddCustBtnOnAddCustWindow.ShadowDecoration.BorderRadius = 25;
            this.AddCustBtnOnAddCustWindow.ShadowDecoration.Depth = 15;
            this.AddCustBtnOnAddCustWindow.ShadowDecoration.Enabled = true;
            this.AddCustBtnOnAddCustWindow.ShadowDecoration.Parent = this.AddCustBtnOnAddCustWindow;
            this.AddCustBtnOnAddCustWindow.Size = new System.Drawing.Size(66, 27);
            this.AddCustBtnOnAddCustWindow.TabIndex = 39;
            this.AddCustBtnOnAddCustWindow.Text = "Okay";
            this.AddCustBtnOnAddCustWindow.Click += new System.EventHandler(this.AddCustBtnOnAddCustWindow_Click);
            // 
            // deletepermissionlabel
            // 
            this.deletepermissionlabel.AutoSize = true;
            this.deletepermissionlabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletepermissionlabel.Location = new System.Drawing.Point(52, 18);
            this.deletepermissionlabel.Name = "deletepermissionlabel";
            this.deletepermissionlabel.Size = new System.Drawing.Size(141, 16);
            this.deletepermissionlabel.TabIndex = 38;
            this.deletepermissionlabel.Text = "Deleted Successfully";
            this.deletepermissionlabel.Click += new System.EventHandler(this.deletepermissionlabel_Click);
            // 
            // DeleteProductList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 92);
            this.Controls.Add(this.AddCustBtnOnAddCustWindow);
            this.Controls.Add(this.deletepermissionlabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeleteProductList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteProductList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Guna.UI2.WinForms.Guna2Button AddCustBtnOnAddCustWindow;
        private System.Windows.Forms.Label deletepermissionlabel;
    }
}