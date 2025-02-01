using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace AiubLink
{
    public partial class UnderReview : Form
    {
        private readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\CS Final Project\AiubLink\DataBase\AiubLink.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=false";
        private readonly Form previousForm;
        private readonly string userRole;

        public UnderReview(Form previousForm, string userRole)
        {
            InitializeComponent();
            this.previousForm = previousForm;
            this.userRole = userRole;
            infolabel.Text = userRole == "Student" ? "Inactive Students List" : "Inactive Faculties List";
        }

        private void UnderReview_Load(object sender, EventArgs e)
        {
            LoadData(); // Load pending user data
        }

        private void LoadData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT UserID, Name, Status FROM AiubLink WHERE Role = @Role AND Status = 'Pending'";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@Role", userRole);

                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView1.Refresh();

                    // Ensure Activate button column exists
                    if (!dataGridView1.Columns.Contains("ActivateButton"))
                    {
                        DataGridViewButtonColumn activateButtonColumn = new DataGridViewButtonColumn
                        {
                            Name = "ActivateButton",
                            HeaderText = "Action",
                            Text = "Activate",
                            UseColumnTextForButtonValue = true
                        };
                        dataGridView1.Columns.Add(activateButtonColumn);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["ActivateButton"].Index)
            {
                // Ensure the user ID is retrieved from the row
                string userId = dataGridView1.Rows[e.RowIndex].Cells["UserID"].Value.ToString();

                if (!string.IsNullOrEmpty(userId))
                {
                    // Call the method to update the user status to 'Registered'
                    UpdateUserStatus(userId, e.RowIndex);
                }
                else
                {
                    MessageBox.Show("UserID is empty. Cannot activate.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void UpdateUserStatus(string userId, int rowIndex)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string updateQuery = "UPDATE AiubLink SET Status = 'Registered' WHERE UserID = @UserID AND Status = 'Pending'";

                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", userId);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show($"User {userId} activated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Optionally update the DataGridView to reflect the new status
                            dataGridView1.Rows[rowIndex].Cells["Status"].Value = "Registered";

                            RefreshData();  // Reload data to reflect changes in the database
                        }
                        else
                        {
                            MessageBox.Show("No pending user found to activate or already registered.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating user status: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void RefreshData()
        {
            // Save the current column order before resetting
            var columnOrder = dataGridView1.Columns.Cast<DataGridViewColumn>()
                                 .Select(col => col.Name)
                                 .ToArray();

            dataGridView1.DataSource = null;  // Clear the DataGridView

            LoadData();  // Reload the data

            // Restore the column order
            foreach (var columnName in columnOrder)
            {
                var column = dataGridView1.Columns[columnName];
                if (column != null)
                {
                    column.DisplayIndex = Array.IndexOf(columnOrder, columnName);
                }
            }
        }


        private void exitbutton_Click(object sender, EventArgs e)
        {
            if (previousForm is AdminMainPage adminPage)
            {
                adminPage.UpdateCountsFromUnderReview();
            }

            previousForm.Show();
            this.Close();
        }
    }
}
