using System;
using System.Collections.Generic;
using System.Text;

namespace KiddyApp
{
    public abstract class Story
    {
        public int CurrentPage = 0;
        public abstract Page[] Pages { get; }
    }

    public class Page
    {
        public PageRow[] Rows;
        public Card Answer = null;
    }

    #region Rows to show in a page
    public abstract class PageRow
    {
    }

    public class PageRowText : PageRow
    {
        public string Text;
        public PageRowText(string Text) { this.Text = Text; }
    }

    public class PageRowCards : PageRow
    {
        public Card[] Cards;
        public PageRowCards(Card[] Cards) { this.Cards = Cards; }
    }
    #endregion
}
