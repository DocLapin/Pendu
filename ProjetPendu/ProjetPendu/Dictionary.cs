using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pendu
{
    /// <summary>
    /// Represents the dictionary which manage words
    /// </summary>
    public class Dictionary
    {
        #region Fields and Properties

        private List<Word> _words;

        /// <summary>
        /// Words of the dictionary
        /// </summary>
        public List<Word> Words
        {
            get { return _words; }
            set { _words = value; }
        }

        #endregion

        /// <summary>
        /// Construct a Dictionary which contains words
        /// </summary>
        /// <param name="words">Words contained by the dictionary</param>
        public Dictionary(List<Word> words)
        {
            if (words.Count() == 0)
            {
                throw new ArgumentException("Must have at least one word");
            }
            else
            {
                _words = words;
            }
        }
        
        /// <summary>
        /// Select a word wich correspond to the specified minimal length and maximal length
        /// </summary>
        /// <param name="minLength">Minimal length of the word</param>
        /// <param name="maxLength">Maximal length of the word</param>
        /// <returns>A randomly selected word which correspond to the specified minimal length and maximal length.
        /// Null if no words correspond to the specified minimal length and maximal length. 
        /// </returns>
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
                List<Word> wordsWithCorrectSize = GetWordsWithCorrectSize(minLength, maxLength);
                int nbOfWords = wordsWithCorrectSize.Count();
                if (nbOfWords == 0)
                {
                    return null;
                }
                else
                {
                    int rndIndex = GetRandomNumber(nbOfWords);
                    return (Word)wordsWithCorrectSize[rndIndex];
                }
            }
        }

        /// <summary>
        /// Remove a word
        /// </summary>
        /// <param name="word">word to remove</param>
        public void Remove(Word word)
        {
            _words.Remove(word);
        }

        /// <summary>
        /// Select words wich correspond to the specified minimal length and maximal length
        /// </summary>
        /// <returns>All words wich correspond to the specified minimal length and maximal length</returns>
        private List<Word> GetWordsWithCorrectSize(int minLength, int maxLength)
        {
            List<Word> wordsWithCorrectSize = new List<Word>();
            foreach (Word word in _words)
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

    }
}
