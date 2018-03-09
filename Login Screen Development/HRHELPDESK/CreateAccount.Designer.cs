namespace HRHELPDESK
{
    partial class CreateAccount
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
            this.components = new System.ComponentModel.Container();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.reenterPasswordLabel = new System.Windows.Forms.Label();
            this.reenterPasswordTextBox = new System.Windows.Forms.TextBox();
            this.emailaddressLabel = new System.Windows.Forms.Label();
            this.emailAddressTextBox = new System.Windows.Forms.TextBox();
            this.reenteremailAddressLabel = new System.Windows.Forms.Label();
            this.reenterEmailAddressTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.createButton = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(77, 24);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(157, 20);
            this.usernameTextBox.TabIndex = 2;
            this.usernameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.usernameTextBox_Validating);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(77, 61);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(144, 20);
            this.passwordTextBox.TabIndex = 3;
            this.passwordTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.passwordTextBox_Validating);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(497, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(13, 27);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(58, 13);
            this.userNameLabel.TabIndex = 5;
            this.userNameLabel.Text = "Username:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(15, 64);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(56, 13);
            this.passwordLabel.TabIndex = 6;
            this.passwordLabel.Text = "Password:";
            // 
            // reenterPasswordLabel
            // 
            this.reenterPasswordLabel.AutoSize = true;
            this.reenterPasswordLabel.Location = new System.Drawing.Point(12, 101);
            this.reenterPasswordLabel.Name = "reenterPasswordLabel";
            this.reenterPasswordLabel.Size = new System.Drawing.Size(100, 13);
            this.reenterPasswordLabel.TabIndex = 7;
            this.reenterPasswordLabel.Text = "Re-enter Password:";
            // 
            // reenterPasswordTextBox
            // 
            this.reenterPasswordTextBox.Location = new System.Drawing.Point(122, 98);
            this.reenterPasswordTextBox.Name = "reenterPasswordTextBox";
            this.reenterPasswordTextBox.Size = new System.Drawing.Size(157, 20);
            this.reenterPasswordTextBox.TabIndex = 8;
            this.reenterPasswordTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.reenterPasswordTextBox_Validating);
            // 
            // emailaddressLabel
            // 
            this.emailaddressLabel.AutoSize = true;
            this.emailaddressLabel.Location = new System.Drawing.Point(15, 135);
            this.emailaddressLabel.Name = "emailaddressLabel";
            this.emailaddressLabel.Size = new System.Drawing.Size(76, 13);
            this.emailaddressLabel.TabIndex = 9;
            this.emailaddressLabel.Text = "Email Address:";
            // 
            // emailAddressTextBox
            // 
            this.emailAddressTextBox.Location = new System.Drawing.Point(97, 132);
            this.emailAddressTextBox.Name = "emailAddressTextBox";
            this.emailAddressTextBox.Size = new System.Drawing.Size(157, 20);
            this.emailAddressTextBox.TabIndex = 10;
            this.emailAddressTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.emailAddressTextBox_Validating);
            // 
            // reenteremailAddressLabel
            // 
            this.reenteremailAddressLabel.AutoSize = true;
            this.reenteremailAddressLabel.Location = new System.Drawing.Point(12, 169);
            this.reenteremailAddressLabel.Name = "reenteremailAddressLabel";
            this.reenteremailAddressLabel.Size = new System.Drawing.Size(120, 13);
            this.reenteremailAddressLabel.TabIndex = 11;
            this.reenteremailAddressLabel.Text = "Re-enter Email Address:";
            // 
            // reenterEmailAddressTextBox
            // 
            this.reenterEmailAddressTextBox.Location = new System.Drawing.Point(138, 166);
            this.reenterEmailAddressTextBox.Name = "reenterEmailAddressTextBox";
            this.reenterEmailAddressTextBox.Size = new System.Drawing.Size(157, 20);
            this.reenterEmailAddressTextBox.TabIndex = 12;
            this.reenterEmailAddressTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.reenterEmailAddressTextBox_Validating);
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Location = new System.Drawing.Point(15, 204);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(81, 13);
            this.phoneNumberLabel.TabIndex = 13;
            this.phoneNumberLabel.Text = "Phone Number:";
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Location = new System.Drawing.Point(102, 201);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(156, 20);
            this.phoneNumberTextBox.TabIndex = 14;
            this.phoneNumberTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.phoneNumberTextBox_Validating);
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(250, 257);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(132, 23);
            this.createButton.TabIndex = 15;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 350);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(this.phoneNumberLabel);
            this.Controls.Add(this.reenterEmailAddressTextBox);
            this.Controls.Add(this.reenteremailAddressLabel);
            this.Controls.Add(this.emailAddressTextBox);
            this.Controls.Add(this.emailaddressLabel);
            this.Controls.Add(this.reenterPasswordTextBox);
            this.Controls.Add(this.reenterPasswordLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Name = "CreateAccount";
            this.Text = "CreateAccount";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label reenterPasswordLabel;
        private System.Windows.Forms.TextBox reenterPasswordTextBox;
        private System.Windows.Forms.Label emailaddressLabel;
        private System.Windows.Forms.TextBox emailAddressTextBox;
        private System.Windows.Forms.Label reenteremailAddressLabel;
        private System.Windows.Forms.TextBox reenterEmailAddressTextBox;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}