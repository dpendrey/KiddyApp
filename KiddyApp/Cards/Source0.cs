﻿using System;
using System.Collections.Generic;
using System.Text;

namespace KiddyApp.Cards.Source0
{
    public class Book : Card
    {
        public override string Text
        {
            get { return "Book"; }
        }

        public override float DifficultyModifier
        {
            get { return Card.DifficultyEasy; }
        }

        public override System.Drawing.Image Image
        {
            get { return new System.Drawing.Bitmap(Images.Source0._0_Book); }
        }

        public override string[] Groups
        {
            get { return new string[] {  }; }
        }

        public override string[] MainColours
        {
            get { return new string[] { "White","Brown" }; }
        }
    }
    public class Question : Card
    {
        public override string Text
        {
            get { return "Question"; }
        }

        public override float DifficultyModifier
        {
            get { return Card.DifficultyEasy; }
        }

        public override System.Drawing.Image Image
        {
            get { return new System.Drawing.Bitmap(Images.Source0._0_Question); }
        }

        public override string[] Groups
        {
            get { return new string[] { }; }
        }

        public override string[] MainColours
        {
            get { return new string[] { }; }
        }
    }
}
