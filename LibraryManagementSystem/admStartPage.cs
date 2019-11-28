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
    public partial class admStartPage : Form
    {

        public admStartPage()
        {
            InitializeComponent();
        }

        private void admStartPage_Load(object sender, EventArgs e)
        {

        }

        private void admStartPageLogoutbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            login log = new login();
            log.Show();
        }

        private void admStartPageChangePasswordbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            changePassword changePass = new changePassword();
            changePass.Show();
        }

        private void admStartPageBookSearchbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            admBookSearch _admBookSearch = new admBookSearch();
            _admBookSearch.Show();
        }

        private void admStartPageEditBookDBbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            admEditBookDB editBookDB = new admEditBookDB();
            editBookDB.Show();
        }

        private void admStartPageEditMemberDBbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            admEditMemberDB editCustomerDB = new admEditMemberDB();
            editCustomerDB.Show();
        }

        private void admStartPageIssuebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            admIssue _admIssue = new admIssue();
            _admIssue.Show();
        }

        private void admStartPageReturnbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            admReturn _admReturn = new admReturn();
            _admReturn.Show();
        }

        private void admStartPageRecordsbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            IssuedRecords issuedRecords = new IssuedRecords();
            issuedRecords.Show();
        }
    }
}
