
namespace DiceGame
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureSecondDie = new System.Windows.Forms.PictureBox();
            this.pictureFirstDie = new System.Windows.Forms.PictureBox();
            this.pictureThirdDie = new System.Windows.Forms.PictureBox();
            this.pictureFourthDie = new System.Windows.Forms.PictureBox();
            this.pictureFifthDie = new System.Windows.Forms.PictureBox();
            this.btnRollDice = new System.Windows.Forms.Button();
            this.radAces = new System.Windows.Forms.RadioButton();
            this.radSmallStraight = new System.Windows.Forms.RadioButton();
            this.radFullHouse = new System.Windows.Forms.RadioButton();
            this.radFourOfAKind = new System.Windows.Forms.RadioButton();
            this.radSixes = new System.Windows.Forms.RadioButton();
            this.radChance = new System.Windows.Forms.RadioButton();
            this.radYahtzee = new System.Windows.Forms.RadioButton();
            this.radLargeStraight = new System.Windows.Forms.RadioButton();
            this.radFours = new System.Windows.Forms.RadioButton();
            this.radThreeOfAKind = new System.Windows.Forms.RadioButton();
            this.radFives = new System.Windows.Forms.RadioButton();
            this.radThrees = new System.Windows.Forms.RadioButton();
            this.radTwos = new System.Windows.Forms.RadioButton();
            this.lblScore = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSecondDie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFirstDie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureThirdDie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFourthDie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFifthDie)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureSecondDie
            // 
            this.pictureSecondDie.Image = ((System.Drawing.Image)(resources.GetObject("pictureSecondDie.Image")));
            this.pictureSecondDie.Location = new System.Drawing.Point(285, 13);
            this.pictureSecondDie.Name = "pictureSecondDie";
            this.pictureSecondDie.Size = new System.Drawing.Size(113, 113);
            this.pictureSecondDie.TabIndex = 0;
            this.pictureSecondDie.TabStop = false;
            // 
            // pictureFirstDie
            // 
            this.pictureFirstDie.Image = ((System.Drawing.Image)(resources.GetObject("pictureFirstDie.Image")));
            this.pictureFirstDie.Location = new System.Drawing.Point(166, 13);
            this.pictureFirstDie.Name = "pictureFirstDie";
            this.pictureFirstDie.Size = new System.Drawing.Size(113, 113);
            this.pictureFirstDie.TabIndex = 1;
            this.pictureFirstDie.TabStop = false;
            // 
            // pictureThirdDie
            // 
            this.pictureThirdDie.Image = ((System.Drawing.Image)(resources.GetObject("pictureThirdDie.Image")));
            this.pictureThirdDie.Location = new System.Drawing.Point(404, 13);
            this.pictureThirdDie.Name = "pictureThirdDie";
            this.pictureThirdDie.Size = new System.Drawing.Size(113, 113);
            this.pictureThirdDie.TabIndex = 2;
            this.pictureThirdDie.TabStop = false;
            // 
            // pictureFourthDie
            // 
            this.pictureFourthDie.Image = ((System.Drawing.Image)(resources.GetObject("pictureFourthDie.Image")));
            this.pictureFourthDie.Location = new System.Drawing.Point(523, 13);
            this.pictureFourthDie.Name = "pictureFourthDie";
            this.pictureFourthDie.Size = new System.Drawing.Size(113, 113);
            this.pictureFourthDie.TabIndex = 3;
            this.pictureFourthDie.TabStop = false;
            // 
            // pictureFifthDie
            // 
            this.pictureFifthDie.Image = ((System.Drawing.Image)(resources.GetObject("pictureFifthDie.Image")));
            this.pictureFifthDie.Location = new System.Drawing.Point(642, 13);
            this.pictureFifthDie.Name = "pictureFifthDie";
            this.pictureFifthDie.Size = new System.Drawing.Size(113, 113);
            this.pictureFifthDie.TabIndex = 4;
            this.pictureFifthDie.TabStop = false;
            // 
            // btnRollDice
            // 
            this.btnRollDice.Location = new System.Drawing.Point(404, 173);
            this.btnRollDice.Name = "btnRollDice";
            this.btnRollDice.Size = new System.Drawing.Size(113, 23);
            this.btnRollDice.TabIndex = 5;
            this.btnRollDice.Text = "Roll Dice";
            this.btnRollDice.UseVisualStyleBackColor = true;
            this.btnRollDice.Click += new System.EventHandler(this.btnRollDice_Click);
            // 
            // radAces
            // 
            this.radAces.AutoSize = true;
            this.radAces.Location = new System.Drawing.Point(12, 13);
            this.radAces.Name = "radAces";
            this.radAces.Size = new System.Drawing.Size(60, 21);
            this.radAces.TabIndex = 6;
            this.radAces.TabStop = true;
            this.radAces.Text = "Aces";
            this.radAces.UseVisualStyleBackColor = true;
            // 
            // radSmallStraight
            // 
            this.radSmallStraight.AutoSize = true;
            this.radSmallStraight.Location = new System.Drawing.Point(12, 256);
            this.radSmallStraight.Name = "radSmallStraight";
            this.radSmallStraight.Size = new System.Drawing.Size(116, 21);
            this.radSmallStraight.TabIndex = 7;
            this.radSmallStraight.TabStop = true;
            this.radSmallStraight.Text = "Small Straight";
            this.radSmallStraight.UseVisualStyleBackColor = true;
            // 
            // radFullHouse
            // 
            this.radFullHouse.AutoSize = true;
            this.radFullHouse.Location = new System.Drawing.Point(12, 229);
            this.radFullHouse.Name = "radFullHouse";
            this.radFullHouse.Size = new System.Drawing.Size(96, 21);
            this.radFullHouse.TabIndex = 8;
            this.radFullHouse.TabStop = true;
            this.radFullHouse.Text = "Full House";
            this.radFullHouse.UseVisualStyleBackColor = true;
            // 
            // radFourOfAKind
            // 
            this.radFourOfAKind.AutoSize = true;
            this.radFourOfAKind.Location = new System.Drawing.Point(12, 202);
            this.radFourOfAKind.Name = "radFourOfAKind";
            this.radFourOfAKind.Size = new System.Drawing.Size(118, 21);
            this.radFourOfAKind.TabIndex = 9;
            this.radFourOfAKind.TabStop = true;
            this.radFourOfAKind.Text = "Four of a Kind";
            this.radFourOfAKind.UseVisualStyleBackColor = true;
            // 
            // radSixes
            // 
            this.radSixes.AutoSize = true;
            this.radSixes.Location = new System.Drawing.Point(12, 148);
            this.radSixes.Name = "radSixes";
            this.radSixes.Size = new System.Drawing.Size(62, 21);
            this.radSixes.TabIndex = 10;
            this.radSixes.TabStop = true;
            this.radSixes.Text = "Sixes";
            this.radSixes.UseVisualStyleBackColor = true;
            // 
            // radChance
            // 
            this.radChance.AutoSize = true;
            this.radChance.Location = new System.Drawing.Point(12, 337);
            this.radChance.Name = "radChance";
            this.radChance.Size = new System.Drawing.Size(77, 21);
            this.radChance.TabIndex = 11;
            this.radChance.TabStop = true;
            this.radChance.Text = "Chance";
            this.radChance.UseVisualStyleBackColor = true;
            // 
            // radYahtzee
            // 
            this.radYahtzee.AutoSize = true;
            this.radYahtzee.Location = new System.Drawing.Point(12, 310);
            this.radYahtzee.Name = "radYahtzee";
            this.radYahtzee.Size = new System.Drawing.Size(81, 21);
            this.radYahtzee.TabIndex = 12;
            this.radYahtzee.TabStop = true;
            this.radYahtzee.Text = "Yahtzee";
            this.radYahtzee.UseVisualStyleBackColor = true;
            // 
            // radLargeStraight
            // 
            this.radLargeStraight.AutoSize = true;
            this.radLargeStraight.Location = new System.Drawing.Point(12, 283);
            this.radLargeStraight.Name = "radLargeStraight";
            this.radLargeStraight.Size = new System.Drawing.Size(119, 21);
            this.radLargeStraight.TabIndex = 13;
            this.radLargeStraight.TabStop = true;
            this.radLargeStraight.Text = "Large Straight";
            this.radLargeStraight.UseVisualStyleBackColor = true;
            // 
            // radFours
            // 
            this.radFours.AutoSize = true;
            this.radFours.Location = new System.Drawing.Point(12, 94);
            this.radFours.Name = "radFours";
            this.radFours.Size = new System.Drawing.Size(65, 21);
            this.radFours.TabIndex = 14;
            this.radFours.TabStop = true;
            this.radFours.Text = "Fours";
            this.radFours.UseVisualStyleBackColor = true;
            // 
            // radThreeOfAKind
            // 
            this.radThreeOfAKind.AutoSize = true;
            this.radThreeOfAKind.Location = new System.Drawing.Point(12, 175);
            this.radThreeOfAKind.Name = "radThreeOfAKind";
            this.radThreeOfAKind.Size = new System.Drawing.Size(127, 21);
            this.radThreeOfAKind.TabIndex = 15;
            this.radThreeOfAKind.TabStop = true;
            this.radThreeOfAKind.Text = "Three of a Kind";
            this.radThreeOfAKind.UseVisualStyleBackColor = true;
            // 
            // radFives
            // 
            this.radFives.AutoSize = true;
            this.radFives.Location = new System.Drawing.Point(12, 121);
            this.radFives.Name = "radFives";
            this.radFives.Size = new System.Drawing.Size(62, 21);
            this.radFives.TabIndex = 16;
            this.radFives.TabStop = true;
            this.radFives.Text = "Fives";
            this.radFives.UseVisualStyleBackColor = true;
            // 
            // radThrees
            // 
            this.radThrees.AutoSize = true;
            this.radThrees.Location = new System.Drawing.Point(12, 67);
            this.radThrees.Name = "radThrees";
            this.radThrees.Size = new System.Drawing.Size(74, 21);
            this.radThrees.TabIndex = 17;
            this.radThrees.TabStop = true;
            this.radThrees.Text = "Threes";
            this.radThrees.UseVisualStyleBackColor = true;
            // 
            // radTwos
            // 
            this.radTwos.AutoSize = true;
            this.radTwos.Location = new System.Drawing.Point(12, 40);
            this.radTwos.Name = "radTwos";
            this.radTwos.Size = new System.Drawing.Size(62, 21);
            this.radTwos.TabIndex = 18;
            this.radTwos.TabStop = true;
            this.radTwos.Text = "Twos";
            this.radTwos.UseVisualStyleBackColor = true;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(164, 149);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(61, 17);
            this.lblScore.TabIndex = 19;
            this.lblScore.Text = "Score: 0";
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(405, 337);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(113, 23);
            this.btnQuit.TabIndex = 20;
            this.btnQuit.Text = "Quit Game";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(643, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Display Rules";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.radTwos);
            this.Controls.Add(this.radThrees);
            this.Controls.Add(this.radFives);
            this.Controls.Add(this.radThreeOfAKind);
            this.Controls.Add(this.radFours);
            this.Controls.Add(this.radLargeStraight);
            this.Controls.Add(this.radYahtzee);
            this.Controls.Add(this.radChance);
            this.Controls.Add(this.radSixes);
            this.Controls.Add(this.radFourOfAKind);
            this.Controls.Add(this.radFullHouse);
            this.Controls.Add(this.radSmallStraight);
            this.Controls.Add(this.radAces);
            this.Controls.Add(this.btnRollDice);
            this.Controls.Add(this.pictureFifthDie);
            this.Controls.Add(this.pictureFourthDie);
            this.Controls.Add(this.pictureThirdDie);
            this.Controls.Add(this.pictureFirstDie);
            this.Controls.Add(this.pictureSecondDie);
            this.Name = "Form1";
            this.Text = "Dice Game - Frank Gatto";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureSecondDie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFirstDie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureThirdDie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFourthDie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFifthDie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureSecondDie;
        private System.Windows.Forms.PictureBox pictureFirstDie;
        private System.Windows.Forms.PictureBox pictureThirdDie;
        private System.Windows.Forms.PictureBox pictureFourthDie;
        private System.Windows.Forms.PictureBox pictureFifthDie;
        private System.Windows.Forms.Button btnRollDice;
        private System.Windows.Forms.RadioButton radAces;
        private System.Windows.Forms.RadioButton radSmallStraight;
        private System.Windows.Forms.RadioButton radFullHouse;
        private System.Windows.Forms.RadioButton radFourOfAKind;
        private System.Windows.Forms.RadioButton radSixes;
        private System.Windows.Forms.RadioButton radChance;
        private System.Windows.Forms.RadioButton radYahtzee;
        private System.Windows.Forms.RadioButton radLargeStraight;
        private System.Windows.Forms.RadioButton radFours;
        private System.Windows.Forms.RadioButton radThreeOfAKind;
        private System.Windows.Forms.RadioButton radFives;
        private System.Windows.Forms.RadioButton radThrees;
        private System.Windows.Forms.RadioButton radTwos;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button button1;
    }
}

