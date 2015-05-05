namespace UserInterface
{
    partial class MakePurchase
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
            this.uxAmount = new System.Windows.Forms.Label();
            this.uxBilling = new System.Windows.Forms.GroupBox();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.groupBoxShipping = new System.Windows.Forms.GroupBox();
            this.txtShipZip = new System.Windows.Forms.TextBox();
            this.txtShipState = new System.Windows.Forms.TextBox();
            this.txtShipCity = new System.Windows.Forms.TextBox();
            this.txtShipAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.uxEmail = new System.Windows.Forms.Label();
            this.uxCell = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.uxBuy = new System.Windows.Forms.Button();
            this.uxCancel = new System.Windows.Forms.Button();
            this.lblCardNumBarPoints = new System.Windows.Forms.Label();
            this.lblExp = new System.Windows.Forms.Label();
            this.lblSecNumValuePunches = new System.Windows.Forms.Label();
            this.lblNameUses = new System.Windows.Forms.Label();
            this.lblPin = new System.Windows.Forms.Label();
            this.txtCardNumBarPoints = new System.Windows.Forms.TextBox();
            this.txtExpDate = new System.Windows.Forms.TextBox();
            this.txtSecValuePunches = new System.Windows.Forms.TextBox();
            this.txtNameUses = new System.Windows.Forms.TextBox();
            this.txtPin = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbPaymentOptions = new System.Windows.Forms.ComboBox();
            this.uxBilling.SuspendLayout();
            this.groupBoxShipping.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxAmount
            // 
            this.uxAmount.AutoSize = true;
            this.uxAmount.Location = new System.Drawing.Point(421, 73);
            this.uxAmount.Name = "uxAmount";
            this.uxAmount.Size = new System.Drawing.Size(46, 13);
            this.uxAmount.TabIndex = 0;
            this.uxAmount.Text = "Amount:";
            // 
            // uxBilling
            // 
            this.uxBilling.Controls.Add(this.txtZip);
            this.uxBilling.Controls.Add(this.txtState);
            this.uxBilling.Controls.Add(this.txtCity);
            this.uxBilling.Controls.Add(this.txtAddress);
            this.uxBilling.Controls.Add(this.label1);
            this.uxBilling.Controls.Add(this.label2);
            this.uxBilling.Controls.Add(this.label3);
            this.uxBilling.Controls.Add(this.label4);
            this.uxBilling.Location = new System.Drawing.Point(8, 231);
            this.uxBilling.Name = "uxBilling";
            this.uxBilling.Size = new System.Drawing.Size(509, 156);
            this.uxBilling.TabIndex = 10;
            this.uxBilling.TabStop = false;
            this.uxBilling.Text = "Billing Address Info";
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(93, 128);
            this.txtZip.Name = "txtZip";
            this.txtZip.ReadOnly = true;
            this.txtZip.Size = new System.Drawing.Size(381, 20);
            this.txtZip.TabIndex = 17;
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(93, 94);
            this.txtState.Name = "txtState";
            this.txtState.ReadOnly = true;
            this.txtState.Size = new System.Drawing.Size(381, 20);
            this.txtState.TabIndex = 16;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(92, 61);
            this.txtCity.Name = "txtCity";
            this.txtCity.ReadOnly = true;
            this.txtCity.Size = new System.Drawing.Size(382, 20);
            this.txtCity.TabIndex = 15;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(94, 29);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(381, 20);
            this.txtAddress.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "City:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Zipcode";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "State:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Address:";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(473, 70);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.Size = new System.Drawing.Size(113, 20);
            this.txtAmount.TabIndex = 11;
            // 
            // groupBoxShipping
            // 
            this.groupBoxShipping.Controls.Add(this.txtShipZip);
            this.groupBoxShipping.Controls.Add(this.txtShipState);
            this.groupBoxShipping.Controls.Add(this.txtShipCity);
            this.groupBoxShipping.Controls.Add(this.txtShipAddress);
            this.groupBoxShipping.Controls.Add(this.label5);
            this.groupBoxShipping.Controls.Add(this.label6);
            this.groupBoxShipping.Controls.Add(this.label7);
            this.groupBoxShipping.Controls.Add(this.label8);
            this.groupBoxShipping.Location = new System.Drawing.Point(523, 231);
            this.groupBoxShipping.Name = "groupBoxShipping";
            this.groupBoxShipping.Size = new System.Drawing.Size(509, 156);
            this.groupBoxShipping.TabIndex = 12;
            this.groupBoxShipping.TabStop = false;
            this.groupBoxShipping.Text = "Shipping Address Info";
            // 
            // txtShipZip
            // 
            this.txtShipZip.Location = new System.Drawing.Point(93, 128);
            this.txtShipZip.Name = "txtShipZip";
            this.txtShipZip.ReadOnly = true;
            this.txtShipZip.Size = new System.Drawing.Size(381, 20);
            this.txtShipZip.TabIndex = 17;
            // 
            // txtShipState
            // 
            this.txtShipState.Location = new System.Drawing.Point(93, 94);
            this.txtShipState.Name = "txtShipState";
            this.txtShipState.ReadOnly = true;
            this.txtShipState.Size = new System.Drawing.Size(381, 20);
            this.txtShipState.TabIndex = 16;
            // 
            // txtShipCity
            // 
            this.txtShipCity.Location = new System.Drawing.Point(92, 61);
            this.txtShipCity.Name = "txtShipCity";
            this.txtShipCity.ReadOnly = true;
            this.txtShipCity.Size = new System.Drawing.Size(382, 20);
            this.txtShipCity.TabIndex = 15;
            // 
            // txtShipAddress
            // 
            this.txtShipAddress.Location = new System.Drawing.Point(94, 29);
            this.txtShipAddress.Name = "txtShipAddress";
            this.txtShipAddress.ReadOnly = true;
            this.txtShipAddress.Size = new System.Drawing.Size(381, 20);
            this.txtShipAddress.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "City:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Zipcode";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "State:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Address:";
            // 
            // uxEmail
            // 
            this.uxEmail.AutoSize = true;
            this.uxEmail.Location = new System.Drawing.Point(314, 410);
            this.uxEmail.Name = "uxEmail";
            this.uxEmail.Size = new System.Drawing.Size(38, 13);
            this.uxEmail.TabIndex = 13;
            this.uxEmail.Text = "E-mail:";
            // 
            // uxCell
            // 
            this.uxCell.AutoSize = true;
            this.uxCell.Location = new System.Drawing.Point(276, 440);
            this.uxCell.Name = "uxCell";
            this.uxCell.Size = new System.Drawing.Size(81, 13);
            this.uxCell.TabIndex = 14;
            this.uxCell.Text = "Phone Number:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(361, 412);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(341, 20);
            this.txtEmail.TabIndex = 15;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(361, 439);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(341, 20);
            this.txtPhone.TabIndex = 16;
            // 
            // uxBuy
            // 
            this.uxBuy.Location = new System.Drawing.Point(380, 478);
            this.uxBuy.Name = "uxBuy";
            this.uxBuy.Size = new System.Drawing.Size(75, 52);
            this.uxBuy.TabIndex = 17;
            this.uxBuy.Text = "Confirm Sale, Purchase!";
            this.uxBuy.UseVisualStyleBackColor = true;
            // 
            // uxCancel
            // 
            this.uxCancel.Location = new System.Drawing.Point(473, 507);
            this.uxCancel.Name = "uxCancel";
            this.uxCancel.Size = new System.Drawing.Size(75, 23);
            this.uxCancel.TabIndex = 18;
            this.uxCancel.Text = "Cancel";
            this.uxCancel.UseVisualStyleBackColor = true;
            // 
            // lblCardNumBarPoints
            // 
            this.lblCardNumBarPoints.AutoSize = true;
            this.lblCardNumBarPoints.Location = new System.Drawing.Point(135, 118);
            this.lblCardNumBarPoints.Name = "lblCardNumBarPoints";
            this.lblCardNumBarPoints.Size = new System.Drawing.Size(72, 13);
            this.lblCardNumBarPoints.TabIndex = 24;
            this.lblCardNumBarPoints.Text = "Card Number:";
            // 
            // lblExp
            // 
            this.lblExp.AutoSize = true;
            this.lblExp.Location = new System.Drawing.Point(119, 143);
            this.lblExp.Name = "lblExp";
            this.lblExp.Size = new System.Drawing.Size(82, 13);
            this.lblExp.TabIndex = 25;
            this.lblExp.Text = "Expiration Date:";
            // 
            // lblSecNumValuePunches
            // 
            this.lblSecNumValuePunches.AutoSize = true;
            this.lblSecNumValuePunches.Location = new System.Drawing.Point(113, 179);
            this.lblSecNumValuePunches.Name = "lblSecNumValuePunches";
            this.lblSecNumValuePunches.Size = new System.Drawing.Size(88, 13);
            this.lblSecNumValuePunches.TabIndex = 26;
            this.lblSecNumValuePunches.Text = "Security Number:";
            // 
            // lblNameUses
            // 
            this.lblNameUses.AutoSize = true;
            this.lblNameUses.Location = new System.Drawing.Point(539, 117);
            this.lblNameUses.Name = "lblNameUses";
            this.lblNameUses.Size = new System.Drawing.Size(78, 13);
            this.lblNameUses.TabIndex = 27;
            this.lblNameUses.Text = "Name on Card:";
            // 
            // lblPin
            // 
            this.lblPin.AutoSize = true;
            this.lblPin.Location = new System.Drawing.Point(561, 152);
            this.lblPin.Name = "lblPin";
            this.lblPin.Size = new System.Drawing.Size(65, 13);
            this.lblPin.TabIndex = 28;
            this.lblPin.Text = "Pin Number:";
            // 
            // txtCardNumBarPoints
            // 
            this.txtCardNumBarPoints.Location = new System.Drawing.Point(212, 115);
            this.txtCardNumBarPoints.Name = "txtCardNumBarPoints";
            this.txtCardNumBarPoints.ReadOnly = true;
            this.txtCardNumBarPoints.Size = new System.Drawing.Size(245, 20);
            this.txtCardNumBarPoints.TabIndex = 30;
            // 
            // txtExpDate
            // 
            this.txtExpDate.Location = new System.Drawing.Point(210, 147);
            this.txtExpDate.Name = "txtExpDate";
            this.txtExpDate.ReadOnly = true;
            this.txtExpDate.Size = new System.Drawing.Size(246, 20);
            this.txtExpDate.TabIndex = 31;
            // 
            // txtSecValuePunches
            // 
            this.txtSecValuePunches.Location = new System.Drawing.Point(210, 179);
            this.txtSecValuePunches.Name = "txtSecValuePunches";
            this.txtSecValuePunches.ReadOnly = true;
            this.txtSecValuePunches.Size = new System.Drawing.Size(245, 20);
            this.txtSecValuePunches.TabIndex = 32;
            // 
            // txtNameUses
            // 
            this.txtNameUses.Location = new System.Drawing.Point(644, 118);
            this.txtNameUses.Name = "txtNameUses";
            this.txtNameUses.ReadOnly = true;
            this.txtNameUses.Size = new System.Drawing.Size(253, 20);
            this.txtNameUses.TabIndex = 33;
            // 
            // txtPin
            // 
            this.txtPin.Location = new System.Drawing.Point(644, 147);
            this.txtPin.Name = "txtPin";
            this.txtPin.ReadOnly = true;
            this.txtPin.Size = new System.Drawing.Size(249, 20);
            this.txtPin.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(352, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 13);
            this.label9.TabIndex = 59;
            this.label9.Text = "Select payment option:";
            // 
            // cbPaymentOptions
            // 
            this.cbPaymentOptions.FormattingEnabled = true;
            this.cbPaymentOptions.Location = new System.Drawing.Point(483, 22);
            this.cbPaymentOptions.Name = "cbPaymentOptions";
            this.cbPaymentOptions.Size = new System.Drawing.Size(167, 21);
            this.cbPaymentOptions.TabIndex = 58;
            this.cbPaymentOptions.SelectedIndexChanged += new System.EventHandler(this.cbPaymentOptions_SelectedIndexChanged);
            // 
            // MakePurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 613);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbPaymentOptions);
            this.Controls.Add(this.txtPin);
            this.Controls.Add(this.txtNameUses);
            this.Controls.Add(this.txtSecValuePunches);
            this.Controls.Add(this.txtExpDate);
            this.Controls.Add(this.txtCardNumBarPoints);
            this.Controls.Add(this.lblPin);
            this.Controls.Add(this.lblNameUses);
            this.Controls.Add(this.lblSecNumValuePunches);
            this.Controls.Add(this.lblExp);
            this.Controls.Add(this.lblCardNumBarPoints);
            this.Controls.Add(this.uxCancel);
            this.Controls.Add(this.uxBuy);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.uxCell);
            this.Controls.Add(this.uxEmail);
            this.Controls.Add(this.groupBoxShipping);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.uxBilling);
            this.Controls.Add(this.uxAmount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MakePurchase";
            this.Text = "Make Purchase";
            this.uxBilling.ResumeLayout(false);
            this.uxBilling.PerformLayout();
            this.groupBoxShipping.ResumeLayout(false);
            this.groupBoxShipping.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxAmount;
        private System.Windows.Forms.GroupBox uxBilling;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.GroupBox groupBoxShipping;
        private System.Windows.Forms.TextBox txtShipZip;
        private System.Windows.Forms.TextBox txtShipState;
        private System.Windows.Forms.TextBox txtShipCity;
        private System.Windows.Forms.TextBox txtShipAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label uxEmail;
        private System.Windows.Forms.Label uxCell;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Button uxBuy;
        private System.Windows.Forms.Button uxCancel;
        private System.Windows.Forms.Label lblCardNumBarPoints;
        private System.Windows.Forms.Label lblExp;
        private System.Windows.Forms.Label lblSecNumValuePunches;
        private System.Windows.Forms.Label lblNameUses;
        private System.Windows.Forms.Label lblPin;
        private System.Windows.Forms.TextBox txtCardNumBarPoints;
        private System.Windows.Forms.TextBox txtExpDate;
        private System.Windows.Forms.TextBox txtSecValuePunches;
        private System.Windows.Forms.TextBox txtNameUses;
        private System.Windows.Forms.TextBox txtPin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbPaymentOptions;
    }
}