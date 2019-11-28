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
    public partial class ManagerRecordsList : Form
    {
        SqlConnection conn;
        SqlCommand cmd;

        public ManagerRecordsList()
        {
            InitializeComponent();
        }

        private void ManagerRecordsListBackbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            managerStartPage managerStartPage = new managerStartPage();
            managerStartPage.Show();
        }

        private void ManagerRecordsList_Load(object sender, EventArgs e)
        {
            string connectionString = ("Data Source = SMIJOG1\\SQLEXPRESS01; Initial Catalog = LibraryDB; Integrated Security = True");
            conn = new SqlConnection(connectionString);

            cmd = new SqlCommand("SELECT Records.Member_ID AS 'Member ID', Records.Book_ID AS 'Book ID', Records.Date_Issued AS 'Date Issued', ReturnedDate.Date_Returned AS 'Date Returned' FROM Records, ReturnedDate", conn);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);

            ManagerRecordsListDataGridView.DataSource = ds.Tables[0];
            ManagerRecordsListDataGridView.ReadOnly = true;
        }

        private void ManagerRecordsListLogoutbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerLogin managerLogin = new ManagerLogin();
            managerLogin.Show();
        }
    }
}
