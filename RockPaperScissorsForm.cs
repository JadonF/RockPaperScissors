/*
 * Created by: Jadon Fournier
 * Created on: 8-Mar-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #18 - Rock, Paper, Scissors
 * This program allows you to play rock paper scissors against a a computer
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissors
{
    public partial class frmRockPaperScissors : Form
    {

        //Define variables and constants
        int PlayerChoice = 0;
        int ComChoice = 0;
        Random comRandom;
        const int MIN = 1;
        const int MAX = 3;

        public frmRockPaperScissors()
        {
            InitializeComponent();
            comRandom = new Random();

            //Hide labels
            this.lblAnswer.Hide();
            this.lblComChoice.Hide();
        }

        private void radRock_CheckedChanged(object sender, EventArgs e)
        {
            PlayerChoice = 1;
        }

        private void radPaper_CheckedChanged(object sender, EventArgs e)
        {
            PlayerChoice = 2;
        }

        private void radScissors_CheckedChanged(object sender, EventArgs e)
        {
            PlayerChoice = 3;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            //Randomly generate the computers choice
            ComChoice = comRandom.Next(MIN, MAX + 1);

            //Show the computers descision
            if (ComChoice == 1)
            {
                lblComChoice.Text = "Rock.";
            }

            else if (ComChoice == 2)
            {
                lblComChoice.Text = "Paper.";
            }

            else
            {
                lblComChoice.Text = "Scissors.";
            }

            //Check the variables
            if (PlayerChoice == 1)
            {
                if (ComChoice == 1)
                {
                    lblAnswer.Text = "Tie.";
                }

                else if (ComChoice == 2)
                {
                    lblAnswer.Text = "The computer wins.";
                }

                else
                {
                    lblAnswer.Text = "You Win!";
                }
            }

            if (PlayerChoice == 2)
            {
                if (ComChoice == 2)
                {
                    lblAnswer.Text = "Tie.";
                }

                else if (ComChoice == 3)
                {
                    lblAnswer.Text = "The computer wins.";
                }

                else
                {
                    lblAnswer.Text = "You Win!";
                }
            }

            if (PlayerChoice == 3)
            {
                if (ComChoice == 3)
                {
                    lblAnswer.Text = "Tie.";
                }

                else if (ComChoice == 1)
                {
                    lblAnswer.Text = "The computer wins.";
                }

                else
                {
                    lblAnswer.Text = "You Win!";
                }
            }

            //Show labels
            this.lblAnswer.Show();
            this.lblComChoice.Show();

        }
    }
}
