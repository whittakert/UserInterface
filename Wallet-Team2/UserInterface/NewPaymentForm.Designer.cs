namespace UserInterface
{
    partial class NewPaymentForm
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
            this.rdCredit = new System.Windows.Forms.RadioButton();
            this.rdDebit = new System.Windows.Forms.RadioButton();
            this.rdLoyalty = new System.Windows.Forms.RadioButton();
            this.rdCoupon = new System.Windows.Forms.RadioButton();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.txtSecurityCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtExp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPin = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUses = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPunches = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPoints = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtReqPoints = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtNameOnCard = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtReqPunch = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rdCredit
            // 
            this.rdCredit.AutoSize = true;
            this.rdCredit.Location = new System.Drawing.Point(12, 17);
            this.rdCredit.Name = "rdCredit";
            this.rdCredit.Size = new System.Drawing.Size(77, 17);
            this.rdCredit.TabIndex = 0;
            this.rdCredit.TabStop = true;
            this.rdCredit.Text = "Credit Card";
            this.rdCredit.UseVisualStyleBackColor = true;
            this.rdCredit.CheckedChanged += new System.EventHandler(this.rdCredit_CheckedChanged);
            // 
            // rdDebit
            // 
            this.rdDebit.AutoSize = true;
            this.rdDebit.Location = new System.Drawing.Point(95, 17);
            this.rdDebit.Name = "rdDebit";
            this.rdDebit.Size = new System.Drawing.Size(75, 17);
            this.rdDebit.TabIndex = 1;
            this.rdDebit.TabStop = true;
            this.rdDebit.Text = "Debit Card";
            this.rdDebit.UseVisualStyleBackColor = true;
            this.rdDebit.CheckedChanged += new System.EventHandler(this.rdDebit_CheckedChanged);
            // 
            // rdLoyalty
            // 
            this.rdLoyalty.AutoSize = true;
            this.rdLoyalty.Location = new System.Drawing.Point(12, 57);
            this.rdLoyalty.Name = "rdLoyalty";
            this.rdLoyalty.Size = new System.Drawing.Size(83, 17);
            this.rdLoyalty.TabIndex = 2;
            this.rdLoyalty.TabStop = true;
            this.rdLoyalty.Text = "Loyalty Card";
            this.rdLoyalty.UseVisualStyleBackColor = true;
            this.rdLoyalty.CheckedChanged += new System.EventHandler(this.rdLoyalty_CheckedChanged);
            // 
            // rdCoupon
            // 
            this.rdCoupon.AutoSize = true;
            this.rdCoupon.Location = new System.Drawing.Point(97, 57);
            this.rdCoupon.Name = "rdCoupon";
            this.rdCoupon.Size = new System.Drawing.Size(62, 17);
            this.rdCoupon.TabIndex = 3;
            this.rdCoupon.TabStop = true;
            this.rdCoupon.Text = "Coupon";
            this.rdCoupon.UseVisualStyleBackColor = true;
            this.rdCoupon.CheckedChanged += new System.EventHandler(this.rdCoupon_CheckedChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(85, 94);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(140, 20);
            this.txtName.TabIndex = 4;
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Location = new System.Drawing.Point(85, 156);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(140, 20);
            this.txtCardNumber.TabIndex = 5;
            // 
            // txtSecurityCode
            // 
            this.txtSecurityCode.Location = new System.Drawing.Point(85, 188);
            this.txtSecurityCode.Name = "txtSecurityCode";
            this.txtSecurityCode.Size = new System.Drawing.Size(140, 20);
            this.txtSecurityCode.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Card Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-2, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Security Code:";
            // 
            // txtExp
            // 
            this.txtExp.Location = new System.Drawing.Point(85, 225);
            this.txtExp.Name = "txtExp";
            this.txtExp.Size = new System.Drawing.Size(140, 20);
            this.txtExp.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Expiration Date:";
            // 
            // txtPin
            // 
            this.txtPin.Location = new System.Drawing.Point(85, 263);
            this.txtPin.Name = "txtPin";
            this.txtPin.Size = new System.Drawing.Size(140, 20);
            this.txtPin.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Pin Number:";
            // 
            // txtBar
            // 
            this.txtBar.Location = new System.Drawing.Point(85, 298);
            this.txtBar.Name = "txtBar";
            this.txtBar.Size = new System.Drawing.Size(140, 20);
            this.txtBar.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Barcode:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 336);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Uses:";
            // 
            // txtUses
            // 
            this.txtUses.Location = new System.Drawing.Point(85, 332);
            this.txtUses.Name = "txtUses";
            this.txtUses.Size = new System.Drawing.Size(140, 20);
            this.txtUses.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 369);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Value:";
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(85, 365);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(140, 20);
            this.txtValue.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 403);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Number of Punches:";
            // 
            // txtPunches
            // 
            this.txtPunches.Location = new System.Drawing.Point(114, 401);
            this.txtPunches.Name = "txtPunches";
            this.txtPunches.Size = new System.Drawing.Size(111, 20);
            this.txtPunches.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 437);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Points:";
            // 
            // txtPoints
            // 
            this.txtPoints.Location = new System.Drawing.Point(90, 433);
            this.txtPoints.Name = "txtPoints";
            this.txtPoints.Size = new System.Drawing.Size(140, 20);
            this.txtPoints.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 467);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Required Points:";
            // 
            // txtReqPoints
            // 
            this.txtReqPoints.Location = new System.Drawing.Point(114, 463);
            this.txtReqPoints.Name = "txtReqPoints";
            this.txtReqPoints.Size = new System.Drawing.Size(116, 20);
            this.txtReqPoints.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(0, 128);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Name on Card:";
            // 
            // txtNameOnCard
            // 
            this.txtNameOnCard.Location = new System.Drawing.Point(85, 125);
            this.txtNameOnCard.Name = "txtNameOnCard";
            this.txtNameOnCard.Size = new System.Drawing.Size(140, 20);
            this.txtNameOnCard.TabIndex = 28;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(4, 492);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 13);
            this.label14.TabIndex = 31;
            this.label14.Text = "Required Punches:";
            // 
            // txtReqPunch
            // 
            this.txtReqPunch.Location = new System.Drawing.Point(114, 491);
            this.txtReqPunch.Name = "txtReqPunch";
            this.txtReqPunch.Size = new System.Drawing.Size(118, 20);
            this.txtReqPunch.TabIndex = 30;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 519);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 32;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(124, 519);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 33;
            this.btnCancel.Text = "Close";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // NewPaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 554);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtReqPunch);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtNameOnCard);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtReqPoints);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtPoints);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtPunches);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtUses);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtExp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSecurityCode);
            this.Controls.Add(this.txtCardNumber);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.rdCoupon);
            this.Controls.Add(this.rdLoyalty);
            this.Controls.Add(this.rdDebit);
            this.Controls.Add(this.rdCredit);
            this.Name = "NewPaymentForm";
            this.Text = "NewPaymentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdCredit;
        private System.Windows.Forms.RadioButton rdDebit;
        private System.Windows.Forms.RadioButton rdLoyalty;
        private System.Windows.Forms.RadioButton rdCoupon;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.TextBox txtSecurityCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtExp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUses;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPunches;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPoints;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtReqPoints;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtNameOnCard;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtReqPunch;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}