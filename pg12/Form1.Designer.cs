namespace pg12
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
            this.labelString = new System.Windows.Forms.Label();
            this.labelStringBuilder = new System.Windows.Forms.Label();
            this.stringButton = new System.Windows.Forms.Button();
            this.sBuilderButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelString
            // 
            this.labelString.AutoSize = true;
            this.labelString.Location = new System.Drawing.Point(50, 54);
            this.labelString.Name = "labelString";
            this.labelString.Size = new System.Drawing.Size(104, 17);
            this.labelString.TabIndex = 0;
            this.labelString.Text = "This is a string.";
            // 
            // labelStringBuilder
            // 
            this.labelStringBuilder.AutoSize = true;
            this.labelStringBuilder.Location = new System.Drawing.Point(53, 177);
            this.labelStringBuilder.Name = "labelStringBuilder";
            this.labelStringBuilder.Size = new System.Drawing.Size(150, 17);
            this.labelStringBuilder.TabIndex = 1;
            this.labelStringBuilder.Text = "This is a StringBuilder.";
            // 
            // stringButton
            // 
            this.stringButton.Location = new System.Drawing.Point(56, 105);
            this.stringButton.Name = "stringButton";
            this.stringButton.Size = new System.Drawing.Size(119, 32);
            this.stringButton.TabIndex = 2;
            this.stringButton.Text = "Show String";
            this.stringButton.UseVisualStyleBackColor = true;
            this.stringButton.Click += new System.EventHandler(this.stringButton_Click);
            // 
            // sBuilderButton
            // 
            this.sBuilderButton.Location = new System.Drawing.Point(56, 226);
            this.sBuilderButton.Name = "sBuilderButton";
            this.sBuilderButton.Size = new System.Drawing.Size(119, 32);
            this.sBuilderButton.TabIndex = 3;
            this.sBuilderButton.Text = "String Builder";
            this.sBuilderButton.UseVisualStyleBackColor = true;
            this.sBuilderButton.Click += new System.EventHandler(this.sBuilderButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 426);
            this.Controls.Add(this.sBuilderButton);
            this.Controls.Add(this.stringButton);
            this.Controls.Add(this.labelStringBuilder);
            this.Controls.Add(this.labelString);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelString;
        private System.Windows.Forms.Label labelStringBuilder;
        private System.Windows.Forms.Button stringButton;
        private System.Windows.Forms.Button sBuilderButton;
    }
}

