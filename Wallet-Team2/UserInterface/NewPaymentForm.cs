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
    public partial class NewPaymentForm : Form
    {
        public TestController tc;
        public NewPaymentForm(TestController t)
        {
            tc = t;
            InitializeComponent();
        }

        private void rdCredit_CheckedChanged(object sender, EventArgs e)
        {
            string type = "Credit";
            txtName.Enabled = true;
            txtNameOnCard.Enabled = true;
            txtCardNumber.Enabled = true;
            txtExp.Enabled = true;
            txtSecurityCode.Enabled = true;
            txtPin.Enabled = false;
            txtBar.Enabled = false;
            txtPoints.Enabled = false;
            txtPunches.Enabled = false;
            txtReqPoints.Enabled = false;
            txtReqPunch.Enabled = false;
            txtValue.Enabled = false;
            txtUses.Enabled = false;

        }

        private void rdDebit_CheckedChanged(object sender, EventArgs e)
        {
            //string type = "Debit";
            txtName.Enabled = true;
            txtNameOnCard.Enabled = true;
            txtCardNumber.Enabled = true;
            txtExp.Enabled = true;
            txtSecurityCode.Enabled = true;
            txtPin.Enabled = true;
            txtBar.Enabled = false;
            txtPoints.Enabled = false;
            txtPunches.Enabled = false;
            txtReqPoints.Enabled = false;
            txtReqPunch.Enabled = false;
            txtValue.Enabled = false;
            txtUses.Enabled = false;
        }

        private void rdLoyalty_CheckedChanged(object sender, EventArgs e)
        {
            string type = "Loyalty";
            txtName.Enabled = true;
            txtNameOnCard.Enabled = false;
            txtCardNumber.Enabled = false;
            txtExp.Enabled = true;
            txtSecurityCode.Enabled = false;
            txtPin.Enabled = false;
            txtBar.Enabled = false;
            txtPoints.Enabled = true;
            txtPunches.Enabled = true;
            txtReqPoints.Enabled = true; ;
            txtReqPunch.Enabled = true;
            txtValue.Enabled = false;
            txtUses.Enabled = false;
        }

        private void rdCoupon_CheckedChanged(object sender, EventArgs e)
        {
            string type = "Coupon";
            txtName.Enabled = true;
            txtNameOnCard.Enabled = false;
            txtCardNumber.Enabled = false;
            txtExp.Enabled = true;
            txtSecurityCode.Enabled = false;
            txtPin.Enabled = false;
            txtBar.Enabled = true;
            txtPoints.Enabled = false;
            txtPunches.Enabled = false;
            txtReqPoints.Enabled = false;
            txtReqPunch.Enabled = false;
            txtValue.Enabled = true;
            txtUses.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> info = new List<string>();
            string type;
            if(rdCredit.Checked)
            {
                type = "Credit";
                info.Clear();
                info.Add(txtName.Text);
                info.Add(txtNameOnCard.Text);
                info.Add(txtSecurityCode.Text);
                info.Add(txtExp.Text);
                info.Add(txtCardNumber.Text);
                tc.sendInfo(info, type); //tc is controller -> sends info
                MessageBox.Show("Info saved!");
                txtBar.Text = "";
                txtCardNumber.Text = "";
                txtExp.Text = "";
                txtName.Text = "";
                txtNameOnCard.Text = "";
                txtPin.Text = "";
                txtPoints.Text = "";
                txtPunches.Text = "";
                txtSecurityCode.Text = "";
                txtReqPunch.Text = "";
                txtReqPoints.Text = "";
                txtUses.Text = "";
                txtValue.Text = "";
                this.Close();
            }
            else if (rdDebit.Checked)
            {
                type = "Debit";
                info.Clear();
                info.Add(txtName.Text);
                info.Add(txtNameOnCard.Text);
                info.Add(txtSecurityCode.Text);
                info.Add(txtExp.Text);
                info.Add(txtPin.Text);
                info.Add(txtCardNumber.Text);
                tc.sendInfo(info, type);
                MessageBox.Show("Info saved!");
                txtBar.Text = "";
                txtCardNumber.Text = "";
                txtExp.Text = "";
                txtName.Text = "";
                txtNameOnCard.Text = "";
                txtPin.Text = "";
                txtPoints.Text = "";
                txtPunches.Text = "";
                txtSecurityCode.Text = "";
                txtReqPunch.Text = "";
                txtReqPoints.Text = "";
                txtUses.Text = "";
                txtValue.Text = "";
                this.Close();
            }
            else if(rdCoupon.Checked)
            {
                type = "Coupon";
                info.Clear();
                info.Add(txtName.Text);
                info.Add(txtBar.Text);
                info.Add(txtExp.Text);
                info.Add(txtUses.Text);
                info.Add(txtValue.Text);
                tc.sendInfo(info, type);
                MessageBox.Show("Info saved!");
                txtBar.Text = "";
                txtCardNumber.Text = "";
                txtExp.Text = "";
                txtName.Text = "";
                txtNameOnCard.Text = "";
                txtPin.Text = "";
                txtPoints.Text = "";
                txtPunches.Text = "";
                txtSecurityCode.Text = "";
                txtReqPunch.Text = "";
                txtReqPoints.Text = "";
                txtUses.Text = "";
                txtValue.Text = "";
                this.Close();
            }
            else if(rdLoyalty.Checked)
            {
                type = "Loyalty";
                info.Clear();
                info.Add(txtName.Text);
                info.Add(txtExp.Text);
                info.Add(txtPunches.Text);
                info.Add(txtPoints.Text);
                info.Add(txtReqPunch.Text);
                info.Add(txtReqPoints.Text);
                tc.sendInfo(info, type);
                MessageBox.Show("Info saved!");
                txtBar.Text = "";
                txtCardNumber.Text = "";
                txtExp.Text = "";
                txtName.Text = "";
                txtNameOnCard.Text = "";
                txtPin.Text = "";
                txtPoints.Text = "";
                txtPunches.Text = "";
                txtSecurityCode.Text = "";
                txtReqPunch.Text = "";
                txtReqPoints.Text = "";
                txtUses.Text = "";
                txtValue.Text = "";
                this.Close();
            }

        }

    }
}
