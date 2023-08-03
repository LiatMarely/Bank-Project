using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_Project
{
    public partial class MusicButton : UserControl
    {
        public MusicButton()
        {
            InitializeComponent();
            switchImage();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            MusicUtils.PlayPauseMusic();
            switchImage();
        }

        private void switchImage()
        {
            if (MusicUtils.isPlaying)
            {
                pictureBoxMusic.BackgroundImage = Properties.Resources.SOUNDON;
            }
            else
            {
                pictureBoxMusic.BackgroundImage = Properties.Resources.SOUNDOFF;
            }
            pictureBoxMusic.Refresh();
        }
    }
}
