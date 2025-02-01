using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace AiubLink
{
    public partial class InfoDashBoard : Form
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\CS Final Project\AiubLink\DataBase\AiubLink.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=false";
        private string userRole;

        public InfoDashBoard(string role)
        {
            InitializeComponent();
            userRole = role;
            if (userRole == "Student")
            {
                studentdetailslabel.Text = "Student Details";
                label2.Text = "Search By Student ID :";
            }
            else
            {
                studentdetailslabel.Text = "Faculty Details";
                label2.Text = "Search By Faculty ID :";
            }
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            AdminMainPage adminMainPage = new AdminMainPage();
            adminMainPage.Show();
            this.Hide();
        }

       

       
        private void refreshbutton_Click(object sender, EventArgs e)
        {
            SearchData();
        }

        private void SearchData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT Name, Phone, UserID, Email, Photo, DOB, Password, Role, Status FROM AiubLink WHERE Role = @Role AND Status = @Status";
                    if (!string.IsNullOrWhiteSpace(idtextBox.Text))
                    {
                        query += " AND UserID LIKE @UserID";
                    }

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Role", userRole);
                        command.Parameters.AddWithValue("@Status", "Registered");

                        if (!string.IsNullOrWhiteSpace(idtextBox.Text))
                        {
                            command.Parameters.AddWithValue("@UserID", "%" + idtextBox.Text.Trim() + "%");
                        }

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Clear and bind the DataGridView
                        dataGridView.Columns.Clear();
                        dataGridView.AutoGenerateColumns = true;
                        dataGridView.DataSource = dataTable;

                        // Add Edit button column
                        DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
                        editButtonColumn.HeaderText = "Edit";
                        editButtonColumn.Text = "Edit";
                        editButtonColumn.Name = "editButton";
                        editButtonColumn.UseColumnTextForButtonValue = true;
                        dataGridView.Columns.Add(editButtonColumn);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while searching data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked column is the Edit button column
            if (e.ColumnIndex == dataGridView.Columns["editButton"].Index)
            {
                // Get the selected row's data
                string userID = dataGridView.Rows[e.RowIndex].Cells["UserID"].Value.ToString();
                string name = dataGridView.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                string phone = dataGridView.Rows[e.RowIndex].Cells["Phone"].Value.ToString();
                string dob = dataGridView.Rows[e.RowIndex].Cells["DOB"].Value.ToString();
                string status = dataGridView.Rows[e.RowIndex].Cells["Status"].Value.ToString();
                byte[] photo = dataGridView.Rows[e.RowIndex].Cells["Photo"].Value as byte[];

                // Open the EditInfo form and pass the data
                EditInfo editForm = new EditInfo(userID, name, phone, dob, status, photo);
                editForm.ShowDialog();

                // Refresh the DataGridView after closing the EditInfo form
                SearchData();
            }
        }

        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView.Columns[e.ColumnIndex].Name == "Photo" && e.Value != DBNull.Value)
            {
                try
                {
                    // Cast the value to a byte array (assuming it's stored as a byte array in the database)
                    byte[] imageBytes = (byte[])e.Value;

                    // Convert the byte array to an image
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        Image image = Image.FromStream(ms);

                        // Resize the image to fit the cell size
                        int cellWidth = dataGridView.Columns[e.ColumnIndex].Width;
                        int cellHeight = dataGridView.RowTemplate.Height;

                        // Resize the image to fit the cell while keeping aspect ratio (stretching it if needed)
                        var resizedImage = new Bitmap(image, new Size(cellWidth, cellHeight));

                        // Set the value to the resized image
                        e.Value = resizedImage;
                    }
                }
                catch (Exception ex)
                {
                    // Handle errors if the image processing fails
                    MessageBox.Show($"An error occurred while formatting the image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void InfoDashBoard_Load(object sender, EventArgs e)
        {
            SearchData();
            dataGridView.CellFormatting += dataGridView_CellFormatting;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void studentdetailslabel_Click(object sender, EventArgs e)
        {

        }
    }
}
