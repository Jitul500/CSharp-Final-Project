namespace AiubLink
{
    partial class AddChannelDashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddChannelDashBoard));
            this.ChannelnametextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Studentlabel2 = new System.Windows.Forms.Label();
            this.FacultycomboBox = new System.Windows.Forms.ComboBox();
            this.createbutton = new System.Windows.Forms.Button();
            this.ChanneldataGridView = new System.Windows.Forms.DataGridView();
            this.StudentPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.exitbutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.channelpanel = new System.Windows.Forms.Panel();
            this.refreshbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.coursecomboBox = new System.Windows.Forms.ComboBox();
            this.StudentCheckedListBox = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.ChanneldataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.channelpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChannelnametextBox
            // 
            this.ChannelnametextBox.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ChannelnametextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ChannelnametextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChannelnametextBox.Location = new System.Drawing.Point(193, 42);
            this.ChannelnametextBox.Name = "ChannelnametextBox";
            this.ChannelnametextBox.Size = new System.Drawing.Size(416, 27);
            this.ChannelnametextBox.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "FACULTY :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Studentlabel2
            // 
            this.Studentlabel2.AutoSize = true;
            this.Studentlabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Studentlabel2.Location = new System.Drawing.Point(788, 19);
            this.Studentlabel2.Name = "Studentlabel2";
            this.Studentlabel2.Size = new System.Drawing.Size(107, 20);
            this.Studentlabel2.TabIndex = 14;
            this.Studentlabel2.Text = "STUDENTS";
            // 
            // FacultycomboBox
            // 
            this.FacultycomboBox.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.FacultycomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FacultycomboBox.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FacultycomboBox.FormattingEnabled = true;
            this.FacultycomboBox.Location = new System.Drawing.Point(193, 189);
            this.FacultycomboBox.Name = "FacultycomboBox";
            this.FacultycomboBox.Size = new System.Drawing.Size(240, 32);
            this.FacultycomboBox.TabIndex = 13;
            // 
            // createbutton
            // 
            this.createbutton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.createbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createbutton.Location = new System.Drawing.Point(1074, 42);
            this.createbutton.Name = "createbutton";
            this.createbutton.Size = new System.Drawing.Size(174, 58);
            this.createbutton.TabIndex = 11;
            this.createbutton.Text = "Create";
            this.createbutton.UseVisualStyleBackColor = false;
            this.createbutton.Click += new System.EventHandler(this.createbutton_Click_1);
            // 
            // ChanneldataGridView
            // 
            this.ChanneldataGridView.AllowUserToAddRows = false;
            this.ChanneldataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ChanneldataGridView.BackgroundColor = System.Drawing.Color.Orange;
            this.ChanneldataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ChanneldataGridView.Location = new System.Drawing.Point(3, 306);
            this.ChanneldataGridView.Name = "ChanneldataGridView";
            this.ChanneldataGridView.ReadOnly = true;
            this.ChanneldataGridView.RowHeadersWidth = 51;
            this.ChanneldataGridView.RowTemplate.Height = 24;
            this.ChanneldataGridView.Size = new System.Drawing.Size(1275, 310);
            this.ChanneldataGridView.TabIndex = 10;
            this.ChanneldataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ChanneldataGridView_CellClick);
            // 
            // StudentPanel
            // 
            this.StudentPanel.Location = new System.Drawing.Point(248, 106);
            this.StudentPanel.Name = "StudentPanel";
            this.StudentPanel.Size = new System.Drawing.Size(1030, 613);
            this.StudentPanel.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SkyBlue;
            this.panel2.Controls.Add(this.StudentPanel);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.exitbutton);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1282, 105);
            this.panel2.TabIndex = 21;
            // 
            // exitbutton
            // 
            this.exitbutton.BackColor = System.Drawing.Color.SkyBlue;
            this.exitbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitbutton.BackgroundImage")));
            this.exitbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitbutton.FlatAppearance.BorderSize = 0;
            this.exitbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitbutton.ForeColor = System.Drawing.Color.Transparent;
            this.exitbutton.Location = new System.Drawing.Point(1224, 24);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(44, 41);
            this.exitbutton.TabIndex = 4;
            this.exitbutton.UseVisualStyleBackColor = false;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "CHANNEL NAME :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // channelpanel
            // 
            this.channelpanel.BackColor = System.Drawing.Color.Green;
            this.channelpanel.Controls.Add(this.refreshbutton);
            this.channelpanel.Controls.Add(this.label1);
            this.channelpanel.Controls.Add(this.coursecomboBox);
            this.channelpanel.Controls.Add(this.StudentCheckedListBox);
            this.channelpanel.Controls.Add(this.ChannelnametextBox);
            this.channelpanel.Controls.Add(this.label3);
            this.channelpanel.Controls.Add(this.label2);
            this.channelpanel.Controls.Add(this.Studentlabel2);
            this.channelpanel.Controls.Add(this.FacultycomboBox);
            this.channelpanel.Controls.Add(this.createbutton);
            this.channelpanel.Controls.Add(this.ChanneldataGridView);
            this.channelpanel.Location = new System.Drawing.Point(0, 105);
            this.channelpanel.Name = "channelpanel";
            this.channelpanel.Size = new System.Drawing.Size(1278, 616);
            this.channelpanel.TabIndex = 22;
            // 
            // refreshbutton
            // 
            this.refreshbutton.BackColor = System.Drawing.Color.DodgerBlue;
            this.refreshbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshbutton.Location = new System.Drawing.Point(1074, 179);
            this.refreshbutton.Name = "refreshbutton";
            this.refreshbutton.Size = new System.Drawing.Size(174, 58);
            this.refreshbutton.TabIndex = 22;
            this.refreshbutton.Text = "Refresh";
            this.refreshbutton.UseVisualStyleBackColor = false;
            this.refreshbutton.Click += new System.EventHandler(this.refreshbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "COURSES :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // coursecomboBox
            // 
            this.coursecomboBox.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.coursecomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coursecomboBox.FormattingEnabled = true;
            this.coursecomboBox.Location = new System.Drawing.Point(193, 111);
            this.coursecomboBox.Name = "coursecomboBox";
            this.coursecomboBox.Size = new System.Drawing.Size(416, 28);
            this.coursecomboBox.TabIndex = 20;
            // 
            // StudentCheckedListBox
            // 
            this.StudentCheckedListBox.BackColor = System.Drawing.Color.Honeydew;
            this.StudentCheckedListBox.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentCheckedListBox.FormattingEnabled = true;
            this.StudentCheckedListBox.Location = new System.Drawing.Point(628, 42);
            this.StudentCheckedListBox.Name = "StudentCheckedListBox";
            this.StudentCheckedListBox.Size = new System.Drawing.Size(426, 204);
            this.StudentCheckedListBox.TabIndex = 18;
            // 
            // AddChannelDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.channelpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddChannelDashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddChannelDashBoard";
            this.Load += new System.EventHandler(this.AddChannelDashBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChanneldataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.channelpanel.ResumeLayout(false);
            this.channelpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox ChannelnametextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Studentlabel2;
        private System.Windows.Forms.ComboBox FacultycomboBox;
        private System.Windows.Forms.Button createbutton;
        private System.Windows.Forms.DataGridView ChanneldataGridView;
        private System.Windows.Forms.Panel StudentPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel channelpanel;
        private System.Windows.Forms.CheckedListBox StudentCheckedListBox;
        private System.Windows.Forms.ComboBox coursecomboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button refreshbutton;
    }
}