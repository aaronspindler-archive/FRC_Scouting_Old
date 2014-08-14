using System;
using System.Windows.Forms;

namespace FRC_Scouting
{
    //@author xNovax
    public partial class WhichYear : Form
    {
        private readonly UsefulSnippets us = new UsefulSnippets();
        private int whichToOpen;
        private Boolean yearSelected;

        public WhichYear()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void whichYearComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (whichYearComboBox.SelectedIndex)
            {
                case 0:
                    whichToOpen = 0;
                    yearSelected = true;
                    break;

                case 1:
                    whichToOpen = 1;
                    yearSelected = true;
                    break;

                default:
                    yearSelected = false;
                    break;
            }
        }

        private void confirmSelectionButton_Click(object sender, EventArgs e)
        {
            if (yearSelected == false)
            {
                us.ErrorOccured("You did not select an option above.");
            }
            else
            {
                if (yearSelected)
                {
                    switch (whichToOpen)
                    {
                        case 0:
                            var aan = new AerialAssist_NorthBay();
                            aan.Show();
                            Hide();
                            break;

                        case 1:
                            MessageBox.Show("The event for 2015 has not yet been decided", "Error", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                            break;
                    }
                }
            }
        }

        private void WhichYear_Load(object sender, EventArgs e)
        {
            whichYearComboBox.Items.Add("2014 | Aerial Assist | NorthBay");
            whichYearComboBox.Items.Add("Not Yet Decided");
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ms = new MainSettings();
            ms.Show();
        }

        private void programInformationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var pi = new ProgramInformation();
            pi.Show();
        }

        private void licenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var li = new LicenseInformation();
            li.Show();
        }

        private void changelogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cl = new ChangeLog();
            cl.Show();
        }

        private void resetAllSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            us.ClearSettings();
        }

        private void teamDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var teamDirectory = new Team_Directory();
            teamDirectory.Show();
        }
    }
}