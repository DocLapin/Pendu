using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pendu
{
    public class Word
    {
        private string _wordString;

        public string WordString
        {
            get { return _wordString; }
            private set { _wordString = value; }
        }

        /// <summary>
        /// Construct a word from a string
        /// </summary>
        /// <param name="word">The word</param>
        public Word(string word)
        {
            if (String.IsNullOrWhiteSpace(word))
            {
                throw new ArgumentOutOfRangeException("Word length must not null and not white");
            }
            else
            {
                WordString = word;
            }
        }

        /// <summary>
        /// Indicate if a word got the correct size agaisnt specified params
        /// </summary>
        /// <param name="minLength">Minimal word length</param>
        /// <param name="maxLength">Maximal word length</param>
        /// <returns>True if the word got the correct size against specified params, false otherwise</returns>
        public bool GotCorrectSize(int minLength, int maxLength)
        {
            if ((minLength <= 0) || (maxLength <= 0))
            {
                throw new ArgumentOutOfRangeException("params must be > 0");
            }
            if (maxLength < minLength)
            {
                throw new ArgumentOutOfRangeException("maxLength must be >= minLength");
            }
            int wordLength = WordString.Length;
            return ((wordLength >= minLength) && (wordLength <= maxLength));
        }

    }
}
