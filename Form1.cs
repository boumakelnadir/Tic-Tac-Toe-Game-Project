using System.Drawing;
using System.Windows.Forms;
using Tic_Tac_Toe_Game_Project.Properties;

namespace Tic_Tac_Toe_Game_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color White = Color.White;
            Pen pen = new Pen(White);
            pen.Width = 10;

            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            // Vertical Alignment Lines
            e.Graphics.DrawLine(pen, 600, 100, 600, 500);
            e.Graphics.DrawLine(pen, 750, 100, 750, 500);

            // Horizonta lAlignment Lines
            e.Graphics.DrawLine(pen, 450, 220, 900, 220);
            e.Graphics.DrawLine(pen, 450, 380, 900, 380);

        }

        stGameStatus GameStatus;
        enPlayer playerTurn = enPlayer.Player1;

        public enum enPlayer
        {
            Player1,
            Player2
        }

        public enum enWinner
        {
            Player1,
            Player2,
            Draw,
            GameInProgress
        }

        public struct stGameStatus
        {
            public enWinner Winner;
            public bool GameOver;
            public short PlayCount;
        }

        public void EndGame()
        {
            switch (GameStatus.Winner)
            {
                case enWinner.Player1:

                    lbl_winner.Text = "Player1";
                    break;

                case enWinner.Player2:

                    lbl_winner.Text = "Player2";
                    break;

                default:

                    lbl_winner.Text = "Draw";
                    break;
            }

            MessageBox.Show("GameOver", "GameOver", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public bool GameValue(Button btn1, Button btn2, Button btn3)
        {
            if (btn1.Tag.ToString() != "?" && btn1.Tag.ToString() == btn2.Tag.ToString() && btn1.Tag.ToString() == btn3.Tag.ToString())
            {
                btn1.BackColor = Color.Green;
                btn2.BackColor = Color.Green;
                btn3.BackColor = Color.Green;

                if (btn1.Tag.ToString() == "X")
                {
                    GameStatus.Winner = enWinner.Player1;
                    GameStatus.GameOver = true;
                    EndGame();
                    return true;
                }
                else
                {
                    GameStatus.Winner = enWinner.Player2;
                    GameStatus.GameOver = true;
                    EndGame();
                    return true;
                }

            }
            GameStatus.GameOver = false;
            return false;
        }

        public void CheckWinner()
        {
            //horisontal
            if (GameValue(button1, button2, button3))
            {
                return;
            }

            if (GameValue(button4, button5, button6))
            {
                return;
            }

            if (GameValue(button7, button8, button9))
            {
                return;
            }

            //vertical

            if (GameValue(button1, button4, button7))
            {
                return;
            }

            if (GameValue(button2, button5, button8))
            {
                return;
            }

            if (GameValue(button3, button6, button9))
            {
                return;
            }

            //diagonal

            if (GameValue(button1, button5, button9))
            {
                return;
            }

            if (GameValue(button3, button5, button7))
            {
                return;
            }

        }

        public void ChangeImage(Button btn)
        {
            if (btn.Tag.ToString() == "?")
            {
                switch (playerTurn)
                {
                    case enPlayer.Player1:

                        btn.Image = Resources.X;
                        lbl_Player_turn.Text = "Player2";
                        playerTurn = enPlayer.Player2;
                        btn.Tag = "X";
                        GameStatus.PlayCount++;
                        GameStatus.Winner = enWinner.GameInProgress;
                        CheckWinner();
                        break;

                    case enPlayer.Player2:

                        btn.Image = Resources.O;
                        lbl_Player_turn.Text = "Player1";
                        playerTurn = enPlayer.Player1;
                        btn.Tag = "O";
                        GameStatus.PlayCount++;
                        GameStatus.Winner = enWinner.GameInProgress;
                        CheckWinner();
                        break;
                }

            }
            else
            {
                MessageBox.Show("Wrong Choice", "Wrong Choice", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (GameStatus.PlayCount == 9)
            {
                lbl_Player_turn.Text = "GameOver";
                GameStatus.Winner = enWinner.Draw;
                GameStatus.GameOver = true;
            }

        }

        public void ResetGame(Button btn)
        {
            btn.Tag = "?";
            btn.Image = Resources.question_mark_96;
            btn.BackColor = Color.Transparent;
        }

        public void RestartGame()
        {
            ResetGame(button1);
            ResetGame(button2);
            ResetGame(button3);
            ResetGame(button4);
            ResetGame(button5);
            ResetGame(button6);
            ResetGame(button7);
            ResetGame(button8);
            ResetGame(button9);

            GameStatus.Winner = enWinner.GameInProgress;
            GameStatus.GameOver = false;
            GameStatus.PlayCount = 0;
            playerTurn = enPlayer.Player1;
            lbl_Player_turn.Text = "Player1";
            lbl_winner.Text = "In Progress";

        }



        private void button1_Click(object sender, System.EventArgs e)
        {
            ChangeImage(button1);
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            ChangeImage(button2);
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            ChangeImage(button3);
        }

        private void button4_Click(object sender, System.EventArgs e)
        {
            ChangeImage(button4);
        }

        private void button5_Click(object sender, System.EventArgs e)
        {
            ChangeImage(button5);
        }

        private void button6_Click(object sender, System.EventArgs e)
        {
            ChangeImage(button6);
        }

        private void button7_Click(object sender, System.EventArgs e)
        {
            ChangeImage(button7);
        }

        private void button8_Click(object sender, System.EventArgs e)
        {
            ChangeImage(button8);
        }

        private void button9_Click(object sender, System.EventArgs e)
        {
            ChangeImage(button9);
        }

        private void btn_restart_game_Click(object sender, System.EventArgs e)
        {
            RestartGame();
        }
    }
}
