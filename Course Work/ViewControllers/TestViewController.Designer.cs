using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Course_Work
{
    partial class TestViewController
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


        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "TestViewController";
            this.answerNumberOne = new RadioButton();
            this.answerNumberTwo = new RadioButton();
            this.answerNumberThree = new RadioButton();
            this.answerNumberFour = new RadioButton();
            this.nextButton = new Button();
            this.questionTextLabel = new System.Windows.Forms.Label();


            // 
            // TestViewController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.Controls.Add(answerNumberOne);
            this.Controls.Add(answerNumberTwo);
            this.Controls.Add(answerNumberThree);
            this.Controls.Add(answerNumberFour);
            this.Controls.Add(questionTextLabel);
            this.Controls.Add(nextButton);

            this.BackColor = Color.FromArgb(255, 232, 232);
            this.Name = "TestViewController";
            this.Text = "TestViewController";
            this.Load += new System.EventHandler(this.TestViewControllerLoad);
            this.ResumeLayout(false);
            this.PerformLayout();
            //
            // answerNumberOne
            //
            this.answerNumberOne.Location = new System.Drawing.Point(20, 300);
            this.answerNumberOne.Name = "answerNumberOne";
            this.answerNumberOne.Size = new System.Drawing.Size(250, 40);
            this.answerNumberOne.Text = "A";
            this.answerNumberOne.UseVisualStyleBackColor = true;
            //
            // answerNumberTwo
            //
            this.answerNumberTwo.Location = new System.Drawing.Point(20, 400);
            this.answerNumberTwo.Name = "answerNumberTwo";
            this.answerNumberTwo.Size = new System.Drawing.Size(250, 40);
            this.answerNumberTwo.Text = "B";
            this.answerNumberTwo.UseVisualStyleBackColor = true;
            //
            // answerNumberThree
            //
            this.answerNumberThree.Location = new System.Drawing.Point(350, 300);
            this.answerNumberThree.Name = "answerNumberThree";
            this.answerNumberThree.Size = new System.Drawing.Size(250, 40);
            this.answerNumberThree.Text = "C";
            this.answerNumberThree.UseVisualStyleBackColor = true;
            //
            // answerNumberFour
            //
            this.answerNumberFour.Location = new System.Drawing.Point(350, 400);
            this.answerNumberFour.Name = "answerNumberFour";
            this.answerNumberFour.Size = new System.Drawing.Size(250, 40);
            this.answerNumberFour.Text = "D";
            this.answerNumberFour.UseVisualStyleBackColor = true;
            //
            // questionTextLabel
            //
            this.questionTextLabel.Location = new System.Drawing.Point(100, 100);
            this.questionTextLabel.Name = "questionTextLabel";
            this.questionTextLabel.Size = new System.Drawing.Size(300, 300);
            this.questionTextLabel.Text = "There should be a question text";
            //
            // nextButton
            //
            this.nextButton.Location = new System.Drawing.Point(490, 550);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(100, 40);
            this.nextButton.TabIndex = 3;
            this.nextButton.Text = "Next ->";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButtonClicked);

        }
            private System.Windows.Forms.RadioButton answerNumberOne;
            private System.Windows.Forms.RadioButton answerNumberTwo;
            private System.Windows.Forms.RadioButton answerNumberThree;
            private System.Windows.Forms.RadioButton answerNumberFour;
            private System.Windows.Forms.Label questionTextLabel;
            private System.Windows.Forms.Button nextButton;
    }



    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>


    #endregion
}
