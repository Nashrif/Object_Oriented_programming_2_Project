namespace MyCourse
{
    partial class myCourseUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(myCourseUserControl));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.yesButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.courseNameBox = new System.Windows.Forms.Label();
            this.courseBox = new System.Windows.Forms.TextBox();
            this.dropButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.courseGrid = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.sectionBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.courseGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label1.Location = new System.Drawing.Point(76, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Registered Courses";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 482);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 45);
            this.label2.TabIndex = 19;
            this.label2.Text = "Wanna Drop A Course?";
            // 
            // yesButton
            // 
            this.yesButton.ActiveBorderThickness = 1;
            this.yesButton.ActiveCornerRadius = 20;
            this.yesButton.ActiveFillColor = System.Drawing.Color.Silver;
            this.yesButton.ActiveForecolor = System.Drawing.Color.White;
            this.yesButton.ActiveLineColor = System.Drawing.Color.Gray;
            this.yesButton.BackColor = System.Drawing.SystemColors.Control;
            this.yesButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("yesButton.BackgroundImage")));
            this.yesButton.ButtonText = "YES";
            this.yesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yesButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yesButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.yesButton.IdleBorderThickness = 1;
            this.yesButton.IdleCornerRadius = 20;
            this.yesButton.IdleFillColor = System.Drawing.Color.White;
            this.yesButton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.yesButton.IdleLineColor = System.Drawing.Color.Silver;
            this.yesButton.Location = new System.Drawing.Point(331, 482);
            this.yesButton.Margin = new System.Windows.Forms.Padding(5);
            this.yesButton.Name = "yesButton";
            this.yesButton.Size = new System.Drawing.Size(102, 45);
            this.yesButton.TabIndex = 20;
            this.yesButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.yesButton.Click += new System.EventHandler(this.yesButton_Click);
            // 
            // courseNameBox
            // 
            this.courseNameBox.AutoSize = true;
            this.courseNameBox.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseNameBox.Location = new System.Drawing.Point(107, 535);
            this.courseNameBox.Name = "courseNameBox";
            this.courseNameBox.Size = new System.Drawing.Size(152, 32);
            this.courseNameBox.TabIndex = 19;
            this.courseNameBox.Text = "Course Name";
            this.courseNameBox.Visible = false;
            // 
            // courseBox
            // 
            this.courseBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseBox.Location = new System.Drawing.Point(265, 535);
            this.courseBox.Multiline = true;
            this.courseBox.Name = "courseBox";
            this.courseBox.Size = new System.Drawing.Size(282, 45);
            this.courseBox.TabIndex = 21;
            this.courseBox.Visible = false;
            // 
            // dropButton
            // 
            this.dropButton.ActiveBorderThickness = 1;
            this.dropButton.ActiveCornerRadius = 20;
            this.dropButton.ActiveFillColor = System.Drawing.Color.Silver;
            this.dropButton.ActiveForecolor = System.Drawing.Color.White;
            this.dropButton.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.dropButton.BackColor = System.Drawing.SystemColors.Control;
            this.dropButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dropButton.BackgroundImage")));
            this.dropButton.ButtonText = "DROP";
            this.dropButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dropButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropButton.ForeColor = System.Drawing.Color.White;
            this.dropButton.IdleBorderThickness = 1;
            this.dropButton.IdleCornerRadius = 20;
            this.dropButton.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.dropButton.IdleForecolor = System.Drawing.Color.White;
            this.dropButton.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.dropButton.Location = new System.Drawing.Point(573, 560);
            this.dropButton.Margin = new System.Windows.Forms.Padding(5);
            this.dropButton.Name = "dropButton";
            this.dropButton.Size = new System.Drawing.Size(174, 45);
            this.dropButton.TabIndex = 22;
            this.dropButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dropButton.Visible = false;
            this.dropButton.Click += new System.EventHandler(this.dropButton_Click);
            // 
            // courseGrid
            // 
            this.courseGrid.AllowUserToAddRows = false;
            this.courseGrid.AllowUserToDeleteRows = false;
            this.courseGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.courseGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.courseGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.courseGrid.Location = new System.Drawing.Point(27, 126);
            this.courseGrid.Name = "courseGrid";
            this.courseGrid.ReadOnly = true;
            this.courseGrid.RowTemplate.Height = 28;
            this.courseGrid.Size = new System.Drawing.Size(970, 328);
            this.courseGrid.TabIndex = 23;
            this.courseGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.courseGrid_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(135, 596);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 32);
            this.label3.TabIndex = 19;
            this.label3.Text = "Section";
            this.label3.Visible = false;
            // 
            // sectionBox
            // 
            this.sectionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sectionBox.Location = new System.Drawing.Point(265, 596);
            this.sectionBox.Multiline = true;
            this.sectionBox.Name = "sectionBox";
            this.sectionBox.Size = new System.Drawing.Size(282, 45);
            this.sectionBox.TabIndex = 21;
            this.sectionBox.Visible = false;
            // 
            // myCourseUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.courseGrid);
            this.Controls.Add(this.dropButton);
            this.Controls.Add(this.sectionBox);
            this.Controls.Add(this.courseBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.yesButton);
            this.Controls.Add(this.courseNameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "myCourseUserControl";
            this.Size = new System.Drawing.Size(1012, 668);
            this.Load += new System.EventHandler(this.myCourseUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.courseGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuThinButton2 yesButton;
        private System.Windows.Forms.Label courseNameBox;
        private System.Windows.Forms.TextBox courseBox;
        private Bunifu.Framework.UI.BunifuThinButton2 dropButton;
        private System.Windows.Forms.DataGridView courseGrid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sectionBox;
    }
}
