namespace LibraryManagementSystem
{
    partial class ListBooks
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
            this.ListBooksDataGridView = new System.Windows.Forms.DataGridView();
            this.ListBooksLogoutbtn = new System.Windows.Forms.Button();
            this.ListBooks_Searchbtn = new System.Windows.Forms.Button();
            this.ListBooksRbBoth = new System.Windows.Forms.RadioButton();
            this.ListBooksRbAuthor = new System.Windows.Forms.RadioButton();
            this.ListBooksRbTitle = new System.Windows.Forms.RadioButton();
            this.ListBooksTbxQuery = new System.Windows.Forms.TextBox();
            this.Searchlbl = new System.Windows.Forms.Label();
            this.ListBooksBackbtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListBooksDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ListBooksDataGridView);
            this.panel1.Controls.Add(this.ListBooksLogoutbtn);
            this.panel1.Controls.Add(this.ListBooks_Searchbtn);
            this.panel1.Controls.Add(this.ListBooksRbBoth);
            this.panel1.Controls.Add(this.ListBooksRbAuthor);
            this.panel1.Controls.Add(this.ListBooksRbTitle);
            this.panel1.Controls.Add(this.ListBooksTbxQuery);
            this.panel1.Controls.Add(this.Searchlbl);
            this.panel1.Controls.Add(this.ListBooksBackbtn);
            this.panel1.Location = new System.Drawing.Point(67, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1314, 703);
            this.panel1.TabIndex = 0;
            // 
            // ListBooksDataGridView
            // 
            this.ListBooksDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ListBooksDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ListBooksDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListBooksDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ListBooksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ListBooksDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.ListBooksDataGridView.Location = new System.Drawing.Point(20, 187);
            this.ListBooksDataGridView.Name = "ListBooksDataGridView";
            this.ListBooksDataGridView.Size = new System.Drawing.Size(1274, 484);
            this.ListBooksDataGridView.TabIndex = 42;
            // 
            // ListBooksLogoutbtn
            // 
            this.ListBooksLogoutbtn.BackColor = System.Drawing.Color.LightSlateGray;
            this.ListBooksLogoutbtn.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBooksLogoutbtn.Location = new System.Drawing.Point(1219, 22);
            this.ListBooksLogoutbtn.Name = "ListBooksLogoutbtn";
            this.ListBooksLogoutbtn.Size = new System.Drawing.Size(75, 35);
            this.ListBooksLogoutbtn.TabIndex = 41;
            this.ListBooksLogoutbtn.Text = "Logout";
            this.ListBooksLogoutbtn.UseVisualStyleBackColor = false;
            this.ListBooksLogoutbtn.Click += new System.EventHandler(this.ListBooksLogoutbtn_Click);
            // 
            // ListBooks_Searchbtn
            // 
            this.ListBooks_Searchbtn.BackColor = System.Drawing.Color.LightSlateGray;
            this.ListBooks_Searchbtn.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBooks_Searchbtn.Location = new System.Drawing.Point(423, 101);
            this.ListBooks_Searchbtn.Name = "ListBooks_Searchbtn";
            this.ListBooks_Searchbtn.Size = new System.Drawing.Size(88, 33);
            this.ListBooks_Searchbtn.TabIndex = 40;
            this.ListBooks_Searchbtn.Text = "Search";
            this.ListBooks_Searchbtn.UseVisualStyleBackColor = false;
            this.ListBooks_Searchbtn.Click += new System.EventHandler(this.ListBooks_Searchbtn_Click);
            // 
            // ListBooksRbBoth
            // 
            this.ListBooksRbBoth.AutoSize = true;
            this.ListBooksRbBoth.Font = new System.Drawing.Font("Indie Flower", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBooksRbBoth.Location = new System.Drawing.Point(276, 101);
            this.ListBooksRbBoth.Name = "ListBooksRbBoth";
            this.ListBooksRbBoth.Size = new System.Drawing.Size(60, 28);
            this.ListBooksRbBoth.TabIndex = 39;
            this.ListBooksRbBoth.TabStop = true;
            this.ListBooksRbBoth.Text = "Both";
            this.ListBooksRbBoth.UseVisualStyleBackColor = true;
            // 
            // ListBooksRbAuthor
            // 
            this.ListBooksRbAuthor.AutoSize = true;
            this.ListBooksRbAuthor.Font = new System.Drawing.Font("Indie Flower", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBooksRbAuthor.Location = new System.Drawing.Point(195, 101);
            this.ListBooksRbAuthor.Name = "ListBooksRbAuthor";
            this.ListBooksRbAuthor.Size = new System.Drawing.Size(71, 28);
            this.ListBooksRbAuthor.TabIndex = 38;
            this.ListBooksRbAuthor.TabStop = true;
            this.ListBooksRbAuthor.Text = "Author";
            this.ListBooksRbAuthor.UseVisualStyleBackColor = true;
            // 
            // ListBooksRbTitle
            // 
            this.ListBooksRbTitle.AutoSize = true;
            this.ListBooksRbTitle.Font = new System.Drawing.Font("Indie Flower", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBooksRbTitle.Location = new System.Drawing.Point(133, 101);
            this.ListBooksRbTitle.Name = "ListBooksRbTitle";
            this.ListBooksRbTitle.Size = new System.Drawing.Size(55, 28);
            this.ListBooksRbTitle.TabIndex = 37;
            this.ListBooksRbTitle.TabStop = true;
            this.ListBooksRbTitle.Text = "Title";
            this.ListBooksRbTitle.UseVisualStyleBackColor = true;
            // 
            // ListBooksTbxQuery
            // 
            this.ListBooksTbxQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBooksTbxQuery.Location = new System.Drawing.Point(133, 72);
            this.ListBooksTbxQuery.Name = "ListBooksTbxQuery";
            this.ListBooksTbxQuery.Size = new System.Drawing.Size(378, 23);
            this.ListBooksTbxQuery.TabIndex = 36;
            // 
            // Searchlbl
            // 
            this.Searchlbl.AutoSize = true;
            this.Searchlbl.Font = new System.Drawing.Font("Indie Flower", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchlbl.Location = new System.Drawing.Point(14, 75);
            this.Searchlbl.Name = "Searchlbl";
            this.Searchlbl.Size = new System.Drawing.Size(118, 24);
            this.Searchlbl.TabIndex = 35;
            this.Searchlbl.Text = "Search Books:";
            // 
            // ListBooksBackbtn
            // 
            this.ListBooksBackbtn.BackColor = System.Drawing.Color.LightSlateGray;
            this.ListBooksBackbtn.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBooksBackbtn.Location = new System.Drawing.Point(18, 22);
            this.ListBooksBackbtn.Name = "ListBooksBackbtn";
            this.ListBooksBackbtn.Size = new System.Drawing.Size(75, 35);
            this.ListBooksBackbtn.TabIndex = 34;
            this.ListBooksBackbtn.Text = "Back";
            this.ListBooksBackbtn.UseVisualStyleBackColor = false;
            this.ListBooksBackbtn.Click += new System.EventHandler(this.ListBooksBackbtn_Click);
            // 
            // ListBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.panel1);
            this.Name = "ListBooks";
            this.Text = "ListBooks";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ListBooks_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListBooksDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ListBooksBackbtn;
        private System.Windows.Forms.Label Searchlbl;
        private System.Windows.Forms.TextBox ListBooksTbxQuery;
        private System.Windows.Forms.RadioButton ListBooksRbTitle;
        private System.Windows.Forms.RadioButton ListBooksRbAuthor;
        private System.Windows.Forms.RadioButton ListBooksRbBoth;
        private System.Windows.Forms.Button ListBooks_Searchbtn;
        private System.Windows.Forms.Button ListBooksLogoutbtn;
        private System.Windows.Forms.DataGridView ListBooksDataGridView;
    }
}