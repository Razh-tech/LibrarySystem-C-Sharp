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
    public partial class admEditMemberDB : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        
        int selected_user_id;

        private void admEditMemberDB_Load(object sender, EventArgs e)
        {
            displayUsers();
        }

        public admEditMemberDB()
        {
            InitializeComponent();
        }

        public void displayUsers()
        {
            string connectionString = ("Data Source = SMIJOG1\\SQLEXPRESS01; Initial Catalog = LibraryDB; Integrated Security = True");
            conn = new SqlConnection(connectionString);

            cmd = new SqlCommand("SELECT * FROM Customers ORDER BY Member_ID ASC", conn);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);

            editMemberDBDataGridView.DataSource = ds.Tables[0];
            editMemberDBDataGridView.ReadOnly = true;
            editMemberDBDataGridView.Columns[1].SortMode = DataGridViewColumnSortMode.Automatic;
        }

        public void clearFields()
        {
            editMemberDBMemberIDTextBox.Text = string.Empty;
            editMemberDBNameTextBox.Text = string.Empty;
            editMemberDBAddressTextBox.Text = string.Empty;
            editMemberDBEmailTextBox.Text = string.Empty;
            editMemberDBContactTextBox.Text = string.Empty;
            editMemberDBTypeTextBox.Text = string.Empty;
        }

        private void editMemberDBBackbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            admStartPage _admStartPage = new admStartPage();
            _admStartPage.Show();
        }

        private void editMemberDBLogoutbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            login log = new login();
            log.Show();
        }

        private void editMemberDBSearchbtn_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            try
            {
                int Search_ID = int.Parse(editStudentDBSearchTextbox.Text);
                cmd = new SqlCommand("SELECT * FROM Customers WHERE Member_ID = @searchQuery", conn);
                cmd.Parameters.AddWithValue("@searchQuery", Search_ID);
            }
            catch
            {
                cmd = new SqlCommand("SELECT * FROM Customers WHERE Name LIKE @searchQuery", conn);
                cmd.Parameters.AddWithValue("@searchQuery", "%" + editStudentDBSearchTextbox.Text + "%");
            }

            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);

            editMemberDBDataGridView.DataSource = ds.Tables[0];

            if (conn.State == ConnectionState.Open)
                conn.Close();
        }

        private void editMemberDBDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.RowIndex != editMemberDBDataGridView.Rows.Count - 1)
            {
                selected_user_id = Convert.ToInt32(editMemberDBDataGridView.Rows[e.RowIndex].Cells[0].Value);
                string Name = Convert.ToString(editMemberDBDataGridView.Rows[e.RowIndex].Cells[1].Value);
                string Address = Convert.ToString(editMemberDBDataGridView.Rows[e.RowIndex].Cells[2].Value);
                string Contact = Convert.ToString(editMemberDBDataGridView.Rows[e.RowIndex].Cells[3].Value);
                string Email = Convert.ToString(editMemberDBDataGridView.Rows[e.RowIndex].Cells[4].Value);
                string Type = Convert.ToString(editMemberDBDataGridView.Rows[e.RowIndex].Cells[5].Value);

                editMemberDBMemberIDTextBox.Text = Convert.ToString(selected_user_id);
                editMemberDBNameTextBox.Text = Name;
                editMemberDBAddressTextBox.Text = Address;
                editMemberDBContactTextBox.Text = Contact;
                editMemberDBEmailTextBox.Text = Email;
                editMemberDBTypeTextBox.Text = Type;
            }
        }

        private void editMemberDBClearbtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void editMemberDBUpdatebtn_Click(object sender, EventArgs e)
        {
            int Member_ID = 0;
            string Name;
            string Address;
            string Contact;
            string Email;
            string Type;

            bool preliminaryAcceptedState = true;

            if (conn.State == ConnectionState.Closed)
                conn.Open();

            try
            {
                Member_ID = Convert.ToInt32(editMemberDBMemberIDTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Please make sure that the Member ID is an integer.", "WARNING");
                preliminaryAcceptedState = false;
            }

            Name = editMemberDBNameTextBox.Text;
            Address = editMemberDBAddressTextBox.Text;
            Contact = editMemberDBContactTextBox.Text;
            Email = editMemberDBEmailTextBox.Text;
            Type = editMemberDBTypeTextBox.Text;

            if (preliminaryAcceptedState == true)
            {
                try
                {
                    cmd = new SqlCommand("UPDATE Customers SET Member_ID = @Member_ID, Name = @Name, Address = @Address, Contact = @Contact, Email = @Email, Type = @Type WHERE Member_ID = @selected_user_id", conn);
                    cmd.Parameters.AddWithValue("@Member_ID", Member_ID);
                    cmd.Parameters.AddWithValue("@Name", Name);
                    cmd.Parameters.AddWithValue("@Address", Address);
                    cmd.Parameters.AddWithValue("@Contact", Contact);
                    cmd.Parameters.AddWithValue("@Email", Email);
                    cmd.Parameters.AddWithValue("@Type", Type);
                    cmd.Parameters.AddWithValue("@selected_user_id", selected_user_id);

                    int result = cmd.ExecuteNonQuery();
                    if (result == 1)
                    {
                        MessageBox.Show("Changes successfully saved.", "User Information");

                        PopupNotifier popup = new PopupNotifier
                        {
                            TitleText = "New Notification",
                            ContentText = "A  member  database  has  just  been  updated"
                        };
                        popup.Popup();

                        clearFields();
                    }

                    displayUsers();
                }
                catch
                {
                    MessageBox.Show("There is already a member with this Member ID.\nMember ID's have to be distinct.", "WARNING");
                }
            }

            if (conn.State == ConnectionState.Open)
                conn.Close();
        }

        private void editMemberDBInsertbtn_Click(object sender, EventArgs e)
        {
            int Member_ID = 0;
            string Name;
            string Address;
            string Contact;
            string Email;
            string Type;

            bool preliminaryAcceptedState = true;

            if (conn.State == ConnectionState.Closed)
                conn.Open();

            try
            {
                Member_ID = Convert.ToInt32(editMemberDBMemberIDTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Please make sure that the Member ID is an integer.", "WARNING");
                preliminaryAcceptedState = false;
            }
            Name = editMemberDBNameTextBox.Text;
            Address = editMemberDBAddressTextBox.Text;
            Contact = editMemberDBContactTextBox.Text;
            Email = editMemberDBEmailTextBox.Text;
            Type = editMemberDBTypeTextBox.Text;

            if (preliminaryAcceptedState == true)
            {
                try
                {
                    cmd = new SqlCommand("INSERT INTO Customers VALUES(@Member_ID, @Name, @Address, @Contact, @Email, @Type)", conn);
                    cmd.Parameters.AddWithValue("@Member_ID", Member_ID);
                    cmd.Parameters.AddWithValue("@Name", Name);
                    cmd.Parameters.AddWithValue("@Address", Address);
                    cmd.Parameters.AddWithValue("@Contact", Contact);
                    cmd.Parameters.AddWithValue("@Email", Email);
                    cmd.Parameters.AddWithValue("@Type", Type);

                    int result = cmd.ExecuteNonQuery();
                    if (result == 1)
                    {
                        MessageBox.Show("Member successfully added.", "User Information");

                        PopupNotifier popup = new PopupNotifier
                        {
                            TitleText = "New Notification",
                            ContentText = "A  new  member  has  just  been  added  to  the  database"
                        };
                        popup.Popup();

                        clearFields();
                    }

                    displayUsers();
                }
                catch
                {
                    MessageBox.Show("There is already a member with this member ID.\nMember ID's have to be distinct.", "WARNING");
                }
            }

            if (conn.State == ConnectionState.Open)
                conn.Close();
        }

        private void editMemberDBDeletebtn_Click(object sender, EventArgs e)
        {
            int Member_ID = 0;

            bool preliminaryAcceptedState = true;

            if (conn.State == ConnectionState.Closed)
                conn.Open();

            try
            {
                Member_ID = Convert.ToInt32(editMemberDBMemberIDTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Please make sure that the Member ID is an integer.", "WARNING");
                preliminaryAcceptedState = false;
            }

            if (preliminaryAcceptedState == true)
            {
                try
                {
                    cmd = new SqlCommand("DELETE FROM Customers WHERE Member_ID = @Member_ID", conn);
                    cmd.Parameters.AddWithValue("@Member_ID", Member_ID);

                    int result = cmd.ExecuteNonQuery();

                    if (result == 1)
                    {
                        MessageBox.Show("Member successfully deleted.", "User Information");

                        PopupNotifier popup = new PopupNotifier
                        {
                            TitleText = "New Notification",
                            ContentText = "A  member  has  just  been  deleted  from  database"
                        };
                        popup.Popup();

                        clearFields();
                    }

                    displayUsers();
                }
                catch
                {
                    MessageBox.Show("Cannot delete a member with an issued book.\nPlease make sure that he/she has returned the book before deleting its database.", "WARNING");
                }
            }

            if (conn.State == ConnectionState.Open)
                conn.Close();
        }
    }
}
