using System.Threading;
using System.Windows.Forms;

/*
 This class stays in a loop and monitors the battery constantly
     */
namespace BatteryWatch
{
    class BatteryWatcher
    {
        const string LOW_BATTERY_MESSAGE = "Your battery has dropped down below {0} percent!";
        const string HIGH_BATTERY_MESSAGE = "Your battery has exceeded {} percent!";

        public void MainLoop(int minimum, int maximum)
        {
            while (true)
            {
                PowerStatus pw = SystemInformation.PowerStatus;

                int batteryPercent = (int)pw.BatteryLifePercent// gets the battery percentage as a float -> 0.75
                    * 100; // that's why we multiply it by 100

                if(IsBelowMinimum(minimum, batteryPercent))
                {
                    DisplayLowBatteryAlertWindow(minimum);
                    break;
                }
                else if(IsAboveMaximum(maximum, batteryPercent))
                {
                    DisplayHighBatteryAlertWindow(maximum);
                    break;
                }

                Thread.Sleep(60000);  // Check every one minute.
            }
        }

        private bool IsBelowMinimum(int minimum, int current)
        {
            return current < minimum;
        }

        private bool IsAboveMaximum(int maximum, int current)
        {
            return current > maximum;
        }

        private void DisplayHighBatteryAlertWindow(int maximumPercentage)
        {
            string message = string.Format(HIGH_BATTERY_MESSAGE, maximumPercentage);

            AlertWindow highBatteryAW = new AlertWindow();

            highBatteryAW.ChangeWarningLabelText(message);

            highBatteryAW.Show();
        }

        private void DisplayLowBatteryAlertWindow(int minimumPercentage)
        {
            string message = string.Format(LOW_BATTERY_MESSAGE, minimumPercentage);

            AlertWindow lowBatteryAW = new AlertWindow();

            lowBatteryAW.ChangeWarningLabelText(message);

            Application.Run(lowBatteryAW);
        }
    }
}
