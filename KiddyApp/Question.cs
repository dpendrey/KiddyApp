using System;
using System.Collections.Generic;
using System.Text;

namespace KiddyApp
{
    public abstract class Question
    {
        public abstract string Prompt { get; }
        public abstract DisplayCard[] Cards { get; }
        public abstract string[] TextButtons { get; }
        public int[] AnswerCards = new int[] { -1 };
        public bool AnswerOrderImportant = false;

        public abstract float MinAge { get; }
        public abstract float MaxAge { get; }
        public abstract float GetDifficulty(float Age);
        public float GetDifficulty() { return GetDifficulty(Kiddy.CurrentPlayer.Age); }
        public float GetFinishedDifficulty()
        {
            float retVal = GetDifficulty()*GetDifficulty();
            for (int i = 0; i < AnswerCards.Length; i++)
                retVal *= Cards[AnswerCards[i]].Card.DifficultyModifier;
            return retVal;
        }

        public static Question GetNext(Random Random)
        {
            Question[] qs = new Question[10];

            float aimFor =(float) (Kiddy.CurrentPlayer.CurrentLevel + Random.NextDouble() * 4 - 2) / 10;

            #region Find 10 random questions to go with next
            for (int i = 0; i < qs.Length; i++)
            {
                switch (Random.Next(4))
                {
                    case 1:
                        qs[i]= new Questions.FindPictureFromPhrase(Random);
                        break;
                    case 2:
                        qs[i] = new Questions.FindSizedPicture(Random);
                        break;
                    case 3:
                        qs[i] = new Questions.FindFromGroup(Random);
                        break;
                    case 0:
                    default:
                        qs[i] = new Questions.FindPictureFromWord(Random);
                        break;
                }
            }
            #endregion

            Question retVal = qs[0];
            #region Determine question closest to the level to aim for
                for (int i = 1; i < qs.Length; i++)
                    if (Math.Abs(aimFor - qs[i].GetFinishedDifficulty()) < Math.Abs(aimFor-retVal.GetFinishedDifficulty()))
                        retVal = qs[i];
            #endregion

            return retVal;
        }
    }
}