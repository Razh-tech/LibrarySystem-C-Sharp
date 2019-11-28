using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace LibraryManagementSystem
{
    public partial class admBookSearch : Form
    {
        SqlConnection conn;
        SqlCommand cmd;

        public string Email;
        public string Password;

        public admBookSearch()
        {
            InitializeComponent();
        }

        private void admBookSearch_Load(object sender, EventArgs e)
        {
            Email = login.Email;
            Password = login.Password;

            string connectionString = ("Data Source = SMIJOG1\\SQLEXPRESS01; Initial Catalog = LibraryDB; Integrated Security = True");
            conn = new SqlConnection(connectionString);

            cmd = new SqlCommand("SELECT Books.Book_ID AS 'Book ID', Title AS 'Title', Author AS 'Author', Issued.Member_ID AS 'Member ID', Name AS 'Name', Date_Issued as 'Date Issued', DATEDIFF(day, Date_Issued, CONVERT(date, GETDATE())) AS 'Total Days Passed', Publisher AS 'Publisher', ISBN AS 'ISBN', Genre AS 'Genre' FROM Books LEFT JOIN Issued ON Books.Book_ID = Issued.Book_ID LEFT JOIN Customers ON Customers.Member_ID = Issued.Member_ID", conn);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);

            admBookSearchDataGridView.DataSource = ds.Tables[0];
            admBookSearchDataGridView.ReadOnly = true;
            admBookSearchRbBoth.Select();
        }

        private void admBookSearchLogoutbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            login log = new login();
            log.Show();
        }

        private void admBookSearch_Searchbtn_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            if (admBookSearchRbBoth.Checked == true)
            {
                cmd = new SqlCommand("SELECT Books.Book_ID AS 'Book ID', Title AS 'Title', Author AS 'Author', Issued.Member_ID AS 'Member ID', Name AS 'Name', Date_Issued as 'Date Issued', DATEDIFF(day, Date_Issued, CONVERT(date, GETDATE())) AS 'Total Days Passed', Publisher AS 'Publisher', ISBN AS 'ISBN', Genre AS 'Genre' FROM Books LEFT JOIN Issued ON Books.Book_ID = Issued.Book_ID LEFT JOIN Customers ON Customers.Member_ID = Issued.Member_ID WHERE Title LIKE @searchQuery OR Author LIKE @searchQuery", conn);
                cmd.Parameters.AddWithValue("@searchQuery", "%" + admBookSearchTbxQuery.Text + "%");

                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);

                admBookSearchDataGridView.DataSource = ds.Tables[0];
            }
            else if (admBookSearchRbTitle.Checked == true)
            {
                cmd = new SqlCommand("SELECT Books.Book_ID AS 'Book ID', Title AS 'Title', Author AS 'Author', Issued.Member_ID AS 'Member ID', Name AS 'Name', Date_Issued as 'Date Issued', DATEDIFF(day, Date_Issued, CONVERT(date, GETDATE())) AS 'Total Days Passed', Publisher AS 'Publisher', ISBN AS 'ISBN', Genre AS 'Genre' FROM Books LEFT JOIN Issued ON Books.Book_ID = Issued.Book_ID LEFT JOIN Customers ON Customers.Member_ID = Issued.Member_ID WHERE Title LIKE @searchQuery", conn);
                cmd.Parameters.AddWithValue("@searchQuery", "%" + admBookSearchTbxQuery.Text + "%");

                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);

                admBookSearchDataGridView.DataSource = ds.Tables[0];
            }
            else if (admBookSearchRbAuthor.Checked == true)
            {
                cmd = new SqlCommand("SELECT Books.Book_ID AS 'Book ID', Title AS 'Title', Author AS 'Author', Issued.Member_ID AS 'Member ID', Name AS 'Name', Date_Issued as 'Date Issued', DATEDIFF(day, Date_Issued, CONVERT(date, GETDATE())) AS 'Total Days Passed', Publisher AS 'Publisher', ISBN AS 'ISBN', Genre AS 'Genre' FROM Books LEFT JOIN Issued ON Books.Book_ID = Issued.Book_ID LEFT JOIN Customers ON Customers.Member_ID = Issued.Member_ID WHERE Author LIKE @searchQuery", conn);
                cmd.Parameters.AddWithValue("@searchQuery", "%" + admBookSearchTbxQuery.Text + "%");

                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);

                admBookSearchDataGridView.DataSource = ds.Tables[0];
            }

            if (conn.State == ConnectionState.Open)
                conn.Close();
        }

        private void admBookSearchBackbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            admStartPage _admStartPage = new admStartPage();
            _admStartPage.Show();
        }
    }
}
