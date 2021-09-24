/*Frank Gatto
 * 9/24/21
 * CIS 3309
 * Lab 3
 * This class is a form to provide the user with a UI to play Yahtzee
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

namespace DiceGame
{
    public partial class Form1 : Form
    {
        DiceGame game = new DiceGame();
        bool scoreHasUpdated = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lockRadioButtons();
            pictureFirstDie.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureSecondDie.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureThirdDie.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureFourthDie.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureFifthDie.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        public void lockRadioButtons()
        {
            foreach (RadioButton rad in this.Controls.OfType<RadioButton>())
            {
                rad.Enabled = false;
            }
        }

        public void unlockRadioButtons()
        {
            foreach (RadioButton rad in this.Controls.OfType<RadioButton>())
            {
                rad.Enabled = true;
            }
        }

        public void displayRules()
        {
            MessageBox.Show("Click the button to roll the dice. \nAfter rolling choose the challenge that you would like to apply the roll to. \nYour selection will be locked in by clicking the roll dice button again. \nThe game is over when all challenges are completed.", "Rules", MessageBoxButtons.OK);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            displayRules();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRollDice_Click(object sender, EventArgs e)
        {
            
            if(game.NumberOfRolls == 0)
            {
                game.RollDice();
                unlockRadioButtons();
                game.NumberOfRolls++;
            }
            else
            {
                foreach(RadioButton rad in this.Controls.OfType<RadioButton>())
                {
                    if(rad.Checked)
                    {
                        if (game.IsChallengeValid(rad.Text))
                        {
                            game.UpdateScore(rad.Text);
                            rad.Enabled = false;
                            rad.Checked = false;
                            scoreHasUpdated = true;
                            break;
                        }
                    }
                }
                if(scoreHasUpdated == false)
                {
                    MessageBox.Show("You must choose a valid challenge to apply your roll to.", "INVALID CHALLENGE ERORR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }                
                game.RollDice();
                game.NumberOfRolls++;
            }

            if(IsGameOver())
            {
                MessageBox.Show("Game over. Your score: " + game.Score.ToString(), "Game Over", MessageBoxButtons.OK);
            }
            
            UpdateDiceImages();
            lblScore.Text = "Score: " + game.Score.ToString();

            

        }

        private void UpdateDiceImages()
        {
            pictureFirstDie.Image = Image.FromFile("../images/dice_" + game.Dice1 + ".png");
            pictureSecondDie.Image = Image.FromFile("../images/dice_" + game.Dice2 + ".png");
            pictureThirdDie.Image = Image.FromFile("../images/dice_" + game.Dice3 + ".png");
            pictureFourthDie.Image = Image.FromFile("../images/dice_" + game.Dice4 + ".png");
            pictureFifthDie.Image = Image.FromFile("../images/dice_" + game.Dice5 + ".png");
        }

        private bool IsGameOver()
        {
            foreach(RadioButton rad in this.Controls.OfType<RadioButton>())
            {
                if(rad.Enabled)
                {
                    return false;
                }
            }

            return true;
        }
    }
        
}
