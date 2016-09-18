namespace BatteryWatch
{
    partial class SettingsWindow
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
            this.lowestBatteryPercentTextBox = new System.Windows.Forms.TextBox();
            this.highestBatteryPercentTextBox = new System.Windows.Forms.TextBox();
            this.lowestBatteryPercentageLabel = new System.Windows.Forms.Label();
            this.highestBatteryPercentageLabel = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lowestBatteryPercentTextBox
            // 
            this.lowestBatteryPercentTextBox.Location = new System.Drawing.Point(12, 123);
            this.lowestBatteryPercentTextBox.Name = "lowestBatteryPercentTextBox";
            this.lowestBatteryPercentTextBox.Size = new System.Drawing.Size(100, 22);
            this.lowestBatteryPercentTextBox.TabIndex = 0;
            // 
            // highestBatteryPercentTextBox
            // 
            this.highestBatteryPercentTextBox.Location = new System.Drawing.Point(170, 123);
            this.highestBatteryPercentTextBox.Name = "highestBatteryPercentTextBox";
            this.highestBatteryPercentTextBox.Size = new System.Drawing.Size(100, 22);
            this.highestBatteryPercentTextBox.TabIndex = 1;
            // 
            // lowestBatteryPercentageLabel
            // 
            this.lowestBatteryPercentageLabel.AutoSize = true;
            this.lowestBatteryPercentageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lowestBatteryPercentageLabel.Location = new System.Drawing.Point(12, 93);
            this.lowestBatteryPercentageLabel.Name = "lowestBatteryPercentageLabel";
            this.lowestBatteryPercentageLabel.Size = new System.Drawing.Size(56, 17);
            this.lowestBatteryPercentageLabel.TabIndex = 2;
            this.lowestBatteryPercentageLabel.Text = "Lowest:";
            // 
            // highestBatteryPercentageLabel
            // 
            this.highestBatteryPercentageLabel.AutoSize = true;
            this.highestBatteryPercentageLabel.Location = new System.Drawing.Point(167, 93);
            this.highestBatteryPercentageLabel.Name = "highestBatteryPercentageLabel";
            this.highestBatteryPercentageLabel.Size = new System.Drawing.Size(60, 17);
            this.highestBatteryPercentageLabel.TabIndex = 3;
            this.highestBatteryPercentageLabel.Text = "Highest:";
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(20, 19);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(250, 34);
            this.infoLabel.TabIndex = 4;
            this.infoLabel.Text = "Please enter the lowest and highest\r\n battery percentage you\'d like to have:\r\n";
            // 
            // SettingsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 171);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.highestBatteryPercentageLabel);
            this.Controls.Add(this.lowestBatteryPercentageLabel);
            this.Controls.Add(this.highestBatteryPercentTextBox);
            this.Controls.Add(this.lowestBatteryPercentTextBox);
            this.Name = "SettingsWindow";
            this.Text = "Battery";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.TextBox lowestBatteryPercentTextBox;
        private System.Windows.Forms.TextBox highestBatteryPercentTextBox;
        private System.Windows.Forms.Label lowestBatteryPercentageLabel;
        private System.Windows.Forms.Label highestBatteryPercentageLabel;
        private System.Windows.Forms.Label informationLabel;
        private System.Windows.Forms.Label infoLabel;
    }
}

