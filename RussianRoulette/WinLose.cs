using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RussianRoulette
{


    public class WinLose
    {
        public int TriggerPoint = 4;

        public int BulletLocation { get; set; }
        public int FireCount { get; set; }

        public void PlaySound(string FileName)
        {
            // play sound 
            string path = Application.StartupPath.Substring(0, Application.StartupPath.LastIndexOf("bin"));
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(path + FileName);
            player.Play();
        }
        public void Randomize()
        {
            // randomize the bullet location
            Random rnd = new Random();
            BulletLocation = rnd.Next(1,7);
        }

        public bool IsWinner()
        {
            bool ret = false;
            // check if hit or miss
            if (BulletLocation == TriggerPoint)
            {
                ret = true;
            }
            if (FireCount == 3 && BulletLocation != TriggerPoint)
            {
                ret = false;
            }
            BulletLocation++;
            FireCount++;
            return ret;
        }
      
    }
}