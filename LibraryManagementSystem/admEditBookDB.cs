using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using Tulpep.NotificationWindow;

namespace LibraryManagementSystem
{
    public partial class admEditBookDB : Form
    {
        SqlConnection conn;
        SqlCommand cmd;

        int selected_book_id;

        private void admEditBookDB_Load(object sender, EventArgs e)
        {
            displayBooks();
            admEditBookDBRbBoth.Select();
        }

        public void displayBooks()
        {
            string connectionString = ("Data Source = SMIJOG1\\SQLEXPRESS01; Initial Catalog = LibraryDB; Integrated Security = True");
            conn = new SqlConnection(connectionString);

            cmd = new SqlCommand("SELECT * FROM Books ORDER BY Title ASC", conn);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);

            editBookDBDataGridView.DataSource = ds.Tables[0];
            editBookDBDataGridView.ReadOnly = true;
        }

        public void clearFields()
        {
            editBookDBBookIDTextBox.Text = string.Empty;
            editBookDBTitleTextBox.Text = string.Empty;
            editBookDBAuthorTextBox.Text = string.Empty;
            editBookDBPublisherTextBox.Text = string.Empty;
            editBookDBISBNTextBox.Text = string.Empty;
            editBookDBGenreTextBox.Text = string.Empty;
        }

        public admEditBookDB()
        {
            InitializeComponent();
        }

