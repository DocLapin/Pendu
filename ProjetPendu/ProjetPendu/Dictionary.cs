using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pendu
{
    public class Dictionary
    {
        private List<Word> _words;
       

        public List<Word> Words
        {
            get { return _words; }
            private set { _words = value; }
        }

        /// <summary>
        /// Construct a Dictionary which contain words
        /// </summary>
        /// <param name="words">Words contained by Dictionary</param>
        public Dictionary(List<Word> words)
        {
            if (words.Count() == 0)
            {
                throw new ArgumentException("Must have at least one word");
            }
            else
            {
                Words = words;
            }
        }

        /// <summary>
        /// Select a word in the dictionary
        /// </summary>
        /// <returns>A word</returns>
        public Word SelectAWord()
        {
            return GetWord();
        }
        
        /// <summary>
        /// Select a word wich correspond to the specified minimal length and maximal length
        /// </summary>
        /// <param name="minLength">Minimal length of the word</param>
        /// <param name="maxLength">Maximal length of the word</param>
        /// <returns>A word which correspond to the specified minimal length and maximal length</returns>
        public Word SelectAWord(int minLength, int maxLength)
        {
            if ((minLength <= 0) || (maxLength <= 0))
            {
                throw new ArgumentOutOfRangeException("params must be > 0");
            }
            else if (maxLength < minLength)
            {
                throw new ArgumentOutOfRangeException("maxLength must be >= minLength");
            }
            else
            {
                return GetWord(minLength, maxLength);
            }
        }

        /// <summary>
        /// Select a word randomly
        /// </summary>
        /// <returns>A randomly selected word</returns>
        private Word GetWord()
        {
            Word w;
            if (Words.Count == 0)
            {
                return null;
            }
            else
            {

                int rndIndex = GetRandomNumber(Words.Count);
                w = Words[rndIndex];
                Words.Remove(w);
                return (Word)w;
            }
            
        }

        /// <summary>
        /// Select a word randomly wich correspond to the specified minimal length and maximal length
        /// </summary>
        /// <returns>A randomly selected word wich correspond to the specified minimal length and maximal length. 
        /// Null if no words correspond to the specified minimal length and maximal length. 
        /// </returns>
        private Word GetWord(int minLength, int maxLength)
        {
            List<Word> wordsWithCorrectSize = GetWordsWithCorrectSize(minLength, maxLength);
            int nbOfWords = wordsWithCorrectSize.Count();
            if (nbOfWords == 0)
            {
                return null;
            }
            else
            {
                int rndIndex = GetRandomNumber(nbOfWords);
                return (Word) wordsWithCorrectSize[rndIndex];
            }
        }

        /// <summary>
        /// Select words wich correspond to the specified minimal length and maximal length
        /// </summary>
        /// <returns>All words wich correspond to the specified minimal length and maximal length</returns>
        private List<Word> GetWordsWithCorrectSize(int minLength, int maxLength)
        {
            List<Word> wordsWithCorrectSize = new List<Word>();
            foreach (Word word in Words)
            {
                if (word.GotCorrectSize(minLength, maxLength))
                {
                    wordsWithCorrectSize.Add(word);
                } 
                // no else
            }
            return wordsWithCorrectSize;
        }

        /// <summary>
        /// Get a random number include in [0, maxValue]
        /// </summary>
        /// <param name="maxValue">Maximal value for the random number</param>
        /// <returns>A random number include in [0, maxValue]</returns>
        private int GetRandomNumber(int maxValue)
        {
            if (maxValue <= 0)
            {
                throw new ArgumentOutOfRangeException("maxValue must be > 0");
            }
            else
            {
                Random rnd = new Random();
                int rndNumber = rnd.Next(maxValue);
                return rndNumber;
            }
        }

        internal void setWords(List<Word> list)
        {
            Words = list;
        }
    }
}
