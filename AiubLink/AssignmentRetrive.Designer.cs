namespace AiubLink
{
    partial class AssignmentRetrive
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssignmentRetrive));
            this.SubmissionsDataGridView = new System.Windows.Forms.DataGridView();
            this.DescriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.CreateAssignmentButton = new System.Windows.Forms.Button();
            this.ReferenceFileTextBox = new System.Windows.Forms.TextBox();
            this.ChannelComboBox = new System.Windows.Forms.ComboBox();
            this.AssignmentsDataGridView = new System.Windows.Forms.DataGridView();
            this.exitbutton = new System.Windows.Forms.Button();
            this.DueTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.SubmissionsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AssignmentsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SubmissionsDataGridView
            // 
            this.SubmissionsDataGridView.AllowUserToAddRows = false;
            this.SubmissionsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SubmissionsDataGridView.BackgroundColor = System.Drawing.Color.Beige;
            this.SubmissionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SubmissionsDataGridView.Location = new System.Drawing.Point(1, 188);
            this.SubmissionsDataGridView.Name = "SubmissionsDataGridView";
            this.SubmissionsDataGridView.ReadOnly = true;
            this.SubmissionsDataGridView.RowHeadersWidth = 51;
            this.SubmissionsDataGridView.RowTemplate.Height = 24;
            this.SubmissionsDataGridView.Size = new System.Drawing.Size(622, 532);
            this.SubmissionsDataGridView.TabIndex = 0;
            this.SubmissionsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SubmissionsDataGridView_CellClick);
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.BackColor = System.Drawing.Color.Cornsilk;
            this.DescriptionTextBox.Location = new System.Drawing.Point(194, 10);
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(289, 130);
            this.DescriptionTextBox.TabIndex = 5;
            this.DescriptionTextBox.Text = "";
            // 
            // CreateAssignmentButton
            // 
            this.CreateAssignmentButton.BackColor = System.Drawing.Color.Violet;
            this.CreateAssignmentButton.Location = new System.Drawing.Point(862, 61);
            this.CreateAssignmentButton.Name = "CreateAssignmentButton";
            this.CreateAssignmentButton.Size = new System.Drawing.Size(197, 50);
            this.CreateAssignmentButton.TabIndex = 6;
            this.CreateAssignmentButton.Text = "CreateAssignment";
            this.CreateAssignmentButton.UseVisualStyleBackColor = false;
            this.CreateAssignmentButton.Click += new System.EventHandler(this.CreateAssignmentButton_Click);
            // 
            // ReferenceFileTextBox
            // 
            this.ReferenceFileTextBox.BackColor = System.Drawing.Color.Khaki;
            this.ReferenceFileTextBox.Location = new System.Drawing.Point(194, 146);
            this.ReferenceFileTextBox.Name = "ReferenceFileTextBox";
            this.ReferenceFileTextBox.Size = new System.Drawing.Size(289, 22);
            this.ReferenceFileTextBox.TabIndex = 10;
            // 
            // ChannelComboBox
            // 
            this.ChannelComboBox.BackColor = System.Drawing.Color.Khaki;
            this.ChannelComboBox.FormattingEnabled = true;
            this.ChannelComboBox.Location = new System.Drawing.Point(548, 51);
            this.ChannelComboBox.Name = "ChannelComboBox";
            this.ChannelComboBox.Size = new System.Drawing.Size(232, 24);
            this.ChannelComboBox.TabIndex = 11;
            this.ChannelComboBox.SelectedIndexChanged += new System.EventHandler(this.ChannelComboBox_SelectedIndexChanged);
            // 
            // AssignmentsDataGridView
            // 
            this.AssignmentsDataGridView.AllowUserToAddRows = false;
            this.AssignmentsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AssignmentsDataGridView.BackgroundColor = System.Drawing.Color.Beige;
            this.AssignmentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AssignmentsDataGridView.Location = new System.Drawing.Point(649, 188);
            this.AssignmentsDataGridView.Name = "AssignmentsDataGridView";
            this.AssignmentsDataGridView.ReadOnly = true;
            this.AssignmentsDataGridView.RowHeadersWidth = 51;
            this.AssignmentsDataGridView.RowTemplate.Height = 24;
            this.AssignmentsDataGridView.Size = new System.Drawing.Size(627, 532);
            this.AssignmentsDataGridView.TabIndex = 12;
            this.AssignmentsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ExtendTimeButton_Click);
            // 
            // exitbutton
            // 
            this.exitbutton.BackColor = System.Drawing.Color.DarkTurquoise;
            this.exitbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitbutton.BackgroundImage")));
            this.exitbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitbutton.FlatAppearance.BorderSize = 0;
            this.exitbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitbutton.Location = new System.Drawing.Point(1224, 15);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(44, 41);
            this.exitbutton.TabIndex = 13;
            this.exitbutton.UseVisualStyleBackColor = false;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // DueTimeDateTimePicker
            // 
            this.DueTimeDateTimePicker.Location = new System.Drawing.Point(548, 103);
            this.DueTimeDateTimePicker.Name = "DueTimeDateTimePicker";
            this.DueTimeDateTimePicker.Size = new System.Drawing.Size(272, 22);
            this.DueTimeDateTimePicker.TabIndex = 14;
            // 
            // AssignmentRetrive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.DueTimeDateTimePicker);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.AssignmentsDataGridView);
            this.Controls.Add(this.ChannelComboBox);
            this.Controls.Add(this.ReferenceFileTextBox);
            this.Controls.Add(this.CreateAssignmentButton);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.SubmissionsDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AssignmentRetrive";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AssignmentRetrive";
            this.Load += new System.EventHandler(this.AssignmentRetrive_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SubmissionsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AssignmentsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView SubmissionsDataGridView;
        private System.Windows.Forms.RichTextBox DescriptionTextBox;
        private System.Windows.Forms.Button CreateAssignmentButton;
        private System.Windows.Forms.TextBox ReferenceFileTextBox;
        private System.Windows.Forms.ComboBox ChannelComboBox;
        private System.Windows.Forms.DataGridView AssignmentsDataGridView;
        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.DateTimePicker DueTimeDateTimePicker;
    }
}