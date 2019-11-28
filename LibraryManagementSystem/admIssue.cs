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
using Tulpep.NotificationWindow;

namespace LibraryManagementSystem
{
    public partial class admIssue : Form
    {
        SqlConnection conn;
        SqlCommand cmd;

        public admIssue()
        {
            InitializeComponent();
        }

        private void admIssue_Load(object sender, EventArgs e)
        {
            string connectionString = ("Data Source = SMIJOG1\\SQLEXPRESS01; Initial Catalog = LibraryDB; Integrated Security = True");
            conn = new SqlConnection(connectionString);

            displayTable();
            admIssueRbBoth.Select();
        }

        public void displayTable()
        {
            cmd = new SqlCommand("SELECT Book_ID AS 'Book ID', Title AS 'Title', Author AS 'Author', Publisher AS 'Publisher', ISBN AS 'ISBN', Genre AS 'Genre' FROM Books WHERE Book_ID NOT IN (SELECT Book_ID FROM Issued)", conn);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);

            admIssueDataGridView.DataSource = ds.Tables[0];
            admIssueDataGridView.ReadOnly = true;
        }

        public void clearFields()
        {
            admIssueSearchQueryTextBox.Text = string.Empty;
            admIssueMemberIDTextBox.Text = string.Empty;
            amdIssueBookIDTextBox.Text = string.Empty;
        }

        private void admIssueDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.RowIndex != admIssueDataGridView.Rows.Count - 1)
            {
                amdIssueBookIDTextBox.Text = Convert.ToString(admIssueDataGridView.Rows[e.RowIndex].Cells[0].Value);
            }
        }

        private void admIssue_Issuebtn_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            int Member_ID = 0;
            int Book_ID = 0;
            string Date_Issued = DateTime.Now.ToString();

            bool preliminaryAcceptedState = true;

            try
            {
                Member_ID = int.Parse(admIssueMemberIDTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Member ID should be an integer.", "WARNING");
                preliminaryAcceptedState = false;
            }
            try
            {
                Book_ID = int.Parse(amdIssueBookIDTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Book ID should be an integer.", "WARNING");
                preliminaryAcceptedState = false;
            }

            cmd = new SqlCommand("SELECT * FROM Issued WHERE Member_ID = @Member_ID", conn);
            cmd.Parameters.AddWithValue("@Member_ID", Member_ID);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);

            int rows = ds.Tables[0].Rows.Count;

            if (rows >= 2)
            {
                MessageBox.Show("Cannot issue more books.\nA Member can only issue 2 books.", "WARNING");
                preliminaryAcceptedState = false;
            }

            cmd = new SqlCommand("SELECT * FROM Issued WHERE Book_ID = @Book_ID", conn);
            cmd.Parameters.AddWithValue("@Book_ID", Book_ID);
            SqlDataAdapter dataAdapter1 = new SqlDataAdapter(cmd);
            DataSet ds1 = new DataSet();
            dataAdapter1.Fill(ds1);

            int rows1 = ds1.Tables[0].Rows.Count;

            if (rows1 > 0)
            {
                MessageBox.Show("The book has already been issued by someone else.\nCannot issue book.", "WARNING");
                preliminaryAcceptedState = false;
            }

            if (preliminaryAcceptedState == true)
            {
                try
                {
                    cmd = new SqlCommand("INSERT INTO Issued VALUES(@Member_ID, @Book_ID, @Date_Issued)", conn);
                    cmd.Parameters.AddWithValue("@Member_ID", Member_ID);
                    cmd.Parameters.AddWithValue("@Book_ID", Book_ID);
                    cmd.Parameters.AddWithValue("@Date_Issued", Date_Issued);

                    int result = cmd.ExecuteNonQuery();

                    if (result == 1)
                    {
                        MessageBox.Show("Book successfully issued.", "User Information");

                        PopupNotifier popup = new PopupNotifier
                        {
                            TitleText = "New Notification",
                            ContentText = "A  book  has  just  been  issued  by  a  member"
                        };
                        popup.Popup();

                        displayTable();
                        clearFields();
                    }
                }
                catch
                {
                    MessageBox.Show("Please make sure that the the Member ID and Book ID is valid.\nIf you still get an error then review the database.", "WARNING");
                }
            }

            if (conn.State == ConnectionState.Open)
                conn.Close();
        }

        private void admIssueSearchbtn_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            if (admIssueRbBoth.Checked == true)
            {
                cmd = new SqlCommand("SELECT Book_ID AS 'Book ID', Title AS 'Title', Author AS 'Author', Publisher AS 'Publisher', ISBN AS 'ISBN', Genre AS 'Genre' FROM Books WHERE ( Title LIKE @searchQuery OR Author LIKE @searchQuery ) AND Book_ID NOT IN ( SELECT Book_ID FROM Issued)", conn);
                cmd.Parameters.AddWithValue("@searchQuery", "%" + admIssueSearchQueryTextBox.Text + "%");

                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);

                admIssueDataGridView.DataSource = ds.Tables[0];
            }
            else if (admIssueRbTitle.Checked == true)
            {
                cmd = new SqlCommand("SELECT Book_ID AS 'Book ID', Title AS 'Title', Author AS 'Author', Publisher AS 'Publisher', ISBN AS 'ISBN', Genre AS 'Genre' FROM Books WHERE Title LIKE @searchQuery AND Book_ID NOT IN ( SELECT Book_ID FROM Issued)", conn);
                cmd.Parameters.AddWithValue("@searchQuery", "%" + admIssueSearchQueryTextBox.Text + "%");

                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);

                admIssueDataGridView.DataSource = ds.Tables[0];
            }
            else if (admIssueRbAuthor.Checked == true)
            {
                cmd = new SqlCommand("SELECT Book_ID AS 'Book ID', Title AS 'Title', Author AS 'Author', Publisher AS 'Publisher', ISBN AS 'ISBN', Genre AS 'Genre' FROM Books WHERE Author LIKE @searchQuery AND Book_ID NOT IN ( SELECT Book_ID FROM Issued)", conn);
                cmd.Parameters.AddWithValue("@searchQuery", "%" + admIssueSearchQueryTextBox.Text + "%");

                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);

                admIssueDataGridView.DataSource = ds.Tables[0];
            }

            if (conn.State == ConnectionState.Open)
                conn.Close();
        }

        private void admIssueBackbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            admStartPage _admStartPage = new admStartPage();
            _admStartPage.Show();
        }

        private void admIssueLogoutbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            login log = new login();
            log.Show();
        }
    }
}
