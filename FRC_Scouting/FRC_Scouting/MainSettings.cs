using FRC_Scouting.Properties;
using System;
using System.Windows.Forms;

namespace FRC_Scouting
{
    public partial class MainSettings : Form
    {
        private readonly UsefulSnippets us = new UsefulSnippets();
        private string customDatabaseHost;
        private string customDatabasePassword;
        private string customDatabasePort;
        private Boolean customDatabaseUsed;
        private string customDatabaseUsername;
        private string username;

        public MainSettings()
        {
            InitializeComponent();
        }

        public void EnableDisableTextBox()
        {
            if (onlineDatabaseCheckBox.Checked)
            {
                databaseHostTextBox.Enabled = true;
                databasePortTextBox.Enabled = true;
                databaseUsernameTextBox.Enabled = true;
                databasePasswordTextBox.Enabled = true;
            }
            else
            {
                if (onlineDatabaseCheckBox.Checked == false)
                {
                    databaseHostTextBox.Enabled = false;
                    databasePortTextBox.Enabled = false;
                    databaseUsernameTextBox.Enabled = false;
                    databasePasswordTextBox.Enabled = false;
                }
            }
        }

        public void SaveAllDatabaseSettings()
        {
            Settings.Default.CustomDatabaseHost = customDatabaseHost;
            Settings.Default.CustomDatabasePort = customDatabasePort;
            Settings.Default.CustomDatabaseUsername = customDatabaseUsername;
            Settings.Default.CustomDatabasePassword = customDatabasePassword;
            Settings.Default.CustomDatabaseUsed = customDatabaseUsed;
            Settings.Default.Save();
        }

        private void clearAllSettingsButton_Click(object sender, EventArgs e)
        {
            us.ClearSettings();
        }

        private void ClickToEmptyTextFieldCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            switch (ClickToEmptyTextFieldCheckBox.Checked)
            {
                case true:
                    Settings.Default.ClickToDeleteTextField = ClickToEmptyTextFieldCheckBox.Checked;
                    break;

                case false:
                    Settings.Default.ClickToDeleteTextField = ClickToEmptyTextFieldCheckBox.Checked;
                    break;
            }
            Settings.Default.Save();
        }

        private void databaseHostTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (Settings.Default.ClickToDeleteTextField)
            {
                databaseHostTextBox.Text = ("");
            }
        }

        private void databaseHostTextBox_TextChanged(object sender, EventArgs e)
        {
            if (databaseHostTextBox.Text != (""))
            {
                customDatabaseHost = databaseHostTextBox.Text;
            }
        }

        private void databasePasswordTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (Settings.Default.ClickToDeleteTextField)
            {
                databasePasswordTextBox.Text = ("");
            }
        }

        private void databasePasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            if (databasePasswordTextBox.Text != (""))
            {
                customDatabasePassword = databasePasswordTextBox.Text;
            }
        }

        private void databasePortTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (Settings.Default.ClickToDeleteTextField)
            {
                databasePortTextBox.Text = ("");
            }
        }

        private void databasePortTextBox_TextChanged(object sender, EventArgs e)
        {
            if (databasePortTextBox.Text != (""))
            {
                customDatabasePort = databasePortTextBox.Text;
            }
        }

        private void databaseUsernameTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (Settings.Default.ClickToDeleteTextField)
            {
                databaseUsernameTextBox.Text = ("");
            }
        }

        private void databaseUsernameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (databaseUsernameTextBox.Text != (""))
            {
                customDatabaseUsername = databaseUsernameTextBox.Text;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainSettings_Load(object sender, EventArgs e)
        {
            usernameTextBox.Text = Settings.Default.username;
            if (Settings.Default.ClickToDeleteTextField)
            {
                ClickToEmptyTextFieldCheckBox.Checked = true;
            }
            else
            {
                if (Settings.Default.ClickToDeleteTextField == false)
                {
                    ClickToEmptyTextFieldCheckBox.Checked = false;
                }
            }
            if (Settings.Default.CustomDatabaseUsed)
            {
                customDatabaseUsed = true;
                onlineDatabaseCheckBox.Checked = true;
                customDatabaseHost = Settings.Default.CustomDatabaseHost;
                customDatabasePort = Settings.Default.CustomDatabasePort;
                customDatabaseUsername = Settings.Default.CustomDatabaseUsername;
                customDatabasePassword = Settings.Default.CustomDatabasePassword;

                databaseHostTextBox.Text = customDatabaseHost;
                databasePortTextBox.Text = customDatabasePort;
                databaseUsernameTextBox.Text = customDatabaseUsername;
                databasePasswordTextBox.Text = customDatabasePassword;
            }
            EnableDisableTextBox();
        }
        private void onlineDatabaseCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (onlineDatabaseCheckBox.Checked)
            {
                customDatabaseUsed = true;
            }
            else
            {
                if (onlineDatabaseCheckBox.Checked == false)
                {
                    customDatabaseUsed = false;
                }
            }
            EnableDisableTextBox();
        }

        private void saveDatabaseSettingsButton_Click(object sender, EventArgs e)
        {
            SaveAllDatabaseSettings();
        }
        private void SaveGeneralSettingsButton_Click(object sender, EventArgs e)
        {
            if (ClickToEmptyTextFieldCheckBox.Checked)
            {
                Settings.Default.ClickToDeleteTextField = true;
            }
            else
            {
                if (ClickToEmptyTextFieldCheckBox.Checked == false)
                {
                    Settings.Default.ClickToDeleteTextField = false;
                }
            }
            Settings.Default.username = username;
            Settings.Default.Save();
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {
            username = usernameTextBox.Text;
        }

        private void usernameTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (Settings.Default.ClickToDeleteTextField)
            {
                usernameTextBox.Text = ("");
            }
        }
    }
}