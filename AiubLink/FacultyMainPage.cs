using CalendarSystem;
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
    public partial class FacultyMainPage : Form
    {
        private string facultyUserID;
        public FacultyMainPage(string userID)
        {
            InitializeComponent();
            facultyUserID = userID;
        }

        private void FacultyMainPage_Load(object sender, EventArgs e)
        {
            LoadFacultyDetails();
            infopanel.Visible = true;
        }

        private void LoadFacultyDetails()
        {
            // Database connection string
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\CS Final Project\AiubLink\DataBase\AiubLink.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=false";

            // Query to fetch student details
            string query = "SELECT Name, Phone, UserID, Email, DOB, Photo FROM AiubLink WHERE UserID = @UserID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", facultyUserID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Populate labels with student details
                                namelabel.Text = reader["Name"].ToString();
                                phonelabel.Text = reader["Phone"].ToString();
                                facultyidlabel.Text = reader["UserID"].ToString();
                                emaillabel.Text = reader["Email"].ToString();
                                doblabel.Text = Convert.ToDateTime(reader["DOB"]).ToString("dd/MM/yyyy");

                                // Load and display photo if available
                                if (reader["Photo"] != DBNull.Value)
                                {
                                    byte[] photoBytes = (byte[])reader["Photo"];
                                    using (var ms = new System.IO.MemoryStream(photoBytes))
                                    {
                                        profilepictureBox.Image = Image.FromStream(ms);
                                    }
                                }
                                else
                                {
                                    profilepictureBox.Image = null;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Failed to load student details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while loading details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.Show();
            this.Hide();
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void infopanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void INFObutton_Click(object sender, EventArgs e)
        {
            infopanel.Visible = true;
        }

        private void Channelbutton_Click(object sender, EventArgs e)
        {
            channels channels = new channels(this, facultyUserID, "Faculty");
            channels.Show();
            this.Hide();
        }

        private void profilepictureBox_Click(object sender, EventArgs e)
        {

        }

        private void sidlabel_Click(object sender, EventArgs e)
        {

        }

        private void Regbutton_Click(object sender, EventArgs e)
        {
            GradeUpload gradeUpload = new GradeUpload(this,facultyUserID);
            gradeUpload.Show();
            this.Hide();
        }

        private void calenderbutton_Click(object sender, EventArgs e)
        {
            CalendarForm calendarForm = new CalendarForm(this);
            calendarForm.Show();
            this.Hide();
        }
    }
}
