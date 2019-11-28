using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class managerStartPage : Form
    {
        public managerStartPage()
        {
            InitializeComponent();
        }

        private void managerStartPageListofBooksbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListBooks listBooks = new ListBooks();
            listBooks.Show();
        }

        private void managerStartPageListofMemberbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListMembers listMembers = new ListMembers();
            listMembers.Show();
        }

        private void managerStartPageChangePasswordbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            changePassword changePass = new changePassword();
            changePass.Show();
        }

        private void managerStartPageLogoutbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerLogin log = new ManagerLogin();
            log.Show();
        }

        private void managerStartPageRecordsbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerRecordsList managerRecordsList = new ManagerRecordsList();
            managerRecordsList.Show();
        }
    }
}
