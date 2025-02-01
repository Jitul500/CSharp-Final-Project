namespace AiubLink
{
    partial class GradeUpload
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GradeUpload));
            this.exitbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.channelcomboBox = new System.Windows.Forms.ComboBox();
            this.studentcheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.cgpatextBox = new System.Windows.Forms.TextBox();
            this.updatedcgpalistBox = new System.Windows.Forms.ListBox();
            this.updatebutton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitbutton
            // 
            this.exitbutton.BackColor = System.Drawing.Color.ForestGreen;
            this.exitbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitbutton.BackgroundImage")));
            this.exitbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitbutton.FlatAppearance.BorderSize = 0;
            this.exitbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitbutton.Location = new System.Drawing.Point(905, 23);
            this.exitbutton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(33, 33);
            this.exitbutton.TabIndex = 15;
            this.exitbutton.UseVisualStyleBackColor = false;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Select Channel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(70, 195);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Select Student";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(102, 189);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Enter CGPA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(110, 189);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Updated CGPA";
            // 
            // channelcomboBox
            // 
            this.channelcomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.channelcomboBox.FormattingEnabled = true;
            this.channelcomboBox.Location = new System.Drawing.Point(51, 118);
            this.channelcomboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.channelcomboBox.Name = "channelcomboBox";
            this.channelcomboBox.Size = new System.Drawing.Size(161, 28);
            this.channelcomboBox.TabIndex = 20;
            this.channelcomboBox.SelectedIndexChanged += new System.EventHandler(this.channelcomboBox_SelectedIndexChanged);
            // 
            // studentcheckedListBox
            // 
            this.studentcheckedListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentcheckedListBox.FormattingEnabled = true;
            this.studentcheckedListBox.Location = new System.Drawing.Point(51, 260);
            this.studentcheckedListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.studentcheckedListBox.Name = "studentcheckedListBox";
            this.studentcheckedListBox.Size = new System.Drawing.Size(161, 172);
            this.studentcheckedListBox.TabIndex = 21;
            // 
            // cgpatextBox
            // 
            this.cgpatextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cgpatextBox.Location = new System.Drawing.Point(78, 254);
            this.cgpatextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cgpatextBox.Name = "cgpatextBox";
            this.cgpatextBox.Size = new System.Drawing.Size(164, 26);
            this.cgpatextBox.TabIndex = 22;
            // 
            // updatedcgpalistBox
            // 
            this.updatedcgpalistBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatedcgpalistBox.FormattingEnabled = true;
            this.updatedcgpalistBox.ItemHeight = 15;
            this.updatedcgpalistBox.Location = new System.Drawing.Point(102, 254);
            this.updatedcgpalistBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.updatedcgpalistBox.Name = "updatedcgpalistBox";
            this.updatedcgpalistBox.Size = new System.Drawing.Size(140, 154);
            this.updatedcgpalistBox.TabIndex = 23;
            // 
            // updatebutton
            // 
            this.updatebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebutton.Location = new System.Drawing.Point(117, 308);
            this.updatebutton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Size = new System.Drawing.Size(92, 34);
            this.updatebutton.TabIndex = 24;
            this.updatebutton.Text = "Update";
            this.updatebutton.UseVisualStyleBackColor = true;
            this.updatebutton.Click += new System.EventHandler(this.updatebutton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.exitbutton);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(958, 82);
            this.panel1.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(28, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(229, 37);
            this.label5.TabIndex = 16;
            this.label5.Text = "Grade Upload";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.channelcomboBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.studentcheckedListBox);
            this.panel2.Location = new System.Drawing.Point(1, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(305, 501);
            this.panel2.TabIndex = 26;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.cgpatextBox);
            this.panel3.Controls.Add(this.updatebutton);
            this.panel3.Location = new System.Drawing.Point(305, 83);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 501);
            this.panel3.TabIndex = 27;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.Controls.Add(this.updatedcgpalistBox);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(603, 83);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(356, 501);
            this.panel4.TabIndex = 28;
            // 
            // GradeUpload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 585);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "GradeUpload";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GradeUpload";
            this.Load += new System.EventHandler(this.GradeUpload_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox channelcomboBox;
        private System.Windows.Forms.CheckedListBox studentcheckedListBox;
        private System.Windows.Forms.TextBox cgpatextBox;
        private System.Windows.Forms.ListBox updatedcgpalistBox;
        private System.Windows.Forms.Button updatebutton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}