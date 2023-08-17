using System.Drawing;

namespace Course_Work
{
    partial class LoginViewController
    {
   
        private System.ComponentModel.IContainer components = null;

    
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
      
        private void InitializeComponent()
        {
            this.proceedButton =  new System.Windows.Forms.Button();
            this.emailTextBox = new System.Windows.Forms.TextBox(); 
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.registerViewButton = new System.Windows.Forms.Button();
            this.emailLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.BackColor = Color.FromArgb(255, 232, 232);
            this.Controls.Add(this.proceedButton);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.registerViewButton);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.passwordLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LoginViewControllerLoad);
            this.ResumeLayout(false);
            this.PerformLayout();
            //
            // proceedButton
            //
            this.proceedButton.Location = new System.Drawing.Point(200, 150);
            this.proceedButton.Name     = "proceedButton";
            this.proceedButton.Size     = new System.Drawing.Size(240, 25);
            this.proceedButton.TabIndex = 3;
            this.proceedButton.Text     = "Sign in";
            this.proceedButton.UseVisualStyleBackColor = true;
            this.proceedButton.Click   += new System.EventHandler(this.proceedButtonClicked);
            //
            // registerViewButton
            //
            this.registerViewButton.Location = new System.Drawing.Point(0, 0);
            this.registerViewButton.Name = "registerViewButton";
            this.registerViewButton.Size = new System.Drawing.Size(100, 40);
            this.registerViewButton.TabIndex = 3;
            this.registerViewButton.Text = "Register";
            this.registerViewButton.UseVisualStyleBackColor = true;
            this.registerViewButton.Click += new System.EventHandler(this.registerViewButtonClicked);
            //
            // emailTextBox
            //
            this.emailTextBox.Location = new System.Drawing.Point(200, 50);
            this.emailTextBox.Name = "userName";
            this.emailTextBox.Size = new System.Drawing.Size(240, 60);
            this.emailTextBox.TabIndex = 1;
            //
            // passwordTextBox
            //
            this.passwordTextBox.Location = new System.Drawing.Point(200, 100);
            this.passwordTextBox.Name = "password";
            this.passwordTextBox.Size = new System.Drawing.Size(240, 60);
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.TabIndex = 2;
            // 
            // emailLabel
            // 
            this.emailLabel.Location = new System.Drawing.Point(200, 30);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(50, 17);
            this.emailLabel.TabIndex = 6;
            this.emailLabel.Text = "Email";
            // 
            // passwordLabel
            // 
            this.passwordLabel.Location = new System.Drawing.Point(200, 80);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(100, 17);
            this.passwordLabel.TabIndex = 6;
            this.passwordLabel.Text = "Password";

        }

        private System.Windows.Forms.Button proceedButton;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button registerViewButton;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label passwordLabel;




        #endregion
    }
}

