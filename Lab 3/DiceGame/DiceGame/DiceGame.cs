/*Frank Gatto
 * 9/24/21
 * CIS 3309
 * Lab 3
 * This class has the funtionality of a Yahtzee game. 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    class DiceGame
    {
        protected int dice1;
        protected int dice2;
        protected int dice3;
        protected int dice4;
        protected int dice5;
        protected int score;
        protected int numberOfRolls;
        Random rand = new Random();
        public DiceGame()
        {
            this.dice1 = 0;
            this.dice2 = 0;
            this.dice3 = 0;
            this.dice4 = 0;
            this.dice5 = 0;
            this.score = 0;
            this.numberOfRolls = 0;
        }

        public int Dice1
        {
            get
            {
                return dice1;
            }
            set
            {
                dice1 = value;
            }
        }

        public int Dice2
        {
            get
            {
                return dice2;
            }
            set
            {
                dice2 = value;
            }
        }

        public int Dice3
        {
            get
            {
                return dice3;
            }
            set
            {
                dice3 = value;
            }
        }

        public int Dice4
        {
            get
            {
                return dice4;
            }
            set
            {
                dice4 = value;
            }
        }

        public int Dice5
        {
            get
            {
                return dice5;
            }
            set
            {
                dice5 = value;
            }
        }

        public int Score
        {
            get
            {
                return score;
            }
            set
            {
                score = value;
            }
        }

        public int NumberOfRolls
        {
            get
            {
                return numberOfRolls;
            }
            set
            {
                numberOfRolls = value;
            }
        }

        private int GenerateNumber()
        { 
            return rand.Next(1, 7);
        }

        public void RollDice()
        {
            dice1 = GenerateNumber();
            dice2 = GenerateNumber();
            dice3 = GenerateNumber();
            dice4 = GenerateNumber();
            dice5 = GenerateNumber();
        }

        //this function calculates the score for the selected challenge
        public void UpdateScore(String challenge)
        {
            if(challenge.Equals("Aces"))
            {
                score += CountNumber(1);
            }
            else if(challenge.Equals("Twos"))
            {
                score += CountNumber(2) * 2;
            }
            else if(challenge.Equals("Threes"))
            {
                score += CountNumber(3) * 3;
            }
            else if(challenge.Equals("Fours"))
            {
                score += CountNumber(4) * 4;
            }
            else if(challenge.Equals("Fives"))
            {
                score += CountNumber(5) * 5;
            }
            else if(challenge.Equals("Sixes"))
            {
                score += CountNumber(6) * 6;
            }
            else if(challenge.Equals("Three of a Kind"))
            {
                if(IsThereAmountOfSameDice(3))
                {
                    score += SumDice();
                }
            }
            else if(challenge.Equals("Four of a Kind"))
            {
                if(IsThereAmountOfSameDice(4))
                {
                    score += SumDice();
                }
            }
            else if(challenge.Equals("Full House"))
            {
                if(IsFullHouse())
                {
                    score += 25;
                }
            }
            else if(challenge.Equals("Small Straight"))
            {
                if(NumberOfSequentialDice() >= 4)
                {
                    score += 30;
                }
            }
            else if(challenge.Equals("Large Straight"))
            {
                if(NumberOfSequentialDice() == 5)
                {
                    score += 40;
                }
            }
            else if(challenge.Equals("Yahtzee"))
            {
                if(IsThereAmountOfSameDice(5))
                {
                    score += 50;
                }
            }
            else if(challenge.Equals("Chance"))
            {
                score += SumDice();
            }
        }

        //this function returns a count of how many dice have the inputted number
        private int CountNumber(int number)
        {
            int count = 0;
            if(dice1 == number)
            {
                count++;
            }
            if(dice2 == number)
            {
                count++;
            }
            if(dice3 == number)
            {
                count++;
            }
            if(dice4 == number)
            {
                count++;
            }
            if(dice5 == number)
            {
                count++;
            }
            return count;
        }

        //this function counts the amount of dice that have the same number
        //returns true if the amount is at least the inputted amount
        //returns false otherwise
        private bool IsThereAmountOfSameDice(int amount)
        {
            for (int i = 1; i <= 6; i++)
            {
                if (CountNumber(i) >= amount)
                {
                    return true;
                }
            }
            return false;
        }

        //this function determins if the player has a full house
        private bool IsFullHouse()
        {
            bool DoesPairExist = false;
            bool DoesThreeOfAKindExist = false;

            for (int i = 1; i <= 6; i++)
            {
                if (CountNumber(i) == 3)
                {
                    DoesThreeOfAKindExist = true;
                }
                if(CountNumber(i) == 2)
                {
                    DoesPairExist = true;
                }
            }
            return DoesPairExist && DoesThreeOfAKindExist;
        }

        //this function returns the sum of all of the dice
        private int SumDice()
        {
            return dice1 + dice2 + dice3 + dice4 + dice5;
        }

        //this function is used to determine if the user has a straight
        //it puts the dice in an array, sorts the array, and then counts the number of dice that are in order
        private int NumberOfSequentialDice()
        {
            int counter = 0;
            int[] array = { dice1, dice2, dice3, dice4, dice5 };
            Array.Sort(array);
            for(int i = 0; i < 4; i++)
            {
                if(array[i] == array[i] + 1)
                {
                    counter++;
                }
            }

            return counter;
        }

        //this function determines if the user can apply the role to the challenge chosen
        //returns true if so, false if not
        //Note: some code may seem redunant with the UpdateScore() function, but I believe it makes more sense to have the two functions be completely separate
        public bool IsChallengeValid(String challenge)
        {
            if (challenge.Equals("Aces"))
            {
                if(CountNumber(1) >= 1)
                {
                    return true;
                }
            }
            else if (challenge.Equals("Twos"))
            {
                if (CountNumber(2) >= 1)
                {
                    return true;
                }
            }
            else if (challenge.Equals("Threes"))
            {
                if (CountNumber(3) >= 1)
                {
                    return true;
                }
            }
            else if (challenge.Equals("Fours"))
            {
                if (CountNumber(4) >= 1)
                {
                    return true;
                }
            }
            else if (challenge.Equals("Fives"))
            {
                if (CountNumber(5) >= 1)
                {
                    return true;
                }
            }
            else if (challenge.Equals("Sixes"))
            {
                if (CountNumber(6) >= 1)
                {
                    return true;
                }
            }
            else if (challenge.Equals("Three of a Kind"))
            {
                if (IsThereAmountOfSameDice(3))
                {
                    return true;
                }
            }
            else if (challenge.Equals("Four of a Kind"))
            {
                if (IsThereAmountOfSameDice(4))
                {
                    return true;
                }
            }
            else if (challenge.Equals("Full House"))
            {
                if (IsFullHouse())
                {
                    return true;
                }
            }
            else if (challenge.Equals("Small Straight"))
            {
                if (NumberOfSequentialDice() >= 4)
                {
                    return true;
                }
            }
            else if (challenge.Equals("Large Straight"))
            {
                if (NumberOfSequentialDice() == 5)
                {
                    return true;
                }
            }
            else if (challenge.Equals("Yahtzee"))
            {
                if (IsThereAmountOfSameDice(5))
                {
                    return true;
                }
            }
            else if (challenge.Equals("Chance"))
            {
                return true;
            }

            return false;
        }
    }
}
