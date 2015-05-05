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
    public partial class MainForm : Form
    {
        private TestController tc;
        private string username;
        public Profile p;

        public MainForm(TestController t, string un)
        {
            InitializeComponent();
            tc = t;
            username = un;
            foreach (Profile pro in tc.profileList)
            {
                if (username.Equals(pro.username))
                {
                    p = pro;
                    break;
                }
            }
            uxName.Text = " Welcome, " + p.username;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void uxPaymentOptions_Click(object sender, EventArgs e) // open payment options
        {
            PaymentOptions payOp = new PaymentOptions(tc, p);
            payOp.Show();
        }

        private void uxSettings_Click(object sender, EventArgs e) // open Account Settings
        {
            AccountSettings accSettings = new AccountSettings(p);
            accSettings.Show();
        }

        private void btnTextFile_Click(object sender, EventArgs e) //temporary method to test html
        {
            Profile testP = p.createProfileFromTextFile();
            string content;
            int i = 1;
            content = testP.username + Environment.NewLine;
            content += testP.password + Environment.NewLine;
            content += testP.email + Environment.NewLine;
            content += testP.firstName + Environment.NewLine;
            content += testP.lastName + Environment.NewLine;
            foreach(string s in testP.addresses)
            {
                if(testP.addresses.Count()==i)
                {
                    content += s;
                }
                else if(testP.addresses.Count() >1 && i != testP.addresses.Count())
                {
                    content += s + ",";

                }
                i++;

            }
            content += Environment.NewLine;
            content += testP.phoneNumber + Environment.NewLine;
            content += testP.question + Environment.NewLine;
            content += testP.answer + Environment.NewLine;
            txtTextFile.Text = content;

        }

        private void buttonLogout_Click(object sender, EventArgs e) // logout
        {
           
            this.Hide();
            LoginForm lf = new LoginForm(tc, p);
            lf.ShowDialog();
            this.Close();

        }
    }
}