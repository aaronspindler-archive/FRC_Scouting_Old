using System;
using General_Form;

namespace FRC_Scouting
{
    //@author xNovax
    public partial class AerialAssist_NorthBay_Event_Information : GeneralForm
    {
        public AerialAssist_NorthBay_Event_Information()
        {
            InitializeComponent();
        }
        Random gen = new Random();
        private int randomNum = 100;
        private int previousNum;
        private string sponsorName;
        private string sponsorLevel;

        private void AerialAssist_NorthBay_Event_Information_Load(object sender, System.EventArgs e)
        {
            randomNum = gen.Next(13);
            previousNum = randomNum;
            UpdateSponsor();

            timer.Tick += timer_Tick;
            timer.Start();
        }

        private void timer_Tick(object sender, System.EventArgs e)
        {
            randomNum = gen.Next(13);

            if (randomNum != previousNum)
            {
                UpdateSponsor();
            }
            else
            {
                randomNum = gen.Next(13);
                UpdateSponsor();
            }
            previousNum = randomNum;
        }

        public void UpdateSponsor()
        {
            switch (randomNum)
            {
                case 0:
                    sponsorPictureBox.Image = Properties.Resources.astowing_inkind_northbay;
                    sponsorName = ("");
                    sponsorLevel = ("");
                    break;
                case 1:
                    sponsorPictureBox.Image = Properties.Resources.astowing_inkind_northbay;
                    sponsorName = ("");
                    sponsorLevel = ("");
                    break;
                case 2:
                    sponsorPictureBox.Image = Properties.Resources.astowing_inkind_northbay;
                    sponsorName = ("");
                    sponsorLevel = ("");
                    break;
                case 3:
                    sponsorPictureBox.Image = Properties.Resources.astowing_inkind_northbay;
                    sponsorName = ("");
                    sponsorLevel = ("");
                    break;
                case 4:
                    sponsorPictureBox.Image = Properties.Resources.astowing_inkind_northbay;
                    sponsorName = ("");
                    sponsorLevel = ("");
                    break;
                case 5:
                    sponsorPictureBox.Image = Properties.Resources.astowing_inkind_northbay;
                    sponsorName = ("");
                    sponsorLevel = ("");
                    break;
                case 6:
                    sponsorPictureBox.Image = Properties.Resources.astowing_inkind_northbay;
                    sponsorName = ("");
                    sponsorLevel = ("");
                    break;
                case 7:
                    sponsorPictureBox.Image = Properties.Resources.astowing_inkind_northbay;
                    sponsorName = ("");
                    sponsorLevel = ("");
                    break;
                case 8:
                    sponsorPictureBox.Image = Properties.Resources.astowing_inkind_northbay;
                    sponsorName = ("");
                    sponsorLevel = ("");
                    break;
                case 9:
                    sponsorPictureBox.Image = Properties.Resources.astowing_inkind_northbay;
                    sponsorName = ("");
                    sponsorLevel = ("");
                    break;
                case 10:
                    sponsorPictureBox.Image = Properties.Resources.astowing_inkind_northbay;
                    sponsorName = ("");
                    sponsorLevel = ("");
                    break;
                case 11:
                    sponsorPictureBox.Image = Properties.Resources.astowing_inkind_northbay;
                    sponsorName = ("");
                    sponsorLevel = ("");
                    break;
                case 12:
                    sponsorPictureBox.Image = Properties.Resources.astowing_inkind_northbay;
                    sponsorName = ("");
                    sponsorLevel = ("");
                    break;
                case 13:
                    sponsorPictureBox.Image = Properties.Resources.astowing_inkind_northbay;
                    sponsorName = ("");
                    sponsorLevel = ("");
                    break;
            }
            sponsorLevelLabel.Text = ("Sponsor Level: " + sponsorLevel);
            sponsorNameLabel.Text = ("Sponsor Name: " + sponsorName);
        }
    }
}