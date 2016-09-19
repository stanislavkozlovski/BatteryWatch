using System.Windows.Forms;

namespace BatteryWatch
{
    public partial class AlertWindow : Form
    {
        public AlertWindow()
        {
            InitializeComponent();
        }

        public void ChangeAlertWindowTitle(string title)
        {
            this.Text = title;
        }
        
        public void ChangeWarningLabelText(string text)
        {
            this.warningLabel.Text = text;
        }

        private void okButton_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
