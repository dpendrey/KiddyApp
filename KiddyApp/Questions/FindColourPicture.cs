using System;
using System.Collections.Generic;
using System.Text;

namespace KiddyApp.Questions
{
    /*
    public class FindColourPicture : Question
    {
        private static string[] phrases = new string[]
        {
            "Find something {0}",
            "Where is something {0}"
        };

        public FindColourPicture(Random Random)
        {
            Card answe = Card.GetRandom(1, Random, null, null)[0];
            Card[] tmp = Card.GetRandom(6, Random, null, null);
            cards = new DisplayCard[tmp.Length];
            for (int i = 0; i < tmp.Length; i++)
                cards[i] = new DisplayCard(tmp[i]);
            AnswerCards = new int[] { Random.Next(cards.Length) };
            cards[AnswerCards[0]] = new DisplayCard(answe);
            prompt = string.Format(phrases[Random.Next(phrases.Length)], cards[AnswerCards[0]].Card.MainColours[0]);
        }

        string prompt;

        DisplayCard[] cards;

        public override DisplayCard[] Cards
        {
            get { return cards; }
        }

        public override string Prompt
        {
            get { return prompt; }
        }

        public override string[] TextButtons
        {
            get { return new string[0]; }
        }

        public override double MaxAge
        {
            get { return 0; }
        }

        public override double MinAge
        {
            get { return 0; }
        }

        public override double GetAgeMatrix(double Age, Difficulty Difficulty)
        {
            return 0;
        }
    }
    */
}