namespace DayBreakDesCrypto
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtnEncrypt = new Button();
            TxtPlainText = new TextBox();
            TxtEncodedText = new TextBox();
            BtnDecrypt = new Button();
            BtnHash = new Button();
            TxtPasswordMD5 = new TextBox();
            TxtUserName = new TextBox();
            TxtPassword = new TextBox();
            SuspendLayout();
            // 
            // BtnEncrypt
            // 
            BtnEncrypt.Location = new Point(425, 12);
            BtnEncrypt.Name = "BtnEncrypt";
            BtnEncrypt.Size = new Size(75, 23);
            BtnEncrypt.TabIndex = 0;
            BtnEncrypt.Text = "Encrypt";
            BtnEncrypt.UseVisualStyleBackColor = true;
            BtnEncrypt.Click += BtnEncrypt_Click;
            // 
            // TxtPlainText
            // 
            TxtPlainText.Location = new Point(12, 12);
            TxtPlainText.Multiline = true;
            TxtPlainText.Name = "TxtPlainText";
            TxtPlainText.Size = new Size(407, 90);
            TxtPlainText.TabIndex = 1;
            // 
            // TxtEncodedText
            // 
            TxtEncodedText.Location = new Point(506, 12);
            TxtEncodedText.Multiline = true;
            TxtEncodedText.Name = "TxtEncodedText";
            TxtEncodedText.Size = new Size(407, 90);
            TxtEncodedText.TabIndex = 1;
            // 
            // BtnDecrypt
            // 
            BtnDecrypt.Location = new Point(425, 41);
            BtnDecrypt.Name = "BtnDecrypt";
            BtnDecrypt.Size = new Size(75, 23);
            BtnDecrypt.TabIndex = 0;
            BtnDecrypt.Text = "Decrypt";
            BtnDecrypt.UseVisualStyleBackColor = true;
            BtnDecrypt.Click += BtnDecrypt_Click;
            // 
            // BtnHash
            // 
            BtnHash.Location = new Point(425, 112);
            BtnHash.Name = "BtnHash";
            BtnHash.Size = new Size(75, 23);
            BtnHash.TabIndex = 0;
            BtnHash.Text = "Hash";
            BtnHash.UseVisualStyleBackColor = true;
            BtnHash.Click += BtnHash_Click;
            // 
            // TxtPasswordMD5
            // 
            TxtPasswordMD5.Location = new Point(506, 113);
            TxtPasswordMD5.Multiline = true;
            TxtPasswordMD5.Name = "TxtPasswordMD5";
            TxtPasswordMD5.Size = new Size(407, 90);
            TxtPasswordMD5.TabIndex = 1;
            // 
            // TxtUserName
            // 
            TxtUserName.Location = new Point(12, 113);
            TxtUserName.Name = "TxtUserName";
            TxtUserName.Size = new Size(407, 23);
            TxtUserName.TabIndex = 2;
            // 
            // TxtPassword
            // 
            TxtPassword.Location = new Point(12, 142);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.Size = new Size(407, 23);
            TxtPassword.TabIndex = 2;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(923, 615);
            Controls.Add(TxtPassword);
            Controls.Add(TxtUserName);
            Controls.Add(TxtEncodedText);
            Controls.Add(TxtPasswordMD5);
            Controls.Add(TxtPlainText);
            Controls.Add(BtnHash);
            Controls.Add(BtnDecrypt);
            Controls.Add(BtnEncrypt);
            Name = "FrmMain";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnEncrypt;
        private TextBox TxtPlainText;
        private TextBox TxtEncodedText;
        private Button BtnDecrypt;
        private Button BtnHash;
        private TextBox TxtPasswordMD5;
        private TextBox TxtUserName;
        private TextBox TxtPassword;
    }
}