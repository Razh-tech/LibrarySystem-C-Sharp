namespace LibraryManagementSystem
{
    partial class changePassword
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
            this.changePassCancelbtn = new System.Windows.Forms.Button();
            this.changePassSubmitbtn = new System.Windows.Forms.Button();
            this.changePassConfirmPassTextBox = new System.Windows.Forms.TextBox();
            this.changePassNewPassTextBox = new System.Windows.Forms.TextBox();
            this.changePassCurrPassTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.changePassCancelbtn);
            this.panel1.Controls.Add(this.changePassSubmitbtn);
            this.panel1.Controls.Add(this.changePassConfirmPassTextBox);
            this.panel1.Controls.Add(this.changePassNewPassTextBox);
            this.panel1.Controls.Add(this.changePassCurrPassTextBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(260, 181);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(616, 346);
            this.panel1.TabIndex = 0;
            // 
            // changePassCancelbtn
            // 
            this.changePassCancelbtn.BackColor = System.Drawing.Color.LightSlateGray;
            this.changePassCancelbtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePassCancelbtn.Location = new System.Drawing.Point(124, 248);
            this.changePassCancelbtn.Name = "changePassCancelbtn";
            this.changePassCancelbtn.Size = new System.Drawing.Size(75, 45);
            this.changePassCancelbtn.TabIndex = 14;
            this.changePassCancelbtn.Text = "Cancel";
            this.changePassCancelbtn.UseVisualStyleBackColor = false;
            this.changePassCancelbtn.Click += new System.EventHandler(this.changePassCancelbtn_Click);
            // 
            // changePassSubmitbtn
            // 
            this.changePassSubmitbtn.BackColor = System.Drawing.Color.LightSlateGray;
            this.changePassSubmitbtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePassSubmitbtn.Location = new System.Drawing.Point(312, 246);
            this.changePassSubmitbtn.Name = "changePassSubmitbtn";
            this.changePassSubmitbtn.Size = new System.Drawing.Size(167, 45);
            this.changePassSubmitbtn.TabIndex = 6;
            this.changePassSubmitbtn.Text = "Submit";
            this.changePassSubmitbtn.UseVisualStyleBackColor = false;
            this.changePassSubmitbtn.Click += new System.EventHandler(this.changePassSubmitbtn_Click);
            // 
            // changePassConfirmPassTextBox
            // 
            this.changePassConfirmPassTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePassConfirmPassTextBox.Location = new System.Drawing.Point(297, 172);
            this.changePassConfirmPassTextBox.Name = "changePassConfirmPassTextBox";
            this.changePassConfirmPassTextBox.PasswordChar = '*';
            this.changePassConfirmPassTextBox.Size = new System.Drawing.Size(198, 27);
            this.changePassConfirmPassTextBox.TabIndex = 5;
            // 
            // changePassNewPassTextBox
            // 
            this.changePassNewPassTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePassNewPassTextBox.Location = new System.Drawing.Point(297, 127);
            this.changePassNewPassTextBox.Name = "changePassNewPassTextBox";
            this.changePassNewPassTextBox.PasswordChar = '*';
            this.changePassNewPassTextBox.Size = new System.Drawing.Size(198, 27);
            this.changePassNewPassTextBox.TabIndex = 4;
            // 
            // changePassCurrPassTextBox
            // 
            this.changePassCurrPassTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePassCurrPassTextBox.Location = new System.Drawing.Point(297, 85);
            this.changePassCurrPassTextBox.Name = "changePassCurrPassTextBox";
            this.changePassCurrPassTextBox.PasswordChar = '*';
            this.changePassCurrPassTextBox.Size = new System.Drawing.Size(198, 27);
            this.changePassCurrPassTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Confirm New Password :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "New Password :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Password :";
            // 
            // changePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1086, 709);
            this.Controls.Add(this.panel1);
            this.Name = "changePassword";
            this.Text = "Chnage Password";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.changePassword_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox changePassConfirmPassTextBox;
        private System.Windows.Forms.TextBox changePassNewPassTextBox;
        private System.Windows.Forms.TextBox changePassCurrPassTextBox;
        private System.Windows.Forms.Button changePassSubmitbtn;
        private System.Windows.Forms.Button changePassCancelbtn;
    }
}