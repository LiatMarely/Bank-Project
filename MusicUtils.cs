using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Project
{
    public static class MusicUtils
    {
        private static WMPLib.WindowsMediaPlayer player;
        public static bool isPlaying { get; set; }

        static MusicUtils()
        {
            player = new WMPLib.WindowsMediaPlayer();
            isPlaying = false;
            player.URL = "Music.mp3";
            player.controls.stop();
        }

        public static void PlayPauseMusic()
        {
            if (isPlaying == false)
            {
                player.controls.play();
            } 
            else
            {
                player.controls.pause();
            }
            isPlaying = !isPlaying;
        }
    }
}
