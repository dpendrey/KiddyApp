using System;
using System.Collections.Generic;
using System.Text;

namespace KiddyApp.PageProviders
{
    public class Question : PageProvider
    {
        KiddyApp.Question curQuestion;
        Random rand = new Random();
        Page curPage;

        public Question()
        {
            curQuestion = new Questions.FindPictureFromWord(rand);

            curPage = new Page();
            curPage.Rows = new PageRow[3];
            curPage.Rows[0] = new PageRowText(curQuestion.Prompt);
            curPage.Rows[1] = new PageRowCards(new DisplayCard[] { curQuestion.Cards[0], curQuestion.Cards[1], curQuestion.Cards[2] });
            curPage.Rows[2] = new PageRowCards(new DisplayCard[] { curQuestion.Cards[3], curQuestion.Cards[4], curQuestion.Cards[5] });
        }

        public override string Name
        {
            get { return "Questions"; }
        }

        public override PageProvider NextProvider
        {
            get { return null; }
        }

        public override Page CurrentPage
        {
            get { return curPage; }
        }

        public override void PageClicked(Page Clicked)
        {
            // If this is in response to an answer page
            if (Clicked.Background == System.Drawing.Color.Green ||
                Clicked.Background == System.Drawing.Color.Red)
            {
                // Get new question
                curQuestion = KiddyApp.Question.GetNext(rand);

                // Populate new page for it
                curPage = new Page();
                curPage.Rows = new PageRow[3];
                curPage.Rows[0] = new PageRowText(curQuestion.Prompt);
                curPage.Rows[1] = new PageRowCards(new DisplayCard[] { curQuestion.Cards[0], curQuestion.Cards[1], curQuestion.Cards[2] });
                curPage.Rows[2] = new PageRowCards(new DisplayCard[] { curQuestion.Cards[3], curQuestion.Cards[4], curQuestion.Cards[5] });
            }
            // Else this is an answer to a question
            else
            {
                if (Clicked.CardClicked == curQuestion.Cards[curQuestion.AnswerCards[0]])
                {
                    // Update players score
                    Kiddy.CurrentPlayer.CurrentLevel += 2 * curQuestion.GetFinishedDifficulty();
                    // Get new page
                    curPage = Page.CorrectPage(curQuestion.Cards[curQuestion.AnswerCards[0]]);
                }
                else
                {
                    // Update players score
                    Kiddy.CurrentPlayer.CurrentLevel -= 4 * curQuestion.GetFinishedDifficulty();
                    // Get new page
                    curPage = Page.IncorrectPage(curQuestion.Cards[curQuestion.AnswerCards[0]]);
                }
                if (Kiddy.CurrentPlayer.CurrentLevel < 0)
                    Kiddy.CurrentPlayer.CurrentLevel = 0;
                if (Kiddy.CurrentPlayer.CurrentLevel > 20)
                    Kiddy.CurrentPlayer.CurrentLevel = 20;
            }
        }
    }
}