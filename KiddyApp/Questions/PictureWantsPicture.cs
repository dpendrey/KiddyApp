using System;
using System.Collections.Generic;
using System.Text;

namespace KiddyApp.Questions
{
    public class PictureWantsPicture : Question
    {
        private static string[] phrases = new string[]
        {
            "{0} is looking for {1}",
            "{0} wants {1}",
            "{0} needs {1}"
            /*,
            "{1} belongs to {0}"
            "{1} is needed by {0}",
        */
        };

        public PictureWantsPicture(Random Random)
        {
            Card[] working = Card.GetRandom(6, Random);
            AnswerCards = new int[2];
            AnswerCards[1] = Random.Next(working.Length);
            AnswerCards[0] = Random.Next(working.Length);
            while (AnswerCards[0] == AnswerCards[1])
                AnswerCards[0] = Random.Next(working.Length);
            List<Card> sentient = Card.GetCardsInGroup(new string[] { "Animal", "Person" });
            working[AnswerCards[0]] = sentient[Random.Next(sentient.Count)];
            prompt = string.Format(phrases[Random.Next(phrases.Length)], working[AnswerCards[0]].Text, working[AnswerCards[1]].Text);
            AnswerOrderImportant = true;

            cards = new DisplayCard[working.Length];
            for (int i = 0; i < cards.Length; i++)
                cards[i] = new DisplayCard(working[i]); 
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
            get { return 7; }
        }

        public override double MinAge
        {
            get { return 4; }
        }

        public override double GetDifficulty(double Age)
        {
            if (Age < 4)
                return Card.DifficultyHard;
            if (Age < 4.57)
                return Card.DifficultyModerate;
            if (Age < 5.5)
                return Card.DifficultyStandard;
                
            return Card.DifficultyEasy;
        }
    }
}