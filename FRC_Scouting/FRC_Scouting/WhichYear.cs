﻿using System;
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
        UsefulSnippets us = new UsefulSnippets();

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
                        break;
                }
            }
        }

        private void WhichYear_Load(object sender, EventArgs e)
        {
            whichYearComboBox.Items.Add("2013-2014 | Aerial Assist");
        }
    }
}
