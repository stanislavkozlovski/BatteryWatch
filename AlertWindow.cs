using System.Windows.Forms;

namespace BatteryWatch
{
    public partial class AlertWindow : Form
    {
        public AlertWindow()
        {
            InitializeComponent();
        }
        
        public void ChangeWarningLabelText(string text)
        {
            this.warningLabel.Text = text;
        }
    }
}