        private void admEditBookDBBackbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            admStartPage _admStartPage = new admStartPage();
            _admStartPage.Show();
        }

        private void admEditBookDBLogoutbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            login log = new login();
            log.Show();
        }

        private void editBookDBSearchbtn_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            if (admEditBookDBRbBoth.Checked == true)
            {
                cmd = new SqlCommand("SELECT * FROM Books WHERE Title LIKE @searchQuery OR Author LIKE @searchQuery", conn);
                cmd.Parameters.AddWithValue("@searchQuery", "%" + editBookDBTbxSearch.Text + "%");

                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);

                editBookDBDataGridView.DataSource = ds.Tables[0];
            }
            else if (admEditBookDBRbTitle.Checked == true)
            {
                cmd = new SqlCommand("SELECT * FROM Books WHERE Title LIKE @searchQuery", conn);
                cmd.Parameters.AddWithValue("@searchQuery", "%" + editBookDBTbxSearch.Text + "%");

                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);

                editBookDBDataGridView.DataSource = ds.Tables[0];
            }
            else if (admEditBookDBRbAuthor.Checked == true)
            {
                cmd = new SqlCommand("SELECT * FROM Books WHERE Author LIKE @searchQuery", conn);
                cmd.Parameters.AddWithValue("@searchQuery", "%" + editBookDBTbxSearch.Text + "%");

                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);

                editBookDBDataGridView.DataSource = ds.Tables[0];
            }

            if (conn.State == ConnectionState.Open)
                conn.Close();
        }

        private void admEditBookDBClearbtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void editBookDBDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.RowIndex != editBookDBDataGridView.Rows.Count - 1)
            {
                selected_book_id = Convert.ToInt32(editBookDBDataGridView.Rows[e.RowIndex].Cells[0].Value);
                string Title = Convert.ToString(editBookDBDataGridView.Rows[e.RowIndex].Cells[1].Value);
                string Author = Convert.ToString(editBookDBDataGridView.Rows[e.RowIndex].Cells[2].Value);
                string Publisher = Convert.ToString(editBookDBDataGridView.Rows[e.RowIndex].Cells[3].Value);
                string ISBN = Convert.ToString(editBookDBDataGridView.Rows[e.RowIndex].Cells[4].Value);
                string Genre = Convert.ToString(editBookDBDataGridView.Rows[e.RowIndex].Cells[5].Value);

                editBookDBBookIDTextBox.Text = Convert.ToString(selected_book_id);
                editBookDBTitleTextBox.Text = Title;
                editBookDBAuthorTextBox.Text = Author;
                editBookDBPublisherTextBox.Text = Publisher;
                editBookDBISBNTextBox.Text = ISBN;
                editBookDBGenreTextBox.Text = Genre;
            }
        }

        private void editBookDBUpdatebtn_Click(object sender, EventArgs e)
        {
            int Book_ID = 0;
            string Title;
            string Author;
            string Publisher;
            string ISBN;
            string Genre;

            bool preliminaryAcceptedState = true;

            if (conn.State == ConnectionState.Closed)
                conn.Open();

            try
            {
                Book_ID = Convert.ToInt32(editBookDBBookIDTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Please make sure that the Book ID is an integer.", "WARNING");
                preliminaryAcceptedState = false;
            }
            Title = editBookDBTitleTextBox.Text;
            Author = editBookDBAuthorTextBox.Text;
            Publisher = editBookDBPublisherTextBox.Text;
            ISBN = editBookDBISBNTextBox.Text;
            Genre = editBookDBGenreTextBox.Text;

            if (preliminaryAcceptedState == true)
            {
                try
                {
                    cmd = new SqlCommand("UPDATE Books SET Book_ID = @Book_ID, Title = @Title, Author = @Author, Publisher = @Publisher, ISBN = @ISBN, Genre = @Genre WHERE Book_ID = @selected_book_id", conn);
                    cmd.Parameters.AddWithValue("@Book_id", Book_ID);
                    cmd.Parameters.AddWithValue("@Title", Title);
                    cmd.Parameters.AddWithValue("@Author", Author);
                    cmd.Parameters.AddWithValue("@Publisher", Publisher);
                    cmd.Parameters.AddWithValue("@ISBN", ISBN);
                    cmd.Parameters.AddWithValue("@Genre", Genre);
                    cmd.Parameters.AddWithValue("@selected_book_id", selected_book_id);

                    int result = cmd.ExecuteNonQuery();
                    if (result == 1)
                    {
                        MessageBox.Show("Changes successfully saved.", "User Information");

                        PopupNotifier popup = new PopupNotifier
                        {
                            TitleText = "New Notification",
                            ContentText = "A  book  database  has  just  been  updated"
                        };
                        popup.Popup();

                        clearFields();
                    }

                    displayBooks();
                }
                catch
                {
                    MessageBox.Show("There is already a book with this BookID.\nBook ID's have to be distinct.", "WARNING");
                }
            }

            if (conn.State == ConnectionState.Open)
                conn.Close();
        }

        private void editBookDBInsertbtn_Click(object sender, EventArgs e)
        {
            int Book_ID = 0;
            string Title;
            string Author;
            string Publisher;
            string ISBN;
            string Genre;

            bool preliminaryAcceptedState = true;

            if (conn.State == ConnectionState.Closed)
                conn.Open();

            try
            {
                Book_ID = Convert.ToInt32(editBookDBBookIDTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Please make sure that the Book ID is an integer.", "WARNING");
                preliminaryAcceptedState = false;
            }
            Title = editBookDBTitleTextBox.Text;
            Author = editBookDBAuthorTextBox.Text;
            Publisher = editBookDBPublisherTextBox.Text;
            ISBN = editBookDBISBNTextBox.Text;
            Genre = editBookDBGenreTextBox.Text;

            if (preliminaryAcceptedState == true)
            {
                try
                {
                    cmd = new SqlCommand("INSERT INTO Books VALUES (@Book_ID, @Title, @Author, @Publisher, @ISBN, @Genre)", conn);
                    cmd.Parameters.AddWithValue("@Book_ID", Book_ID);
                    cmd.Parameters.AddWithValue("@Title", Title);
                    cmd.Parameters.AddWithValue("@Author", Author);
                    cmd.Parameters.AddWithValue("@Publisher", Publisher);
                    cmd.Parameters.AddWithValue("@ISBN", ISBN);
                    cmd.Parameters.AddWithValue("@Genre", Genre);

                    int result = cmd.ExecuteNonQuery();

                    if (result == 1)
                    {
                        MessageBox.Show("Book successfully added.", "User Information");

                        PopupNotifier popup = new PopupNotifier
                        {
                            TitleText = "New Notification",
                            ContentText = "A  new  book  has  just  been  added  to  database"
                        };
                        popup.Popup();

                        clearFields();
                    }

                    displayBooks();
                }
                catch
                {
                    MessageBox.Show("There is already a book with this Book ID.\nBook ID's have to be distinct.", "WARNING");
                }
            }

            if (conn.State == ConnectionState.Open)
                conn.Close();
        }

        private void editBookDBDeletebtn_Click(object sender, EventArgs e)
        {
            int Book_ID = 0;

            bool preliminaryAcceptedState = true;

            if (conn.State == ConnectionState.Closed)
                conn.Open();

            try
            {
                Book_ID = Convert.ToInt32(editBookDBBookIDTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Please make sure that the Book ID is an integer.", "WARNING");
                preliminaryAcceptedState = false;
            }

            if (preliminaryAcceptedState == true)
            {
                try
                {
                    cmd = new SqlCommand("DELETE FROM Books WHERE Book_ID = @Book_ID", conn);
                    cmd.Parameters.AddWithValue("@Book_ID", Book_ID);

                    int result = cmd.ExecuteNonQuery();
                    if (result == 1)
                    {
                        MessageBox.Show("Book successfully deleted.", "User Information");

                        PopupNotifier popup = new PopupNotifier
                        {
                            TitleText = "New Notification",
                            ContentText = "A  book  has  just  been  deleted  from  database"
                        };
                        popup.Popup();

                        clearFields();
                    }

                    displayBooks();
                }
                catch
                {
                    MessageBox.Show("Cannot delete an issued book.\nPlease make sure the book is not issued to a student before deleting it.", "WARNING");
                }
            }

            if (conn.State == ConnectionState.Open)
                conn.Close();
        }
    }
}
