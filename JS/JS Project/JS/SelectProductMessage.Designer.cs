namespace JS
{
    partial class SelectProductMessage
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
            this.AddedLabel = new System.Windows.Forms.Label();
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
            this.AddCustBtnOnAddCustWindow.Location = new System.Drawing.Point(149, 46);
            this.AddCustBtnOnAddCustWindow.Name = "AddCustBtnOnAddCustWindow";
            this.AddCustBtnOnAddCustWindow.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(60)))), ((int)(((byte)(52)))));
            this.AddCustBtnOnAddCustWindow.ShadowDecoration.BorderRadius = 25;
            this.AddCustBtnOnAddCustWindow.ShadowDecoration.Depth = 15;
            this.AddCustBtnOnAddCustWindow.ShadowDecoration.Enabled = true;
            this.AddCustBtnOnAddCustWindow.ShadowDecoration.Parent = this.AddCustBtnOnAddCustWindow;
            this.AddCustBtnOnAddCustWindow.Size = new System.Drawing.Size(66, 27);
            this.AddCustBtnOnAddCustWindow.TabIndex = 61;
            this.AddCustBtnOnAddCustWindow.Text = "Okay";
            this.AddCustBtnOnAddCustWindow.Click += new System.EventHandler(this.AddCustBtnOnAddCustWindow_Click);
            // 
            // AddedLabel
            // 
            this.AddedLabel.AutoSize = true;
            this.AddedLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddedLabel.Location = new System.Drawing.Point(32, 19);
            this.AddedLabel.Name = "AddedLabel";
            this.AddedLabel.Size = new System.Drawing.Size(146, 16);
            this.AddedLabel.TabIndex = 60;
            this.AddedLabel.Text = "Please Select Product";
            // 
            // SelectProductMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(247, 92);
            this.Controls.Add(this.AddCustBtnOnAddCustWindow);
            this.Controls.Add(this.AddedLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SelectProductMessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectProductMessage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Guna.UI2.WinForms.Guna2Button AddCustBtnOnAddCustWindow;
        private System.Windows.Forms.Label AddedLabel;
    }
}