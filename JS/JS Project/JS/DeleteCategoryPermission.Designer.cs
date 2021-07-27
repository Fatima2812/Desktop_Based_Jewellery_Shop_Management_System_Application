namespace JS
{
    partial class DeleteCategoryPermission
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
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.YesBtnDeleteCategory = new Guna.UI2.WinForms.Guna2Button();
            this.deletepermissionlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // guna2Button1
            // 
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 12;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(60)))), ((int)(((byte)(52)))));
            this.guna2Button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(162, 50);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(60)))), ((int)(((byte)(52)))));
            this.guna2Button1.ShadowDecoration.BorderRadius = 25;
            this.guna2Button1.ShadowDecoration.Depth = 15;
            this.guna2Button1.ShadowDecoration.Enabled = true;
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(66, 27);
            this.guna2Button1.TabIndex = 42;
            this.guna2Button1.Text = "No";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // YesBtnDeleteCategory
            // 
            this.YesBtnDeleteCategory.AutoRoundedCorners = true;
            this.YesBtnDeleteCategory.BackColor = System.Drawing.Color.Transparent;
            this.YesBtnDeleteCategory.BorderRadius = 12;
            this.YesBtnDeleteCategory.CheckedState.Parent = this.YesBtnDeleteCategory;
            this.YesBtnDeleteCategory.CustomImages.Parent = this.YesBtnDeleteCategory;
            this.YesBtnDeleteCategory.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(60)))), ((int)(((byte)(52)))));
            this.YesBtnDeleteCategory.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YesBtnDeleteCategory.ForeColor = System.Drawing.Color.White;
            this.YesBtnDeleteCategory.HoverState.Parent = this.YesBtnDeleteCategory;
            this.YesBtnDeleteCategory.Location = new System.Drawing.Point(82, 50);
            this.YesBtnDeleteCategory.Name = "YesBtnDeleteCategory";
            this.YesBtnDeleteCategory.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(60)))), ((int)(((byte)(52)))));
            this.YesBtnDeleteCategory.ShadowDecoration.BorderRadius = 25;
            this.YesBtnDeleteCategory.ShadowDecoration.Depth = 15;
            this.YesBtnDeleteCategory.ShadowDecoration.Enabled = true;
            this.YesBtnDeleteCategory.ShadowDecoration.Parent = this.YesBtnDeleteCategory;
            this.YesBtnDeleteCategory.Size = new System.Drawing.Size(66, 27);
            this.YesBtnDeleteCategory.TabIndex = 41;
            this.YesBtnDeleteCategory.Text = "Yes";
            this.YesBtnDeleteCategory.Click += new System.EventHandler(this.AddCustBtnOnAddCustWindow_Click);
            // 
            // deletepermissionlabel
            // 
            this.deletepermissionlabel.AutoSize = true;
            this.deletepermissionlabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletepermissionlabel.Location = new System.Drawing.Point(19, 15);
            this.deletepermissionlabel.Name = "deletepermissionlabel";
            this.deletepermissionlabel.Size = new System.Drawing.Size(97, 16);
            this.deletepermissionlabel.TabIndex = 40;
            this.deletepermissionlabel.Text = "Are you sure?";
            // 
            // DeleteCategoryPermission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(247, 92);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.YesBtnDeleteCategory);
            this.Controls.Add(this.deletepermissionlabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeleteCategoryPermission";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteCategoryPermission";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button YesBtnDeleteCategory;
        private System.Windows.Forms.Label deletepermissionlabel;
    }
}