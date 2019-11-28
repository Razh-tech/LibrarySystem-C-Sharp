namespace LibraryManagementSystem
{
    partial class ListMembers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ListMembersDataGridView = new System.Windows.Forms.DataGridView();
            this.Searchlbl = new System.Windows.Forms.Label();
            this.ListMembersSearchbtn = new System.Windows.Forms.Button();
            this.ListMembersSearchTextbox = new System.Windows.Forms.TextBox();
            this.ListMembersLogoutbtn = new System.Windows.Forms.Button();
            this.ListMembersBackbtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListMembersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ListMembersDataGridView);
            this.panel1.Controls.Add(this.Searchlbl);
            this.panel1.Controls.Add(this.ListMembersSearchbtn);
            this.panel1.Controls.Add(this.ListMembersSearchTextbox);
            this.panel1.Controls.Add(this.ListMembersLogoutbtn);
            this.panel1.Controls.Add(this.ListMembersBackbtn);
            this.panel1.Location = new System.Drawing.Point(39, -36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1181, 717);
            this.panel1.TabIndex = 0;
            // 
            // ListMembersDataGridView
            // 
            this.ListMembersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ListMembersDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ListMembersDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListMembersDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ListMembersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ListMembersDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.ListMembersDataGridView.Location = new System.Drawing.Point(102, 206);
            this.ListMembersDataGridView.Name = "ListMembersDataGridView";
            this.ListMembersDataGridView.Size = new System.Drawing.Size(969, 342);
            this.ListMembersDataGridView.TabIndex = 66;
            // 
            // Searchlbl
            // 
            this.Searchlbl.AutoSize = true;
            this.Searchlbl.Font = new System.Drawing.Font("Indie Flower", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchlbl.Location = new System.Drawing.Point(99, 122);
            this.Searchlbl.Name = "Searchlbl";
            this.Searchlbl.Size = new System.Drawing.Size(174, 24);
            this.Searchlbl.TabIndex = 65;
            this.Searchlbl.Text = "Search (name or id) :";
            // 
            // ListMembersSearchbtn
            // 
            this.ListMembersSearchbtn.BackColor = System.Drawing.Color.LightSlateGray;
            this.ListMembersSearchbtn.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListMembersSearchbtn.Location = new System.Drawing.Point(689, 148);
            this.ListMembersSearchbtn.Name = "ListMembersSearchbtn";
            this.ListMembersSearchbtn.Size = new System.Drawing.Size(88, 33);
            this.ListMembersSearchbtn.TabIndex = 64;
            this.ListMembersSearchbtn.Text = "Search";
            this.ListMembersSearchbtn.UseVisualStyleBackColor = false;
            this.ListMembersSearchbtn.Click += new System.EventHandler(this.ListMembersSearchbtn_Click);
            // 
            // ListMembersSearchTextbox
            // 
            this.ListMembersSearchTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListMembersSearchTextbox.Location = new System.Drawing.Point(261, 119);
            this.ListMembersSearchTextbox.Name = "ListMembersSearchTextbox";
            this.ListMembersSearchTextbox.Size = new System.Drawing.Size(516, 23);
            this.ListMembersSearchTextbox.TabIndex = 63;
            // 
            // ListMembersLogoutbtn
            // 
            this.ListMembersLogoutbtn.BackColor = System.Drawing.Color.LightSlateGray;
            this.ListMembersLogoutbtn.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListMembersLogoutbtn.Location = new System.Drawing.Point(996, 80);
            this.ListMembersLogoutbtn.Name = "ListMembersLogoutbtn";
            this.ListMembersLogoutbtn.Size = new System.Drawing.Size(75, 35);
            this.ListMembersLogoutbtn.TabIndex = 44;
            this.ListMembersLogoutbtn.Text = "Logout";
            this.ListMembersLogoutbtn.UseVisualStyleBackColor = false;
            this.ListMembersLogoutbtn.Click += new System.EventHandler(this.ListMembersLogoutbtn_Click);
            // 
            // ListMembersBackbtn
            // 
            this.ListMembersBackbtn.BackColor = System.Drawing.Color.LightSlateGray;
            this.ListMembersBackbtn.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListMembersBackbtn.Location = new System.Drawing.Point(99, 63);
            this.ListMembersBackbtn.Name = "ListMembersBackbtn";
            this.ListMembersBackbtn.Size = new System.Drawing.Size(82, 35);
            this.ListMembersBackbtn.TabIndex = 43;
            this.ListMembersBackbtn.Text = "Back";
            this.ListMembersBackbtn.UseVisualStyleBackColor = false;
            this.ListMembersBackbtn.Click += new System.EventHandler(this.ListMembersBackbtn_Click);
            // 
            // ListMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1370, 747);
            this.Controls.Add(this.panel1);
            this.Name = "ListMembers";
            this.Text = "List Members";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ListMembers_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListMembersDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ListMembersBackbtn;
        private System.Windows.Forms.Button ListMembersLogoutbtn;
        private System.Windows.Forms.TextBox ListMembersSearchTextbox;
        private System.Windows.Forms.Button ListMembersSearchbtn;
        private System.Windows.Forms.Label Searchlbl;
        private System.Windows.Forms.DataGridView ListMembersDataGridView;
    }
}