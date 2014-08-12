using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FRC_Scouting
{
    public partial class AerialAssist_Nipissing : Form
    {
        public AerialAssist_Nipissing()
        {
            InitializeComponent();
        }

        private void AerialAssist_Nipissing_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
