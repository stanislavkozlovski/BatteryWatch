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
            int.TryParse(this.lowestBatteryPercentTextBox.Text, out this.lowestBatteryPercent);
        }

        private void highestBatteryPercentTextBox_TextChanged(object sender, System.EventArgs e)
        {
            int.TryParse(this.highestBatteryPercentTextBox.Text, out this.highestBatteryPercent);
        }

        private void closeSettingsButton_Click(object sender, System.EventArgs e)
        {
            if(lowestBatteryPercent != 0 && highestBatteryPercent != 0)
            {
                this.Hide();

                // create the tray icon and start the watcher loop
                var bwac = new BatteryWatchApplicationContext(this.lowestBatteryPercent, this.highestBatteryPercent);
                
            }
        }
    }
}
