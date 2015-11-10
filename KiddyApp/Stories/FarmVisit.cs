using System;
using System.Collections.Generic;
using System.Text;

namespace KiddyApp.Stories
{
    public class FarmVisit : Story
    {
        private Page[] pages;
        public FarmVisit(Random Random)
        {
            pages = new Page[1];

            #region Page 1
            pages[0] = new Page();
            pages[0].CorrectAnswer = null;
            pages[0].Rows = new PageRow[2];
            pages[0].Rows[0] = new PageRowText("The Queen went to visit a farm");
            pages[0].Rows[1] = new PageRowCards(new Card[] { new Cards.Source1.Queen() });
            #endregion

            #region Page 2
            pages[1] = new Page();
            pages[1].CorrectAnswer = null;
            pages[1].Rows = new PageRow[4];
            pages[1].Rows[0] = new PageRowText("She saw some animals");
            pages[1].Rows[1] = new PageRowCards(Card.GetRandom(3, Random, null, new string[] { "Animal", "Farm" }));
            pages[1].Rows[2] = new PageRowText("They live in a barn");
            pages[1].Rows[3] = new PageRowCards(new Card[] { new Cards.Source2.Barn() });
            #endregion
        }

        public override Page GetCurrentPage()
        {
            return pages[CurrentPage];
        }

        public override void PageFinished(Page Page)
        {
            CurrentPage++;
        }
    }
}