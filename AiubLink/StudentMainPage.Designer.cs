namespace AiubLink
{
    partial class StudentMainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentMainPage));
            this.label1 = new System.Windows.Forms.Label();
            this.exitbutton = new System.Windows.Forms.Button();
            this.calenderbutton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Backbutton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.INFObutton = new System.Windows.Forms.Button();
            this.Channelbutton = new System.Windows.Forms.Button();
            this.Regbutton = new System.Windows.Forms.Button();
            this.infopanel = new System.Windows.Forms.Panel();
            this.profilepictureBox = new System.Windows.Forms.PictureBox();
            this.doblabel = new System.Windows.Forms.Label();
            this.emaillabel = new System.Windows.Forms.Label();
            this.studentidlabel = new System.Windows.Forms.Label();
            this.phonelabel = new System.Windows.Forms.Label();
            this.namelabel = new System.Windows.Forms.Label();
            this.dblabel = new System.Windows.Forms.Label();
            this.pilabel = new System.Windows.Forms.Label();
            this.elabel = new System.Windows.Forms.Label();
            this.sidlabel = new System.Windows.Forms.Label();
            this.plabel = new System.Windows.Forms.Label();
            this.nlabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.infopanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilepictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(440, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(426, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Dashboard";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // exitbutton
            // 
            this.exitbutton.BackColor = System.Drawing.SystemColors.Highlight;
            this.exitbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitbutton.BackgroundImage")));
            this.exitbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitbutton.FlatAppearance.BorderSize = 0;
            this.exitbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitbutton.Location = new System.Drawing.Point(1233, 28);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(44, 41);
            this.exitbutton.TabIndex = 4;
            this.exitbutton.UseVisualStyleBackColor = false;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // calenderbutton
            // 
            this.calenderbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calenderbutton.Location = new System.Drawing.Point(45, 296);
            this.calenderbutton.Name = "calenderbutton";
            this.calenderbutton.Size = new System.Drawing.Size(134, 50);
            this.calenderbutton.TabIndex = 5;
            this.calenderbutton.Text = "Calender";
            this.calenderbutton.UseVisualStyleBackColor = true;
            this.calenderbutton.Click += new System.EventHandler(this.calenderbutton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.Backbutton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.exitbutton);
            this.panel1.Location = new System.Drawing.Point(-9, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1304, 97);
            this.panel1.TabIndex = 6;
            // 
            // Backbutton
            // 
            this.Backbutton.BackColor = System.Drawing.SystemColors.Highlight;
            this.Backbutton.FlatAppearance.BorderSize = 0;
            this.Backbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Backbutton.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Backbutton.Location = new System.Drawing.Point(21, 28);
            this.Backbutton.Name = "Backbutton";
            this.Backbutton.Size = new System.Drawing.Size(110, 37);
            this.Backbutton.TabIndex = 6;
            this.Backbutton.Text = "← Back";
            this.Backbutton.UseVisualStyleBackColor = false;
            this.Backbutton.Click += new System.EventHandler(this.Backbutton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Orange;
            this.panel2.Controls.Add(this.INFObutton);
            this.panel2.Controls.Add(this.Channelbutton);
            this.panel2.Controls.Add(this.Regbutton);
            this.panel2.Controls.Add(this.calenderbutton);
            this.panel2.Location = new System.Drawing.Point(-24, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(215, 660);
            this.panel2.TabIndex = 7;
            // 
            // INFObutton
            // 
            this.INFObutton.Location = new System.Drawing.Point(45, 62);
            this.INFObutton.Name = "INFObutton";
            this.INFObutton.Size = new System.Drawing.Size(134, 53);
            this.INFObutton.TabIndex = 10;
            this.INFObutton.Text = "Info";
            this.INFObutton.UseVisualStyleBackColor = true;
            this.INFObutton.Click += new System.EventHandler(this.INFObutton_Click);
            // 
            // Channelbutton
            // 
            this.Channelbutton.Location = new System.Drawing.Point(45, 144);
            this.Channelbutton.Name = "Channelbutton";
            this.Channelbutton.Size = new System.Drawing.Size(134, 53);
            this.Channelbutton.TabIndex = 9;
            this.Channelbutton.Text = "Channels";
            this.Channelbutton.UseVisualStyleBackColor = true;
            this.Channelbutton.Click += new System.EventHandler(this.Channelbutton_Click);
            // 
            // Regbutton
            // 
            this.Regbutton.Location = new System.Drawing.Point(45, 217);
            this.Regbutton.Name = "Regbutton";
            this.Regbutton.Size = new System.Drawing.Size(134, 53);
            this.Regbutton.TabIndex = 8;
            this.Regbutton.Text = "Registration";
            this.Regbutton.UseVisualStyleBackColor = true;
            this.Regbutton.Click += new System.EventHandler(this.Regbutton_Click);
            // 
            // infopanel
            // 
            this.infopanel.Controls.Add(this.profilepictureBox);
            this.infopanel.Controls.Add(this.doblabel);
            this.infopanel.Controls.Add(this.emaillabel);
            this.infopanel.Controls.Add(this.studentidlabel);
            this.infopanel.Controls.Add(this.phonelabel);
            this.infopanel.Controls.Add(this.namelabel);
            this.infopanel.Controls.Add(this.dblabel);
            this.infopanel.Controls.Add(this.pilabel);
            this.infopanel.Controls.Add(this.elabel);
            this.infopanel.Controls.Add(this.sidlabel);
            this.infopanel.Controls.Add(this.plabel);
            this.infopanel.Controls.Add(this.nlabel);
            this.infopanel.Location = new System.Drawing.Point(188, 71);
            this.infopanel.Name = "infopanel";
            this.infopanel.Size = new System.Drawing.Size(1092, 649);
            this.infopanel.TabIndex = 8;
            // 
            // profilepictureBox
            // 
            this.profilepictureBox.Location = new System.Drawing.Point(252, 97);
            this.profilepictureBox.Name = "profilepictureBox";
            this.profilepictureBox.Size = new System.Drawing.Size(148, 130);
            this.profilepictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilepictureBox.TabIndex = 11;
            this.profilepictureBox.TabStop = false;
            this.profilepictureBox.Click += new System.EventHandler(this.profilepictureBox_Click);
            // 
            // doblabel
            // 
            this.doblabel.AutoSize = true;
            this.doblabel.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold);
            this.doblabel.Location = new System.Drawing.Point(645, 402);
            this.doblabel.Name = "doblabel";
            this.doblabel.Size = new System.Drawing.Size(56, 27);
            this.doblabel.TabIndex = 10;
            this.doblabel.Text = "dob";
            // 
            // emaillabel
            // 
            this.emaillabel.AutoSize = true;
            this.emaillabel.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold);
            this.emaillabel.Location = new System.Drawing.Point(651, 261);
            this.emaillabel.Name = "emaillabel";
            this.emaillabel.Size = new System.Drawing.Size(78, 27);
            this.emaillabel.TabIndex = 9;
            this.emaillabel.Text = "email";
            // 
            // studentidlabel
            // 
            this.studentidlabel.AutoSize = true;
            this.studentidlabel.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold);
            this.studentidlabel.Location = new System.Drawing.Point(702, 179);
            this.studentidlabel.Name = "studentidlabel";
            this.studentidlabel.Size = new System.Drawing.Size(73, 27);
            this.studentidlabel.TabIndex = 8;
            this.studentidlabel.Text = "stdid";
            // 
            // phonelabel
            // 
            this.phonelabel.AutoSize = true;
            this.phonelabel.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold);
            this.phonelabel.Location = new System.Drawing.Point(702, 328);
            this.phonelabel.Name = "phonelabel";
            this.phonelabel.Size = new System.Drawing.Size(86, 27);
            this.phonelabel.TabIndex = 7;
            this.phonelabel.Text = "phone";
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelabel.Location = new System.Drawing.Point(666, 88);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(87, 27);
            this.namelabel.TabIndex = 6;
            this.namelabel.Text = "Name ";
            // 
            // dblabel
            // 
            this.dblabel.AutoSize = true;
            this.dblabel.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dblabel.Location = new System.Drawing.Point(548, 402);
            this.dblabel.Name = "dblabel";
            this.dblabel.Size = new System.Drawing.Size(78, 27);
            this.dblabel.TabIndex = 5;
            this.dblabel.Text = "DOB : ";
            // 
            // pilabel
            // 
            this.pilabel.AutoSize = true;
            this.pilabel.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pilabel.Location = new System.Drawing.Point(78, 144);
            this.pilabel.Name = "pilabel";
            this.pilabel.Size = new System.Drawing.Size(168, 27);
            this.pilabel.TabIndex = 4;
            this.pilabel.Text = "Profile Photo : ";
            // 
            // elabel
            // 
            this.elabel.AutoSize = true;
            this.elabel.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elabel.Location = new System.Drawing.Point(548, 261);
            this.elabel.Name = "elabel";
            this.elabel.Size = new System.Drawing.Size(91, 27);
            this.elabel.TabIndex = 3;
            this.elabel.Text = "Email : ";
            // 
            // sidlabel
            // 
            this.sidlabel.AutoSize = true;
            this.sidlabel.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sidlabel.Location = new System.Drawing.Point(548, 179);
            this.sidlabel.Name = "sidlabel";
            this.sidlabel.Size = new System.Drawing.Size(142, 27);
            this.sidlabel.TabIndex = 2;
            this.sidlabel.Text = "Student ID : ";
            // 
            // plabel
            // 
            this.plabel.AutoSize = true;
            this.plabel.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plabel.Location = new System.Drawing.Point(548, 330);
            this.plabel.Name = "plabel";
            this.plabel.Size = new System.Drawing.Size(139, 27);
            this.plabel.TabIndex = 1;
            this.plabel.Text = "Phone No : ";
            // 
            // nlabel
            // 
            this.nlabel.AutoSize = true;
            this.nlabel.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nlabel.Location = new System.Drawing.Point(548, 88);
            this.nlabel.Name = "nlabel";
            this.nlabel.Size = new System.Drawing.Size(99, 27);
            this.nlabel.TabIndex = 0;
            this.nlabel.Text = "Name : ";
            // 
            // StudentMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.infopanel);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StudentMainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentMainPage";
            this.Load += new System.EventHandler(this.StudentMainPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.infopanel.ResumeLayout(false);
            this.infopanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilepictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.Button calenderbutton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Regbutton;
        private System.Windows.Forms.Button Channelbutton;
        private System.Windows.Forms.Button INFObutton;
        private System.Windows.Forms.Panel infopanel;
        private System.Windows.Forms.Label pilabel;
        private System.Windows.Forms.Label elabel;
        private System.Windows.Forms.Label sidlabel;
        private System.Windows.Forms.Label plabel;
        private System.Windows.Forms.Label nlabel;
        private System.Windows.Forms.PictureBox profilepictureBox;
        private System.Windows.Forms.Label doblabel;
        private System.Windows.Forms.Label emaillabel;
        private System.Windows.Forms.Label studentidlabel;
        private System.Windows.Forms.Label phonelabel;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.Label dblabel;
        private System.Windows.Forms.Button Backbutton;
    }
}