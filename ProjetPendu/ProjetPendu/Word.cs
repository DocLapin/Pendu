using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Pendu
{
    public class Word
    {
        private char[] _wordToFind;
        private char[] _wordToFindUpper;
        private bool[] _checkTable;

        public string WordToFindString
        {
            get
            {
                return (new string(_wordToFind));
            }
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
                _wordToFind = word.ToCharArray();
                _wordToFindUpper = word.ToUpper().ToCharArray();
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
            int wordLength = _wordToFind.Length;
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
            for (int i = 0; i < _wordToFind.Length; i++)
            {
                if (_checkTable[i])
                {
                    state = state + _wordToFind[i];
                }
                else
                {
                    state = state + '*';
                }
            }
            return state;
        }

        public bool Check(string wordPlayed) 
        {
            char[] wordPlayedChar = wordPlayed.ToUpper().ToCharArray();
            if (wordPlayedChar.Length == 1)
            {
                return CheckLetter(wordPlayedChar[0]);
            }
            else
            {
                return CheckWord(wordPlayedChar);
            }
        }

        private bool CheckLetter(char letter)
        {
            bool check = false;
            for (int i = 0; i < _wordToFindUpper.Length; i++)
            {
                if (_wordToFindUpper[i] == letter)
                {
                    _checkTable[i] = true;
                    check = true;
                }
                // no else
            }
            return check;
        }

        private bool CheckWord(char[] wordPlayedChar)
        {
            if (_wordToFindUpper.SequenceEqual(wordPlayedChar))
            {
                for (int i = 0; i < _wordToFindUpper.Length; i++)
                {
                    _checkTable[i] = true;
                }
                return true;
            }
            // no else
            return false;
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

        public void Reset()
        {
            for (int i = 0; i < _checkTable.Length; ++i)
            {
                _checkTable[i] = false;
            }
        }
    }
}
