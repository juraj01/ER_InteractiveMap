namespace EldenRing___Interaktívna_mapa___Guna_UI
{
    partial class MessageSuccess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageSuccess));
            this.UpperBorderPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.Ok = new Guna.UI2.WinForms.Guna2Button();
            this.BackgroundPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.ExitButton = new Guna.UI2.WinForms.Guna2ControlBox();
            this.UpperBorderPanel.SuspendLayout();
            this.BackgroundPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // UpperBorderPanel
            // 
            this.UpperBorderPanel.BackColor = System.Drawing.Color.Transparent;
            this.UpperBorderPanel.BorderColor = System.Drawing.Color.DimGray;
            this.UpperBorderPanel.BorderThickness = 1;
            this.UpperBorderPanel.Controls.Add(this.ExitButton);
            this.UpperBorderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UpperBorderPanel.Location = new System.Drawing.Point(0, 0);
            this.UpperBorderPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.UpperBorderPanel.Name = "UpperBorderPanel";
            this.UpperBorderPanel.Size = new System.Drawing.Size(526, 32);
            this.UpperBorderPanel.TabIndex = 0;
            // 
            // Ok
            // 
            this.Ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Ok.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Ok.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Ok.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Ok.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Ok.FillColor = System.Drawing.Color.DimGray;
            this.Ok.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Ok.ForeColor = System.Drawing.Color.White;
            this.Ok.Location = new System.Drawing.Point(424, 211);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(89, 31);
            this.Ok.TabIndex = 2;
            this.Ok.Text = "OK";
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // BackgroundPanel
            // 
            this.BackgroundPanel.BackgroundImage = global::EldenRing___Interaktívna_mapa___Guna_UI.Properties.Resources.map_text_background_region;
            this.BackgroundPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BackgroundPanel.Controls.Add(this.MessageLabel);
            this.BackgroundPanel.Location = new System.Drawing.Point(-223, 38);
            this.BackgroundPanel.Name = "BackgroundPanel";
            this.BackgroundPanel.Size = new System.Drawing.Size(926, 167);
            this.BackgroundPanel.TabIndex = 3;
            // 
            // MessageLabel
            // 
            this.MessageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.BackColor = System.Drawing.Color.Transparent;
            this.MessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageLabel.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.MessageLabel.Location = new System.Drawing.Point(300, 71);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(364, 30);
            this.MessageLabel.TabIndex = 0;
            this.MessageLabel.Text = "Registration was successfull";
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
            this.ExitButton.Location = new System.Drawing.Point(474, 0);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(52, 31);
            this.ExitButton.TabIndex = 21;
            // 
            // MessageSuccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(526, 250);
            this.Controls.Add(this.BackgroundPanel);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.UpperBorderPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MessageSuccess";
            this.Text = "Main";
            this.UpperBorderPanel.ResumeLayout(false);
            this.BackgroundPanel.ResumeLayout(false);
            this.BackgroundPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel UpperBorderPanel;
        private Guna.UI2.WinForms.Guna2ControlBox ExitButton;
        private Guna.UI2.WinForms.Guna2Button Ok;
        private Guna.UI2.WinForms.Guna2Panel BackgroundPanel;
        private System.Windows.Forms.Label MessageLabel;
    }
}