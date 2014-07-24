using System;
using System.Windows.Forms;

namespace FRC_Scouting
{
    public partial class WhichYear : Form
    {
        public WhichYear()
        {
            InitializeComponent();
        }

        private int whichToOpen;
        private Boolean yearSelected = false;
        private UsefulSnippets us = new UsefulSnippets();

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
                if (yearSelected == true)
                {
                    switch (whichToOpen)
                    {
                        case 0:
                            var aao = new AerialAssist_Oshawa();
                            aao.Show();
                            this.Hide();
                            break;

                        case 1:
                            var aan = new AerialAssist_Nipissing();
                            aan.Show();
                            this.Hide();
                            break;

                        case 2:
                            this.Hide();
                            break;
                    }
                }
            }
        }

        private void WhichYear_Load(object sender, EventArgs e)
        {
            whichYearComboBox.Items.Add("2013-2014 | Aerial Assist | Oshawa");
            whichYearComboBox.Items.Add("2013-2014 | Aerial Assist | Nipissing");
            whichYearComboBox.Items.Add("2014-2015 | Undecieded");
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
    }
}