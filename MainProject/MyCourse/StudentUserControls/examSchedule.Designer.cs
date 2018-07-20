namespace MyCourse
{
    partial class examScheduleUserControl
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
            this.label2 = new System.Windows.Forms.Label();
            this.examGrid = new System.Windows.Forms.DataGridView();
            this.selectBtn = new System.Windows.Forms.Button();
            this.sectionNameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.courseNameBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.courseGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.examGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(54, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(299, 57);
            this.label2.TabIndex = 0;
            this.label2.Text = "Schedule";
            // 
            // examGrid
            // 
            this.examGrid.AllowUserToAddRows = false;
            this.examGrid.AllowUserToDeleteRows = false;
            this.examGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.examGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.examGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.examGrid.GridColor = System.Drawing.SystemColors.Control;
            this.examGrid.Location = new System.Drawing.Point(62, 329);
            this.examGrid.Name = "examGrid";
            this.examGrid.ReadOnly = true;
            this.examGrid.RowTemplate.Height = 28;
            this.examGrid.Size = new System.Drawing.Size(431, 266);
            this.examGrid.TabIndex = 1;
            // 
            // selectBtn
            // 
            this.selectBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.selectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectBtn.ForeColor = System.Drawing.Color.White;
            this.selectBtn.Location = new System.Drawing.Point(480, 120);
            this.selectBtn.Name = "selectBtn";
            this.selectBtn.Size = new System.Drawing.Size(131, 36);
            this.selectBtn.TabIndex = 65;
            this.selectBtn.Text = "SELECT";
            this.selectBtn.UseVisualStyleBackColor = false;
            this.selectBtn.Click += new System.EventHandler(this.selectBtn_Click);
            // 
            // sectionNameBox
            // 
            this.sectionNameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sectionNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sectionNameBox.Location = new System.Drawing.Point(187, 138);
            this.sectionNameBox.Multiline = true;
            this.sectionNameBox.Name = "sectionNameBox";
            this.sectionNameBox.Size = new System.Drawing.Size(287, 43);
            this.sectionNameBox.TabIndex = 63;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(83, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 38);
            this.label3.TabIndex = 61;
            this.label3.Text = "Section";
            // 
            // courseNameBox
            // 
            this.courseNameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.courseNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseNameBox.Location = new System.Drawing.Point(187, 89);
            this.courseNameBox.Multiline = true;
            this.courseNameBox.Name = "courseNameBox";
            this.courseNameBox.Size = new System.Drawing.Size(287, 43);
            this.courseNameBox.TabIndex = 64;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(83, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 38);
            this.label5.TabIndex = 62;
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
            this.courseGrid.Location = new System.Drawing.Point(650, 45);
            this.courseGrid.Name = "courseGrid";
            this.courseGrid.ReadOnly = true;
            this.courseGrid.RowTemplate.Height = 28;
            this.courseGrid.Size = new System.Drawing.Size(316, 213);
            this.courseGrid.TabIndex = 60;
            this.courseGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.courseGrid_CellClick);
            // 
            // examScheduleUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.selectBtn);
            this.Controls.Add(this.sectionNameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.courseNameBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.courseGrid);
            this.Controls.Add(this.examGrid);
            this.Controls.Add(this.label2);
            this.Name = "examScheduleUserControl";
            this.Size = new System.Drawing.Size(1012, 668);
            this.Load += new System.EventHandler(this.examScheduleUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.examGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView examGrid;
        private System.Windows.Forms.Button selectBtn;
        private System.Windows.Forms.TextBox sectionNameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox courseNameBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView courseGrid;
    }
}
