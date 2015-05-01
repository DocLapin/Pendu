using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Pendu;

namespace Pendu
{
    public class Game
    {

        #region Fields and Properties

        private Dictionary _dictionary;

        public Dictionary Dictionary
        {
            get { return _dictionary; }
            private set { _dictionary = value; }
        }

        private IInput _input;

        public IInput Input
        {
            get { return _input; }
            private set { _input = value; }
        }

        private IOutput _output;

        public IOutput Output
        {
            get { return _output; }
            private set { _output = value; }
        }

        private Rules _rules;

        public Rules Rules
        {
            get { return _rules; }
            private set { _rules = value; }
        }

        private ICharacter _character;

        public ICharacter Character
        {
            get { return _character; }
            private set { _character = value; }
        }

        private int _nbErrors = 0;

        public int NbErrors
        {
            get { return _nbErrors; }
            private set { _nbErrors = value; }
        }

        private bool _isWon = false;

        public bool IsWon
        {
            get { return _isWon; }
            private set { _isWon = value; }
        }

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
        public Game(Dictionary dictionary, IInput input, IOutput output, Rules rules, ICharacter character)
        {
            _dictionary = dictionary;
            _input = input;
            _output = output;
            _rules = rules;
            _character = character;
        }

        /// <summary>
        /// start the game 
        /// </summary>
        public void Play()
        {
            Word word = _dictionary.SelectAWord(Rules.MinLengthWord, Rules.MaxLengthWord);
            while (!IsFinished())
            {
                string played = Ask();
                if (!word.Check(played))
                {
                    NbErrors++;
                }
                else
                {
                    IsWon = word.IsFound();
                }
                ShowWord(word);
                ShowCharacter(NbErrors);
            }
            ShowCharacter(NbErrors);
        }

        /// <summary>
        /// Reset a new game
        /// </summary>
        private void Reset()
        {
            
        }

        /// <summary>
        /// ends the game
        /// </summary>
        private void Quit()
        {

        }

        /// <summary>
        /// Is the game finished ?
        /// </summary>
        /// <returns> True if the game is finished </returns>
        private bool IsFinished()
        {
            return ((IsWon == true) || (NbErrors == Rules.MaxNbErrors));
        }

        /// <summary>
        /// show the rules
        /// </summary>
        private void ShowRules()
        {
            Output.ShowRules(_rules);
        }

        /// <summary>
        /// show the letter played
        /// </summary>
        private void ShowCharacter(int numcharacter)
        {
            Output.ShowCharacter(Character, numcharacter);
        }

        /// <summary>
        /// show the word played
        /// </summary>
        private void ShowWord(Word word)
        {
            Output.ShowWord(word);
        }
        
        /// <summary>
        /// what the player wants to input
        /// </summary>
	    private string Ask()
        {
            return Input.Input();
        }
    }
}
