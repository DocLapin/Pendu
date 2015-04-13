using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Pendu;

namespace ProjetPendu
{
    interface IOutput
    {
        /// <summary>
        /// Show the rules of the game
        /// </summary>
        /// <param name="r"></param>
        void ShowRules(Rules r);
        /// <summary>
        /// Show the word to find with the hidden letters
        /// </summary>
        /// <param name="w"></param>
        void ShowWord(Word w);

        /// <summary>
        /// Show the character
        /// </summary>
        /// <param name="c"></param>
        void ShowCharacter(ICharacter character, int numcharacter);
    }
}
