namespace MyCourse
{
    partial class viewStudentUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewStudentUserControl));
            this.label1 = new System.Windows.Forms.Label();
            this.studentListGrid = new System.Windows.Forms.DataGridView();
            this.yesButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label4 = new System.Windows.Forms.Label();
            this.removeStudentPanel = new System.Windows.Forms.Panel();
            this.removeBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.StudentIdBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.StudentNameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.selectBtn = new System.Windows.Forms.Button();
            this.courseGrid = new System.Windows.Forms.DataGridView();
            this.sectionNameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.courseNameBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.searchBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.studentListGrid)).BeginInit();
            this.removeStudentPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 45);
            this.label1.TabIndex = 33;
            this.label1.Text = "Student List";
            // 
            // studentListGrid
            // 
            this.studentListGrid.AllowUserToAddRows = false;
            this.studentListGrid.AllowUserToDeleteRows = false;
            this.studentListGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.studentListGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.studentListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentListGrid.Location = new System.Drawing.Point(13, 297);
            this.studentListGrid.Name = "studentListGrid";
            this.studentListGrid.ReadOnly = true;
            this.studentListGrid.RowTemplate.Height = 28;
            this.studentListGrid.Size = new System.Drawing.Size(416, 252);
            this.studentListGrid.TabIndex = 34;
            this.studentListGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentListGrid_CellClick);
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
            this.yesButton.Location = new System.Drawing.Point(141, 614);
            this.yesButton.Margin = new System.Windows.Forms.Padding(5);
            this.yesButton.Name = "yesButton";
            this.yesButton.Size = new System.Drawing.Size(102, 45);
            this.yesButton.TabIndex = 37;
            this.yesButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.yesButton.Click += new System.EventHandler(this.yesButton_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 564);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(439, 45);
            this.label4.TabIndex = 36;
            this.label4.Text = "Wanna Remove A Student From Course?";
            // 
            // removeStudentPanel
            // 
            this.removeStudentPanel.Controls.Add(this.removeBtn);
            this.removeStudentPanel.Controls.Add(this.StudentIdBox);
            this.removeStudentPanel.Controls.Add(this.label6);
            this.removeStudentPanel.Controls.Add(this.StudentNameBox);
            this.removeStudentPanel.Controls.Add(this.label3);
            this.removeStudentPanel.Location = new System.Drawing.Point(484, 381);
            this.removeStudentPanel.Name = "removeStudentPanel";
            this.removeStudentPanel.Size = new System.Drawing.Size(496, 168);
            this.removeStudentPanel.TabIndex = 38;
            this.removeStudentPanel.Visible = false;
            // 
            // removeBtn
            // 
            this.removeBtn.ActiveBorderThickness = 1;
            this.removeBtn.ActiveCornerRadius = 20;
            this.removeBtn.ActiveFillColor = System.Drawing.Color.Silver;
            this.removeBtn.ActiveForecolor = System.Drawing.Color.White;
            this.removeBtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.removeBtn.BackColor = System.Drawing.SystemColors.Control;
            this.removeBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("removeBtn.BackgroundImage")));
            this.removeBtn.ButtonText = "Remove";
            this.removeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeBtn.ForeColor = System.Drawing.Color.White;
            this.removeBtn.IdleBorderThickness = 1;
            this.removeBtn.IdleCornerRadius = 20;
            this.removeBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.removeBtn.IdleForecolor = System.Drawing.Color.White;
            this.removeBtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.removeBtn.Location = new System.Drawing.Point(249, 118);
            this.removeBtn.Margin = new System.Windows.Forms.Padding(5);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(174, 45);
            this.removeBtn.TabIndex = 42;
            this.removeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // StudentIdBox
            // 
            this.StudentIdBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentIdBox.Location = new System.Drawing.Point(197, 65);
            this.StudentIdBox.Multiline = true;
            this.StudentIdBox.Name = "StudentIdBox";
            this.StudentIdBox.Size = new System.Drawing.Size(282, 45);
            this.StudentIdBox.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 45);
            this.label6.TabIndex = 40;
            this.label6.Text = "Student Id";
            // 
            // StudentNameBox
            // 
            this.StudentNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentNameBox.Location = new System.Drawing.Point(197, 14);
            this.StudentNameBox.Multiline = true;
            this.StudentNameBox.Name = "StudentNameBox";
            this.StudentNameBox.Size = new System.Drawing.Size(282, 45);
            this.StudentNameBox.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 45);
            this.label3.TabIndex = 40;
            this.label3.Text = "Student Name";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.selectBtn);
            this.panel2.Controls.Add(this.courseGrid);
            this.panel2.Controls.Add(this.sectionNameBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.courseNameBox);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(4, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(987, 233);
            this.panel2.TabIndex = 43;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // selectBtn
            // 
            this.selectBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.selectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectBtn.ForeColor = System.Drawing.Color.White;
            this.selectBtn.Location = new System.Drawing.Point(396, 122);
            this.selectBtn.Name = "selectBtn";
            this.selectBtn.Size = new System.Drawing.Size(131, 36);
            this.selectBtn.TabIndex = 48;
            this.selectBtn.Text = "SELECT";
            this.selectBtn.UseVisualStyleBackColor = false;
            this.selectBtn.Click += new System.EventHandler(this.selectBtn_Click_1);
            // 
            // courseGrid
            // 
            this.courseGrid.AllowUserToAddRows = false;
            this.courseGrid.AllowUserToDeleteRows = false;
            this.courseGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.courseGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.courseGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.courseGrid.Location = new System.Drawing.Point(587, 18);
            this.courseGrid.Name = "courseGrid";
            this.courseGrid.ReadOnly = true;
            this.courseGrid.RowTemplate.Height = 28;
            this.courseGrid.Size = new System.Drawing.Size(389, 197);
            this.courseGrid.TabIndex = 46;
            this.courseGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.courseGrid_CellClick);
            // 
            // sectionNameBox
            // 
            this.sectionNameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sectionNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sectionNameBox.Location = new System.Drawing.Point(103, 140);
            this.sectionNameBox.Multiline = true;
            this.sectionNameBox.Name = "sectionNameBox";
            this.sectionNameBox.Size = new System.Drawing.Size(287, 43);
            this.sectionNameBox.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-1, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 38);
            this.label2.TabIndex = 41;
            this.label2.Text = "Section";
            // 
            // courseNameBox
            // 
            this.courseNameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.courseNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseNameBox.Location = new System.Drawing.Point(103, 91);
            this.courseNameBox.Multiline = true;
            this.courseNameBox.Name = "courseNameBox";
            this.courseNameBox.Size = new System.Drawing.Size(287, 43);
            this.courseNameBox.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(-1, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 38);
            this.label5.TabIndex = 42;
            this.label5.Text = "Course";
            // 
            // searchBox
            // 
            this.searchBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.searchBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.searchBox.ForeColor = System.Drawing.Color.Black;
            this.searchBox.HintForeColor = System.Drawing.Color.Empty;
            this.searchBox.HintText = "SEARCH";
            this.searchBox.isPassword = false;
            this.searchBox.LineFocusedColor = System.Drawing.Color.Red;
            this.searchBox.LineIdleColor = System.Drawing.Color.Gray;
            this.searchBox.LineMouseHoverColor = System.Drawing.Color.Red;
            this.searchBox.LineThickness = 1;
            this.searchBox.Location = new System.Drawing.Point(251, 250);
            this.searchBox.Margin = new System.Windows.Forms.Padding(4);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(178, 40);
            this.searchBox.TabIndex = 50;
            this.searchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.searchBox.OnValueChanged += new System.EventHandler(this.searchBox_OnValueChanged);
            // 
            // viewStudentUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.removeStudentPanel);
            this.Controls.Add(this.yesButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.studentListGrid);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "viewStudentUserControl";
            this.Size = new System.Drawing.Size(994, 671);
            this.Load += new System.EventHandler(this.viewStudentUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentListGrid)).EndInit();
            this.removeStudentPanel.ResumeLayout(false);
            this.removeStudentPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView studentListGrid;
        private Bunifu.Framework.UI.BunifuThinButton2 yesButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel removeStudentPanel;
        private Bunifu.Framework.UI.BunifuThinButton2 removeBtn;
        private System.Windows.Forms.TextBox StudentNameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView courseGrid;
        private System.Windows.Forms.TextBox sectionNameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox courseNameBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox StudentIdBox;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuMaterialTextbox searchBox;
        private System.Windows.Forms.Button selectBtn;
    }
}
