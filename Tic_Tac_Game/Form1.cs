using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using Tic_Tac_Game.Properties;

namespace Tic_Tac_Game
{
    public partial class Form1 : Form
    {
        enPlayer PlayerTurn = enPlayer.Player_1;
        stGameStatus GameStatus;
        enum enPlayer
        {
            Player_1,
            Player_2
        }

        enum enWinner
        {
            Player_1,
            Player_2,
            Draw,
            GameInProgress
        }

        struct stGameStatus
        {
            public enWinner Winner;
            public bool GameOver;
            public short PlayCount;
        }

        public void EndGame()
        {
            lblTurn.Text = "Game Over";
            switch(GameStatus.Winner)
            {
                case enWinner.Player_1:
                    lblWinner.Text = "Player 1";
                    break;

                case enWinner.Player_2:
                    lblWinner.Text = "Player 2";
                    break;

                default:
                    lblWinner.Text = "Draw";
                    break;
            }

            MessageBox.Show("GameOver", "GameOver", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public bool CheckValues(Button Btn1,Button Btn2,Button Btn3)
        {
            if(Btn1.Tag.ToString() != "?" && Btn1.Tag.ToString() == Btn2.Tag.ToString() && Btn2.Tag.ToString() == Btn3.Tag.ToString())
            {
                Btn1.BackColor = Color.GreenYellow;
                Btn2.BackColor = Color.GreenYellow;
                Btn3.BackColor = Color.GreenYellow;

                if(Btn1.Tag.ToString() == "X")
                {
                    GameStatus.Winner = enWinner.Player_1;
                    GameStatus.GameOver = true;
                    EndGame();
                    panel1.Enabled = false;
                    return true;
                }
                else
                {
                    GameStatus.Winner = enWinner.Player_2;
                    GameStatus.GameOver = true;
                    EndGame();
                    panel1.Enabled = false;
                    return true;
                }
            }

            GameStatus.GameOver = false;
            return false;
        }

        public void CheckWinner()
        {
            //checked rows
            //check Row1
            if (CheckValues(button1, button2, button3))
                return;

            //check Row2
            if (CheckValues(button4, button5, button6))
                return;

            //check Row3
            if (CheckValues(button7, button8, button9))
                return;

            //checked cols
            //check col1
            if (CheckValues(button1, button4, button7))
                return;

            //check col2
            if (CheckValues(button2, button5, button8))
                return;

            //check col3
            if (CheckValues(button3, button6, button9))
                return;

            //check Diagonal

            //check Diagonal1
            if (CheckValues(button1, button5, button9))
                return;

            //check Diagonal2
            if (CheckValues(button3, button5, button7))
                return;
        }

        private void ChangeImage(Button Btn)
        {
            if(Btn.Tag.ToString() == "?")
            {
                switch (PlayerTurn)
                {
                    case enPlayer.Player_1:
                        Btn.Image = Properties.Resources.X;
                        PlayerTurn = enPlayer.Player_2;
                        GameStatus.PlayCount++;
                        Btn.Tag = "X";
                        lblTurn.Text = "Player 2";
                        CheckWinner();
                        break;
                    case enPlayer.Player_2:
                        Btn.Image = Properties.Resources.O;
                        PlayerTurn = enPlayer.Player_1;
                        GameStatus.PlayCount++;
                        Btn.Tag = "O";
                        lblTurn.Text = "Player 1";
                        CheckWinner();
                        break;
                }
            }

            else
            {
                MessageBox.Show("Wrong Choice", "Worng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if(GameStatus.PlayCount == 9)
            {
                GameStatus.GameOver = true;
                GameStatus.Winner = enWinner.Draw;
                EndGame();
                panel1.Enabled = false;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            ChangeImage((Button) sender);
        }

        public void ResetImage(Button Btn)
        {
            Btn.BackColor = Color.Transparent;
            Btn.Image = Properties.Resources.question_mark_96;
            Btn.Tag = "?";
        }

        void ResetGame()
        {
            ResetImage(button1);
            ResetImage(button2);
            ResetImage(button3);
            ResetImage(button4);
            ResetImage(button5);
            ResetImage(button6);
            ResetImage(button7);
            ResetImage(button8);
            ResetImage(button9);

            panel1.Enabled = true;
            PlayerTurn = enPlayer.Player_1;
            GameStatus.GameOver = false;
            GameStatus.PlayCount = 0;
            lblTurn.Text = "Player 1";
            lblWinner.Text = "In Progress";
            GameStatus.Winner = enWinner.GameInProgress;
        }

        private void btnRestart_Game_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        //private void pictureBox1_Click(object sender, EventArgs e)
        //{
        //    if(!PictureClicked)
        //    {
        //        PictureClicked = true;
        //        putRandomCards(pictureBox_TopLeft);
        //    }
        //    else
        //    {
        //        showMessageIfPictureClick();
        //    }
        //}


    }
}
