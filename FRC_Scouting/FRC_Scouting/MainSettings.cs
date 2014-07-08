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
        private Boolean onlineDatabaseUsed;

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainSettings_Load(object sender, EventArgs e)
        {
            UpdateDatabaseUI();
        }

        public void UpdateDatabaseUI()
        {
            if (FRC_Scouting.Properties.Settings.Default.OnlineDatabase == true)
            {
                databaseHostTextBox.Enabled = true;
                databasePortTextBox.Enabled = true;
                databaseUsernameTextBox.Enabled = true;
                databasePasswordTextBox.Enabled = true;
            }
            else
            {
                if (FRC_Scouting.Properties.Settings.Default.OnlineDatabase == false)
                {
                    databaseHostTextBox.Enabled = false;
                    databasePortTextBox.Enabled = false;
                    databaseUsernameTextBox.Enabled = false;
                    databasePasswordTextBox.Enabled = false;
                }
            }
        }

        public void SaveAllSettings()
        {
            FRC_Scouting.Properties.Settings.Default.databaseHost = databaseHostAddress;
            FRC_Scouting.Properties.Settings.Default.databasePort = databasePort;
            FRC_Scouting.Properties.Settings.Default.databaseUsername = databaseUsername;
            FRC_Scouting.Properties.Settings.Default.databasePassword = databasePassword;
            FRC_Scouting.Properties.Settings.Default.OnlineDatabase = onlineDatabaseUsed;
            FRC_Scouting.Properties.Settings.Default.Save();
        }

        private void saveDatabaseSettingsButton_Click(object sender, EventArgs e)
        {
            SaveAllSettings();
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

        private void onlineDatabaseCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (onlineDatabaseCheckBox.Checked == true)
            {
                onlineDatabaseUsed = true;
                FRC_Scouting.Properties.Settings.Default.OnlineDatabase = true;
                FRC_Scouting.Properties.Settings.Default.Save();
            }
            else
            {
                if (onlineDatabaseCheckBox.Checked == false)
                {
                    onlineDatabaseUsed = false;
                    FRC_Scouting.Properties.Settings.Default.OnlineDatabase = false;
                    FRC_Scouting.Properties.Settings.Default.Save();
                }
            }
            UpdateDatabaseUI();
        }
    }
}
