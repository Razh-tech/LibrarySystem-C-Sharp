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

namespace LibraryManagementSystem
{
    public partial class ListBooks : Form
    {
        SqlConnection conn;
        SqlCommand cmd;

        public string Email;
        public string Password;

        public ListBooks()
        {
            InitializeComponent();
        }

        private void ListBooksBackbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            managerStartPage managerStart = new managerStartPage();
            managerStart.Show();
        }

        private void ListBooksLogoutbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerLogin log = new ManagerLogin();
            log.Show();
        }

        private void ListBooks_Searchbtn_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            if (ListBooksRbBoth.Checked == true)
            {
                cmd = new SqlCommand("SELECT Books.Book_ID AS 'Book ID', Title AS 'Title', Author AS 'Author', Issued.Member_ID AS 'Member ID', Name AS 'Name', Date_Issued as 'Date Issued', DATEDIFF(day, Date_Issued, CONVERT(date, GETDATE())) AS 'Total Days Passed', Publisher AS 'Publisher', ISBN AS 'ISBN', Genre AS 'Genre' FROM Books LEFT JOIN Issued ON Books.Book_ID = Issued.Book_ID LEFT JOIN Customers ON Customers.Member_ID = Issued.Member_ID WHERE Title LIKE @searchQuery OR Author LIKE @searchQuery", conn);
                cmd.Parameters.AddWithValue("@searchQuery", "%" + ListBooksTbxQuery.Text + "%");

                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);

                ListBooksDataGridView.DataSource = ds.Tables[0];
            }
            else if (ListBooksRbTitle.Checked == true)
            {
                cmd = new SqlCommand("SELECT Books.Book_ID AS 'Book ID', Title AS 'Title', Author AS 'Author', Issued.Member_ID AS 'Member ID', Name AS 'Name', Date_Issued as 'Date Issued', DATEDIFF(day, Date_Issued, CONVERT(date, GETDATE())) AS 'Total Days Passed', Publisher AS 'Publisher', ISBN AS 'ISBN', Genre AS 'Genre' FROM Books LEFT JOIN Issued ON Books.Book_ID = Issued.Book_ID LEFT JOIN Customers ON Customers.Member_ID = Issued.Member_ID WHERE Title LIKE @searchQuery", conn);
                cmd.Parameters.AddWithValue("@searchQuery", "%" + ListBooksTbxQuery.Text + "%");

                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);

                ListBooksDataGridView.DataSource = ds.Tables[0];
            }
            else if (ListBooksRbAuthor.Checked == true)
            {
                cmd = new SqlCommand("SELECT Books.Book_ID AS 'Book ID', Title AS 'Title', Author AS 'Author', Issued.Member_ID AS 'Member ID', Name AS 'Name', Date_Issued as 'Date Issued', DATEDIFF(day, Date_Issued, CONVERT(date, GETDATE())) AS 'Total Days Passed', Publisher AS 'Publisher', ISBN AS 'ISBN', Genre AS 'Genre' FROM Books LEFT JOIN Issued ON Books.Book_ID = Issued.Book_ID LEFT JOIN Customers ON Customers.Member_ID = Issued.Member_ID WHERE Author LIKE @searchQuery", conn);
                cmd.Parameters.AddWithValue("@searchQuery", "%" + ListBooksTbxQuery.Text + "%");

                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);

                ListBooksDataGridView.DataSource = ds.Tables[0];
            }

            if (conn.State == ConnectionState.Open)
                conn.Close();
        }

        private void ListBooks_Load(object sender, EventArgs e)
        {
            Email = login.Email;
            Password = login.Password;

            string connectionString = ("Data Source = SMIJOG1\\SQLEXPRESS01; Initial Catalog = LibraryDB; Integrated Security = True");
            conn = new SqlConnection(connectionString);

            cmd = new SqlCommand("SELECT Books.Book_ID AS 'Book ID', Title AS 'Title', Author AS 'Author', Issued.Member_ID AS 'Member ID', Name AS 'Name', Date_Issued as 'Date Issued', DATEDIFF(day, Date_Issued, CONVERT(date, GETDATE())) AS 'Total Days Passed', Publisher AS 'Publisher', ISBN AS 'ISBN', Genre AS 'Genre' FROM Books LEFT JOIN Issued ON Books.Book_ID = Issued.Book_ID LEFT JOIN Customers ON Customers.Member_ID = Issued.Member_ID", conn);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);

            ListBooksDataGridView.DataSource = ds.Tables[0];
            ListBooksDataGridView.ReadOnly = true;
            ListBooksRbBoth.Select();
        }
    }
}
