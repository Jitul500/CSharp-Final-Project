using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AiubLink
{
    public partial class AddChannelDashBoard : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\CS Final Project\AiubLink\DataBase\AiubLink.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=false";
        public AddChannelDashBoard()
        {
            InitializeComponent();
        }


        private void AddChannelDashBoard_Load(object sender, EventArgs e)
        {
            LoadStudentCheckedListBox();
            LoadFacultyComboBox();
            LoadChannelData();
            LoadCoursesComboBox();
            coursecomboBox.SelectedIndexChanged += coursecomboBox_SelectedIndexChanged;
        }

        private void LoadStudentCheckedListBox()
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\CS Final Project\AiubLink\DataBase\AiubLink.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=false";
            string query = "SELECT UserID FROM AiubLink WHERE Role = 'Student'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                StudentCheckedListBox.Items.Add(reader["UserID"].ToString());
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading students: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadChannelData()
        {
            string query = @"
                SELECT 
                    Channels.ChannelID,
                    Channels.ChannelName,
                    Channels.FacultyID,
                    ChannelStudents.StudentID
                FROM 
                    Channels
                INNER JOIN 
                    ChannelStudents ON Channels.ChannelID = ChannelStudents.ChannelID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        ChanneldataGridView.DataSource = dataTable;

                        if (!ChanneldataGridView.Columns.Contains("Remove"))
                        {
                            DataGridViewButtonColumn removeButtonColumn = new DataGridViewButtonColumn
                            {
                                Name = "Remove",
                                HeaderText = "Remove",
                                Text = "Remove",
                                UseColumnTextForButtonValue = true
                            };
                            ChanneldataGridView.Columns.Add(removeButtonColumn);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading channel data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadCoursesComboBox()
        {
            string query = "SELECT CourseName FROM Courses";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            coursecomboBox.Items.Clear();
                            while (reader.Read())
                            {
                                coursecomboBox.Items.Add(reader["CourseName"].ToString());
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading courses: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void LoadFacultyComboBox()
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\CS Final Project\AiubLink\DataBase\AiubLink.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=false";
            string query = "SELECT UserID FROM AiubLink WHERE Role = 'Faculty'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                FacultycomboBox.Items.Add(reader["UserID"].ToString());
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading faculties: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ChanneldataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == ChanneldataGridView.Columns["Remove"].Index)
            {
                int channelId = Convert.ToInt32(ChanneldataGridView.Rows[e.RowIndex].Cells["ChannelID"].Value);
                string studentId = ChanneldataGridView.Rows[e.RowIndex].Cells["StudentID"].Value.ToString();

                RemoveStudentFromChannel(channelId, studentId);
                LoadChannelData();
            }
        }

        private void RemoveStudentFromChannel(int channelId, string studentId)
        {
            string deleteQuery = "DELETE FROM ChannelStudents WHERE ChannelID = @ChannelID AND StudentID = @StudentID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                    {
                        command.Parameters.AddWithValue("@ChannelID", channelId);
                        command.Parameters.AddWithValue("@StudentID", studentId);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Student removed successfully from the channel.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed to remove the student.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error removing student: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void coursecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCourse = coursecomboBox.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedCourse))
            {
                MessageBox.Show("Please select a course.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ShowRegisteredStudents(selectedCourse);
        }

        private void ShowRegisteredStudents(string courseName)
        {
            string query = @"
        SELECT DISTINCT a.UserID 
        FROM Registrations r 
        INNER JOIN Courses c ON r.CourseID = c.CourseID
        INNER JOIN AiubLink a ON r.SerialNo = a.UserID
        WHERE c.CourseName = @courseName AND a.Role = 'Student'";

            StudentCheckedListBox.Items.Clear();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@courseName", courseName);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                StudentCheckedListBox.Items.Add(reader["UserID"].ToString());
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading registered students: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void exitbutton_Click_1(object sender, EventArgs e)
        {
            AdminMainPage adminMainPage = new AdminMainPage();
            adminMainPage.Show();
            this.Hide();
        }

        private void createbutton_Click_1(object sender, EventArgs e)
        {
            string channelName = ChannelnametextBox.Text.Trim();

            if (string.IsNullOrEmpty(channelName))
            {
                MessageBox.Show("Please enter a channel name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (FacultycomboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a faculty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (StudentCheckedListBox.CheckedItems.Count == 0)
            {
                MessageBox.Show("Please select at least one student.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string facultyID = FacultycomboBox.SelectedItem.ToString();
            List<string> selectedStudents = new List<string>();

            foreach (var item in StudentCheckedListBox.CheckedItems)
            {
                selectedStudents.Add(item.ToString());
            }

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\CS Final Project\AiubLink\DataBase\AiubLink.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=false";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Insert channel into the Channels table
                    string insertChannelQuery = "INSERT INTO Channels (ChannelName, FacultyID) OUTPUT INSERTED.ChannelID VALUES (@ChannelName, @FacultyID)";
                    int channelId;

                    using (SqlCommand command = new SqlCommand(insertChannelQuery, connection))
                    {
                        command.Parameters.AddWithValue("@ChannelName", channelName);
                        command.Parameters.AddWithValue("@FacultyID", facultyID);

                        channelId = (int)command.ExecuteScalar();
                    }

                    // Insert students into the ChannelStudents table
                    string insertStudentsQuery = "INSERT INTO ChannelStudents (ChannelID, StudentID) VALUES (@ChannelID, @StudentID)";

                    foreach (string studentID in selectedStudents)
                    {
                        using (SqlCommand command = new SqlCommand(insertStudentsQuery, connection))
                        {
                            command.Parameters.AddWithValue("@ChannelID", channelId);
                            command.Parameters.AddWithValue("@StudentID", studentID);
                            command.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Channel created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Reset the form
                    ChannelnametextBox.Clear();
                    FacultycomboBox.SelectedIndex = -1;
                    for (int i = 0; i < StudentCheckedListBox.Items.Count; i++)
                    {
                        StudentCheckedListBox.SetItemChecked(i, false);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error creating channel: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void refreshbutton_Click(object sender, EventArgs e)
        {
            LoadChannelData();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
