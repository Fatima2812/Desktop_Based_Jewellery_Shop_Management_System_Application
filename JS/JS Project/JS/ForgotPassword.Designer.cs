﻿namespace JS
{
    partial class ForgotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPassword));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Topbar = new System.Windows.Forms.Panel();
            this.ManageUsersLabel = new System.Windows.Forms.Label();
            this.CrossButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.UpdatebrandData = new Guna.UI2.WinForms.Guna2Button();
            this.SignupEmailTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.Topbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CrossButton)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.Topbar.Controls.Add(this.ManageUsersLabel);
            this.Topbar.Controls.Add(this.CrossButton);
            this.Topbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Topbar.Location = new System.Drawing.Point(0, 0);
            this.Topbar.Name = "Topbar";
            this.Topbar.Size = new System.Drawing.Size(756, 34);
            this.Topbar.TabIndex = 6;
            // 
            // ManageUsersLabel
            // 
            this.ManageUsersLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ManageUsersLabel.AutoSize = true;
            this.ManageUsersLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageUsersLabel.ForeColor = System.Drawing.Color.White;
            this.ManageUsersLabel.Location = new System.Drawing.Point(12, 9);
            this.ManageUsersLabel.Name = "ManageUsersLabel";
            this.ManageUsersLabel.Size = new System.Drawing.Size(132, 19);
            this.ManageUsersLabel.TabIndex = 20;
            this.ManageUsersLabel.Text = "Forgot Password";
            // 
            // CrossButton
            // 
            this.CrossButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CrossButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(60)))), ((int)(((byte)(52)))));
            this.CrossButton.Image = ((System.Drawing.Image)(resources.GetObject("CrossButton.Image")));
            this.CrossButton.ImageActive = null;
            this.CrossButton.Location = new System.Drawing.Point(722, 6);
            this.CrossButton.Name = "CrossButton";
            this.CrossButton.Size = new System.Drawing.Size(25, 25);
            this.CrossButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CrossButton.TabIndex = 6;
            this.CrossButton.TabStop = false;
            this.CrossButton.Zoom = 10;
            this.CrossButton.Click += new System.EventHandler(this.CrossButton_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.guna2Button1);
            this.panel1.Controls.Add(this.guna2TextBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.UpdatebrandData);
            this.panel1.Controls.Add(this.SignupEmailTextbox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(22, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(712, 303);
            this.panel1.TabIndex = 8;
            // 
            // UpdatebrandData
            // 
            this.UpdatebrandData.AutoRoundedCorners = true;
            this.UpdatebrandData.BackColor = System.Drawing.Color.Transparent;
            this.UpdatebrandData.BorderRadius = 12;
            this.UpdatebrandData.CheckedState.Parent = this.UpdatebrandData;
            this.UpdatebrandData.CustomImages.Parent = this.UpdatebrandData;
            this.UpdatebrandData.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(60)))), ((int)(((byte)(52)))));
            this.UpdatebrandData.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdatebrandData.ForeColor = System.Drawing.Color.White;
            this.UpdatebrandData.HoverState.Parent = this.UpdatebrandData;
            this.UpdatebrandData.Location = new System.Drawing.Point(420, 102);
            this.UpdatebrandData.Name = "UpdatebrandData";
            this.UpdatebrandData.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(60)))), ((int)(((byte)(52)))));
            this.UpdatebrandData.ShadowDecoration.BorderRadius = 25;
            this.UpdatebrandData.ShadowDecoration.Depth = 20;
            this.UpdatebrandData.ShadowDecoration.Enabled = true;
            this.UpdatebrandData.ShadowDecoration.Parent = this.UpdatebrandData;
            this.UpdatebrandData.Size = new System.Drawing.Size(129, 27);
            this.UpdatebrandData.TabIndex = 33;
            this.UpdatebrandData.Text = "Send Code";
            this.UpdatebrandData.Click += new System.EventHandler(this.UpdatebrandData_Click);
            // 
            // SignupEmailTextbox
            // 
            this.SignupEmailTextbox.BorderColor = System.Drawing.Color.White;
            this.SignupEmailTextbox.BorderRadius = 18;
            this.SignupEmailTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SignupEmailTextbox.DefaultText = "";
            this.SignupEmailTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SignupEmailTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SignupEmailTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SignupEmailTextbox.DisabledState.Parent = this.SignupEmailTextbox;
            this.SignupEmailTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SignupEmailTextbox.FillColor = System.Drawing.Color.WhiteSmoke;
            this.SignupEmailTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SignupEmailTextbox.FocusedState.Parent = this.SignupEmailTextbox;
            this.SignupEmailTextbox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignupEmailTextbox.ForeColor = System.Drawing.Color.Black;
            this.SignupEmailTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SignupEmailTextbox.HoverState.Parent = this.SignupEmailTextbox;
            this.SignupEmailTextbox.Location = new System.Drawing.Point(274, 45);
            this.SignupEmailTextbox.Name = "SignupEmailTextbox";
            this.SignupEmailTextbox.PasswordChar = '\0';
            this.SignupEmailTextbox.PlaceholderText = "";
            this.SignupEmailTextbox.SelectedText = "";
            this.SignupEmailTextbox.ShadowDecoration.Parent = this.SignupEmailTextbox;
            this.SignupEmailTextbox.Size = new System.Drawing.Size(275, 30);
            this.SignupEmailTextbox.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(124, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Enter User Email";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(81, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 16);
            this.label1.TabIndex = 34;
            this.label1.Text = "Enter Verfication Code";
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.BorderColor = System.Drawing.Color.White;
            this.guna2TextBox1.BorderRadius = 18;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.FocusedState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.HoverState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Location = new System.Drawing.Point(274, 157);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.ShadowDecoration.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Size = new System.Drawing.Size(275, 30);
            this.guna2TextBox1.TabIndex = 35;
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
            this.guna2Button1.Location = new System.Drawing.Point(420, 210);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(60)))), ((int)(((byte)(52)))));
            this.guna2Button1.ShadowDecoration.BorderRadius = 25;
            this.guna2Button1.ShadowDecoration.Depth = 20;
            this.guna2Button1.ShadowDecoration.Enabled = true;
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(129, 27);
            this.guna2Button1.TabIndex = 36;
            this.guna2Button1.Text = "Enter";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(756, 381);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Topbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgotPassword";
            this.Topbar.ResumeLayout(false);
            this.Topbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CrossButton)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel Topbar;
        private System.Windows.Forms.Label ManageUsersLabel;
        private Bunifu.Framework.UI.BunifuImageButton CrossButton;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button UpdatebrandData;
        private Guna.UI2.WinForms.Guna2TextBox SignupEmailTextbox;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private System.Windows.Forms.Label label1;
    }
}