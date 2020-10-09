namespace P4_Code
{
    partial class Login
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
            this.userNameText = new System.Windows.Forms.Label();
            this.passwordText = new System.Windows.Forms.Label();
            this.userNameInput = new System.Windows.Forms.TextBox();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userNameText
            // 
            this.userNameText.AutoSize = true;
            this.userNameText.Location = new System.Drawing.Point(120, 78);
            this.userNameText.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.userNameText.Name = "userNameText";
            this.userNameText.Size = new System.Drawing.Size(164, 32);
            this.userNameText.TabIndex = 0;
            this.userNameText.Text = "User Name:";
            this.userNameText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // passwordText
            // 
            this.passwordText.AutoSize = true;
            this.passwordText.Location = new System.Drawing.Point(142, 147);
            this.passwordText.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(147, 32);
            this.passwordText.TabIndex = 1;
            this.passwordText.Text = "Password:";
            this.passwordText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // userNameInput
            // 
            this.userNameInput.Location = new System.Drawing.Point(300, 78);
            this.userNameInput.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.userNameInput.Name = "userNameInput";
            this.userNameInput.Size = new System.Drawing.Size(898, 38);
            this.userNameInput.TabIndex = 1;
            // 
            // passwordInput
            // 
            this.passwordInput.Location = new System.Drawing.Point(300, 147);
            this.passwordInput.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.PasswordChar = '*';
            this.passwordInput.Size = new System.Drawing.Size(898, 38);
            this.passwordInput.TabIndex = 2;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(588, 234);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(272, 60);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(930, 234);
            this.loginButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(272, 60);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 393);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.userNameInput);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.userNameText);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userNameText;
        private System.Windows.Forms.Label passwordText;
        private System.Windows.Forms.TextBox userNameInput;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button loginButton;
    }
}

