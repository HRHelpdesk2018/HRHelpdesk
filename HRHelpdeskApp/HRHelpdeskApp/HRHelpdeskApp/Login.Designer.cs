namespace HRHelpdeskApp
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
            this.newAccountButton = new System.Windows.Forms.Button();
            this.noAccountLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // newAccountButton
            // 
            this.newAccountButton.Location = new System.Drawing.Point(262, 176);
            this.newAccountButton.Name = "newAccountButton";
            this.newAccountButton.Size = new System.Drawing.Size(208, 35);
            this.newAccountButton.TabIndex = 15;
            this.newAccountButton.Text = "Sign Up";
            this.newAccountButton.UseVisualStyleBackColor = true;
            this.newAccountButton.Click += new System.EventHandler(this.newAccountButton_Click);
            // 
            // noAccountLabel
            // 
            this.noAccountLabel.AutoSize = true;
            this.noAccountLabel.Font = new System.Drawing.Font("Goudy Old Style", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noAccountLabel.Location = new System.Drawing.Point(13, 188);
            this.noAccountLabel.Name = "noAccountLabel";
            this.noAccountLabel.Size = new System.Drawing.Size(233, 21);
            this.noAccountLabel.TabIndex = 14;
            this.noAccountLabel.Text = "Don\'t have an account? Click here";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(262, 110);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(208, 45);
            this.cancelButton.TabIndex = 13;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(17, 110);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(208, 45);
            this.loginButton.TabIndex = 12;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(147, 67);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(218, 20);
            this.passwordTextBox.TabIndex = 11;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(147, 17);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(218, 20);
            this.usernameTextBox.TabIndex = 10;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Goudy Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(12, 59);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(109, 28);
            this.passwordLabel.TabIndex = 9;
            this.passwordLabel.Text = "Password:";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Goudy Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(12, 9);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(118, 28);
            this.usernameLabel.TabIndex = 8;
            this.usernameLabel.Text = "Username:";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 248);
            this.Controls.Add(this.newAccountButton);
            this.Controls.Add(this.noAccountLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newAccountButton;
        private System.Windows.Forms.Label noAccountLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label usernameLabel;
    }
}