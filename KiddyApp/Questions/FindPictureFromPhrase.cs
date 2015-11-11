using System;
using System.Collections.Generic;
using System.Text;

namespace KiddyApp.Questions
{
    public class FindPictureFromPhrase:Question
    {
        private static string[] phrases = new string[]
        {
            "Find the {0}",
            "Where is the {0}",
            "{0} is hiding"
        };

        public FindPictureFromPhrase(Random Random)
        {
            Card[] tmp = Card.GetRandom(6, Random);
            cards = new DisplayCard[tmp.Length];
            for (int i = 0; i < tmp.Length; i++)
                cards[i] = new DisplayCard(tmp[i]);
            AnswerCards = new int[] { Random.Next(cards.Length) };
            prompt = string.Format(phrases[Random.Next(phrases.Length)], cards[AnswerCards[0]].Card.Text);
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

        public override float MaxAge
        {
            get { return 7; }
        }

        public override float MinAge
        {
            get { return 4; }
        }

        public override float GetDifficulty(float Age)
        {
            if (Age < 4)
                return Card.DifficultyModerate;
            if (Age < 4.57)
                return Card.DifficultyStandard;
            if (Age < 5.5)
                return Card.DifficulySomewhatEasy;

            return Card.DifficultyEasy;
        }
    }
}
