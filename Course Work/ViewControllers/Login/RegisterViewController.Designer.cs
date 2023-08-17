using System.Drawing;

namespace Course_Work
{
    partial class RegisterViewController
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
            this.proceedButton = new System.Windows.Forms.Button();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.emailLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox(); 
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.newButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RegisterViewController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.BackColor = Color.FromArgb(255, 232, 232);
            this.Controls.Add(this.proceedButton);

            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Name = "RegisterViewController";
            this.Text = "RegisterViewController";
            this.Load += new System.EventHandler(this.RegisterViewControllerLoad);
            this.ResumeLayout(false);
            this.PerformLayout();
            //
            // proceedButton
            //
            this.proceedButton.Location = new System.Drawing.Point(200, 250);
            this.proceedButton.Name = "proceedButton";
            this.proceedButton.Size = new System.Drawing.Size(240, 25);
            this.proceedButton.TabIndex = 3;
            this.proceedButton.Text = "Sign up";
            this.proceedButton.UseVisualStyleBackColor = true;
            this.proceedButton.Click += new System.EventHandler(this.proceedButtonClicked);
            //
            // loginButton
            //
            this.loginButton.Location = new System.Drawing.Point(0, 0);
            this.loginButton.Name = "registerViewButton";
            this.loginButton.Size = new System.Drawing.Size(100, 40);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "Log in";
            this.loginButton.Click += new System.EventHandler(this.loginButtonClicked);
            //
            // newButton
            //
            this.newButton.Location = new System.Drawing.Point(0, 0);
            this.newButton.Name = "registerViewButton";
            this.newButton.Size = new System.Drawing.Size(100, 40);
            this.newButton.TabIndex = 3;
            this.newButton.Text = "New button";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.loginButtonClicked);
            //
            // emailTextBox
            //
            this.emailTextBox.Location = new System.Drawing.Point(200, 150);
            this.emailTextBox.Name = "email";
            this.emailTextBox.Size = new System.Drawing.Size(240, 60);
            this.emailTextBox.TabIndex = 1;
 
            //
            // firstNameTextBox
            //
            this.firstNameTextBox.Location = new System.Drawing.Point(200, 50);
            this.firstNameTextBox.Name = "firstName";
            this.firstNameTextBox.Size = new System.Drawing.Size(240, 60);
            this.firstNameTextBox.TabIndex = 1;
            //
            // lastNameTextBox
            //
            this.lastNameTextBox.Location = new System.Drawing.Point(200, 100);
            this.lastNameTextBox.Name = "lastName";
            this.lastNameTextBox.Size = new System.Drawing.Size(240, 60);
            this.lastNameTextBox.TabIndex = 1;
            //
            // passwordTextBox
            //
            this.passwordTextBox.Location = new System.Drawing.Point(200, 200);
            this.passwordTextBox.Name = "password";
            this.passwordTextBox.Size = new System.Drawing.Size(240, 60);
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.TabIndex = 2;
            // 
            // emailLabel
            // 
            this.emailLabel.Location = new System.Drawing.Point(200, 130);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(50, 17);
            this.emailLabel.TabIndex = 6;
            this.emailLabel.Text = "Email";
            // 
            // passwordLabel
            // 
            this.passwordLabel.Location = new System.Drawing.Point(200, 180);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(100, 17);
            this.passwordLabel.TabIndex = 6;
            this.passwordLabel.Text = "Password";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.Location = new System.Drawing.Point(200, 30);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(100, 17);
            this.firstNameLabel.TabIndex = 6;
            this.firstNameLabel.Text = "First Name";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.Location = new System.Drawing.Point(200, 80);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(100, 17);
            this.lastNameLabel.TabIndex = 6;
            this.lastNameLabel.Text = "Last Name";

        }

        private System.Windows.Forms.Button proceedButton;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Button newButton;


        #endregion
    }
}
