using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Threading;

namespace LeranWords
{
    class Runner
    {
        private string selectedDict;
        private LearnWords.Direction selectedDirection;
        //static int countOfWords = 0;
        //ArrayList worsdAsArrayList = new ArrayList();
        KeyValuePair<string, string> currentPair;
        List<KeyValuePair<string, string>> Words = new List<KeyValuePair<string, string>>();
        int limitOfAmontOfWord = 3;

        public Runner(string selectedDict, LearnWords.Direction selectedDirection)
        {
            this.selectedDict = selectedDict;
            this.selectedDirection = selectedDirection;
        }

        public void Run()
        {
            Dictionary<string, string> words = DictionatyReader.GetWords(selectedDict);
            foreach (KeyValuePair<string, string> pair in words)
            {
                Words.Add(pair);
            }
            ShowWord();
        }

        private void ShowWord()
        {
            if (Words.Count == 0)
            {
                LearnWords.Finish();
            }
            else
            {
                Words.Shuffle();
                currentPair = (KeyValuePair<string, string>)Words[0];
                if (selectedDirection == LearnWords.Direction.PolRuss)
                    StartForPolRuss(currentPair);
                else
                    StartForRussPol(currentPair);
            }
        }

        private void StartForRussPol(KeyValuePair<string, string> pair)
        {
            PostWordToBeTranslate(pair.Value);
        }

        private void StartForPolRuss(KeyValuePair<string, string> pair)
        {
            PostWordToBeTranslate(pair.Key);
        }

        private void PostWordToBeTranslate(string word)
        {
            LearnWords.TextBoxForWordToBeTranslated.Invoke(new Action(() => LearnWords.TextBoxForWordToBeTranslated.Clear()));
            LearnWords.TextBoxForWordToBeTranslated.Invoke(new Action(() => LearnWords.TextBoxForWordToBeTranslated.AppendText(word)));
        }
        Queue failedWords = new Queue();
        bool wasFail = false;

        internal void CheckTranslation(string translation)
        {
            string expectedTranslation;
            if (selectedDirection == LearnWords.Direction.PolRuss)
                expectedTranslation = currentPair.Value.ToLower().Trim();
            else
                expectedTranslation = currentPair.Key.ToLower().Trim();

            if (wasFail)
            {
                CheckTranslationIfPreviousWasFailed(translation, expectedTranslation);
            }
            else
            {
                bool isTransaltedCorrecrly = translation.ToLower().Trim() == expectedTranslation.ToLower().Trim();
                if (isTransaltedCorrecrly)
                {
                    wasFail = false;
                    Words.Remove(currentPair);
                    LearnWords.TextBoxForTypedWord.Invoke(new Action(() => LearnWords.TextBoxForTypedWord.Clear()));
                    TypePairToLog();
                    ShowWord();
                }
                else
                {
                    wasFail = true;
                    AddPairAsItWasntTranslated(currentPair);
                    MessageBox.Show("Incorrect!!!\nShould be '" + expectedTranslation + "'");
                    LearnWords.TextBoxForTypedWord.Invoke(new Action(() => LearnWords.TextBoxForTypedWord.Clear()));
                }
            }
        }

        private void TypePairToLog()
        {

            if (!string.IsNullOrEmpty(LearnWords.TextBoxLogWithResults.Text))
                LearnWords.TextBoxLogWithResults.Invoke(new Action(() => LearnWords.TextBoxLogWithResults.AppendText("\n")));
            string knownPartOfWord = selectedDirection == LearnWords.Direction.RussPol ? currentPair.Value : currentPair.Key;
            if (GetAmountOfSuchPair(currentPair) > 0)
                LearnWords.TextBoxLogWithResults.Invoke(new Action(() => LearnWords.TextBoxLogWithResults.AppendText(knownPartOfWord + " - *****")));
            else
                LearnWords.TextBoxLogWithResults.Invoke(new Action(() => LearnWords.TextBoxLogWithResults.AppendText(currentPair.Key + " - " + currentPair.Value)));
        }
        private void AddPairAsItWasntTranslated(KeyValuePair<string, string> currentPair)
        {

            int currentAmount = GetAmountOfSuchPair(currentPair);
            if (currentAmount < limitOfAmontOfWord)
            {
                Words.Add(currentPair);
                currentAmount++;
            }
            if (currentAmount < limitOfAmontOfWord)
            {
                Words.Add(currentPair);
                currentAmount++;
            }
            if (currentAmount > limitOfAmontOfWord)
            {
            }
        }

        int GetAmountOfSuchPair(KeyValuePair<string, string> pair)
        {
            int amount = 0;
            foreach (KeyValuePair<string, string> pairInDict in Words)
            {
                if (pairInDict.Key == pair.Key)
                    amount++;
            }
            return amount;
        }

        private void CheckTranslationIfPreviousWasFailed(string translation, string expectedTranslation)
        {
            bool isTransaltedCorrecrly = translation.ToLower().Trim() == expectedTranslation.ToLower().Trim();
            if (isTransaltedCorrecrly)
            {
                wasFail = false;
                ShowWord();
                LearnWords.TextBoxForTypedWord.Invoke(new Action(() => LearnWords.TextBoxForTypedWord.Clear()));
            }
            else
            {
                MessageBox.Show("Incorrect!!!\nShould be '" + expectedTranslation + "'");
                LearnWords.TextBoxForTypedWord.Invoke(new Action(() => LearnWords.TextBoxForTypedWord.Clear()));
            }
        }
    }



    public static class ThreadSafeRandom
    {
        [ThreadStatic]
        private static Random Local;

        public static Random ThisThreadsRandom
        {
            get { return Local ?? (Local = new Random(unchecked(Environment.TickCount * 31 + Thread.CurrentThread.ManagedThreadId))); }
        }
    }

    static class MyExtensions
    {
        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = ThreadSafeRandom.ThisThreadsRandom.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}
