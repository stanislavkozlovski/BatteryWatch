using System.Threading;
using System.Windows.Forms;

/*
 This class stays in a loop and monitors the battery constantly
     */
namespace BatteryWatch
{
    class BatteryWatcher
    {
        const string LOW_BATTERY_TITLE = "Battery is too low!";
        const string HIGH_BATTERY_TITLE = "Battery is too high!";
        const string LOW_BATTERY_MESSAGE = "Your battery has dropped down below {0} percent!";
        const string HIGH_BATTERY_MESSAGE = "Your battery has exceeded {0} percent!";
        int minimumBatteryPercentage = 0,
            maximumBatteryPercentage = 0;

        public void MainLoop(int minimum, int maximum)
        {
            minimumBatteryPercentage = minimum;
            maximumBatteryPercentage = maximum;

            while (true)
            {
                PowerStatus pw = SystemInformation.PowerStatus;

                int batteryPercent = (int)(pw.BatteryLifePercent// gets the battery percentage as a float -> 0.75
                    * 100); // that's why we multiply it by 100

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

        private void LoopUntilBatteryIsHigh(int minimum)
        {
            /* this method is called when the battery has gone below the minimum percentage
               it loops until the battery is charged above the minimum percentage and resumes the main loop again.*/

            while (true)
            {
                PowerStatus pw = SystemInformation.PowerStatus;

                int batteryPercent = (int)(pw.BatteryLifePercent// gets the battery percentage as a float -> 0.75
                    * 100); // that's why we multiply it by 100

                if (IsAboveMaximum(minimum, batteryPercent))
                    break;

                Thread.Sleep(60000);
            }

            MainLoop(minimumBatteryPercentage, maximumBatteryPercentage);
        }

        private void LoopUntilBatteryIsLow(int maximum)
        {
            /* this method is called when the battery has gone above the maximum percentage
               it loops until the battery drops below the maximum percentage and starts the main loop again */

            while (true)
            {
                PowerStatus pw = SystemInformation.PowerStatus;

                int batteryPercent = (int)(pw.BatteryLifePercent // gets the battery percentage as a float -> 0.75
                    * 100); // that's why we multiply it by 100

                if (IsBelowMinimum(maximum, batteryPercent))
                    break;

                Thread.Sleep(60000);
            }

            MainLoop(minimumBatteryPercentage, maximumBatteryPercentage);
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
            highBatteryAW.ChangeAlertWindowTitle(HIGH_BATTERY_TITLE);

            highBatteryAW.Show();

            highBatteryAW.FormClosed += (s, args) =>
            {
                // when we close the warning window, loop until the battery is charged back to normal and then run the
                // mainloop again
                highBatteryAW.Dispose();
                LoopUntilBatteryIsLow(maximumPercentage);
            };
        }

        private void DisplayLowBatteryAlertWindow(int minimumPercentage)
        {
            string message = string.Format(LOW_BATTERY_MESSAGE, minimumPercentage);

            AlertWindow lowBatteryAW = new AlertWindow();

            lowBatteryAW.ChangeWarningLabelText(message);
            lowBatteryAW.ChangeAlertWindowTitle(LOW_BATTERY_TITLE);

            lowBatteryAW.Show();

            lowBatteryAW.FormClosed += (s, args) =>
            {
                // when we close the warning window, loop until the battery is charged back to normal and then run the
                // mainloop again
                lowBatteryAW.Dispose();           
                LoopUntilBatteryIsHigh(minimumPercentage);
            };
        }
    }
}
