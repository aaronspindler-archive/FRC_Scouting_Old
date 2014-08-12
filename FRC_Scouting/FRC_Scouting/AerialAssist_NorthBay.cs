using System;
using System.Windows.Forms;

namespace FRC_Scouting
{
    public partial class AerialAssist_NorthBay : Form
    {
        private string selectedTeamName;
        private int selectedTeamNumber;
        private int selectedTeamLocation;
        private int selectedTeamSlot;

        public AerialAssist_NorthBay()
        {
            InitializeComponent();
        }

        private void AerialAssist_Nipissing_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AerialAssist_Nipissing_Load(object sender, EventArgs e)
        {
            //Loading Team Names
            teamSelector.Items.Add("188 | Blizzard");
            teamSelector.Items.Add("610 | The Coyotes");
            teamSelector.Items.Add("772 | Sabre Bytes");
            teamSelector.Items.Add("1305 | Ice Cubed");
            teamSelector.Items.Add("1310 | RUNNYMEDE ROBOTICS");
            teamSelector.Items.Add("1325 | Inverse Paradox");
            teamSelector.Items.Add("1334 | Red Devils");
            teamSelector.Items.Add("1605 | RoboHawks");
            teamSelector.Items.Add("2013 | Cybergnomes");
            teamSelector.Items.Add("2200 | MMRambotics");
            teamSelector.Items.Add("2386 | Trojans");
            teamSelector.Items.Add("2609 | BeaverworX");
            teamSelector.Items.Add("2994 | ASTECHZ");
            teamSelector.Items.Add("3543 | C4 Robotics");
            teamSelector.Items.Add("3571 | Milton Mustangs");
            teamSelector.Items.Add("3710 | FSS Cyber Falcons");
            teamSelector.Items.Add("4001 | Retro-Rams");
            teamSelector.Items.Add("4069 | Lo-Ellen Robotics");
            teamSelector.Items.Add("4152 | Hoya Robotics");
            teamSelector.Items.Add("4343 | MaxTech");
            teamSelector.Items.Add("4476 | W.A.F.F.L.E.S.");
            teamSelector.Items.Add("4704 | Northern Lights Robotics");
            teamSelector.Items.Add("4754 | RoBenedicts");
            teamSelector.Items.Add("4902 | The Wildebots");
            teamSelector.Items.Add("4914 | Panthers");
            teamSelector.Items.Add("4946 | ALPHA DOGS");
            teamSelector.Items.Add("4951 | CDS Cyclones");
            teamSelector.Items.Add("4968 | RoboHawks");
            teamSelector.Items.Add("4976 | Rebels");
            teamSelector.Items.Add("4992 | Spartans");
            teamSelector.Items.Add("5035 | eNimkii");
            teamSelector.Items.Add("5076 | Stormbots");
            teamSelector.Items.Add("5157 | Roboprime Cardinals");
            teamSelector.Items.Add("5164 | Gators");
            teamSelector.Items.Add("5191 | LANCERobotics");
            teamSelector.Items.Add("5324 | Hawks");
        }

        private void teamSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (teamSelector.SelectedIndex == 0)
            {
                
            }
            else
            {
                if (teamSelector.SelectedIndex == 1)
                {
                    
                }
                else
                {
                    if (teamSelector.SelectedIndex == 2)
                    {
                        
                    }
                    else
                    {
                        if (teamSelector.SelectedIndex == 3)
                        {
                            
                        }
                        else
                        {
                            if (teamSelector.SelectedIndex == 4)
                            {
                                
                            }
                            else
                            {
                                if (teamSelector.SelectedIndex == 5)
                                {
                                    
                                }
                                else
                                {
                                    if (teamSelector.SelectedIndex == 6)
                                    {
                                        
                                    }
                                    else
                                    {
                                        if (teamSelector.SelectedIndex == 7)
                                        {
                                            
                                        }
                                        else
                                        {
                                            if (teamSelector.SelectedIndex == 8)
                                            {
                                                
                                            }
                                            else
                                            {
                                                if (teamSelector.SelectedIndex == 9)
                                                {
                                                    
                                                }
                                                else
                                                {
                                                    if (teamSelector.SelectedIndex == 10)
                                                    {
                                                        
                                                    }
                                                    else
                                                    {
                                                        if (teamSelector.SelectedIndex == 11)
                                                        {
                                                            
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