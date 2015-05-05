namespace UserInterface
{
    partial class MainForm
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
            this.uxPaymentOptions = new System.Windows.Forms.Button();
            this.uxSettings = new System.Windows.Forms.Button();
            this.uxName = new System.Windows.Forms.Label();
            this.txtTextFile = new System.Windows.Forms.TextBox();
            this.btnTextFile = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxPaymentOptions
            // 
            this.uxPaymentOptions.Location = new System.Drawing.Point(12, 117);
            this.uxPaymentOptions.Name = "uxPaymentOptions";
            this.uxPaymentOptions.Size = new System.Drawing.Size(186, 23);
            this.uxPaymentOptions.TabIndex = 0;
            this.uxPaymentOptions.Text = "Payment Options/Make Purchase";
            this.uxPaymentOptions.UseVisualStyleBackColor = true;
            this.uxPaymentOptions.Click += new System.EventHandler(this.uxPaymentOptions_Click);
            // 
            // uxSettings
            // 
            this.uxSettings.Location = new System.Drawing.Point(244, 117);
            this.uxSettings.Name = "uxSettings";
            this.uxSettings.Size = new System.Drawing.Size(101, 23);
            this.uxSettings.TabIndex = 2;
            this.uxSettings.Text = "Account Settings";
            this.uxSettings.UseVisualStyleBackColor = true;
            this.uxSettings.Click += new System.EventHandler(this.uxSettings_Click);
            // 
            // uxName
            // 
            this.uxName.AutoSize = true;
            this.uxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxName.Location = new System.Drawing.Point(151, 44);
            this.uxName.Name = "uxName";
            this.uxName.Size = new System.Drawing.Size(173, 20);
            this.uxName.TabIndex = 3;
            this.uxName.Text = "username goes here";
            this.uxName.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtTextFile
            // 
            this.txtTextFile.Location = new System.Drawing.Point(155, 174);
            this.txtTextFile.Multiline = true;
            this.txtTextFile.Name = "txtTextFile";
            this.txtTextFile.Size = new System.Drawing.Size(296, 247);
            this.txtTextFile.TabIndex = 4;
            // 
            // btnTextFile
            // 
            this.btnTextFile.Location = new System.Drawing.Point(38, 293);
            this.btnTextFile.Name = "btnTextFile";
            this.btnTextFile.Size = new System.Drawing.Size(75, 23);
            this.btnTextFile.TabIndex = 5;
            this.btnTextFile.Text = "Text File Data";
            this.btnTextFile.UseVisualStyleBackColor = true;
            this.btnTextFile.Click += new System.EventHandler(this.btnTextFile_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(391, 117);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(75, 23);
            this.buttonLogout.TabIndex = 6;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 455);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.btnTextFile);
            this.Controls.Add(this.txtTextFile);
            this.Controls.Add(this.uxName);
            this.Controls.Add(this.uxSettings);
            this.Controls.Add(this.uxPaymentOptions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainForm";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxPaymentOptions;
        private System.Windows.Forms.Button uxSettings;
        private System.Windows.Forms.Label uxName;
        private System.Windows.Forms.TextBox txtTextFile;
        private System.Windows.Forms.Button btnTextFile;
        private System.Windows.Forms.Button buttonLogout;
    }
}

