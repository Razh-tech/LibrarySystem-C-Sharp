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
    public partial class login : Form
    {
        SqlConnection conn;
        SqlCommand cmd;

        public static string Email;
        public static string Password;

        private void login_Load(object sender, EventArgs e)
        {
            string connectionString = ("Data Source = SMIJOG1\\SQLEXPRESS01; Initial Catalog = LibraryDB; Integrated Security = True");
            conn = new SqlConnection(connectionString);
        }

        public login()
        {
            InitializeComponent();
        }

        public void clear()
        {
            loginEmailTextBox.Text = string.Empty;
            loginPassTextBox.Text = string.Empty;
        }

        private void logManagerbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerLogin managerLogin = new ManagerLogin();
            managerLogin.Show();
        }

        private void LoginSubmitbtn_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            cmd = new SqlCommand("SELECT * FROM Employees WHERE Email = @Email AND Password = @Password AND Role = 'Admin'", conn);
            cmd.Parameters.AddWithValue("@Email", loginEmailTextBox.Text);
            cmd.Parameters.AddWithValue("@Password", loginPassTextBox.Text);

            string mail = loginEmailTextBox.Text;
            string Pass = loginPassTextBox.Text;

            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            dataAdapter.Fill(dt);
            try
            {
                if (dt.Rows.Count > 0)
                {
                    Email = loginEmailTextBox.Text;
                    Password = loginPassTextBox.Text;

                    if (mail == "" && Pass == "")
                    {
                        MessageBox.Show("Please provide your email and password!");
                    }
                    else if (mail == "masterbruce@wayne.com" && Pass == "b4t4r4ng")
                    {
                        MessageBox.Show("Only Admin that can login through here.\nIf you're a manager, please login via 'Login as Manager'", "User Information");
                    }
                    else
                    {
                        this.Hide();
                        admStartPage admStartPage = new admStartPage();
                        admStartPage.Show();
                    }
                }
                else
                {
                    MessageBox.Show("The entered EMAIL or PASSWORD is WRONG.\nPlease check and try again.\nIf you have forgotten the password then please remember it.", "User Information");
                    clear();
                }
            }
            catch (NullReferenceException)
            {
                throw new NullReferenceException();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            if (conn.State == ConnectionState.Open)
                conn.Close();
        }
    }
}
