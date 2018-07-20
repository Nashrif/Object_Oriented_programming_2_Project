namespace MyCourse
{
    partial class insertCourseProgressUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(insertCourseProgressUserControl));
            this.panel1 = new System.Windows.Forms.Panel();
            this.completeBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.outlineGrid = new System.Windows.Forms.DataGridView();
            this.percentageBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.outlineBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.selectBtn = new System.Windows.Forms.Button();
            this.courseGrid = new System.Windows.Forms.DataGridView();
            this.sectionNameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.courseNameBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outlineGrid)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.completeBtn);
            this.panel1.Controls.Add(this.outlineGrid);
            this.panel1.Controls.Add(this.percentageBox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.outlineBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(0, 203);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(991, 465);
            this.panel1.TabIndex = 37;
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
            this.completeBtn.ButtonText = "INSERT";
            this.completeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.completeBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.completeBtn.ForeColor = System.Drawing.Color.White;
            this.completeBtn.IdleBorderThickness = 1;
            this.completeBtn.IdleCornerRadius = 20;
            this.completeBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.completeBtn.IdleForecolor = System.Drawing.Color.White;
            this.completeBtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.completeBtn.Location = new System.Drawing.Point(613, 359);
            this.completeBtn.Margin = new System.Windows.Forms.Padding(5);
            this.completeBtn.Name = "completeBtn";
            this.completeBtn.Size = new System.Drawing.Size(199, 45);
            this.completeBtn.TabIndex = 37;
            this.completeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.completeBtn.Click += new System.EventHandler(this.completeBtn_Click);
            // 
            // outlineGrid
            // 
            this.outlineGrid.AllowUserToAddRows = false;
            this.outlineGrid.AllowUserToDeleteRows = false;
            this.outlineGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.outlineGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.outlineGrid.Location = new System.Drawing.Point(10, 48);
            this.outlineGrid.Name = "outlineGrid";
            this.outlineGrid.ReadOnly = true;
            this.outlineGrid.RowTemplate.Height = 28;
            this.outlineGrid.Size = new System.Drawing.Size(419, 305);
            this.outlineGrid.TabIndex = 36;
            this.outlineGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.outlineGrid_CellClick);
            // 
            // percentageBox
            // 
            this.percentageBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.percentageBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percentageBox.Location = new System.Drawing.Point(488, 294);
            this.percentageBox.Multiline = true;
            this.percentageBox.Name = "percentageBox";
            this.percentageBox.Size = new System.Drawing.Size(470, 43);
            this.percentageBox.TabIndex = 34;
            this.percentageBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.percentageBox_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(481, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(278, 38);
            this.label6.TabIndex = 33;
            this.label6.Text = "Percentage Completed";
            // 
            // outlineBox
            // 
            this.outlineBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outlineBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outlineBox.Location = new System.Drawing.Point(488, 188);
            this.outlineBox.Multiline = true;
            this.outlineBox.Name = "outlineBox";
            this.outlineBox.Size = new System.Drawing.Size(470, 43);
            this.outlineBox.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(481, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 38);
            this.label4.TabIndex = 33;
            this.label4.Text = "Topic";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.selectBtn);
            this.panel2.Controls.Add(this.courseGrid);
            this.panel2.Controls.Add(this.sectionNameBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.courseNameBox);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(987, 200);
            this.panel2.TabIndex = 43;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // selectBtn
            // 
            this.selectBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.selectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectBtn.ForeColor = System.Drawing.Color.White;
            this.selectBtn.Location = new System.Drawing.Point(397, 89);
            this.selectBtn.Name = "selectBtn";
            this.selectBtn.Size = new System.Drawing.Size(131, 36);
            this.selectBtn.TabIndex = 47;
            this.selectBtn.Text = "SELECT";
            this.selectBtn.UseVisualStyleBackColor = false;
            this.selectBtn.Click += new System.EventHandler(this.selectBtn_Click_1);
            // 
            // courseGrid
            // 
            this.courseGrid.AllowUserToAddRows = false;
            this.courseGrid.AllowUserToDeleteRows = false;
            this.courseGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.courseGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.courseGrid.Location = new System.Drawing.Point(600, 3);
            this.courseGrid.Name = "courseGrid";
            this.courseGrid.ReadOnly = true;
            this.courseGrid.RowTemplate.Height = 28;
            this.courseGrid.Size = new System.Drawing.Size(384, 191);
            this.courseGrid.TabIndex = 46;
            this.courseGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.courseGrid_CellClick);
            // 
            // sectionNameBox
            // 
            this.sectionNameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sectionNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sectionNameBox.Location = new System.Drawing.Point(104, 105);
            this.sectionNameBox.Multiline = true;
            this.sectionNameBox.Name = "sectionNameBox";
            this.sectionNameBox.Size = new System.Drawing.Size(287, 43);
            this.sectionNameBox.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 38);
            this.label2.TabIndex = 41;
            this.label2.Text = "Section";
            // 
            // courseNameBox
            // 
            this.courseNameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.courseNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseNameBox.Location = new System.Drawing.Point(104, 56);
            this.courseNameBox.Multiline = true;
            this.courseNameBox.Name = "courseNameBox";
            this.courseNameBox.Size = new System.Drawing.Size(287, 43);
            this.courseNameBox.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 38);
            this.label5.TabIndex = 42;
            this.label5.Text = "Course";
            // 
            // insertCourseProgressUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "insertCourseProgressUserControl";
            this.Size = new System.Drawing.Size(994, 671);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outlineGrid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView outlineGrid;
        private System.Windows.Forms.TextBox outlineBox;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuThinButton2 completeBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView courseGrid;
        private System.Windows.Forms.TextBox sectionNameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox courseNameBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox percentageBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button selectBtn;
    }
}
