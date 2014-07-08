using FRC_Scouting.Properties;
using System;
using System.Windows.Forms;

namespace FRC_Scouting
{
    public partial class MainSettings : Form
    {
        private readonly UsefulSnippets us = new UsefulSnippets();
        private string databaseHostAddress;
        private string databasePassword;
        private string databasePort;
        private string databaseUsername;
        private Boolean onlineDatabaseUsed;

        public MainSettings()
        {
            InitializeComponent();
        }

        public void LoadTextboxText()
        {
            if (FRC_Scouting.Properties.Settings.Default.OnlineDatabase == true)
            {
                databaseHostTextBox.Text = FRC_Scouting.Properties.Settings.Default.databaseHost;
                databasePortTextBox.Text = FRC_Scouting.Properties.Settings.Default.databasePort;
                databaseUsernameTextBox.Text = FRC_Scouting.Properties.Settings.Default.databaseUsername;
                databasePasswordTextBox.Text = FRC_Scouting.Properties.Settings.Default.databasePassword;
            }
        }

        public void SaveAllSettings()
        {
            Settings.Default.databaseHost = databaseHostAddress;
            Settings.Default.databasePort = databasePort;
            Settings.Default.databaseUsername = databaseUsername;
            Settings.Default.databasePassword = databasePassword;
            Settings.Default.OnlineDatabase = onlineDatabaseUsed;
            Settings.Default.Save();
        }

        public void UpdateDatabaseUI()
        {
            if (Settings.Default.OnlineDatabase)
            {
                databaseHostTextBox.Enabled = true;
                databasePortTextBox.Enabled = true;
                databaseUsernameTextBox.Enabled = true;
                databasePasswordTextBox.Enabled = true;
            }
            else
            {
                if (Settings.Default.OnlineDatabase == false)
                {
                    databaseHostTextBox.Enabled = false;
                    databasePortTextBox.Enabled = false;
                    databaseUsernameTextBox.Enabled = false;
                    databasePasswordTextBox.Enabled = false;
                }
            }
        }

        private void clearAllSettingsButton_Click(object sender, EventArgs e)
        {
            us.ClearSettings();
        }

        private void databaseHostTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            databaseHostTextBox.Text = ("");
        }

        private void databaseHostTextBox_TextChanged(object sender, EventArgs e)
        {
            if (databaseHostTextBox.Text != (""))
            {
                databaseHostAddress = databaseHostTextBox.Text;
            }
        }

        private void databasePasswordTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            databasePasswordTextBox.Text = ("");
        }

        private void databasePasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            if (databasePasswordTextBox.Text != (""))
            {
                databasePassword = databasePasswordTextBox.Text;
            }
        }

        private void databasePortTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            databasePortTextBox.Text = ("");
        }

        private void databasePortTextBox_TextChanged(object sender, EventArgs e)
        {
            if (databasePortTextBox.Text != (""))
            {
                databasePort = databasePortTextBox.Text;
            }
        }

        private void databaseUsernameTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            databaseUsernameTextBox.Text = ("");
        }

        private void databaseUsernameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (databaseUsernameTextBox.Text != (""))
            {
                databaseUsername = databaseUsernameTextBox.Text;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainSettings_Load(object sender, EventArgs e)
        {
            UpdateDatabaseUI();
            LoadTextboxText();
        }

        private void onlineDatabaseCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (onlineDatabaseCheckBox.Checked)
            {
                onlineDatabaseUsed = true;
                Settings.Default.OnlineDatabase = true;
                Settings.Default.Save();
            }
            else
            {
                if (onlineDatabaseCheckBox.Checked == false)
                {
                    onlineDatabaseUsed = false;
                    Settings.Default.OnlineDatabase = false;
                    Settings.Default.Save();
                }
            }
            UpdateDatabaseUI();
        }

        private void saveDatabaseSettingsButton_Click(object sender, EventArgs e)
        {
            SaveAllSettings();
        }
    }
}