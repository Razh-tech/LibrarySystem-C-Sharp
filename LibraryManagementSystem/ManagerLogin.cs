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
    public partial class ManagerLogin : Form
    {
        SqlConnection conn;
        SqlCommand cmd;

        public static string Email;
        public static string Password;

        public ManagerLogin()
        {
            InitializeComponent();
        }

        private void ManagerLogin_Load(object sender, EventArgs e)
        {
            string connectionString = ("Data Source = SMIJOG1\\SQLEXPRESS01; Initial Catalog = LibraryDB; Integrated Security = True");
            conn = new SqlConnection(connectionString);
        }

        public void clear()
        {
            managerLogEmailTextBox.Text = string.Empty;
            managerLogPassTextBox.Text = string.Empty;
        }

        private void logAdminbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            login login = new login();
            login.Show();
        }

        private void ManagerLoginSubmitbtn_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            cmd = new SqlCommand("SELECT * FROM Employees WHERE Email = @Email AND Password = @Password AND Role = 'Manager'", conn);
            cmd.Parameters.AddWithValue("@Email", managerLogEmailTextBox.Text);
            cmd.Parameters.AddWithValue("@Password", managerLogPassTextBox.Text);

            string mail = managerLogEmailTextBox.Text;
            string Pass = managerLogPassTextBox.Text;

            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            dataAdapter.Fill(dt);
            try
            {
                if (dt.Rows.Count > 0)
                {
                    Email = managerLogEmailTextBox.Text;
                    Password = managerLogPassTextBox.Text;

                    if (mail == "" && Pass == "")
                    {
                        MessageBox.Show("Please provide your email and password!", "User Information");
                    }
                    else if (mail == "masterbruce@wayne.com" && Pass == "b4t4r4ng")
                    {
                        this.Hide();
                        managerStartPage managerStart = new managerStartPage();
                        managerStart.Show();
                    }
                    else
                    {
                        MessageBox.Show("Only Manager that can login through here.\nIf you're an admin, please login via 'Login as Admin'", "User Information");
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
