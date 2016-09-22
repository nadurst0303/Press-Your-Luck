using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Press_Your_Luck
{
    public partial class GameBoard : Form
    {
        public struct player
        {
            int spins;
            int money;
        }
        private PictureBox[] tile = new PictureBox[15];
        private Bitmap[] image; //= new Bitmap[20];
        private Random random = new Random();

        public GameBoard()
        {
            InitializeComponent();
            tile = Controls.OfType<PictureBox>().ToArray();
            /*image[0] = Properties.Resources._500;
            image[1] = Properties.Resources._500spin;
            image[2] = Properties.Resources._530;
            image[3] = Properties.Resources._650;
            image[4] = Properties.Resources._750;
            image[5] = Properties.Resources._750spin;
            image[6] = Properties.Resources._800;
            image[7] = Properties.Resources._900;
            image[8] = Properties.Resources._1000;
            image[9] = Properties.Resources._1000s;
            image[10] = Properties.Resources._1100;
            image[11] = Properties.Resources._1200;
            image[12] = Properties.Resources._1250;
            image[13] = Properties.Resources._1300;
            image[14] = Properties.Resources._1400;
            image[15] = Properties.Resources._1500;
            image[16] = Properties.Resources._1500s;
            image[17] = Properties.Resources.whammy1;
            image[18] = Properties.Resources.whammy2;
            image[19] = Properties.Resources.whammy3;*/
            image = new Bitmap[] {Properties.Resources._500,
                Properties.Resources._500spin, Properties.Resources._530,
                Properties.Resources._650, Properties.Resources._750,
                Properties.Resources._750spin, Properties.Resources._800,
                Properties.Resources._900, Properties.Resources._1000,
                Properties.Resources._1000s, Properties.Resources._1100,
                Properties.Resources._1200, Properties.Resources._1250,
                Properties.Resources._1300, Properties.Resources._1400,
                Properties.Resources._1500, Properties.Resources._1500s,
                Properties.Resources.whammy1, Properties.Resources.whammy2,
                Properties.Resources.whammy3};

        }
        
        private void startButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Rules:\nRound One consists of 5 triva questions.\n"+
                "Player One buzzes in by pressing the 'A' key\n" + 
                "Player Two buzzes in by pressing the 'L' key\n" +
                "If you answer correctly, you get 3 spins\n" +
                "but wrong ansers take 1 spin away.\n\n" +
                "After the trivia round, the player with most spins gets to spin first.\n"+
                "You may continue spinning until you get a whammy or pass \n" +
                "spins to the other player if you want to play it safe.\n\n" +
                "The player with most points in the end wins! If you think you're ready, lets begin!");

            
            for (int i = 0; i < 14; i++)
                tile[i].Image = image[i];
            /*for (int i = 0; i < 5; i++)
            {
                questionLabel.Text = question from file
                read key from keyboard
                read answer from answerTextBox
                if key = 'a'
                    currentPlayer = playerOne
                else
                    currentPlayer = playerTwo
                if answerTextBox == answer (read from file)
                    currentPlayer.spins+=3
                    questionLabel.Text = "CORRECT. +3 SPINS"
                else
                    currentPlayer.spins--
                    questionLabel.Text = "INCORRECT. -1 SPIN"
            }*/
        }

        private void spinButton_Click(object sender, EventArgs e)
        {
            questionLabel.Text = "Press SPACEBAR to stop!";
            do
            {
                while (!Console.KeyAvailable)
                {
                    //move cursor and images randomly
                    for (int i = 1; i <16; i++)
                    {
                        //pictureBox[i].image = random image
                    }
                }
            }
            while (Console.ReadKey(true).Key != ConsoleKey.Spacebar);
        }
    }
}
