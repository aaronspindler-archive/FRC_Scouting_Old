using General_Form;
using System;

namespace FRC_Scouting
{
    public partial class Team_Directory : GeneralForm
    {
        public Team_Directory()
        {
            InitializeComponent();
        }

        private void Teams_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 5352; i++)
            {
                teamListBox.Items.Add("Team: " + i);
            }
        }
    }
}