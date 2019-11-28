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
    public partial class admReturn : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlCommand records;
        SqlCommand returnedDate;

        public admReturn()
        {
            InitializeComponent();
        }

        private void admReturn_Load(object sender, EventArgs e)
        {
            string connectionString = ("Data Source = SMIJOG1\\SQLEXPRESS01; Initial Catalog = LibraryDB; Integrated Security = True");
            conn = new SqlConnection(connectionString);

            displayTable();
        }

        public void clear()
        {
            admReturnTbxSearchQuery.Text = string.Empty;
            admReturnMemberIDTextBox.Text = string.Empty;
            admReturnBookIDTextBox.Text = string.Empty;
            admReturnBooksLblFine.Text = string.Empty;
        }

        public void displayTable()
        {
            cmd = new SqlCommand("SELECT Issued.Member_ID, Customers.Name, Issued.Book_ID, Books.Title, Issued.Date_Issued, DATEDIFF(day, Date_Issued, CONVERT(date, GETDATE())) AS 'Days Passed' From Issued Inner Join Books On Books.Book_ID = Issued.Book_ID Inner Join Customers On Customers.Member_ID = Issued.Member_ID", conn);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);

            admReturnDataGridView.DataSource = ds.Tables[0];
            admReturnDataGridView.ReadOnly = true;
        }

        private void admReturnDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.RowIndex != admReturnDataGridView.Rows.Count - 1)
            {
                admReturnBookIDTextBox.Text = Convert.ToString(admReturnDataGridView.Rows[e.RowIndex].Cells[2].Value);
                admReturnMemberIDTextBox.Text = Convert.ToString(admReturnDataGridView.Rows[e.RowIndex].Cells[0].Value);

                int fine = 0;
                int days_passed = Convert.ToInt32(admReturnDataGridView.Rows[e.RowIndex].Cells[5].Value);

                if (days_passed > 7)
                {
                    fine = days_passed - 7;
                }

                admReturnFineTextBox.Text = Convert.ToString("Rp. " + (500 * fine));
            }
        }

        private void admReturnSearchbtn_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            try
            {
                if (admReturnTbxSearchQuery.Text == string.Empty)
                {
                    displayTable();
                }
                else
                {
                    cmd = new SqlCommand("SELECT Issued.Member_ID, Customers.Name, Issued.Book_ID, Books.Title, Issued.Date_Issued, DATEDIFF(day, Date_Issued, CONVERT(date, GETDATE())) AS 'Days Passed' From Issued Inner Join Books On Books.Book_ID = Issued.Book_ID Inner Join Customers On Customers.Member_ID = Issued.Member_ID", conn);
                    cmd.Parameters.AddWithValue("@searchQuery", Convert.ToInt32(admReturnTbxSearchQuery.Text));

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    dataAdapter.Fill(ds);

                    admReturnDataGridView.DataSource = ds.Tables[0];
                }
            }
            catch
            {
                MessageBox.Show("Please make sure that you enter only an integer in the search box.", "WARNING");
            }

            if (conn.State == ConnectionState.Open)
                conn.Close();
        }

        private void admReturnReturnbtn_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            int Book_ID = 0;
            int Member_ID = 0;
            string Date_Returned = DateTime.Now.ToString();

            bool preliminaryAcceptedState = true;

            try
            {
                Book_ID = int.Parse(admReturnBookIDTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Book ID should be an integer.", "WARNING");
                preliminaryAcceptedState = false;
            }

            try
            {
                Member_ID = int.Parse(admReturnMemberIDTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Member ID should be an integer.", "WARNING");
                preliminaryAcceptedState = false;
            }

            if (preliminaryAcceptedState == true)
            {
                try
                {
                    records = new SqlCommand ("INSERT INTO Records(Member_ID, Book_ID, Date_Issued) SELECT * FROM Issued WHERE Member_ID = @Member_ID", conn);
                    records.Parameters.AddWithValue("@Member_ID", admReturnMemberIDTextBox.Text);
                    records.ExecuteNonQuery();

                    returnedDate = new SqlCommand("INSERT INTO ReturnedDate VALUES(@Date_Returned)", conn);
                    returnedDate.Parameters.AddWithValue("@Date_Returned", Date_Returned);
                    returnedDate.ExecuteNonQuery();

                    cmd = new SqlCommand("DELETE FROM Issued WHERE Book_ID = @Book_ID AND Member_ID = @Member_ID", conn);
                    cmd.Parameters.AddWithValue("@Book_ID", Book_ID);
                    cmd.Parameters.AddWithValue("@Member_ID", Member_ID);

                    int result = cmd.ExecuteNonQuery();

                    if (result == 0)
                    {
                        MessageBox.Show("Please enter a valid Member ID and Book ID.\nInvalid Input.", "WARNING");
                    }

                    if (result == 1)
                    {
                        MessageBox.Show("Book successfully returned.", "User Information");

                        PopupNotifier popup = new PopupNotifier
                        {
                            TitleText = "New Notification",
                            ContentText = "A  book  has  just  been  returned  by  a  member"
                        };
                        popup.Popup();

                        clear();
                        displayTable();
                    }
                }
                catch
                {
                    MessageBox.Show("Internal system error.\nPlease contact the manager.", "WARNING");
                }
            }

            if (conn.State == ConnectionState.Open)
                conn.Close();
        }

        private void admReturnBooksBackbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            admStartPage _admStartPage = new admStartPage();
            _admStartPage.Show();
        }

        private void admReturnBooksLogoutbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            login log = new login();
            log.Show();
        }
    }
}
