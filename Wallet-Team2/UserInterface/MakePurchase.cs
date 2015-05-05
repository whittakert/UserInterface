using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace UserInterface
{
    public partial class MakePurchase : Form
    {
        TestController tc;
        Profile p;
        public MakePurchase(TestController t, Profile pro)
        {
            InitializeComponent();
            tc = t;
            p = pro;
            if(tc.instrumentList != null)
            {
                List<List<string>> payments = tc.instrumentList;
                foreach(List<string> l in payments)
                {
                    cbPaymentOptions.Items.Add(l[0]);
                }
                double purchaseAmount = tc.getAmount();
                txtAmount.Text = purchaseAmount.ToString("C");
            }


        }

        private void cbPaymentOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ID = cbPaymentOptions.SelectedItem.ToString();
            List<string> info = tc.getInstrumentInfo(p.username, ID);
            string[] sA= new string[6];
            string[] aA = new String[4];
            int i = 0;
            int j = 0; 

            foreach(string s in info)
            {
                sA[i] = s;
                i++;
            }

            foreach(string a in p.addresses)
            {
                aA[j] = a;
                j++;
            }

            txtAddress.Text = aA[0];
            txtCity.Text = aA[1];
            txtState.Text = aA[2];
            txtZip.Text = aA[3];
            txtShipAddress.Text = aA[0];
            txtShipCity.Text = aA[1];
            txtShipState.Text = aA[2];
            txtShipZip.Text = aA[3];
            txtEmail.Text = p.email;
            txtPhone.Text = p.phoneNumber;

            if (tc.instrumentType == "Credit") //s[0] = ID s[1] = nameOnCard s[2] = secCode s[3] = expDate  s[4] = cardNumber
            {
                lblCardNumBarPoints.Text = "Card number:";
                lblExp.Text = "Expiration date:";
                lblSecNumValuePunches.Text = "Security code:";
                lblNameUses.Text = "Name on card:";
                lblPin.Text = "";
                txtPin.Enabled = false;
                txtCardNumBarPoints.Text = sA[4];
                txtExpDate.Text = sA[3];
                txtSecValuePunches.Text = sA[2];
                txtNameUses.Text = sA[1];

            }
            else if (tc.instrumentType == "Debit") //s[0] = ID s[1] = nameOnCard s[2] = secCode s[3] = expDate  s[4] = cardNumber s[5] = pin numba
            {
                lblCardNumBarPoints.Text = "Card number:";
                lblExp.Text = "Expiration date:";
                lblSecNumValuePunches.Text = "Security code:";
                lblNameUses.Text = "Name on card:";
                lblPin.Text = "Pin number:";
                txtCardNumBarPoints.Text = sA[4];
                txtExpDate.Text = sA[3];
                txtSecValuePunches.Text = sA[2];
                txtNameUses.Text = sA[1];
                txtPin.Text = sA[5];

            }
            else if (tc.instrumentType == "Coupon") //s[0] = ID s[1] = barcode s[2] = expDate s[3] = numba of uses s[4] = value
            {
                lblCardNumBarPoints.Text = "Barcode:";
                lblExp.Text = "Expiration Date:";
                lblSecNumValuePunches.Text = "Value:";
                lblNameUses.Text = "Number of uses:";
                lblPin.Text = "";
                txtPin.Enabled = false;
                txtCardNumBarPoints.Text = sA[1];
                txtExpDate.Text = sA[2];
                txtSecValuePunches.Text = sA[4];
                txtNameUses.Text = sA[3];


            }
            else if (tc.instrumentType == "Loyalty") //s[0] = ID s[1] = expDate s[2] = numba of punches s[3] = points s[4] = reqPunches s[5] = reqPoints don't need to display req's
            {
                lblCardNumBarPoints.Text = "Points:";
                lblExp.Text = "Expiration Date:";
                lblSecNumValuePunches.Text = "Punches:";
                lblNameUses.Text = "";
                lblPin.Text = "";
                txtNameUses.Enabled = false;
                txtPin.Enabled = false;
                txtCardNumBarPoints.Text = sA[3];
                txtSecValuePunches.Text = sA[2];
            }

        }

        
        private void uxBuy_Click(object sender, EventArgs e)
        {

            ////verify fields are all filled
            //if (textBoxCardNum.Text.Equals(""))
            //    MessageBox.Show("Enter Card Number");
            //if (textBoxExpDate.Text.Equals(""))
            //    MessageBox.Show("Enter expiration date");
            //if (textBoxSecurityNum.Text.Equals(""))
            //    MessageBox.Show("Enter security number");
            //if (textBoxAddress.Text.Equals(""))
            //    MessageBox.Show("Enter street address");
            //if (textBoxCity.Text.Equals(""))
            //    MessageBox.Show("Enter city name");
            //if (textBoxState.Text.Equals(""))
            //    MessageBox.Show("Enter state name");
            //if (textBoxZip.Text.Equals(""))
            //    MessageBox.Show("Enter zip code");
            //if (uxShipAddress.Text.Equals("") || uxShipCity.Text.Equals("") || uxShipState.Text.Equals("") || uxShipZip.Text.Equals(""))
            //    MessageBox.Show("Complete Shipping Address");
            MessageBox.Show("Item bought!");
        }

        private void uxCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbAccount_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RBcard1_CheckedChanged(object sender, EventArgs e)
        {

        }





    }
}