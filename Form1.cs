using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlapiBird
{
    public partial class FlappyBird : Form
    {
        int pipeSpeed = 8;
        int gravity = 15;
        int score = 0;



        public FlappyBird()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GameTimer(object sender, EventArgs e)
        {

            bird.Top += gravity;
            bottonPipe.Left -= pipeSpeed;
            topPipe.Left -= pipeSpeed;
            ScoreText.Text = "Score:" + score;


            if (bottonPipe.Left < -150)
            {
                bottonPipe.Left = 800;
                score++;
            }

            if (topPipe.Left < -150)
            {
                topPipe.Left = 700;
                score++;
            }

            if (score > 5)
            {
                pipeSpeed = 13;
            }
            if (score >= 25)
            {
                pipeSpeed = 15;
            }
            if (score > 35)
            {
                pipeSpeed = 18;
            }
            if (score > 50)
            {
                pipeSpeed = 23;
            }

            if (bird.Bounds.IntersectsWith(topPipe.Bounds) || bird.Bounds.IntersectsWith(bottonPipe.Bounds) || bird.Bounds.IntersectsWith(ground.Bounds) ||
                bird.Top < -25)
            {
                EndGame();
            }
        }

        private void gameKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -10;
            }
        }

        private void gameKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 10;
            }
        }


        public void EndGame()
        {
            gameTimer.Stop();
            ScoreText.Text += " " + " " + "Game Over";
        }


    }
}
