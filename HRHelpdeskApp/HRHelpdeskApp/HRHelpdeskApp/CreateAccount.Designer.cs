namespace HRHelpdeskApp
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
            this.memberLabel = new System.Windows.Forms.Label();
            this.memberButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.reenterPasswordTextBox = new System.Windows.Forms.TextBox();
            this.reenterPasswordLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.createButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // memberLabel
            // 
            this.memberLabel.AutoSize = true;
            this.memberLabel.Font = new System.Drawing.Font("Goudy Old Style", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberLabel.Location = new System.Drawing.Point(10, 281);
            this.memberLabel.Name = "memberLabel";
            this.memberLabel.Size = new System.Drawing.Size(299, 21);
            this.memberLabel.TabIndex = 24;
            this.memberLabel.Text = "Already have an existing account? Click here";
            // 
            // memberButton
            // 
            this.memberButton.Location = new System.Drawing.Point(315, 262);
            this.memberButton.Name = "memberButton";
            this.memberButton.Size = new System.Drawing.Size(200, 49);
            this.memberButton.TabIndex = 20;
            this.memberButton.Text = "Sign In";
            this.memberButton.UseVisualStyleBackColor = true;
            this.memberButton.Click += new System.EventHandler(this.memberButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(364, 172);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(200, 45);
            this.CancelButton.TabIndex = 19;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // reenterPasswordTextBox
            // 
            this.reenterPasswordTextBox.Location = new System.Drawing.Point(217, 129);
            this.reenterPasswordTextBox.Name = "reenterPasswordTextBox";
            this.reenterPasswordTextBox.Size = new System.Drawing.Size(201, 20);
            this.reenterPasswordTextBox.TabIndex = 17;
            // 
            // reenterPasswordLabel
            // 
            this.reenterPasswordLabel.AutoSize = true;
            this.reenterPasswordLabel.Font = new System.Drawing.Font("Goudy Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reenterPasswordLabel.Location = new System.Drawing.Point(9, 121);
            this.reenterPasswordLabel.Name = "reenterPasswordLabel";
            this.reenterPasswordLabel.Size = new System.Drawing.Size(202, 28);
            this.reenterPasswordLabel.TabIndex = 20;
            this.reenterPasswordLabel.Text = "Re-Enter Password:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Goudy Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(9, 64);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(109, 28);
            this.passwordLabel.TabIndex = 19;
            this.passwordLabel.Text = "Password:";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Goudy Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(9, 13);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(118, 28);
            this.usernameLabel.TabIndex = 18;
            this.usernameLabel.Text = "Username:";
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(94, 172);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(200, 45);
            this.createButton.TabIndex = 18;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(133, 72);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(201, 20);
            this.passwordTextBox.TabIndex = 16;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(149, 21);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(201, 20);
            this.usernameTextBox.TabIndex = 15;
            // 
            // CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(721, 323);
            this.Controls.Add(this.memberLabel);
            this.Controls.Add(this.memberButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.reenterPasswordTextBox);
            this.Controls.Add(this.reenterPasswordLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Name = "CreateAccount";
            this.Text = "CreateAccount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label memberLabel;
        private System.Windows.Forms.Button memberButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.TextBox reenterPasswordTextBox;
        private System.Windows.Forms.Label reenterPasswordLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
    }
}