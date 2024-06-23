using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Security.Cryptography;
using System.CodeDom;
using System.Xml.Schema;
using System.Linq.Expressions;
using System.Diagnostics; // Ensure you use System.Timers, not System.Threading

namespace RCP_Game
{
    public partial class Form1 : Form
    {
        private int animationStep;

        public Form1()
        {
            InitializeComponent();
            Main_Menu_Panel.BringToFront();
        }

        #region Game Main Functions

        string Player1_name = "Player 1 ";
        string Player2_name = "Player 2 Or Computer";

        enum enChoice
        {
            Rock = 1,
            Paper = 2,
            Scissors = 3,
            NAN = 4
        }

        enChoice Player1_Choice;
        enChoice Player2_Choice;
        private string WinningCases()
        {

            if ((Player1_Choice == enChoice.Rock && Player2_Choice == enChoice.Scissors) || (Player1_Choice == enChoice.Paper && Player2_Choice == enChoice.Rock) || (Player1_Choice == enChoice.Scissors && Player2_Choice == enChoice.Paper))
            {
                return Player1_name + " Win";
            }
            else if (Player1_Choice == Player2_Choice)
            {
                return "Draw";
            }

            return Player2_name + "Win";
        }

        private void AnnoceWinner()
        {
            MessageBox.Show(WinningCases(), "Result");
            Result_Label.Text = WinningCases();
            PlayerVSPlayer_Result_label.Text = WinningCases();
        }


        private void GameModeButton_VC_Click(object sender, EventArgs e)
        {
            Player2_name = "Computer";
            VSComputer_Panel.BringToFront();
        }    
        

        private void ReturnFunc()
        {
            
            Main_Menu_Panel.BringToFront();
            ClearAll();
        }

        private void ClearAll()
        {
            // Reset Names and Choices : 
            Player1_name = "Player1";
            Player2_name = "Player2";
            Player1_Choice = enChoice.NAN;
            Player2_Choice = enChoice.NAN;
            // Reset Picture Boxes and labels : 
                // 1vs1 Gamemode :
            player_1_PB.Image = Properties.Resources.rock_paper_scissors;
            player2_PB.Image = Properties.Resources.rock_paper_scissors;
            player_1_Choice_Label.Text = Player1_name + " Choice";
            player_2_Choice_label.Text = Player2_name + " Choice";
                // Player vs Computer GameMode :
            User_Choice_PB.Image = Properties.Resources.rock_paper_scissors;
            Computer_Choice_PB.Image = Properties.Resources.rock_paper_scissors;
            UserChoice_Label.Text = "Player Choice";
            Computer_Choice_Label.Text = "Computer Choice";
            // Clear Results Labels :
            Result_Label.Text = "";
            PlayerVSPlayer_Result_label.Text = "";
        }

       

        #endregion 

        #region Player vs Computer Gamemode Functions

        static Random random = new Random();


        private void Rock_Choice_button_Click(object sender, EventArgs e)
        {
            User_Choice_PB.Image = Properties.Resources._006_asteroid;
            Player1_Choice = enChoice.Rock;
            UserChoice_Label.Text = Player1_Choice.ToString();
        }

        private void Paper_Choice_Button_Click(object sender, EventArgs e)
        {
            User_Choice_PB.Image = Properties.Resources._005_scroll;
            Player1_Choice = enChoice.Paper;
            UserChoice_Label.Text = Player1_Choice.ToString();
        }

        private void Scissors_Choice_Button_Click(object sender, EventArgs e)
        {
            User_Choice_PB.Image = Properties.Resources._001_scissor;
            Player1_Choice = enChoice.Scissors;
            UserChoice_Label.Text = Player1_Choice.ToString();
        }

