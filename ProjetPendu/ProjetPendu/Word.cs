using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Pendu
{
    public class Word
    {
        private string _wordString;
        private bool[] _checkTable;
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
                _checkTable = new bool[word.Length];
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

        /// <summary>
        /// Get word state which represent the word
        /// with the found letters.
        /// * if the letter isn't found 
        /// [letter] otherwise. 
        /// </summary>
        /// <returns>the word state</returns>
        public string GetCurrentState()
        {
            string state = String.Empty;
            int length = WordString.Length;
            for (int i = 0; i < length; i++)
            {
                if (_checkTable[i])
                {
                    state = state + WordString.Substring(i, i);
                }
                else
                {
                    state = state + '*';
                }
            }
            return state;
        }

        public bool check(string word) 
        {
            char[] wordChar = WordString.ToCharArray();
            char[] messageChar = word.ToCharArray();
            if(word.Length == 1)
            {
                bool check = false;
                char letter = messageChar[0];
                for (int i = 0; i < wordChar.Length; i++)
                {
                    if (wordChar[i] == letter)
                    {
                        _checkTable[i] = true;
                        check = true;
                    }
                    // no else
                }
                return check;
            }
            else
            {
               return wordChar.Equals(messageChar);
            }
        }
    }
}
