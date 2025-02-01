using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace UniversityRegistrationSystem
{
    public partial class StudentForm : Form
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\CS Final Project\AiubLink\DataBase\AiubLink.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=false";
        private Form previousForm;
        private string serialNo;
        private string studentID;
        private string studentName;
        private int currentSemester;

        public StudentForm(Form previousForm, string studentID, string studentName)
        {
            InitializeComponent();
            this.previousForm = previousForm;
            this.studentID = studentID;
            this.studentName = studentName;

            txtStudentID.Text = studentID;
            txtStudentName.Text = studentName;
            txtStudentID.ReadOnly = true;
            txtStudentName.ReadOnly = true;

            InitializeStudentSerialNo();
            InitializeCourseDataGridView(); // Initialize the DataGridView columns
            LoadCourses();
            LoadRegisteredCourses();
            InitializeSemester();
        }

        private void InitializeStudentSerialNo()
        {
            string query = @"
    SELECT a.UserID, a.Name 
    FROM AiubLink a 
    WHERE a.Role = 'Student' AND a.UserID = @userID";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@userID", studentID);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string userID = reader["UserID"].ToString();
                            string name = reader["Name"].ToString();
                            txtStudentID.Text = userID;
                            txtStudentName.Text = name;
                            serialNo = userID;
                        }
                        else
                        {
                            MessageBox.Show("Student not found or incorrect role assignment.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        

        private void InitializeSemester()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string semesterQuery = "SELECT ISNULL(MAX(SemesterNumber), 0) FROM Semesters WHERE SerialNo = @serialNo";
                using (SqlCommand cmd = new SqlCommand(semesterQuery, con))
                {
                    cmd.Parameters.AddWithValue("@serialNo", serialNo);
                    currentSemester = (int)cmd.ExecuteScalar() + 1;
                }
            }
            lblSemester.Text = $"Current Semester: {currentSemester}";
        }

        private void InitializeCourseDataGridView()
        {
            coursedataGridView.Columns.Clear();

            coursedataGridView.Columns.Add("SemesterNumber", "Semester Number");
            coursedataGridView.Columns.Add("CourseName", "Course Name");
            coursedataGridView.Columns.Add("CGPA", "CGPA");

            // Add Delete button column
            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.Name = "DeleteButton";
            deleteButtonColumn.HeaderText = "Action";
            deleteButtonColumn.Text = "Delete";
            deleteButtonColumn.UseColumnTextForButtonValue = true;
            coursedataGridView.Columns.Add(deleteButtonColumn);

            coursedataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            coursedataGridView.CellClick += CoursedataGridView_CellClick;
        }


        private void LoadCourses()
        {
            coursecheckedListBox.Items.Clear();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = @"SELECT CourseName FROM Courses c
                                 WHERE NOT EXISTS (
                                     SELECT 1 FROM Registrations r 
                                     INNER JOIN Semesters s ON r.SemesterID = s.SemesterID
                                     WHERE r.SerialNo = @serialNo AND r.CourseID = c.CourseID
                                 )";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@serialNo", serialNo);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            coursecheckedListBox.Items.Add(reader["CourseName"].ToString());
                        }
                    }
                }
            }
        }

        private void LoadRegisteredCourses()
        {
            coursedataGridView.Rows.Clear();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = @"
            SELECT s.SemesterNumber, c.CourseName, r.CGPA
            FROM Registrations r
            INNER JOIN Courses c ON r.CourseID = c.CourseID
            INNER JOIN Semesters s ON r.SemesterID = s.SemesterID
            WHERE r.SerialNo = @serialNo
            ORDER BY s.SemesterNumber";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@serialNo", serialNo);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string semesterNumber = reader["SemesterNumber"].ToString();
                            string courseName = reader["CourseName"].ToString();
                            string cgpa = reader["CGPA"] != DBNull.Value ? reader["CGPA"].ToString() : "N/A";

                            coursedataGridView.Rows.Add(semesterNumber, courseName, cgpa);
                        }
                    }
                }
            }
        }


        private void CoursedataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == coursedataGridView.Columns["DeleteButton"].Index)
            {
                string courseName = coursedataGridView.Rows[e.RowIndex].Cells["CourseName"].Value.ToString();

                // Remove the row from the DataGridView
                coursedataGridView.Rows.RemoveAt(e.RowIndex);

                // Add the course back to the checked list box
                if (!coursecheckedListBox.Items.Contains(courseName))
                {
                    coursecheckedListBox.Items.Add(courseName);
                }
            }
        }

        private void btnRegisterCourse_Click(object sender, EventArgs e)
        {
            int selectedCoursesCount = coursecheckedListBox.CheckedItems.Count;

            if (selectedCoursesCount < 4 || selectedCoursesCount > 6)
            {
                MessageBox.Show("Please select between 4 and 6 courses to register.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // Check if this is the first semester or a subsequent semester
                    bool isFirstSemester = currentSemester == 1;

                    // If it's not the first semester, check CGPA for each selected course
                    if (!isFirstSemester)
                    {
                        foreach (var course in coursecheckedListBox.CheckedItems)
                        {
                            // Check if the course has already been registered in the previous semester (from coursedataGridView)
                            bool isAlreadyRegistered = false;
                            foreach (DataGridViewRow row in coursedataGridView.Rows)
                            {
                                if (row.Cells["CourseName"].Value.ToString() == course.ToString())
                                {
                                    isAlreadyRegistered = true;
                                    break;
                                }
                            }

                            // If the course is already registered, check if the CGPA is available
                            if (isAlreadyRegistered)
                            {
                                string checkCgpaQuery = "SELECT CGPA FROM Registrations r INNER JOIN Courses c ON r.CourseID = c.CourseID WHERE r.SerialNo = @serialNo AND c.CourseName = @courseName";
                                object cgpaValue;

                                using (SqlCommand cmd = new SqlCommand(checkCgpaQuery, con))
                                {
                                    cmd.Parameters.AddWithValue("@serialNo", serialNo);
                                    cmd.Parameters.AddWithValue("@courseName", course.ToString());
                                    cgpaValue = cmd.ExecuteScalar();
                                }

                                if (cgpaValue == null || cgpaValue == DBNull.Value)
                                {
                                    MessageBox.Show($"Cannot register for the next semester. Course '{course}' has no CGPA recorded.",
                                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }
                            }
                        }
                    }

                    // Insert new semester
                    string insertSemesterQuery = "INSERT INTO Semesters (SemesterNumber, SerialNo) OUTPUT INSERTED.SemesterID VALUES (@semesterNumber, @serialNo)";
                    int semesterId;

                    using (SqlCommand semesterCmd = new SqlCommand(insertSemesterQuery, con))
                    {
                        semesterCmd.Parameters.AddWithValue("@semesterNumber", currentSemester);
                        semesterCmd.Parameters.AddWithValue("@serialNo", serialNo);
                        semesterId = (int)semesterCmd.ExecuteScalar();
                    }

                    // Register courses
                    string registerQuery = "INSERT INTO Registrations (SerialNo, CourseID, SemesterID) VALUES (@serialNo, @courseID, @semesterID)";
                    foreach (var course in coursecheckedListBox.CheckedItems)
                    {
                        string courseIdQuery = "SELECT CourseID FROM Courses WHERE CourseName = @courseName";
                        int courseId;

                        using (SqlCommand courseCmd = new SqlCommand(courseIdQuery, con))
                        {
                            courseCmd.Parameters.AddWithValue("@courseName", course.ToString());
                            courseId = (int)courseCmd.ExecuteScalar();
                        }

                        using (SqlCommand registerCmd = new SqlCommand(registerQuery, con))
                        {
                            registerCmd.Parameters.AddWithValue("@serialNo", serialNo);
                            registerCmd.Parameters.AddWithValue("@courseID", courseId);
                            registerCmd.Parameters.AddWithValue("@semesterID", semesterId);
                            registerCmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Courses registered successfully!");
                    LoadCourses();
                    LoadRegisteredCourses();
                    InitializeSemester();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during registration: " + ex.Message);
            }
        }




        private void exitbutton_Click(object sender, EventArgs e)
        {
            previousForm.Show();
            this.Close();
        }

        private void btnViewCourses_Click(object sender, EventArgs e)
        {
            coursedataGridView.Visible = true;
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            coursedataGridView.Visible = false;
        }
    }
}
