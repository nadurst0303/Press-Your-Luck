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
