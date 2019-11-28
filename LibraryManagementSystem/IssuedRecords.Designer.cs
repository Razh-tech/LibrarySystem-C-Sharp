namespace LibraryManagementSystem
{
    partial class IssuedRecords
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
            this.IssuedRecordsBackbtn = new System.Windows.Forms.Button();
            this.IssuedRecordsLogoutbtn = new System.Windows.Forms.Button();
            this.IssuedRecordsDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IssuedRecordsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.IssuedRecordsDataGridView);
            this.panel1.Controls.Add(this.IssuedRecordsLogoutbtn);
            this.panel1.Controls.Add(this.IssuedRecordsBackbtn);
            this.panel1.Location = new System.Drawing.Point(67, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1314, 703);
            this.panel1.TabIndex = 0;
            // 
            // IssuedRecordsBackbtn
            // 
            this.IssuedRecordsBackbtn.BackColor = System.Drawing.Color.LightSlateGray;
            this.IssuedRecordsBackbtn.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IssuedRecordsBackbtn.Location = new System.Drawing.Point(18, 22);
            this.IssuedRecordsBackbtn.Name = "IssuedRecordsBackbtn";
            this.IssuedRecordsBackbtn.Size = new System.Drawing.Size(75, 35);
            this.IssuedRecordsBackbtn.TabIndex = 34;
            this.IssuedRecordsBackbtn.Text = "Back";
            this.IssuedRecordsBackbtn.UseVisualStyleBackColor = false;
            this.IssuedRecordsBackbtn.Click += new System.EventHandler(this.IssuedRecordsBackbtn_Click);
            // 
            // IssuedRecordsLogoutbtn
            // 
            this.IssuedRecordsLogoutbtn.BackColor = System.Drawing.Color.LightSlateGray;
            this.IssuedRecordsLogoutbtn.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IssuedRecordsLogoutbtn.Location = new System.Drawing.Point(1219, 22);
            this.IssuedRecordsLogoutbtn.Name = "IssuedRecordsLogoutbtn";
            this.IssuedRecordsLogoutbtn.Size = new System.Drawing.Size(75, 35);
            this.IssuedRecordsLogoutbtn.TabIndex = 35;
            this.IssuedRecordsLogoutbtn.Text = "Logout";
            this.IssuedRecordsLogoutbtn.UseVisualStyleBackColor = false;
            this.IssuedRecordsLogoutbtn.Click += new System.EventHandler(this.IssuedRecordsLogoutbtn_Click);
            // 
            // IssuedRecordsDataGridView
            // 
            this.IssuedRecordsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.IssuedRecordsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.IssuedRecordsDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.IssuedRecordsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.IssuedRecordsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.IssuedRecordsDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.IssuedRecordsDataGridView.Location = new System.Drawing.Point(362, 183);
            this.IssuedRecordsDataGridView.Name = "IssuedRecordsDataGridView";
            this.IssuedRecordsDataGridView.Size = new System.Drawing.Size(550, 484);
            this.IssuedRecordsDataGridView.TabIndex = 36;
            // 
            // IssuedRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.panel1);
            this.Name = "IssuedRecords";
            this.Text = "IssuedRecords";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.IssuedRecords_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IssuedRecordsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button IssuedRecordsBackbtn;
        private System.Windows.Forms.Button IssuedRecordsLogoutbtn;
        private System.Windows.Forms.DataGridView IssuedRecordsDataGridView;
    }
}