        private void start_Button_Click(object sender, EventArgs e)
        {
            if (User_Choice_PB.Image == Properties.Resources.rock_paper_scissors)
            {
                MessageBox.Show("Please Enter your Choice To start The Game..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.None);
                return;
            }
            Player2_Choice = (enChoice)random.Next(1, 4);
            Computer_Choice_Label.Text = Player2_Choice.ToString();
            ChangeImage(Computer_Choice_PB, Player2_Choice);
            AnnoceWinner();
            
        }

        private void ChangeImage(PictureBox sender, enChoice Choice)
        {
            switch (Choice)
            {
                case enChoice.Rock:
                    sender.Image = Properties.Resources._006_asteroid;
                    break;
                case enChoice.Paper:
                    sender.Image = Properties.Resources._005_scroll;
                    break;
                case enChoice.Scissors:
                    sender.Image = Properties.Resources._001_scissor;
                    break;
            }
        }


        private void Return_Button_Click(object sender, EventArgs e)
        {
            ReturnFunc();
        }

        #endregion

        #region Gamemode Player vs Player Code

        private void Initialize1vs1()
        {
            Player1_name = "player 1";
            Player2_name = "player 2";
            // Creat a {palyer name} Form as Soon To Read The Players Names
        }

        private void GameModeButton_1VS1_Click(object sender, EventArgs e)
        {
            PlayerVSPlayer_Panel.BringToFront();
        }

        private void P1_Rock_Button_Choice_Click(object sender, EventArgs e)
        {
            Player1_Choice = enChoice.Rock;
            ChangeImageByChoice(1, player_1_PB);
            ChangePlayer1_Choice_Label();
        }

        private void P1_Paper_Button_Choice_Click(object sender, EventArgs e)
        {
            Player1_Choice = enChoice.Paper;
            ChangeImageByChoice(1, player_1_PB);
            ChangePlayer1_Choice_Label();
        }

        private void P1_Scissors_Button_Choice_Click(object sender, EventArgs e)
        {
            Player1_Choice = enChoice.Scissors;
            ChangeImageByChoice(1, player_1_PB);
            ChangePlayer1_Choice_Label();
        }

        private void P2_Rock_Player_Button_Choice_Click(object sender, EventArgs e)
        {
            Player2_Choice = enChoice.Rock;
            ChangeImageByChoice(2, player2_PB);
            ChangePlayer2_Choice_Label();
        }

        private void P2_Paper_Button_Choice_Click(object sender, EventArgs e)
        {
            Player2_Choice = enChoice.Paper;
            ChangeImageByChoice(2, player2_PB);
            ChangePlayer2_Choice_Label();
        }

        private void P2_Scissors_Button_Choice_Click(object sender, EventArgs e)
        {
            Player2_Choice = enChoice.Scissors;
            ChangeImageByChoice(2, player2_PB);
            ChangePlayer2_Choice_Label();
        }

        private void ChangePlayer1_Choice_Label()
        {
            player_1_Choice_Label.Text = Player1_Choice.ToString();
        }

        private void ChangePlayer2_Choice_Label()
        {
            player_2_Choice_label.Text = Player2_Choice.ToString();
        }


        private void P1_Hide_Choice_Click(object sender, EventArgs e)
        {
            HidePB();
        }

        private void HidePB()
        {
            player_1_PB.Image = Properties.Resources.rock_paper_scissors;
            player2_PB.Image = Properties.Resources.rock_paper_scissors;
            player_1_Choice_Label.Text = "XXXXXXXX";
            player_2_Choice_label.Text = "XXXXXXXX";
        }

        private void ChangeImageByChoice(int player_Num, PictureBox Player_PictureBox) // player 1 = 1; palyer 2 = 2 ; => int player_num;
        {
            if (player_Num == 1)
            {
                switch (Player1_Choice)
                {
                    case enChoice.Rock:
                        player_1_PB.Image = Properties.Resources._006_asteroid;
                        break;
                    case enChoice.Paper:
                        player_1_PB.Image = Properties.Resources._005_scroll;
                        break;
                    case enChoice.Scissors:
                        player_1_PB.Image = Properties.Resources._001_scissor;
                        break;
                }
            }
            else if (player_Num == 2)
            {
                switch (Player2_Choice)
                {
                    case enChoice.Rock:
                        player2_PB.Image = Properties.Resources._006_asteroid;
                        break;
                    case enChoice.Paper:
                        player2_PB.Image = Properties.Resources._005_scroll;
                        break;
                    case enChoice.Scissors:
                        player2_PB.Image = Properties.Resources._001_scissor;
                        break;  
                }
            }
            else
            {
                Console.WriteLine("Error : indefined Player Number !! just 1 or 2 (Its a Dual Game !!!)");
            }
        }
        private void P2_Hide_Choise_Click(object sender, EventArgs e)
        {
            HidePB();
        }


        private void Return_Button_2_Click(object sender, EventArgs e)
        {
            ReturnFunc();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChangeImageByChoice(1, player_1_PB);
            ChangeImageByChoice(2, player2_PB);
            ChangePlayer1_Choice_Label();
            ChangePlayer2_Choice_Label();
            AnnoceWinner();
        }

        #endregion


    }
}
