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
            char[] wordChar = WordString.ToCharArray();
            for (int i = 0; i < wordChar.Length; i++)
            {
                if (_checkTable[i])
                {
                    state = state + wordChar[i];
                }
                else
                {
                    state = state + '*';
                }
            }
            return state;
        }

        public bool Check(string word) 
        {
            bool check = false;
            char[] wordChar = WordString.ToUpper().ToCharArray();
            char[] playedChar = word.ToUpper().ToCharArray();
            if(word.Length == 1)
            {
                char letter = playedChar[0];
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
                if (Enumerable.SequenceEqual(wordChar, playedChar)) 
                {
                    for (int i = 0; i < wordChar.Length; i++)
                    {
                       _checkTable[i] = true;
                    }
                    check = true;
                }
                else
                {
                    check = false;
                }
            }
            return check;
        }

        public bool IsFound()
        {
            foreach (bool letterFound in _checkTable)
            {
                if (!letterFound)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
