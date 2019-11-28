namespace LibraryManagementSystem
{
    partial class ManagerRecordsList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ManagerRecordsListBackbtn = new System.Windows.Forms.Button();
            this.ManagerRecordsListLogoutbtn = new System.Windows.Forms.Button();
            this.ManagerRecordsListDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ManagerRecordsListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ManagerRecordsListDataGridView);
            this.panel1.Controls.Add(this.ManagerRecordsListLogoutbtn);
            this.panel1.Controls.Add(this.ManagerRecordsListBackbtn);
            this.panel1.Location = new System.Drawing.Point(67, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1314, 703);
            this.panel1.TabIndex = 0;
            // 
            // ManagerRecordsListBackbtn
            // 
            this.ManagerRecordsListBackbtn.BackColor = System.Drawing.Color.LightSlateGray;
            this.ManagerRecordsListBackbtn.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManagerRecordsListBackbtn.Location = new System.Drawing.Point(18, 22);
            this.ManagerRecordsListBackbtn.Name = "ManagerRecordsListBackbtn";
            this.ManagerRecordsListBackbtn.Size = new System.Drawing.Size(75, 35);
            this.ManagerRecordsListBackbtn.TabIndex = 35;
            this.ManagerRecordsListBackbtn.Text = "Back";
            this.ManagerRecordsListBackbtn.UseVisualStyleBackColor = false;
            this.ManagerRecordsListBackbtn.Click += new System.EventHandler(this.ManagerRecordsListBackbtn_Click);
            // 
            // ManagerRecordsListLogoutbtn
            // 
            this.ManagerRecordsListLogoutbtn.BackColor = System.Drawing.Color.LightSlateGray;
            this.ManagerRecordsListLogoutbtn.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManagerRecordsListLogoutbtn.Location = new System.Drawing.Point(1219, 22);
            this.ManagerRecordsListLogoutbtn.Name = "ManagerRecordsListLogoutbtn";
            this.ManagerRecordsListLogoutbtn.Size = new System.Drawing.Size(75, 35);
            this.ManagerRecordsListLogoutbtn.TabIndex = 36;
            this.ManagerRecordsListLogoutbtn.Text = "Logout";
            this.ManagerRecordsListLogoutbtn.UseVisualStyleBackColor = false;
            this.ManagerRecordsListLogoutbtn.Click += new System.EventHandler(this.ManagerRecordsListLogoutbtn_Click);
            // 
            // ManagerRecordsListDataGridView
            // 
            this.ManagerRecordsListDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ManagerRecordsListDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ManagerRecordsListDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ManagerRecordsListDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.ManagerRecordsListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ManagerRecordsListDataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.ManagerRecordsListDataGridView.Location = new System.Drawing.Point(362, 183);
            this.ManagerRecordsListDataGridView.Name = "ManagerRecordsListDataGridView";
            this.ManagerRecordsListDataGridView.Size = new System.Drawing.Size(550, 484);
            this.ManagerRecordsListDataGridView.TabIndex = 37;
            // 
            // ManagerRecordsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1370, 747);
            this.Controls.Add(this.panel1);
            this.Name = "ManagerRecordsList";
            this.Text = "ManagerRecordsList";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ManagerRecordsList_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ManagerRecordsListDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ManagerRecordsListBackbtn;
        private System.Windows.Forms.Button ManagerRecordsListLogoutbtn;
        private System.Windows.Forms.DataGridView ManagerRecordsListDataGridView;
    }
}