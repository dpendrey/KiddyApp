using System;
using System.Collections.Generic;
using System.Text;

namespace KiddyApp.PageProviders
{
    public class MainMenu : PageProvider
    {
        private Page curPage = null;
        private PageProvider newProvider = null;

        public MainMenu()
        {
            curPage = new Page();
            curPage.Rows = new PageRow[2];

            curPage.Rows[0] = new PageRowText("What do you want to do?");

            curPage.Rows[1] = new PageRowCards(
                new Card[]
                {
                    new Cards.Source0.Book(),
                    new Cards.Source0.Question()
                });
        }

        public override string Name
        {
            get { return "Menu"; }
        }

        public override Page CurrentPage
        {
            get { return curPage ; }
        }

        public override PageProvider NextProvider
        {
            get { return newProvider; }
        }

        public override void PageClicked(Page Clicked)
        {
            if (Clicked.CardClicked.Card is Cards.Source0.Book)
            {
                curPage = null;
                newProvider=new Stories.FarmVisit(new Random());
            }
            if (Clicked.CardClicked.Card is Cards.Source0.Question)
            {
                curPage = null;
                newProvider = new Question();
            }
        }
    }
}