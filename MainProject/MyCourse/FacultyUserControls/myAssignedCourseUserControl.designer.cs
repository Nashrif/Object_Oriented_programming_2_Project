namespace MyCourse
{
    partial class myAssignedCourseUserControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.AssignedGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.AssignedGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 45);
            this.label1.TabIndex = 25;
            this.label1.Text = "Registered Courses";
            // 
            // AssignedGrid
            // 
            this.AssignedGrid.AllowUserToAddRows = false;
            this.AssignedGrid.AllowUserToDeleteRows = false;
            this.AssignedGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AssignedGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.AssignedGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AssignedGrid.Location = new System.Drawing.Point(75, 144);
            this.AssignedGrid.Name = "AssignedGrid";
            this.AssignedGrid.ReadOnly = true;
            this.AssignedGrid.RowTemplate.Height = 28;
            this.AssignedGrid.Size = new System.Drawing.Size(594, 363);
            this.AssignedGrid.TabIndex = 26;
            // 
            // myAssignedCourseUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AssignedGrid);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "myAssignedCourseUserControl";
            this.Size = new System.Drawing.Size(994, 671);
            this.Load += new System.EventHandler(this.myAssignedCourseUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AssignedGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView AssignedGrid;
    }
}
