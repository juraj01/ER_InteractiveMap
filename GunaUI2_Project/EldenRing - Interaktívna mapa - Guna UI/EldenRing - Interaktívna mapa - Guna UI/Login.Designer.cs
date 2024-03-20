using System.Drawing;

namespace EldenRing___Interaktívna_mapa___Guna_UI
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.LoginButton = new Guna.UI2.WinForms.Guna2Button();
            this.RegisterButton = new Guna.UI2.WinForms.Guna2Button();
            this.PasswordTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.RegisterLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.UpperBorderPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.ExitButton = new Guna.UI2.WinForms.Guna2ControlBox();
            this.MaximizeButton = new Guna.UI2.WinForms.Guna2ControlBox();
            this.MinimalizeButton = new Guna.UI2.WinForms.Guna2ControlBox();
            this.UpperBorderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginButton
            // 
            this.LoginButton.AutoRoundedCorners = true;
            this.LoginButton.BackColor = System.Drawing.Color.Transparent;
            this.LoginButton.BorderColor = System.Drawing.Color.DarkGray;
            this.LoginButton.BorderRadius = 16;
            this.LoginButton.BorderThickness = 1;
            this.LoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginButton.CustomBorderColor = System.Drawing.Color.Transparent;
            this.LoginButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(7)))));
            this.LoginButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LoginButton.ForeColor = System.Drawing.Color.White;
            this.LoginButton.HoverState.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.LoginButton.Location = new System.Drawing.Point(47, 562);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(273, 35);
            this.LoginButton.TabIndex = 10;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseTransparentBackground = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // RegisterButton
            // 
            this.RegisterButton.AutoRoundedCorners = true;
            this.RegisterButton.BackColor = System.Drawing.Color.Transparent;
            this.RegisterButton.BorderColor = System.Drawing.Color.DarkGray;
            this.RegisterButton.BorderRadius = 16;
            this.RegisterButton.BorderThickness = 1;
            this.RegisterButton.CheckedState.BorderColor = System.Drawing.Color.Goldenrod;
            this.RegisterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegisterButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RegisterButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RegisterButton.ForeColor = System.Drawing.Color.White;
            this.RegisterButton.HoverState.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.RegisterButton.Location = new System.Drawing.Point(47, 639);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(273, 35);
            this.RegisterButton.TabIndex = 12;
            this.RegisterButton.Text = "Registration";
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.AutoRoundedCorners = true;
            this.PasswordTextBox.BackColor = System.Drawing.Color.Transparent;
            this.PasswordTextBox.BorderColor = System.Drawing.Color.DarkGray;
            this.PasswordTextBox.BorderRadius = 17;
            this.PasswordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordTextBox.DefaultText = "";
            this.PasswordTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PasswordTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PasswordTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTextBox.FillColor = System.Drawing.Color.Black;
            this.PasswordTextBox.FocusedState.BorderColor = System.Drawing.Color.Goldenrod;
            this.PasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PasswordTextBox.ForeColor = System.Drawing.Color.White;
            this.PasswordTextBox.HoverState.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.PasswordTextBox.Location = new System.Drawing.Point(47, 470);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '\0';
            this.PasswordTextBox.PlaceholderForeColor = System.Drawing.Color.Transparent;
            this.PasswordTextBox.PlaceholderText = "";
            this.PasswordTextBox.SelectedText = "";
            this.PasswordTextBox.Size = new System.Drawing.Size(273, 36);
            this.PasswordTextBox.TabIndex = 8;
            this.PasswordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PasswordTextBox.TextChanged += new System.EventHandler(this.PasswordTextBox_TextChanged);
            // 
            // RegisterLabel
            // 
            this.RegisterLabel.AutoSize = true;
            this.RegisterLabel.BackColor = System.Drawing.Color.Transparent;
            this.RegisterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RegisterLabel.ForeColor = System.Drawing.Color.Silver;
            this.RegisterLabel.Location = new System.Drawing.Point(56, 616);
            this.RegisterLabel.Name = "RegisterLabel";
            this.RegisterLabel.Size = new System.Drawing.Size(212, 20);
            this.RegisterLabel.TabIndex = 13;
            this.RegisterLabel.Text = "If you don\'t have an account:";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PasswordLabel.ForeColor = System.Drawing.Color.Silver;
            this.PasswordLabel.Location = new System.Drawing.Point(56, 447);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(158, 20);
            this.PasswordLabel.TabIndex = 9;
            this.PasswordLabel.Text = "Enter your password:";
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.BackColor = System.Drawing.Color.Transparent;
            this.LoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LoginLabel.ForeColor = System.Drawing.Color.Silver;
            this.LoginLabel.Location = new System.Drawing.Point(56, 539);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(333, 20);
            this.LoginLabel.TabIndex = 11;
            this.LoginLabel.Text = "If you have an account and filled boxes above:";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.BackColor = System.Drawing.Color.Transparent;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NameLabel.ForeColor = System.Drawing.Color.Silver;
            this.NameLabel.Location = new System.Drawing.Point(56, 372);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(161, 20);
            this.NameLabel.TabIndex = 5;
            this.NameLabel.Text = "Enter your username:";
            // 
            // NameTextBox
            // 
            this.NameTextBox.AutoRoundedCorners = true;
            this.NameTextBox.BackColor = System.Drawing.Color.Transparent;
            this.NameTextBox.BorderColor = System.Drawing.Color.DarkGray;
            this.NameTextBox.BorderRadius = 17;
            this.NameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NameTextBox.DefaultText = "";
            this.NameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NameTextBox.FillColor = System.Drawing.Color.Transparent;
            this.NameTextBox.FocusedState.BorderColor = System.Drawing.Color.Goldenrod;
            this.NameTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NameTextBox.ForeColor = System.Drawing.Color.White;
            this.NameTextBox.HoverState.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.NameTextBox.Location = new System.Drawing.Point(47, 395);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.PasswordChar = '\0';
            this.NameTextBox.PlaceholderForeColor = System.Drawing.Color.Transparent;
            this.NameTextBox.PlaceholderText = "";
            this.NameTextBox.SelectedText = "";
            this.NameTextBox.Size = new System.Drawing.Size(273, 36);
            this.NameTextBox.TabIndex = 4;
            this.NameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // UpperBorderPanel
            // 
            this.UpperBorderPanel.AutoSize = true;
            this.UpperBorderPanel.BackColor = System.Drawing.Color.Transparent;
            this.UpperBorderPanel.BorderColor = System.Drawing.Color.DimGray;
            this.UpperBorderPanel.BorderThickness = 1;
            this.UpperBorderPanel.Controls.Add(this.MinimalizeButton);
            this.UpperBorderPanel.Controls.Add(this.ExitButton);
            this.UpperBorderPanel.Controls.Add(this.MaximizeButton);
            this.UpperBorderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UpperBorderPanel.ForeColor = System.Drawing.Color.Transparent;
            this.UpperBorderPanel.Location = new System.Drawing.Point(0, 0);
            this.UpperBorderPanel.Name = "UpperBorderPanel";
            this.UpperBorderPanel.Size = new System.Drawing.Size(1091, 32);
            this.UpperBorderPanel.TabIndex = 16;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BackgroundImage = global::EldenRing___Interaktívna_mapa___Guna_UI.Properties.Resources.Login;
            this.guna2Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2Panel1.Location = new System.Drawing.Point(60, 65);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(385, 125);
            this.guna2Panel1.TabIndex = 17;
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.BackColor = System.Drawing.Color.Transparent;
            this.ExitButton.BackgroundImage = global::EldenRing___Interaktívna_mapa___Guna_UI.Properties.Resources.Exit___final_;
            this.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ExitButton.BorderColor = System.Drawing.Color.Transparent;
            this.ExitButton.FillColor = System.Drawing.Color.Transparent;
            this.ExitButton.IconColor = System.Drawing.Color.Transparent;
            this.ExitButton.Location = new System.Drawing.Point(1046, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(45, 29);
            this.ExitButton.TabIndex = 18;
            // 
            // MaximizeButton
            // 
            this.MaximizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaximizeButton.BackColor = System.Drawing.Color.Transparent;
            this.MaximizeButton.BackgroundImage = global::EldenRing___Interaktívna_mapa___Guna_UI.Properties.Resources.Maximalize___final;
            this.MaximizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MaximizeButton.BorderColor = System.Drawing.Color.Transparent;
            this.MaximizeButton.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.MaximizeButton.FillColor = System.Drawing.Color.Transparent;
            this.MaximizeButton.IconColor = System.Drawing.Color.Transparent;
            this.MaximizeButton.Location = new System.Drawing.Point(1004, 0);
            this.MaximizeButton.Name = "MaximizeButton";
            this.MaximizeButton.Size = new System.Drawing.Size(45, 29);
            this.MaximizeButton.TabIndex = 19;
            // 
            // MinimalizeButton
            // 
            this.MinimalizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimalizeButton.BackColor = System.Drawing.Color.Transparent;
            this.MinimalizeButton.BackgroundImage = global::EldenRing___Interaktívna_mapa___Guna_UI.Properties.Resources.Minimalize___final;
            this.MinimalizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MinimalizeButton.BorderColor = System.Drawing.Color.Transparent;
            this.MinimalizeButton.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.MinimalizeButton.FillColor = System.Drawing.Color.Transparent;
            this.MinimalizeButton.IconColor = System.Drawing.Color.Transparent;
            this.MinimalizeButton.Location = new System.Drawing.Point(962, 0);
            this.MinimalizeButton.Name = "MinimalizeButton";
            this.MinimalizeButton.Size = new System.Drawing.Size(45, 29);
            this.MinimalizeButton.TabIndex = 18;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::EldenRing___Interaktívna_mapa___Guna_UI.Properties.Resources.LoginBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1091, 708);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.UpperBorderPanel);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.RegisterLabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.NameLabel);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Form1";
            this.UpperBorderPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button LoginButton;
        private Guna.UI2.WinForms.Guna2Button RegisterButton;
        private Guna.UI2.WinForms.Guna2TextBox NameTextBox;
        private Guna.UI2.WinForms.Guna2TextBox PasswordTextBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label RegisterLabel;
        private Guna.UI2.WinForms.Guna2Panel UpperBorderPanel;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ControlBox ExitButton;
        private Guna.UI2.WinForms.Guna2ControlBox MaximizeButton;
        private Guna.UI2.WinForms.Guna2ControlBox MinimalizeButton;
    }
}

