using System;
using System.Collections.Generic;
using System.Text;

namespace KiddyApp
{
    public class Page
    {
        public static Page CorrectPage(DisplayCard Answer)
        {
            return CorrectPage(Answer.Card);
        }
        public static Page CorrectPage(Card Answer)
        {
                Page p = new Page();
                p.Background = System.Drawing.Color.Green;
                p.Rows = new PageRow[2];
                p.Rows[0] = new PageRowText("Correct!");
                p.Rows[1]=new PageRowCards(new Card[]{Answer});

                p.SoundToPlay = new System.Media.SoundPlayer(Audio.Audio.ShootingStar);

                return p;
        }
        public static Page IncorrectPage(DisplayCard Answer)
        {
            return IncorrectPage(Answer.Card);
        }
        public static Page IncorrectPage(Card Answer)
        {
            Page p = new Page();
            p.Background = System.Drawing.Color.Red;
            p.Rows = new PageRow[2];
            p.Rows[0] = new PageRowText("Sorry");
            p.Rows[1] = new PageRowCards(new Card[] { Answer });

            p.SoundToPlay = new System.Media.SoundPlayer(Audio.Audio.Error);

            return p;
        }

        public PageRow[] Rows;

        public int RowClicked;
        public int XClicked, YClicked;
        public DisplayCard CardClicked;

        public System.Drawing.Color Background = System.Drawing.Color.White;
        public System.Media.SoundPlayer SoundToPlay = null;

        public float PageHeight(System.Drawing.Graphics Graphics)
        {
            float tmp = 0;
            for (int i = 0; i < Rows.Length; i++)
                tmp += Rows[i].RowHeight(Graphics);
            return tmp;
        }
    }
}