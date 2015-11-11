using System;
using System.Collections.Generic;
using System.Text;

namespace KiddyApp.Questions
{
    public class FindFromGroup:Question
    {
        class FindFromGroupSubject
        {
            public FindFromGroupSubject(string Group, string Prompt)
            {
                this.Group = Group;
                this.Prompt = Prompt;
            }
            public string Group;
            public string Prompt;
        }
        private static FindFromGroupSubject[] groups = new FindFromGroupSubject[] { 
            new FindFromGroupSubject("Animal","Find the animal"),
            new FindFromGroupSubject("Toy","Find a toy"),
            new FindFromGroupSubject("Ocean","Find something from the ocean"),
            new FindFromGroupSubject("Food", "Find some food"),
            new FindFromGroupSubject("Fruit", "Find some fruit"),
            new FindFromGroupSubject("Kitchen", "Find something from the kitchen"),
            new FindFromGroupSubject("Farm","Find something from the farm"),
            new FindFromGroupSubject("Plant","Find a plant")
        };

        public FindFromGroup(Random Random)
        {
            subject = groups[Random.Next(groups.Length)];
            Card[] tmp = Card.GetRandom(6, Random, null, "!"+subject.Group);
            cards = new DisplayCard[tmp.Length];
            for (int i = 0; i < tmp.Length; i++)
                cards[i] = new DisplayCard(tmp[i]);
            AnswerCards = new int[] { Random.Next(cards.Length) };
            cards[AnswerCards[0]] =new DisplayCard( Card.GetRandom(1, Random, null, subject.Group)[0]);
            prompt = subject.Prompt;
        }

        FindFromGroupSubject subject;

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
