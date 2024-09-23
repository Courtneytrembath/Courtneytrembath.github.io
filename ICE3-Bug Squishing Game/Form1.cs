using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICE3_Bug_Squishing_Game
{
    public partial class Form1 : Form
    {
        const int StartTime = 60;
        const int StartInerval = 2000;
        Random random = new Random();
        int score = 0;//how many bugs you squished
        int timeleft = StartTime;
        //array bug
        Bitmap[] bugImage =
        {
            Properties.Resources.bug1,
            Properties.Resources.bug2,
            Properties.Resources.bugs,
        };
        // storing the last bug so we dont get repeats
        int newIndex, lastIndex = -1;
        public Form1()
        {
            InitializeComponent();
            timeLabel.Text = "Time left: " + timeleft;
        }


        private void pictureBox2_Click(object sender, MouseEventArgs e)
        {
            //unsubcribe to mouse down event
            bug.MouseDown -= pictureBox2_Click;
            // show blood splat
            bug.Image = Properties.Resources.Sailorsaturn78_Halloween_Blood_splat_32;
            // increase scroe and update lable
            score++;
            scoreLabel.Text = $"Squished {score} Bugs";
            //spawnBug();

        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            timeleft--;// decreasing time by 1 second
            timeLabel.Text = "Time left: " + timeleft;

            //evers 10 seconds spawn faster
            if (timeleft % 10 == 0) spawnTimer.Interval /= 2;

            if (timeleft == 0) GameOver();
        }

        void GameOver()
        {
            //stop timers
            gameTimer.Stop();
            spawnTimer.Stop();
            //hide bug
            bug.Visible = false;
            // resart button
            button1.Visible = true;


        }
        void RestartGame(object sender, EventArgs e)
        {
            spawnTimer.Interval = StartInerval;
            timeleft = StartTime;
            score = 0;
            scoreLabel.Text = $"Squished {score} Bugs";
            gameTimer.Start();
            spawnTimer.Start();
            bug.Visible = true;
            button1.Visible= false;

        }



        //called automaticly by timer

        private void spawnBug(object sender=null, EventArgs e=null)
        {
            //unsubcribe to mouse down event
            bug.MouseDown -= pictureBox2_Click;
            //unsubcribe to mouse down event
            bug.MouseDown += pictureBox2_Click;
            // reset image to a random bug
            do
            {
                newIndex = random.Next(0, bugImage.Length);

            } while (newIndex == lastIndex);
            lastIndex=newIndex;
            bug.Image = bugImage[newIndex];
            // move the bug to random location
            // clientsize means only visable area
            
            int randomX = random.Next(0, ClientSize.Width - bug.Width); ;
            //starting from 39 because of the score label
            int randomY = random.Next(39, ClientSize.Height - bug.Height);
            bug.Location = new Point(randomX, randomY);
        }


    }
}
