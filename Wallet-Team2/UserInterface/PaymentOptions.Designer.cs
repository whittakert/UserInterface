namespace UserInterface
{
    partial class PaymentOptions
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
            this.uxSave = new System.Windows.Forms.Button();
            this.uxCancel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxSave
            // 
            this.uxSave.Location = new System.Drawing.Point(12, 28);
            this.uxSave.Name = "uxSave";
            this.uxSave.Size = new System.Drawing.Size(94, 23);
            this.uxSave.TabIndex = 54;
            this.uxSave.Text = "Make Purchase";
            this.uxSave.UseVisualStyleBackColor = true;
            this.uxSave.Click += new System.EventHandler(this.uxSave_Click);
            // 
            // uxCancel
            // 
            this.uxCancel.Location = new System.Drawing.Point(128, 28);
            this.uxCancel.Name = "uxCancel";
            this.uxCancel.Size = new System.Drawing.Size(75, 23);
            this.uxCancel.TabIndex = 55;
            this.uxCancel.Text = "Cancel";
            this.uxCancel.UseVisualStyleBackColor = true;
            this.uxCancel.Click += new System.EventHandler(this.uxCancel_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(224, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 58;
            this.button1.Text = "New Payment";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PaymentOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 71);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.uxCancel);
            this.Controls.Add(this.uxSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "PaymentOptions";
            this.Text = "Payment Options";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uxSave;
        private System.Windows.Forms.Button uxCancel;
        private System.Windows.Forms.Button button1;
    }
}