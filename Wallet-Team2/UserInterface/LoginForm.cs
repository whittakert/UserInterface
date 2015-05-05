using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class LoginForm : Form
    {

        TestController c;
        public bool match = false;
        public string username;
        Profile p;

        public LoginForm(TestController tc, Profile pro)
        {
            InitializeComponent();
            c = tc;
            p = pro;
        }



        private void uxLogin_Click(object sender, EventArgs e)
        {

            //Check with userprofile to see if username & password match

            bool matches = false;
            username = c.getUsername(uxUserName.Text);
            string password = c.checkPassword(username);

            if (username.Equals("######") || password.Equals("######"))
            {
                matches = false;
            }

            if (password != uxPassword.Text)
                matches = false;
            else
                matches = true;

            if (matches)
            {
                MessageBox.Show("Login successful!");
                match = true;
                this.Close();
            }

            else
                MessageBox.Show("Username and password don't match!");

        }

        private void uxForgotPassword_Click(object sender, EventArgs e)
        {
            //Have new form prompt user to enter email address to send pwd to
            ForgotPassword fp = new ForgotPassword(c);
            fp.Show();
        }

        private void uxCreate_Click(object sender, EventArgs e)
        {
            //Open form to create new account
            CreateAccount ca = new CreateAccount(c); //put c here before submission
            ca.Show();
        }

        private void uxExit_Click(object sender, EventArgs e)
        {
            c.open = false;
            this.Close();
        }
    }
}