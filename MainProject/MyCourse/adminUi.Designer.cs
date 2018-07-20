namespace MyCourse
{
    partial class adminUi
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminUi));
            this.panel2 = new System.Windows.Forms.Panel();
            this.examTimeBtn = new System.Windows.Forms.Button();
            this.assignFacultyBtn = new System.Windows.Forms.Button();
            this.createCourseButton = new System.Windows.Forms.Button();
            this.courseListBtn = new System.Windows.Forms.Button();
            this.facultyListBtn = new System.Windows.Forms.Button();
            this.studentListBtn = new System.Windows.Forms.Button();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.logOut = new System.Windows.Forms.Button();
            this.topLabel = new System.Windows.Forms.Label();
            this.facultyListUserControl1 = new MyCourse.AdminUserControls.facultyListUserControl();
            this.studentListUserControl1 = new MyCourse.AdminUserControls.StudentUserControl();
            this.courseListUserControl1 = new MyCourse.AdminUserControls.courseListUserControl();
            this.createCourseUserControl1 = new MyCourse.AdminUserControls.createCourseUserControl();
            this.assignFacultyUserControl1 = new MyCourse.AdminUserControls.assignFacultyUserControl();
            this.setExamTimeUserControl1 = new MyCourse.AdminUserControls.setExamTimeUserControl();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Controls.Add(this.examTimeBtn);
            this.panel2.Controls.Add(this.assignFacultyBtn);
            this.panel2.Controls.Add(this.createCourseButton);
            this.panel2.Controls.Add(this.courseListBtn);
            this.panel2.Controls.Add(this.facultyListBtn);
            this.panel2.Controls.Add(this.studentListBtn);
            this.panel2.Controls.Add(this.sidePanel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(285, 720);
            this.panel2.TabIndex = 3;
            // 
            // examTimeBtn
            // 
            this.examTimeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.examTimeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.examTimeBtn.FlatAppearance.BorderSize = 0;
            this.examTimeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.examTimeBtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.examTimeBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.examTimeBtn.Image = ((System.Drawing.Image)(resources.GetObject("examTimeBtn.Image")));
            this.examTimeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.examTimeBtn.Location = new System.Drawing.Point(12, 506);
            this.examTimeBtn.Name = "examTimeBtn";
            this.examTimeBtn.Size = new System.Drawing.Size(270, 61);
            this.examTimeBtn.TabIndex = 11;
            this.examTimeBtn.Text = "Set Exam Time";
            this.examTimeBtn.UseVisualStyleBackColor = true;
            this.examTimeBtn.Click += new System.EventHandler(this.examTimeBtn_Click);
            // 
            // assignFacultyBtn
            // 
            this.assignFacultyBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.assignFacultyBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.assignFacultyBtn.FlatAppearance.BorderSize = 0;
            this.assignFacultyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.assignFacultyBtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignFacultyBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.assignFacultyBtn.Image = ((System.Drawing.Image)(resources.GetObject("assignFacultyBtn.Image")));
            this.assignFacultyBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.assignFacultyBtn.Location = new System.Drawing.Point(12, 432);
            this.assignFacultyBtn.Name = "assignFacultyBtn";
            this.assignFacultyBtn.Size = new System.Drawing.Size(270, 57);
            this.assignFacultyBtn.TabIndex = 12;
            this.assignFacultyBtn.Text = "Assign Faculty\r\nTo Course";
            this.assignFacultyBtn.UseVisualStyleBackColor = true;
            this.assignFacultyBtn.Click += new System.EventHandler(this.assignFacultyBtn_Click);
            // 
            // createCourseButton
            // 
            this.createCourseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.createCourseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createCourseButton.FlatAppearance.BorderSize = 0;
            this.createCourseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createCourseButton.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createCourseButton.ForeColor = System.Drawing.SystemColors.Control;
            this.createCourseButton.Image = ((System.Drawing.Image)(resources.GetObject("createCourseButton.Image")));
            this.createCourseButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.createCourseButton.Location = new System.Drawing.Point(12, 136);
            this.createCourseButton.Name = "createCourseButton";
            this.createCourseButton.Size = new System.Drawing.Size(270, 57);
            this.createCourseButton.TabIndex = 15;
            this.createCourseButton.Text = "Create A Course";
            this.createCourseButton.UseVisualStyleBackColor = true;
            this.createCourseButton.Click += new System.EventHandler(this.createCourseButton_Click_1);
            // 
            // courseListBtn
            // 
            this.courseListBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.courseListBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.courseListBtn.FlatAppearance.BorderSize = 0;
            this.courseListBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.courseListBtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseListBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.courseListBtn.Image = ((System.Drawing.Image)(resources.GetObject("courseListBtn.Image")));
            this.courseListBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.courseListBtn.Location = new System.Drawing.Point(12, 209);
            this.courseListBtn.Name = "courseListBtn";
            this.courseListBtn.Size = new System.Drawing.Size(270, 57);
            this.courseListBtn.TabIndex = 15;
            this.courseListBtn.Text = "Course List";
            this.courseListBtn.UseVisualStyleBackColor = true;
            this.courseListBtn.Click += new System.EventHandler(this.courseListBtn_Click_1);
            // 
            // facultyListBtn
            // 
            this.facultyListBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.facultyListBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.facultyListBtn.FlatAppearance.BorderSize = 0;
            this.facultyListBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.facultyListBtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facultyListBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.facultyListBtn.Image = ((System.Drawing.Image)(resources.GetObject("facultyListBtn.Image")));
            this.facultyListBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.facultyListBtn.Location = new System.Drawing.Point(12, 282);
            this.facultyListBtn.Name = "facultyListBtn";
            this.facultyListBtn.Size = new System.Drawing.Size(270, 57);
            this.facultyListBtn.TabIndex = 13;
            this.facultyListBtn.Text = "Faculty List";
            this.facultyListBtn.UseVisualStyleBackColor = true;
            this.facultyListBtn.Click += new System.EventHandler(this.facultyListBtn_Click_1);
            // 
            // studentListBtn
            // 
            this.studentListBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.studentListBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.studentListBtn.FlatAppearance.BorderSize = 0;
            this.studentListBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.studentListBtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentListBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.studentListBtn.Image = ((System.Drawing.Image)(resources.GetObject("studentListBtn.Image")));
            this.studentListBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.studentListBtn.Location = new System.Drawing.Point(12, 358);
            this.studentListBtn.Name = "studentListBtn";
            this.studentListBtn.Size = new System.Drawing.Size(270, 57);
            this.studentListBtn.TabIndex = 14;
            this.studentListBtn.Text = "Student List";
            this.studentListBtn.UseVisualStyleBackColor = true;
            this.studentListBtn.Click += new System.EventHandler(this.studentListBtn_Click_1);
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(170)))), ((int)(((byte)(210)))));
            this.sidePanel.Location = new System.Drawing.Point(3, 140);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(10, 53);
            this.sidePanel.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Controls.Add(this.logOut);
            this.panel1.Controls.Add(this.topLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(285, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1015, 46);
            this.panel1.TabIndex = 10;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(953, 1);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(50, 42);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 5;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click_1);
            // 
            // logOut
            // 
            this.logOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logOut.FlatAppearance.BorderSize = 0;
            this.logOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOut.Image = ((System.Drawing.Image)(resources.GetObject("logOut.Image")));
            this.logOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logOut.Location = new System.Drawing.Point(775, 4);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(181, 42);
            this.logOut.TabIndex = 4;
            this.logOut.Text = "Log Out";
            this.logOut.UseVisualStyleBackColor = true;
            this.logOut.Click += new System.EventHandler(this.logOut_Click_1);
            // 
            // topLabel
            // 
            this.topLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.topLabel.Location = new System.Drawing.Point(6, 4);
            this.topLabel.Name = "topLabel";
            this.topLabel.Size = new System.Drawing.Size(323, 37);
            this.topLabel.TabIndex = 3;
            this.topLabel.Text = "label1";
            // 
            // facultyListUserControl1
            // 
            this.facultyListUserControl1.Location = new System.Drawing.Point(288, 44);
            this.facultyListUserControl1.Name = "facultyListUserControl1";
            this.facultyListUserControl1.Size = new System.Drawing.Size(1012, 668);
            this.facultyListUserControl1.TabIndex = 14;
            this.facultyListUserControl1.Visible = false;
            // 
            // studentListUserControl1
            // 
            this.studentListUserControl1.Location = new System.Drawing.Point(285, 44);
            this.studentListUserControl1.Name = "studentListUserControl1";
            this.studentListUserControl1.Size = new System.Drawing.Size(1012, 668);
            this.studentListUserControl1.TabIndex = 13;
            this.studentListUserControl1.Visible = false;
            // 
            // courseListUserControl1
            // 
            this.courseListUserControl1.Location = new System.Drawing.Point(285, 44);
            this.courseListUserControl1.Name = "courseListUserControl1";
            this.courseListUserControl1.Size = new System.Drawing.Size(1012, 668);
            this.courseListUserControl1.TabIndex = 12;
            this.courseListUserControl1.Visible = false;
            // 
            // createCourseUserControl1
            // 
            this.createCourseUserControl1.Location = new System.Drawing.Point(288, 49);
            this.createCourseUserControl1.Name = "createCourseUserControl1";
            this.createCourseUserControl1.Size = new System.Drawing.Size(1012, 668);
            this.createCourseUserControl1.TabIndex = 11;
            // 
            // assignFacultyUserControl1
            // 
            this.assignFacultyUserControl1.Location = new System.Drawing.Point(285, 44);
            this.assignFacultyUserControl1.Name = "assignFacultyUserControl1";
            this.assignFacultyUserControl1.Size = new System.Drawing.Size(1012, 668);
            this.assignFacultyUserControl1.TabIndex = 15;
            this.assignFacultyUserControl1.Visible = false;
            // 
            // setExamTimeUserControl1
            // 
            this.setExamTimeUserControl1.Location = new System.Drawing.Point(285, 44);
            this.setExamTimeUserControl1.Name = "setExamTimeUserControl1";
            this.setExamTimeUserControl1.Size = new System.Drawing.Size(1012, 668);
            this.setExamTimeUserControl1.TabIndex = 16;
            this.setExamTimeUserControl1.Visible = false;
            // 
            // adminUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 720);
            this.Controls.Add(this.setExamTimeUserControl1);
            this.Controls.Add(this.assignFacultyUserControl1);
            this.Controls.Add(this.facultyListUserControl1);
            this.Controls.Add(this.studentListUserControl1);
            this.Controls.Add(this.courseListUserControl1);
            this.Controls.Add(this.createCourseUserControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "adminUi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "adminUi";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button examTimeBtn;
        private System.Windows.Forms.Button assignFacultyBtn;
        private System.Windows.Forms.Button createCourseButton;
        private System.Windows.Forms.Button courseListBtn;
        private System.Windows.Forms.Button facultyListBtn;
        private System.Windows.Forms.Button studentListBtn;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Button logOut;
        private System.Windows.Forms.Label topLabel;
        private AdminUserControls.createCourseUserControl createCourseUserControl1;
        private AdminUserControls.courseListUserControl courseListUserControl1;
        private AdminUserControls.StudentUserControl studentListUserControl1;
        private AdminUserControls.facultyListUserControl facultyListUserControl1;
        private AdminUserControls.assignFacultyUserControl assignFacultyUserControl1;
        private AdminUserControls.setExamTimeUserControl setExamTimeUserControl1;
    }
}