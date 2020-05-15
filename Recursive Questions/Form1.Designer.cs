namespace Recursive_Questions
{
    partial class Form1
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
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nonRecursiveFibonnacciLabel = new System.Windows.Forms.Label();
            this.recursiveSumLabel = new System.Windows.Forms.Label();
            this.sumButton = new System.Windows.Forms.Button();
            this.fibonnacciButton = new System.Windows.Forms.Button();
            this.recursiveFibonnacciLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(343, 26);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(147, 31);
            this.inputTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F);
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter a value to solve";
            // 
            // nonRecursiveFibonnacciLabel
            // 
            this.nonRecursiveFibonnacciLabel.AutoSize = true;
            this.nonRecursiveFibonnacciLabel.Location = new System.Drawing.Point(40, 190);
            this.nonRecursiveFibonnacciLabel.Name = "nonRecursiveFibonnacciLabel";
            this.nonRecursiveFibonnacciLabel.Size = new System.Drawing.Size(0, 25);
            this.nonRecursiveFibonnacciLabel.TabIndex = 2;
            // 
            // recursiveSumLabel
            // 
            this.recursiveSumLabel.AutoSize = true;
            this.recursiveSumLabel.Location = new System.Drawing.Point(40, 149);
            this.recursiveSumLabel.Name = "recursiveSumLabel";
            this.recursiveSumLabel.Size = new System.Drawing.Size(0, 25);
            this.recursiveSumLabel.TabIndex = 3;
            // 
            // sumButton
            // 
            this.sumButton.Location = new System.Drawing.Point(123, 86);
            this.sumButton.Name = "sumButton";
            this.sumButton.Size = new System.Drawing.Size(130, 50);
            this.sumButton.TabIndex = 4;
            this.sumButton.Text = "Sum";
            this.sumButton.UseVisualStyleBackColor = true;
            this.sumButton.Click += new System.EventHandler(this.sumButton_Click);
            // 
            // fibonnacciButton
            // 
            this.fibonnacciButton.Location = new System.Drawing.Point(259, 86);
            this.fibonnacciButton.Name = "fibonnacciButton";
            this.fibonnacciButton.Size = new System.Drawing.Size(130, 50);
            this.fibonnacciButton.TabIndex = 5;
            this.fibonnacciButton.Text = "Fibonnacci";
            this.fibonnacciButton.UseVisualStyleBackColor = true;
            this.fibonnacciButton.Click += new System.EventHandler(this.fibonnacciButton_Click);
            // 
            // recursiveFibonnacciLabel
            // 
            this.recursiveFibonnacciLabel.AutoSize = true;
            this.recursiveFibonnacciLabel.Location = new System.Drawing.Point(40, 313);
            this.recursiveFibonnacciLabel.Name = "recursiveFibonnacciLabel";
            this.recursiveFibonnacciLabel.Size = new System.Drawing.Size(0, 25);
            this.recursiveFibonnacciLabel.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 428);
            this.Controls.Add(this.recursiveFibonnacciLabel);
            this.Controls.Add(this.fibonnacciButton);
            this.Controls.Add(this.sumButton);
            this.Controls.Add(this.recursiveSumLabel);
            this.Controls.Add(this.nonRecursiveFibonnacciLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nonRecursiveFibonnacciLabel;
        private System.Windows.Forms.Label recursiveSumLabel;
        private System.Windows.Forms.Button sumButton;
        private System.Windows.Forms.Button fibonnacciButton;
        private System.Windows.Forms.Label recursiveFibonnacciLabel;
    }
}

