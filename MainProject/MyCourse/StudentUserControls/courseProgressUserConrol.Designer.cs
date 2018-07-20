namespace MyCourse
{
    partial class courseProgressUserConrol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(courseProgressUserConrol));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.openBtn = new System.Windows.Forms.Button();
            this.TopicGrid = new System.Windows.Forms.DataGridView();
            this.progressBox = new System.Windows.Forms.TextBox();
            this.topicBox = new System.Windows.Forms.TextBox();
            this.courseNameLabel = new System.Windows.Forms.Label();
            this.progressBar = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.selectBtn = new System.Windows.Forms.Button();
            this.sectionNameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.courseNameBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.courseGrid = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TopicGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.openBtn);
            this.panel1.Controls.Add(this.TopicGrid);
            this.panel1.Controls.Add(this.progressBox);
            this.panel1.Controls.Add(this.topicBox);
            this.panel1.Controls.Add(this.courseNameLabel);
            this.panel1.Controls.Add(this.progressBar);
            this.panel1.Location = new System.Drawing.Point(0, 252);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1009, 413);
            this.panel1.TabIndex = 24;
            this.panel1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(651, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 45);
            this.label1.TabIndex = 66;
            this.label1.Text = "Completed";
            // 
            // openBtn
            // 
            this.openBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.openBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openBtn.ForeColor = System.Drawing.Color.White;
            this.openBtn.Location = new System.Drawing.Point(785, 76);
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(169, 36);
            this.openBtn.TabIndex = 68;
            this.openBtn.Text = "PROGRESS";
            this.openBtn.UseVisualStyleBackColor = false;
            this.openBtn.Click += new System.EventHandler(this.openBtn_Click);
            // 
            // TopicGrid
            // 
            this.TopicGrid.AllowUserToAddRows = false;
            this.TopicGrid.AllowUserToDeleteRows = false;
            this.TopicGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TopicGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TopicGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TopicGrid.Location = new System.Drawing.Point(-2, 3);
            this.TopicGrid.Name = "TopicGrid";
            this.TopicGrid.ReadOnly = true;
            this.TopicGrid.RowTemplate.Height = 28;
            this.TopicGrid.Size = new System.Drawing.Size(321, 408);
            this.TopicGrid.TabIndex = 3;
            this.TopicGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TopicGrid_CellClick);
            // 
            // progressBox
            // 
            this.progressBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.progressBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressBox.Location = new System.Drawing.Point(376, 129);
            this.progressBox.Multiline = true;
            this.progressBox.Name = "progressBox";
            this.progressBox.Size = new System.Drawing.Size(386, 43);
            this.progressBox.TabIndex = 67;
            this.progressBox.Visible = false;
            // 
            // topicBox
            // 
            this.topicBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.topicBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topicBox.Location = new System.Drawing.Point(376, 69);
            this.topicBox.Multiline = true;
            this.topicBox.Name = "topicBox";
            this.topicBox.Size = new System.Drawing.Size(386, 43);
            this.topicBox.TabIndex = 67;
            // 
            // courseNameLabel
            // 
            this.courseNameLabel.AutoSize = true;
            this.courseNameLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseNameLabel.Location = new System.Drawing.Point(376, 21);
            this.courseNameLabel.Name = "courseNameLabel";
            this.courseNameLabel.Size = new System.Drawing.Size(91, 45);
            this.courseNameLabel.TabIndex = 66;
            this.courseNameLabel.Text = "Topic";
            // 
            // progressBar
            // 
            this.progressBar.animated = false;
            this.progressBar.animationIterval = 1;
            this.progressBar.animationSpeed = 100;
            this.progressBar.BackColor = System.Drawing.SystemColors.Control;
            this.progressBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("progressBar.BackgroundImage")));
            this.progressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.progressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
            this.progressBar.LabelVisible = true;
            this.progressBar.LineProgressThickness = 6;
            this.progressBar.LineThickness = 2;
            this.progressBar.Location = new System.Drawing.Point(468, 206);
            this.progressBar.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.progressBar.MaxValue = 100;
            this.progressBar.Name = "progressBar";
            this.progressBar.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.progressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(127)))), ((int)(((byte)(48)))));
            this.progressBar.Size = new System.Drawing.Size(175, 175);
            this.progressBar.TabIndex = 2;
            this.progressBar.Value = 0;
            // 
            // selectBtn
            // 
            this.selectBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.selectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectBtn.ForeColor = System.Drawing.Color.White;
            this.selectBtn.Location = new System.Drawing.Point(435, 95);
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
            this.sectionNameBox.Location = new System.Drawing.Point(142, 113);
            this.sectionNameBox.Multiline = true;
            this.sectionNameBox.Name = "sectionNameBox";
            this.sectionNameBox.Size = new System.Drawing.Size(287, 43);
            this.sectionNameBox.TabIndex = 63;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 38);
            this.label2.TabIndex = 61;
            this.label2.Text = "Section";
            // 
            // courseNameBox
            // 
            this.courseNameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.courseNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseNameBox.Location = new System.Drawing.Point(142, 64);
            this.courseNameBox.Multiline = true;
            this.courseNameBox.Name = "courseNameBox";
            this.courseNameBox.Size = new System.Drawing.Size(287, 43);
            this.courseNameBox.TabIndex = 64;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 62);
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
            this.courseGrid.Location = new System.Drawing.Point(605, 20);
            this.courseGrid.Name = "courseGrid";
            this.courseGrid.ReadOnly = true;
            this.courseGrid.RowTemplate.Height = 28;
            this.courseGrid.Size = new System.Drawing.Size(316, 213);
            this.courseGrid.TabIndex = 60;
            this.courseGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.courseGrid_CellClick);
            // 
            // courseProgressUserConrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.selectBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sectionNameBox);
            this.Controls.Add(this.courseGrid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.courseNameBox);
            this.Name = "courseProgressUserConrol";
            this.Size = new System.Drawing.Size(1012, 668);
            this.Load += new System.EventHandler(this.courseProgressUserConrol_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TopicGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCircleProgressbar progressBar;
        private System.Windows.Forms.DataGridView TopicGrid;
        private System.Windows.Forms.Button selectBtn;
        private System.Windows.Forms.TextBox sectionNameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox courseNameBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView courseGrid;
        private System.Windows.Forms.Button openBtn;
        private System.Windows.Forms.TextBox progressBox;
        private System.Windows.Forms.TextBox topicBox;
        private System.Windows.Forms.Label courseNameLabel;
        private System.Windows.Forms.Label label1;
    }
}
