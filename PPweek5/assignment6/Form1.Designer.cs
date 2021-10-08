
namespace assignment6
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.beforeLabel = new System.Windows.Forms.Label();
            this.afterLabel = new System.Windows.Forms.Label();
            this.OutputBeforeLabel = new System.Windows.Forms.Label();
            this.outputAfterLabel = new System.Windows.Forms.Label();
            this.comparisonLabel = new System.Windows.Forms.Label();
            this.compareBox = new System.Windows.Forms.TextBox();
            this.compareButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // beforeLabel
            // 
            this.beforeLabel.AutoSize = true;
            this.beforeLabel.Location = new System.Drawing.Point(47, 30);
            this.beforeLabel.Name = "beforeLabel";
            this.beforeLabel.Size = new System.Drawing.Size(124, 15);
            this.beforeLabel.TabIndex = 0;
            this.beforeLabel.Text = "Content table (before)";
            // 
            // afterLabel
            // 
            this.afterLabel.AutoSize = true;
            this.afterLabel.Location = new System.Drawing.Point(229, 30);
            this.afterLabel.Name = "afterLabel";
            this.afterLabel.Size = new System.Drawing.Size(114, 15);
            this.afterLabel.TabIndex = 1;
            this.afterLabel.Text = "Content table (after)";
            // 
            // OutputBeforeLabel
            // 
            this.OutputBeforeLabel.AutoSize = true;
            this.OutputBeforeLabel.Location = new System.Drawing.Point(47, 66);
            this.OutputBeforeLabel.Name = "OutputBeforeLabel";
            this.OutputBeforeLabel.Size = new System.Drawing.Size(0, 15);
            this.OutputBeforeLabel.TabIndex = 2;
            // 
            // outputAfterLabel
            // 
            this.outputAfterLabel.AutoSize = true;
            this.outputAfterLabel.Location = new System.Drawing.Point(229, 66);
            this.outputAfterLabel.Name = "outputAfterLabel";
            this.outputAfterLabel.Size = new System.Drawing.Size(0, 15);
            this.outputAfterLabel.TabIndex = 3;
            // 
            // comparisonLabel
            // 
            this.comparisonLabel.AutoSize = true;
            this.comparisonLabel.Location = new System.Drawing.Point(48, 399);
            this.comparisonLabel.Name = "comparisonLabel";
            this.comparisonLabel.Size = new System.Drawing.Size(117, 15);
            this.comparisonLabel.TabIndex = 4;
            this.comparisonLabel.Text = "Comparison number";
            // 
            // compareBox
            // 
            this.compareBox.Location = new System.Drawing.Point(207, 396);
            this.compareBox.Name = "compareBox";
            this.compareBox.Size = new System.Drawing.Size(74, 23);
            this.compareBox.TabIndex = 5;
            // 
            // compareButton
            // 
            this.compareButton.Location = new System.Drawing.Point(302, 396);
            this.compareButton.Name = "compareButton";
            this.compareButton.Size = new System.Drawing.Size(75, 23);
            this.compareButton.TabIndex = 6;
            this.compareButton.Text = "Compare";
            this.compareButton.UseVisualStyleBackColor = true;
            this.compareButton.Click += new System.EventHandler(this.compareButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 461);
            this.Controls.Add(this.compareButton);
            this.Controls.Add(this.compareBox);
            this.Controls.Add(this.comparisonLabel);
            this.Controls.Add(this.outputAfterLabel);
            this.Controls.Add(this.OutputBeforeLabel);
            this.Controls.Add(this.afterLabel);
            this.Controls.Add(this.beforeLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label beforeLabel;
        private System.Windows.Forms.Label afterLabel;
        private System.Windows.Forms.Label OutputBeforeLabel;
        private System.Windows.Forms.Label outputAfterLabel;
        private System.Windows.Forms.Label comparisonLabel;
        private System.Windows.Forms.TextBox compareBox;
        private System.Windows.Forms.Button compareButton;
    }
}

