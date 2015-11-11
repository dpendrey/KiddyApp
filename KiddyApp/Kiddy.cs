using System;
using System.Collections.Generic;
using System.Text;

namespace KiddyApp
{
    public class Kiddy
    {
        public string Name = "Celeste";
        public float Age = 5;
        public Difficulty Difficulty = Difficulty.Standard;
        public float CurrentLevel = 10;


        public static Kiddy CurrentPlayer = new Kiddy();
    }
}
