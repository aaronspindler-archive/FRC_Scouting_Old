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
                    sponsorPictureBox.Image = Properties.Resources.fednor_platinum_northbay;
                    sponsorName = ("FedNor");
                    sponsorLevel = ("Platinum");
                    break;
                case 1:
                    sponsorPictureBox.Image = Properties.Resources.redpath_platinum_northbay;
                    sponsorName = ("RedPath");
                    sponsorLevel = ("Platinum");
                    break;
                case 2:
                    sponsorPictureBox.Image = Properties.Resources.nipu_platinum_northbay;
                    sponsorName = ("Nipissing University");
                    sponsorLevel = ("Platinum");
                    break;
                case 3:
                    sponsorPictureBox.Image = Properties.Resources.atlascopco_gold_northbay;
                    sponsorName = ("Atlas Copco");
                    sponsorLevel = ("Gold");
                    break;
                case 4:
                    sponsorPictureBox.Image = Properties.Resources.twg_gold_northbay;
                    sponsorName = ("twg* Communications");
                    sponsorLevel = ("Gold");
                    break;
                case 5:
                    sponsorPictureBox.Image = Properties.Resources.ontario_silver_northbay;
                    sponsorName = ("Ontario | Northern Ontario Heritage Fund Corporation");
                    sponsorLevel = ("Silver");
                    break;
                case 6:
                    sponsorPictureBox.Image = Properties.Resources.forbetteorforworse_silver_northbay;
                    sponsorName = ("For Better for Worse");
                    sponsorLevel = ("Silver");
                    break;
                case 7:
                    sponsorPictureBox.Image = Properties.Resources.canadore_silver_northbay;
                    sponsorName = ("Canadore College");
                    sponsorLevel = ("Silver");
                    break;
                case 8:
                    sponsorPictureBox.Image = Properties.Resources.stantec_bronze_northbay;
                    sponsorName = ("Stantec");
                    sponsorLevel = ("Bronze");
                    break;
                case 9:
                    sponsorPictureBox.Image = Properties.Resources.north_bay_strategicpartner_northbay;
                    sponsorName = ("North Bay");
                    sponsorLevel = ("Strategic Partner");
                    break;
                case 10:
                    sponsorPictureBox.Image = Properties.Resources.nearnorth_strategicpartner_northbay;
                    sponsorName = ("Near North District School Board");
                    sponsorLevel = ("Strategic Partner");
                    break;
                case 11:
                    sponsorPictureBox.Image = Properties.Resources.metso_inkind_northbay;
                    sponsorName = ("Metso Minerals");
                    sponsorLevel = ("In Kind");
                    break;
                case 12:
                    sponsorPictureBox.Image = Properties.Resources.astowing_inkind_northbay;
                    sponsorName = ("A&S Towing");
                    sponsorLevel = ("In Kind");
                    break;
                case 13:
                    sponsorPictureBox.Image = Properties.Resources.sms_inkind_northbay;
                    sponsorName = ("SMS Rents");
                    sponsorLevel = ("In Kind");
                    break;
            }
            sponsorLevelLabel.Text = ("Sponsor Level: " + sponsorLevel);
            sponsorNameLabel.Text = ("Sponsor Name: " + sponsorName);
        }
    }
}