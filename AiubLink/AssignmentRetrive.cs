using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace AiubLink
{
    public partial class AssignmentRetrive : Form
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\CS Final Project\AiubLink\DataBase\AiubLink.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=false";
        private Form previousForm;
        private string selectedChannel;

        public AssignmentRetrive(Form previousForm, string selectedChannel)
        {
            InitializeComponent();
            this.previousForm = previousForm;
            this.selectedChannel = selectedChannel;
        }

        private void AssignmentRetrive_Load(object sender, EventArgs e)
        {
            SetupDataGridView();
            LoadAssignments(selectedChannel);
            LoadSubmissions(selectedChannel);
        }

        private void LoadAssignments(string channelName)
        {
            string query = @"SELECT AssignmentID, Description, DueTime FROM Assignments WHERE ChannelID = (SELECT ChannelID FROM Channels WHERE ChannelName = @ChannelName) AND IsActive = 1";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ChannelName", channelName);
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            AssignmentsDataGridView.DataSource = dataTable;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading assignments: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadSubmissions(string channelName)
        {
            string query = @"SELECT s.UserID, u.Name, s.AssignmentID, s.SubmittedAt, s.FilePath FROM Submissions s INNER JOIN AiubLink u ON s.UserID = u.UserID WHERE s.ChannelID = (SELECT ChannelID FROM Channels WHERE ChannelName = @ChannelName)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ChannelName", channelName);
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            SubmissionsDataGridView.DataSource = dataTable;

                            if (!SubmissionsDataGridView.Columns.Contains("Show"))
                            {
                                DataGridViewButtonColumn showButton = new DataGridViewButtonColumn
                                {
                                    HeaderText = "Show File",
                                    Name = "Show",
                                    Text = "Open",
                                    UseColumnTextForButtonValue = true
                                };
                                SubmissionsDataGridView.Columns.Add(showButton);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading submissions: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SubmissionsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == SubmissionsDataGridView.Columns["Show"].Index)
            {
                string filePath = SubmissionsDataGridView.Rows[e.RowIndex].Cells["FilePath"].Value?.ToString();

                if (!string.IsNullOrEmpty(filePath))
                {
                    if (File.Exists(filePath))
                    {
                        try
                        {
                            System.Diagnostics.Process.Start(filePath);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error opening file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("File does not exist at the specified path.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("No file path available.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void SetupDataGridView()
        {
            DataGridViewButtonColumn extendTimeButton = new DataGridViewButtonColumn
            {
                Name = "ExtendTime",
                HeaderText = "Extend Time",
                Text = "Extend Time",
                UseColumnTextForButtonValue = true
            };
            AssignmentsDataGridView.Columns.Add(extendTimeButton);
        }

        private void ExtendTimeButton_Click(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == AssignmentsDataGridView.Columns["ExtendTime"].Index)
            {
                int assignmentID = Convert.ToInt32(AssignmentsDataGridView.Rows[e.RowIndex].Cells["AssignmentID"].Value);

                object dueTimeValue = AssignmentsDataGridView.Rows[e.RowIndex].Cells["DueTime"].Value;
                DateTime currentDueTime;

                if (dueTimeValue == DBNull.Value)
                {
                    MessageBox.Show("No due time is set for this assignment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    currentDueTime = Convert.ToDateTime(dueTimeValue);
                }

                DateTimePickerForm dateTimeForm = new DateTimePickerForm(currentDueTime);
                dateTimeForm.DueTimeUpdated += (newDueTime) =>
                {
                    UpdateAssignmentDueTime(assignmentID, newDueTime);
                    LoadAssignments(selectedChannel);
                };
                dateTimeForm.ShowDialog();
            }
        }

        private void UpdateAssignmentDueTime(int assignmentID, DateTime newDueTime)
        {
            string query = "UPDATE Assignments SET DueTime = @NewDueTime WHERE AssignmentID = @AssignmentID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NewDueTime", newDueTime);
                        command.Parameters.AddWithValue("@AssignmentID", assignmentID);
                        command.ExecuteNonQuery();
                    }
                    MessageBox.Show("Due time extended successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAssignments(selectedChannel);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error extending time: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            previousForm.Show();
            this.Close();
        }

        private void CreateAssignmentButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(DescriptionTextBox.Text) || DueTimeDateTimePicker.Value == null)
            {
                MessageBox.Show("Please provide a description and set a due time for the assignment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string description = DescriptionTextBox.Text;
            DateTime dueTime = DueTimeDateTimePicker.Value;
            int channelID = GetChannelID(selectedChannel);

            if (channelID == -1)
            {
                MessageBox.Show("Selected channel is not valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = "INSERT INTO Assignments (ChannelID, Description, DueTime, IsActive) VALUES (@ChannelID, @Description, @DueTime, 1)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ChannelID", channelID);
                        command.Parameters.AddWithValue("@Description", description);
                        command.Parameters.AddWithValue("@DueTime", dueTime);
                        command.ExecuteNonQuery();
                    }
                    MessageBox.Show("Assignment created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAssignments(selectedChannel);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error creating assignment: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private int GetChannelID(string channelName)
        {
            string query = "SELECT ChannelID FROM Channels WHERE ChannelName = @ChannelName";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ChannelName", channelName);
                        object result = command.ExecuteScalar();
                        return result != null ? Convert.ToInt32(result) : -1;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error fetching ChannelID: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return -1;
                }
            }
        }

        private void ReferenceFileTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
