using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace LibrarySystem
{
    public partial class LibraryForm : Form
    {
        private string jsonFilePath = "books.json";  // JSON file to store book records
        private string booksFolder = "Books";
        public LibraryForm()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private void LibraryForm_Load(object sender, EventArgs e)
        {
            LoadBooks();
        }

        private void InitializeDataGridView()
        {
            // Configure DataGridView columns
            dataGridView.Columns.Clear();
            dataGridView.AutoGenerateColumns = false;
            dataGridView.AllowUserToAddRows = false; // Disable placeholder row

            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Title", HeaderText = "Title" });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Author", HeaderText = "Author" });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Genre", HeaderText = "Genre" });

            // Add Open button column
            var openButtonColumn = new DataGridViewButtonColumn
            {
                Name = "OpenButton",
                HeaderText = "Open",
                Text = "Open File",
                UseColumnTextForButtonValue = true
            };
            dataGridView.Columns.Add(openButtonColumn);

            // Add Delete button column
            var deleteButtonColumn = new DataGridViewButtonColumn
            {
                Name = "DeleteButton",
                HeaderText = "Delete",
                Text = "Delete",
                UseColumnTextForButtonValue = true
            };
            dataGridView.Columns.Add(deleteButtonColumn);

            dataGridView.CellClick += DataGridView_CellClick;
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "All Files|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                UploadBook(txtTitle.Text, txtAuthor.Text, txtGenre.Text, filePath);
                LoadBooks();
            }
        }

        private void UploadBook(string title, string author, string genre, string filePath)
        {
            if (!Directory.Exists(booksFolder))
                Directory.CreateDirectory(booksFolder);

            if (!File.Exists(jsonFilePath))
                File.WriteAllText(jsonFilePath, "[]");

            string destPath = Path.Combine(booksFolder, Path.GetFileName(filePath));
            File.Copy(filePath, destPath, true);

            List<Book> books = GetBooks();
            books.Add(new Book { Title = title, Author = author, Genre = genre, FilePath = destPath });

            File.WriteAllText(jsonFilePath, JsonConvert.SerializeObject(books, Formatting.Indented));
        }

        private List<Book> GetBooks()
        {
            if (!File.Exists(jsonFilePath)) return new List<Book>();

            string jsonContent = File.ReadAllText(jsonFilePath);
            return JsonConvert.DeserializeObject<List<Book>>(jsonContent) ?? new List<Book>();
        }

        private void LoadBooks()
        {
            dataGridView.DataSource = null;
            dataGridView.DataSource = GetBooks();
            dataGridView.Refresh(); // Ensure the DataGridView is refreshed
        }

        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView.Rows.Count) // Ensure valid row
            {
                var books = GetBooks();
                var selectedBook = books[e.RowIndex];

                if (e.ColumnIndex == dataGridView.Columns["OpenButton"].Index)
                {
                    OpenBookFile(selectedBook.FilePath);
                }
                else if (e.ColumnIndex == dataGridView.Columns["DeleteButton"].Index)
                {
                    DeleteBookRecord(selectedBook);
                }
            }
        }

        private void OpenBookFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                System.Diagnostics.Process.Start(filePath);
            }
            else
            {
                MessageBox.Show("File not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteBookRecord(Book book)
        {
            var books = GetBooks();
            var bookToRemove = books.Find(b => b.Title == book.Title && b.Author == book.Author && b.FilePath == book.FilePath);
            if (bookToRemove != null)
            {
                books.Remove(bookToRemove);

                // Delete the file if it exists
                if (File.Exists(book.FilePath))
                {
                    File.Delete(book.FilePath);
                }

                File.WriteAllText(jsonFilePath, JsonConvert.SerializeObject(books, Formatting.Indented));
                LoadBooks(); // Refresh DataGridView after deletion

                MessageBox.Show("Book record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Book record not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public string FilePath { get; set; }
    }
}
    

