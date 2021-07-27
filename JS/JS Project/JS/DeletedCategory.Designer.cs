namespace JS
{
    partial class DeletedCategory
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
            this.YesBtnDeleteCategory = new Guna.UI2.WinForms.Guna2Button();
            this.deletepermissionlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
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
            this.YesBtnDeleteCategory.Location = new System.Drawing.Point(121, 53);
            this.YesBtnDeleteCategory.Name = "YesBtnDeleteCategory";
            this.YesBtnDeleteCategory.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(60)))), ((int)(((byte)(52)))));
            this.YesBtnDeleteCategory.ShadowDecoration.BorderRadius = 25;
            this.YesBtnDeleteCategory.ShadowDecoration.Depth = 15;
            this.YesBtnDeleteCategory.ShadowDecoration.Enabled = true;
            this.YesBtnDeleteCategory.ShadowDecoration.Parent = this.YesBtnDeleteCategory;
            this.YesBtnDeleteCategory.Size = new System.Drawing.Size(66, 27);
            this.YesBtnDeleteCategory.TabIndex = 43;
            this.YesBtnDeleteCategory.Text = "Okay";
            this.YesBtnDeleteCategory.Click += new System.EventHandler(this.YesBtnDeleteCategory_Click);
            // 
            // deletepermissionlabel
            // 
            this.deletepermissionlabel.AutoSize = true;
            this.deletepermissionlabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletepermissionlabel.Location = new System.Drawing.Point(40, 20);
            this.deletepermissionlabel.Name = "deletepermissionlabel";
            this.deletepermissionlabel.Size = new System.Drawing.Size(145, 16);
            this.deletepermissionlabel.TabIndex = 42;
            this.deletepermissionlabel.Text = "Deleted Successfully!";
            // 
            // DeletedCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(247, 92);
            this.Controls.Add(this.YesBtnDeleteCategory);
            this.Controls.Add(this.deletepermissionlabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeletedCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeletedCategory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Guna.UI2.WinForms.Guna2Button YesBtnDeleteCategory;
        private System.Windows.Forms.Label deletepermissionlabel;
    }
}