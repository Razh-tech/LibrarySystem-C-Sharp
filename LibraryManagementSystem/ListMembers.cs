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
    public partial class ListMembers : Form
    {
        SqlConnection conn;
        SqlCommand cmd;

        public ListMembers()
        {
            InitializeComponent();
        }

        private void ListMembers_Load(object sender, EventArgs e)
        {
            displayUsers();
        }

        public void displayUsers()
        {
            string connectionString = ("Data Source = SMIJOG1\\SQLEXPRESS01; Initial Catalog = LibraryDB; Integrated Security = True");
            conn = new SqlConnection(connectionString);

            cmd = new SqlCommand("SELECT * FROM Customers ORDER BY Member_ID ASC", conn);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);

            ListMembersDataGridView.DataSource = ds.Tables[0];
            ListMembersDataGridView.ReadOnly = true;
            ListMembersDataGridView.Columns[1].SortMode = DataGridViewColumnSortMode.Automatic;
        }

        private void ListMembersBackbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            managerStartPage managerStart = new managerStartPage();
            managerStart.Show();
        }

        private void ListMembersLogoutbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerLogin log = new ManagerLogin();
            log.Show();
        }

        private void ListMembersSearchbtn_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            try
            {
                int Search_ID = int.Parse(ListMembersSearchTextbox.Text);
                cmd = new SqlCommand("SELECT * FROM Customers WHERE Member_ID = @searchQuery", conn);
                cmd.Parameters.AddWithValue("@searchQuery", Search_ID);
            }
            catch
            {
                cmd = new SqlCommand("SELECT * FROM Customers WHERE Name LIKE @searchQuery", conn);
                cmd.Parameters.AddWithValue("@searchQuery", "%" + ListMembersSearchTextbox.Text + "%");
            }

            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);

            ListMembersDataGridView.DataSource = ds.Tables[0];

            if (conn.State == ConnectionState.Open)
                conn.Close();
        }
    }
}
