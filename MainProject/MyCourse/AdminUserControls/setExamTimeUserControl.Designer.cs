namespace MyCourse.AdminUserControls
{
    partial class setExamTimeUserControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(setExamTimeUserControl));
            this.label2 = new System.Windows.Forms.Label();
            this.courseNameBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.examDataGrid = new System.Windows.Forms.DataGridView();
            this.confirmBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.searchIdBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.examDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(45, 465);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 28);
            this.label2.TabIndex = 28;
            this.label2.Text = "Enter Course Name";
            // 
            // courseNameBox
            // 
            this.courseNameBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.courseNameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.courseNameBox.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseNameBox.Location = new System.Drawing.Point(276, 465);
            this.courseNameBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.courseNameBox.Name = "courseNameBox";
            this.courseNameBox.Size = new System.Drawing.Size(298, 34);
            this.courseNameBox.TabIndex = 27;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "";
            this.dateTimePicker.Location = new System.Drawing.Point(276, 521);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(298, 26);
            this.dateTimePicker.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(124, 521);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 28);
            this.label1.TabIndex = 25;
            this.label1.Text = "Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(43, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 37);
            this.label4.TabIndex = 24;
            this.label4.Text = "Course Table";
            // 
            // examDataGrid
            // 
            this.examDataGrid.AllowUserToAddRows = false;
            this.examDataGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            this.examDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.examDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.examDataGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.examDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.examDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.examDataGrid.Location = new System.Drawing.Point(50, 67);
            this.examDataGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.examDataGrid.MultiSelect = false;
            this.examDataGrid.Name = "examDataGrid";
            this.examDataGrid.ReadOnly = true;
            this.examDataGrid.Size = new System.Drawing.Size(607, 338);
            this.examDataGrid.TabIndex = 23;
            this.examDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.examDataGrid_CellClick);
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
            this.confirmBtn.Location = new System.Drawing.Point(276, 575);
            this.confirmBtn.Margin = new System.Windows.Forms.Padding(5);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(203, 45);
            this.confirmBtn.TabIndex = 41;
            this.confirmBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
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
            this.searchIdBox.LineIdleColor = System.Drawing.Color.Gray;
            this.searchIdBox.LineMouseHoverColor = System.Drawing.Color.Red;
            this.searchIdBox.LineThickness = 1;
            this.searchIdBox.Location = new System.Drawing.Point(450, 18);
            this.searchIdBox.Margin = new System.Windows.Forms.Padding(4);
            this.searchIdBox.Name = "searchIdBox";
            this.searchIdBox.Size = new System.Drawing.Size(207, 40);
            this.searchIdBox.TabIndex = 50;
            this.searchIdBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.searchIdBox.OnValueChanged += new System.EventHandler(this.searchIdBox_OnValueChanged);
            // 
            // setExamTimeUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.searchIdBox);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.courseNameBox);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.examDataGrid);
            this.Name = "setExamTimeUserControl";
            this.Size = new System.Drawing.Size(1012, 668);
            this.Load += new System.EventHandler(this.setExamTimeUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.examDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox courseNameBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView examDataGrid;
        private Bunifu.Framework.UI.BunifuThinButton2 confirmBtn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox searchIdBox;
    }
}
