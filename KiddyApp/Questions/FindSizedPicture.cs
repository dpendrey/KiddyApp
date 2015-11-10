using System;
using System.Collections.Generic;
using System.Text;

namespace KiddyApp.Questions
{
    public class FindSizedPicture:Question
    {
        private static string[] bigPhrases = new string[]
        {
            "Find the big {0}",
            "Where is the big {0}",
            "Big {0} is hiding",
            "Find the huge {0}",
            "Where is the huge {0}",
            "Huge {0} is hiding",
            "Find the giant {0}",
            "Where is the giant {0}",
            "Giant {0} is hiding",
        };
        private static string[] smallPhrases = new string[]
        {
            "Find the small {0}",
            "Where is the small {0}",
            "Small {0} is hiding",
            "Find the little {0}",
            "Where is the little {0}",
            "Little {0} is hiding",
            "Find the tiny {0}",
            "Where is the tiny {0}",
            "Tiny {0} is hiding"
        };

        public FindSizedPicture(Random Random)
        {
            double[] scales;

            // Generate list of cards and scales
            List<Card> tmpList = new List<Card>(Card.GetRandom(3, Random));
            tmpList.Add(tmpList[0]);
            tmpList.Add(tmpList[1]);
            tmpList.Add(tmpList[2]);
            List<double> tmpScales = new List<double>();
            tmpScales.Add(1);
            tmpScales.Add(1);
            tmpScales.Add(1);
            tmpScales.Add(0.5f);
            tmpScales.Add(0.5f);
            tmpScales.Add(0.5f);
            scales = new double[6];

            // Randomly shuffle into display items
            List<Card> finalCards = new List<Card>();
            while (tmpList.Count > 0)
            {
                int index = Random.Next(tmpList.Count);
                scales[finalCards.Count] = tmpScales[index];
                finalCards.Add(tmpList[index]);

                tmpScales.RemoveAt(index);
                tmpList.RemoveAt(index);
            }

            cards = new DisplayCard[6];
            for (int i = 0; i < finalCards.Count; i++)
                cards[i] = new DisplayCard(finalCards[i], scales[i]);

            // Determine answer and compile the prompt
            AnswerCards = new int[] { Random.Next(cards.Length) };

            if (scales[AnswerCards[0]]>0.75)
                prompt = string.Format(bigPhrases[Random.Next(bigPhrases.Length)], cards[AnswerCards[0]].Card.Text);
            else
                prompt = string.Format(smallPhrases[Random.Next(smallPhrases.Length)], cards[AnswerCards[0]].Card.Text);
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
