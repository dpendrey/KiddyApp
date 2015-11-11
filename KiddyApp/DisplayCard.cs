﻿using System;
using System.Collections.Generic;
using System.Text;

namespace KiddyApp
{
    public class DisplayCard
    {
        public Card Card;
        public float Scale;
        public int X, Y;

        public DisplayCard(Card Card)
        {
            this.Card = Card;
            this.Scale = 1;
        }

        public DisplayCard(Card Card, float Scale)
        {
            this.Card = Card;
            this.Scale = Scale;
        }
    }
}
