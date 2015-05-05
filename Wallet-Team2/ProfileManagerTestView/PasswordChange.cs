﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProfileManagerLib;

namespace ProfileManagerTestView
{
    public partial class PasswordChange : Form
    {
        public ProfileController mProfileController;
        public string mSelectedUser;

        public PasswordChange()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (uxNewPass.Text == uxNewPassConfirm.Text)
            {
                if (!mProfileController.ChangeUserPassword(mSelectedUser,uxCurrentPass.Text, uxNewPass.Text))
                {
                    MessageBox.Show("Incorrect current password!");
                }
                else
                {
                    //success, close me
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Not matching new passwords!");
            }
       }
    }
}
