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

        //Variables
        UsefulSnippets us = new UsefulSnippets();
        private string databaseHostAddress;
        private string databasePort;
        private string databaseUsername;
        private string databasePassword;

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainSettings_Load(object sender, EventArgs e)
        {

        }

        private void saveDatabaseSettingsButton_Click(object sender, EventArgs e)
        {

        }

        private void clearAllSettingsButton_Click(object sender, EventArgs e)
        {
            us.ClearSettings();
        }

        private void databaseHostTextBox_TextChanged(object sender, EventArgs e)
        {
            if (databaseHostTextBox.Text != (""))
            {
                databaseHostAddress = databaseHostTextBox.Text;
            }
        }

        private void databasePortTextBox_TextChanged(object sender, EventArgs e)
        {
            if (databasePortTextBox.Text != (""))
            {
                databasePort = databasePortTextBox.Text;
            }
        }

        private void databaseUsernameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (databaseUsernameTextBox.Text != (""))
            {
                databaseUsername = databaseUsernameTextBox.Text;
            }
        }

        private void databasePasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            if (databasePasswordTextBox.Text != (""))
            {
                databasePassword = databasePasswordTextBox.Text;
            }
        }

        private void databaseHostTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            databaseHostTextBox.Text = ("");
        }

        private void databasePortTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            databasePortTextBox.Text = ("");
        }

        private void databaseUsernameTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            databaseUsernameTextBox.Text = ("");
        }

        private void databasePasswordTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            databasePasswordTextBox.Text = ("");
        }
    }
}
