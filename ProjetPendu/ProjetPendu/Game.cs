using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using Pendu;

namespace Pendu
{
    /// <summary>
    /// Represents the game
    /// </summary>
    public class Game
    {

        #region Fields and Properties

        private Dictionary _dictionary;

        private IInput _input;

        private IOutput _output;

        private Rules _rules;

        private ICharacter _character;

        private IWordStorage _wordfilestorage;

        private int _nbErrors = 0;

        private bool _isWon = false;

        private bool _continuePlay = true;

        #endregion

        /// <summary>
        /// Game constructor with fields
        /// </summary>
        /// <param name="player"></param>
        /// <param name="dictionary"></param>
        /// <param name="input"></param>
        /// <param name="output"></param>
        /// <param name="rules"></param>
        /// <param name="character"></param>
        /// <param name="wordfilestorage"></param>
        public Game(IWordStorage wordfilestorage, Dictionary dictionary, IInput input, IOutput output, Rules rules, ICharacter character)
        {
            _dictionary = dictionary;
            _input = input;
            _output = output;
            _rules = rules;
            _character = character;
            _wordfilestorage = wordfilestorage;
        }

        /// <summary>
        /// Starts the game 
        /// </summary>
        public void Start()
        {
            while (_continuePlay)
            {
                _continuePlay = false;
                Word word = _dictionary.SelectAWord(_rules.MinLengthWord, _rules.MaxLengthWord);
                while (!IsFinished() && word != null)
                {
                    Play(word);
                }
                if (word == null)
                {
                    NoMoreWords();
                }
                else
                {
                    End();
                }
                Reset(word);
            }
        }

        /// <summary>
        /// Play to the game with a word to find
        /// </summary>
        /// <param name="word">The word to find</param>
        private void Play(Word word)
        {
            _dictionary.Remove(word);
            ShowMenu();
            string played = Ask();
            if (played.Equals(_rules.SymbolRules))
            {
                ShowRules();
            }
            else if (played.Equals(_rules.SymbolQuit))
            {
                Quit();
            }
            else
            {
                if (!word.Check(played))
                {
                    _nbErrors++;
                }
                else
                {
                    _isWon = word.IsFound();
                }
                
                ShowWordState(word);
                ShowNumberLetter(word);
                ShowCharacter(_nbErrors);
                
            }
        }

        /// <summary>
        /// Quits the game
        /// </summary>
        private void Quit()
        {
            System.Environment.Exit(1);
        }

        /// <summary>
        /// Manage situation when there is no more words
        /// </summary>
        private void NoMoreWords()
        {
            _output.ShowNoMoreWords();
            _dictionary.Words = _wordfilestorage.Load();
        }

        /// <summary>
        /// Reset the game
        /// </summary>
        /// <param name="word"></param>
        private void Reset(Word word)
        {
            _output.ShowReset();
            string response = Ask();
            if (response.Equals(_rules.SymbolReset))
            {
                _continuePlay = true;
                _isWon = false;
                _nbErrors = 0;
            }
        }

        /// <summary>
        /// Manage the end of the game
        /// </summary>
        private void End(Word word)
        {
            if (_isWon)
            {
                _output.ShowWin();
            }
            else
            {
                _output.ShowLost(word);
            }
        }

        /// <summary>
        /// Is the game finished ?
        /// </summary>
        /// <returns> True if the game is finished, false otherwise </returns>
        private bool IsFinished()
        {
            return ((_isWon == true) || (_nbErrors == _rules.MaxNbErrors));
        }

        #region Input and Output

        /// <summary>
        /// ShowS the rules
        /// </summary>
        private void ShowRules()
        {
            _output.ShowRules(_rules);
        }

        /// <summary>
        /// Shows the character with the appropriate state given by the number
        /// </summary>
        /// <param name="numcharacter">Number of the state to show</param>
        private void ShowCharacter(int numcharacter)
        {
            _output.ShowCharacter(_character, numcharacter);
        }

        /// <summary>
        /// Shows the word played
        /// </summary>
        private void ShowWordState(Word word)
        {
            _output.ShowWordState(word);
        }

        /// <summary>
        /// Shows the number of letters remainig
        /// </summary>
        private void ShowNumberLetter(Word word)
        {
            _output.ShowNumber(word);
        }

        /// <summary>
        /// What the player wants to input
        /// </summary>
        private string Ask()
        {
            return _input.Input();
        }

        /// <summary>
        /// Shows the menu
        /// </summary>
        private void ShowMenu()
        {
            _output.ShowMenu();
        }

        #endregion

    }
}
