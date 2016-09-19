namespace BatteryWatch
{
    partial class InvalidInputWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvalidInputWindow));
            this.okButton = new System.Windows.Forms.Button();
            this.requiredInputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(71, 102);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(89, 61);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // requiredInputLabel
            // 
            this.requiredInputLabel.AutoSize = true;
            this.requiredInputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.requiredInputLabel.Location = new System.Drawing.Point(12, 9);
            this.requiredInputLabel.Name = "requiredInputLabel";
            this.requiredInputLabel.Size = new System.Drawing.Size(251, 68);
            this.requiredInputLabel.TabIndex = 1;
            this.requiredInputLabel.Text = "The percentages must be integers \r\nbetween 2-99 and the minimum\r\npercentage must " +
    "be less than\r\nthe maximum percentage by at least 5.\r\n";
            // 
            // InvalidInputWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 175);
            this.Controls.Add(this.requiredInputLabel);
            this.Controls.Add(this.okButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InvalidInputWindow";
            this.Text = "Invalid Input";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label requiredInputLabel;
    }
}