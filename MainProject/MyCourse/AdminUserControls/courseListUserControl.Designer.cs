namespace MyCourse.AdminUserControls
{
    partial class courseListUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(courseListUserControl));
            this.label1 = new System.Windows.Forms.Label();
            this.courseListGrid = new System.Windows.Forms.DataGridView();
            this.courseIdBox = new System.Windows.Forms.TextBox();
            this.sectionBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.completeBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.searchIdBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.sectionBox1 = new System.Windows.Forms.TextBox();
            this.sectionBox2 = new System.Windows.Forms.TextBox();
            this.courseNameBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.courseListGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(35, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 37);
            this.label1.TabIndex = 10;
            this.label1.Text = "Registered Courses ";
            // 
            // courseListGrid
            // 
            this.courseListGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.courseListGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.courseListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.courseListGrid.Location = new System.Drawing.Point(42, 60);
            this.courseListGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.courseListGrid.Name = "courseListGrid";
            this.courseListGrid.Size = new System.Drawing.Size(880, 365);
            this.courseListGrid.TabIndex = 9;
            this.courseListGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.courseListGrid_CellClick);
            // 
            // courseIdBox
            // 
            this.courseIdBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.courseIdBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseIdBox.Location = new System.Drawing.Point(209, 487);
            this.courseIdBox.Multiline = true;
            this.courseIdBox.Name = "courseIdBox";
            this.courseIdBox.Size = new System.Drawing.Size(266, 43);
            this.courseIdBox.TabIndex = 28;
            // 
            // sectionBox
            // 
            this.sectionBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sectionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sectionBox.Location = new System.Drawing.Point(209, 547);
            this.sectionBox.Multiline = true;
            this.sectionBox.Name = "sectionBox";
            this.sectionBox.Size = new System.Drawing.Size(266, 43);
            this.sectionBox.TabIndex = 29;
            this.sectionBox.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(19, 487);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "Course Id";
            // 
            // completeBtn
            // 
            this.completeBtn.ActiveBorderThickness = 1;
            this.completeBtn.ActiveCornerRadius = 20;
            this.completeBtn.ActiveFillColor = System.Drawing.Color.Silver;
            this.completeBtn.ActiveForecolor = System.Drawing.Color.White;
            this.completeBtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.completeBtn.BackColor = System.Drawing.SystemColors.Control;
            this.completeBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("completeBtn.BackgroundImage")));
            this.completeBtn.ButtonText = "REMOVE";
            this.completeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.completeBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.completeBtn.ForeColor = System.Drawing.Color.White;
            this.completeBtn.IdleBorderThickness = 1;
            this.completeBtn.IdleCornerRadius = 20;
            this.completeBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.completeBtn.IdleForecolor = System.Drawing.Color.White;
            this.completeBtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.completeBtn.Location = new System.Drawing.Point(495, 487);
            this.completeBtn.Margin = new System.Windows.Forms.Padding(5);
            this.completeBtn.Name = "completeBtn";
            this.completeBtn.Size = new System.Drawing.Size(169, 45);
            this.completeBtn.TabIndex = 38;
            this.completeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.completeBtn.Click += new System.EventHandler(this.completeBtn_Click);
            // 
            // searchIdBox
            // 
            this.searchIdBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.searchIdBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchIdBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.searchIdBox.ForeColor = System.Drawing.Color.Black;
            this.searchIdBox.HintForeColor = System.Drawing.Color.Empty;
            this.searchIdBox.HintText = "Search";
            this.searchIdBox.isPassword = false;
            this.searchIdBox.LineFocusedColor = System.Drawing.Color.Red;
            this.searchIdBox.LineIdleColor = System.Drawing.Color.DimGray;
            this.searchIdBox.LineMouseHoverColor = System.Drawing.Color.Red;
            this.searchIdBox.LineThickness = 3;
            this.searchIdBox.Location = new System.Drawing.Point(715, 11);
            this.searchIdBox.Margin = new System.Windows.Forms.Padding(4);
            this.searchIdBox.Name = "searchIdBox";
            this.searchIdBox.Size = new System.Drawing.Size(207, 40);
            this.searchIdBox.TabIndex = 50;
            this.searchIdBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.searchIdBox.OnValueChanged += new System.EventHandler(this.searchIdBox_OnValueChanged);
            // 
            // sectionBox1
            // 
            this.sectionBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sectionBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sectionBox1.Location = new System.Drawing.Point(209, 596);
            this.sectionBox1.Multiline = true;
            this.sectionBox1.Name = "sectionBox1";
            this.sectionBox1.Size = new System.Drawing.Size(266, 43);
            this.sectionBox1.TabIndex = 29;
            this.sectionBox1.Visible = false;
            // 
            // sectionBox2
            // 
            this.sectionBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sectionBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sectionBox2.Location = new System.Drawing.Point(481, 596);
            this.sectionBox2.Multiline = true;
            this.sectionBox2.Name = "sectionBox2";
            this.sectionBox2.Size = new System.Drawing.Size(266, 43);
            this.sectionBox2.TabIndex = 29;
            this.sectionBox2.Visible = false;
            // 
            // courseNameBox
            // 
            this.courseNameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.courseNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseNameBox.Location = new System.Drawing.Point(481, 547);
            this.courseNameBox.Multiline = true;
            this.courseNameBox.Name = "courseNameBox";
            this.courseNameBox.Size = new System.Drawing.Size(266, 43);
            this.courseNameBox.TabIndex = 29;
            this.courseNameBox.Visible = false;
            // 
            // courseListUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.searchIdBox);
            this.Controls.Add(this.completeBtn);
            this.Controls.Add(this.courseNameBox);
            this.Controls.Add(this.sectionBox2);
            this.Controls.Add(this.sectionBox1);
            this.Controls.Add(this.sectionBox);
            this.Controls.Add(this.courseIdBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.courseListGrid);
            this.Name = "courseListUserControl";
            this.Size = new System.Drawing.Size(1012, 668);
            this.Load += new System.EventHandler(this.courseListUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.courseListGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView courseListGrid;
        private System.Windows.Forms.TextBox courseIdBox;
        private System.Windows.Forms.TextBox sectionBox;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuThinButton2 completeBtn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox searchIdBox;
        private System.Windows.Forms.TextBox sectionBox1;
        private System.Windows.Forms.TextBox sectionBox2;
        private System.Windows.Forms.TextBox courseNameBox;
    }
}
