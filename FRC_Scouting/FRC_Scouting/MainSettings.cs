using System;
using System.Windows.Forms;

namespace FRC_Scouting
{
    public partial class MainSettings : Form
    {
        public MainSettings()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearAllSettingsButton_Click(object sender, EventArgs e)
        {
            FRC_Scouting.Properties.Settings.Default.Reset();
            FRC_Scouting.Properties.Settings.Default.Save();
        }
    }
}
