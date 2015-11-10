using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KiddyApp
{
    public partial class CardsAndText : Form
    {
        Question question;
        List<int> answers = new List<int>();
        Random rand = new Random();
        Font font;
        Brush brush;
        int mouseDown = -1;
        Mode mode;
        System.Media.SoundPlayer correct, incorrect;

        public CardsAndText()
        {
            InitializeComponent();

            WindowState = FormWindowState.Maximized;

            Card.loadCards();


            question = new Questions.FindPictureFromWord(rand);
            mode = Mode.Guessing;
            font = new Font(Font.FontFamily.Name, 24, FontStyle.Bold);
            brush = new SolidBrush(Color.Black);
            correct = new System.Media.SoundPlayer(Audio.Audio.ShootingStar);
            incorrect = new System.Media.SoundPlayer(Audio.Audio.Error);
        }

        #region Update display
        private void CardsAndText_Paint(object sender, PaintEventArgs e)
        {
            switch (mode)
            {
                #region Kiddy is guessing which card to click on
                case Mode.Guessing:
                    // Clear the screen to white
                    e.Graphics.Clear(Color.White);

                    #region Determine where to draw each card
                    switch (question.Cards.Length)
                    {
                        case 6:
                            #region Position 6 cards
                            question.Cards[0].X = (int)(Width / 2 - question.Cards[1].Scale * question.Cards[1].Card.Image.Width / 2 - 50 - question.Cards[0].Scale * question.Cards[0].Card.Image.Width);
                            question.Cards[0].Y = (int)(50 + (400 / 2) - question.Cards[0].Scale * question.Cards[0].Card.Image.Height / 2);

                            question.Cards[1].X = (int)(Width / 2 - question.Cards[1].Scale * question.Cards[1].Card.Image.Width / 2);
                            question.Cards[1].Y = (int)(50 + (400 / 2) - question.Cards[1].Scale * question.Cards[1].Card.Image.Height / 2);

                            question.Cards[2].X = (int)(Width / 2 + question.Cards[1].Scale * question.Cards[1].Card.Image.Width / 2 + 50);
                            question.Cards[2].Y = (int)(50 + (400 / 2) - question.Cards[2].Scale * question.Cards[2].Card.Image.Height / 2);

                            question.Cards[3].X = (int)(Width / 2 - question.Cards[4].Scale * question.Cards[4].Card.Image.Width / 2 - 50 - question.Cards[3].Scale * question.Cards[3].Card.Image.Width);
                            question.Cards[3].Y = (int)(450 + (300 / 2) - question.Cards[3].Scale * question.Cards[3].Card.Image.Height / 2);

                            question.Cards[4].X = (int)(Width / 2 - question.Cards[4].Scale * question.Cards[4].Card.Image.Width / 2);
                            question.Cards[4].Y = (int)(450 + (300 / 2) - question.Cards[4].Scale * question.Cards[4].Card.Image.Height / 2);

                            question.Cards[5].X = (int)(Width / 2 + question.Cards[4].Scale * question.Cards[4].Card.Image.Width / 2 + 50);
                            question.Cards[5].Y = (int)(450 + (300 / 2) - question.Cards[5].Scale * question.Cards[5].Card.Image.Height / 2);
                            #endregion
                            break;
                        default:
                            MessageBox.Show("I don't know how to draw that many cards!");
                            break;
                    }
                    #endregion

                    #region Draw each of the cards
                    Text = "";
                    for (int i = 0; i < question.Cards.Length; i++)
                        e.Graphics.DrawImage(question.Cards[i].Card.Image, question.Cards[i].X, question.Cards[i].Y,
                            (float)(question.Cards[i].Card.Image.Width * question.Cards[i].Scale),
                            (float)(question.Cards[i].Card.Image.Height * question.Cards[i].Scale));

                    SizeF size = e.Graphics.MeasureString(question.Prompt, font);
                    e.Graphics.DrawString(question.Prompt, font, brush, (Width - size.Width) / 2, 20);
                    #endregion
                    break;
                #endregion
                #region Guess was correct
                case Mode.Correct:
                    e.Graphics.Clear(Color.Green);
                    break;
                #endregion
                #region Guess was incorrect
                case Mode.Incorrect:
                    e.Graphics.Clear(Color.Red);
                    break;
                #endregion
                #region I have no idea how we got here
                default:
                    e.Graphics.Clear(Color.White);
                    break;
                #endregion
            }
        }
        #endregion

        #region Mouse down
        private void CardsAndText_MouseDown(object sender, MouseEventArgs e)
        {
            switch (mode)
            {
                case Mode.Guessing:
                    // Determine if the click landed within a card, if so save which one
                    mouseDown = -1;
                    for (int i = 0; i < question.Cards.Length; i++)
                        if (e.X > question.Cards[i].X && e.X < question.Cards[i].X + question.Cards[i].Card.Image.Width &&
                            e.Y > question.Cards[i].Y && e.Y < question.Cards[i].Y + question.Cards[i].Card.Image.Height)
                            mouseDown = i;
                    break;
                    // Don't care where it was
                case Mode.Correct:
                case Mode.Incorrect:
                default:
                    break;
            }
        }
        #endregion

        #region Mouse up
        private void CardsAndText_MouseUp(object sender, MouseEventArgs e)
        {
            switch (mode)
            {
                #region While guessing
                case Mode.Guessing:
                    // Determine which card was clicked in
                    for (int i = 0; i < question.Cards.Length; i++)
                        if (e.X > question.Cards[i].X && e.X < question.Cards[i].X + question.Cards[i].Card.Image.Width &&
                            e.Y > question.Cards[i].Y && e.Y < question.Cards[i].Y + question.Cards[i].Card.Image.Height)
                            // Make sure it is the same as when the mouse went down
                            if (mouseDown == i)
                            {
                                // If the correct answer
                                if (i == question.AnswerCards[0])
                                {
                                    // Guess was correct
                                    mode = Mode.Correct;
                                    // Play sound effect
                                    correct.Play();
                                    // Update players score
                                    Kiddy.CurrentPlayer.CurrentLevel += 2*question.GetFinishedDifficulty();
                                }
                                else
                                {
                                    // Guess was incorrect
                                    mode = Mode.Incorrect;
                                    // Play sound effect
                                    incorrect.Play();
                                    // Update players score
                                    Kiddy.CurrentPlayer.CurrentLevel -= 4*question.GetFinishedDifficulty();
                                }
                                if (Kiddy.CurrentPlayer.CurrentLevel < 0)
                                    Kiddy.CurrentPlayer.CurrentLevel = 0;
                                if (Kiddy.CurrentPlayer.CurrentLevel > 20)
                                    Kiddy.CurrentPlayer.CurrentLevel = 20;
                                // Redraw the whole screen
                                Text = Kiddy.CurrentPlayer.CurrentLevel.ToString();
                                Invalidate();
                            }
                    break;
                #endregion
                #region Correct/Incorrect screen
                case Mode.Correct:
                case Mode.Incorrect:
                default:
                    // Move to next question
                    question = Question.GetNext(rand);
                    mode = Mode.Guessing;
                    Invalidate();
                    break;
                #endregion
            }
        }
        #endregion
    }
}