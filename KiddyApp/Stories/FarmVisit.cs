using System;
using System.Collections.Generic;
using System.Text;

namespace KiddyApp.Stories
{
    public class FarmVisit : PageProvider
    {
        private Page[] pages;
        int curPage = 0;
        public FarmVisit(Random Random)
        {
            Card tmpCard;
            pages = new Page[7];

            #region Page 1
            pages[0] = new Page();
            pages[0].Rows = new PageRow[2];
            pages[0].Rows[0] = new PageRowText("The Queen went to visit a farm");
            pages[0].Rows[1] = new PageRowCards(new Card[] { new Cards.Source1.Queen() });
            #endregion

            #region Page 2
            pages[1] = new Page();
            pages[1].Rows = new PageRow[4];
            pages[1].Rows[0] = new PageRowText("She saw some animals");
            pages[1].Rows[1] = new PageRowCards(Card.GetRandom(3, Random, null, new string[] { "Animal", "Farm" }));
            pages[1].Rows[2] = new PageRowText("They live in a barn");
            pages[1].Rows[3] = new PageRowCards(new Card[] { new Cards.Source2.Barn() });
            #endregion

            #region Page 3
            pages[2] = new Page();
            pages[2].Rows = new PageRow[4];
            pages[2].Rows[0] = new PageRowText("There were some ducks");
            pages[2].Rows[1] = new PageRowCards(new Card[] { new Cards.Source2.Duck() });
            pages[2].Rows[2] = new PageRowText("They laid eggs");
            pages[2].Rows[3] = new PageRowCards(new Card[] { new Cards.Source2.Eggs() });
            #endregion

            #region Page 4
            pages[3] = new Page();
            pages[3].Rows = new PageRow[2];
            pages[3].Rows[0] = new PageRowText("The Queens picked up the eggs");
            pages[3].Rows[1] = new PageRowCards(new Card[] { new Cards.Source1.Queen(), new Cards.Source2.Eggs() });
            #endregion

            #region Page 5
            tmpCard = ((PageRowCards)pages[1].Rows[1]).DisplayCards[Random.Next(3)].Card;
            pages[4] = new Page();
            pages[4].Rows = new PageRow[4];
            pages[4].Rows[0] = new PageRowText(tmpCard.Text+" scared the Queen");
            pages[4].Rows[1] = new PageRowCards(new Card[] { tmpCard, new Cards.Source1.Queen() });
            pages[4].Rows[2] = new PageRowText("She dropped an egg");
            pages[4].Rows[3] = new PageRowCards(new Card[] { new Cards.Source1.Egg() });
            #endregion

            #region Page 6
            pages[5] = new Page();
            pages[5].Rows = new PageRow[4];
            pages[5].Rows[0] = new PageRowText("Then the Queen played some music");
            pages[5].Rows[1] = new PageRowCards(new Card[] { new Cards.Source1.Queen(), new Cards.Source2.Notes() });
            pages[5].Rows[3] = new PageRowCards(Card.GetRandom(1, Random, null, new string[] { "Musical Instrument" }));

            pages[5].Rows[2] = new PageRowText("On a "+((PageRowCards)pages[5].Rows[3]).DisplayCards[0].Card.Text);
            #endregion

            #region Page 7
            pages[6] = new Page();
            pages[6].Rows = new PageRow[2];
            pages[6].Rows[0] = new PageRowText("It was a fun day");
            pages[6].Rows[1] = new PageRowCards(new Card[] { new Cards.Source2.JesterHat()});
            #endregion

            /*
            #region Page 3
            pages[2] = new Page();
            pages[2].Rows = new PageRow[4];
            pages[2].Rows[0] = new PageRowText("The queen wanted got to");
            pages[2].Rows[1] = new PageRowCards(new Card[]{new Cards.Source1.Queen()});
            pages[2].Rows[2] = new PageRowText("fly a kite!");
            pages[2].Rows[3] = new PageRowCards(new Card[] { new Cards.Source2.Kite() });
            #endregion
            */
        }

        public override string Name
        {
            get { return "Farm Visit Story"; }
        }

        public override Page CurrentPage
        {
            get
            {
                if (curPage >= pages.Length)
                    return null;
                return pages[curPage];
            }
        }

        public override PageProvider NextProvider
        {
            get
            {
                if (curPage >= pages.Length)
                    return new PageProviders.MainMenu();
                else
                    return null;
            }
        }

        public override void PageClicked(Page Clicked)
        {
            if (Clicked != null)
                curPage++;
        }
    }
}