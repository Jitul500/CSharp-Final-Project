namespace AiubLink
{
    partial class EditInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditInfo));
            this.deletebutton = new System.Windows.Forms.Button();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.uploadbutton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.updatebutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Studentlabel1 = new System.Windows.Forms.Label();
            this.Emaillabel1 = new System.Windows.Forms.Label();
            this.phonetextBox = new System.Windows.Forms.TextBox();
            this.IDlabel2 = new System.Windows.Forms.Label();
            this.nametextBox = new System.Windows.Forms.TextBox();
            this.Phonelabel3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // deletebutton
            // 
            this.deletebutton.BackColor = System.Drawing.Color.Crimson;
            this.deletebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebutton.ForeColor = System.Drawing.SystemColors.Control;
            this.deletebutton.Location = new System.Drawing.Point(577, 327);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(185, 45);
            this.deletebutton.TabIndex = 41;
            this.deletebutton.Text = "Delete";
            this.deletebutton.UseVisualStyleBackColor = false;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // statusComboBox
            // 
            this.statusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Items.AddRange(new object[] {
            "Pending",
            "Registered"});
            this.statusComboBox.Location = new System.Drawing.Point(165, 213);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(276, 28);
            this.statusComboBox.TabIndex = 40;
            // 
            // uploadbutton
            // 
            this.uploadbutton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.uploadbutton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadbutton.Location = new System.Drawing.Point(807, 119);
            this.uploadbutton.Name = "uploadbutton";
            this.uploadbutton.Size = new System.Drawing.Size(93, 38);
            this.uploadbutton.TabIndex = 39;
            this.uploadbutton.Text = "Upload";
            this.uploadbutton.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(648, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(709, 235);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(255, 22);
            this.dateTimePicker1.TabIndex = 37;
            // 
            // updatebutton
            // 
            this.updatebutton.BackColor = System.Drawing.Color.SpringGreen;
            this.updatebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebutton.Location = new System.Drawing.Point(215, 327);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Size = new System.Drawing.Size(185, 45);
            this.updatebutton.TabIndex = 36;
            this.updatebutton.Text = "Update";
            this.updatebutton.UseVisualStyleBackColor = false;
            this.updatebutton.Click += new System.EventHandler(this.updatebutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(495, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 25);
            this.label1.TabIndex = 35;
            this.label1.Text = "DATE OF BIRTH";
            // 
            // Studentlabel1
            // 
            this.Studentlabel1.AutoSize = true;
            this.Studentlabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Studentlabel1.Location = new System.Drawing.Point(51, 87);
            this.Studentlabel1.Name = "Studentlabel1";
            this.Studentlabel1.Size = new System.Drawing.Size(74, 25);
            this.Studentlabel1.TabIndex = 29;
            this.Studentlabel1.Text = "NAME";
            // 
            // Emaillabel1
            // 
            this.Emaillabel1.AutoSize = true;
            this.Emaillabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emaillabel1.Location = new System.Drawing.Point(547, 124);
            this.Emaillabel1.Name = "Emaillabel1";
            this.Emaillabel1.Size = new System.Drawing.Size(68, 25);
            this.Emaillabel1.TabIndex = 30;
            this.Emaillabel1.Text = "Photo";
            // 
            // phonetextBox
            // 
            this.phonetextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phonetextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phonetextBox.Location = new System.Drawing.Point(165, 139);
            this.phonetextBox.Name = "phonetextBox";
            this.phonetextBox.Size = new System.Drawing.Size(289, 30);
            this.phonetextBox.TabIndex = 34;
            // 
            // IDlabel2
            // 
            this.IDlabel2.AutoSize = true;
            this.IDlabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDlabel2.Location = new System.Drawing.Point(64, 213);
            this.IDlabel2.Name = "IDlabel2";
            this.IDlabel2.Size = new System.Drawing.Size(74, 25);
            this.IDlabel2.TabIndex = 31;
            this.IDlabel2.Text = "Status";
            // 
            // nametextBox
            // 
            this.nametextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nametextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nametextBox.Location = new System.Drawing.Point(165, 87);
            this.nametextBox.Name = "nametextBox";
            this.nametextBox.Size = new System.Drawing.Size(289, 30);
            this.nametextBox.TabIndex = 33;
            // 
            // Phonelabel3
            // 
            this.Phonelabel3.AutoSize = true;
            this.Phonelabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phonelabel3.Location = new System.Drawing.Point(51, 142);
            this.Phonelabel3.Name = "Phonelabel3";
            this.Phonelabel3.Size = new System.Drawing.Size(87, 25);
            this.Phonelabel3.TabIndex = 32;
            this.Phonelabel3.Text = "PHONE";
            // 
            // EditInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(999, 450);
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(this.uploadbutton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.updatebutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Studentlabel1);
            this.Controls.Add(this.Emaillabel1);
            this.Controls.Add(this.phonetextBox);
            this.Controls.Add(this.IDlabel2);
            this.Controls.Add(this.nametextBox);
            this.Controls.Add(this.Phonelabel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditInfo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.Button uploadbutton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button updatebutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Studentlabel1;
        private System.Windows.Forms.Label Emaillabel1;
        private System.Windows.Forms.TextBox phonetextBox;
        private System.Windows.Forms.Label IDlabel2;
        private System.Windows.Forms.TextBox nametextBox;
        private System.Windows.Forms.Label Phonelabel3;
    }
}