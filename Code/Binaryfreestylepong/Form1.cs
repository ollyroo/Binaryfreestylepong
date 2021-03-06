﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace Binaryfreestylepong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //some startup stuff
        private int ballspeed = 5, goingright = 1, goingdown = 1, PlayerOneScoreOnGo = 1,PlayerTwoScoreOnGo = 1, caseX = 0, caseY = 0, streak1 = 1, streak2 = 1;
        private Boolean GoingRightPlayer1, GoingUpPlayer1, GoingLeftPlayer1, GoingDownPlayer1, GoingRightPlayer2, GoingUpPlayer2, GoingLeftPlayer2, GoingDownPlayer2, Scoring, turnOne, turnTwo, reverseRotateOne, reverseRotateTwo;
        //all variable asignment
        private void ballTimer_Tick(object sender, EventArgs e)
        {

            ball.Location = new Point(ball.Location.X + ballspeed*goingright, ball.Location.Y + ballspeed*goingdown);
            //main ball movement
            if (ball.Bounds.IntersectsWith(rightWall.Bounds))
            {
                goingright = goingright * -1;
                //detects if hit right wall
                caseY = 0;

                if (ball.Location.Y <= 132 || ball.Location.Y >= 328)
                    caseY = 1;
                else if (ball.Location.X <= 188 || ball.Location.Y >= 271)
                    caseY = 2;
                else if (ball.Location.Y <= 216 || ball.Location.Y >= 244)
                    caseY = 3;
                else if (ball.Location.Y <= 244)
                    caseY = 4;
                //case statement for scoring
                switch (caseY)
                {
                    case 1:
                        if (Scoring == true)
                        {
                            PlayerOneScoreOnGo = PlayerOneScoreOnGo + 1 * streak1;
                            streak1 = streak1 + 2;
                            streak2 = 1;
                            score1.Text = PlayerOneScoreOnGo.ToString();
                        }
                        else
                        {
                            PlayerTwoScoreOnGo = PlayerTwoScoreOnGo + 1 * streak2;
                            streak2 = streak2 + 1;
                            streak1 = 1;
                            score2.Text = PlayerTwoScoreOnGo.ToString();
                        }
                        break;
                    case 2:
                        if (Scoring == true)
                        {
                            PlayerOneScoreOnGo = PlayerOneScoreOnGo + 2 * streak1;
                            streak1 = streak1 + 2;
                            streak2 = 1;
                            score1.Text = PlayerOneScoreOnGo.ToString();
                        }
                        else
                        {
                            PlayerTwoScoreOnGo = PlayerTwoScoreOnGo + 2 * streak2;
                            streak2 = streak2 + 1;
                            streak1 = 1;
                            score2.Text = PlayerTwoScoreOnGo.ToString();
                        }
                        break;
                    case 3:
                        if (Scoring == true)
                        {
                            PlayerOneScoreOnGo = PlayerOneScoreOnGo + 4 * streak1;
                            streak1 = streak1 + 2;
                            streak2 = 1;
                            score1.Text = PlayerOneScoreOnGo.ToString();
                        }
                        else
                        {
                            PlayerTwoScoreOnGo = PlayerTwoScoreOnGo + 4 * streak2;
                            streak2 = streak2 + 1;
                            streak1 = 1;
                            score2.Text = PlayerTwoScoreOnGo.ToString();
                        }
                        break;
                    case 4:
                        if (Scoring == true)
                        {
                            PlayerOneScoreOnGo = PlayerOneScoreOnGo + 8 * streak1;
                            streak1 = streak1 + 2;
                            streak2 = 1;
                            score1.Text = PlayerOneScoreOnGo.ToString();
                        }
                        else
                        {
                            PlayerTwoScoreOnGo = PlayerTwoScoreOnGo + 8 * streak2;
                            streak2 = streak2 + 1;
                            streak1 = 1;
                            score2.Text = PlayerTwoScoreOnGo.ToString();
                        }
                        break;
                        
                }
            }
            if (ball.Bounds.IntersectsWith(bottomWall.Bounds))
            {
                goingdown = goingdown * -1;
                //detects if hit bottom wall
                caseX = 0;

                if (ball.Location.X <= 132 || ball.Location.X >= 328)
                    caseX = 1;
                else if (ball.Location.X <= 188 || ball.Location.X >= 271)
                    caseX = 2;
                else if (ball.Location.X <= 216 || ball.Location.X >= 244)
                    caseX = 3;
                else if (ball.Location.X <= 244)
                    caseX = 4;
                // case statement for scoring
                switch (caseX)
                {
                    case 1:
                        if (Scoring == true)
                        {
                            PlayerOneScoreOnGo = PlayerOneScoreOnGo + 1 * streak1;
                            streak1 = streak1 + 2;
                            streak2 = 1;
                            score1.Text = PlayerOneScoreOnGo.ToString();
                        }
                        else
                        {
                            PlayerTwoScoreOnGo = PlayerTwoScoreOnGo + 1 * streak2;
                            streak2 = streak2 + 1;
                            streak1 = 1;
                            score2.Text = PlayerTwoScoreOnGo.ToString();
                        }
                        break;
                    case 2:
                        if (Scoring == true)
                        {
                            PlayerOneScoreOnGo = PlayerOneScoreOnGo + 2 * streak1;
                            streak1 = streak1 + 2;
                            streak2 = 1;
                            score1.Text = PlayerOneScoreOnGo.ToString();
                        }
                        else
                        {
                            PlayerTwoScoreOnGo = PlayerTwoScoreOnGo + 2 * streak2;
                            streak2 = streak2 + 1;
                            streak1 = 1;
                            score2.Text = PlayerTwoScoreOnGo.ToString();
                        }
                        break;
                    case 3:
                        if (Scoring == true)
                        {
                            PlayerOneScoreOnGo = PlayerOneScoreOnGo + 4 * streak1;
                            streak1 = streak1 + 2;
                            streak2 = 1;
                            score1.Text = PlayerOneScoreOnGo.ToString();
                        }
                        else
                        {
                            PlayerTwoScoreOnGo = PlayerTwoScoreOnGo + 4 * streak2;
                            streak2 = streak2 + 1;
                            streak1 = 1;
                            score2.Text = PlayerTwoScoreOnGo.ToString();
                        }
                        break;
                    case 4:
                        if (Scoring == true)
                        {
                            PlayerOneScoreOnGo = PlayerOneScoreOnGo + 8 * streak1;
                            streak1 = streak1 + 2;
                            streak2 = 1;
                            score1.Text = PlayerOneScoreOnGo.ToString();
                        }
                        else
                        {
                            PlayerTwoScoreOnGo = PlayerTwoScoreOnGo + 8 * streak2;
                            streak2 = streak2 + 1;
                            streak1 = 1;
                            score2.Text = PlayerTwoScoreOnGo.ToString();
                        }
                        break;
                }
            }
            if (ball.Bounds.IntersectsWith(leftWall.Bounds))
            {
                goingright = goingright * -1;
                //detects if hit left wall
                caseY = 0;

                if (ball.Location.Y <= 132 || ball.Location.Y >= 328)
                    caseY = 1;
                else if (ball.Location.X <= 188 || ball.Location.Y >= 271)
                    caseY = 2;
                else if (ball.Location.Y <= 216 || ball.Location.Y >= 244)
                    caseY = 3;
                else if (ball.Location.Y <= 244)
                    caseY = 4;
                //case statement for scoring
                switch (caseY)
                {
                    case 1:
                        if (Scoring == true)
                        {
                            PlayerOneScoreOnGo = PlayerOneScoreOnGo + 1 * streak1;
                            streak1 = streak1 + 2;
                            streak2 = 1;
                            score1.Text = PlayerOneScoreOnGo.ToString();
                        }
                        else
                        {
                            PlayerTwoScoreOnGo = PlayerTwoScoreOnGo + 1 * streak2;
                            streak2 = streak2 + 1;
                            streak1 = 1;
                            score2.Text = PlayerTwoScoreOnGo.ToString();
                        }
                        break;
                    case 2:
                        if (Scoring == true)
                        {
                            PlayerOneScoreOnGo = PlayerOneScoreOnGo + 2 * streak1;
                            streak1 = streak1 + 2;
                            streak2 = 1;
                            score1.Text = PlayerOneScoreOnGo.ToString();
                        }
                        else
                        {
                            PlayerTwoScoreOnGo = PlayerTwoScoreOnGo + 2 * streak2;
                            streak2 = streak2 + 1;
                            streak1 = 1;
                            score2.Text = PlayerTwoScoreOnGo.ToString();
                        }
                        break;
                    case 3:
                        if (Scoring == true)
                        {
                            PlayerOneScoreOnGo = PlayerOneScoreOnGo + 4 * streak1;
                            streak1 = streak1 + 2;
                            streak2 = 1;
                            score1.Text = PlayerOneScoreOnGo.ToString();
                        }
                        else
                        {
                            PlayerTwoScoreOnGo = PlayerTwoScoreOnGo + 4 * streak2;
                            streak2 = streak2 + 1;
                            streak1 = 1;
                            score2.Text = PlayerTwoScoreOnGo.ToString();
                        }
                        break;
                    case 4:
                        if (Scoring == true)
                        {
                            PlayerOneScoreOnGo = PlayerOneScoreOnGo + 8 * streak1;
                            streak1 = streak1 + 2;
                            streak2 = 1;
                            score1.Text = PlayerOneScoreOnGo.ToString();
                        }
                        else
                        {
                            PlayerTwoScoreOnGo = PlayerTwoScoreOnGo + 8 * streak2;
                            streak2 = streak2 + 1;
                            streak1 = 1;
                            score2.Text = PlayerTwoScoreOnGo.ToString();
                        }
                        break;
                }
            }
            if (ball.Bounds.IntersectsWith(topWall.Bounds))
            {
                goingdown = goingdown * -1;
                //detects if hit top wall
                caseX = 0;

                if (ball.Location.X <= 132 || ball.Location.X >= 328)
                    caseX = 1;
                else if (ball.Location.X <= 188 || ball.Location.X >= 271)
                    caseX = 2;
                else if (ball.Location.X <= 216 || ball.Location.X >= 244)
                    caseX = 3;
                else if (ball.Location.X <= 244)
                    caseX = 4;
                //case statement for scoring
                switch (caseX)
                {
                    case 1:
                        if (Scoring == true)
                        {
                            PlayerOneScoreOnGo = PlayerOneScoreOnGo + 1 * streak1;
                            streak1 = streak1 + 2;
                            streak2 = 1;
                            score1.Text = PlayerOneScoreOnGo.ToString();
                        }
                        else
                        {
                            PlayerTwoScoreOnGo = PlayerTwoScoreOnGo + 1 * streak2;
                            streak2 = streak2 + 1;
                            streak1 = 1;
                            score2.Text = PlayerTwoScoreOnGo.ToString();
                        }
                        break;
                    case 2:
                        if (Scoring == true)
                        {
                            PlayerOneScoreOnGo = PlayerOneScoreOnGo + 2 * streak1;
                            streak1 = streak1 + 2;
                            streak2 = 1;
                            score1.Text = PlayerOneScoreOnGo.ToString();
                        }
                        else
                        {
                            PlayerTwoScoreOnGo = PlayerTwoScoreOnGo + 2 * streak2;
                            streak2 = streak2 + 1;
                            streak1 = 1;
                            score2.Text = PlayerTwoScoreOnGo.ToString();
                        }
                        break;
                    case 3:
                        if (Scoring == true)
                        {
                            PlayerOneScoreOnGo = PlayerOneScoreOnGo + 4 * streak1;
                            streak1 = streak1 + 2;
                            streak2 = 1;
                            score1.Text = PlayerOneScoreOnGo.ToString();
                        }
                        else
                        {
                            PlayerTwoScoreOnGo = PlayerTwoScoreOnGo + 4 * streak2;
                            streak2 = streak2 + 1;
                            streak1 = 1;
                            score2.Text = PlayerTwoScoreOnGo.ToString();
                        }
                        break;
                    case 4:
                        if (Scoring == true)
                        {
                            PlayerOneScoreOnGo = PlayerOneScoreOnGo + 8 * streak1;
                            streak1 = streak1 + 2;
                            streak2 = 1;
                            score1.Text = PlayerOneScoreOnGo.ToString();
                        }
                        else
                        {
                            PlayerTwoScoreOnGo = PlayerTwoScoreOnGo + 8 * streak2;
                            streak2 = streak2 + 1;
                            streak1 = 1;
                            score2.Text = PlayerTwoScoreOnGo.ToString();
                        }
                        break;
                }
            }
            if (ball.Bounds.IntersectsWith(playerOne.Bounds))
            {
                if (reverseRotateOne)
                    goingright = goingright * -1;
                else
                    goingdown = goingdown * -1;
                //movement of ball if it hits player one
                ball.Image = (Binaryfreestylepong.Properties.Resources.ballWhite);
                ball.Location = new Point(ball.Location.X + ballspeed * goingright, ball.Location.Y + ballspeed * goingdown);
                if (ball.Bounds.IntersectsWith(playerOne.Bounds))
                {
                    goingdown = goingdown * -1;
                    goingright = goingright * -1;
                }
                //this helps with ball stickyness
                Scoring = true;

            }
            if (ball.Bounds.IntersectsWith(playerTwo.Bounds))
            {
                if (reverseRotateTwo)
                    goingdown = goingdown * -1;
                else
                    goingright = goingright * -1;
                //detects if ball hit player two
                ball.Image = (Binaryfreestylepong.Properties.Resources.ballBlack);
                ball.Location = new Point(ball.Location.X + ballspeed * goingright, ball.Location.Y + ballspeed * goingdown);
                if (ball.Bounds.IntersectsWith(playerTwo.Bounds))
                {
                    goingright = goingright * -1;
                    goingdown = goingdown * -1;
                }
                //makes collision less sticky
                Scoring = false;
            }
        }

        private void playertimer_Tick(object sender, EventArgs e)
        {
            if (GoingUpPlayer1)
                if (playerOne.Bounds.IntersectsWith(topWall.Bounds) == false)
                playerOne.Location = new Point(playerOne.Location.X, playerOne.Location.Y - 2);
           if (GoingRightPlayer1)
               if (playerOne.Bounds.IntersectsWith(rightWall.Bounds) == false)
               playerOne.Location = new Point(playerOne.Location.X + 2, playerOne.Location.Y);
           if (GoingDownPlayer1)
               if (playerOne.Bounds.IntersectsWith(bottomWall.Bounds) == false)
               playerOne.Location = new Point(playerOne.Location.X, playerOne.Location.Y + 2);
           if (GoingLeftPlayer1)
               if (playerOne.Bounds.IntersectsWith(leftWall.Bounds) == false)
               playerOne.Location = new Point(playerOne.Location.X - 2, playerOne.Location.Y);
            //collion for player one hitting a wall
           if (turnOne)
           {
               playerOne.Size = new Size(20, 116);
               reverseRotateOne = true;
           }
           else
           {
               playerOne.Size = new Size(116, 20);
               reverseRotateOne = false;
           }
            //changes padle acording to rotation
           if (GoingUpPlayer2)
               if (playerTwo.Bounds.IntersectsWith(topWall.Bounds)== false)
               playerTwo.Location = new Point(playerTwo.Location.X, playerTwo.Location.Y - 2);
           if (GoingRightPlayer2)
               if (playerTwo.Bounds.IntersectsWith(rightWall.Bounds) == false)
               playerTwo.Location = new Point(playerTwo.Location.X + 2, playerTwo.Location.Y);
           if (GoingDownPlayer2)
               if (playerTwo.Bounds.IntersectsWith(bottomWall.Bounds) == false)
               playerTwo.Location = new Point(playerTwo.Location.X, playerTwo.Location.Y + 2);
           if (GoingLeftPlayer2)
               if (playerTwo.Bounds.IntersectsWith(leftWall.Bounds) == false)
               playerTwo.Location = new Point(playerTwo.Location.X - 2, playerTwo.Location.Y);
            //collision for player two hitting a wall
           if (turnTwo)
           {
               playerTwo.Size = new Size(20, 116);
               reverseRotateTwo = false;
           }
           else
           {
               playerTwo.Size = new Size(116, 20);
               reverseRotateTwo = true;

           }
        }

        private void Form1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D)
                GoingRightPlayer1 = true;
            if (e.KeyCode == Keys.W)
                GoingUpPlayer1 = true;
            if (e.KeyCode == Keys.A)
                GoingLeftPlayer1 = true;
            if (e.KeyCode == Keys.S)
                GoingDownPlayer1 = true;
            if (e.KeyCode == Keys.Space)
                if (turnOne)
                    turnOne = false;
                else
                    turnOne = true;

            if (e.KeyCode == Keys.Right)
                GoingRightPlayer2 = true;
            if (e.KeyCode == Keys.Up)
                GoingUpPlayer2 = true;
            if (e.KeyCode == Keys.Left)
                GoingLeftPlayer2 = true;
            if (e.KeyCode == Keys.Down)
                GoingDownPlayer2 = true;
            if (e.KeyCode == Keys.Enter)
                if (turnTwo)
                    turnTwo = false;
                else
                    turnTwo = true;
            //detects if a key was pressed
        }

        private void Form1_KeyUp_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D)
                GoingRightPlayer1 = false;
            if (e.KeyCode == Keys.W)
                GoingUpPlayer1 = false;
            if (e.KeyCode == Keys.A)
                GoingLeftPlayer1 = false;
            if (e.KeyCode == Keys.S)
                GoingDownPlayer1 = false;

            if (e.KeyCode == Keys.Right)
                GoingRightPlayer2 = false;
            if (e.KeyCode == Keys.Up)
                GoingUpPlayer2 = false;
            if (e.KeyCode == Keys.Left)
                GoingLeftPlayer2 = false;
            if (e.KeyCode == Keys.Down)
                GoingDownPlayer2 = false;
            //detects if a key was let go of
            
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            ballTimer.Enabled = true;
            playertimer.Enabled = true;
            introBox.Visible = false;
            //startup loop
        } 

    }
}