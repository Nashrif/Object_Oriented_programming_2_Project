namespace MyCourse
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
            this.loginButtom = new Bunifu.Framework.UI.BunifuThinButton2();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.userIdBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.signupButton = new System.Windows.Forms.Button();
            this.loginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginPanel
            // 
            this.loginPanel.BackColor = System.Drawing.Color.White;
            this.loginPanel.Controls.Add(this.loginButtom);
            this.loginPanel.Controls.Add(this.passwordBox);
            this.loginPanel.Controls.Add(this.passwordLabel);
            this.loginPanel.Controls.Add(this.userIdBox);
            this.loginPanel.Controls.Add(this.label1);
            this.loginPanel.Location = new System.Drawing.Point(61, 183);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(377, 449);
            this.loginPanel.TabIndex = 2;
            // 
            // loginButtom
            // 
            this.loginButtom.ActiveBorderThickness = 1;
            this.loginButtom.ActiveCornerRadius = 20;
            this.loginButtom.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.loginButtom.ActiveForecolor = System.Drawing.Color.White;
            this.loginButtom.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.loginButtom.BackColor = System.Drawing.Color.White;
            this.loginButtom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loginButtom.BackgroundImage")));
            this.loginButtom.ButtonText = "LOGIN";
            this.loginButtom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButtom.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButtom.ForeColor = System.Drawing.Color.SeaGreen;
            this.loginButtom.IdleBorderThickness = 1;
            this.loginButtom.IdleCornerRadius = 20;
            this.loginButtom.IdleFillColor = System.Drawing.Color.SeaGreen;
            this.loginButtom.IdleForecolor = System.Drawing.Color.White;
            this.loginButtom.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.loginButtom.Location = new System.Drawing.Point(200, 336);
            this.loginButtom.Margin = new System.Windows.Forms.Padding(5);
            this.loginButtom.Name = "loginButtom";
            this.loginButtom.Size = new System.Drawing.Size(158, 56);
            this.loginButtom.TabIndex = 3;
            this.loginButtom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passwordBox
            // 
            this.passwordBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.passwordBox.Location = new System.Drawing.Point(29, 234);
            this.passwordBox.Multiline = true;
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(329, 54);
            this.passwordBox.TabIndex = 3;
            // 
            // passwordLabel
            // 
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.Color.YellowGreen;
            this.passwordLabel.Location = new System.Drawing.Point(25, 188);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(182, 43);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "PASSWORD";
            // 
            // userIdBox
            // 
            this.userIdBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.userIdBox.Location = new System.Drawing.Point(29, 88);
            this.userIdBox.Multiline = true;
            this.userIdBox.Name = "userIdBox";
            this.userIdBox.Size = new System.Drawing.Size(329, 54);
            this.userIdBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.YellowGreen;
            this.label1.Location = new System.Drawing.Point(24, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "USER ID";
            // 
            // loginButton
            // 
            this.loginButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(68)))), ((int)(((byte)(101)))));
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.Location = new System.Drawing.Point(212, 74);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(142, 45);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "LOGIN";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // signupButton
            // 
            this.signupButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(68)))), ((int)(((byte)(101)))));
            this.signupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signupButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupButton.ForeColor = System.Drawing.Color.White;
            this.signupButton.Location = new System.Drawing.Point(495, 74);
            this.signupButton.Name = "signupButton";
            this.signupButton.Size = new System.Drawing.Size(142, 45);
            this.signupButton.TabIndex = 4;
            this.signupButton.Text = "SIGN UP";
            this.signupButton.UseVisualStyleBackColor = true;
            // 
            // loginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(68)))), ((int)(((byte)(101)))));
            this.ClientSize = new System.Drawing.Size(809, 714);
            this.Controls.Add(this.signupButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.loginPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "loginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyCourse";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.TextBox userIdBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordBox;
        private Bunifu.Framework.UI.BunifuThinButton2 loginButtom;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button signupButton;
    }
}

