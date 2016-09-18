using System.Threading;
using System.Windows.Forms;

/*
 This class stays in a loop and monitors the battery constantly
     */
namespace BatteryWatch
{
    class BatteryWatcher
    {
        public void MainLoop(int minimum, int maximum)
        {
            while (true)
            {
                PowerStatus pw = SystemInformation.PowerStatus;

                int batteryPercent = (int)pw.BatteryLifePercent// gets the battery percentage as a float -> 0.75
                    * 100; // that's why we multiply it by 100

                if(IsBelowMinimum(minimum, batteryPercent))
                {
                    Application.Run(new AlertWindow());
                    break;
                }
                else if(IsAboveMaximum(maximum, batteryPercent))
                {
                    Application.Run(new AlertWindow());
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
    }
}
