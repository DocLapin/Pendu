using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Pendu;

namespace Pendu
{
    /// <summary>
    /// Provides services to use output
    /// </summary>
    public interface IOutput
    {
        /// <summary>
        /// Show the main menu of the game
        /// </summary>
        void ShowMenu();

        /// <summary>
        /// Show the rules of the game
        /// </summary>
        /// <param name="r"></param>
        void ShowRules(Rules r);

        /// <summary>
        /// Show the word to find with hidden letters
        /// </summary>
        /// <param name="w"></param>
        void ShowWordState(Word w);

        /// <summary>
        /// Shows the character
        /// </summary>
        /// <param name="c"></param>
        void ShowCharacter(ICharacter character, int numcharacter);

        /// <summary>
        /// Tells the player that he lost
        /// </summary>
        void ShowLost();

        /// <summary>
        /// Tells the player that he has won
        /// </summary>
        void ShowWin();

        /// <summary>
        /// Asks if the player wants to reset the game
        /// </summary>
        void ShowReset();

        /// <summary>
        /// Shows the message when there is no more words
        /// </summary>
        void ShowNoMoreWords();
    }
}
