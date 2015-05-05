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
    public partial class AccountSettings : Form
    {
        public Profile testProfile;
        public AccountSettings(Profile p)
        {
            InitializeComponent();
            testProfile = p;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void uxCancel_Click(object sender, EventArgs e) // CANCEL BUTTON
        {
            this.Close();
        }

        private void uxSave_Click(object sender, EventArgs e) // SAVE 
        {
            if (!textBoxFirstName.Text.Equals(""))
            {
                testProfile.firstName = textBoxFirstName.Text;
            }
            if (!textBoxLastName.Text.Equals(""))
            {
                testProfile.lastName = textBoxLastName.Text;
            }
            if (!textBoxPassword.Text.Equals(""))
            {
                testProfile.password = textBoxPassword.Text;
            }
            if (!textBoxPhoneNum.Text.Equals(""))
            {
                testProfile.phoneNumber = textBoxPhoneNum.Text;
            }
            if (!textBoxEmail.Text.Equals(""))
            {
                testProfile.email = textBoxEmail.Text;
            }
            this.Close();

        }
    }
}
