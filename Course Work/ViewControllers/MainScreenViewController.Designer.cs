using System.Drawing;

namespace Course_Work
{
    partial class MainScreenViewController
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
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Form2";
            this.listButton = new System.Windows.Forms.Button();
            this.testButton = new System.Windows.Forms.Button();
            // 
            // MainScreenViewController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.BackColor = Color.FromArgb(255, 232, 232);
            this.Controls.Add(this.listButton);
            this.Controls.Add(this.testButton);
            this.Name = "MainScreenViewController";
            this.Text = "MainScreenViewController";
            this.Load += new System.EventHandler(this.MainScreenViewControllerLoad);
            this.ResumeLayout(false);
            this.PerformLayout();
            //
            // listButton
            //
            this.listButton.Location = new System.Drawing.Point(250, 250);
            this.listButton.Name = "listButton";
            this.listButton.Size = new System.Drawing.Size(100, 40);
            this.listButton.TabIndex = 3;
            this.listButton.Text = "Records";
            this.listButton.UseVisualStyleBackColor = true;
            this.listButton.Click += new System.EventHandler(this.listButtonClicked);
            //
            // testButton
            //
            this.testButton.Location = new System.Drawing.Point(250, 200);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(100, 40);
            this.testButton.TabIndex = 3;
            this.testButton.Text = "Test";
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.testButtonClicked);
        }


           private System.Windows.Forms.Button listButton;
           private System.Windows.Forms.Button testButton;
        }

        #endregion
    }
