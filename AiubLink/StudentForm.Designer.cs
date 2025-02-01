namespace UniversityRegistrationSystem
{
    partial class StudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnViewCourses = new System.Windows.Forms.Button();
            this.btnRegisterCourse = new System.Windows.Forms.Button();
            this.uniregpanel1 = new System.Windows.Forms.Panel();
            this.exitbutton = new System.Windows.Forms.Button();
            this.coursecheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.coursedataGridView = new System.Windows.Forms.DataGridView();
            this.lblSemester = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.uniregpanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coursedataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gold;
            this.panel2.Controls.Add(this.txtStudentName);
            this.panel2.Controls.Add(this.txtStudentID);
            this.panel2.Location = new System.Drawing.Point(271, 110);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(949, 78);
            this.panel2.TabIndex = 7;
            // 
            // txtStudentName
            // 
            this.txtStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentName.Location = new System.Drawing.Point(492, 19);
            this.txtStudentName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(427, 38);
            this.txtStudentName.TabIndex = 1;
            // 
            // txtStudentID
            // 
            this.txtStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentID.Location = new System.Drawing.Point(27, 19);
            this.txtStudentID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(459, 38);
            this.txtStudentID.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Controls.Add(this.btnViewCourses);
            this.panel1.Controls.Add(this.btnRegisterCourse);
            this.panel1.Location = new System.Drawing.Point(-1, 81);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 640);
            this.panel1.TabIndex = 6;
            // 
            // btnViewCourses
            // 
            this.btnViewCourses.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnViewCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewCourses.Location = new System.Drawing.Point(13, 137);
            this.btnViewCourses.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnViewCourses.Name = "btnViewCourses";
            this.btnViewCourses.Size = new System.Drawing.Size(163, 70);
            this.btnViewCourses.TabIndex = 7;
            this.btnViewCourses.Text = "View Registered Courses";
            this.btnViewCourses.UseVisualStyleBackColor = false;
            this.btnViewCourses.Click += new System.EventHandler(this.btnViewCourses_Click);
            // 
            // btnRegisterCourse
            // 
            this.btnRegisterCourse.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnRegisterCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterCourse.Location = new System.Drawing.Point(13, 41);
            this.btnRegisterCourse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegisterCourse.Name = "btnRegisterCourse";
            this.btnRegisterCourse.Size = new System.Drawing.Size(163, 66);
            this.btnRegisterCourse.TabIndex = 5;
            this.btnRegisterCourse.Text = "Register Course";
            this.btnRegisterCourse.UseVisualStyleBackColor = false;
            this.btnRegisterCourse.Click += new System.EventHandler(this.btnRegisterCourse_Click);
            // 
            // uniregpanel1
            // 
            this.uniregpanel1.BackColor = System.Drawing.Color.Green;
            this.uniregpanel1.Controls.Add(this.exitbutton);
            this.uniregpanel1.Location = new System.Drawing.Point(-1, 0);
            this.uniregpanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uniregpanel1.Name = "uniregpanel1";
            this.uniregpanel1.Size = new System.Drawing.Size(1281, 82);
            this.uniregpanel1.TabIndex = 5;
            // 
            // exitbutton
            // 
            this.exitbutton.BackColor = System.Drawing.Color.Green;
            this.exitbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitbutton.BackgroundImage")));
            this.exitbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitbutton.FlatAppearance.BorderSize = 0;
            this.exitbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitbutton.Location = new System.Drawing.Point(1225, 12);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(44, 41);
            this.exitbutton.TabIndex = 9;
            this.exitbutton.UseVisualStyleBackColor = false;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // coursecheckedListBox
            // 
            this.coursecheckedListBox.BackColor = System.Drawing.Color.PaleTurquoise;
            this.coursecheckedListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.coursecheckedListBox.FormattingEnabled = true;
            this.coursecheckedListBox.Location = new System.Drawing.Point(231, 254);
            this.coursecheckedListBox.Name = "coursecheckedListBox";
            this.coursecheckedListBox.Size = new System.Drawing.Size(462, 454);
            this.coursecheckedListBox.TabIndex = 10;
            // 
            // coursedataGridView
            // 
            this.coursedataGridView.AllowUserToAddRows = false;
            this.coursedataGridView.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.coursedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.coursedataGridView.Location = new System.Drawing.Point(716, 254);
            this.coursedataGridView.Name = "coursedataGridView";
            this.coursedataGridView.ReadOnly = true;
            this.coursedataGridView.RowHeadersWidth = 51;
            this.coursedataGridView.RowTemplate.Height = 24;
            this.coursedataGridView.Size = new System.Drawing.Size(552, 454);
            this.coursedataGridView.TabIndex = 11;
            // 
            // lblSemester
            // 
            this.lblSemester.AutoSize = true;
            this.lblSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSemester.Location = new System.Drawing.Point(364, 218);
            this.lblSemester.Name = "lblSemester";
            this.lblSemester.Size = new System.Drawing.Size(64, 25);
            this.lblSemester.TabIndex = 12;
            this.lblSemester.Text = "label1";
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.lblSemester);
            this.Controls.Add(this.coursedataGridView);
            this.Controls.Add(this.coursecheckedListBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.uniregpanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "StudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentForm";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.uniregpanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.coursedataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnViewCourses;
        private System.Windows.Forms.Button btnRegisterCourse;
        private System.Windows.Forms.Panel uniregpanel1;
        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.CheckedListBox coursecheckedListBox;
        private System.Windows.Forms.DataGridView coursedataGridView;
        private System.Windows.Forms.Label lblSemester;
    }
}