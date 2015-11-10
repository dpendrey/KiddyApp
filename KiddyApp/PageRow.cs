using System;
using System.Collections.Generic;
using System.Text;

namespace KiddyApp
{
    public abstract class PageRow
    {
        public abstract float RowHeight(System.Drawing.Graphics Graphics);
        public abstract void DrawRow(System.Drawing.Graphics Graphics, float TopOffset, float Width);
    }

    public class PageRowText : PageRow
    {
        public string Text;
        public System.Drawing.Font Font = new System.Drawing.Font("Times New Roman", 24, System.Drawing.FontStyle.Bold);
        public PageRowText(string Text) { this.Text = Text; }

        public override float RowHeight(System.Drawing.Graphics Graphics)
        {
            return Graphics.MeasureString(Text, Font).Height;
        }

        public override void DrawRow(System.Drawing.Graphics Graphics, float TopOffset, float Width)
        {

        }
    }

    public class PageRowCards : PageRow
    {
        public Card[] Cards;
        public PageRowCards(Card[] Cards) { this.Cards = Cards; }

        public override float RowHeight(System.Drawing.Graphics Graphics)
        {
            float curHeight = 0;
            for (int i = 0; i < Cards.Length; i++)
                if (curHeight < Cards[i].Image.Height)
                    curHeight = Cards[i].Image.Height;
            return curHeight;
        }

        public override void DrawRow(System.Drawing.Graphics Graphics, float TopOffset, float Width)
        {
        }
    }
}