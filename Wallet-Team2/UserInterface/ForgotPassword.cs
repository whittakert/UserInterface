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
    public partial class ForgotPassword : Form
    {
        TestController tC;
        public ForgotPassword(TestController tc)
        {
            InitializeComponent();
            tC = tc;
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            string answer = txtAnswer.Text;
            string correctAnswer = tC.getAnswer(txtUser.Text);

            if(answer == correctAnswer)
            {
                lblPassword.Text = "Your correct password is: " + tC.getPassword(txtUser.Text);
            }
            else
            {
                lblPassword.Text = "";
                MessageBox.Show("Your answer does not match the answer in our records.");
            }
        }

        private void btnUserName_Click(object sender, EventArgs e)
        {
            if (txtUser.Text != "")
            {
                txtQuestion.Text = tC.getQuestion(txtUser.Text);
                btnAnswer.Enabled = true;
                txtAnswer.ReadOnly = false;
            }
            else
                MessageBox.Show("Enter a username!");

        }


    }
}
