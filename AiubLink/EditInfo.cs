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
    public partial class EditInfo : Form
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\CS Final Project\AiubLink\DataBase\AiubLink.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=false";
        private string userID;
        private byte[] photoData;
        public EditInfo(string userID, string name, string phone, string dob, string status, byte[] photo)
        {
            InitializeComponent();
            this.userID = userID;

            // Pre-fill the fields with the data passed from InfoDashBoard
            nametextBox.Text = name;
            phonetextBox.Text = phone;
            dateTimePicker1.Value = DateTime.Parse(dob);
            statusComboBox.SelectedItem = status;

            if (photo != null)
            {
                photoData = photo;
                pictureBox1.Image = ImageFromBytes(photo);
            }
        }

        private Image ImageFromBytes(byte[] photoData)
        {
            using (var ms = new System.IO.MemoryStream(photoData))
            {
                return Image.FromStream(ms);
            }
        }


        private void updatebutton_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "UPDATE AiubLink SET Name = @Name, Phone = @Phone, DOB = @DOB, Status = @Status";
                    if (pictureBox1.Image != null)
                    {
                        query += ", Photo = @Photo";
                    }
                    query += " WHERE UserID = @UserID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", nametextBox.Text.Trim());
                        command.Parameters.AddWithValue("@Phone", int.Parse(phonetextBox.Text.Trim()));
                        command.Parameters.AddWithValue("@DOB", dateTimePicker1.Value);
                        command.Parameters.AddWithValue("@Status", statusComboBox.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@UserID", userID);

                        if (pictureBox1.Image != null)
                        {
                            command.Parameters.Add("@Photo", SqlDbType.VarBinary).Value = GetPhotoData();
                        }

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("No data found for the given UserID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private byte[] GetPhotoData()
        {
            if (pictureBox1.Image != null)
            {
                using (var ms = new System.IO.MemoryStream())
                {
                    pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    return ms.ToArray();
                }
            }
            return null;
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    var result = MessageBox.Show("Are you sure you want to delete this data?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        string query = "DELETE FROM AiubLink WHERE UserID = @UserID";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@UserID", userID);

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Data deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("No data found for the given UserID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while deleting data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
