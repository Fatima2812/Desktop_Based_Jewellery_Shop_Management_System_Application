namespace JS
{
    partial class UpdateCategoryMessageBox
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
            this.OkayUpdateCategoryBtn = new Guna.UI2.WinForms.Guna2Button();
            this.UpdateCategorylabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // OkayUpdateCategoryBtn
            // 
            this.OkayUpdateCategoryBtn.AutoRoundedCorners = true;
            this.OkayUpdateCategoryBtn.BackColor = System.Drawing.Color.Transparent;
            this.OkayUpdateCategoryBtn.BorderRadius = 12;
            this.OkayUpdateCategoryBtn.CheckedState.Parent = this.OkayUpdateCategoryBtn;
            this.OkayUpdateCategoryBtn.CustomImages.Parent = this.OkayUpdateCategoryBtn;
            this.OkayUpdateCategoryBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(60)))), ((int)(((byte)(52)))));
            this.OkayUpdateCategoryBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OkayUpdateCategoryBtn.ForeColor = System.Drawing.Color.White;
            this.OkayUpdateCategoryBtn.HoverState.Parent = this.OkayUpdateCategoryBtn;
            this.OkayUpdateCategoryBtn.Location = new System.Drawing.Point(122, 50);
            this.OkayUpdateCategoryBtn.Name = "OkayUpdateCategoryBtn";
            this.OkayUpdateCategoryBtn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(60)))), ((int)(((byte)(52)))));
            this.OkayUpdateCategoryBtn.ShadowDecoration.BorderRadius = 25;
            this.OkayUpdateCategoryBtn.ShadowDecoration.Depth = 15;
            this.OkayUpdateCategoryBtn.ShadowDecoration.Enabled = true;
            this.OkayUpdateCategoryBtn.ShadowDecoration.Parent = this.OkayUpdateCategoryBtn;
            this.OkayUpdateCategoryBtn.Size = new System.Drawing.Size(66, 27);
            this.OkayUpdateCategoryBtn.TabIndex = 40;
            this.OkayUpdateCategoryBtn.Text = "Okay";
            this.OkayUpdateCategoryBtn.Click += new System.EventHandler(this.OkayUpdateCategoryBtn_Click);
            // 
            // UpdateCategorylabel
            // 
            this.UpdateCategorylabel.AutoSize = true;
            this.UpdateCategorylabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateCategorylabel.Location = new System.Drawing.Point(50, 20);
            this.UpdateCategorylabel.Name = "UpdateCategorylabel";
            this.UpdateCategorylabel.Size = new System.Drawing.Size(142, 16);
            this.UpdateCategorylabel.TabIndex = 39;
            this.UpdateCategorylabel.Text = "Update Successfully!";
            // 
            // UpdateCategoryMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(247, 92);
            this.Controls.Add(this.OkayUpdateCategoryBtn);
            this.Controls.Add(this.UpdateCategorylabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateCategoryMessageBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateCategoryMessageBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Guna.UI2.WinForms.Guna2Button OkayUpdateCategoryBtn;
        private System.Windows.Forms.Label UpdateCategorylabel;
    }
}