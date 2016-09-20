using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BatteryWatch
{
    public partial class SettingsWindow : Form
    {
        private int lowestBatteryPercent = 0;
        private int highestBatteryPercent = 0;

        public SettingsWindow()
        {
            InitializeComponent();
        }

        private void lowestBatteryPercentTextBox_TextChanged(object sender, System.EventArgs e)
        {
            int previousCaretPosition = RemoveNonNumericalCharacters(lowestBatteryPercentTextBox);
            // add visual percentage
            if (!lowestBatteryPercentTextBox.Text.EndsWith("%") && lowestBatteryPercentTextBox.Text.Length > 0)
                AddVisualPercentage(lowestBatteryPercentTextBox, previousCaretPosition);
        }

        private void LowestBatteryPercentTextBox_SelectionChanged(object sender, System.EventArgs e)
        {
            if (lowestBatteryPercentTextBox.SelectionStart == lowestBatteryPercentTextBox.Text.Length)
                // we cannot go past the % symbol
                lowestBatteryPercentTextBox.SelectionStart -= 1;
            else if (lowestBatteryPercentTextBox.SelectedText.Contains("%"))
                // we cannot select the % symbol
                lowestBatteryPercentTextBox.SelectionLength -= 1;
        }

        private void highestBatteryPercentTextBox_TextChanged(object sender, System.EventArgs e)
        {
            int previousCaretPosition = RemoveNonNumericalCharacters(highestBatteryPercentTextBox);
            // add visual percentage
            if (!highestBatteryPercentTextBox.Text.EndsWith("%") && highestBatteryPercentTextBox.Text.Length > 0)
                AddVisualPercentage(highestBatteryPercentTextBox, previousCaretPosition);
        }

        private void HighestBatteryPercentTextBox_SelectionChanged(object sender, System.EventArgs e)
        {
            if (highestBatteryPercentTextBox.SelectionStart == highestBatteryPercentTextBox.Text.Length)
                // we cannot go past the % symbol
                highestBatteryPercentTextBox.SelectionStart -= 1;
            else if (highestBatteryPercentTextBox.SelectedText.Contains("%"))
                // we cannot select the % symbol
                highestBatteryPercentTextBox.SelectionLength -= 1;
        }

        private int RemoveNonNumericalCharacters(RichTextBox textBox)
        {
            /* this method removes every non-numerical character, entered in a text box.
             it is called whenever the text boxes are edited and before the % symbol is added
             Returns the previous caret position*/
            int previousCaretPosition = textBox.SelectionStart == 0 ? 0 : textBox.SelectionStart - 1;
            textBox.Text = Regex.Replace(textBox.Text, @"[^0-9]", "");

            return previousCaretPosition;                                                                                                                                   
        }

        private void AddVisualPercentage(RichTextBox textBox, int previousCaretPosition)
        {
            /*  this methods adds a % symbol to the end of the textbox's text */
            textBox.Text += '%';
            // move the cursor where it should be
            if (previousCaretPosition + 1 != textBox.Text.Length)
                textBox.SelectionStart = previousCaretPosition + 1;
            else
                textBox.SelectionStart = previousCaretPosition;
        }
        private void closeSettingsButton_Click(object sender, System.EventArgs e)
        {
            // parse the text
            int.TryParse(this.lowestBatteryPercentTextBox.Text.Replace("%", ""), out this.lowestBatteryPercent);
            int.TryParse(this.highestBatteryPercentTextBox.Text.Replace("%", ""), out this.highestBatteryPercent);

            if (InputIsValid(this.lowestBatteryPercent, this.highestBatteryPercent))
            {
                this.Hide();

                // create the tray icon and start the watcher loop
                var bwac = new BatteryWatchApplicationContext(this.lowestBatteryPercent, this.highestBatteryPercent);
            }
            else
            {
                InvalidInputWindow invalidInputWindow = new InvalidInputWindow();
                invalidInputWindow.Show();
            }

            
        }

        private bool InputIsValid(int minimumPercentage, int maximumPercentage)
        {
            /* returns if the input that has been entered is valid. Must be numbers from 2-99 and the minimumPercentage must
             be 5 less than the maximum */
            bool validMinPercentage = (minimumPercentage >= 2 && minimumPercentage <= 94);
            bool validMaxPercentage = (maximumPercentage >= 7 && maximumPercentage <= 99);
            bool differenceIsBiggerThanFive = (maximumPercentage - minimumPercentage) >= 5;

            return validMinPercentage && validMaxPercentage && differenceIsBiggerThanFive;
        }
    }
}
