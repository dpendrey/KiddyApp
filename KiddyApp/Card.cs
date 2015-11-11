using System;
using System.Collections.Generic;
using System.Text;

namespace KiddyApp
{
    public abstract class Card
    {
        public const float DifficultyStandard = 1,
            DifficultyBitHigh = 1.2f,
            DifficultyModerate = 1.5f,
            DifficultyHard = 2,
            DifficulySomewhatEasy=0.8f,
            DifficultyEasy = 0.5f;
        public abstract string Text { get; }

        public abstract System.Drawing.Image Image { get; }

        public abstract string[] Groups { get; }

        public abstract string[] MainColours { get; }

        public abstract float DifficultyModifier { get; }


        static List<Card> cards = new List<Card>();

        internal static void loadCards()
        {
            cards.Clear();

            cards.Add(new Cards.Source0.Book());
            cards.Add(new Cards.Source0.Question());


            cards.Add(new Cards.Source1.Apple());
            cards.Add(new Cards.Source1.Butterfly());
            cards.Add(new Cards.Source1.Cat());
            cards.Add(new Cards.Source1.Doll());
            cards.Add(new Cards.Source1.Egg());
            cards.Add(new Cards.Source1.Flower());
            cards.Add(new Cards.Source1.Goat());
            cards.Add(new Cards.Source1.Heart());
            cards.Add(new Cards.Source1.Ice_Cream());
            cards.Add(new Cards.Source1.Jar());
            cards.Add(new Cards.Source1.Kite());
            cards.Add(new Cards.Source1.Ladybug());
            cards.Add(new Cards.Source1.Moon());
            cards.Add(new Cards.Source1.Nest());
            cards.Add(new Cards.Source1.Orange());
            cards.Add(new Cards.Source1.Pear());
            cards.Add(new Cards.Source1.Queen());
            cards.Add(new Cards.Source1.Rocket());
            cards.Add(new Cards.Source1.Sun());
            cards.Add(new Cards.Source1.Teddy());
            cards.Add(new Cards.Source1.Umbrella());
            cards.Add(new Cards.Source1.Violin());
            cards.Add(new Cards.Source1.Whale());
            cards.Add(new Cards.Source1.Xylophone());
            cards.Add(new Cards.Source1.Yacht());
            cards.Add(new Cards.Source1.Zebra());


            cards.Add(new Cards.Source2.Antelope());
            cards.Add(new Cards.Source2.Apple());
            cards.Add(new Cards.Source2.Barn());
            cards.Add(new Cards.Source2.Bird());
            cards.Add(new Cards.Source2.Camel());
            cards.Add(new Cards.Source2.Cow());
            cards.Add(new Cards.Source2.Dinosaur());
            cards.Add(new Cards.Source2.Duck());
            cards.Add(new Cards.Source2.Eggs());
            cards.Add(new Cards.Source2.Elephant());
            cards.Add(new Cards.Source2.Flamingo());
            cards.Add(new Cards.Source2.Giraffe());
            cards.Add(new Cards.Source2.Goats());
            cards.Add(new Cards.Source2.Horse());
            cards.Add(new Cards.Source2.House());
            cards.Add(new Cards.Source2.Igloo());
            cards.Add(new Cards.Source2.Insect());
            cards.Add(new Cards.Source2.Jacket());
            cards.Add(new Cards.Source2.JesterHat());
            cards.Add(new Cards.Source2.Kite());
            cards.Add(new Cards.Source2.Kitten());
            cards.Add(new Cards.Source2.Lamb());
            cards.Add(new Cards.Source2.Lion());
            cards.Add(new Cards.Source2.Monkey());
            cards.Add(new Cards.Source2.Moose());
            cards.Add(new Cards.Source2.Notes());
            cards.Add(new Cards.Source2.Numbers());
            cards.Add(new Cards.Source2.Octopus());
            cards.Add(new Cards.Source2.Owls());
            cards.Add(new Cards.Source2.Paint());
            cards.Add(new Cards.Source2.Pumpkin());
            cards.Add(new Cards.Source2.Rocket());
            cards.Add(new Cards.Source2.RockingHorse());
            cards.Add(new Cards.Source2.Snake());
            cards.Add(new Cards.Source2.Stars());
            cards.Add(new Cards.Source2.Tree());
            cards.Add(new Cards.Source2.Turtle());
            cards.Add(new Cards.Source2.Umbrella());
            cards.Add(new Cards.Source2.Unicorn());
            cards.Add(new Cards.Source2.Violin());
            cards.Add(new Cards.Source2.Volcano());
            cards.Add(new Cards.Source2.Watermellon());
            cards.Add(new Cards.Source2.Whale());
            cards.Add(new Cards.Source2.XRay());
            cards.Add(new Cards.Source2.Xylophone());
            cards.Add(new Cards.Source2.Yarn());
            cards.Add(new Cards.Source2.YoYo());
            cards.Add(new Cards.Source2.Zebra());
            cards.Add(new Cards.Source2.Zipper());
        }

