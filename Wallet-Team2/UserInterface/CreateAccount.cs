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
    public partial class CreateAccount : Form
    {
        TestController tc;
        public CreateAccount(TestController t)
        {
            InitializeComponent();
            tc = t;
        }

        private void label1_Click(object sender, EventArgs e) // dont delete oops
        {

        }

        private void uxCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uxSubmit_Click(object sender, EventArgs e) // submit button
        {
            if (!uxPWtext.Text.Equals(uxCPWtext.Text)) // checking to see if passwords match
            {
                MessageBox.Show("Passwords don't match.");
            }
            else if (uxAnswerText.Text == "" || uxCity.Text == "" || uxCPWtext.Text == "" || uxEMtext.Text == "" || uxFNtext.Text == "" || 
                uxLNtext.Text == "" ||uxPNtext.Text == "" || uxPWtext.Text == "" || uxQuestionText.Text == "" || uxState.Text == "" || 
                uxStreet.Text == "" || uxUNtext.Text == "" || uxZip.Text == "")// need to make sure all fields are filled in 
            {
                MessageBox.Show("All Fields must be complete!");
            }
            else
            {
                //send info to controller
                RegisterAccount();
                uxAnswerText.Clear();
                uxCity.Clear();
                uxCPWtext.Clear();
                uxEMtext.Clear();
                uxFNtext.Clear();
                uxLNtext.Clear();
                uxPNtext.Clear();
                uxPWtext.Clear();
                uxQuestionText.Clear();
                uxState.Clear();
                uxStreet.Clear();
                uxUNtext.Clear();
                uxZip.Clear();
                MessageBox.Show("Account Created");
                this.Close(); //close after account is created
            }
        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {

        }

        private void RegisterAccount()
        {
            string firstName = uxFNtext.Text;
            string lastName = uxLNtext.Text;
            string email = uxEMtext.Text;
            string phoneNumber = uxPNtext.Text;
            string username = uxUNtext.Text;
            string password = uxPWtext.Text;
            string question = uxQuestionText.Text;
            string answer = uxAnswerText.Text;
            string streetAdd = uxStreet.Text;
            string city = uxCity.Text;
            string state = uxState.Text;
            string zip = uxZip.Text;

            string fullAddress = streetAdd + ", " + city + ", " + state + ", " + zip;
            tc.Register(firstName, lastName, email, phoneNumber, username, password, question, answer, fullAddress);
            
        }
    }
}
