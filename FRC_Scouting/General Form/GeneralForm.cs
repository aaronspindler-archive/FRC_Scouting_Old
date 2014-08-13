using FRC_Scouting;
using System;
using System.Windows.Forms;

namespace General_Form
{
    public partial class GeneralForm : Form
    {
        private readonly UsefulSnippets us = new UsefulSnippets();

        public GeneralForm()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            currentTimeDisplay.Text = ("Current Time: " + us.GetCurrentTime());
        }

        private void GeneralForm_Load(object sender, EventArgs e)
        {
            currentTimeDisplay.Text = ("Current Time: " + us.GetCurrentTime());
            timer.Tick += timer_Tick;
            timer.Start();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}