namespace HRHelpdeskApp
{
    partial class FormSelection
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
            this.generalInformationButton = new System.Windows.Forms.Button();
            this.medicalInformationForm = new System.Windows.Forms.Button();
            this.logOutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // generalInformationButton
            // 
            this.generalInformationButton.Location = new System.Drawing.Point(68, 62);
            this.generalInformationButton.Name = "generalInformationButton";
            this.generalInformationButton.Size = new System.Drawing.Size(141, 114);
            this.generalInformationButton.TabIndex = 0;
            this.generalInformationButton.Text = "Click here to open General Information Form";
            this.generalInformationButton.UseVisualStyleBackColor = true;
            this.generalInformationButton.Click += new System.EventHandler(this.generalInformationButton_Click);
            // 
            // medicalInformationForm
            // 
            this.medicalInformationForm.Location = new System.Drawing.Point(322, 62);
            this.medicalInformationForm.Name = "medicalInformationForm";
            this.medicalInformationForm.Size = new System.Drawing.Size(141, 114);
            this.medicalInformationForm.TabIndex = 1;
            this.medicalInformationForm.Text = "Click here to open Medical Information Form";
            this.medicalInformationForm.UseVisualStyleBackColor = true;
            this.medicalInformationForm.Click += new System.EventHandler(this.medicalInformationForm_Click);
            // 
            // logOutButton
            // 
            this.logOutButton.Location = new System.Drawing.Point(297, 190);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(194, 60);
            this.logOutButton.TabIndex = 2;
            this.logOutButton.Text = "Log Out";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // FormSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 262);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.medicalInformationForm);
            this.Controls.Add(this.generalInformationButton);
            this.Name = "FormSelection";
            this.Text = "FormSelection";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button generalInformationButton;
        private System.Windows.Forms.Button medicalInformationForm;
        private System.Windows.Forms.Button logOutButton;
    }
}