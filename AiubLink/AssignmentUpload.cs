using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace AiubLink
{
    public partial class AssignmentUpload : Form
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\CS Final Project\AiubLink\DataBase\AiubLink.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=false";
        private Form previousForm;
        private string userID;
        private string channelID;

        public AssignmentUpload(Form previousForm, string userID, string channelID)
        {
            InitializeComponent();
            this.previousForm = previousForm;
            this.userID = userID;
            this.channelID = channelID;
        }

        private void AssignmentUpload_Load(object sender, EventArgs e)
        {
            LoadAssignments();
            LoadSubmittedAssignments();
        }

        private void LoadAssignments()
        {
            string query = @"
                SELECT A.AssignmentID, A.Description 
                FROM Assignments A
                WHERE A.IsActive = 1 
                AND A.ChannelID = @ChannelID
                AND A.AssignmentID NOT IN (SELECT AssignmentID FROM Submissions WHERE UserID = @UserID)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", userID);
                        command.Parameters.AddWithValue("@ChannelID", channelID);
                        assignmentComboBox.Items.Clear();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                assignmentComboBox.Items.Add(reader["AssignmentID"].ToString());
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading assignments: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void assignmentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedAssignmentID = assignmentComboBox.SelectedItem.ToString();
            LoadAssignmentDescription(selectedAssignmentID);
        }

        private void LoadAssignmentDescription(string assignmentID)
        {
            string query = "SELECT Description FROM Assignments WHERE AssignmentID = @AssignmentID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@AssignmentID", assignmentID);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                descriptionrichTextBox.Text = reader["Description"].ToString();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading assignment description: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void pastdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && pastdataGridView.Columns[e.ColumnIndex].Name == "Edit")
            {
                string submissionID = pastdataGridView.Rows[e.RowIndex].Cells["SubmissionID"].Value.ToString();

                OpenFileDialog openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string newFilePath = openFileDialog.FileName;
                    byte[] fileData = File.ReadAllBytes(newFilePath);

                    UpdateSubmission(submissionID, newFilePath, fileData);
                }
            }
        }

        private void UpdateSubmission(string submissionID, string newFilePath, byte[] fileData)
        {
            string query = @"
                UPDATE Submissions 
                SET FilePath = @FilePath, FileData = @FileData 
                WHERE SubmissionID = @SubmissionID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@SubmissionID", submissionID);
                        command.Parameters.AddWithValue("@FilePath", Path.GetFileName(newFilePath));
                        command.Parameters.AddWithValue("@FileData", fileData);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Assignment reuploaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadSubmittedAssignments(); // Refresh DataGridView
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating submission: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FilePathTextBox.Text = openFileDialog.FileName;
            }
        }

        private void UploadAssignmentButton_Click(object sender, EventArgs e)
        {
            if (assignmentComboBox.SelectedItem == null || string.IsNullOrEmpty(FilePathTextBox.Text))
            {
                MessageBox.Show("Please select an assignment and choose a file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string assignmentID = assignmentComboBox.SelectedItem.ToString();
            string filePath = FilePathTextBox.Text;

            if (!File.Exists(filePath))
            {
                MessageBox.Show("The selected file does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if the due time has expired
            if (IsDueTimeExpired(assignmentID))
            {
                MessageBox.Show("Assignment cannot be uploaded. Due time expired.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            byte[] fileData = File.ReadAllBytes(filePath);

            string query = @"
        INSERT INTO Submissions (AssignmentID, ChannelID, FilePath, FileData, UserID) 
        VALUES (@AssignmentID, @ChannelID, @FilePath, @FileData, @UserID)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@AssignmentID", assignmentID);
                        command.Parameters.AddWithValue("@ChannelID", channelID);
                        command.Parameters.AddWithValue("@FilePath", filePath);  // Store full file path here
                        command.Parameters.AddWithValue("@FileData", fileData);
                        command.Parameters.AddWithValue("@UserID", userID);

                        command.ExecuteNonQuery();

                        MessageBox.Show("Assignment uploaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Refresh ComboBox after successful upload
                        LoadAssignments();

                        // Refresh DataGridView to show the newly uploaded submission
                        LoadSubmittedAssignments();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error uploading assignment: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool IsDueTimeExpired(string assignmentID)
        {
            string query = "SELECT DueTime FROM Assignments WHERE AssignmentID = @AssignmentID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@AssignmentID", assignmentID);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                DateTime dueTime = reader.GetDateTime(0);
                                return DateTime.Now > dueTime;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error checking due time: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return false;
        }

        private void LoadSubmittedAssignments()
        {
            string query = @"
                SELECT SubmissionID, AssignmentID, FilePath 
                FROM Submissions 
                WHERE UserID = @UserID AND ChannelID = @ChannelID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", userID);
                        command.Parameters.AddWithValue("@ChannelID", channelID);

                        DataTable submissionData = new DataTable();
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(submissionData);

                        pastdataGridView.DataSource = submissionData;

                        if (!pastdataGridView.Columns.Contains("Edit"))
                        {
                            DataGridViewButtonColumn editButton = new DataGridViewButtonColumn
                            {
                                HeaderText = "Edit",
                                Text = "Reupload",
                                UseColumnTextForButtonValue = true,
                                Name = "Edit"
                            };
                            pastdataGridView.Columns.Add(editButton);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading submissions: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            previousForm.Show();
            this.Close();
        }
    }
}