namespace MyCourse
{
    partial class insertNoticeUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(insertNoticeUserControl));
            this.panel1 = new System.Windows.Forms.Panel();
            this.confirmBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.noticeBox = new System.Windows.Forms.RichTextBox();
            this.subjectBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.subjectLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.courseGrid = new System.Windows.Forms.DataGridView();
            this.sectionNameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.courseNameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.confirmBtn);
            this.panel1.Controls.Add(this.noticeBox);
            this.panel1.Controls.Add(this.subjectBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.subjectLabel);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 239);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(994, 432);
            this.panel1.TabIndex = 41;
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
            this.confirmBtn.Location = new System.Drawing.Point(320, 357);
            this.confirmBtn.Margin = new System.Windows.Forms.Padding(5);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(199, 45);
            this.confirmBtn.TabIndex = 38;
            this.confirmBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // noticeBox
            // 
            this.noticeBox.Location = new System.Drawing.Point(48, 218);
            this.noticeBox.Name = "noticeBox";
            this.noticeBox.Size = new System.Drawing.Size(827, 117);
            this.noticeBox.TabIndex = 2;
            this.noticeBox.Text = "";
            // 
            // subjectBox
            // 
            this.subjectBox.Location = new System.Drawing.Point(48, 92);
            this.subjectBox.Multiline = true;
            this.subjectBox.Name = "subjectBox";
            this.subjectBox.Size = new System.Drawing.Size(338, 46);
            this.subjectBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Cambria", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Notice";
            // 
            // subjectLabel
            // 
            this.subjectLabel.Font = new System.Drawing.Font("Cambria", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectLabel.Location = new System.Drawing.Point(41, 39);
            this.subjectLabel.Name = "subjectLabel";
            this.subjectLabel.Size = new System.Drawing.Size(217, 50);
            this.subjectLabel.TabIndex = 0;
            this.subjectLabel.Text = "Subject";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.courseGrid);
            this.panel2.Controls.Add(this.sectionNameBox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.courseNameBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(4, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(987, 233);
            this.panel2.TabIndex = 42;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // courseGrid
            // 
            this.courseGrid.AllowUserToAddRows = false;
            this.courseGrid.AllowUserToDeleteRows = false;
            this.courseGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.courseGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.courseGrid.Location = new System.Drawing.Point(501, 17);
            this.courseGrid.Name = "courseGrid";
            this.courseGrid.ReadOnly = true;
            this.courseGrid.RowTemplate.Height = 28;
            this.courseGrid.Size = new System.Drawing.Size(384, 197);
            this.courseGrid.TabIndex = 46;
            this.courseGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.courseGrid_CellClick);
            // 
            // sectionNameBox
            // 
            this.sectionNameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sectionNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sectionNameBox.Location = new System.Drawing.Point(103, 153);
            this.sectionNameBox.Multiline = true;
            this.sectionNameBox.Name = "sectionNameBox";
            this.sectionNameBox.Size = new System.Drawing.Size(287, 30);
            this.sectionNameBox.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-1, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 38);
            this.label3.TabIndex = 41;
            this.label3.Text = "Section";
            // 
            // courseNameBox
            // 
            this.courseNameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.courseNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseNameBox.Location = new System.Drawing.Point(103, 100);
            this.courseNameBox.Multiline = true;
            this.courseNameBox.Name = "courseNameBox";
            this.courseNameBox.Size = new System.Drawing.Size(287, 30);
            this.courseNameBox.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-1, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 38);
            this.label2.TabIndex = 42;
            this.label2.Text = "Course";
            // 
            // insertNoticeUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "insertNoticeUserControl";
            this.Size = new System.Drawing.Size(994, 671);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox noticeBox;
        private System.Windows.Forms.TextBox subjectBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label subjectLabel;
        private Bunifu.Framework.UI.BunifuThinButton2 confirmBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView courseGrid;
        private System.Windows.Forms.TextBox sectionNameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox courseNameBox;
        private System.Windows.Forms.Label label2;
    }
}
