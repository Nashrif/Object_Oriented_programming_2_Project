namespace MyCourse
{
    partial class noteUserControl
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(noteUserControl));
            this.firstCoursePanel = new System.Windows.Forms.Panel();
            this.firstCourseFolder = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.firstCourseLabel = new System.Windows.Forms.Label();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.listView = new System.Windows.Forms.ListView();
            this.courseGrid = new System.Windows.Forms.DataGridView();
            this.selectBtn = new System.Windows.Forms.Button();
            this.sectionNameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.courseNameBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.firstCoursePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.firstCourseFolder)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // firstCoursePanel
            // 
            this.firstCoursePanel.Controls.Add(this.firstCourseFolder);
            this.firstCoursePanel.Controls.Add(this.panel2);
            this.firstCoursePanel.Location = new System.Drawing.Point(3, 140);
            this.firstCoursePanel.Name = "firstCoursePanel";
            this.firstCoursePanel.Size = new System.Drawing.Size(187, 177);
            this.firstCoursePanel.TabIndex = 0;
            this.firstCoursePanel.Visible = false;
            // 
            // firstCourseFolder
            // 
            this.firstCourseFolder.BackColor = System.Drawing.SystemColors.Control;
            this.firstCourseFolder.Image = ((System.Drawing.Image)(resources.GetObject("firstCourseFolder.Image")));
            this.firstCourseFolder.ImageActive = null;
            this.firstCourseFolder.Location = new System.Drawing.Point(0, 6);
            this.firstCourseFolder.Name = "firstCourseFolder";
            this.firstCourseFolder.Size = new System.Drawing.Size(184, 107);
            this.firstCourseFolder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.firstCourseFolder.TabIndex = 1;
            this.firstCourseFolder.TabStop = false;
            this.firstCourseFolder.Zoom = 10;
            this.firstCourseFolder.Click += new System.EventHandler(this.firstCourseFolder_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.firstCourseLabel);
            this.panel2.Location = new System.Drawing.Point(4, 116);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(180, 58);
            this.panel2.TabIndex = 0;
            // 
            // firstCourseLabel
            // 
            this.firstCourseLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstCourseLabel.Location = new System.Drawing.Point(3, 11);
            this.firstCourseLabel.Name = "firstCourseLabel";
            this.firstCourseLabel.Size = new System.Drawing.Size(174, 47);
            this.firstCourseLabel.TabIndex = 0;
            this.firstCourseLabel.Text = "label1";
            this.firstCourseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList.ImageSize = new System.Drawing.Size(32, 32);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // listView
            // 
            this.listView.LargeImageList = this.imageList;
            this.listView.Location = new System.Drawing.Point(3, 323);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(1005, 342);
            this.listView.TabIndex = 1;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
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
            this.courseGrid.Location = new System.Drawing.Point(643, 3);
            this.courseGrid.Name = "courseGrid";
            this.courseGrid.ReadOnly = true;
            this.courseGrid.RowTemplate.Height = 28;
            this.courseGrid.Size = new System.Drawing.Size(316, 244);
            this.courseGrid.TabIndex = 2;
            this.courseGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.courseGrid_CellClick);
            // 
            // selectBtn
            // 
            this.selectBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.selectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectBtn.ForeColor = System.Drawing.Color.White;
            this.selectBtn.Location = new System.Drawing.Point(418, 45);
            this.selectBtn.Name = "selectBtn";
            this.selectBtn.Size = new System.Drawing.Size(131, 36);
            this.selectBtn.TabIndex = 53;
            this.selectBtn.Text = "SELECT";
            this.selectBtn.UseVisualStyleBackColor = false;
            this.selectBtn.Click += new System.EventHandler(this.selectBtn_Click);
            // 
            // sectionNameBox
            // 
            this.sectionNameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sectionNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sectionNameBox.Location = new System.Drawing.Point(125, 63);
            this.sectionNameBox.Multiline = true;
            this.sectionNameBox.Name = "sectionNameBox";
            this.sectionNameBox.Size = new System.Drawing.Size(287, 43);
            this.sectionNameBox.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 38);
            this.label2.TabIndex = 49;
            this.label2.Text = "Section";
            // 
            // courseNameBox
            // 
            this.courseNameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.courseNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseNameBox.Location = new System.Drawing.Point(125, 14);
            this.courseNameBox.Multiline = true;
            this.courseNameBox.Name = "courseNameBox";
            this.courseNameBox.Size = new System.Drawing.Size(287, 43);
            this.courseNameBox.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 38);
            this.label5.TabIndex = 50;
            this.label5.Text = "Course";
            // 
            // noteUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.selectBtn);
            this.Controls.Add(this.sectionNameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.courseNameBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.courseGrid);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.firstCoursePanel);
            this.Name = "noteUserControl";
            this.Size = new System.Drawing.Size(1012, 668);
            this.Load += new System.EventHandler(this.noteUserControl_Load);
            this.firstCoursePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.firstCourseFolder)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.courseGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel firstCoursePanel;
        private Bunifu.Framework.UI.BunifuImageButton firstCourseFolder;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label firstCourseLabel;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.DataGridView courseGrid;
        private System.Windows.Forms.Button selectBtn;
        private System.Windows.Forms.TextBox sectionNameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox courseNameBox;
        private System.Windows.Forms.Label label5;
    }
}
