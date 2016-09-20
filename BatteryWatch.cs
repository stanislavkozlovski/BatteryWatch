using BatteryWatch;
using System;
using System.Drawing;
using System.Windows.Forms;


/* VERSION: 1.0
   AUTHOR: Enether */
namespace BatteryWatch
{
    static class BatteryWatch
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SettingsWindow());
        }
    }
}


public class BatteryWatchApplicationContext : ApplicationContext
{
    private NotifyIcon trayIcon;

    public BatteryWatchApplicationContext(int minimumPercentage, int maximumPercentage)
    {
        // Initialize Tray Icon
        trayIcon = new NotifyIcon()
        {
            Icon = new Icon("../../Resources/BatteryWatchIcon.ico"),
            ContextMenu = new ContextMenu(new MenuItem[] {
                new MenuItem("Exit", OnExit)
            }),
            Visible = true
        };

        BatteryWatcher bw = new BatteryWatcher();
        bw.MainLoop(minimumPercentage, maximumPercentage);
    }

    void OnExit(object sender, EventArgs e)
    {
        // Hide tray icon, otherwise it will remain shown until user mouses over it
        trayIcon.Visible = false;

        Application.Exit();
    }
}
