namespace PresentationLayer
{
    partial class loginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginPage));
            this.loginPanel = new System.Windows.Forms.Panel();
            this.signUpButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.passwordBox = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.userIdBox = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.loginButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.passwordLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.userIdLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.closeimagebutton = new Bunifu.Framework.UI.BunifuImageButton();
            this.loginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeimagebutton)).BeginInit();
            this.SuspendLayout();
            // 
            // loginPanel
            // 
            this.loginPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.loginPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(68)))), ((int)(((byte)(101)))));
            this.loginPanel.Controls.Add(this.signUpButton);
            this.loginPanel.Controls.Add(this.passwordBox);
            this.loginPanel.Controls.Add(this.userIdBox);
            this.loginPanel.Controls.Add(this.loginButton);
            this.loginPanel.Controls.Add(this.passwordLabel);
            this.loginPanel.Controls.Add(this.userIdLabel);
            this.loginPanel.Location = new System.Drawing.Point(142, 93);
            this.loginPanel.Margin = new System.Windows.Forms.Padding(0);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(381, 515);
            this.loginPanel.TabIndex = 8;
            // 
            // signUpButton
            // 
            this.signUpButton.ActiveBorderThickness = 1;
            this.signUpButton.ActiveCornerRadius = 20;
            this.signUpButton.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(199)))), ((int)(((byte)(181)))));
            this.signUpButton.ActiveForecolor = System.Drawing.Color.White;
            this.signUpButton.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(199)))), ((int)(((byte)(181)))));
            this.signUpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(68)))), ((int)(((byte)(101)))));
            this.signUpButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("signUpButton.BackgroundImage")));
            this.signUpButton.ButtonText = "SIGN UP";
            this.signUpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signUpButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.signUpButton.IdleBorderThickness = 1;
            this.signUpButton.IdleCornerRadius = 20;
            this.signUpButton.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.signUpButton.IdleForecolor = System.Drawing.Color.Honeydew;
            this.signUpButton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.signUpButton.Location = new System.Drawing.Point(32, 418);
            this.signUpButton.Margin = new System.Windows.Forms.Padding(5);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(314, 54);
            this.signUpButton.TabIndex = 4;
            this.signUpButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // passwordBox
            // 
            this.passwordBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(68)))), ((int)(((byte)(101)))));
            this.passwordBox.BorderColor = System.Drawing.Color.SeaGreen;
            this.passwordBox.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBox.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.passwordBox.Location = new System.Drawing.Point(28, 252);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(318, 32);
            this.passwordBox.TabIndex = 2;
            // 
            // userIdBox
            // 
            this.userIdBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(68)))), ((int)(((byte)(101)))));
            this.userIdBox.BorderColor = System.Drawing.Color.Black;
            this.userIdBox.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userIdBox.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.userIdBox.Location = new System.Drawing.Point(28, 113);
            this.userIdBox.Name = "userIdBox";
            this.userIdBox.Size = new System.Drawing.Size(318, 32);
            this.userIdBox.TabIndex = 1;
            // 
            // loginButton
            // 
            this.loginButton.ActiveBorderThickness = 1;
            this.loginButton.ActiveCornerRadius = 20;
            this.loginButton.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(199)))), ((int)(((byte)(181)))));
            this.loginButton.ActiveForecolor = System.Drawing.Color.White;
            this.loginButton.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(199)))), ((int)(((byte)(181)))));
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(68)))), ((int)(((byte)(101)))));
            this.loginButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loginButton.BackgroundImage")));
            this.loginButton.ButtonText = "LOGIN";
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.loginButton.IdleBorderThickness = 1;
            this.loginButton.IdleCornerRadius = 20;
            this.loginButton.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.loginButton.IdleForecolor = System.Drawing.Color.Honeydew;
            this.loginButton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.loginButton.Location = new System.Drawing.Point(32, 341);
            this.loginButton.Margin = new System.Windows.Forms.Padding(5);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(314, 54);
            this.loginButton.TabIndex = 3;
            this.loginButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.passwordLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.passwordLabel.Location = new System.Drawing.Point(28, 204);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(241, 32);
            this.passwordLabel.TabIndex = 0;
            this.passwordLabel.Text = "PASSWORD";
            // 
            // userIdLabel
            // 
            this.userIdLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userIdLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.userIdLabel.Location = new System.Drawing.Point(28, 78);
            this.userIdLabel.Name = "userIdLabel";
            this.userIdLabel.Size = new System.Drawing.Size(241, 32);
            this.userIdLabel.TabIndex = 0;
            this.userIdLabel.Text = "USER ID";
            // 
            // closeimagebutton
            // 
            this.closeimagebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(199)))), ((int)(((byte)(181)))));
            this.closeimagebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeimagebutton.Image = ((System.Drawing.Image)(resources.GetObject("closeimagebutton.Image")));
            this.closeimagebutton.ImageActive = null;
            this.closeimagebutton.Location = new System.Drawing.Point(618, 0);
            this.closeimagebutton.Name = "closeimagebutton";
            this.closeimagebutton.Size = new System.Drawing.Size(61, 49);
            this.closeimagebutton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeimagebutton.TabIndex = 6;
            this.closeimagebutton.TabStop = false;
            this.closeimagebutton.Zoom = 10;
            this.closeimagebutton.Click += new System.EventHandler(this.closeimagebutton_Click);
            // 
            // loginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(199)))), ((int)(((byte)(181)))));
            this.ClientSize = new System.Drawing.Size(680, 685);
            this.Controls.Add(this.loginPanel);
            this.Controls.Add(this.closeimagebutton);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "loginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyCourse";
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeimagebutton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuImageButton closeimagebutton;
        private System.Windows.Forms.Panel loginPanel;
        private Bunifu.Framework.UI.BunifuCustomLabel userIdLabel;
        private Bunifu.Framework.UI.BunifuCustomLabel passwordLabel;
        private Bunifu.Framework.UI.BunifuThinButton2 loginButton;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox passwordBox;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox userIdBox;
        private Bunifu.Framework.UI.BunifuThinButton2 signUpButton;
    }
}

