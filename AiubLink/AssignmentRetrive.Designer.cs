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
            this.AssignmentsDataGridView = new System.Windows.Forms.DataGridView();
            this.exitbutton = new System.Windows.Forms.Button();
            this.DueTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.SubmissionsDataGridView.Location = new System.Drawing.Point(37, 287);
            this.SubmissionsDataGridView.Name = "SubmissionsDataGridView";
            this.SubmissionsDataGridView.ReadOnly = true;
            this.SubmissionsDataGridView.RowHeadersWidth = 51;
            this.SubmissionsDataGridView.RowTemplate.Height = 24;
            this.SubmissionsDataGridView.Size = new System.Drawing.Size(607, 350);
            this.SubmissionsDataGridView.TabIndex = 0;
            this.SubmissionsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SubmissionsDataGridView_CellClick);
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.BackColor = System.Drawing.Color.Cornsilk;
            this.DescriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionTextBox.Location = new System.Drawing.Point(311, 53);
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(704, 131);
            this.DescriptionTextBox.TabIndex = 5;
            this.DescriptionTextBox.Text = "";
            // 
            // CreateAssignmentButton
            // 
            this.CreateAssignmentButton.BackColor = System.Drawing.Color.Violet;
            this.CreateAssignmentButton.Location = new System.Drawing.Point(1043, 658);
            this.CreateAssignmentButton.Name = "CreateAssignmentButton";
            this.CreateAssignmentButton.Size = new System.Drawing.Size(197, 50);
            this.CreateAssignmentButton.TabIndex = 6;
            this.CreateAssignmentButton.Text = "CreateAssignment";
            this.CreateAssignmentButton.UseVisualStyleBackColor = false;
            this.CreateAssignmentButton.Click += new System.EventHandler(this.CreateAssignmentButton_Click);
            // 
            // AssignmentsDataGridView
            // 
            this.AssignmentsDataGridView.AllowUserToAddRows = false;
            this.AssignmentsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AssignmentsDataGridView.BackgroundColor = System.Drawing.Color.Beige;
            this.AssignmentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AssignmentsDataGridView.Location = new System.Drawing.Point(675, 287);
            this.AssignmentsDataGridView.Name = "AssignmentsDataGridView";
            this.AssignmentsDataGridView.ReadOnly = true;
            this.AssignmentsDataGridView.RowHeadersWidth = 51;
            this.AssignmentsDataGridView.RowTemplate.Height = 24;
            this.AssignmentsDataGridView.Size = new System.Drawing.Size(565, 350);
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
            this.DueTimeDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DueTimeDateTimePicker.Location = new System.Drawing.Point(440, 240);
            this.DueTimeDateTimePicker.Name = "DueTimeDateTimePicker";
            this.DueTimeDateTimePicker.Size = new System.Drawing.Size(427, 30);
            this.DueTimeDateTimePicker.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(595, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "DESCRIPTION";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(606, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "DUE TIME";
            // 
            // AssignmentRetrive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DueTimeDateTimePicker);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.AssignmentsDataGridView);
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
        private System.Windows.Forms.DataGridView AssignmentsDataGridView;
        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.DateTimePicker DueTimeDateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}