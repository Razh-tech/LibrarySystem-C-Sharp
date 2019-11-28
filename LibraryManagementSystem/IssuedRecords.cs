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
    public partial class IssuedRecords : Form
    {
        SqlConnection conn;
        SqlCommand cmd;

        public IssuedRecords()
        {
            InitializeComponent();
        }

        private void IssuedRecordsBackbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            admStartPage _admStartPage = new admStartPage();
            _admStartPage.Show();
        }

        private void IssuedRecordsLogoutbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            login log = new login();
            log.Show();
        }

        private void IssuedRecords_Load(object sender, EventArgs e)
        {
            string connectionString = ("Data Source = SMIJOG1\\SQLEXPRESS01; Initial Catalog = LibraryDB; Integrated Security = True");
            conn = new SqlConnection(connectionString);

            cmd = new SqlCommand("SELECT Records.Member_ID AS 'Member ID', Records.Book_ID AS 'Book ID', Records.Date_Issued AS 'Date Issued', ReturnedDate.Date_Returned AS 'Date Returned' FROM Records, ReturnedDate", conn);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);

            IssuedRecordsDataGridView.DataSource = ds.Tables[0];
            IssuedRecordsDataGridView.ReadOnly = true;
        }
    }
}
