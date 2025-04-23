using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace memorygameapp
{
    public partial class MemoryGame : Form
    {
        List<Button> lstbtn;
        List<string> emojis;
        List<Button> FlippedCards = new();
        List<string> FlippedEmoji = new();
        Random rnd = new Random();
        int player1score = 0;
        int player2score = 0;
        bool ischeckingmatch = false;
        int matchedPairs = 0; 
        enum TurnEnum { Player1 = 1, player2 = 2 };
        TurnEnum CurrentTurn = TurnEnum.Player1;

        public MemoryGame()
        {
            InitializeComponent();
            btnStart.Click += BtnStart_Click;
            InitializeButtonsList();
            InitializeEmojiList();
            EnableDisableCards(false);
        }

        private void InitializeButtonsList()
        {
            lstbtn = new() { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9, btn10, btn11, btn12, btn13, btn14, btn15, btn16, btn17, btn18, btn19, btn20 };
            foreach (Button btn in lstbtn)
            {
                btn.Click += Card_Click;
            }
            SetButtonBackFace();
        }

        private void InitializeEmojiList()
        {
            emojis = new()
            {
                "🐶", "🐶",
                "🐱", "🐱",
                "🐰", "🐰",
                "🐵", "🐵",
                "🦊", "🦊",
                "🐼", "🐼",
                "🐯", "🐯",
                "🐸", "🐸",
                "🐷", "🐷",
                "🦁", "🦁"
            };
            emojis = emojis.OrderBy(i => rnd.Next()).ToList();
        }

        private void SetButtonBackFace()
        {
            foreach (Button btn in lstbtn)
            {
                btn.Text = "u";
                btn.Font = new Font("Wingdings", 70);
            }
        }

        private void ShowEmoji(Button btn, int index)
        {
            btn.Text = emojis[index];
            btn.Font = new Font("Segoe UI Emoji", 60);
        }

        private void EnableDisableCards(bool enable = false)
        {
            foreach (Button btn in lstbtn)
            {
                btn.Enabled = enable;
            }
        }

        private void FlipCard(object sender, EventArgs e)
        {
            if (ischeckingmatch) return;
            Button clickedButton = sender as Button;

            if (clickedButton == null || FlippedCards.Contains(clickedButton))
                return;

            int index = lstbtn.IndexOf(clickedButton);

            clickedButton.Font = new Font("Segoe UI Emoji", 60);
            clickedButton.Text = emojis[index];

            FlippedCards.Add(clickedButton);
            FlippedEmoji.Add(emojis[index]);

            CheckForMatch();
        }

        private void SwitchTurn()
        {
            txtCurrentTurn.BackColor = Color.Orange;
            if (CurrentTurn == TurnEnum.Player1)
            {
                CurrentTurn = TurnEnum.player2;
            }
            else
            {
                CurrentTurn = TurnEnum.Player1;
            }
            txtCurrentTurn.Text = "It's " + CurrentTurn + "'s turn!";
        }

        private void CheckForMatch()
        {
            if (FlippedCards.Count == 2)
            {
                ischeckingmatch = true;

                if (FlippedEmoji[0] == FlippedEmoji[1])
                {
                    matchedPairs++; 
                    FlippedCards.Clear();
                    FlippedEmoji.Clear();
                    UpdateScore();
                    SwitchTurn();
                    DetectWinner();
                    ischeckingmatch = false;
                }
                else
                {
                    Task.Delay(800).ContinueWith(_ =>
                    {
                        Invoke((Action)(() =>
                        {
                            foreach (Button b in FlippedCards)
                            {
                                b.Font = new Font("Wingdings", 70);
                                b.Text = "u";
                            }
                            FlippedCards.Clear();
                            FlippedEmoji.Clear();
                            SwitchTurn();
                            ischeckingmatch = false;
                        }));
                    });
                }
            }
        }

        private void DetectWinner()
        {
            if (matchedPairs == 10) 
            {
                if (player1score > player2score)
                {
                    txtCurrentTurn.Text = "PLAYER 1 WON!!";
                }
                else if (player2score > player1score)
                {
                    txtCurrentTurn.Text = "PLAYER 2 WON!!";
                }
                else
                {
                    txtCurrentTurn.Text = "TIE!!";
                }
                EnableDisableCards(false);
            }
        }

        private void UpdateScore()
        {
            if (CurrentTurn == TurnEnum.Player1)
            {
                player1score++;
                txtPlayer1Score.Text = player1score.ToString();
            }
            else
            {
                player2score++;
                txtPlayer2Score.Text = player2score.ToString();
            }
        }

        private void RestartGame()
        {
            player1score = 0;
            player2score = 0;
            matchedPairs = 0; 

            txtPlayer1Score.Text = "0";
            txtPlayer2Score.Text = "0";

            CurrentTurn = TurnEnum.Player1;
            txtCurrentTurn.Text = "It's " + CurrentTurn + "'s turn!";
            txtCurrentTurn.BackColor = Color.Orange;

            FlippedCards.Clear();
            FlippedEmoji.Clear();

            InitializeEmojiList();
            SetButtonBackFace();
            EnableDisableCards(true);
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            btnStart.Text = "Restart";
            btnStart.BackColor = Color.HotPink;

            RestartGame();
        }

        private void Card_Click(object sender, EventArgs e)
        {
            FlipCard(sender, e);
        }
    }
}