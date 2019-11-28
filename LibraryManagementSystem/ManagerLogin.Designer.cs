namespace LibraryManagementSystem
{
    partial class ManagerLogin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.logAdminbtn = new System.Windows.Forms.Button();
            this.ManagerLoginSubmitbtn = new System.Windows.Forms.Button();
            this.loginLblPassword = new System.Windows.Forms.Label();
            this.loginLblUserId = new System.Windows.Forms.Label();
            this.managerLogEmailTextBox = new System.Windows.Forms.TextBox();
            this.managerLogPassTextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.logAdminbtn);
            this.panel1.Controls.Add(this.ManagerLoginSubmitbtn);
            this.panel1.Controls.Add(this.loginLblPassword);
            this.panel1.Controls.Add(this.loginLblUserId);
            this.panel1.Controls.Add(this.managerLogEmailTextBox);
            this.panel1.Controls.Add(this.managerLogPassTextBox);
            this.panel1.Location = new System.Drawing.Point(67, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(901, 559);
            this.panel1.TabIndex = 0;
            // 
            // logAdminbtn
            // 
            this.logAdminbtn.BackColor = System.Drawing.Color.LightSlateGray;
            this.logAdminbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.logAdminbtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logAdminbtn.Location = new System.Drawing.Point(512, 305);
            this.logAdminbtn.Margin = new System.Windows.Forms.Padding(0);
            this.logAdminbtn.Name = "logAdminbtn";
            this.logAdminbtn.Size = new System.Drawing.Size(136, 23);
            this.logAdminbtn.TabIndex = 13;
            this.logAdminbtn.Text = "Login as Admin";
            this.logAdminbtn.UseVisualStyleBackColor = false;
            this.logAdminbtn.Click += new System.EventHandler(this.logAdminbtn_Click);
            // 
            // ManagerLoginSubmitbtn
            // 
            this.ManagerLoginSubmitbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ManagerLoginSubmitbtn.BackColor = System.Drawing.Color.LightSlateGray;
            this.ManagerLoginSubmitbtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManagerLoginSubmitbtn.Location = new System.Drawing.Point(354, 305);
            this.ManagerLoginSubmitbtn.Name = "ManagerLoginSubmitbtn";
            this.ManagerLoginSubmitbtn.Size = new System.Drawing.Size(74, 32);
            this.ManagerLoginSubmitbtn.TabIndex = 12;
            this.ManagerLoginSubmitbtn.Text = "Login";
            this.ManagerLoginSubmitbtn.UseVisualStyleBackColor = false;
            this.ManagerLoginSubmitbtn.Click += new System.EventHandler(this.ManagerLoginSubmitbtn_Click);
            // 
            // loginLblPassword
            // 
            this.loginLblPassword.AutoSize = true;
            this.loginLblPassword.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLblPassword.Location = new System.Drawing.Point(224, 258);
            this.loginLblPassword.Name = "loginLblPassword";
            this.loginLblPassword.Size = new System.Drawing.Size(111, 22);
            this.loginLblPassword.TabIndex = 11;
            this.loginLblPassword.Text = "Password :";
            // 
            // loginLblUserId
            // 
            this.loginLblUserId.AutoSize = true;
            this.loginLblUserId.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLblUserId.Location = new System.Drawing.Point(224, 216);
            this.loginLblUserId.Name = "loginLblUserId";
            this.loginLblUserId.Size = new System.Drawing.Size(72, 22);
            this.loginLblUserId.TabIndex = 10;
            this.loginLblUserId.Text = "Email :";
            // 
            // managerLogEmailTextBox
            // 
            this.managerLogEmailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managerLogEmailTextBox.Location = new System.Drawing.Point(354, 211);
            this.managerLogEmailTextBox.Name = "managerLogEmailTextBox";
            this.managerLogEmailTextBox.Size = new System.Drawing.Size(294, 27);
            this.managerLogEmailTextBox.TabIndex = 8;
            // 
            // managerLogPassTextBox
            // 
            this.managerLogPassTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managerLogPassTextBox.Location = new System.Drawing.Point(354, 256);
            this.managerLogPassTextBox.Name = "managerLogPassTextBox";
            this.managerLogPassTextBox.PasswordChar = '*';
            this.managerLogPassTextBox.Size = new System.Drawing.Size(294, 27);
            this.managerLogPassTextBox.TabIndex = 9;
            // 
            // ManagerLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1041, 638);
            this.Controls.Add(this.panel1);
            this.Name = "ManagerLogin";
            this.Text = "ManagerLogin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ManagerLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox managerLogPassTextBox;
        private System.Windows.Forms.TextBox managerLogEmailTextBox;
        private System.Windows.Forms.Label loginLblUserId;
        private System.Windows.Forms.Label loginLblPassword;
        private System.Windows.Forms.Button ManagerLoginSubmitbtn;
        private System.Windows.Forms.Button logAdminbtn;
    }
}