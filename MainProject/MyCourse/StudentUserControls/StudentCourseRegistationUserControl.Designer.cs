namespace MyCourse.StudentUserControls
{
    partial class StudentCourseRegistationUserControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentCourseRegistationUserControl));
            this.SectionGrid = new System.Windows.Forms.DataGridView();
            this.CourseGrid = new System.Windows.Forms.DataGridView();
            this.firstSectionBtn = new System.Windows.Forms.Button();
            this.SectionBox = new System.Windows.Forms.TextBox();
            this.CourseBox = new System.Windows.Forms.TextBox();
            this.firstCourseLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nextButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.searchIdBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.SectionGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CourseGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // SectionGrid
            // 
            this.SectionGrid.AllowUserToAddRows = false;
            this.SectionGrid.AllowUserToDeleteRows = false;
            this.SectionGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SectionGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SectionGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.SectionGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SectionGrid.GridColor = System.Drawing.Color.White;
            this.SectionGrid.Location = new System.Drawing.Point(401, 78);
            this.SectionGrid.Name = "SectionGrid";
            this.SectionGrid.ReadOnly = true;
            this.SectionGrid.RowTemplate.Height = 28;
            this.SectionGrid.Size = new System.Drawing.Size(608, 278);
            this.SectionGrid.TabIndex = 19;
            this.SectionGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SectionGrid_CellClick);
            // 
            // CourseGrid
            // 
            this.CourseGrid.AllowUserToAddRows = false;
            this.CourseGrid.AllowUserToDeleteRows = false;
            this.CourseGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CourseGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CourseGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.CourseGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CourseGrid.GridColor = System.Drawing.Color.White;
            this.CourseGrid.Location = new System.Drawing.Point(9, 78);
            this.CourseGrid.Name = "CourseGrid";
            this.CourseGrid.ReadOnly = true;
            this.CourseGrid.RowTemplate.Height = 28;
            this.CourseGrid.Size = new System.Drawing.Size(356, 278);
            this.CourseGrid.TabIndex = 20;
            this.CourseGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CourseGrid_CellClick);
            // 
            // firstSectionBtn
            // 
            this.firstSectionBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.firstSectionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.firstSectionBtn.Location = new System.Drawing.Point(484, 466);
            this.firstSectionBtn.Name = "firstSectionBtn";
            this.firstSectionBtn.Size = new System.Drawing.Size(117, 43);
            this.firstSectionBtn.TabIndex = 32;
            this.firstSectionBtn.Text = "Section";
            this.firstSectionBtn.UseVisualStyleBackColor = false;
            this.firstSectionBtn.Click += new System.EventHandler(this.firstSectionBtn_Click);
            // 
            // SectionBox
            // 
            this.SectionBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SectionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SectionBox.Location = new System.Drawing.Point(620, 466);
            this.SectionBox.Multiline = true;
            this.SectionBox.Name = "SectionBox";
            this.SectionBox.Size = new System.Drawing.Size(116, 43);
            this.SectionBox.TabIndex = 28;
            this.SectionBox.Visible = false;
            // 
            // CourseBox
            // 
            this.CourseBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CourseBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseBox.Location = new System.Drawing.Point(198, 466);
            this.CourseBox.Multiline = true;
            this.CourseBox.Name = "CourseBox";
            this.CourseBox.Size = new System.Drawing.Size(267, 43);
            this.CourseBox.TabIndex = 29;
            // 
            // firstCourseLabel
            // 
            this.firstCourseLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstCourseLabel.ForeColor = System.Drawing.Color.Black;
            this.firstCourseLabel.Location = new System.Drawing.Point(21, 463);
            this.firstCourseLabel.Name = "firstCourseLabel";
            this.firstCourseLabel.Size = new System.Drawing.Size(160, 43);
            this.firstCourseLabel.TabIndex = 23;
            this.firstCourseLabel.Text = "Course Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 33);
            this.label1.TabIndex = 14;
            this.label1.Text = "Course Table";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.label3.Location = new System.Drawing.Point(614, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 33);
            this.label3.TabIndex = 14;
            this.label3.Text = "SectionTable";
            // 
            // nextButton
            // 
            this.nextButton.ActiveBorderThickness = 1;
            this.nextButton.ActiveCornerRadius = 20;
            this.nextButton.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.nextButton.ActiveForecolor = System.Drawing.Color.WhiteSmoke;
            this.nextButton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.nextButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.nextButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("nextButton.BackgroundImage")));
            this.nextButton.ButtonText = "CONFIRM";
            this.nextButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.ForeColor = System.Drawing.Color.White;
            this.nextButton.IdleBorderThickness = 1;
            this.nextButton.IdleCornerRadius = 20;
            this.nextButton.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.nextButton.IdleForecolor = System.Drawing.Color.White;
            this.nextButton.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.nextButton.Location = new System.Drawing.Point(773, 582);
            this.nextButton.Margin = new System.Windows.Forms.Padding(5);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(185, 47);
            this.nextButton.TabIndex = 33;
            this.nextButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
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
            this.searchIdBox.Location = new System.Drawing.Point(220, 29);
            this.searchIdBox.Margin = new System.Windows.Forms.Padding(4);
            this.searchIdBox.Name = "searchIdBox";
            this.searchIdBox.Size = new System.Drawing.Size(145, 42);
            this.searchIdBox.TabIndex = 51;
            this.searchIdBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.searchIdBox.OnValueChanged += new System.EventHandler(this.searchIdBox_OnValueChanged);
            // 
            // StudentCourseRegistationUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.searchIdBox);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.firstSectionBtn);
            this.Controls.Add(this.SectionBox);
            this.Controls.Add(this.CourseBox);
            this.Controls.Add(this.firstCourseLabel);
            this.Controls.Add(this.SectionGrid);
            this.Controls.Add(this.CourseGrid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "StudentCourseRegistationUserControl";
            this.Size = new System.Drawing.Size(1012, 668);
            this.Load += new System.EventHandler(this.StudentCourseRegistationUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SectionGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CourseGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView SectionGrid;
        private System.Windows.Forms.DataGridView CourseGrid;
        private System.Windows.Forms.Button firstSectionBtn;
        private System.Windows.Forms.TextBox SectionBox;
        private System.Windows.Forms.TextBox CourseBox;
        private System.Windows.Forms.Label firstCourseLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuThinButton2 nextButton;
        private Bunifu.Framework.UI.BunifuMaterialTextbox searchIdBox;
    }
}
