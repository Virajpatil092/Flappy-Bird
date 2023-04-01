using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text; 
using System.Threading.Tasks;
using System.Windows.Forms;

namespace For_Freshers
{
    public partial class Gameop : Form
    {
        int pipespeed = 5;
        int gravity = 8;
        int score = 0;
        public Gameop()
        {  
            InitializeComponent();

        }                      
        private void gametimerevent(object sender, EventArgs e)
        { 
            maincharacter.Top += gravity;
            Bottompipe.Left -= pipespeed;   
            Toppipe.Left -= pipespeed;
            Scoretext.Text = "Score : " +score.ToString();
            if(Bottompipe.Left < -50)
            {
                score++;
                Bottompipe.Left = 400;
                if (score % 5 == 0) pipespeed ++;
            }

            if (Toppipe.Left < -80)
            {
                score++;
                Toppipe.Left = 550;
                if (score % 5 == 0) pipespeed ++;
            }

            if (maincharacter.Bounds.IntersectsWith(Bottompipe.Bounds)
              || maincharacter.Bounds.IntersectsWith(Toppipe.Bounds)
              || maincharacter.Bounds.IntersectsWith(Ground.Bounds))
            {
                endgame();
            }
            if(maincharacter.Top < -10)
            {
                endgame();
            }
        }

        private void GoDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = -10;
            }
        }

        private void Goup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 10;
            }
        }
        private void endgame()
        {
            Gametimer.Stop();
            Scoretext.Text="Game over !!! Score = " + score.ToString();
        }
    }
}