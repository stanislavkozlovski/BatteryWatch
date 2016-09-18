using System.Windows.Forms;

namespace BatteryWatch
{
    public partial class AlertWindow : Form
    {
        // TODO: Change Window title
        public AlertWindow()
        {
            InitializeComponent();
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
