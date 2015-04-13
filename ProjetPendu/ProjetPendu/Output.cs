using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Pendu;

namespace ProjetPendu
{
    public class OutputConsole : IOutput
    {
        /// <summary>
        /// Display the 
        /// </summary>
        /// <returns> Input pressed by the player</returns>
        public void ShowRules(Rules r)
        {
            Console.Write(r.GetRules());
        }

        public void ShowCharacter(ICharacter character, int numcharacter)
        {
        }

        public void ShowWord(Word w)
        {
            Console.WriteLine(w.GetCurrentState());
        }
    }
}
