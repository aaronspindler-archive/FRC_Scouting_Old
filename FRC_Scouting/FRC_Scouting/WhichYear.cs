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
                switch (whichToOpen)
                {
                    case 0:
                        var home2014 = new Home_2014();
                        home2014.Show();
                        this.Hide();
                        break;

                    case 1:
                        var home2015 = new Home_2015();
                        home2015.Show();
                        this.Hide();
                        break;
                }
            }
        }

        private void WhichYear_Load(object sender, EventArgs e)
        {
            whichYearComboBox.Items.Add("2013-2014 | Aerial Assist");
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
    }
}