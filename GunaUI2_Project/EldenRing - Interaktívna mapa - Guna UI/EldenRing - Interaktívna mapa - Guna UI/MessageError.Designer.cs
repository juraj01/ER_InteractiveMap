namespace EldenRing___Interaktívna_mapa___Guna_UI
{
    partial class MessageError
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageError));
            this.UpperBorderPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.ExitButton = new Guna.UI2.WinForms.Guna2ControlBox();
            this.Ok = new Guna.UI2.WinForms.Guna2Button();
            this.UpperBorderPanel.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // UpperBorderPanel
            // 
            this.UpperBorderPanel.BorderColor = System.Drawing.Color.DarkGray;
            this.UpperBorderPanel.BorderThickness = 1;
            this.UpperBorderPanel.Controls.Add(this.ExitButton);
            this.UpperBorderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UpperBorderPanel.Location = new System.Drawing.Point(0, 0);
            this.UpperBorderPanel.Name = "UpperBorderPanel";
            this.UpperBorderPanel.Size = new System.Drawing.Size(656, 32);
            this.UpperBorderPanel.TabIndex = 0;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackgroundImage = global::EldenRing___Interaktívna_mapa___Guna_UI.Properties.Resources.map_text_background_location;
            this.guna2Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2Panel2.Controls.Add(this.MessageLabel);
            this.guna2Panel2.Location = new System.Drawing.Point(-163, 38);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1069, 142);
            this.guna2Panel2.TabIndex = 1;
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.BackColor = System.Drawing.Color.Transparent;
            this.MessageLabel.Font = new System.Drawing.Font("Garamond", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MessageLabel.ForeColor = System.Drawing.Color.Maroon;
            this.MessageLabel.Location = new System.Drawing.Point(175, 51);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(161, 33);
            this.MessageLabel.TabIndex = 0;
            this.MessageLabel.Text = "Custom Text";
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.BackgroundImage = global::EldenRing___Interaktívna_mapa___Guna_UI.Properties.Resources.Exit___final_;
            this.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ExitButton.BorderColor = System.Drawing.Color.Transparent;
            this.ExitButton.FillColor = System.Drawing.Color.Transparent;
            this.ExitButton.ForeColor = System.Drawing.Color.Transparent;
            this.ExitButton.IconColor = System.Drawing.Color.Transparent;
            this.ExitButton.Location = new System.Drawing.Point(608, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(52, 31);
            this.ExitButton.TabIndex = 1;
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
            this.Ok.Location = new System.Drawing.Point(555, 191);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(89, 31);
            this.Ok.TabIndex = 2;
            this.Ok.Text = "OK";
            // 
            // MessageError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(656, 234);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.UpperBorderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MessageError";
            this.Text = "Form1";
            this.UpperBorderPanel.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel UpperBorderPanel;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label MessageLabel;
        private Guna.UI2.WinForms.Guna2ControlBox ExitButton;
        private Guna.UI2.WinForms.Guna2Button Ok;
    }
}