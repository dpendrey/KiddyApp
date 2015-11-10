﻿using System;
using System.Collections.Generic;
using System.Text;

namespace KiddyApp
{
    public class Page
    {
        public PageRow[] Rows;
        public Card CorrectAnswer = null;
        public Card Selected = null;
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