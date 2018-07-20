namespace MyCourse.AdminUserControls
{
    partial class facultyListUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(facultyListUserControl));
            this.panel1 = new System.Windows.Forms.Panel();
            this.confirmBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label1 = new System.Windows.Forms.Label();
            this.facultyIdBox = new System.Windows.Forms.TextBox();
            this.removeBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label4 = new System.Windows.Forms.Label();
            this.facultyListGrid = new System.Windows.Forms.DataGridView();
            this.searchIdBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facultyListGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.confirmBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.facultyIdBox);
            this.panel1.Location = new System.Drawing.Point(33, 503);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(418, 143);
            this.panel1.TabIndex = 51;
            this.panel1.Visible = false;
            // 
            // confirmBtn
            // 
            this.confirmBtn.ActiveBorderThickness = 1;
            this.confirmBtn.ActiveCornerRadius = 20;
            this.confirmBtn.ActiveFillColor = System.Drawing.Color.Silver;
            this.confirmBtn.ActiveForecolor = System.Drawing.Color.White;
            this.confirmBtn.ActiveLineColor = System.Drawing.Color.Gray;
            this.confirmBtn.BackColor = System.Drawing.SystemColors.Control;
            this.confirmBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("confirmBtn.BackgroundImage")));
            this.confirmBtn.ButtonText = "Confirm";
            this.confirmBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.confirmBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.confirmBtn.IdleBorderThickness = 1;
            this.confirmBtn.IdleCornerRadius = 20;
            this.confirmBtn.IdleFillColor = System.Drawing.Color.White;
            this.confirmBtn.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.confirmBtn.IdleLineColor = System.Drawing.Color.Silver;
            this.confirmBtn.Location = new System.Drawing.Point(190, 70);
            this.confirmBtn.Margin = new System.Windows.Forms.Padding(5);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(137, 45);
            this.confirmBtn.TabIndex = 46;
            this.confirmBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 28);
            this.label1.TabIndex = 40;
            this.label1.Text = "Faculty Id";
            // 
            // facultyIdBox
            // 
            this.facultyIdBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.facultyIdBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facultyIdBox.Location = new System.Drawing.Point(137, 19);
            this.facultyIdBox.Multiline = true;
            this.facultyIdBox.Name = "facultyIdBox";
            this.facultyIdBox.Size = new System.Drawing.Size(266, 43);
            this.facultyIdBox.TabIndex = 41;
            // 
            // removeBtn
            // 
            this.removeBtn.ActiveBorderThickness = 1;
            this.removeBtn.ActiveCornerRadius = 20;
            this.removeBtn.ActiveFillColor = System.Drawing.Color.Silver;
            this.removeBtn.ActiveForecolor = System.Drawing.Color.White;
            this.removeBtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.removeBtn.BackColor = System.Drawing.SystemColors.Control;
            this.removeBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("removeBtn.BackgroundImage")));
            this.removeBtn.ButtonText = "REMOVE A FACULTY";
            this.removeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeBtn.ForeColor = System.Drawing.Color.White;
            this.removeBtn.IdleBorderThickness = 1;
            this.removeBtn.IdleCornerRadius = 20;
            this.removeBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.removeBtn.IdleForecolor = System.Drawing.Color.White;
            this.removeBtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.removeBtn.Location = new System.Drawing.Point(44, 438);
            this.removeBtn.Margin = new System.Windows.Forms.Padding(5);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(285, 45);
            this.removeBtn.TabIndex = 50;
            this.removeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(37, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 37);
            this.label4.TabIndex = 49;
            this.label4.Text = "Faculty List";
            // 
            // facultyListGrid
            // 
            this.facultyListGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.facultyListGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.facultyListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.facultyListGrid.Location = new System.Drawing.Point(44, 64);
            this.facultyListGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.facultyListGrid.Name = "facultyListGrid";
            this.facultyListGrid.Size = new System.Drawing.Size(650, 364);
            this.facultyListGrid.TabIndex = 48;
            this.facultyListGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.facultyListGrid_CellClick);
            // 
            // searchIdBox
            // 
            this.searchIdBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.searchIdBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchIdBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.searchIdBox.ForeColor = System.Drawing.Color.Black;
            this.searchIdBox.HintForeColor = System.Drawing.Color.Empty;
            this.searchIdBox.HintText = "SEARCH";
            this.searchIdBox.isPassword = false;
            this.searchIdBox.LineFocusedColor = System.Drawing.Color.Red;
            this.searchIdBox.LineIdleColor = System.Drawing.Color.Gray;
            this.searchIdBox.LineMouseHoverColor = System.Drawing.Color.Red;
            this.searchIdBox.LineThickness = 3;
            this.searchIdBox.Location = new System.Drawing.Point(487, 15);
            this.searchIdBox.Margin = new System.Windows.Forms.Padding(4);
            this.searchIdBox.Name = "searchIdBox";
            this.searchIdBox.Size = new System.Drawing.Size(207, 40);
            this.searchIdBox.TabIndex = 53;
            this.searchIdBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.searchIdBox.OnValueChanged += new System.EventHandler(this.searchIdBox_OnValueChanged);
            // 
            // facultyListUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.searchIdBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.facultyListGrid);
            this.Name = "facultyListUserControl";
            this.Size = new System.Drawing.Size(1012, 668);
            this.Load += new System.EventHandler(this.facultyListUserControl_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facultyListGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 confirmBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox facultyIdBox;
        private Bunifu.Framework.UI.BunifuThinButton2 removeBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView facultyListGrid;
        private Bunifu.Framework.UI.BunifuMaterialTextbox searchIdBox;
    }
}
