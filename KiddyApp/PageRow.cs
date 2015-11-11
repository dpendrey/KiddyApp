using System;
using System.Collections.Generic;
using System.Text;

namespace KiddyApp
{
    public abstract class PageRow
    {
        public abstract float RowHeight(System.Drawing.Graphics Graphics);
        public void DrawRow(System.Drawing.Graphics Graphics, float TopOffset, float Width)
        {
            drawnY = (int)TopOffset;
            drawnHeight = drawRow(Graphics, TopOffset, Width);
        }
        public DisplayCard Click(int X, int Y)
        {
            if (Y > drawnY && Y < drawnY + drawnHeight)
            {
                return click(X, Y - drawnY);
            }
            return null;
        }

        protected abstract int drawRow(System.Drawing.Graphics Graphics, float TopOffset, float Width);
        protected abstract DisplayCard click(int X, int Y);


        private int drawnY, drawnHeight;
    }

    public class PageRowText : PageRow
    {
        public string Text;
        public System.Drawing.Font Font = new System.Drawing.Font("Times New Roman", 24, System.Drawing.FontStyle.Bold);
        public System.Drawing.Brush Brush = System.Drawing.Brushes.Black;
        public PageRowText(string Text) { this.Text = Text; }

        public override float RowHeight(System.Drawing.Graphics Graphics)
        {
            return Graphics.MeasureString(Text, Font).Height;
        }

        protected override int drawRow(System.Drawing.Graphics Graphics, float TopOffset, float Width)
        {
            System.Drawing.SizeF textSize = Graphics.MeasureString(Text, Font);
            Graphics.DrawString(Text, Font, Brush, (Width - textSize.Width) / 2, TopOffset);
            return (int)textSize.Height;
        }

        protected override DisplayCard click(int X, int Y)
        {
            return null;
        }
    }

    public class PageRowCards : PageRow
    {
        public DisplayCard[] DisplayCards;
        public PageRowCards(Card[] DisplayCards)
        {
            this.DisplayCards = new DisplayCard[DisplayCards.Length];
            for (int i = 0; i < DisplayCards.Length; i++)
                this.DisplayCards[i] = new DisplayCard(DisplayCards[i]);
        }
        public PageRowCards(DisplayCard[] DisplayCards) { this.DisplayCards = DisplayCards; }

        public override float RowHeight(System.Drawing.Graphics Graphics)
        {
            float curHeight = 0;
            for (int i = 0; i < DisplayCards.Length; i++)
                if (curHeight < DisplayCards[i].Card.Image.Height)
                    curHeight = DisplayCards[i].Card.Image.Height;
            return curHeight;
        }

        protected override int drawRow(System.Drawing.Graphics Graphics, float TopOffset, float Width)
        {
            float totalWidth = 0;
            for (int i = 0; i < DisplayCards.Length; i++)
                totalWidth += DisplayCards[i].Card.Image.Width;
            float curX, rowHeight;

            curX = (Width - totalWidth) / 2;
            rowHeight = RowHeight(Graphics);

            for (int i = 0; i < DisplayCards.Length; i++)
            {
                DisplayCards[i].X = (int)curX;
                DisplayCards[i].Y=(int)( ((rowHeight - DisplayCards[i].Card.Image.Height) / 2));
                Graphics.DrawImageUnscaled(DisplayCards[i].Card.Image, DisplayCards[i].X,(int)TopOffset+ DisplayCards[i].Y);
                curX += DisplayCards[i].Card.Image.Width;
            }

            return (int)rowHeight;
        }

        protected override DisplayCard click(int X, int Y)
        {
            for (int i = 0; i < DisplayCards.Length; i++)
                if (X > DisplayCards[i].X && X < DisplayCards[i].X + DisplayCards[i].Card.Image.Width)
                    return DisplayCards[i];
            return null;
        }
    }
}