        public static List<Card> GetCardsInGroup(string Group)
        {
            List<Card> retVal = new List<Card>();

            foreach (Card c in cards)
                for (int i = 0; i < c.Groups.Length; i++)
                    if (c.Groups[i].ToUpper() == Group.ToUpper())
                        retVal.Add(c);

            return retVal;
        }

        public static List<Card> GetCardsInGroup(string[] Group)
        {
            List<Card> retVal = new List<Card>();

            foreach (Card c in cards)
                for (int i = 0; i < c.Groups.Length; i++)
                    for (int j = 0; j < Group.Length; j++)
                        if (c.Groups[i].ToUpper() == Group[j].ToUpper())
                            retVal.Add(c);

            return retVal;
        }

        public static Card GetCard(string Text)
        {
            Text=Text.ToUpper();
            foreach(Card c in cards)
                if (c.Text.ToUpper()==Text )
                    return c;
            return null;
        }

        public static Card[] GetRandom(int Count, Random Random,string[] Colour, string[] Group)
        {
            List<Card> working = new List<Card>(cards);
            Card[] retVal = new Card[Count];

            #region Cull based on group
            if (Group != null)
            {
                for (int x=0;x<Group.Length;x++)
                {
                if (Group[x].StartsWith("!"))
                {
                    Group[x] = Group[x].Substring(1);
                    for (int i = 0; i < working.Count; i++)
                    {
                        bool found = false;
                        for(int j=0;j<working[i].Groups.Length&&!found;j++)
                            if (working[i].Groups[j].ToUpper() == Group[x].ToUpper())
                            {
                                found = true;
                            }
                        if (found)
                        {
                            working.RemoveAt(i);
                            i--;
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < working.Count; i++)
                    {
                        bool found = false;
                        for (int j = 0; j < working[i].Groups.Length && !found; j++)
                            if (working[i].Groups[j].ToUpper() == Group[x].ToUpper())
                            {
                                found = true;
                            }
                        if (!found)
                        {
                            working.RemoveAt(i);
                            i--;
                        }
                    }
                }
                }
            }
            #endregion

            #region Pick out random cards
            for (int i = 0; i < Count; i++)
            {
                int curVal = Random.Next(working.Count);
                retVal[i] = working[curVal];
                working.RemoveAt(curVal);
            }
            #endregion

            return retVal;
        }

        public static Card[] GetRandom(int Count, Random Random)
        {
            List<Card> working = new List<Card>(cards);
            Card[] retVal = new Card[Count];

            #region Pick out random cards
            for (int i = 0; i < Count; i++)
            {
                int curVal = Random.Next(working.Count);
                retVal[i] = working[curVal];
                working.RemoveAt(curVal);
            }
            #endregion

            return retVal;
        }

        public static Card[] GetRandom(int Count, Random Random, string Colour, string Group)
        {
            List<Card> working = new List<Card>(cards);
            Card[] retVal = new Card[Count];

            #region Cull based on group
            if (Group != null)
            {
                if (Group.StartsWith("!"))
                {
                    Group = Group.Substring(1);
                    for (int i = 0; i < working.Count; i++)
                    {
                        bool found = false;
                        for(int j=0;j<working[i].Groups.Length&&!found;j++)
                            if (working[i].Groups[j].ToUpper() == Group.ToUpper())
                            {
                                found = true;
                            }
                        if (found)
                        {
                            working.RemoveAt(i);
                            i--;
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < working.Count; i++)
                    {
                        bool found = false;
                        for (int j = 0; j < working[i].Groups.Length && !found; j++)
                            if (working[i].Groups[j].ToUpper() == Group.ToUpper())
                            {
                                found = true;
                            }
                        if (!found)
                        {
                            working.RemoveAt(i);
                            i--;
                        }
                    }
                }
            }
            #endregion

            #region Pick out random cards
            for (int i = 0; i < Count; i++)
            {
                int curVal = Random.Next(working.Count);
                retVal[i] = working[curVal];
                working.RemoveAt(curVal);
            }
            #endregion

            return retVal;
        }

        public static string[] GetColours()
        {
            List<string> retVal = new List<string>();

            for (int i = 0; i < cards.Count; i++)
            {
                foreach (string col in cards[i].MainColours)
                {
                    if (!retVal.Contains(col))
                        retVal.Add(col);
                }
            }

            return retVal.ToArray();
        }

        public static Card[] GetCardsInColour(string Colour)
        {
            List<Card> retVal = new List<Card>();

            foreach (Card c in cards)
            {
                foreach(string col in c.MainColours)
                    if (col.ToUpper() == Colour.ToUpper())
                    {
                        retVal.Add(c);
                        break;
                    }
            }

            return retVal.ToArray();
        }

        public static Card[] GetCardsNotInColour(string Colour)
        {
            List<Card> retVal = new List<Card>();

            foreach (Card c in cards)
            {
                bool found = false;
                foreach (string col in c.MainColours)
                    if (col.ToUpper() == Colour.ToUpper())
                    {
                        found = true;
                        break;
                    }
                if (!found)
                    retVal.Add(c);
            }

            return retVal.ToArray();
        }
    }
}
