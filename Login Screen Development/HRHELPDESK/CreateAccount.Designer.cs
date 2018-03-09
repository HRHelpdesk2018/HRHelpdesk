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
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.reenterPasswordLabel = new System.Windows.Forms.Label();
            this.emailAddressLabel = new System.Windows.Forms.Label();
            this.reenterEmailAddressLabel = new System.Windows.Forms.Label();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.reenterPasswordTextBox = new System.Windows.Forms.TextBox();
            this.emailAddressTextBox = new System.Windows.Forms.TextBox();
            this.reenterEmailAddressTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(95, 25);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(157, 20);
            this.usernameTextBox.TabIndex = 2;
            this.usernameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.usernameTextBox_Validating);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(93, 61);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(157, 20);
            this.passwordTextBox.TabIndex = 3;
            this.passwordTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.passwordTextBox_Validating);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(397, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(31, 25);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(58, 13);
            this.usernameLabel.TabIndex = 5;
            this.usernameLabel.Text = "Username:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(31, 64);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(56, 13);
            this.passwordLabel.TabIndex = 6;
            this.passwordLabel.Text = "Password:";
            // 
            // reenterPasswordLabel
            // 
            this.reenterPasswordLabel.AutoSize = true;
            this.reenterPasswordLabel.Location = new System.Drawing.Point(31, 100);
            this.reenterPasswordLabel.Name = "reenterPasswordLabel";
            this.reenterPasswordLabel.Size = new System.Drawing.Size(101, 13);
            this.reenterPasswordLabel.TabIndex = 7;
            this.reenterPasswordLabel.Text = "Re-Enter Password:";
            // 
            // emailAddressLabel
            // 
            this.emailAddressLabel.AutoSize = true;
            this.emailAddressLabel.Location = new System.Drawing.Point(31, 140);
            this.emailAddressLabel.Name = "emailAddressLabel";
            this.emailAddressLabel.Size = new System.Drawing.Size(76, 13);
            this.emailAddressLabel.TabIndex = 8;
            this.emailAddressLabel.Text = "Email Address:";
            // 
            // reenterEmailAddressLabel
            // 
            this.reenterEmailAddressLabel.AutoSize = true;
            this.reenterEmailAddressLabel.Location = new System.Drawing.Point(31, 176);
            this.reenterEmailAddressLabel.Name = "reenterEmailAddressLabel";
            this.reenterEmailAddressLabel.Size = new System.Drawing.Size(121, 13);
            this.reenterEmailAddressLabel.TabIndex = 9;
            this.reenterEmailAddressLabel.Text = "Re-Enter Email Address:";
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Location = new System.Drawing.Point(31, 214);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(81, 13);
            this.phoneNumberLabel.TabIndex = 10;
            this.phoneNumberLabel.Text = "Phone Number:";
            // 
            // reenterPasswordTextBox
            // 
            this.reenterPasswordTextBox.Location = new System.Drawing.Point(138, 97);
            this.reenterPasswordTextBox.Name = "reenterPasswordTextBox";
            this.reenterPasswordTextBox.Size = new System.Drawing.Size(155, 20);
            this.reenterPasswordTextBox.TabIndex = 11;
            this.reenterPasswordTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.reenterPasswordTextBox_Validating);
            // 
            // emailAddressTextBox
            // 
            this.emailAddressTextBox.Location = new System.Drawing.Point(113, 137);
            this.emailAddressTextBox.Name = "emailAddressTextBox";
            this.emailAddressTextBox.Size = new System.Drawing.Size(154, 20);
            this.emailAddressTextBox.TabIndex = 12;
            this.emailAddressTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.emailAddressTextBox_Validating);
            // 
            // reenterEmailAddressTextBox
            // 
            this.reenterEmailAddressTextBox.Location = new System.Drawing.Point(158, 173);
            this.reenterEmailAddressTextBox.Name = "reenterEmailAddressTextBox";
            this.reenterEmailAddressTextBox.Size = new System.Drawing.Size(154, 20);
            this.reenterEmailAddressTextBox.TabIndex = 13;
            this.reenterEmailAddressTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.reenterEmailAddressTextBox_Validating);
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Location = new System.Drawing.Point(118, 214);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(154, 20);
            this.phoneNumberTextBox.TabIndex = 14;
            this.phoneNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phoneNumberTextBox_KeyPress);
            this.phoneNumberTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.phoneNumberTextBox_Validating);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 326);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(this.reenterEmailAddressTextBox);
            this.Controls.Add(this.emailAddressTextBox);
            this.Controls.Add(this.reenterPasswordTextBox);
            this.Controls.Add(this.phoneNumberLabel);
            this.Controls.Add(this.reenterEmailAddressLabel);
            this.Controls.Add(this.emailAddressLabel);
            this.Controls.Add(this.reenterPasswordLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
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
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label reenterPasswordLabel;
        private System.Windows.Forms.Label emailAddressLabel;
        private System.Windows.Forms.Label reenterEmailAddressLabel;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.TextBox reenterPasswordTextBox;
        private System.Windows.Forms.TextBox emailAddressTextBox;
        private System.Windows.Forms.TextBox reenterEmailAddressTextBox;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}