using System;
using System.Windows.Forms;

namespace BatteryWatch
{
    public partial class InvalidInputWindow : Form
    {
        public InvalidInputWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
