using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Pendu;

namespace ProjetPendu
{
    public class Game
    {

        private Player _player;
        private Dictionary _dictionary;
        private IInput _input;
        private IOutput _output;
        private Rules _rules;
        private ICharacter _character;

        private int _nbTry { get; private set; }

        /// <summary>
        /// Game constructor with fields
        /// </summary>
        /// <param name="player"></param>
        /// <param name="dictionary"></param>
        /// <param name="input"></param>
        /// <param name="output"></param>
        /// <param name="rules"></param>
        /// <param name="character"></param>
        public Game(Player player, Dictionary dictionary, IInput input, IOutput output, Rules rules, ICharacter character)
        {
            _player = player;
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
            _nbTry = 0;


                
        }

        /// <summary>
        /// Reset a new game
        /// </summary>
        private void Reset();

        /// <summary>
        /// ends the game
        /// </summary>
        private void Quit();

        /// <summary>
        /// Is the game finished ?
        /// </summary>
        /// <returns> True if the game is finished </returns>
        private bool IsFinished();

        /// <summary>
        /// show the rules
        /// </summary>
        private void ShowRules();

        /// <summary>
        /// show the letter played
        /// </summary>
        private void ShowCharacter();

        /// <summary>
        /// show the word played
        /// </summary>
        private void ShowWord();

        /// <summary>
        /// what the player wants to input
        /// </summary>
        private void Ask();
    }
}
