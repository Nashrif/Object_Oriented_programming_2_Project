namespace MyCourse
{
    partial class noticeUserControl
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.noticeGrid = new System.Windows.Forms.DataGridView();
            this.openBtn = new System.Windows.Forms.Button();
            this.subjectBox = new System.Windows.Forms.TextBox();
            this.courseNameLabel = new System.Windows.Forms.Label();
            this.noticeSubjectGrid = new System.Windows.Forms.DataGridView();
            this.selectBtn = new System.Windows.Forms.Button();
            this.sectionNameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.courseNameBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.courseGrid = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.noticeGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noticeSubjectGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.noticeGrid);
            this.panel1.Controls.Add(this.openBtn);
            this.panel1.Controls.Add(this.subjectBox);
            this.panel1.Controls.Add(this.courseNameLabel);
            this.panel1.Controls.Add(this.noticeSubjectGrid);
            this.panel1.Location = new System.Drawing.Point(0, 222);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1012, 443);
            this.panel1.TabIndex = 30;
            // 
            // noticeGrid
            // 
            this.noticeGrid.AllowUserToAddRows = false;
            this.noticeGrid.AllowUserToDeleteRows = false;
            this.noticeGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.noticeGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.noticeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.noticeGrid.Location = new System.Drawing.Point(304, 199);
            this.noticeGrid.Name = "noticeGrid";
            this.noticeGrid.ReadOnly = true;
            this.noticeGrid.RowTemplate.Height = 28;
            this.noticeGrid.Size = new System.Drawing.Size(687, 211);
            this.noticeGrid.TabIndex = 0;
            this.noticeGrid.Visible = false;
            // 
            // openBtn
            // 
            this.openBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.openBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openBtn.ForeColor = System.Drawing.Color.White;
            this.openBtn.Location = new System.Drawing.Point(795, 149);
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(131, 36);
            this.openBtn.TabIndex = 54;
            this.openBtn.Text = "OPEN";
            this.openBtn.UseVisualStyleBackColor = false;
            this.openBtn.Click += new System.EventHandler(this.openBtn_Click);
            // 
            // subjectBox
            // 
            this.subjectBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.subjectBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectBox.Location = new System.Drawing.Point(312, 142);
            this.subjectBox.Multiline = true;
            this.subjectBox.Name = "subjectBox";
            this.subjectBox.Size = new System.Drawing.Size(455, 43);
            this.subjectBox.TabIndex = 30;
            // 
            // courseNameLabel
            // 
            this.courseNameLabel.AutoSize = true;
            this.courseNameLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseNameLabel.Location = new System.Drawing.Point(304, 94);
            this.courseNameLabel.Name = "courseNameLabel";
            this.courseNameLabel.Size = new System.Drawing.Size(119, 45);
            this.courseNameLabel.TabIndex = 2;
            this.courseNameLabel.Text = "Subject";
            // 
            // noticeSubjectGrid
            // 
            this.noticeSubjectGrid.AllowUserToAddRows = false;
            this.noticeSubjectGrid.AllowUserToDeleteRows = false;
            this.noticeSubjectGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.noticeSubjectGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.noticeSubjectGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.noticeSubjectGrid.Location = new System.Drawing.Point(-2, 3);
            this.noticeSubjectGrid.Name = "noticeSubjectGrid";
            this.noticeSubjectGrid.ReadOnly = true;
            this.noticeSubjectGrid.RowTemplate.Height = 28;
            this.noticeSubjectGrid.Size = new System.Drawing.Size(300, 441);
            this.noticeSubjectGrid.TabIndex = 0;
            this.noticeSubjectGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.noticeSubjectGrid_CellClick);
            // 
            // selectBtn
            // 
            this.selectBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.selectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectBtn.ForeColor = System.Drawing.Color.White;
            this.selectBtn.Location = new System.Drawing.Point(521, 78);
            this.selectBtn.Name = "selectBtn";
            this.selectBtn.Size = new System.Drawing.Size(131, 36);
            this.selectBtn.TabIndex = 59;
            this.selectBtn.Text = "SELECT";
            this.selectBtn.UseVisualStyleBackColor = false;
            this.selectBtn.Click += new System.EventHandler(this.selectBtn_Click);
            // 
            // sectionNameBox
            // 
            this.sectionNameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sectionNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sectionNameBox.Location = new System.Drawing.Point(228, 96);
            this.sectionNameBox.Multiline = true;
            this.sectionNameBox.Name = "sectionNameBox";
            this.sectionNameBox.Size = new System.Drawing.Size(287, 43);
            this.sectionNameBox.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(124, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 38);
            this.label2.TabIndex = 55;
            this.label2.Text = "Section";
            // 
            // courseNameBox
            // 
            this.courseNameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.courseNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseNameBox.Location = new System.Drawing.Point(228, 47);
            this.courseNameBox.Multiline = true;
            this.courseNameBox.Name = "courseNameBox";
            this.courseNameBox.Size = new System.Drawing.Size(287, 43);
            this.courseNameBox.TabIndex = 58;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(124, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 38);
            this.label5.TabIndex = 56;
            this.label5.Text = "Course";
            // 
            // courseGrid
            // 
            this.courseGrid.AllowUserToAddRows = false;
            this.courseGrid.AllowUserToDeleteRows = false;
            this.courseGrid.AllowUserToResizeColumns = false;
            this.courseGrid.AllowUserToResizeRows = false;
            this.courseGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.courseGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.courseGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.courseGrid.Location = new System.Drawing.Point(691, 3);
            this.courseGrid.Name = "courseGrid";
            this.courseGrid.ReadOnly = true;
            this.courseGrid.RowTemplate.Height = 28;
            this.courseGrid.Size = new System.Drawing.Size(316, 213);
            this.courseGrid.TabIndex = 54;
            this.courseGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.courseGrid_CellClick);
            // 
            // noticeUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.selectBtn);
            this.Controls.Add(this.sectionNameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.courseNameBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.courseGrid);
            this.Controls.Add(this.panel1);
            this.Name = "noticeUserControl";
            this.Size = new System.Drawing.Size(1012, 668);
            this.Load += new System.EventHandler(this.noticeUserControl_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.noticeGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noticeSubjectGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView noticeSubjectGrid;
        private System.Windows.Forms.Label courseNameLabel;
        private System.Windows.Forms.TextBox subjectBox;
        private System.Windows.Forms.Button openBtn;
        private System.Windows.Forms.Button selectBtn;
        private System.Windows.Forms.TextBox sectionNameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox courseNameBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView courseGrid;
        private System.Windows.Forms.DataGridView noticeGrid;
        //private projectDatabaseDataSet projectDatabaseDataSet;
    }
}
