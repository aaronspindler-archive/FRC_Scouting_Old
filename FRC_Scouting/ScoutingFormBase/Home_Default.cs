using System;
using System.Windows.Forms;
using FRC_Scouting;

namespace ScoutingFormBase
{
    public partial class Home_Default : Form
    {
        public Home_Default()
        {
            InitializeComponent();
        }
        //Variables
        UsefulSnippets uc = new UsefulSnippets();

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            currentTimeDisplay.Text = ("Current Time: " + uc.GetCurrentTime());
        }

        private void Home_Default_Load(object sender, EventArgs e)
        {
            currentTimeDisplay.Text = ("Current Time: " + uc.GetCurrentTime());
            timer.Tick += timer_Tick;
            timer.Start();
        }

        private void Home_Default_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
