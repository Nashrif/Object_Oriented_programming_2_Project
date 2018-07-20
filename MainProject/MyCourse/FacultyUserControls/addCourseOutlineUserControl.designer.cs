namespace MyCourse
{
    partial class addCourseOutlineUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addCourseOutlineUserControl));
            this.registeredCourseGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.courseNameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.outlineBox = new System.Windows.Forms.TextBox();
            this.firstOutlineBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label4 = new System.Windows.Forms.Label();
            this.sectionBox = new System.Windows.Forms.TextBox();
            this.outlineGrid = new System.Windows.Forms.DataGridView();
            this.Selectbutton = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.registeredCourseGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outlineGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // registeredCourseGrid
            // 
            this.registeredCourseGrid.AllowUserToAddRows = false;
            this.registeredCourseGrid.AllowUserToDeleteRows = false;
            this.registeredCourseGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.registeredCourseGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.registeredCourseGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.registeredCourseGrid.Location = new System.Drawing.Point(288, 20);
            this.registeredCourseGrid.Name = "registeredCourseGrid";
            this.registeredCourseGrid.ReadOnly = true;
            this.registeredCourseGrid.RowTemplate.Height = 28;
            this.registeredCourseGrid.Size = new System.Drawing.Size(454, 226);
            this.registeredCourseGrid.TabIndex = 0;
            this.registeredCourseGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.registeredCourseGrid_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 45);
            this.label1.TabIndex = 26;
            this.label1.Text = "Registered Course";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 38);
            this.label2.TabIndex = 26;
            this.label2.Text = "Select Course";
            // 
            // courseNameBox
            // 
            this.courseNameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.courseNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseNameBox.Location = new System.Drawing.Point(200, 270);
            this.courseNameBox.Multiline = true;
            this.courseNameBox.Name = "courseNameBox";
            this.courseNameBox.Size = new System.Drawing.Size(335, 43);
            this.courseNameBox.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 469);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(453, 38);
            this.label3.TabIndex = 26;
            this.label3.Text = "Insert Course Outline (One At A Time)";
            // 
            // outlineBox
            // 
            this.outlineBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outlineBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outlineBox.Location = new System.Drawing.Point(72, 543);
            this.outlineBox.Multiline = true;
            this.outlineBox.Name = "outlineBox";
            this.outlineBox.Size = new System.Drawing.Size(335, 43);
            this.outlineBox.TabIndex = 27;
            // 
            // firstOutlineBtn
            // 
            this.firstOutlineBtn.ActiveBorderThickness = 1;
            this.firstOutlineBtn.ActiveCornerRadius = 20;
            this.firstOutlineBtn.ActiveFillColor = System.Drawing.Color.Silver;
            this.firstOutlineBtn.ActiveForecolor = System.Drawing.Color.White;
            this.firstOutlineBtn.ActiveLineColor = System.Drawing.Color.Gray;
            this.firstOutlineBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.firstOutlineBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("firstOutlineBtn.BackgroundImage")));
            this.firstOutlineBtn.ButtonText = "ADD";
            this.firstOutlineBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.firstOutlineBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstOutlineBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.firstOutlineBtn.IdleBorderThickness = 1;
            this.firstOutlineBtn.IdleCornerRadius = 20;
            this.firstOutlineBtn.IdleFillColor = System.Drawing.Color.White;
            this.firstOutlineBtn.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.firstOutlineBtn.IdleLineColor = System.Drawing.Color.Silver;
            this.firstOutlineBtn.Location = new System.Drawing.Point(415, 541);
            this.firstOutlineBtn.Margin = new System.Windows.Forms.Padding(5);
            this.firstOutlineBtn.Name = "firstOutlineBtn";
            this.firstOutlineBtn.Size = new System.Drawing.Size(102, 45);
            this.firstOutlineBtn.TabIndex = 28;
            this.firstOutlineBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.firstOutlineBtn.Click += new System.EventHandler(this.firstOutlineBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 38);
            this.label4.TabIndex = 26;
            this.label4.Text = "Select Section";
            // 
            // sectionBox
            // 
            this.sectionBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sectionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sectionBox.Location = new System.Drawing.Point(200, 319);
            this.sectionBox.Multiline = true;
            this.sectionBox.Name = "sectionBox";
            this.sectionBox.Size = new System.Drawing.Size(335, 43);
            this.sectionBox.TabIndex = 27;
            // 
            // outlineGrid
            // 
            this.outlineGrid.AllowUserToAddRows = false;
            this.outlineGrid.AllowUserToDeleteRows = false;
            this.outlineGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.outlineGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.outlineGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.outlineGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.outlineGrid.Location = new System.Drawing.Point(594, 384);
            this.outlineGrid.Name = "outlineGrid";
            this.outlineGrid.ReadOnly = true;
            this.outlineGrid.RowTemplate.Height = 28;
            this.outlineGrid.Size = new System.Drawing.Size(385, 272);
            this.outlineGrid.TabIndex = 0;
            // 
            // Selectbutton
            // 
            this.Selectbutton.ActiveBorderThickness = 1;
            this.Selectbutton.ActiveCornerRadius = 20;
            this.Selectbutton.ActiveFillColor = System.Drawing.Color.Silver;
            this.Selectbutton.ActiveForecolor = System.Drawing.Color.White;
            this.Selectbutton.ActiveLineColor = System.Drawing.Color.Gray;
            this.Selectbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Selectbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Selectbutton.BackgroundImage")));
            this.Selectbutton.ButtonText = "Select";
            this.Selectbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Selectbutton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Selectbutton.ForeColor = System.Drawing.Color.SeaGreen;
            this.Selectbutton.IdleBorderThickness = 1;
            this.Selectbutton.IdleCornerRadius = 20;
            this.Selectbutton.IdleFillColor = System.Drawing.Color.White;
            this.Selectbutton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.Selectbutton.IdleLineColor = System.Drawing.Color.Silver;
            this.Selectbutton.Location = new System.Drawing.Point(559, 293);
            this.Selectbutton.Margin = new System.Windows.Forms.Padding(8);
            this.Selectbutton.Name = "Selectbutton";
            this.Selectbutton.Size = new System.Drawing.Size(102, 45);
            this.Selectbutton.TabIndex = 29;
            this.Selectbutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Selectbutton.Click += new System.EventHandler(this.Selectbutton_Click);
            // 
            // addCourseOutlineUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.Selectbutton);
            this.Controls.Add(this.firstOutlineBtn);
            this.Controls.Add(this.outlineBox);
            this.Controls.Add(this.sectionBox);
            this.Controls.Add(this.courseNameBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outlineGrid);
            this.Controls.Add(this.registeredCourseGrid);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "addCourseOutlineUserControl";
            this.Size = new System.Drawing.Size(994, 671);
            this.Load += new System.EventHandler(this.addCourseOutlineUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.registeredCourseGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outlineGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView registeredCourseGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox courseNameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox outlineBox;
        private Bunifu.Framework.UI.BunifuThinButton2 firstOutlineBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox sectionBox;
        private System.Windows.Forms.DataGridView outlineGrid;
        private Bunifu.Framework.UI.BunifuThinButton2 Selectbutton;
    }
}
