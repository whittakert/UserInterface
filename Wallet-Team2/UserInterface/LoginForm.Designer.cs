namespace UserInterface
{
    partial class LoginForm
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
            this.uxLogin = new System.Windows.Forms.Button();
            this.uxForgotPassword = new System.Windows.Forms.Button();
            this.uxUserName = new System.Windows.Forms.TextBox();
            this.uxPassword = new System.Windows.Forms.TextBox();
            this.uxUNlabel = new System.Windows.Forms.Label();
            this.uxPWlabel = new System.Windows.Forms.Label();
            this.uxCreate = new System.Windows.Forms.Button();
            this.uxExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxLogin
            // 
            this.uxLogin.Location = new System.Drawing.Point(116, 109);
            this.uxLogin.Name = "uxLogin";
            this.uxLogin.Size = new System.Drawing.Size(101, 23);
            this.uxLogin.TabIndex = 0;
            this.uxLogin.Text = "Login";
            this.uxLogin.UseVisualStyleBackColor = true;
            this.uxLogin.Click += new System.EventHandler(this.uxLogin_Click);
            // 
            // uxForgotPassword
            // 
            this.uxForgotPassword.Location = new System.Drawing.Point(116, 138);
            this.uxForgotPassword.Name = "uxForgotPassword";
            this.uxForgotPassword.Size = new System.Drawing.Size(101, 23);
            this.uxForgotPassword.TabIndex = 1;
            this.uxForgotPassword.Text = "Forgot Password?";
            this.uxForgotPassword.UseVisualStyleBackColor = true;
            this.uxForgotPassword.Click += new System.EventHandler(this.uxForgotPassword_Click);
            // 
            // uxUserName
            // 
            this.uxUserName.Location = new System.Drawing.Point(78, 27);
            this.uxUserName.Name = "uxUserName";
            this.uxUserName.Size = new System.Drawing.Size(172, 20);
            this.uxUserName.TabIndex = 2;
            // 
            // uxPassword
            // 
            this.uxPassword.Location = new System.Drawing.Point(78, 73);
            this.uxPassword.Name = "uxPassword";
            this.uxPassword.PasswordChar = '*';
            this.uxPassword.Size = new System.Drawing.Size(172, 20);
            this.uxPassword.TabIndex = 3;
            // 
            // uxUNlabel
            // 
            this.uxUNlabel.AutoSize = true;
            this.uxUNlabel.Location = new System.Drawing.Point(142, 11);
            this.uxUNlabel.Name = "uxUNlabel";
            this.uxUNlabel.Size = new System.Drawing.Size(55, 13);
            this.uxUNlabel.TabIndex = 4;
            this.uxUNlabel.Text = "Username";
            // 
            // uxPWlabel
            // 
            this.uxPWlabel.AutoSize = true;
            this.uxPWlabel.Location = new System.Drawing.Point(142, 57);
            this.uxPWlabel.Name = "uxPWlabel";
            this.uxPWlabel.Size = new System.Drawing.Size(53, 13);
            this.uxPWlabel.TabIndex = 5;
            this.uxPWlabel.Text = "Password";
            // 
            // uxCreate
            // 
            this.uxCreate.Location = new System.Drawing.Point(107, 192);
            this.uxCreate.Name = "uxCreate";
            this.uxCreate.Size = new System.Drawing.Size(119, 23);
            this.uxCreate.TabIndex = 6;
            this.uxCreate.Text = "Create Account";
            this.uxCreate.UseVisualStyleBackColor = true;
            this.uxCreate.Click += new System.EventHandler(this.uxCreate_Click);
            // 
            // uxExit
            // 
            this.uxExit.Location = new System.Drawing.Point(122, 241);
            this.uxExit.Name = "uxExit";
            this.uxExit.Size = new System.Drawing.Size(75, 23);
            this.uxExit.TabIndex = 7;
            this.uxExit.Text = "Exit";
            this.uxExit.UseVisualStyleBackColor = true;
            this.uxExit.Click += new System.EventHandler(this.uxExit_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 276);
            this.Controls.Add(this.uxExit);
            this.Controls.Add(this.uxCreate);
            this.Controls.Add(this.uxPWlabel);
            this.Controls.Add(this.uxUNlabel);
            this.Controls.Add(this.uxPassword);
            this.Controls.Add(this.uxUserName);
            this.Controls.Add(this.uxForgotPassword);
            this.Controls.Add(this.uxLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxLogin;
        private System.Windows.Forms.Button uxForgotPassword;
        private System.Windows.Forms.TextBox uxUserName;
        private System.Windows.Forms.TextBox uxPassword;
        private System.Windows.Forms.Label uxUNlabel;
        private System.Windows.Forms.Label uxPWlabel;
        private System.Windows.Forms.Button uxCreate;
        private System.Windows.Forms.Button uxExit;
    }
}