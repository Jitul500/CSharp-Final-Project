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
    public partial class AdminMainPage : Form
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\CS Final Project\AiubLink\DataBase\AiubLink.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=false";
        public AdminMainPage()
        {
            InitializeComponent();
            
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Hide();
        }

        private void AdminMainPage_Load(object sender, EventArgs e)
        {
            UpdateCounts();
           

        }

        private void UpdateCounts()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Query to count registered students
                    string studentRegisteredQuery = "SELECT COUNT(*) FROM AiubLink WHERE Role = 'Student' AND Status = 'Registered'";
                    using (SqlCommand studentRegisteredCommand = new SqlCommand(studentRegisteredQuery, connection))
                    {
                        int studentRegisteredCount = (int)studentRegisteredCommand.ExecuteScalar();
                        stnumlabel.Text = studentRegisteredCount.ToString(); // Set the count to the label
                    }

                    // Query to count pending students
                    string studentPendingQuery = "SELECT COUNT(*) FROM AiubLink WHERE Role = 'Student' AND Status = 'Pending'";
                    using (SqlCommand studentPendingCommand = new SqlCommand(studentPendingQuery, connection))
                    {
                        int studentPendingCount = (int)studentPendingCommand.ExecuteScalar();
                        stnum2label.Text = studentPendingCount.ToString(); // Set the count to the label
                    }

                    // Query to count registered faculties
                    string facultyRegisteredQuery = "SELECT COUNT(*) FROM AiubLink WHERE Role = 'Faculty' AND Status = 'Registered'";
                    using (SqlCommand facultyRegisteredCommand = new SqlCommand(facultyRegisteredQuery, connection))
                    {
                        int facultyRegisteredCount = (int)facultyRegisteredCommand.ExecuteScalar();
                        facnumlabel.Text = facultyRegisteredCount.ToString(); // Set the count to the label
                    }

                    // Query to count pending faculties
                    string facultyPendingQuery = "SELECT COUNT(*) FROM AiubLink WHERE Role = 'Faculty' AND Status = 'Pending'";
                    using (SqlCommand facultyPendingCommand = new SqlCommand(facultyPendingQuery, connection))
                    {
                        int facultyPendingCount = (int)facultyPendingCommand.ExecuteScalar();
                        facnum2label.Text = facultyPendingCount.ToString(); // Set the count to the label
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while fetching counts: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UpdateCountsFromUnderReview()
        {
            UpdateCounts(); 
        }


        private void AdStudentB_Click(object sender, EventArgs e)
        {
            InfoDashBoard infoDashBoard = new InfoDashBoard("Student");
            infoDashBoard.Show();
            this.Hide();
        }

        private void AdTeacherB_Click(object sender, EventArgs e)
        {
            InfoDashBoard infoDashBoard = new InfoDashBoard("Faculty");
            infoDashBoard.Show();
            this.Hide();

        }

        private void AdADDchannelB_Click(object sender, EventArgs e)
        {
            
            AddChannelDashBoard addChannelDashBoard = new AddChannelDashBoard();
            addChannelDashBoard.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void StudentPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnteacherunrev_Click(object sender, EventArgs e)
        {
            UnderReview underReview = new UnderReview(this, "Faculty");
            underReview.Show();
            this.Hide();
        }

        private void btnstudentunrev_Click(object sender, EventArgs e)
        {
            UnderReview underReview = new UnderReview(this, "Student");
            underReview.Show();
            this.Hide();
        }

        private void stnum2label_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
