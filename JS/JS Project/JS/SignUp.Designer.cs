namespace JS
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.SignupButton = new Guna.UI2.WinForms.Guna2Button();
            this.SignupPasswordTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.SignupEmailTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.Signuptaglinelabel = new System.Windows.Forms.Label();
            this.SignUpLabel = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.SignupAccountTypeCombobox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.SignupUserNameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.SignupPhoneNumberTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.CrossButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CrossButton)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.Logo);
            this.panel1.Location = new System.Drawing.Point(-6, -20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(446, 583);
            this.panel1.TabIndex = 11;
            // 
            // Logo
            // 
            this.Logo.Image = global::JS.Properties.Resources.madrion;
            this.Logo.Location = new System.Drawing.Point(-143, 14);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(741, 497);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            this.Logo.Click += new System.EventHandler(this.Logo_Click);
            // 
            // SignupButton
            // 
            this.SignupButton.AutoRoundedCorners = true;
            this.SignupButton.BackColor = System.Drawing.Color.Transparent;
            this.SignupButton.BorderRadius = 17;
            this.SignupButton.CheckedState.Parent = this.SignupButton;
            this.SignupButton.CustomImages.Parent = this.SignupButton;
            this.SignupButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(60)))), ((int)(((byte)(52)))));
            this.SignupButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignupButton.ForeColor = System.Drawing.Color.White;
            this.SignupButton.HoverState.Parent = this.SignupButton;
            this.SignupButton.Location = new System.Drawing.Point(545, 468);
            this.SignupButton.Name = "SignupButton";
            this.SignupButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(60)))), ((int)(((byte)(52)))));
            this.SignupButton.ShadowDecoration.BorderRadius = 30;
            this.SignupButton.ShadowDecoration.Depth = 21;
            this.SignupButton.ShadowDecoration.Enabled = true;
            this.SignupButton.ShadowDecoration.Parent = this.SignupButton;
            this.SignupButton.Size = new System.Drawing.Size(229, 37);
            this.SignupButton.TabIndex = 16;
            this.SignupButton.Text = "Register";
            this.SignupButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // SignupPasswordTextBox
            // 
            this.SignupPasswordTextBox.BorderColor = System.Drawing.Color.White;
            this.SignupPasswordTextBox.BorderRadius = 18;
            this.SignupPasswordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SignupPasswordTextBox.DefaultText = "  Password";
            this.SignupPasswordTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SignupPasswordTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SignupPasswordTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SignupPasswordTextBox.DisabledState.Parent = this.SignupPasswordTextBox;
            this.SignupPasswordTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SignupPasswordTextBox.FillColor = System.Drawing.Color.WhiteSmoke;
            this.SignupPasswordTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SignupPasswordTextBox.FocusedState.Parent = this.SignupPasswordTextBox;
            this.SignupPasswordTextBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignupPasswordTextBox.ForeColor = System.Drawing.Color.LightGray;
            this.SignupPasswordTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SignupPasswordTextBox.HoverState.Parent = this.SignupPasswordTextBox;
            this.SignupPasswordTextBox.Location = new System.Drawing.Point(516, 221);
            this.SignupPasswordTextBox.MinimumSize = new System.Drawing.Size(275, 0);
            this.SignupPasswordTextBox.Name = "SignupPasswordTextBox";
            this.SignupPasswordTextBox.PasswordChar = '\0';
            this.SignupPasswordTextBox.PlaceholderText = "";
            this.SignupPasswordTextBox.SelectedText = "";
            this.SignupPasswordTextBox.SelectionStart = 10;
            this.SignupPasswordTextBox.ShadowDecoration.Parent = this.SignupPasswordTextBox;
            this.SignupPasswordTextBox.Size = new System.Drawing.Size(275, 36);
            this.SignupPasswordTextBox.TabIndex = 15;
            this.SignupPasswordTextBox.Enter += new System.EventHandler(this.SignupPasswordTextBox_Enter);
            this.SignupPasswordTextBox.Leave += new System.EventHandler(this.SignupPasswordTextBox_Leave);
            // 
            // SignupEmailTextbox
            // 
            this.SignupEmailTextbox.BorderColor = System.Drawing.Color.White;
            this.SignupEmailTextbox.BorderRadius = 18;
            this.SignupEmailTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SignupEmailTextbox.DefaultText = "  Email";
            this.SignupEmailTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SignupEmailTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SignupEmailTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SignupEmailTextbox.DisabledState.Parent = this.SignupEmailTextbox;
            this.SignupEmailTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SignupEmailTextbox.FillColor = System.Drawing.Color.WhiteSmoke;
            this.SignupEmailTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SignupEmailTextbox.FocusedState.Parent = this.SignupEmailTextbox;
            this.SignupEmailTextbox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignupEmailTextbox.ForeColor = System.Drawing.Color.Gainsboro;
            this.SignupEmailTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SignupEmailTextbox.HoverState.Parent = this.SignupEmailTextbox;
            this.SignupEmailTextbox.Location = new System.Drawing.Point(516, 172);
            this.SignupEmailTextbox.Name = "SignupEmailTextbox";
            this.SignupEmailTextbox.PasswordChar = '\0';
            this.SignupEmailTextbox.PlaceholderText = "";
            this.SignupEmailTextbox.SelectedText = "";
            this.SignupEmailTextbox.SelectionStart = 7;
            this.SignupEmailTextbox.ShadowDecoration.Parent = this.SignupEmailTextbox;
            this.SignupEmailTextbox.Size = new System.Drawing.Size(275, 36);
            this.SignupEmailTextbox.TabIndex = 14;
            this.SignupEmailTextbox.TextChanged += new System.EventHandler(this.SignupEmailTextbox_TextChanged);
            this.SignupEmailTextbox.Enter += new System.EventHandler(this.SignupEmailTextbox_Enter);
            this.SignupEmailTextbox.Leave += new System.EventHandler(this.SignupEmailTextbox_Leave);
            // 
            // Signuptaglinelabel
            // 
            this.Signuptaglinelabel.AutoSize = true;
            this.Signuptaglinelabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Signuptaglinelabel.ForeColor = System.Drawing.Color.DarkGray;
            this.Signuptaglinelabel.Location = new System.Drawing.Point(566, 48);
            this.Signuptaglinelabel.Name = "Signuptaglinelabel";
            this.Signuptaglinelabel.Size = new System.Drawing.Size(185, 96);
            this.Signuptaglinelabel.TabIndex = 13;
            this.Signuptaglinelabel.Text = "Enter the information below\r\n \r\n\r\n\r\n\r\n\r\n";
            this.Signuptaglinelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SignUpLabel
            // 
            this.SignUpLabel.AutoSize = true;
            this.SignUpLabel.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpLabel.Location = new System.Drawing.Point(584, 9);
            this.SignUpLabel.Name = "SignUpLabel";
            this.SignUpLabel.Size = new System.Drawing.Size(142, 36);
            this.SignUpLabel.TabIndex = 12;
            this.SignUpLabel.Text = "Add User";
            this.SignUpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // SignupAccountTypeCombobox
            // 
            this.SignupAccountTypeCombobox.BackColor = System.Drawing.Color.White;
            this.SignupAccountTypeCombobox.BorderColor = System.Drawing.Color.White;
            this.SignupAccountTypeCombobox.BorderRadius = 21;
            this.SignupAccountTypeCombobox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.SignupAccountTypeCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SignupAccountTypeCombobox.FillColor = System.Drawing.Color.WhiteSmoke;
            this.SignupAccountTypeCombobox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SignupAccountTypeCombobox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SignupAccountTypeCombobox.FocusedState.Parent = this.SignupAccountTypeCombobox;
            this.SignupAccountTypeCombobox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.SignupAccountTypeCombobox.ForeColor = System.Drawing.Color.Black;
            this.SignupAccountTypeCombobox.HoverState.Parent = this.SignupAccountTypeCombobox;
            this.SignupAccountTypeCombobox.ItemHeight = 30;
            this.SignupAccountTypeCombobox.ItemsAppearance.Parent = this.SignupAccountTypeCombobox;
            this.SignupAccountTypeCombobox.Location = new System.Drawing.Point(516, 78);
            this.SignupAccountTypeCombobox.MinimumSize = new System.Drawing.Size(275, 0);
            this.SignupAccountTypeCombobox.Name = "SignupAccountTypeCombobox";
            this.SignupAccountTypeCombobox.ShadowDecoration.Parent = this.SignupAccountTypeCombobox;
            this.SignupAccountTypeCombobox.Size = new System.Drawing.Size(275, 36);
            this.SignupAccountTypeCombobox.TabIndex = 20;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.ContainerControl = this;
            // 
            // SignupUserNameTextBox
            // 
            this.SignupUserNameTextBox.BorderColor = System.Drawing.Color.White;
            this.SignupUserNameTextBox.BorderRadius = 18;
            this.SignupUserNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SignupUserNameTextBox.DefaultText = "  Username";
            this.SignupUserNameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SignupUserNameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SignupUserNameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SignupUserNameTextBox.DisabledState.Parent = this.SignupUserNameTextBox;
            this.SignupUserNameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SignupUserNameTextBox.FillColor = System.Drawing.Color.WhiteSmoke;
            this.SignupUserNameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SignupUserNameTextBox.FocusedState.Parent = this.SignupUserNameTextBox;
            this.SignupUserNameTextBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignupUserNameTextBox.ForeColor = System.Drawing.Color.LightGray;
            this.SignupUserNameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SignupUserNameTextBox.HoverState.Parent = this.SignupUserNameTextBox;
            this.SignupUserNameTextBox.Location = new System.Drawing.Point(516, 269);
            this.SignupUserNameTextBox.MinimumSize = new System.Drawing.Size(275, 0);
            this.SignupUserNameTextBox.Name = "SignupUserNameTextBox";
            this.SignupUserNameTextBox.PasswordChar = '\0';
            this.SignupUserNameTextBox.PlaceholderText = "";
            this.SignupUserNameTextBox.SelectedText = "";
            this.SignupUserNameTextBox.SelectionStart = 10;
            this.SignupUserNameTextBox.ShadowDecoration.Parent = this.SignupUserNameTextBox;
            this.SignupUserNameTextBox.Size = new System.Drawing.Size(275, 36);
            this.SignupUserNameTextBox.TabIndex = 21;
            this.SignupUserNameTextBox.TextChanged += new System.EventHandler(this.SignupUserNameTextBox_TextChanged);
            this.SignupUserNameTextBox.Enter += new System.EventHandler(this.SignupUserNameTextBox_Enter);
            this.SignupUserNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SignupUserNameTextBox_KeyPress);
            this.SignupUserNameTextBox.Leave += new System.EventHandler(this.SignupUserNameTextBox_Leave);
            // 
            // SignupPhoneNumberTextBox
            // 
            this.SignupPhoneNumberTextBox.BorderColor = System.Drawing.Color.White;
            this.SignupPhoneNumberTextBox.BorderRadius = 18;
            this.SignupPhoneNumberTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SignupPhoneNumberTextBox.DefaultText = "  Phone Number";
            this.SignupPhoneNumberTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SignupPhoneNumberTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SignupPhoneNumberTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SignupPhoneNumberTextBox.DisabledState.Parent = this.SignupPhoneNumberTextBox;
            this.SignupPhoneNumberTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SignupPhoneNumberTextBox.FillColor = System.Drawing.Color.WhiteSmoke;
            this.SignupPhoneNumberTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SignupPhoneNumberTextBox.FocusedState.Parent = this.SignupPhoneNumberTextBox;
            this.SignupPhoneNumberTextBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignupPhoneNumberTextBox.ForeColor = System.Drawing.Color.LightGray;
            this.SignupPhoneNumberTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SignupPhoneNumberTextBox.HoverState.Parent = this.SignupPhoneNumberTextBox;
            this.SignupPhoneNumberTextBox.Location = new System.Drawing.Point(516, 316);
            this.SignupPhoneNumberTextBox.MinimumSize = new System.Drawing.Size(275, 0);
            this.SignupPhoneNumberTextBox.Name = "SignupPhoneNumberTextBox";
            this.SignupPhoneNumberTextBox.PasswordChar = '\0';
            this.SignupPhoneNumberTextBox.PlaceholderText = "";
            this.SignupPhoneNumberTextBox.SelectedText = "";
            this.SignupPhoneNumberTextBox.SelectionStart = 14;
            this.SignupPhoneNumberTextBox.ShadowDecoration.Parent = this.SignupPhoneNumberTextBox;
            this.SignupPhoneNumberTextBox.Size = new System.Drawing.Size(275, 36);
            this.SignupPhoneNumberTextBox.TabIndex = 22;
            this.SignupPhoneNumberTextBox.Enter += new System.EventHandler(this.SignupPhoneNumberTextBox_Enter);
            this.SignupPhoneNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SignupPhoneNumberTextBox_KeyPress);
            this.SignupPhoneNumberTextBox.Leave += new System.EventHandler(this.SignupPhoneNumberTextBox_Leave);
            // 
            // guna2Button1
            // 
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 13;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(60)))), ((int)(((byte)(52)))));
            this.guna2Button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(467, 515);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(60)))), ((int)(((byte)(52)))));
            this.guna2Button1.ShadowDecoration.BorderRadius = 30;
            this.guna2Button1.ShadowDecoration.Depth = 21;
            this.guna2Button1.ShadowDecoration.Enabled = true;
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(147, 29);
            this.guna2Button1.TabIndex = 23;
            this.guna2Button1.Text = "Update User";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.AutoRoundedCorners = true;
            this.guna2Button2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button2.BorderRadius = 13;
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(60)))), ((int)(((byte)(52)))));
            this.guna2Button2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Location = new System.Drawing.Point(734, 515);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(60)))), ((int)(((byte)(52)))));
            this.guna2Button2.ShadowDecoration.BorderRadius = 30;
            this.guna2Button2.ShadowDecoration.Depth = 21;
            this.guna2Button2.ShadowDecoration.Enabled = true;
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(147, 29);
            this.guna2Button2.TabIndex = 24;
            this.guna2Button2.Text = "Delete User";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.BorderColor = System.Drawing.Color.White;
            this.guna2TextBox1.BorderRadius = 18;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = " ID";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.FocusedState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.guna2TextBox1.ForeColor = System.Drawing.Color.LightGray;
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.HoverState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Location = new System.Drawing.Point(516, 124);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.SelectionStart = 3;
            this.guna2TextBox1.ShadowDecoration.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Size = new System.Drawing.Size(275, 36);
            this.guna2TextBox1.TabIndex = 25;
            this.guna2TextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.guna2TextBox1_KeyPress);
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.BackColor = System.Drawing.Color.White;
            this.guna2ComboBox1.BorderColor = System.Drawing.Color.White;
            this.guna2ComboBox1.BorderRadius = 21;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2ComboBox1.HoverState.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.ItemHeight = 30;
            this.guna2ComboBox1.ItemsAppearance.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Location = new System.Drawing.Point(516, 363);
            this.guna2ComboBox1.MinimumSize = new System.Drawing.Size(275, 0);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.ShadowDecoration.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Size = new System.Drawing.Size(275, 36);
            this.guna2ComboBox1.TabIndex = 26;
            // 
            // guna2TextBox2
            // 
            this.guna2TextBox2.BorderColor = System.Drawing.Color.White;
            this.guna2TextBox2.BorderRadius = 18;
            this.guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox2.DefaultText = "Date";
            this.guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.DisabledState.Parent = this.guna2TextBox2;
            this.guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.FocusedState.Parent = this.guna2TextBox2;
            this.guna2TextBox2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBox2.ForeColor = System.Drawing.Color.LightGray;
            this.guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.HoverState.Parent = this.guna2TextBox2;
            this.guna2TextBox2.Location = new System.Drawing.Point(516, 412);
            this.guna2TextBox2.Name = "guna2TextBox2";
            this.guna2TextBox2.PasswordChar = '\0';
            this.guna2TextBox2.PlaceholderText = "";
            this.guna2TextBox2.SelectedText = "";
            this.guna2TextBox2.SelectionStart = 4;
            this.guna2TextBox2.ShadowDecoration.Parent = this.guna2TextBox2;
            this.guna2TextBox2.Size = new System.Drawing.Size(275, 36);
            this.guna2TextBox2.TabIndex = 27;
            this.guna2TextBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.guna2TextBox2_KeyPress);
            // 
            // CrossButton
            // 
            this.CrossButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CrossButton.BackColor = System.Drawing.Color.White;
            this.CrossButton.Image = ((System.Drawing.Image)(resources.GetObject("CrossButton.Image")));
            this.CrossButton.ImageActive = null;
            this.CrossButton.Location = new System.Drawing.Point(871, 12);
            this.CrossButton.Name = "CrossButton";
            this.CrossButton.Size = new System.Drawing.Size(25, 25);
            this.CrossButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CrossButton.TabIndex = 28;
            this.CrossButton.TabStop = false;
            this.CrossButton.Zoom = 10;
            this.CrossButton.Click += new System.EventHandler(this.CrossButton_Click_1);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(908, 554);
            this.Controls.Add(this.CrossButton);
            this.Controls.Add(this.guna2TextBox2);
            this.Controls.Add(this.guna2ComboBox1);
            this.Controls.Add(this.guna2TextBox1);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.SignupPhoneNumberTextBox);
            this.Controls.Add(this.SignupUserNameTextBox);
            this.Controls.Add(this.SignupAccountTypeCombobox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SignupButton);
            this.Controls.Add(this.SignupPasswordTextBox);
            this.Controls.Add(this.SignupEmailTextbox);
            this.Controls.Add(this.Signuptaglinelabel);
            this.Controls.Add(this.SignUpLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUp";
            this.Load += new System.EventHandler(this.SignUp_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CrossButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Logo;
        private Guna.UI2.WinForms.Guna2Button SignupButton;
        private System.Windows.Forms.Label Signuptaglinelabel;
        private System.Windows.Forms.Label SignUpLabel;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        public Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        public Guna.UI2.WinForms.Guna2TextBox SignupPasswordTextBox;
        public Guna.UI2.WinForms.Guna2TextBox SignupEmailTextbox;
        public Guna.UI2.WinForms.Guna2ComboBox SignupAccountTypeCombobox;
        public Guna.UI2.WinForms.Guna2TextBox SignupPhoneNumberTextBox;
        public Guna.UI2.WinForms.Guna2TextBox SignupUserNameTextBox;
        public Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        public Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private Bunifu.Framework.UI.BunifuImageButton CrossButton;
    }
}