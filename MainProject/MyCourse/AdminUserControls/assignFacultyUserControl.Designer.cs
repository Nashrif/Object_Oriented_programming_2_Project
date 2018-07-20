namespace MyCourse.AdminUserControls
{
    partial class assignFacultyUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(assignFacultyUserControl));
            this.courseGrid = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.facultyBox = new System.Windows.Forms.TextBox();
            this.sectionBox = new System.Windows.Forms.TextBox();
            this.courseNameBox = new System.Windows.Forms.TextBox();
            this.facultyGrid = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.confirmBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.searchFacultyBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.searchCourseBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.facultyIdBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.courseGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultyGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // courseGrid
            // 
            this.courseGrid.AllowUserToAddRows = false;
            this.courseGrid.AllowUserToDeleteRows = false;
            this.courseGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.courseGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.courseGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.courseGrid.Location = new System.Drawing.Point(521, 134);
            this.courseGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.courseGrid.Name = "courseGrid";
            this.courseGrid.ReadOnly = true;
            this.courseGrid.Size = new System.Drawing.Size(466, 272);
            this.courseGrid.TabIndex = 36;
            this.courseGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.courseGrid_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(27, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 37);
            this.label4.TabIndex = 35;
            this.label4.Text = "Faculty Table";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(158, 520);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 28);
            this.label3.TabIndex = 32;
            this.label3.Text = "Faculty Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(183, 475);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 28);
            this.label2.TabIndex = 33;
            this.label2.Text = "Section";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(160, 432);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 28);
            this.label1.TabIndex = 34;
            this.label1.Text = "Course Name";
            // 
            // facultyBox
            // 
            this.facultyBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.facultyBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.facultyBox.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facultyBox.Location = new System.Drawing.Point(338, 520);
            this.facultyBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.facultyBox.Name = "facultyBox";
            this.facultyBox.Size = new System.Drawing.Size(397, 34);
            this.facultyBox.TabIndex = 29;
            // 
            // sectionBox
            // 
            this.sectionBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.sectionBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sectionBox.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sectionBox.Location = new System.Drawing.Point(338, 475);
            this.sectionBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sectionBox.Name = "sectionBox";
            this.sectionBox.Size = new System.Drawing.Size(397, 34);
            this.sectionBox.TabIndex = 30;
            // 
            // courseNameBox
            // 
            this.courseNameBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.courseNameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.courseNameBox.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseNameBox.Location = new System.Drawing.Point(338, 431);
            this.courseNameBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.courseNameBox.Name = "courseNameBox";
            this.courseNameBox.Size = new System.Drawing.Size(397, 34);
            this.courseNameBox.TabIndex = 31;
            // 
            // facultyGrid
            // 
            this.facultyGrid.AllowUserToAddRows = false;
            this.facultyGrid.AllowUserToDeleteRows = false;
            this.facultyGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.facultyGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.facultyGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.facultyGrid.Location = new System.Drawing.Point(21, 134);
            this.facultyGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.facultyGrid.Name = "facultyGrid";
            this.facultyGrid.ReadOnly = true;
            this.facultyGrid.Size = new System.Drawing.Size(373, 272);
            this.facultyGrid.TabIndex = 28;
            this.facultyGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.facultyGrid_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(514, 22);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(221, 37);
            this.label5.TabIndex = 35;
            this.label5.Text = "Course Table";
            // 
            // confirmBtn
            // 
            this.confirmBtn.ActiveBorderThickness = 1;
            this.confirmBtn.ActiveCornerRadius = 20;
            this.confirmBtn.ActiveFillColor = System.Drawing.Color.Silver;
            this.confirmBtn.ActiveForecolor = System.Drawing.Color.White;
            this.confirmBtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.confirmBtn.BackColor = System.Drawing.SystemColors.Control;
            this.confirmBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("confirmBtn.BackgroundImage")));
            this.confirmBtn.ButtonText = "CONFIRM";
            this.confirmBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.confirmBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmBtn.ForeColor = System.Drawing.Color.White;
            this.confirmBtn.IdleBorderThickness = 1;
            this.confirmBtn.IdleCornerRadius = 20;
            this.confirmBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.confirmBtn.IdleForecolor = System.Drawing.Color.White;
            this.confirmBtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.confirmBtn.Location = new System.Drawing.Point(338, 618);
            this.confirmBtn.Margin = new System.Windows.Forms.Padding(5);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(203, 45);
            this.confirmBtn.TabIndex = 40;
            this.confirmBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // searchFacultyBox
            // 
            this.searchFacultyBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.searchFacultyBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchFacultyBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.searchFacultyBox.ForeColor = System.Drawing.Color.Black;
            this.searchFacultyBox.HintForeColor = System.Drawing.Color.Empty;
            this.searchFacultyBox.HintText = "SEARCH";
            this.searchFacultyBox.isPassword = false;
            this.searchFacultyBox.LineFocusedColor = System.Drawing.Color.Red;
            this.searchFacultyBox.LineIdleColor = System.Drawing.Color.Gray;
            this.searchFacultyBox.LineMouseHoverColor = System.Drawing.Color.Red;
            this.searchFacultyBox.LineThickness = 3;
            this.searchFacultyBox.Location = new System.Drawing.Point(188, 85);
            this.searchFacultyBox.Margin = new System.Windows.Forms.Padding(4);
            this.searchFacultyBox.Name = "searchFacultyBox";
            this.searchFacultyBox.Size = new System.Drawing.Size(207, 40);
            this.searchFacultyBox.TabIndex = 51;
            this.searchFacultyBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.searchFacultyBox.OnValueChanged += new System.EventHandler(this.searchFacultyBox_OnValueChanged);
            // 
            // searchCourseBox
            // 
            this.searchCourseBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.searchCourseBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchCourseBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.searchCourseBox.ForeColor = System.Drawing.Color.Black;
            this.searchCourseBox.HintForeColor = System.Drawing.Color.Empty;
            this.searchCourseBox.HintText = "SEARCH";
            this.searchCourseBox.isPassword = false;
            this.searchCourseBox.LineFocusedColor = System.Drawing.Color.Red;
            this.searchCourseBox.LineIdleColor = System.Drawing.Color.Gray;
            this.searchCourseBox.LineMouseHoverColor = System.Drawing.Color.Red;
            this.searchCourseBox.LineThickness = 3;
            this.searchCourseBox.Location = new System.Drawing.Point(780, 85);
            this.searchCourseBox.Margin = new System.Windows.Forms.Padding(4);
            this.searchCourseBox.Name = "searchCourseBox";
            this.searchCourseBox.Size = new System.Drawing.Size(207, 40);
            this.searchCourseBox.TabIndex = 52;
            this.searchCourseBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.searchCourseBox.OnValueChanged += new System.EventHandler(this.searchCourseBox_OnValueChanged);
            // 
            // facultyIdBox
            // 
            this.facultyIdBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.facultyIdBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.facultyIdBox.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facultyIdBox.Location = new System.Drawing.Point(338, 564);
            this.facultyIdBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.facultyIdBox.Name = "facultyIdBox";
            this.facultyIdBox.Size = new System.Drawing.Size(397, 34);
            this.facultyIdBox.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(183, 564);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 28);
            this.label8.TabIndex = 32;
            this.label8.Text = "Faculty ID";
            // 
            // assignFacultyUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.searchCourseBox);
            this.Controls.Add(this.searchFacultyBox);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.courseGrid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.facultyIdBox);
            this.Controls.Add(this.facultyBox);
            this.Controls.Add(this.sectionBox);
            this.Controls.Add(this.courseNameBox);
            this.Controls.Add(this.facultyGrid);
            this.Name = "assignFacultyUserControl";
            this.Size = new System.Drawing.Size(1012, 668);
            this.Load += new System.EventHandler(this.assignFacultyUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.courseGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultyGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView courseGrid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox facultyBox;
        private System.Windows.Forms.TextBox sectionBox;
        private System.Windows.Forms.TextBox courseNameBox;
        private System.Windows.Forms.DataGridView facultyGrid;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuThinButton2 confirmBtn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox searchFacultyBox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox searchCourseBox;
        private System.Windows.Forms.TextBox facultyIdBox;
        private System.Windows.Forms.Label label8;
    }
}
