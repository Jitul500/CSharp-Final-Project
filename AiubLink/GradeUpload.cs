using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AiubLink
{
    public partial class GradeUpload : Form
    {
        private Form previousForm;
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\CS Final Project\AiubLink\DataBase\AiubLink.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=false";
        private string FacultyID;
        public GradeUpload(Form previousForm, string facultyID)
        {
            InitializeComponent();
            this.previousForm = previousForm;
            FacultyID = facultyID;
        }

        private void LoadChannels()
        {
            string query = "SELECT ChannelName FROM Channels WHERE FacultyID = @FacultyID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Use the FacultyID passed when this form was created
                        command.Parameters.AddWithValue("@FacultyID", FacultyID);
                        SqlDataReader reader = command.ExecuteReader();

                        channelcomboBox.Items.Clear();
                        while (reader.Read())
                        {
                            channelcomboBox.Items.Add(reader["ChannelName"].ToString());
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading channels: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void channelcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadStudentsForChannel();
        }

        private void LoadStudentsForChannel()
        {
            string selectedChannel = channelcomboBox.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedChannel)) return;

            string query = @"
                SELECT CS.StudentID 
                FROM ChannelStudents CS
                INNER JOIN Channels C ON CS.ChannelID = C.ChannelID
                WHERE C.ChannelName = @ChannelName";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ChannelName", selectedChannel);
                        SqlDataReader reader = command.ExecuteReader();

                        studentcheckedListBox.Items.Clear();
                        while (reader.Read())
                        {
                            studentcheckedListBox.Items.Add(reader["StudentID"].ToString());
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading students: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            if (studentcheckedListBox.CheckedItems.Count != 1)
            {
                MessageBox.Show("Please select a single student.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string selectedStudentID = studentcheckedListBox.CheckedItems[0].ToString();
            string selectedChannel = channelcomboBox.SelectedItem?.ToString();
            string cgpaValue = cgpatextBox.Text.Trim();

            if (string.IsNullOrEmpty(cgpaValue) || !decimal.TryParse(cgpaValue, out decimal cgpa))
            {
                MessageBox.Show("Please enter a valid CGPA.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            UpdateStudentCGPA(selectedStudentID, selectedChannel, cgpa);
        }

        private void UpdateStudentCGPA(string studentID, string channelName, decimal cgpa)
        {
            string query = @"
                UPDATE R
                SET R.CGPA = @CGPA
                FROM Registrations R
                INNER JOIN Channels C ON C.ChannelName = @ChannelName
                INNER JOIN Courses CO ON CO.CourseName = C.ChannelName
                WHERE R.SerialNo = @StudentID AND R.CourseID = CO.CourseID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CGPA", cgpa);
                        command.Parameters.AddWithValue("@StudentID", studentID);
                        command.Parameters.AddWithValue("@ChannelName", channelName);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("CGPA updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadUpdatedCGPAList(studentID);
                        }
                        else
                        {
                            MessageBox.Show("CGPA update failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating CGPA: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadUpdatedCGPAList(string studentID)
        {
            string query = "SELECT CGPA FROM Registrations WHERE SerialNo = @StudentID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@StudentID", studentID);
                        SqlDataReader reader = command.ExecuteReader();

                        updatedcgpalistBox.Items.Clear();
                        while (reader.Read())
                        {
                            updatedcgpalistBox.Items.Add(reader["CGPA"].ToString());
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading updated CGPA: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            previousForm.Show();
            this.Close();
        }

        private void GradeUpload_Load(object sender, EventArgs e)
        {
            LoadChannels();
        }
    }
}
