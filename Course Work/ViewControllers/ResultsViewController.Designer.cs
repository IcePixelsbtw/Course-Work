using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Course_Work
{
    partial class ResultsViewController
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
            this.Text = "ResultsViewController";
            this.resultsDataGrid = new DataGridView();
            this.backButton = new System.Windows.Forms.Button();
            resultsDataGrid.Dock = DockStyle.Fill;

            // 
            // ResultsViewController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.BackColor = Color.FromArgb(255, 232, 232);
            this.Controls.Add(this.resultsDataGrid);
            this.Controls.Add(this.backButton);
            this.Name = "ResultsViewController";
            this.Text = "ResultsViewController";
            this.Load += new System.EventHandler(this.ResultsViewControllerLoad);
            this.ResumeLayout(false);
            this.PerformLayout();
            //
            // resultsDataGrid
            //
            this.resultsDataGrid.Location = new System.Drawing.Point(0, 0);
            this.resultsDataGrid.Name = "resultsDataGrid";
            this.resultsDataGrid.Size = new System.Drawing.Size(300, 300);
            this.resultsDataGrid.ReadOnly = true;
            this.resultsDataGrid.AllowUserToResizeColumns = false;
            this.resultsDataGrid.AllowUserToResizeRows = false;
            this.resultsDataGrid.BackgroundColor = Color.FromArgb(255, 232, 232);
            //
            // backButton
            //
            this.backButton.Location = new System.Drawing.Point(490, 550);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(100, 40);
            this.backButton.Text = "<- Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButtonClicked);

        }



        private System.Windows.Forms.DataGridView resultsDataGrid;
        private System.Windows.Forms.Button backButton;





    }

    #endregion
}