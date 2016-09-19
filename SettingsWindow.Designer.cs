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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsWindow));
            this.lowestBatteryPercentageLabel = new System.Windows.Forms.Label();
            this.highestBatteryPercentageLabel = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            this.closeSettingsButton = new System.Windows.Forms.Button();
            this.lowestBatteryPercentTextBox = new System.Windows.Forms.RichTextBox();
            this.highestBatteryPercentTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lowestBatteryPercentageLabel
            // 
            this.lowestBatteryPercentageLabel.AutoSize = true;
            this.lowestBatteryPercentageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lowestBatteryPercentageLabel.Location = new System.Drawing.Point(12, 73);
            this.lowestBatteryPercentageLabel.Name = "lowestBatteryPercentageLabel";
            this.lowestBatteryPercentageLabel.Size = new System.Drawing.Size(56, 17);
            this.lowestBatteryPercentageLabel.TabIndex = 2;
            this.lowestBatteryPercentageLabel.Text = "Lowest:";
            // 
            // highestBatteryPercentageLabel
            // 
            this.highestBatteryPercentageLabel.AutoSize = true;
            this.highestBatteryPercentageLabel.Location = new System.Drawing.Point(167, 73);
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
            // closeSettingsButton
            // 
            this.closeSettingsButton.Location = new System.Drawing.Point(117, 127);
            this.closeSettingsButton.Name = "closeSettingsButton";
            this.closeSettingsButton.Size = new System.Drawing.Size(49, 32);
            this.closeSettingsButton.TabIndex = 5;
            this.closeSettingsButton.Text = "OK";
            this.closeSettingsButton.UseVisualStyleBackColor = true;
            this.closeSettingsButton.Click += new System.EventHandler(this.closeSettingsButton_Click);
            // 
            // lowestBatteryPercentTextBox
            // 
            this.lowestBatteryPercentTextBox.Location = new System.Drawing.Point(15, 95);
            this.lowestBatteryPercentTextBox.Multiline = false;
            this.lowestBatteryPercentTextBox.Name = "lowestBatteryPercentTextBox";
            this.lowestBatteryPercentTextBox.Size = new System.Drawing.Size(110, 26);
            this.lowestBatteryPercentTextBox.TabIndex = 6;
            this.lowestBatteryPercentTextBox.Text = "";
            this.lowestBatteryPercentTextBox.TextChanged += new System.EventHandler(this.lowestBatteryPercentTextBox_TextChanged);
            this.lowestBatteryPercentTextBox.SelectionChanged += new System.EventHandler(this.LowestBatteryPercentTextBox_SelectionChanged);
            // 
            // highestBatteryPercentTextBox
            // 
            this.highestBatteryPercentTextBox.Location = new System.Drawing.Point(160, 95);
            this.highestBatteryPercentTextBox.Multiline = false;
            this.highestBatteryPercentTextBox.Name = "highestBatteryPercentTextBox";
            this.highestBatteryPercentTextBox.Size = new System.Drawing.Size(110, 26);
            this.highestBatteryPercentTextBox.TabIndex = 7;
            this.highestBatteryPercentTextBox.Text = "";
            this.highestBatteryPercentTextBox.TextChanged += new System.EventHandler(this.highestBatteryPercentTextBox_TextChanged);
            this.highestBatteryPercentTextBox.SelectionChanged += new System.EventHandler(this.HighestBatteryPercentTextBox_SelectionChanged);
            // 
            // SettingsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 171);
            this.Controls.Add(this.highestBatteryPercentTextBox);
            this.Controls.Add(this.lowestBatteryPercentTextBox);
            this.Controls.Add(this.closeSettingsButton);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.highestBatteryPercentageLabel);
            this.Controls.Add(this.lowestBatteryPercentageLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsWindow";
            this.Text = "Battery Watch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void HighestBatteryPercentTextBox_TextChanged(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.Label lowestBatteryPercentageLabel;
        private System.Windows.Forms.Label highestBatteryPercentageLabel;
        private System.Windows.Forms.Label informationLabel;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Button closeSettingsButton;
        private System.Windows.Forms.RichTextBox lowestBatteryPercentTextBox;
        private System.Windows.Forms.RichTextBox highestBatteryPercentTextBox;
    }
}

