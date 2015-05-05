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
    public partial class PaymentOptions : Form
    {
        TestController tc;
        Profile p;
        public PaymentOptions(TestController t, Profile p)
        {
            this.p = p;
            tc = t;
            InitializeComponent();
            //foreach (Card c in p.cards)
            //{
            //    cbPaymentOptions.Items.Add(c);

            //}
            //textBoxCardNum.Text = profile.cardNumber;
            //textBoxExpDate.Text = profile.cardExpDate;
            //textBoxSecurityNum.Text = profile.securityCode;

            //c1 = profile.cards[0];
            //c2 = profile.cards[1];
            // this is only two cards beacause I am not sure how many cards there are going to be allowed


        }

        //public void RBcard1_CheckedChanged(object sender, EventArgs e) // CARD 1 IS PRIMARY/FIRST CARD
        //{
        //    foreach (Control control in this.groupBoxPayOp.Controls)
        //    {
        //        if (control is RadioButton)
        //        {
        //            if (RBcard1.Checked)
        //            {
        //                textBoxCardNum.Enabled = true;
        //                textBoxExpDate.Enabled = true;
        //                textBoxSecurityNum.Enabled = true;
        //                textBoxZipCode.Enabled = true;
        //                textBoxAccNum.Enabled = false;
        //                textBoxRoutingNum.Enabled = false;
        //            }
        //        }
        //    }
        //}


        //public void rbCard2_CheckedChanged(object sender, EventArgs e)
        //{
        //    foreach (Control control in this.groupBoxPayOp.Controls)
        //    {
        //        if (control is RadioButton)
        //        {
        //            if (rbCard2.Checked)
        //            {
        //                textBoxCardNum.Enabled = true;
        //                textBoxExpDate.Enabled = true;
        //                textBoxSecurityNum.Enabled = true;
        //                textBoxZipCode.Enabled = true;
        //                textBoxAccNum.Enabled = false;
        //                textBoxRoutingNum.Enabled = false;
        //                textBoxCardNum.Text = "";
        //                textBoxExpDate.Text = "";
        //                textBoxSecurityNum.Text = "";
                        
        //            }
        //        }
        //    }
        //}

        //private void rbCard3_CheckedChanged(object sender, EventArgs e)
        //{
        //    foreach (Control control in this.groupBoxPayOp.Controls)
        //    {
        //        if (control is RadioButton)
        //        {
        //            if (rbCard3.Checked)
        //            {
        //                textBoxCardNum.Enabled = true;
        //                textBoxExpDate.Enabled = true;
        //                textBoxSecurityNum.Enabled = true;
        //                textBoxZipCode.Enabled = true;
        //                textBoxAccNum.Enabled = false;
        //                textBoxRoutingNum.Enabled = false;
        //                textBoxCardNum.Text = "";
        //                textBoxExpDate.Text = "";
        //                textBoxSecurityNum.Text = "";
        //            }
        //        }
        //    }

        //}

        //private void rbGiftCard_CheckedChanged(object sender, EventArgs e)
        //{
        //    foreach (Control control in this.groupBoxPayOp.Controls)
        //    {
        //        if (control is RadioButton)
        //        {
        //            if (rbGiftCard.Checked)
        //            {
        //                textBoxCardNum.Enabled = true;
        //                textBoxExpDate.Enabled = false;
        //                textBoxSecurityNum.Enabled = false;
        //                textBoxZipCode.Enabled = false;
        //                textBoxAccNum.Enabled = false;
        //                textBoxRoutingNum.Enabled = false;
        //            }
        //        }
        //    }
        //}

        //private void rbAccount_CheckedChanged(object sender, EventArgs e)
        //{
        //    foreach (Control control in this.groupBoxPayOp.Controls)
        //    {
        //        if (control is RadioButton)
        //        {
        //            if (rbAccount.Checked)
        //            {
        //                textBoxCardNum.Enabled = false;
        //                textBoxExpDate.Enabled = false;
        //                textBoxSecurityNum.Enabled = false;
        //                textBoxZipCode.Enabled = true;
        //                textBoxAccNum.Enabled = true;
        //                textBoxRoutingNum.Enabled = true;
        //            }
        //        }
        //    }
        //}

        private void uxCancel_Click(object sender, EventArgs e) // CANCEL BUTTON
        {
            this.Close();
        }

        private void uxSave_Click(object sender, EventArgs e) // make a purchase
        {
            if (tc.instrumentList != null)
            {
                MakePurchase mp = new MakePurchase(tc, p);
                mp.Show();
            }
            else
                MessageBox.Show("Add a payment method before continuing!");


            //if (rbCard2.Checked && textBoxCardNum.Text != "" && textBoxExpDate.Text != "" && textBoxSecurityNum.Text != "") // adding card 2 
            //{
            //    MessageBox.Show("Would you like to add this card to wallet?", "Add Card", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //    if (DialogResult == DialogResult.Yes)
            //    {
            //        Card card1 = new Card(textBoxCardNum.Text, "MasterCard", textBoxExpDate.Text, textBoxSecurityNum.Text, txtCardName.Text);
            //        p.cards.Add(card1);
            //    }
            //    else
            //        return;
            //}
            //if (rbCard3.Checked && textBoxCardNum.Text != "" && textBoxExpDate.Text != "" && textBoxSecurityNum.Text != "")
            //{
            //    MessageBox.Show("Would you like to add this card to wallet?", "Add Card", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //    if (DialogResult == DialogResult.Yes) // jumps straight to return here and idk why and its very upsetting
            //    {
            //        Card card1 = new Card(textBoxCardNum.Text, "MasterCard", textBoxExpDate.Text, textBoxSecurityNum.Text, txtCardName.Text);
            //        p.cards.Add(card1);
            //    }
            //    else
            //        return;
            //}
            //if (rbAccount.Checked &&  textBoxAccNum.Text != "" && textBoxRoutingNum.Text != "" && textBoxZipCode.Text != "")
            //{
            //    MessageBox.Show("Would you like to add this Account to wallet?", "Add Card", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //    if (DialogResult == DialogResult.Yes)
            //    {
            //        Account acc = new Account(textBoxAccNum.Text, textBoxRoutingNum.Text, textBoxZipCode.Text);
            //        //we need a way to add an account with that profile. 
            //    }
            //    else
            //        return;
            //}

        }

        private void button1_Click(object sender, EventArgs e) //newpayment button
        {

                NewPaymentForm nf = new NewPaymentForm(tc);
                nf.Show();


        }
    }
}
