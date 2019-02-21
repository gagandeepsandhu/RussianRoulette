using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RussianRoulette
{
    public partial class frmMain : Form
    {
        //initialize the class variable
        WinLose clsWinLose = new WinLose();
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
            // enabale or disable button
            btnSpin.Enabled = false;
            btnFire.Enabled = false;
            btnPlayAgain.Enabled = false;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
       
            clsWinLose.PlaySound(@"GUN+Reload.wav");//play load bullet sound
            clsWinLose.FireCount = 0;
            clsWinLose.BulletLocation = 0;
            // enabale or disable button
            btnSpin.Enabled = true;
            btnLoad.Enabled = false;
            lblMessage.Text = "";


        }

        private void btnSpin_Click(object sender, EventArgs e)
        {
            clsWinLose.PlaySound(@"GUN+Clip.wav"); //play spin chamber sound
            // enabale or disable button
            clsWinLose.Randomize();
            btnSpin.Enabled = false;
            btnFire.Enabled = true;
           
           
        }

        private void btnFire_Click(object sender, EventArgs e)
        {
          
            
            if (clsWinLose.IsWinner())
            { 
                lblWinScore.Text = (Convert.ToInt32(lblWinScore.Text) +100).ToString();
                lblMessage.Text = "Good Job! you Hit";
                //enable or disable the button control
                btnFire.Enabled = false;
                btnLoad.Enabled = true;
                btnPlayAgain.Enabled = false;
                clsWinLose.PlaySound(@"GUN+Shot2.wav");
            }
            else
            {
                lblLossScore.Text = (Convert.ToInt32(lblLossScore.Text) + 100).ToString();
                clsWinLose.PlaySound(@"GUN+Empty.wav");

                if(clsWinLose.FireCount==3) // game over after 2 chances
                { 
                lblMessage.Text = "You die,!Game Over";
                btnPlayAgain.Enabled = true;
                btnFire.Enabled = false;
                    lblLossScore.Text = "0";
                }

            }
                
         

        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            clsWinLose.BulletLocation = 0;
            
            //enable or disable the button control
            btnSpin.Enabled = false;
            btnFire.Enabled = false;
            btnLoad.Enabled = true;
            btnPlayAgain.Enabled = false;


            //reset the lable text
            lblMessage.Text = ".";
            lblLossScore.Text = "0";
            lblWinScore.Text = "0";
        }
    }
}
