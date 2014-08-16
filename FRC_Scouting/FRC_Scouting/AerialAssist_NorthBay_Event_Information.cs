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
        private int randomNum;
        private int previousNum;
        private string sponsorName;
        private string sponsorLevel;

        private void AerialAssist_NorthBay_Event_Information_Load(object sender, System.EventArgs e)
        {
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
            if (randomNum == 0)
            {
                sponsorPictureBox.Image = Properties.Resources.astowing_inkind_northbay;
                sponsorName = ("");
                sponsorLevel = ("");
            }
            else
            {
                if (randomNum == 1)
                {
                    sponsorPictureBox.Image = Properties.Resources.astowing_inkind_northbay;
                    sponsorName = ("");
                    sponsorLevel = ("");
                }
                else
                {
                    if (randomNum == 2)
                    {
                        sponsorPictureBox.Image = Properties.Resources.astowing_inkind_northbay;
                        sponsorName = ("");
                        sponsorLevel = ("");
                    }
                    else
                    {
                        if (randomNum == 3)
                        {
                            sponsorPictureBox.Image = Properties.Resources.astowing_inkind_northbay;
                            sponsorName = ("");
                            sponsorLevel = ("");
                        }
                        else
                        {
                            if (randomNum == 4)
                            {
                                sponsorPictureBox.Image = Properties.Resources.astowing_inkind_northbay;
                                sponsorName = ("");
                                sponsorLevel = ("");
                            }
                            else
                            {
                                if (randomNum == 5)
                                {
                                    sponsorPictureBox.Image = Properties.Resources.astowing_inkind_northbay;
                                    sponsorName = ("");
                                    sponsorLevel = ("");
                                }
                                else
                                {
                                    if (randomNum == 6)
                                    {
                                        sponsorPictureBox.Image = Properties.Resources.astowing_inkind_northbay;
                                        sponsorName = ("");
                                        sponsorLevel = ("");
                                    }
                                    else
                                    {
                                        if (randomNum == 7)
                                        {
                                            sponsorPictureBox.Image = Properties.Resources.astowing_inkind_northbay;
                                            sponsorName = ("");
                                            sponsorLevel = ("");
                                        }
                                        else
                                        {
                                            if (randomNum == 8)
                                            {
                                                sponsorPictureBox.Image = Properties.Resources.astowing_inkind_northbay;
                                                sponsorName = ("");
                                                sponsorLevel = ("");
                                            }
                                            else
                                            {
                                                if (randomNum == 9)
                                                {
                                                    sponsorPictureBox.Image = Properties.Resources.astowing_inkind_northbay;
                                                    sponsorName = ("");
                                                    sponsorLevel = ("");
                                                }
                                                else
                                                {
                                                    if (randomNum == 10)
                                                    {
                                                        sponsorPictureBox.Image = Properties.Resources.astowing_inkind_northbay;
                                                        sponsorName = ("");
                                                        sponsorLevel = ("");
                                                    }
                                                    else
                                                    {
                                                        if (randomNum == 11)
                                                        {
                                                            sponsorPictureBox.Image = Properties.Resources.astowing_inkind_northbay;
                                                            sponsorName = ("");
                                                            sponsorLevel = ("");
                                                        }
                                                        else
                                                        {
                                                            if (randomNum == 12)
                                                            {
                                                                sponsorPictureBox.Image = Properties.Resources.astowing_inkind_northbay;
                                                                sponsorName = ("");
                                                                sponsorLevel = ("");
                                                            }
                                                            else
                                                            {
                                                                if (randomNum == 13)
                                                                {
                                                                    sponsorPictureBox.Image = Properties.Resources.astowing_inkind_northbay;
                                                                    sponsorName = ("");
                                                                    sponsorLevel = ("");
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}