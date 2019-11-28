namespace LibraryManagementSystem
{
    partial class login
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
            this.LoginSubmitbtn = new System.Windows.Forms.Button();
            this.logManagerbtn = new System.Windows.Forms.Button();
            this.loginPassTextBox = new System.Windows.Forms.TextBox();
            this.loginEmailTextBox = new System.Windows.Forms.TextBox();
            this.loginLblPassword = new System.Windows.Forms.Label();
            this.loginLblUserId = new System.Windows.Forms.Label();
            this.loginLblQuote = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.LoginSubmitbtn);
            this.panel1.Controls.Add(this.logManagerbtn);
            this.panel1.Controls.Add(this.loginPassTextBox);
            this.panel1.Controls.Add(this.loginEmailTextBox);
            this.panel1.Controls.Add(this.loginLblPassword);
            this.panel1.Controls.Add(this.loginLblUserId);
            this.panel1.Controls.Add(this.loginLblQuote);
            this.panel1.Location = new System.Drawing.Point(67, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(901, 559);
            this.panel1.TabIndex = 0;
            // 
            // LoginSubmitbtn
            // 
            this.LoginSubmitbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginSubmitbtn.BackColor = System.Drawing.Color.LightSlateGray;
            this.LoginSubmitbtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginSubmitbtn.Location = new System.Drawing.Point(354, 305);
            this.LoginSubmitbtn.Name = "LoginSubmitbtn";
            this.LoginSubmitbtn.Size = new System.Drawing.Size(74, 32);
            this.LoginSubmitbtn.TabIndex = 13;
            this.LoginSubmitbtn.Text = "Login";
            this.LoginSubmitbtn.UseVisualStyleBackColor = false;
            this.LoginSubmitbtn.Click += new System.EventHandler(this.LoginSubmitbtn_Click);
            // 
            // logManagerbtn
            // 
            this.logManagerbtn.BackColor = System.Drawing.Color.LightSlateGray;
            this.logManagerbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.logManagerbtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logManagerbtn.Location = new System.Drawing.Point(512, 305);
            this.logManagerbtn.Margin = new System.Windows.Forms.Padding(0);
            this.logManagerbtn.Name = "logManagerbtn";
            this.logManagerbtn.Size = new System.Drawing.Size(136, 23);
            this.logManagerbtn.TabIndex = 10;
            this.logManagerbtn.Text = "Login as Manager";
            this.logManagerbtn.UseVisualStyleBackColor = false;
            this.logManagerbtn.Click += new System.EventHandler(this.logManagerbtn_Click);
            // 
            // loginPassTextBox
            // 
            this.loginPassTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginPassTextBox.Location = new System.Drawing.Point(354, 256);
            this.loginPassTextBox.Name = "loginPassTextBox";
            this.loginPassTextBox.PasswordChar = '*';
            this.loginPassTextBox.Size = new System.Drawing.Size(294, 27);
            this.loginPassTextBox.TabIndex = 8;
            // 
            // loginEmailTextBox
            // 
            this.loginEmailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginEmailTextBox.Location = new System.Drawing.Point(354, 211);
            this.loginEmailTextBox.Name = "loginEmailTextBox";
            this.loginEmailTextBox.Size = new System.Drawing.Size(294, 27);
            this.loginEmailTextBox.TabIndex = 7;
            // 
            // loginLblPassword
            // 
            this.loginLblPassword.AutoSize = true;
            this.loginLblPassword.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLblPassword.Location = new System.Drawing.Point(224, 261);
            this.loginLblPassword.Name = "loginLblPassword";
            this.loginLblPassword.Size = new System.Drawing.Size(111, 22);
            this.loginLblPassword.TabIndex = 6;
            this.loginLblPassword.Text = "Password :";
            // 
            // loginLblUserId
            // 
            this.loginLblUserId.AutoSize = true;
            this.loginLblUserId.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLblUserId.Location = new System.Drawing.Point(224, 216);
            this.loginLblUserId.Name = "loginLblUserId";
            this.loginLblUserId.Size = new System.Drawing.Size(72, 22);
            this.loginLblUserId.TabIndex = 5;
            this.loginLblUserId.Text = "Email :";
            // 
            // loginLblQuote
            // 
            this.loginLblQuote.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.loginLblQuote.AutoSize = true;
            this.loginLblQuote.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLblQuote.Location = new System.Drawing.Point(80, 125);
            this.loginLblQuote.Name = "loginLblQuote";
            this.loginLblQuote.Size = new System.Drawing.Size(774, 38);
            this.loginLblQuote.TabIndex = 3;
            this.loginLblQuote.Text = "\"Nothing is more impotent than an unread library.\"";
            this.loginLblQuote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loginLblQuote.UseCompatibleTextRendering = true;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1041, 638);
            this.Controls.Add(this.panel1);
            this.Name = "login";
            this.Text = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label loginLblQuote;
        private System.Windows.Forms.TextBox loginPassTextBox;
        private System.Windows.Forms.TextBox loginEmailTextBox;
        private System.Windows.Forms.Label loginLblPassword;
        private System.Windows.Forms.Label loginLblUserId;
        private System.Windows.Forms.Button logManagerbtn;
        private System.Windows.Forms.Button LoginSubmitbtn;
    }
}

