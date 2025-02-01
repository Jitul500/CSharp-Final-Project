namespace AiubLink
{
    partial class AssignmentUpload
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssignmentUpload));
            this.BrowseButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.exitbutton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.descriptionrichTextBox = new System.Windows.Forms.RichTextBox();
            this.FilePathTextBox = new System.Windows.Forms.TextBox();
            this.assignmentComboBox = new System.Windows.Forms.ComboBox();
            this.UploadAssignmentButton = new System.Windows.Forms.Button();
            this.pastdataGridView = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pastdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // BrowseButton
            // 
            this.BrowseButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.BrowseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrowseButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BrowseButton.Location = new System.Drawing.Point(35, 163);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(116, 46);
            this.BrowseButton.TabIndex = 0;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.UseVisualStyleBackColor = false;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Location = new System.Drawing.Point(-2, -6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(79, 729);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.ForestGreen;
            this.panel2.Controls.Add(this.exitbutton);
            this.panel2.Location = new System.Drawing.Point(76, -3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1204, 74);
            this.panel2.TabIndex = 4;
            // 
            // exitbutton
            // 
            this.exitbutton.BackColor = System.Drawing.Color.ForestGreen;
            this.exitbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitbutton.BackgroundImage")));
            this.exitbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitbutton.FlatAppearance.BorderSize = 0;
            this.exitbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitbutton.Location = new System.Drawing.Point(1148, 15);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(44, 41);
            this.exitbutton.TabIndex = 14;
            this.exitbutton.UseVisualStyleBackColor = false;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.descriptionrichTextBox);
            this.panel3.Controls.Add(this.FilePathTextBox);
            this.panel3.Controls.Add(this.assignmentComboBox);
            this.panel3.Controls.Add(this.UploadAssignmentButton);
            this.panel3.Controls.Add(this.BrowseButton);
            this.panel3.Location = new System.Drawing.Point(76, 70);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1204, 345);
            this.panel3.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(626, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "DESCRIPTION";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(30, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "ASSIGNMENT ID";
            // 
            // descriptionrichTextBox
            // 
            this.descriptionrichTextBox.BackColor = System.Drawing.Color.FloralWhite;
            this.descriptionrichTextBox.Location = new System.Drawing.Point(631, 61);
            this.descriptionrichTextBox.Name = "descriptionrichTextBox";
            this.descriptionrichTextBox.Size = new System.Drawing.Size(561, 264);
            this.descriptionrichTextBox.TabIndex = 5;
            this.descriptionrichTextBox.Text = "";
            // 
            // FilePathTextBox
            // 
            this.FilePathTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilePathTextBox.Location = new System.Drawing.Point(35, 224);
            this.FilePathTextBox.Name = "FilePathTextBox";
            this.FilePathTextBox.Size = new System.Drawing.Size(347, 30);
            this.FilePathTextBox.TabIndex = 4;
            // 
            // assignmentComboBox
            // 
            this.assignmentComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignmentComboBox.FormattingEnabled = true;
            this.assignmentComboBox.Location = new System.Drawing.Point(35, 61);
            this.assignmentComboBox.Name = "assignmentComboBox";
            this.assignmentComboBox.Size = new System.Drawing.Size(347, 33);
            this.assignmentComboBox.TabIndex = 3;
            this.assignmentComboBox.SelectedIndexChanged += new System.EventHandler(this.assignmentComboBox_SelectedIndexChanged);
            // 
            // UploadAssignmentButton
            // 
            this.UploadAssignmentButton.BackColor = System.Drawing.Color.Orange;
            this.UploadAssignmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UploadAssignmentButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UploadAssignmentButton.Location = new System.Drawing.Point(35, 279);
            this.UploadAssignmentButton.Name = "UploadAssignmentButton";
            this.UploadAssignmentButton.Size = new System.Drawing.Size(153, 46);
            this.UploadAssignmentButton.TabIndex = 2;
            this.UploadAssignmentButton.Text = "UploadAssignment";
            this.UploadAssignmentButton.UseVisualStyleBackColor = false;
            this.UploadAssignmentButton.Click += new System.EventHandler(this.UploadAssignmentButton_Click);
            // 
            // pastdataGridView
            // 
            this.pastdataGridView.AllowUserToAddRows = false;
            this.pastdataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.pastdataGridView.BackgroundColor = System.Drawing.SystemColors.Info;
            this.pastdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pastdataGridView.Location = new System.Drawing.Point(76, 411);
            this.pastdataGridView.Name = "pastdataGridView";
            this.pastdataGridView.ReadOnly = true;
            this.pastdataGridView.RowHeadersWidth = 51;
            this.pastdataGridView.RowTemplate.Height = 24;
            this.pastdataGridView.Size = new System.Drawing.Size(1204, 309);
            this.pastdataGridView.TabIndex = 8;
            this.pastdataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pastdataGridView_CellContentClick);
            // 
            // AssignmentUpload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pastdataGridView);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AssignmentUpload";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AssignmentUpload";
            this.Load += new System.EventHandler(this.AssignmentUpload_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pastdataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button UploadAssignmentButton;
        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.ComboBox assignmentComboBox;
        private System.Windows.Forms.TextBox FilePathTextBox;
        private System.Windows.Forms.RichTextBox descriptionrichTextBox;
        private System.Windows.Forms.DataGridView pastdataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}