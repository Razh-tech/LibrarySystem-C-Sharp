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

namespace LibraryManagementSystem
{
    public partial class changePassword : Form
    {
        SqlConnection conn;
        SqlCommand cmd;

        public string Email;
        public string Password;

        public changePassword()
        {
            InitializeComponent();
        }

        private void changePassword_Load(object sender, EventArgs e)
        {
            clear();

            Email = login.Email;
            Password = login.Password;

            string connectionString = ("Data Source = SMIJOG1\\SQLEXPRESS01; Initial Catalog = LibraryDB; Integrated Security = True");
            conn = new SqlConnection(connectionString);
        }

        public void clear()
        {
            changePassCurrPassTextBox.Text = string.Empty;
            changePassNewPassTextBox.Text = string.Empty;
            changePassConfirmPassTextBox.Text = string.Empty;
        }

        private void changePassCancelbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            login log = new login();
            log.Show();
        }

        private void changePassSubmitbtn_Click(object sender, EventArgs e)
        {
            if (Password == changePassCurrPassTextBox.Text)
            {
                if (changePassNewPassTextBox.Text == changePassConfirmPassTextBox.Text)
                {
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();

                    cmd = new SqlCommand("UPDATE Employees SET Password = @Password WHERE Employee_ID = @Employee_ID", conn);
                    cmd.Parameters.AddWithValue("@Password", changePassNewPassTextBox.Text);
                    cmd.Parameters.AddWithValue("@Employee_ID", Email);

                    int result = cmd.ExecuteNonQuery();

                    if (result == 1)
                    {
                        MessageBox.Show("Password successfully updated.\nPlease login with the new credentials on the new screen.", "User Information");

                        this.Hide();
                        login log = new login();
                        log.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Please make sure the new password is different than the current password.", "WARNING");
                }

                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
            else
            {
                MessageBox.Show("Please make sure the 'current password' matches your current password.", "WARNING");
            }
        }
    }
}
