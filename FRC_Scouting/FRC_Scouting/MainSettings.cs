using FRC_Scouting.Properties;
using System;
using System.Windows.Forms;

namespace FRC_Scouting
{
    public partial class MainSettings : Form
    {
        private readonly UsefulSnippets us = new UsefulSnippets();
        private string databaseHostAddress = ("Example : 192.168.1.1");
        private string databasePassword = ("Example : password123");
        private string databasePort = ("Example : 3306");
        private string databaseUsername = ("Example : root");
        private Boolean onlineDatabaseUsed;

        public MainSettings()
        {
            InitializeComponent();
        }

        #region Enable Disable Checkbox
        public void EnableDisableTextBox()
        {
            if (onlineDatabaseCheckBox.Checked == true)
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
        #endregion

        public void LoadTextboxText()
        {
            if (FRC_Scouting.Properties.Settings.Default.OnlineDatabase == true)
            {
                databaseHostTextBox.Text = FRC_Scouting.Properties.Settings.Default.databaseHost;
                databasePortTextBox.Text = FRC_Scouting.Properties.Settings.Default.databasePort;
                databaseUsernameTextBox.Text = FRC_Scouting.Properties.Settings.Default.databaseUsername;
                databasePasswordTextBox.Text = FRC_Scouting.Properties.Settings.Default.databasePassword;
            }
            else
            {
                if (FRC_Scouting.Properties.Settings.Default.OnlineDatabase == false)
                {
                    databaseHostTextBox.Text = ("Example : 192.168.1.1");
                    databasePortTextBox.Text = ("Example : 3306");
                    databaseUsernameTextBox.Text = ("Example : root");
                    databasePasswordTextBox.Text = ("Example : password123");
                }
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

        private void clearAllSettingsButton_Click(object sender, EventArgs e)
        {
            us.ClearSettings();
        }

        #region Click To Delete

        private void databaseHostTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (FRC_Scouting.Properties.Settings.Default.ClickToDeleteTextField == true)
            {
                databaseHostTextBox.Text = ("");
            }
        }

        private void databasePasswordTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (FRC_Scouting.Properties.Settings.Default.ClickToDeleteTextField == true)
            {
                databasePasswordTextBox.Text = ("");
            }
        }

        private void databasePortTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (FRC_Scouting.Properties.Settings.Default.ClickToDeleteTextField == true)
            {
                databasePortTextBox.Text = ("");
            }
        }

        private void databaseUsernameTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (FRC_Scouting.Properties.Settings.Default.ClickToDeleteTextField == true)
            {
                databaseUsernameTextBox.Text = ("");
            }
        }

        #endregion Click To Delete

        #region Text Gatherers

        private void databaseHostTextBox_TextChanged(object sender, EventArgs e)
        {
            if (databaseHostTextBox.Text != (""))
            {
                databaseHostAddress = databaseHostTextBox.Text;
            }
        }

        private void databasePasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            if (databasePasswordTextBox.Text != (""))
            {
                databasePassword = databasePasswordTextBox.Text;
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

        #endregion Text Gatherers

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainSettings_Load(object sender, EventArgs e)
        {
            LoadTextboxText();
            EnableDisableTextBox();

            if (FRC_Scouting.Properties.Settings.Default.ClickToDeleteTextField == true)
            {
                ClickToEmptyTextFieldCheckBox.Checked = true;
            }
            else
            {
                if (FRC_Scouting.Properties.Settings.Default.ClickToDeleteTextField == false)
                {
                    ClickToEmptyTextFieldCheckBox.Checked = false;
                }
            }

            if (FRC_Scouting.Properties.Settings.Default.OnlineDatabase == true)
            {
                onlineDatabaseCheckBox.Checked = true;
                LoadTextboxText();
            }
            else
            {
                if (FRC_Scouting.Properties.Settings.Default.OnlineDatabase == false)
                {
                    onlineDatabaseCheckBox.Checked = false;
                    LoadTextboxText();
                }
            }
        }

        private void onlineDatabaseCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            EnableDisableTextBox();

            if (onlineDatabaseCheckBox.Checked == true)
            {
                onlineDatabaseUsed = true;
                Settings.Default.OnlineDatabase = true;
            }
            else
            {
                if (onlineDatabaseCheckBox.Checked == false)
                {
                    onlineDatabaseUsed = false;
                    Settings.Default.OnlineDatabase = false;
                }
            }
            FRC_Scouting.Properties.Settings.Default.Save();
        }

        private void saveDatabaseSettingsButton_Click(object sender, EventArgs e)
        {
            SaveAllSettings();
        }

        private void ClickToEmptyTextFieldCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            switch (ClickToEmptyTextFieldCheckBox.Checked)
            {
                case true:
                    FRC_Scouting.Properties.Settings.Default.ClickToDeleteTextField = ClickToEmptyTextFieldCheckBox.Checked;
                    break;

                case false:
                    FRC_Scouting.Properties.Settings.Default.ClickToDeleteTextField = ClickToEmptyTextFieldCheckBox.Checked;
                    break;
            }
            FRC_Scouting.Properties.Settings.Default.Save();
        }
    }
}